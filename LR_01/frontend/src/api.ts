export const getResult = () =>
  fetch("http://127.0.0.1:8091/result.vsa", {
    credentials: "include",
  }).then((res) => res.json());

export const postNewResult = (value: number) =>
  fetch(`http://127.0.0.1:8091/result.vsa?RESULT=${value}`, {
    method: "POST",
    credentials: "include",
  }).then((res) => res);

export const pushStack = (value: number) =>
  fetch(`http://127.0.0.1:8091/result.vsa?ADD=${value}`, {
    method: "PUT",
    credentials: "include",
  }).then((res) => res);

export const popStackFetch = () =>
  fetch(`http://127.0.0.1:8091/result.vsa`, {
    method: "DELETE",
    credentials: "include",
  }).then((res) => res);
