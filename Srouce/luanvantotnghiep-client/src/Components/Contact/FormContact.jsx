import React from 'react'
import { useHistory } from "react-router-dom";
import { useForm, Form } from '../../hooks/useForm';

const initialFValues = {
    hoTen: '',
    sdt: '',
    diaChi: '',
    email: '',
    noiDung: ''
}

const FormContact = (props) => {
    const { Contact } = props;
    const history = useHistory();

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
                temp.email = ""
            } else {
                temp.email = "Email sai định dạng"
            }
        }

        if ('diaChi' in fieldValues)
            temp.diaChi = fieldValues.diaChi ? "" : "Trường này không được rỗng"
        if ('noiDung' in fieldValues)
            temp.noiDung = fieldValues.noiDung ? "" : "Trường này không được rỗng"
        console.log(fieldValues)
        setErrors({
            ...temp
        })
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
    const handleSubmitConact = e => {
        e.preventDefault()
        if (validate()) {
            const FormContact = new FormData()
            FormContact.append('hoTen', values.hoTen)
            FormContact.append('sdt', values.sdt)
            FormContact.append('diaChi', values.diaChi)
            FormContact.append('email', values.email)
            FormContact.append('noiDung', values.noiDung)
            Contact(FormContact, resetForm);
        }
    }

    return (
        <form onSubmit={handleSubmitConact} encType="multipart/form-data">
            <div className="form-fields">
                <div className="form-group row">
                    <div className="col-md-6">
                        <input className="form-control"
                            style={{ textTransform: 'lowercase' }}
                            name="hoTen"
                            value={values.hoTen}
                            onChange={handleInputChange}
                            autoComplete="off"
                            error={errors.hoTen}
                            placeholder="Họ và tên" />
                        <small style={{ color: 'red' }}>{errors.hoTen}</small>
                    </div>
                    <div className="col-md-6 margin-bottom-mobie">
                        <input className="form-control"
                            name="sdt"
                            type="text"
                            style={{ textTransform: 'lowercase' }}
                            value={values.sdt}
                            onChange={handleInputChange}
                            autoComplete="off"
                            error={errors.sdt}
                            placeholder="Số điện thoại" />
                        <small style={{ color: 'red' }}>{errors.sdt}</small>
                    </div>
                </div>
                <div className="form-group row">
                    <div className="col-md-12 margin-bottom-mobie">
                        <input className="form-control"
                            name="email"
                            style={{ textTransform: 'lowercase' }}
                            value={values.email}
                            onChange={handleInputChange}
                            autoComplete="off"
                            error={errors.email}
                            placeholder="Địa chỉ Email"
                            type="email" />
                        <small style={{ color: 'red' }}>{errors.email}</small>
                    </div>
                </div>
                <div className="form-group row">
                    <div className="col-md-12">
                        <textarea className="form-control"
                            name="diaChi"
                            style={{ textTransform: 'lowercase' }}
                            value={values.diaChi}
                            onChange={handleInputChange}
                            autoComplete="off"
                            error={errors.diaChi}
                            placeholder="Địa chỉ hiện tại"
                            rows={3} />
                        <small style={{ color: 'red' }}>{errors.diaChi}</small>
                    </div>
                </div>
                <div className="form-group row">
                    <div className="col-md-12">
                        <textarea className="form-control"
                            name="noiDung"
                            style={{ textTransform: 'lowercase' }}
                            value={values.noiDung}
                            onChange={handleInputChange}
                            autoComplete="off"
                            error={errors.noiDung}
                            placeholder="Nội dung liên hệ"
                            rows={8} />
                        <small style={{ color: 'red' }}>{errors.noiDung}</small>
                    </div>
                </div>
            </div>
            <div>
                <button className="btn" type="submit" name="submitMessage">
                    <img className="img-fl" src="img/other/contact_email.png" alt="img" />Gữi tin nhắn
                </button>
            </div>
        </form>
    );
};

export default FormContact;