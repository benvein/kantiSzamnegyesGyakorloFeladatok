import express from "express";
import foursRoutes from "./routes/foursRoutes.js";

const PORT = 3000;
const app = express();

app.use(express.json());

app.use("/fours", foursRoutes);

app.listen(PORT, () => {
  console.log(`http://localhost:${PORT}`);
});
