export interface NewResultProps {
  value: number;
  onSubmit: (e: React.FormEvent<HTMLFormElement>) => void;
  onChange: (e: React.ChangeEvent<HTMLInputElement>) => void;
}

export function NewResult({ onSubmit, onChange, value }: NewResultProps) {
  return (
    <div>
      <form onSubmit={onSubmit}>
        <input
          id="NewResult"
          name="NewResult"
          type="number"
          value={value}
          onChange={onChange}
        />
        <button type="submit">Set</button>
      </form>
    </div>
  );
}
