import $ from "jquery";

const BASE_URL = "http://localhost:8092/api/result";

const query = (params: any) =>
  new Promise((resolve, reject) => {
    $.ajax({
      ...params,
      xhrFields: { withCredentials: true },
      success: (result: any) => resolve(result),
      error: () => reject(),
    });
  });

export const getResult = () =>
  query({ url: `${BASE_URL}`, type: "GET" }).then((res: any) => {
    return res;
  });

export const postNewResult = (value: number) =>
  query({
    url: `${BASE_URL}?result=${value}`,
    type: "POST",
  }).then((res: any) => res);

export const pushStack = (value: number) =>
  query({
    url: `${BASE_URL}?add=${value}`,
    type: "PUT",
  }).then((res: any) => res);

export const popStackFetch = () =>
  query({
    url: `${BASE_URL}`,
    type: "DELETE",
  }).then((res: any) => res);
