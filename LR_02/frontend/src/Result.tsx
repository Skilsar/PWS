export interface ResultProps {
  result: string | number;
}

export default function Result({ result }: ResultProps) {
  return (
    <div>
      <h3>Result: {result}</h3>
    </div>
  );
}
