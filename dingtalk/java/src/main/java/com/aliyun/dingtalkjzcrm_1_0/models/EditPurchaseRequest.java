// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditPurchaseRequest extends TeaModel {
    // 数据类型，固定填写153
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
    public EditPurchaseRequestData data;

    public static EditPurchaseRequest build(java.util.Map<String, ?> map) throws Exception {
        EditPurchaseRequest self = new EditPurchaseRequest();
        return TeaModel.build(map, self);
    }

    public EditPurchaseRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditPurchaseRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public EditPurchaseRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditPurchaseRequest setData(EditPurchaseRequestData data) {
        this.data = data;
        return this;
    }
    public EditPurchaseRequestData getData() {
        return this.data;
    }

    public static class EditPurchaseRequestData extends TeaModel {
        // 创建人
        @NameInMap("data_userid")
        public String dataUserid;

        // 供应商
        @NameInMap("gysid")
        public String gysid;

        // 采购单号
        @NameInMap("cgno")
        public String cgno;

        // 采购金额
        @NameInMap("summoney")
        public String summoney;

        // 采购日期
        @NameInMap("cgdate")
        public String cgdate;

        // 执行状态
        @NameInMap("cg_zxstate")
        public String cgZxstate;

        // 关联订单客户
        @NameInMap("order_khid")
        public String orderKhid;

        // 采购主题
        @NameInMap("cgname")
        public String cgname;

        // 供应商联系人
        @NameInMap("gys_lxrid")
        public String gysLxrid;

        // 联系方式
        @NameInMap("gys_lxrinfo")
        public String gysLxrinfo;

        // 采购分类
        @NameInMap("cgtype")
        public String cgtype;

        // 供应商代表
        @NameInMap("gysjingban")
        public String gysjingban;

        // 我方代表
        @NameInMap("empid")
        public String empid;

        // 优惠折扣率
        @NameInMap("cg_moneyzhekou")
        public String cgMoneyzhekou;

        // 优惠抹零金额
        @NameInMap("cg_kjmoney")
        public String cgKjmoney;

        // 附加费用分类
        @NameInMap("cg_fjmoneylx")
        public String cgFjmoneylx;

        // 附加费用金额
        @NameInMap("cg_fjmoney")
        public String cgFjmoney;

        // 关联订单
        @NameInMap("order_htid")
        public String orderHtid;

        // 采购摘要
        @NameInMap("cgremark")
        public String cgremark;

        // 产品明细，json格式
        @NameInMap("child_mx")
        public String childMx;

        public static EditPurchaseRequestData build(java.util.Map<String, ?> map) throws Exception {
            EditPurchaseRequestData self = new EditPurchaseRequestData();
            return TeaModel.build(map, self);
        }

        public EditPurchaseRequestData setDataUserid(String dataUserid) {
            this.dataUserid = dataUserid;
            return this;
        }
        public String getDataUserid() {
            return this.dataUserid;
        }

        public EditPurchaseRequestData setGysid(String gysid) {
            this.gysid = gysid;
            return this;
        }
        public String getGysid() {
            return this.gysid;
        }

        public EditPurchaseRequestData setCgno(String cgno) {
            this.cgno = cgno;
            return this;
        }
        public String getCgno() {
            return this.cgno;
        }

        public EditPurchaseRequestData setSummoney(String summoney) {
            this.summoney = summoney;
            return this;
        }
        public String getSummoney() {
            return this.summoney;
        }

        public EditPurchaseRequestData setCgdate(String cgdate) {
            this.cgdate = cgdate;
            return this;
        }
        public String getCgdate() {
            return this.cgdate;
        }

        public EditPurchaseRequestData setCgZxstate(String cgZxstate) {
            this.cgZxstate = cgZxstate;
            return this;
        }
        public String getCgZxstate() {
            return this.cgZxstate;
        }

        public EditPurchaseRequestData setOrderKhid(String orderKhid) {
            this.orderKhid = orderKhid;
            return this;
        }
        public String getOrderKhid() {
            return this.orderKhid;
        }

        public EditPurchaseRequestData setCgname(String cgname) {
            this.cgname = cgname;
            return this;
        }
        public String getCgname() {
            return this.cgname;
        }

        public EditPurchaseRequestData setGysLxrid(String gysLxrid) {
            this.gysLxrid = gysLxrid;
            return this;
        }
        public String getGysLxrid() {
            return this.gysLxrid;
        }

        public EditPurchaseRequestData setGysLxrinfo(String gysLxrinfo) {
            this.gysLxrinfo = gysLxrinfo;
            return this;
        }
        public String getGysLxrinfo() {
            return this.gysLxrinfo;
        }

        public EditPurchaseRequestData setCgtype(String cgtype) {
            this.cgtype = cgtype;
            return this;
        }
        public String getCgtype() {
            return this.cgtype;
        }

        public EditPurchaseRequestData setGysjingban(String gysjingban) {
            this.gysjingban = gysjingban;
            return this;
        }
        public String getGysjingban() {
            return this.gysjingban;
        }

        public EditPurchaseRequestData setEmpid(String empid) {
            this.empid = empid;
            return this;
        }
        public String getEmpid() {
            return this.empid;
        }

        public EditPurchaseRequestData setCgMoneyzhekou(String cgMoneyzhekou) {
            this.cgMoneyzhekou = cgMoneyzhekou;
            return this;
        }
        public String getCgMoneyzhekou() {
            return this.cgMoneyzhekou;
        }

        public EditPurchaseRequestData setCgKjmoney(String cgKjmoney) {
            this.cgKjmoney = cgKjmoney;
            return this;
        }
        public String getCgKjmoney() {
            return this.cgKjmoney;
        }

        public EditPurchaseRequestData setCgFjmoneylx(String cgFjmoneylx) {
            this.cgFjmoneylx = cgFjmoneylx;
            return this;
        }
        public String getCgFjmoneylx() {
            return this.cgFjmoneylx;
        }

        public EditPurchaseRequestData setCgFjmoney(String cgFjmoney) {
            this.cgFjmoney = cgFjmoney;
            return this;
        }
        public String getCgFjmoney() {
            return this.cgFjmoney;
        }

        public EditPurchaseRequestData setOrderHtid(String orderHtid) {
            this.orderHtid = orderHtid;
            return this;
        }
        public String getOrderHtid() {
            return this.orderHtid;
        }

        public EditPurchaseRequestData setCgremark(String cgremark) {
            this.cgremark = cgremark;
            return this;
        }
        public String getCgremark() {
            return this.cgremark;
        }

        public EditPurchaseRequestData setChildMx(String childMx) {
            this.childMx = childMx;
            return this;
        }
        public String getChildMx() {
            return this.childMx;
        }

    }

}
