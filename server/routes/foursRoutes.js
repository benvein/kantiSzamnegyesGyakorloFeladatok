import express from "express";
import * as db from "./data/fours.js";

const router = express.Router();

router.get("/fours", (req,res)=>{
    const fours = db.getAllFours();
    res.status(200).json(fours);
});

router.get("/fours/:id", (req,res)=>{
    const four = db.getByIndex(+req.params.id);
    if(!four){
        return res.status(404).json({message: "not found"});
    }

    res.status(200).json(four);
});

router.post("/fours", (req,res) => {
    const { numbers } = req.body;

  if (
    !Array.isArray(numbers) ||
    numbers.length !== 4 ||
    !numbers.every(n => Number.isInteger(n))
  ) {
    return res.status(400).send("Invalid data");
  }

  try {
    const result = db.addFour(...numbers)

    res.json({
      id: result.lastInsertRowid,
      numbers
    });
  } catch (err) {
    if (err.code === "SQLITE_CONSTRAINT_UNIQUE") {
      return res.status(409).send("Already exists");
    }
    res.status(500).send("Server error");
  }

});

export default router;