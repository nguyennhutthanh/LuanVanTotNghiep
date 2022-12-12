import React from 'react';
import { useForm, Form } from '../../hooks/useForm';
import { useHistory } from "react-router-dom";

const initialFValues = {
  idKhach: 0,
  hoTen: '',
  sdt: '',
  diaChi: '',
  email: '',
  userName: '',
  passWp: '',
}

const Register = (props) => {
  const { AddUser } = props;
  let history = useHistory();

  const validate = (fieldValues = values) => {
    let temp = { ...errors }
    if ('hoTen' in fieldValues) {
      const regexp = /^([^0-9]*)$/;
      const checkingResult = regexp.exec(fieldValues.hoTen);
      if (fieldValues.hoTen == "") {
        temp.hoTen = "Trường này không được rỗng"
      } else if (checkingResult !== null) {
        temp.hoTen = "";
      } else {
        temp.hoTen = 'Tên không được nhập số'
      }
    }
    if ('sdt' in fieldValues) {
      const regexp = /^\d{10,11}$/;
      const regexChar = /^([^a-zA-Z]*)$/;
      const checkingResult = regexp.exec(fieldValues.sdt);
      const checkingChar = regexChar.exec(fieldValues.sdt);
      if (fieldValues.sdt == "") {
        temp.sdt = "Trường này không được rỗng";
      } else if (checkingChar == null) {
        temp.sdt = 'số điện thoại không được nhập ký tự'
      }
      else if (checkingResult == null) {
        temp.sdt = 'Số điện thoại phải có 10 hoặc 11 số.'
      } else {
        temp.sdt = "";
      }
    }
    if ('email' in fieldValues) {
      const regexEmail = /^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/g;
      const checkingEmail = regexEmail.exec(fieldValues.email);
      if (fieldValues.email == "") {
        temp.email = "Trường này không được rỗng"
      } else if (checkingEmail !== null) {
        temp.email = " "
      } else {
        temp.email = "Email sai định dạng"
      }
    }
    if ('userName' in fieldValues)
      temp.userName = fieldValues.userName ? "" : "Trường này không được rỗng"
    if ('passWp' in fieldValues)
      temp.passWp = fieldValues.passWp ? "" : "Trường này không được rỗng"
    if ('diaChi' in fieldValues)
      temp.diaChi = fieldValues.diaChi ? "" : "Trường này không được rỗng"
    setErrors({
      ...temp
    })
    console.log(fieldValues)
    if (fieldValues == values)
      return Object.values(temp).every(x => x == "")
  }

  const {
    values, setValues,
    errors, setErrors,
    handleInputChange,
    resetForm
  } = useForm(initialFValues, true, validate);

  console.log(values)
  const handleSubmitUser = e => {
    e.preventDefault()
    if (validate()) {
      const FormDataUser = new FormData()
      FormDataUser.append('idKhach', values.idKhach)
      FormDataUser.append('hoTen', values.hoTen)
      FormDataUser.append('diaChi', values.diaChi)
      FormDataUser.append('sdt', values.sdt)
      FormDataUser.append('email', values.email)
      FormDataUser.append('userName', values.userName)
      FormDataUser.append('passWp', values.passWp)
      AddUser(FormDataUser, resetForm);
      history.push("/Login")
    }
  }

  return (
    <form onSubmit={handleSubmitUser} id="customer-form" className="js-customer-form">
      <div>
        <div className="form-group">
          <div>
            <input className="form-control"
              name="hoTen" type="text"
              placeholder="Họ và tên"
              autoComplete="off"
              value={values.hoTen}
              onChange={handleInputChange}
              error={errors.hoTen}
            />
            <small style={{ color: 'red' }}>{errors.hoTen}</small>
          </div>
        </div>
        <div className="form-group">
          <div>
            <input className="form-control"
              name="sdt" type="text"
              placeholder="Số điện thoại"
              autoComplete="off"
              value={values.sdt}
              onChange={handleInputChange}
              error={errors.sdt}
            />
            <small style={{ color: 'red' }}>{errors.sdt}</small>
          </div>
        </div>
        <div className="form-group">
          <div>
            <input className="form-control"
              name="email" type="email"
              placeholder="Email"
              autoComplete="off"
              value={values.email}
              onChange={handleInputChange}
              error={errors.email}
            />
            <small style={{ color: 'red' }}>{errors.email}</small>
          </div>
        </div>
        <div className="form-group">
          <div>
            <input className="form-control"
              name="userName" type="text"
              placeholder="Tên tài khoản"
              autoComplete="off"
              value={values.userName}
              onChange={handleInputChange}
              error={errors.userName}
            />
            <small style={{ color: 'red' }}>{errors.userName}</small>
          </div>
        </div>
        <div className="form-group">
          <div>
            <div className="input-group">
              <input className="form-control js-child-focus js-visible-password"
                name="passWp" type="password"
                placeholder="Password"
                autoComplete="off"
                value={values.passWp}
                onChange={handleInputChange}
                error={errors.passWp}
              />
            </div>
            <small style={{ color: 'red' }}>{errors.passWp}</small>
          </div>
        </div>
        <textarea className="form-control js-child-focus js-visible"
          placeholder="Địa chỉ"
          name="diaChi" rows={5}
          autoComplete="off"
          value={values.diaChi}
          onChange={handleInputChange}
          error={errors.diaChi}
        />
        <small style={{ color: 'red' }}>{errors.diaChi}</small>
      </div>
      <div className="clearfix">
        <div>
          <button className="btn btn-primary" type="submit">
            Tạo tài khoản
          </button>
        </div>
      </div>
    </form>
  );
};

export default Register;