// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditPurchaseRequest extends TeaModel {
    @NameInMap("data")
    public EditPurchaseRequestData data;

    @NameInMap("datatype")
    public Long datatype;

    @NameInMap("msgid")
    public Long msgid;

    @NameInMap("stamp")
    public Long stamp;

    public static EditPurchaseRequest build(java.util.Map<String, ?> map) throws Exception {
        EditPurchaseRequest self = new EditPurchaseRequest();
        return TeaModel.build(map, self);
    }

    public EditPurchaseRequest setData(EditPurchaseRequestData data) {
        this.data = data;
        return this;
    }
    public EditPurchaseRequestData getData() {
        return this.data;
    }

    public EditPurchaseRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditPurchaseRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditPurchaseRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public static class EditPurchaseRequestData extends TeaModel {
        @NameInMap("cg_fjmoney")
        public String cgFjmoney;

        @NameInMap("cg_fjmoneylx")
        public String cgFjmoneylx;

        @NameInMap("cg_kjmoney")
        public String cgKjmoney;

        @NameInMap("cg_moneyzhekou")
        public String cgMoneyzhekou;

        @NameInMap("cg_zxstate")
        public String cgZxstate;

        @NameInMap("cgdate")
        public String cgdate;

        @NameInMap("cgname")
        public String cgname;

        @NameInMap("cgno")
        public String cgno;

        @NameInMap("cgremark")
        public String cgremark;

        @NameInMap("cgtype")
        public String cgtype;

        @NameInMap("child_mx")
        public String childMx;

        @NameInMap("data_userid")
        public String dataUserid;

        @NameInMap("empid")
        public String empid;

        @NameInMap("gys_lxrid")
        public String gysLxrid;

        @NameInMap("gys_lxrinfo")
        public String gysLxrinfo;

        @NameInMap("gysid")
        public String gysid;

        @NameInMap("gysjingban")
        public String gysjingban;

        @NameInMap("order_htid")
        public String orderHtid;

        @NameInMap("order_khid")
        public String orderKhid;

        @NameInMap("summoney")
        public String summoney;

        public static EditPurchaseRequestData build(java.util.Map<String, ?> map) throws Exception {
            EditPurchaseRequestData self = new EditPurchaseRequestData();
            return TeaModel.build(map, self);
        }

        public EditPurchaseRequestData setCgFjmoney(String cgFjmoney) {
            this.cgFjmoney = cgFjmoney;
            return this;
        }
        public String getCgFjmoney() {
            return this.cgFjmoney;
        }

        public EditPurchaseRequestData setCgFjmoneylx(String cgFjmoneylx) {
            this.cgFjmoneylx = cgFjmoneylx;
            return this;
        }
        public String getCgFjmoneylx() {
            return this.cgFjmoneylx;
        }

        public EditPurchaseRequestData setCgKjmoney(String cgKjmoney) {
            this.cgKjmoney = cgKjmoney;
            return this;
        }
        public String getCgKjmoney() {
            return this.cgKjmoney;
        }

        public EditPurchaseRequestData setCgMoneyzhekou(String cgMoneyzhekou) {
            this.cgMoneyzhekou = cgMoneyzhekou;
            return this;
        }
        public String getCgMoneyzhekou() {
            return this.cgMoneyzhekou;
        }

        public EditPurchaseRequestData setCgZxstate(String cgZxstate) {
            this.cgZxstate = cgZxstate;
            return this;
        }
        public String getCgZxstate() {
            return this.cgZxstate;
        }

        public EditPurchaseRequestData setCgdate(String cgdate) {
            this.cgdate = cgdate;
            return this;
        }
        public String getCgdate() {
            return this.cgdate;
        }

        public EditPurchaseRequestData setCgname(String cgname) {
            this.cgname = cgname;
            return this;
        }
        public String getCgname() {
            return this.cgname;
        }

        public EditPurchaseRequestData setCgno(String cgno) {
            this.cgno = cgno;
            return this;
        }
        public String getCgno() {
            return this.cgno;
        }

        public EditPurchaseRequestData setCgremark(String cgremark) {
            this.cgremark = cgremark;
            return this;
        }
        public String getCgremark() {
            return this.cgremark;
        }

        public EditPurchaseRequestData setCgtype(String cgtype) {
            this.cgtype = cgtype;
            return this;
        }
        public String getCgtype() {
            return this.cgtype;
        }

        public EditPurchaseRequestData setChildMx(String childMx) {
            this.childMx = childMx;
            return this;
        }
        public String getChildMx() {
            return this.childMx;
        }

        public EditPurchaseRequestData setDataUserid(String dataUserid) {
            this.dataUserid = dataUserid;
            return this;
        }
        public String getDataUserid() {
            return this.dataUserid;
        }

        public EditPurchaseRequestData setEmpid(String empid) {
            this.empid = empid;
            return this;
        }
        public String getEmpid() {
            return this.empid;
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

        public EditPurchaseRequestData setGysid(String gysid) {
            this.gysid = gysid;
            return this;
        }
        public String getGysid() {
            return this.gysid;
        }

        public EditPurchaseRequestData setGysjingban(String gysjingban) {
            this.gysjingban = gysjingban;
            return this;
        }
        public String getGysjingban() {
            return this.gysjingban;
        }

        public EditPurchaseRequestData setOrderHtid(String orderHtid) {
            this.orderHtid = orderHtid;
            return this;
        }
        public String getOrderHtid() {
            return this.orderHtid;
        }

        public EditPurchaseRequestData setOrderKhid(String orderKhid) {
            this.orderKhid = orderKhid;
            return this;
        }
        public String getOrderKhid() {
            return this.orderKhid;
        }

        public EditPurchaseRequestData setSummoney(String summoney) {
            this.summoney = summoney;
            return this;
        }
        public String getSummoney() {
            return this.summoney;
        }

    }

}
