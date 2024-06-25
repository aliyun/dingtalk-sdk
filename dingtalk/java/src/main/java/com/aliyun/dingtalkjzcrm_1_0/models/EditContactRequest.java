// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditContactRequest extends TeaModel {
    @NameInMap("data")
    public EditContactRequestData data;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>197</p>
     */
    @NameInMap("datatype")
    public Long datatype;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("msgid")
    public Long msgid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1621822122</p>
     */
    @NameInMap("stamp")
    public Long stamp;

    public static EditContactRequest build(java.util.Map<String, ?> map) throws Exception {
        EditContactRequest self = new EditContactRequest();
        return TeaModel.build(map, self);
    }

    public EditContactRequest setData(EditContactRequestData data) {
        this.data = data;
        return this;
    }
    public EditContactRequestData getData() {
        return this.data;
    }

    public EditContactRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditContactRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditContactRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public static class EditContactRequestData extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>张三</p>
         * 
         * <strong>if can be null:</strong>
         * <p>false</p>
         */
        @NameInMap("data_userid")
        public String dataUserid;

        @NameInMap("lxr_address")
        public String lxrAddress;

        @NameInMap("lxr_birthday")
        public String lxrBirthday;

        @NameInMap("lxr_chengwei")
        public String lxrChengwei;

        @NameInMap("lxr_ctnumber")
        public String lxrCtnumber;

        @NameInMap("lxr_cttype")
        public String lxrCttype;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("lxr_customerid")
        public String lxrCustomerid;

        @NameInMap("lxr_department")
        public String lxrDepartment;

        @NameInMap("lxr_dingtalk")
        public String lxrDingtalk;

        @NameInMap("lxr_email")
        public String lxrEmail;

        @NameInMap("lxr_fax")
        public String lxrFax;

        @NameInMap("lxr_group")
        public String lxrGroup;

        @NameInMap("lxr_handset")
        public String lxrHandset;

        @NameInMap("lxr_headship")
        public String lxrHeadship;

        @NameInMap("lxr_like")
        public String lxrLike;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("lxr_name")
        public String lxrName;

        @NameInMap("lxr_photo")
        public String lxrPhoto;

        @NameInMap("lxr_preside")
        public String lxrPreside;

        @NameInMap("lxr_pst")
        public String lxrPst;

        @NameInMap("lxr_qq")
        public String lxrQq;

        @NameInMap("lxr_remark")
        public String lxrRemark;

        @NameInMap("lxr_sex")
        public String lxrSex;

        @NameInMap("lxr_skype")
        public String lxrSkype;

        @NameInMap("lxr_tel")
        public String lxrTel;

        @NameInMap("lxr_type")
        public String lxrType;

        @NameInMap("lxr_wangwang")
        public String lxrWangwang;

        @NameInMap("lxr_weixin")
        public String lxrWeixin;

        @NameInMap("lxr_worktel")
        public String lxrWorktel;

        public static EditContactRequestData build(java.util.Map<String, ?> map) throws Exception {
            EditContactRequestData self = new EditContactRequestData();
            return TeaModel.build(map, self);
        }

        public EditContactRequestData setDataUserid(String dataUserid) {
            this.dataUserid = dataUserid;
            return this;
        }
        public String getDataUserid() {
            return this.dataUserid;
        }

        public EditContactRequestData setLxrAddress(String lxrAddress) {
            this.lxrAddress = lxrAddress;
            return this;
        }
        public String getLxrAddress() {
            return this.lxrAddress;
        }

        public EditContactRequestData setLxrBirthday(String lxrBirthday) {
            this.lxrBirthday = lxrBirthday;
            return this;
        }
        public String getLxrBirthday() {
            return this.lxrBirthday;
        }

        public EditContactRequestData setLxrChengwei(String lxrChengwei) {
            this.lxrChengwei = lxrChengwei;
            return this;
        }
        public String getLxrChengwei() {
            return this.lxrChengwei;
        }

        public EditContactRequestData setLxrCtnumber(String lxrCtnumber) {
            this.lxrCtnumber = lxrCtnumber;
            return this;
        }
        public String getLxrCtnumber() {
            return this.lxrCtnumber;
        }

        public EditContactRequestData setLxrCttype(String lxrCttype) {
            this.lxrCttype = lxrCttype;
            return this;
        }
        public String getLxrCttype() {
            return this.lxrCttype;
        }

        public EditContactRequestData setLxrCustomerid(String lxrCustomerid) {
            this.lxrCustomerid = lxrCustomerid;
            return this;
        }
        public String getLxrCustomerid() {
            return this.lxrCustomerid;
        }

        public EditContactRequestData setLxrDepartment(String lxrDepartment) {
            this.lxrDepartment = lxrDepartment;
            return this;
        }
        public String getLxrDepartment() {
            return this.lxrDepartment;
        }

        public EditContactRequestData setLxrDingtalk(String lxrDingtalk) {
            this.lxrDingtalk = lxrDingtalk;
            return this;
        }
        public String getLxrDingtalk() {
            return this.lxrDingtalk;
        }

        public EditContactRequestData setLxrEmail(String lxrEmail) {
            this.lxrEmail = lxrEmail;
            return this;
        }
        public String getLxrEmail() {
            return this.lxrEmail;
        }

        public EditContactRequestData setLxrFax(String lxrFax) {
            this.lxrFax = lxrFax;
            return this;
        }
        public String getLxrFax() {
            return this.lxrFax;
        }

        public EditContactRequestData setLxrGroup(String lxrGroup) {
            this.lxrGroup = lxrGroup;
            return this;
        }
        public String getLxrGroup() {
            return this.lxrGroup;
        }

        public EditContactRequestData setLxrHandset(String lxrHandset) {
            this.lxrHandset = lxrHandset;
            return this;
        }
        public String getLxrHandset() {
            return this.lxrHandset;
        }

        public EditContactRequestData setLxrHeadship(String lxrHeadship) {
            this.lxrHeadship = lxrHeadship;
            return this;
        }
        public String getLxrHeadship() {
            return this.lxrHeadship;
        }

        public EditContactRequestData setLxrLike(String lxrLike) {
            this.lxrLike = lxrLike;
            return this;
        }
        public String getLxrLike() {
            return this.lxrLike;
        }

        public EditContactRequestData setLxrName(String lxrName) {
            this.lxrName = lxrName;
            return this;
        }
        public String getLxrName() {
            return this.lxrName;
        }

        public EditContactRequestData setLxrPhoto(String lxrPhoto) {
            this.lxrPhoto = lxrPhoto;
            return this;
        }
        public String getLxrPhoto() {
            return this.lxrPhoto;
        }

        public EditContactRequestData setLxrPreside(String lxrPreside) {
            this.lxrPreside = lxrPreside;
            return this;
        }
        public String getLxrPreside() {
            return this.lxrPreside;
        }

        public EditContactRequestData setLxrPst(String lxrPst) {
            this.lxrPst = lxrPst;
            return this;
        }
        public String getLxrPst() {
            return this.lxrPst;
        }

        public EditContactRequestData setLxrQq(String lxrQq) {
            this.lxrQq = lxrQq;
            return this;
        }
        public String getLxrQq() {
            return this.lxrQq;
        }

        public EditContactRequestData setLxrRemark(String lxrRemark) {
            this.lxrRemark = lxrRemark;
            return this;
        }
        public String getLxrRemark() {
            return this.lxrRemark;
        }

        public EditContactRequestData setLxrSex(String lxrSex) {
            this.lxrSex = lxrSex;
            return this;
        }
        public String getLxrSex() {
            return this.lxrSex;
        }

        public EditContactRequestData setLxrSkype(String lxrSkype) {
            this.lxrSkype = lxrSkype;
            return this;
        }
        public String getLxrSkype() {
            return this.lxrSkype;
        }

        public EditContactRequestData setLxrTel(String lxrTel) {
            this.lxrTel = lxrTel;
            return this;
        }
        public String getLxrTel() {
            return this.lxrTel;
        }

        public EditContactRequestData setLxrType(String lxrType) {
            this.lxrType = lxrType;
            return this;
        }
        public String getLxrType() {
            return this.lxrType;
        }

        public EditContactRequestData setLxrWangwang(String lxrWangwang) {
            this.lxrWangwang = lxrWangwang;
            return this;
        }
        public String getLxrWangwang() {
            return this.lxrWangwang;
        }

        public EditContactRequestData setLxrWeixin(String lxrWeixin) {
            this.lxrWeixin = lxrWeixin;
            return this;
        }
        public String getLxrWeixin() {
            return this.lxrWeixin;
        }

        public EditContactRequestData setLxrWorktel(String lxrWorktel) {
            this.lxrWorktel = lxrWorktel;
            return this;
        }
        public String getLxrWorktel() {
            return this.lxrWorktel;
        }

    }

}
