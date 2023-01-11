// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditIntostockRequest extends TeaModel {
    /**
     * <p>编辑数据</p>
     */
    @NameInMap("data")
    public EditIntostockRequestData data;

    /**
     * <p>数据类型，固定填写189</p>
     */
    @NameInMap("datatype")
    public Long datatype;

    /**
     * <p>数据id，不填或者填0为新增数据</p>
     */
    @NameInMap("msgid")
    public Long msgid;

    /**
     * <p>时间戳</p>
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
        /**
         * <p>入库申请人</p>
         */
        @NameInMap("askempid")
        public String askempid;

        /**
         * <p>入库备注</p>
         */
        @NameInMap("auditreson")
        public String auditreson;

        /**
         * <p>入库单号</p>
         */
        @NameInMap("billno")
        public String billno;

        /**
         * <p>产品明细，json格式</p>
         */
        @NameInMap("child_mx")
        public String childMx;

        /**
         * <p>供应商/客户</p>
         */
        @NameInMap("customerid")
        public String customerid;

        /**
         * <p>创建人</p>
         */
        @NameInMap("data_userid")
        public String dataUserid;

        /**
         * <p>入库经办人</p>
         */
        @NameInMap("empid")
        public String empid;

        /**
         * <p>单据类型（入库，销售退货，生产退料，生产入库，维修退货）</p>
         */
        @NameInMap("inorout")
        public String inorout;

        /**
         * <p>入库日期</p>
         */
        @NameInMap("libiodate")
        public String libiodate;

        /**
         * <p>入库主题</p>
         */
        @NameInMap("libioname")
        public String libioname;

        /**
         * <p>入库状态（未入库，已入库）</p>
         */
        @NameInMap("libiostate")
        public String libiostate;

        /**
         * <p>对应单据</p>
         */
        @NameInMap("orderid")
        public String orderid;

        /**
         * <p>申请备注</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <p>入库仓库</p>
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
