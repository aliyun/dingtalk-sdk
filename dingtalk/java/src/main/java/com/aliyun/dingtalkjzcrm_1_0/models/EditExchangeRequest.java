// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditExchangeRequest extends TeaModel {
    @NameInMap("data")
    public EditExchangeRequestData data;

    @NameInMap("datatype")
    public Long datatype;

    @NameInMap("msgid")
    public Long msgid;

    @NameInMap("stamp")
    public Long stamp;

    public static EditExchangeRequest build(java.util.Map<String, ?> map) throws Exception {
        EditExchangeRequest self = new EditExchangeRequest();
        return TeaModel.build(map, self);
    }

    public EditExchangeRequest setData(EditExchangeRequestData data) {
        this.data = data;
        return this;
    }
    public EditExchangeRequestData getData() {
        return this.data;
    }

    public EditExchangeRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditExchangeRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditExchangeRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public static class EditExchangeRequestData extends TeaModel {
        @NameInMap("child_mx")
        public String childMx;

        @NameInMap("data_userid")
        public String dataUserid;

        @NameInMap("hh_customerid")
        public String hhCustomerid;

        @NameInMap("hh_date")
        public String hhDate;

        @NameInMap("hh_inempid")
        public String hhInempid;

        @NameInMap("hh_inlibid")
        public String hhInlibid;

        @NameInMap("hh_intime")
        public String hhIntime;

        @NameInMap("hh_number")
        public String hhNumber;

        @NameInMap("hh_orderid")
        public String hhOrderid;

        @NameInMap("hh_outempid")
        public String hhOutempid;

        @NameInMap("hh_outlibid")
        public String hhOutlibid;

        @NameInMap("hh_outtime")
        public String hhOuttime;

        @NameInMap("hh_remark")
        public String hhRemark;

        @NameInMap("hh_state")
        public String hhState;

        @NameInMap("hh_title")
        public String hhTitle;

        @NameInMap("hh_type")
        public String hhType;

        public static EditExchangeRequestData build(java.util.Map<String, ?> map) throws Exception {
            EditExchangeRequestData self = new EditExchangeRequestData();
            return TeaModel.build(map, self);
        }

        public EditExchangeRequestData setChildMx(String childMx) {
            this.childMx = childMx;
            return this;
        }
        public String getChildMx() {
            return this.childMx;
        }

        public EditExchangeRequestData setDataUserid(String dataUserid) {
            this.dataUserid = dataUserid;
            return this;
        }
        public String getDataUserid() {
            return this.dataUserid;
        }

        public EditExchangeRequestData setHhCustomerid(String hhCustomerid) {
            this.hhCustomerid = hhCustomerid;
            return this;
        }
        public String getHhCustomerid() {
            return this.hhCustomerid;
        }

        public EditExchangeRequestData setHhDate(String hhDate) {
            this.hhDate = hhDate;
            return this;
        }
        public String getHhDate() {
            return this.hhDate;
        }

        public EditExchangeRequestData setHhInempid(String hhInempid) {
            this.hhInempid = hhInempid;
            return this;
        }
        public String getHhInempid() {
            return this.hhInempid;
        }

        public EditExchangeRequestData setHhInlibid(String hhInlibid) {
            this.hhInlibid = hhInlibid;
            return this;
        }
        public String getHhInlibid() {
            return this.hhInlibid;
        }

        public EditExchangeRequestData setHhIntime(String hhIntime) {
            this.hhIntime = hhIntime;
            return this;
        }
        public String getHhIntime() {
            return this.hhIntime;
        }

        public EditExchangeRequestData setHhNumber(String hhNumber) {
            this.hhNumber = hhNumber;
            return this;
        }
        public String getHhNumber() {
            return this.hhNumber;
        }

        public EditExchangeRequestData setHhOrderid(String hhOrderid) {
            this.hhOrderid = hhOrderid;
            return this;
        }
        public String getHhOrderid() {
            return this.hhOrderid;
        }

        public EditExchangeRequestData setHhOutempid(String hhOutempid) {
            this.hhOutempid = hhOutempid;
            return this;
        }
        public String getHhOutempid() {
            return this.hhOutempid;
        }

        public EditExchangeRequestData setHhOutlibid(String hhOutlibid) {
            this.hhOutlibid = hhOutlibid;
            return this;
        }
        public String getHhOutlibid() {
            return this.hhOutlibid;
        }

        public EditExchangeRequestData setHhOuttime(String hhOuttime) {
            this.hhOuttime = hhOuttime;
            return this;
        }
        public String getHhOuttime() {
            return this.hhOuttime;
        }

        public EditExchangeRequestData setHhRemark(String hhRemark) {
            this.hhRemark = hhRemark;
            return this;
        }
        public String getHhRemark() {
            return this.hhRemark;
        }

        public EditExchangeRequestData setHhState(String hhState) {
            this.hhState = hhState;
            return this;
        }
        public String getHhState() {
            return this.hhState;
        }

        public EditExchangeRequestData setHhTitle(String hhTitle) {
            this.hhTitle = hhTitle;
            return this;
        }
        public String getHhTitle() {
            return this.hhTitle;
        }

        public EditExchangeRequestData setHhType(String hhType) {
            this.hhType = hhType;
            return this;
        }
        public String getHhType() {
            return this.hhType;
        }

    }

}
