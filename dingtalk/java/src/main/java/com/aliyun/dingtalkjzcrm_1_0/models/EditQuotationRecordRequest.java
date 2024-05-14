// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditQuotationRecordRequest extends TeaModel {
    @NameInMap("data")
    public EditQuotationRecordRequestData data;

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

    public static EditQuotationRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        EditQuotationRecordRequest self = new EditQuotationRecordRequest();
        return TeaModel.build(map, self);
    }

    public EditQuotationRecordRequest setData(EditQuotationRecordRequestData data) {
        this.data = data;
        return this;
    }
    public EditQuotationRecordRequestData getData() {
        return this.data;
    }

    public EditQuotationRecordRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditQuotationRecordRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditQuotationRecordRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public static class EditQuotationRecordRequestData extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bj_bjren")
        public String bjBjren;

        @NameInMap("bj_bzremark")
        public String bjBzremark;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bj_customerid")
        public String bjCustomerid;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bj_date")
        public String bjDate;

        @NameInMap("bj_fjmoney")
        public String bjFjmoney;

        @NameInMap("bj_fjmoneylx")
        public String bjFjmoneylx;

        @NameInMap("bj_fkremark")
        public String bjFkremark;

        @NameInMap("bj_jfremark")
        public String bjJfremark;

        @NameInMap("bj_jshren")
        public String bjJshren;

        @NameInMap("bj_kjmoney")
        public String bjKjmoney;

        @NameInMap("bj_lianxi")
        public String bjLianxi;

        @NameInMap("bj_moneyzhekou")
        public String bjMoneyzhekou;

        @NameInMap("bj_number")
        public String bjNumber;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bj_price")
        public String bjPrice;

        @NameInMap("bj_remark")
        public String bjRemark;

        @NameInMap("bj_state")
        public String bjState;

        @NameInMap("bj_title")
        public String bjTitle;

        @NameInMap("bj_xshid")
        public String bjXshid;

        @NameInMap("child_mx")
        public String childMx;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("data_userid")
        public String dataUserid;

        public static EditQuotationRecordRequestData build(java.util.Map<String, ?> map) throws Exception {
            EditQuotationRecordRequestData self = new EditQuotationRecordRequestData();
            return TeaModel.build(map, self);
        }

        public EditQuotationRecordRequestData setBjBjren(String bjBjren) {
            this.bjBjren = bjBjren;
            return this;
        }
        public String getBjBjren() {
            return this.bjBjren;
        }

        public EditQuotationRecordRequestData setBjBzremark(String bjBzremark) {
            this.bjBzremark = bjBzremark;
            return this;
        }
        public String getBjBzremark() {
            return this.bjBzremark;
        }

        public EditQuotationRecordRequestData setBjCustomerid(String bjCustomerid) {
            this.bjCustomerid = bjCustomerid;
            return this;
        }
        public String getBjCustomerid() {
            return this.bjCustomerid;
        }

        public EditQuotationRecordRequestData setBjDate(String bjDate) {
            this.bjDate = bjDate;
            return this;
        }
        public String getBjDate() {
            return this.bjDate;
        }

        public EditQuotationRecordRequestData setBjFjmoney(String bjFjmoney) {
            this.bjFjmoney = bjFjmoney;
            return this;
        }
        public String getBjFjmoney() {
            return this.bjFjmoney;
        }

        public EditQuotationRecordRequestData setBjFjmoneylx(String bjFjmoneylx) {
            this.bjFjmoneylx = bjFjmoneylx;
            return this;
        }
        public String getBjFjmoneylx() {
            return this.bjFjmoneylx;
        }

        public EditQuotationRecordRequestData setBjFkremark(String bjFkremark) {
            this.bjFkremark = bjFkremark;
            return this;
        }
        public String getBjFkremark() {
            return this.bjFkremark;
        }

        public EditQuotationRecordRequestData setBjJfremark(String bjJfremark) {
            this.bjJfremark = bjJfremark;
            return this;
        }
        public String getBjJfremark() {
            return this.bjJfremark;
        }

        public EditQuotationRecordRequestData setBjJshren(String bjJshren) {
            this.bjJshren = bjJshren;
            return this;
        }
        public String getBjJshren() {
            return this.bjJshren;
        }

        public EditQuotationRecordRequestData setBjKjmoney(String bjKjmoney) {
            this.bjKjmoney = bjKjmoney;
            return this;
        }
        public String getBjKjmoney() {
            return this.bjKjmoney;
        }

        public EditQuotationRecordRequestData setBjLianxi(String bjLianxi) {
            this.bjLianxi = bjLianxi;
            return this;
        }
        public String getBjLianxi() {
            return this.bjLianxi;
        }

        public EditQuotationRecordRequestData setBjMoneyzhekou(String bjMoneyzhekou) {
            this.bjMoneyzhekou = bjMoneyzhekou;
            return this;
        }
        public String getBjMoneyzhekou() {
            return this.bjMoneyzhekou;
        }

        public EditQuotationRecordRequestData setBjNumber(String bjNumber) {
            this.bjNumber = bjNumber;
            return this;
        }
        public String getBjNumber() {
            return this.bjNumber;
        }

        public EditQuotationRecordRequestData setBjPrice(String bjPrice) {
            this.bjPrice = bjPrice;
            return this;
        }
        public String getBjPrice() {
            return this.bjPrice;
        }

        public EditQuotationRecordRequestData setBjRemark(String bjRemark) {
            this.bjRemark = bjRemark;
            return this;
        }
        public String getBjRemark() {
            return this.bjRemark;
        }

        public EditQuotationRecordRequestData setBjState(String bjState) {
            this.bjState = bjState;
            return this;
        }
        public String getBjState() {
            return this.bjState;
        }

        public EditQuotationRecordRequestData setBjTitle(String bjTitle) {
            this.bjTitle = bjTitle;
            return this;
        }
        public String getBjTitle() {
            return this.bjTitle;
        }

        public EditQuotationRecordRequestData setBjXshid(String bjXshid) {
            this.bjXshid = bjXshid;
            return this;
        }
        public String getBjXshid() {
            return this.bjXshid;
        }

        public EditQuotationRecordRequestData setChildMx(String childMx) {
            this.childMx = childMx;
            return this;
        }
        public String getChildMx() {
            return this.childMx;
        }

        public EditQuotationRecordRequestData setDataUserid(String dataUserid) {
            this.dataUserid = dataUserid;
            return this;
        }
        public String getDataUserid() {
            return this.dataUserid;
        }

    }

}
