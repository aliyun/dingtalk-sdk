// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditIntostockRequest extends TeaModel {
    @NameInMap("data")
    public EditIntostockRequestData data;

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

    public static EditIntostockRequest build(java.util.Map<String, ?> map) throws Exception {
        EditIntostockRequest self = new EditIntostockRequest();
        return TeaModel.build(map, self);
    }

    public EditIntostockRequest setData(EditIntostockRequestData data) {
        this.data = data;
        return this;
    }
    public EditIntostockRequestData getData() {
        return this.data;
    }

    public EditIntostockRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditIntostockRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditIntostockRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public static class EditIntostockRequestData extends TeaModel {
        @NameInMap("askempid")
        public String askempid;

        @NameInMap("auditreson")
        public String auditreson;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("billno")
        public String billno;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("child_mx")
        public String childMx;

        @NameInMap("customerid")
        public String customerid;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("data_userid")
        public String dataUserid;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("empid")
        public String empid;

        @NameInMap("inorout")
        public String inorout;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("libiodate")
        public String libiodate;

        @NameInMap("libioname")
        public String libioname;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("libiostate")
        public String libiostate;

        @NameInMap("orderid")
        public String orderid;

        @NameInMap("remark")
        public String remark;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("stocklibid")
        public String stocklibid;

        public static EditIntostockRequestData build(java.util.Map<String, ?> map) throws Exception {
            EditIntostockRequestData self = new EditIntostockRequestData();
            return TeaModel.build(map, self);
        }

        public EditIntostockRequestData setAskempid(String askempid) {
            this.askempid = askempid;
            return this;
        }
        public String getAskempid() {
            return this.askempid;
        }

        public EditIntostockRequestData setAuditreson(String auditreson) {
            this.auditreson = auditreson;
            return this;
        }
        public String getAuditreson() {
            return this.auditreson;
        }

        public EditIntostockRequestData setBillno(String billno) {
            this.billno = billno;
            return this;
        }
        public String getBillno() {
            return this.billno;
        }

        public EditIntostockRequestData setChildMx(String childMx) {
            this.childMx = childMx;
            return this;
        }
        public String getChildMx() {
            return this.childMx;
        }

        public EditIntostockRequestData setCustomerid(String customerid) {
            this.customerid = customerid;
            return this;
        }
        public String getCustomerid() {
            return this.customerid;
        }

        public EditIntostockRequestData setDataUserid(String dataUserid) {
            this.dataUserid = dataUserid;
            return this;
        }
        public String getDataUserid() {
            return this.dataUserid;
        }

        public EditIntostockRequestData setEmpid(String empid) {
            this.empid = empid;
            return this;
        }
        public String getEmpid() {
            return this.empid;
        }

        public EditIntostockRequestData setInorout(String inorout) {
            this.inorout = inorout;
            return this;
        }
        public String getInorout() {
            return this.inorout;
        }

        public EditIntostockRequestData setLibiodate(String libiodate) {
            this.libiodate = libiodate;
            return this;
        }
        public String getLibiodate() {
            return this.libiodate;
        }

        public EditIntostockRequestData setLibioname(String libioname) {
            this.libioname = libioname;
            return this;
        }
        public String getLibioname() {
            return this.libioname;
        }

        public EditIntostockRequestData setLibiostate(String libiostate) {
            this.libiostate = libiostate;
            return this;
        }
        public String getLibiostate() {
            return this.libiostate;
        }

        public EditIntostockRequestData setOrderid(String orderid) {
            this.orderid = orderid;
            return this;
        }
        public String getOrderid() {
            return this.orderid;
        }

        public EditIntostockRequestData setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public EditIntostockRequestData setStocklibid(String stocklibid) {
            this.stocklibid = stocklibid;
            return this;
        }
        public String getStocklibid() {
            return this.stocklibid;
        }

    }

}
