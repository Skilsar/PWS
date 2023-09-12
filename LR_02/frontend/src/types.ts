export interface GetResultDto {
  Result: number;
}

export interface SetResultDto extends GetResultDto {}

export interface PushValueToStack {
  Add: number;
}
