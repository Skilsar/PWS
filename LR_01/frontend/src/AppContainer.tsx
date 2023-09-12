import { getResult, popStackFetch, postNewResult, pushStack } from "./api";
import { NewResult } from "./NewResult";
import { PopStack } from "./PopStack";
import { PushStack } from "./PushStack";
import Result from "./Result";
import { useCallback, useEffect, useState } from "react";
import { useMutation, useQuery, useQueryClient } from "react-query";

export default function AppContainer() {
  const [result, setResult] = useState("");
  const [newResult, setNewResult] = useState(0);
  const [pushValue, setPushValue] = useState(0);

  const queryClient = useQueryClient();

  const {
    data: resultData,
    isError: getResultIsError,
    error: getResultError,
    isSuccess,
    refetch,
  } = useQuery("result", getResult, { enabled: false });

  const onSuccess = useCallback(() => {
    queryClient.invalidateQueries();
    refetch();
  }, []);

  const postNewResultMutation = useMutation(() => postNewResult(newResult), {
    onSuccess,
  });

  const pushStackMutation = useMutation(() => pushStack(pushValue), {
    onSuccess,
  });

  const popStackMutation = useMutation(() => popStackFetch(), {
    onSuccess,
  });

  useEffect(() => {
    getResultIsError && console.log(getResultError);
  }, [getResultIsError, getResultError]);

  useEffect(() => {
    if (isSuccess) {
      const result = JSON.parse(JSON.stringify(resultData))["RESULT"];
      setResult(result);
    }
  }, [resultData, isSuccess]);

  useEffect(() => {
    refetch();
  }, []);

  return (
    <div>
      <Result result={result} />
      <NewResult
        onSubmit={(e) => {
          e.preventDefault();
          postNewResultMutation.mutate();
        }}
        value={newResult}
        onChange={(e) => {
          setNewResult(e.target.value as unknown as number);
        }}
      />
      <PushStack
        onSubmit={(e) => {
          e.preventDefault();
          pushStackMutation.mutate();
        }}
        value={pushValue}
        onChange={(e) => {
          setPushValue(e.target.value as unknown as number);
        }}
      />
      <PopStack
        onSubmit={(e) => {
          e.preventDefault();
          popStackMutation.mutate();
        }}
      />
    </div>
  );
}
