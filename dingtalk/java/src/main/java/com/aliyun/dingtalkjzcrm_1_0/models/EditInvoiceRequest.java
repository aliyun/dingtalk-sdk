// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditInvoiceRequest extends TeaModel {
    @NameInMap("data")
    public EditInvoiceRequestData data;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("datatype")
    public Long datatype;

    @NameInMap("msgid")
    public Long msgid;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("stamp")
    public Long stamp;

    public static EditInvoiceRequest build(java.util.Map<String, ?> map) throws Exception {
        EditInvoiceRequest self = new EditInvoiceRequest();
        return TeaModel.build(map, self);
    }

    public EditInvoiceRequest setData(EditInvoiceRequestData data) {
        this.data = data;
        return this;
    }
    public EditInvoiceRequestData getData() {
        return this.data;
    }

    public EditInvoiceRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditInvoiceRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditInvoiceRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public static class EditInvoiceRequestData extends TeaModel {
        @NameInMap("child_mx")
        public String childMx;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("data_userid")
        public String dataUserid;

        @NameInMap("fh_address")
        public String fhAddress;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fh_customerid")
        public String fhCustomerid;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fh_date")
        public String fhDate;

        @NameInMap("fh_email")
        public String fhEmail;

        @NameInMap("fh_handset")
        public String fhHandset;

        @NameInMap("fh_htorder")
        public String fhHtorder;

        @NameInMap("fh_jianshu")
        public String fhJianshu;

        @NameInMap("fh_kg")
        public String fhKg;

        @NameInMap("fh_linkman")
        public String fhLinkman;

        @NameInMap("fh_lxrid")
        public String fhLxrid;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fh_mode")
        public String fhMode;

        @NameInMap("fh_msn")
        public String fhMsn;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fh_number")
        public String fhNumber;

        @NameInMap("fh_post")
        public String fhPost;

        @NameInMap("fh_preside")
        public String fhPreside;

        @NameInMap("fh_remark")
        public String fhRemark;

        @NameInMap("fh_shipper")
        public String fhShipper;

        @NameInMap("fh_state")
        public String fhState;

        @NameInMap("fh_tel")
        public String fhTel;

        @NameInMap("fh_title")
        public String fhTitle;

        @NameInMap("fh_yunfei")
        public String fhYunfei;

        public static EditInvoiceRequestData build(java.util.Map<String, ?> map) throws Exception {
            EditInvoiceRequestData self = new EditInvoiceRequestData();
            return TeaModel.build(map, self);
        }

        public EditInvoiceRequestData setChildMx(String childMx) {
            this.childMx = childMx;
            return this;
        }
        public String getChildMx() {
            return this.childMx;
        }

        public EditInvoiceRequestData setDataUserid(String dataUserid) {
            this.dataUserid = dataUserid;
            return this;
        }
        public String getDataUserid() {
            return this.dataUserid;
        }

        public EditInvoiceRequestData setFhAddress(String fhAddress) {
            this.fhAddress = fhAddress;
            return this;
        }
        public String getFhAddress() {
            return this.fhAddress;
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

        public EditInvoiceRequestData setFhEmail(String fhEmail) {
            this.fhEmail = fhEmail;
            return this;
        }
        public String getFhEmail() {
            return this.fhEmail;
        }

        public EditInvoiceRequestData setFhHandset(String fhHandset) {
            this.fhHandset = fhHandset;
            return this;
        }
        public String getFhHandset() {
            return this.fhHandset;
        }

        public EditInvoiceRequestData setFhHtorder(String fhHtorder) {
            this.fhHtorder = fhHtorder;
            return this;
        }
        public String getFhHtorder() {
            return this.fhHtorder;
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

        public EditInvoiceRequestData setFhLinkman(String fhLinkman) {
            this.fhLinkman = fhLinkman;
            return this;
        }
        public String getFhLinkman() {
            return this.fhLinkman;
        }

        public EditInvoiceRequestData setFhLxrid(String fhLxrid) {
            this.fhLxrid = fhLxrid;
            return this;
        }
        public String getFhLxrid() {
            return this.fhLxrid;
        }

        public EditInvoiceRequestData setFhMode(String fhMode) {
            this.fhMode = fhMode;
            return this;
        }
        public String getFhMode() {
            return this.fhMode;
        }

        public EditInvoiceRequestData setFhMsn(String fhMsn) {
            this.fhMsn = fhMsn;
            return this;
        }
        public String getFhMsn() {
            return this.fhMsn;
        }

        public EditInvoiceRequestData setFhNumber(String fhNumber) {
            this.fhNumber = fhNumber;
            return this;
        }
        public String getFhNumber() {
            return this.fhNumber;
        }

        public EditInvoiceRequestData setFhPost(String fhPost) {
            this.fhPost = fhPost;
            return this;
        }
        public String getFhPost() {
            return this.fhPost;
        }

        public EditInvoiceRequestData setFhPreside(String fhPreside) {
            this.fhPreside = fhPreside;
            return this;
        }
        public String getFhPreside() {
            return this.fhPreside;
        }

        public EditInvoiceRequestData setFhRemark(String fhRemark) {
            this.fhRemark = fhRemark;
            return this;
        }
        public String getFhRemark() {
            return this.fhRemark;
        }

        public EditInvoiceRequestData setFhShipper(String fhShipper) {
            this.fhShipper = fhShipper;
            return this;
        }
        public String getFhShipper() {
            return this.fhShipper;
        }

        public EditInvoiceRequestData setFhState(String fhState) {
            this.fhState = fhState;
            return this;
        }
        public String getFhState() {
            return this.fhState;
        }

        public EditInvoiceRequestData setFhTel(String fhTel) {
            this.fhTel = fhTel;
            return this;
        }
        public String getFhTel() {
            return this.fhTel;
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

    }

}
