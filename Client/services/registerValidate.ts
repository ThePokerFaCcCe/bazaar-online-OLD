import * as Yup from "yup";

const registerSchema = Yup.object({
  firstName: Yup.string()
    .required("فیلد نام نمیتواند خالی باشد")
    .min(2, "نام نمیتواند کمتر از 2 کاراکتر باشد")
    .max(32, "فیلد نام نمیتواند بیشتر از 32 کاراکتر باشد"),
  lastName: Yup.string()
    .required("فیلد نام خانوادگی نمیتواند خالی باشد")
    .min(2, "نام خانوادگی نمیتواند کمتر از 2 کاراکتر باشد")
    .max(32, "نام خانوادگی نمیتواند کمتر از 32 کاراکتر باشد"),
  email: Yup.string()
    .required("فیلد ایمیل نمیتواند خالی باشد")
    .max(100, "ایمیل نمیتواند بیشتر از 100 کاراکتر باشد")
    .email("یک ایمیل معتبر وارد کنید"),
  phoneNumber: Yup.string()
    .min(11, "شماره موبایل نمیتواند کمتر از 11 عدد باشد")
    .max(11, "شماره موبایل نمیتواند بیشتر از 11 عدد باشد"),
  password: Yup.string()
    .min(6, "رمز باید حداقل 6 رقم باشد")
    .required("فیلد کلمه عبور نمیتواند خالی باشد"),
});

export default registerSchema;
