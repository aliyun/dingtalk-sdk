// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditGoodsRequest extends TeaModel {
    @NameInMap("data")
    public EditGoodsRequestData data;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>154</p>
     */
    @NameInMap("datatype")
    public Long datatype;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("msgid")
    public Long msgid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1621822122</p>
     */
    @NameInMap("stamp")
    public Long stamp;

    public static EditGoodsRequest build(java.util.Map<String, ?> map) throws Exception {
        EditGoodsRequest self = new EditGoodsRequest();
        return TeaModel.build(map, self);
    }

    public EditGoodsRequest setData(EditGoodsRequestData data) {
        this.data = data;
        return this;
    }
    public EditGoodsRequestData getData() {
        return this.data;
    }

    public EditGoodsRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditGoodsRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditGoodsRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public static class EditGoodsRequestData extends TeaModel {
        @NameInMap("addedtime")
        public String addedtime;

        @NameInMap("cbprice")
        public String cbprice;

        @NameInMap("cp_parentid")
        public String cpParentid;

        @NameInMap("cparea")
        public String cparea;

        @NameInMap("cpbarcode")
        public String cpbarcode;

        @NameInMap("cpbrand")
        public String cpbrand;

        @NameInMap("cpcontent")
        public String cpcontent;

        @NameInMap("cpguige")
        public String cpguige;

        @NameInMap("cpimg")
        public String cpimg;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("cpname")
        public String cpname;

        @NameInMap("cpno")
        public String cpno;

        @NameInMap("cpremark")
        public String cpremark;

        @NameInMap("cptype")
        public String cptype;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("cpunit")
        public String cpunit;

        @NameInMap("cpweight")
        public String cpweight;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>张三</p>
         * 
         * <strong>if can be null:</strong>
         * <p>false</p>
         */
        @NameInMap("data_userid")
        public String dataUserid;

        @NameInMap("gysid")
        public String gysid;

        @NameInMap("ispicimanage")
        public String ispicimanage;

        @NameInMap("issnmanage")
        public String issnmanage;

        @NameInMap("isstock")
        public String isstock;

        @NameInMap("isstop")
        public String isstop;

        @NameInMap("preprice1")
        public String preprice1;

        @NameInMap("preprice2")
        public String preprice2;

        @NameInMap("preprice3")
        public String preprice3;

        @NameInMap("preprice4")
        public String preprice4;

        @NameInMap("stockdown")
        public String stockdown;

        @NameInMap("stockup")
        public String stockup;

        @NameInMap("typeid")
        public String typeid;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unitrate")
        public String unitrate;

        public static EditGoodsRequestData build(java.util.Map<String, ?> map) throws Exception {
            EditGoodsRequestData self = new EditGoodsRequestData();
            return TeaModel.build(map, self);
        }

        public EditGoodsRequestData setAddedtime(String addedtime) {
            this.addedtime = addedtime;
            return this;
        }
        public String getAddedtime() {
            return this.addedtime;
        }

        public EditGoodsRequestData setCbprice(String cbprice) {
            this.cbprice = cbprice;
            return this;
        }
        public String getCbprice() {
            return this.cbprice;
        }

        public EditGoodsRequestData setCpParentid(String cpParentid) {
            this.cpParentid = cpParentid;
            return this;
        }
        public String getCpParentid() {
            return this.cpParentid;
        }

        public EditGoodsRequestData setCparea(String cparea) {
            this.cparea = cparea;
            return this;
        }
        public String getCparea() {
            return this.cparea;
        }

        public EditGoodsRequestData setCpbarcode(String cpbarcode) {
            this.cpbarcode = cpbarcode;
            return this;
        }
        public String getCpbarcode() {
            return this.cpbarcode;
        }

        public EditGoodsRequestData setCpbrand(String cpbrand) {
            this.cpbrand = cpbrand;
            return this;
        }
        public String getCpbrand() {
            return this.cpbrand;
        }

        public EditGoodsRequestData setCpcontent(String cpcontent) {
            this.cpcontent = cpcontent;
            return this;
        }
        public String getCpcontent() {
            return this.cpcontent;
        }

        public EditGoodsRequestData setCpguige(String cpguige) {
            this.cpguige = cpguige;
            return this;
        }
        public String getCpguige() {
            return this.cpguige;
        }

        public EditGoodsRequestData setCpimg(String cpimg) {
            this.cpimg = cpimg;
            return this;
        }
        public String getCpimg() {
            return this.cpimg;
        }

        public EditGoodsRequestData setCpname(String cpname) {
            this.cpname = cpname;
            return this;
        }
        public String getCpname() {
            return this.cpname;
        }

        public EditGoodsRequestData setCpno(String cpno) {
            this.cpno = cpno;
            return this;
        }
        public String getCpno() {
            return this.cpno;
        }

        public EditGoodsRequestData setCpremark(String cpremark) {
            this.cpremark = cpremark;
            return this;
        }
        public String getCpremark() {
            return this.cpremark;
        }

        public EditGoodsRequestData setCptype(String cptype) {
            this.cptype = cptype;
            return this;
        }
        public String getCptype() {
            return this.cptype;
        }

        public EditGoodsRequestData setCpunit(String cpunit) {
            this.cpunit = cpunit;
            return this;
        }
        public String getCpunit() {
            return this.cpunit;
        }

        public EditGoodsRequestData setCpweight(String cpweight) {
            this.cpweight = cpweight;
            return this;
        }
        public String getCpweight() {
            return this.cpweight;
        }

        public EditGoodsRequestData setDataUserid(String dataUserid) {
            this.dataUserid = dataUserid;
            return this;
        }
        public String getDataUserid() {
            return this.dataUserid;
        }

        public EditGoodsRequestData setGysid(String gysid) {
            this.gysid = gysid;
            return this;
        }
        public String getGysid() {
            return this.gysid;
        }

        public EditGoodsRequestData setIspicimanage(String ispicimanage) {
            this.ispicimanage = ispicimanage;
            return this;
        }
        public String getIspicimanage() {
            return this.ispicimanage;
        }

        public EditGoodsRequestData setIssnmanage(String issnmanage) {
            this.issnmanage = issnmanage;
            return this;
        }
        public String getIssnmanage() {
            return this.issnmanage;
        }

        public EditGoodsRequestData setIsstock(String isstock) {
            this.isstock = isstock;
            return this;
        }
        public String getIsstock() {
            return this.isstock;
        }

        public EditGoodsRequestData setIsstop(String isstop) {
            this.isstop = isstop;
            return this;
        }
        public String getIsstop() {
            return this.isstop;
        }

        public EditGoodsRequestData setPreprice1(String preprice1) {
            this.preprice1 = preprice1;
            return this;
        }
        public String getPreprice1() {
            return this.preprice1;
        }

        public EditGoodsRequestData setPreprice2(String preprice2) {
            this.preprice2 = preprice2;
            return this;
        }
        public String getPreprice2() {
            return this.preprice2;
        }

        public EditGoodsRequestData setPreprice3(String preprice3) {
            this.preprice3 = preprice3;
            return this;
        }
        public String getPreprice3() {
            return this.preprice3;
        }

        public EditGoodsRequestData setPreprice4(String preprice4) {
            this.preprice4 = preprice4;
            return this;
        }
        public String getPreprice4() {
            return this.preprice4;
        }

        public EditGoodsRequestData setStockdown(String stockdown) {
            this.stockdown = stockdown;
            return this;
        }
        public String getStockdown() {
            return this.stockdown;
        }

        public EditGoodsRequestData setStockup(String stockup) {
            this.stockup = stockup;
            return this;
        }
        public String getStockup() {
            return this.stockup;
        }

        public EditGoodsRequestData setTypeid(String typeid) {
            this.typeid = typeid;
            return this;
        }
        public String getTypeid() {
            return this.typeid;
        }

        public EditGoodsRequestData setUnitrate(String unitrate) {
            this.unitrate = unitrate;
            return this;
        }
        public String getUnitrate() {
            return this.unitrate;
        }

    }

}
