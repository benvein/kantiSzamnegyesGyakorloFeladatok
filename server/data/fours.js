import db from "./db.js";

db.prepare(
  `
    CREATE TABLE IF NOT EXISTS fours(
    index INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    first INTEGER NOT NULL,
    second INTEGER NOT NULL,
    third INTEGER NOT NULL,
    fourth INTEGER NOT NULL
    UNIQUE(first, second, third, fourth)
    )
    `,
).run();

export const getAllFours = () => db.prepare("SELECT * FROM fours").all();
export const getByIndex = (index) =>
  db.prepare("SELECT * FROM fours WHERE index = ?").get(index);
export const addFour = (first, second, third, fourth) =>
  db
    .prepare("INSERT INTO fours (first, second, third, fourth) VALUES(?,?,?,?)")
    .run(first, second, third, fourth);
