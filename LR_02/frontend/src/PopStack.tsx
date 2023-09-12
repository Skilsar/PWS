export interface PopStack {
  onSubmit: (e: React.FormEvent<HTMLFormElement>) => void;
}

export function PopStack({ onSubmit }: PopStack) {
  return (
    <div>
      <form onSubmit={onSubmit}>
        <button type="submit">Pop</button>
      </form>
    </div>
  );
}
