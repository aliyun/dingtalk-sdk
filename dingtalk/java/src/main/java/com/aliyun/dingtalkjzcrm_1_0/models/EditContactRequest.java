// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditContactRequest extends TeaModel {
    // 数据类型，固定填写197
    @NameInMap("datatype")
    public Long datatype;

    // 时间戳
    @NameInMap("stamp")
    public Long stamp;

    // 数据id，不填或者填0为新增数据
    @NameInMap("msgid")
    public Long msgid;

    // 编辑数据
    @NameInMap("data")
    public EditContactRequestData data;

    public static EditContactRequest build(java.util.Map<String, ?> map) throws Exception {
        EditContactRequest self = new EditContactRequest();
        return TeaModel.build(map, self);
    }

    public EditContactRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditContactRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public EditContactRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditContactRequest setData(EditContactRequestData data) {
        this.data = data;
        return this;
    }
    public EditContactRequestData getData() {
        return this.data;
    }

    public static class EditContactRequestData extends TeaModel {
        // 创建人
        @NameInMap("data_userid")
        public String dataUserid;

        // 对应客户
        @NameInMap("lxr_customerid")
        public String lxrCustomerid;

        // 姓名
        @NameInMap("lxr_name")
        public String lxrName;

        // 手机
        @NameInMap("lxr_handset")
        public String lxrHandset;

        // 工作电话
        @NameInMap("lxr_worktel")
        public String lxrWorktel;

        // 性别（男，女）
        @NameInMap("lxr_sex")
        public String lxrSex;

        // 分类
        @NameInMap("lxr_group")
        public String lxrGroup;

        // 负责业务
        @NameInMap("lxr_preside")
        public String lxrPreside;

        // 证件类型
        @NameInMap("lxr_cttype")
        public String lxrCttype;

        // 证件号码
        @NameInMap("lxr_ctnumber")
        public String lxrCtnumber;

        // 称谓
        @NameInMap("lxr_chengwei")
        public String lxrChengwei;

        // 类型（联系人，主联系人）
        @NameInMap("lxr_type")
        public String lxrType;

        // 部门
        @NameInMap("lxr_department")
        public String lxrDepartment;

        // 职务
        @NameInMap("lxr_headship")
        public String lxrHeadship;

        // 钉钉号
        @NameInMap("lxr_dingtalk")
        public String lxrDingtalk;

        // 传真
        @NameInMap("lxr_fax")
        public String lxrFax;

        // 旺旺
        @NameInMap("lxr_wangwang")
        public String lxrWangwang;

        // Email
        @NameInMap("lxr_email")
        public String lxrEmail;

        // 微信号
        @NameInMap("lxr_weixin")
        public String lxrWeixin;

        // QQ
        @NameInMap("lxr_qq")
        public String lxrQq;

        // 家庭电话
        @NameInMap("lxr_tel")
        public String lxrTel;

        // 邮编
        @NameInMap("lxr_pst")
        public String lxrPst;

        // Skype
        @NameInMap("lxr_skype")
        public String lxrSkype;

        // 住址
        @NameInMap("lxr_address")
        public String lxrAddress;

        // 生日
        @NameInMap("lxr_birthday")
        public String lxrBirthday;

        // 爱好
        @NameInMap("lxr_like")
        public String lxrLike;

        // 备注
        @NameInMap("lxr_remark")
        public String lxrRemark;

        // 联系名片
        @NameInMap("lxr_photo")
        public String lxrPhoto;

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

        public EditContactRequestData setLxrCustomerid(String lxrCustomerid) {
            this.lxrCustomerid = lxrCustomerid;
            return this;
        }
        public String getLxrCustomerid() {
            return this.lxrCustomerid;
        }

        public EditContactRequestData setLxrName(String lxrName) {
            this.lxrName = lxrName;
            return this;
        }
        public String getLxrName() {
            return this.lxrName;
        }

        public EditContactRequestData setLxrHandset(String lxrHandset) {
            this.lxrHandset = lxrHandset;
            return this;
        }
        public String getLxrHandset() {
            return this.lxrHandset;
        }

        public EditContactRequestData setLxrWorktel(String lxrWorktel) {
            this.lxrWorktel = lxrWorktel;
            return this;
        }
        public String getLxrWorktel() {
            return this.lxrWorktel;
        }

        public EditContactRequestData setLxrSex(String lxrSex) {
            this.lxrSex = lxrSex;
            return this;
        }
        public String getLxrSex() {
            return this.lxrSex;
        }

        public EditContactRequestData setLxrGroup(String lxrGroup) {
            this.lxrGroup = lxrGroup;
            return this;
        }
        public String getLxrGroup() {
            return this.lxrGroup;
        }

        public EditContactRequestData setLxrPreside(String lxrPreside) {
            this.lxrPreside = lxrPreside;
            return this;
        }
        public String getLxrPreside() {
            return this.lxrPreside;
        }

        public EditContactRequestData setLxrCttype(String lxrCttype) {
            this.lxrCttype = lxrCttype;
            return this;
        }
        public String getLxrCttype() {
            return this.lxrCttype;
        }

        public EditContactRequestData setLxrCtnumber(String lxrCtnumber) {
            this.lxrCtnumber = lxrCtnumber;
            return this;
        }
        public String getLxrCtnumber() {
            return this.lxrCtnumber;
        }

        public EditContactRequestData setLxrChengwei(String lxrChengwei) {
            this.lxrChengwei = lxrChengwei;
            return this;
        }
        public String getLxrChengwei() {
            return this.lxrChengwei;
        }

        public EditContactRequestData setLxrType(String lxrType) {
            this.lxrType = lxrType;
            return this;
        }
        public String getLxrType() {
            return this.lxrType;
        }

        public EditContactRequestData setLxrDepartment(String lxrDepartment) {
            this.lxrDepartment = lxrDepartment;
            return this;
        }
        public String getLxrDepartment() {
            return this.lxrDepartment;
        }

        public EditContactRequestData setLxrHeadship(String lxrHeadship) {
            this.lxrHeadship = lxrHeadship;
            return this;
        }
        public String getLxrHeadship() {
            return this.lxrHeadship;
        }

        public EditContactRequestData setLxrDingtalk(String lxrDingtalk) {
            this.lxrDingtalk = lxrDingtalk;
            return this;
        }
        public String getLxrDingtalk() {
            return this.lxrDingtalk;
        }

        public EditContactRequestData setLxrFax(String lxrFax) {
            this.lxrFax = lxrFax;
            return this;
        }
        public String getLxrFax() {
            return this.lxrFax;
        }

        public EditContactRequestData setLxrWangwang(String lxrWangwang) {
            this.lxrWangwang = lxrWangwang;
            return this;
        }
        public String getLxrWangwang() {
            return this.lxrWangwang;
        }

        public EditContactRequestData setLxrEmail(String lxrEmail) {
            this.lxrEmail = lxrEmail;
            return this;
        }
        public String getLxrEmail() {
            return this.lxrEmail;
        }

        public EditContactRequestData setLxrWeixin(String lxrWeixin) {
            this.lxrWeixin = lxrWeixin;
            return this;
        }
        public String getLxrWeixin() {
            return this.lxrWeixin;
        }

        public EditContactRequestData setLxrQq(String lxrQq) {
            this.lxrQq = lxrQq;
            return this;
        }
        public String getLxrQq() {
            return this.lxrQq;
        }

        public EditContactRequestData setLxrTel(String lxrTel) {
            this.lxrTel = lxrTel;
            return this;
        }
        public String getLxrTel() {
            return this.lxrTel;
        }

        public EditContactRequestData setLxrPst(String lxrPst) {
            this.lxrPst = lxrPst;
            return this;
        }
        public String getLxrPst() {
            return this.lxrPst;
        }

        public EditContactRequestData setLxrSkype(String lxrSkype) {
            this.lxrSkype = lxrSkype;
            return this;
        }
        public String getLxrSkype() {
            return this.lxrSkype;
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

        public EditContactRequestData setLxrLike(String lxrLike) {
            this.lxrLike = lxrLike;
            return this;
        }
        public String getLxrLike() {
            return this.lxrLike;
        }

        public EditContactRequestData setLxrRemark(String lxrRemark) {
            this.lxrRemark = lxrRemark;
            return this;
        }
        public String getLxrRemark() {
            return this.lxrRemark;
        }

        public EditContactRequestData setLxrPhoto(String lxrPhoto) {
            this.lxrPhoto = lxrPhoto;
            return this;
        }
        public String getLxrPhoto() {
            return this.lxrPhoto;
        }

    }

}
