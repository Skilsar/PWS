import { NewResultProps } from "./NewResult";

export interface PushStackProps extends NewResultProps {}

export function PushStack({ onSubmit, onChange, value }: PushStackProps) {
  return (
    <div>
      <form onSubmit={onSubmit}>
        <input
          id="PushStack"
          name="PushStack"
          type="number"
          value={value}
          onChange={onChange}
        />
        <button type="submit">Push</button>
      </form>
    </div>
  );
}
