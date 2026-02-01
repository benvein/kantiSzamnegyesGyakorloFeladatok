import { useState } from "react";
import type { Four } from "../types/Four";
import apiClient from "../apis/apiClient";
import { Button, Form } from "react-bootstrap";

const AddFour = () => {
  const [four, setFour] = useState<Four>({
    first: 0,
    second: 0,
    third: 0,
    fourth: 0,
  });

  const submit = () => {
    const dto: Four = {
      first: four.first,
      second: four.second,
      third: four.third,
      fourth: four.fourth,
    };

    apiClient
      .post("/fours", dto)
      .then((res) => console.log(res))
      .catch((err) => console.log(err));
  };

  return (
    <>
      <Form>
        <Form.Group className="mb-3" controlId="first">
          <Form.Label>Első</Form.Label>
          <Form.Control
            type="number"
            placeholder="1"
            onChange={(e) =>
              setFour({ ...four, first: Number(e.target.value) })
            }
          />
        </Form.Group>

        <Form.Group className="mb-3" controlId="second">
          <Form.Label>Második</Form.Label>
          <Form.Control
            type="number"
            placeholder="1"
            onChange={(e) =>
              setFour({ ...four, second: Number(e.target.value) })
            }
          />
        </Form.Group>

        <Form.Group className="mb-3" controlId="third">
          <Form.Label>Harmadik</Form.Label>
          <Form.Control
            type="number"
            placeholder="1"
            onChange={(e) =>
              setFour({ ...four, third: Number(e.target.value) })
            }
          />
        </Form.Group>

        <Form.Group className="mb-3" controlId="fourth">
          <Form.Label>Negyedik</Form.Label>
          <Form.Control
            type="number"
            placeholder="1"
            onChange={(e) =>
              setFour({ ...four, fourth: Number(e.target.value) })
            }
          />
        </Form.Group>
        <Button variant="primary" type="submit" onClick={submit}>
          hozzáad
        </Button>
      </Form>
    </>
  );
};

export default AddFour;
