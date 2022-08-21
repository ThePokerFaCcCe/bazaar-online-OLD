import _ from "lodash";
import { UserDashboard } from "../types/type";

const paginate = (
  items: UserDashboard | [],
  pageNumber: number,
  pageSize: number
) => {
  const startIndex = (pageNumber - 1) * pageSize;
  return _(items).slice(startIndex).take(pageSize).value();
};

export default paginate;
