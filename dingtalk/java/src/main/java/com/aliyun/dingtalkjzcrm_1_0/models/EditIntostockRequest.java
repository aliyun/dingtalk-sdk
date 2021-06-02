// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditIntostockRequest extends TeaModel {
    // 数据类型，固定填写189
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
    public EditIntostockRequestData data;

    public static EditIntostockRequest build(java.util.Map<String, ?> map) throws Exception {
        EditIntostockRequest self = new EditIntostockRequest();
        return TeaModel.build(map, self);
    }

    public EditIntostockRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditIntostockRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public EditIntostockRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditIntostockRequest setData(EditIntostockRequestData data) {
        this.data = data;
        return this;
    }
    public EditIntostockRequestData getData() {
        return this.data;
    }

    public static class EditIntostockRequestData extends TeaModel {
        // 创建人
        @NameInMap("data_userid")
        public String dataUserid;

        // 入库日期
        @NameInMap("libiodate")
        public String libiodate;

        // 入库仓库
        @NameInMap("stocklibid")
        public String stocklibid;

        // 入库状态（未入库，已入库）
        @NameInMap("libiostate")
        public String libiostate;

        // 入库单号
        @NameInMap("billno")
        public String billno;

        // 供应商/客户
        @NameInMap("customerid")
        public String customerid;

        // 入库经办人
        @NameInMap("empid")
        public String empid;

        // 单据类型（入库，销售退货，生产退料，生产入库，维修退货）
        @NameInMap("inorout")
        public String inorout;

        // 入库主题
        @NameInMap("libioname")
        public String libioname;

        // 对应单据
        @NameInMap("orderid")
        public String orderid;

        // 入库申请人
        @NameInMap("askempid")
        public String askempid;

        // 申请备注
        @NameInMap("remark")
        public String remark;

        // 入库备注
        @NameInMap("auditreson")
        public String auditreson;

        // 产品明细，json格式
        @NameInMap("child_mx")
        public String childMx;

        public static EditIntostockRequestData build(java.util.Map<String, ?> map) throws Exception {
            EditIntostockRequestData self = new EditIntostockRequestData();
            return TeaModel.build(map, self);
        }

        public EditIntostockRequestData setDataUserid(String dataUserid) {
            this.dataUserid = dataUserid;
            return this;
        }
        public String getDataUserid() {
            return this.dataUserid;
        }

        public EditIntostockRequestData setLibiodate(String libiodate) {
            this.libiodate = libiodate;
            return this;
        }
        public String getLibiodate() {
            return this.libiodate;
        }

        public EditIntostockRequestData setStocklibid(String stocklibid) {
            this.stocklibid = stocklibid;
            return this;
        }
        public String getStocklibid() {
            return this.stocklibid;
        }

        public EditIntostockRequestData setLibiostate(String libiostate) {
            this.libiostate = libiostate;
            return this;
        }
        public String getLibiostate() {
            return this.libiostate;
        }

        public EditIntostockRequestData setBillno(String billno) {
            this.billno = billno;
            return this;
        }
        public String getBillno() {
            return this.billno;
        }

        public EditIntostockRequestData setCustomerid(String customerid) {
            this.customerid = customerid;
            return this;
        }
        public String getCustomerid() {
            return this.customerid;
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

        public EditIntostockRequestData setLibioname(String libioname) {
            this.libioname = libioname;
            return this;
        }
        public String getLibioname() {
            return this.libioname;
        }

        public EditIntostockRequestData setOrderid(String orderid) {
            this.orderid = orderid;
            return this;
        }
        public String getOrderid() {
            return this.orderid;
        }

        public EditIntostockRequestData setAskempid(String askempid) {
            this.askempid = askempid;
            return this;
        }
        public String getAskempid() {
            return this.askempid;
        }

        public EditIntostockRequestData setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public EditIntostockRequestData setAuditreson(String auditreson) {
            this.auditreson = auditreson;
            return this;
        }
        public String getAuditreson() {
            return this.auditreson;
        }

        public EditIntostockRequestData setChildMx(String childMx) {
            this.childMx = childMx;
            return this;
        }
        public String getChildMx() {
            return this.childMx;
        }

    }

}
