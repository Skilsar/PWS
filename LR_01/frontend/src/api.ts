export const getResult = () =>
  fetch("http://192.168.127.191:8095/result.vsa", {
    credentials: "include",
  }).then((res) => res.json());

export const postNewResult = (value: number) =>
  fetch(`http://192.168.127.191:8095/result.vsa?RESULT=${value}`, {
    method: "POST",
    credentials: "include",
  }).then((res) => res);

export const pushStack = (value: number) =>
  fetch(`http://192.168.127.191:8095/result.vsa?ADD=${value}`, {
    method: "PUT",
    credentials: "include",
  }).then((res) => res);

export const popStackFetch = () =>
  fetch(`http://192.168.127.191:8095/result.vsa`, {
    method: "DELETE",
    credentials: "include",
  }).then((res) => res);
