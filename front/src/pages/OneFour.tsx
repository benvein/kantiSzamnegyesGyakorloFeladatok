import { useParams } from "react-router-dom";
import type { Four } from "../types/Four";
import { useEffect, useState } from "react";
import apiClient from "../apis/apiClient";

const OneFour = () => {
  const { id } = useParams();
  const [four, setFour] = useState<Four>();

  useEffect(() => {
    apiClient
      .get(`/fours/${id}`)
      .then((res) => setFour(res.data))
      .catch((err) => console.log(err));
  }, []);

  return (
    <>
      <p>
        [{four?.first}, {four?.second}, {four?.third}, {four?.fourth},]
      </p>
      <br />
    </>
  );
};

export default OneFour;
