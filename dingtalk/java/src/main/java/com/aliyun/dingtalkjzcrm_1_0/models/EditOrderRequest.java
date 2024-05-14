// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditOrderRequest extends TeaModel {
    @NameInMap("data")
    public EditOrderRequestData data;

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

    public static EditOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        EditOrderRequest self = new EditOrderRequest();
        return TeaModel.build(map, self);
    }

    public EditOrderRequest setData(EditOrderRequestData data) {
        this.data = data;
        return this;
    }
    public EditOrderRequestData getData() {
        return this.data;
    }

    public EditOrderRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditOrderRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditOrderRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public static class EditOrderRequestData extends TeaModel {
        @NameInMap("child_mx")
        public String childMx;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("data_userid")
        public String dataUserid;

        @NameInMap("fahuoaddressid")
        public String fahuoaddressid;

        @NameInMap("ht_begindate")
        public String htBegindate;

        @NameInMap("ht_contract")
        public String htContract;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("ht_customerid")
        public String htCustomerid;

        @NameInMap("ht_cusub")
        public String htCusub;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("ht_date")
        public String htDate;

        @NameInMap("ht_deliplace")
        public String htDeliplace;

        @NameInMap("ht_enddate")
        public String htEnddate;

        @NameInMap("ht_fjmoney")
        public String htFjmoney;

        @NameInMap("ht_fjmoneylx")
        public String htFjmoneylx;

        @NameInMap("ht_kjmoney")
        public String htKjmoney;

        @NameInMap("ht_lxrid")
        public String htLxrid;

        @NameInMap("ht_lxrinfo")
        public String htLxrinfo;

        @NameInMap("ht_moneyzhekou")
        public String htMoneyzhekou;

        @NameInMap("ht_number")
        public String htNumber;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("ht_order")
        public String htOrder;

        @NameInMap("ht_paymode")
        public String htPaymode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("ht_preside")
        public String htPreside;

        @NameInMap("ht_remark")
        public String htRemark;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("ht_state")
        public String htState;

        @NameInMap("ht_summemo")
        public String htSummemo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("ht_summoney")
        public String htSummoney;

        @NameInMap("ht_title")
        public String htTitle;

        @NameInMap("ht_type")
        public String htType;

        @NameInMap("ht_wesub")
        public String htWesub;

        @NameInMap("ht_wuliutype")
        public String htWuliutype;

        @NameInMap("ht_xshid")
        public String htXshid;

        @NameInMap("ht_yunfeimoney")
        public String htYunfeimoney;

        public static EditOrderRequestData build(java.util.Map<String, ?> map) throws Exception {
            EditOrderRequestData self = new EditOrderRequestData();
            return TeaModel.build(map, self);
        }

        public EditOrderRequestData setChildMx(String childMx) {
            this.childMx = childMx;
            return this;
        }
        public String getChildMx() {
            return this.childMx;
        }

        public EditOrderRequestData setDataUserid(String dataUserid) {
            this.dataUserid = dataUserid;
            return this;
        }
        public String getDataUserid() {
            return this.dataUserid;
        }

        public EditOrderRequestData setFahuoaddressid(String fahuoaddressid) {
            this.fahuoaddressid = fahuoaddressid;
            return this;
        }
        public String getFahuoaddressid() {
            return this.fahuoaddressid;
        }

        public EditOrderRequestData setHtBegindate(String htBegindate) {
            this.htBegindate = htBegindate;
            return this;
        }
        public String getHtBegindate() {
            return this.htBegindate;
        }

        public EditOrderRequestData setHtContract(String htContract) {
            this.htContract = htContract;
            return this;
        }
        public String getHtContract() {
            return this.htContract;
        }

        public EditOrderRequestData setHtCustomerid(String htCustomerid) {
            this.htCustomerid = htCustomerid;
            return this;
        }
        public String getHtCustomerid() {
            return this.htCustomerid;
        }

        public EditOrderRequestData setHtCusub(String htCusub) {
            this.htCusub = htCusub;
            return this;
        }
        public String getHtCusub() {
            return this.htCusub;
        }

        public EditOrderRequestData setHtDate(String htDate) {
            this.htDate = htDate;
            return this;
        }
        public String getHtDate() {
            return this.htDate;
        }

        public EditOrderRequestData setHtDeliplace(String htDeliplace) {
            this.htDeliplace = htDeliplace;
            return this;
        }
        public String getHtDeliplace() {
            return this.htDeliplace;
        }

        public EditOrderRequestData setHtEnddate(String htEnddate) {
            this.htEnddate = htEnddate;
            return this;
        }
        public String getHtEnddate() {
            return this.htEnddate;
        }

        public EditOrderRequestData setHtFjmoney(String htFjmoney) {
            this.htFjmoney = htFjmoney;
            return this;
        }
        public String getHtFjmoney() {
            return this.htFjmoney;
        }

        public EditOrderRequestData setHtFjmoneylx(String htFjmoneylx) {
            this.htFjmoneylx = htFjmoneylx;
            return this;
        }
        public String getHtFjmoneylx() {
            return this.htFjmoneylx;
        }

        public EditOrderRequestData setHtKjmoney(String htKjmoney) {
            this.htKjmoney = htKjmoney;
            return this;
        }
        public String getHtKjmoney() {
            return this.htKjmoney;
        }

        public EditOrderRequestData setHtLxrid(String htLxrid) {
            this.htLxrid = htLxrid;
            return this;
        }
        public String getHtLxrid() {
            return this.htLxrid;
        }

        public EditOrderRequestData setHtLxrinfo(String htLxrinfo) {
            this.htLxrinfo = htLxrinfo;
            return this;
        }
        public String getHtLxrinfo() {
            return this.htLxrinfo;
        }

        public EditOrderRequestData setHtMoneyzhekou(String htMoneyzhekou) {
            this.htMoneyzhekou = htMoneyzhekou;
            return this;
        }
        public String getHtMoneyzhekou() {
            return this.htMoneyzhekou;
        }

        public EditOrderRequestData setHtNumber(String htNumber) {
            this.htNumber = htNumber;
            return this;
        }
        public String getHtNumber() {
            return this.htNumber;
        }

        public EditOrderRequestData setHtOrder(String htOrder) {
            this.htOrder = htOrder;
            return this;
        }
        public String getHtOrder() {
            return this.htOrder;
        }

        public EditOrderRequestData setHtPaymode(String htPaymode) {
            this.htPaymode = htPaymode;
            return this;
        }
        public String getHtPaymode() {
            return this.htPaymode;
        }

        public EditOrderRequestData setHtPreside(String htPreside) {
            this.htPreside = htPreside;
            return this;
        }
        public String getHtPreside() {
            return this.htPreside;
        }

        public EditOrderRequestData setHtRemark(String htRemark) {
            this.htRemark = htRemark;
            return this;
        }
        public String getHtRemark() {
            return this.htRemark;
        }

        public EditOrderRequestData setHtState(String htState) {
            this.htState = htState;
            return this;
        }
        public String getHtState() {
            return this.htState;
        }

        public EditOrderRequestData setHtSummemo(String htSummemo) {
            this.htSummemo = htSummemo;
            return this;
        }
        public String getHtSummemo() {
            return this.htSummemo;
        }

        public EditOrderRequestData setHtSummoney(String htSummoney) {
            this.htSummoney = htSummoney;
            return this;
        }
        public String getHtSummoney() {
            return this.htSummoney;
        }

        public EditOrderRequestData setHtTitle(String htTitle) {
            this.htTitle = htTitle;
            return this;
        }
        public String getHtTitle() {
            return this.htTitle;
        }

        public EditOrderRequestData setHtType(String htType) {
            this.htType = htType;
            return this;
        }
        public String getHtType() {
            return this.htType;
        }

        public EditOrderRequestData setHtWesub(String htWesub) {
            this.htWesub = htWesub;
            return this;
        }
        public String getHtWesub() {
            return this.htWesub;
        }

        public EditOrderRequestData setHtWuliutype(String htWuliutype) {
            this.htWuliutype = htWuliutype;
            return this;
        }
        public String getHtWuliutype() {
            return this.htWuliutype;
        }

        public EditOrderRequestData setHtXshid(String htXshid) {
            this.htXshid = htXshid;
            return this;
        }
        public String getHtXshid() {
            return this.htXshid;
        }

        public EditOrderRequestData setHtYunfeimoney(String htYunfeimoney) {
            this.htYunfeimoney = htYunfeimoney;
            return this;
        }
        public String getHtYunfeimoney() {
            return this.htYunfeimoney;
        }

    }

}
