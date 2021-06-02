// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditInvoiceRequest extends TeaModel {
    // 数据类型，固定填写169
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
    public EditInvoiceRequestData data;

    public static EditInvoiceRequest build(java.util.Map<String, ?> map) throws Exception {
        EditInvoiceRequest self = new EditInvoiceRequest();
        return TeaModel.build(map, self);
    }

    public EditInvoiceRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditInvoiceRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public EditInvoiceRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditInvoiceRequest setData(EditInvoiceRequestData data) {
        this.data = data;
        return this;
    }
    public EditInvoiceRequestData getData() {
        return this.data;
    }

    public static class EditInvoiceRequestData extends TeaModel {
        // 创建人
        @NameInMap("data_userid")
        public String dataUserid;

        // 对应客户
        @NameInMap("fh_customerid")
        public String fhCustomerid;

        // 发货日期
        @NameInMap("fh_date")
        public String fhDate;

        // 发货单号
        @NameInMap("fh_number")
        public String fhNumber;

        // 发货方式
        @NameInMap("fh_mode")
        public String fhMode;

        // 对应订单
        @NameInMap("fh_htorder")
        public String fhHtorder;

        // 发货主题
        @NameInMap("fh_title")
        public String fhTitle;

        // 运费
        @NameInMap("fh_yunfei")
        public String fhYunfei;

        // 打包件数
        @NameInMap("fh_jianshu")
        public String fhJianshu;

        // 重量(Kg)
        @NameInMap("fh_kg")
        public String fhKg;

        // 发货人
        @NameInMap("fh_shipper")
        public String fhShipper;

        // 所有者
        @NameInMap("fh_preside")
        public String fhPreside;

        // 联系人
        @NameInMap("fh_lxrid")
        public String fhLxrid;

        // 收货人
        @NameInMap("fh_linkman")
        public String fhLinkman;

        // 电话
        @NameInMap("fh_tel")
        public String fhTel;

        // 手机
        @NameInMap("fh_handset")
        public String fhHandset;

        // 邮编
        @NameInMap("fh_post")
        public String fhPost;

        // 地址
        @NameInMap("fh_address")
        public String fhAddress;

        // Email
        @NameInMap("fh_email")
        public String fhEmail;

        // MSN
        @NameInMap("fh_msn")
        public String fhMsn;

        // 备注
        @NameInMap("fh_remark")
        public String fhRemark;

        // 发货状态
        @NameInMap("fh_state")
        public String fhState;

        // 产品明细，json格式
        @NameInMap("child_mx")
        public String childMx;

        public static EditInvoiceRequestData build(java.util.Map<String, ?> map) throws Exception {
            EditInvoiceRequestData self = new EditInvoiceRequestData();
            return TeaModel.build(map, self);
        }

        public EditInvoiceRequestData setDataUserid(String dataUserid) {
            this.dataUserid = dataUserid;
            return this;
        }
        public String getDataUserid() {
            return this.dataUserid;
        }

        public EditInvoiceRequestData setFhCustomerid(String fhCustomerid) {
            this.fhCustomerid = fhCustomerid;
            return this;
        }
        public String getFhCustomerid() {
            return this.fhCustomerid;
        }

        public EditInvoiceRequestData setFhDate(String fhDate) {
            this.fhDate = fhDate;
            return this;
        }
        public String getFhDate() {
            return this.fhDate;
        }

        public EditInvoiceRequestData setFhNumber(String fhNumber) {
            this.fhNumber = fhNumber;
            return this;
        }
        public String getFhNumber() {
            return this.fhNumber;
        }

        public EditInvoiceRequestData setFhMode(String fhMode) {
            this.fhMode = fhMode;
            return this;
        }
        public String getFhMode() {
            return this.fhMode;
        }

        public EditInvoiceRequestData setFhHtorder(String fhHtorder) {
            this.fhHtorder = fhHtorder;
            return this;
        }
        public String getFhHtorder() {
            return this.fhHtorder;
        }

        public EditInvoiceRequestData setFhTitle(String fhTitle) {
            this.fhTitle = fhTitle;
            return this;
        }
        public String getFhTitle() {
            return this.fhTitle;
        }

        public EditInvoiceRequestData setFhYunfei(String fhYunfei) {
            this.fhYunfei = fhYunfei;
            return this;
        }
        public String getFhYunfei() {
            return this.fhYunfei;
        }

        public EditInvoiceRequestData setFhJianshu(String fhJianshu) {
            this.fhJianshu = fhJianshu;
            return this;
        }
        public String getFhJianshu() {
            return this.fhJianshu;
        }

        public EditInvoiceRequestData setFhKg(String fhKg) {
            this.fhKg = fhKg;
            return this;
        }
        public String getFhKg() {
            return this.fhKg;
        }

        public EditInvoiceRequestData setFhShipper(String fhShipper) {
            this.fhShipper = fhShipper;
            return this;
        }
        public String getFhShipper() {
            return this.fhShipper;
        }

        public EditInvoiceRequestData setFhPreside(String fhPreside) {
            this.fhPreside = fhPreside;
            return this;
        }
        public String getFhPreside() {
            return this.fhPreside;
        }

        public EditInvoiceRequestData setFhLxrid(String fhLxrid) {
            this.fhLxrid = fhLxrid;
            return this;
        }
        public String getFhLxrid() {
            return this.fhLxrid;
        }

        public EditInvoiceRequestData setFhLinkman(String fhLinkman) {
            this.fhLinkman = fhLinkman;
            return this;
        }
        public String getFhLinkman() {
            return this.fhLinkman;
        }

        public EditInvoiceRequestData setFhTel(String fhTel) {
            this.fhTel = fhTel;
            return this;
        }
        public String getFhTel() {
            return this.fhTel;
        }

        public EditInvoiceRequestData setFhHandset(String fhHandset) {
            this.fhHandset = fhHandset;
            return this;
        }
        public String getFhHandset() {
            return this.fhHandset;
        }

        public EditInvoiceRequestData setFhPost(String fhPost) {
            this.fhPost = fhPost;
            return this;
        }
        public String getFhPost() {
            return this.fhPost;
        }

        public EditInvoiceRequestData setFhAddress(String fhAddress) {
            this.fhAddress = fhAddress;
            return this;
        }
        public String getFhAddress() {
            return this.fhAddress;
        }

        public EditInvoiceRequestData setFhEmail(String fhEmail) {
            this.fhEmail = fhEmail;
            return this;
        }
        public String getFhEmail() {
            return this.fhEmail;
        }

        public EditInvoiceRequestData setFhMsn(String fhMsn) {
            this.fhMsn = fhMsn;
            return this;
        }
        public String getFhMsn() {
            return this.fhMsn;
        }

        public EditInvoiceRequestData setFhRemark(String fhRemark) {
            this.fhRemark = fhRemark;
            return this;
        }
        public String getFhRemark() {
            return this.fhRemark;
        }

        public EditInvoiceRequestData setFhState(String fhState) {
            this.fhState = fhState;
            return this;
        }
        public String getFhState() {
            return this.fhState;
        }

        public EditInvoiceRequestData setChildMx(String childMx) {
            this.childMx = childMx;
            return this;
        }
        public String getChildMx() {
            return this.childMx;
        }

    }

}
