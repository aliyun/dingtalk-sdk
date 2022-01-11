// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditOutstockRequest extends TeaModel {
    // 编辑数据
    @NameInMap("data")
    public EditOutstockRequestData data;

    // 数据类型，固定填写191
    @NameInMap("datatype")
    public Long datatype;

    // 数据id，不填或者填0为新增数据
    @NameInMap("msgid")
    public Long msgid;

    // 时间戳
    @NameInMap("stamp")
    public Long stamp;

    public static EditOutstockRequest build(java.util.Map<String, ?> map) throws Exception {
        EditOutstockRequest self = new EditOutstockRequest();
        return TeaModel.build(map, self);
    }

    public EditOutstockRequest setData(EditOutstockRequestData data) {
        this.data = data;
        return this;
    }
    public EditOutstockRequestData getData() {
        return this.data;
    }

    public EditOutstockRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditOutstockRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditOutstockRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public static class EditOutstockRequestData extends TeaModel {
        // 申请人
        @NameInMap("askempid")
        public String askempid;

        // 出库备注
        @NameInMap("auditreson")
        public String auditreson;

        // 出库单号
        @NameInMap("billno")
        public String billno;

        // 产品明细，json格式
        @NameInMap("child_mx")
        public String childMx;

        // 对应客户
        @NameInMap("customerid")
        public String customerid;

        // 创建人
        @NameInMap("data_userid")
        public String dataUserid;

        // 经办人
        @NameInMap("empid")
        public String empid;

        // 单据类型
        @NameInMap("inorout")
        public String inorout;

        // 出库日期
        @NameInMap("libiodate")
        public String libiodate;

        // 出库主题
        @NameInMap("libioname")
        public String libioname;

        // 出库状态
        @NameInMap("libiostate")
        public String libiostate;

        // 对应订单
        @NameInMap("orderid")
        public String orderid;

        // 申请备注
        @NameInMap("remark")
        public String remark;

        // 出库仓库
        @NameInMap("stocklibid")
        public String stocklibid;

        public static EditOutstockRequestData build(java.util.Map<String, ?> map) throws Exception {
            EditOutstockRequestData self = new EditOutstockRequestData();
            return TeaModel.build(map, self);
        }

        public EditOutstockRequestData setAskempid(String askempid) {
            this.askempid = askempid;
            return this;
        }
        public String getAskempid() {
            return this.askempid;
        }

        public EditOutstockRequestData setAuditreson(String auditreson) {
            this.auditreson = auditreson;
            return this;
        }
        public String getAuditreson() {
            return this.auditreson;
        }

        public EditOutstockRequestData setBillno(String billno) {
            this.billno = billno;
            return this;
        }
        public String getBillno() {
            return this.billno;
        }

        public EditOutstockRequestData setChildMx(String childMx) {
            this.childMx = childMx;
            return this;
        }
        public String getChildMx() {
            return this.childMx;
        }

        public EditOutstockRequestData setCustomerid(String customerid) {
            this.customerid = customerid;
            return this;
        }
        public String getCustomerid() {
            return this.customerid;
        }

        public EditOutstockRequestData setDataUserid(String dataUserid) {
            this.dataUserid = dataUserid;
            return this;
        }
        public String getDataUserid() {
            return this.dataUserid;
        }

        public EditOutstockRequestData setEmpid(String empid) {
            this.empid = empid;
            return this;
        }
        public String getEmpid() {
            return this.empid;
        }

        public EditOutstockRequestData setInorout(String inorout) {
            this.inorout = inorout;
            return this;
        }
        public String getInorout() {
            return this.inorout;
        }

        public EditOutstockRequestData setLibiodate(String libiodate) {
            this.libiodate = libiodate;
            return this;
        }
        public String getLibiodate() {
            return this.libiodate;
        }

        public EditOutstockRequestData setLibioname(String libioname) {
            this.libioname = libioname;
            return this;
        }
        public String getLibioname() {
            return this.libioname;
        }

        public EditOutstockRequestData setLibiostate(String libiostate) {
            this.libiostate = libiostate;
            return this;
        }
        public String getLibiostate() {
            return this.libiostate;
        }

        public EditOutstockRequestData setOrderid(String orderid) {
            this.orderid = orderid;
            return this;
        }
        public String getOrderid() {
            return this.orderid;
        }

        public EditOutstockRequestData setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public EditOutstockRequestData setStocklibid(String stocklibid) {
            this.stocklibid = stocklibid;
            return this;
        }
        public String getStocklibid() {
            return this.stocklibid;
        }

    }

}
