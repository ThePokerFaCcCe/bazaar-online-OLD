import { useState } from "react";
import { IconButton, Box, Grid, Button } from "@mui/material";
import {
  Menu,
  Home,
  MarkunreadMailboxOutlined,
  Close,
  PeopleOutlined,
  Search,
  PeopleOutline,
} from "@mui/icons-material";
import { Input } from "antd";
import { Sidebar } from "primereact/sidebar";
import { NavItems, Store } from "../../../types/type";
import Link from "next/link";
import styles from "../../../styles/NavBar.module.css";
import { useSelector, useDispatch } from "react-redux";
import { mobileMenuToggle } from "../../../store/state/ui";
import Logo from "./logo";

const navItems: NavItems = [
  { title: "خانه", icon: <Home className={styles.navbar__icon} /> },
  { title: "ورود | ثبت نام", icon: <PeopleOutline /> },
  {
    title: "آگهی ها",
    icon: <MarkunreadMailboxOutlined className={styles.navbar__icon} />,
  },
  {
    title: "درباره ما",
    icon: <PeopleOutlined className={styles.navbar__icon} />,
  },
];

const MobileNavBar = (): JSX.Element => {
  // Redux Setup
  const dispatch = useDispatch();

  const { mobileMenuVisible } = useSelector(
    (state: Store) => state.entities.ui.navbar
  );
  // Render
  return (
    <>
      <Box className={styles.mobile__nav}>
        <IconButton onClick={() => dispatch(mobileMenuToggle())}>
          <Menu />
        </IconButton>
        <div style={{ cursor: "pointer" }}>
          <Link href="/">
            <Logo />
          </Link>
        </div>
        <Link href="/ad/new">
          <Button className={styles.navbar__btn} variant="contained">
            ثبت آگهی
          </Button>
        </Link>
      </Box>
      <Sidebar
        icons={() => (
          <Close
            sx={{ cursor: "pointer" }}
            onClick={() => dispatch(mobileMenuToggle())}
          />
        )}
        showCloseIcon={false}
        position="right"
        visible={mobileMenuVisible}
        onHide={() => dispatch(mobileMenuToggle())}
      >
        <Box className={styles.navbar__drawer}>
          {navItems.map((item, index) => (
            <Box
              sx={{ fontWeight: "500" }}
              key={index}
              className="w-100 border-bottom p-3"
            >
              <Grid container spacing={2} direction="row" alignItems="center">
                <Grid item>{item.icon}</Grid>
                <Grid item>
                  <a className={styles.navbar__title}>{item.title}</a>
                </Grid>
              </Grid>
            </Box>
          ))}
          <Box sx={{ fontWeight: "500" }} className="w-100 border-bottom p-3">
            <label className="pb-2">جستجو</label>
            <Input
              className={styles.search__input}
              size="large"
              placeholder="جستجو در همه آگهی ها"
              prefix={<Search sx={{ color: "#BCBCBC" }} />}
            />
          </Box>
        </Box>
      </Sidebar>
    </>
  );
};

export default MobileNavBar;
