import { useEffect, useState } from "react";
import "./App.css";
import type { Four } from "../types/Four";
import apiClient from "../apis/apiClient";

function AllFours() {
  const [fours, setFours] = useState<Four[]>([]);

  useEffect(() => {
    apiClient
      .get("/fours")
      .then((res) => setFours(res.data))
      .catch((err) => console.log(err));
  }, []);

  const generateContent = (f: Four) => {
    return (
      <>
        <p>
          [{f.first}, {f.second}, {f.third}, {f.fourth},]
        </p>
        <br />
      </>
    );
  };

  return <>{fours.map((i) => generateContent(i))}</>;
}

export default AllFours;
