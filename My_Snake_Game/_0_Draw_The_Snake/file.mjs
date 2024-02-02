import * as fsPromises from "fs/promises";
import * as path from "path";

any();
async function any() {
  const const1 = await fsPromises.readFile("./Snake_Parts.cs", "utf-8");
  console.log(JSON.stringify(const1));
}
