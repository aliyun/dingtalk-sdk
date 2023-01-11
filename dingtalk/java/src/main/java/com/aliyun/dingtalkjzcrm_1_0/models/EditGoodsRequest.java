// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditGoodsRequest extends TeaModel {
    /**
     * <p>编辑数据</p>
     */
    @NameInMap("data")
    public EditGoodsRequestData data;

    /**
     * <p>数据类型，固定填写154</p>
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
        /**
         * <p>上架时间</p>
         */
        @NameInMap("addedtime")
        public String addedtime;

        /**
         * <p>成本价格</p>
         */
        @NameInMap("cbprice")
        public String cbprice;

        /**
         * <p>基准产品</p>
         */
        @NameInMap("cp_parentid")
        public String cpParentid;

        /**
         * <p>产品产地</p>
         */
        @NameInMap("cparea")
        public String cparea;

        /**
         * <p>条形码</p>
         */
        @NameInMap("cpbarcode")
        public String cpbarcode;

        /**
         * <p>产品品牌</p>
         */
        @NameInMap("cpbrand")
        public String cpbrand;

        /**
         * <p>产品说明</p>
         */
        @NameInMap("cpcontent")
        public String cpcontent;

        /**
         * <p>产品规格</p>
         */
        @NameInMap("cpguige")
        public String cpguige;

        /**
         * <p>产品图片</p>
         */
        @NameInMap("cpimg")
        public String cpimg;

        /**
         * <p>产品名称</p>
         */
        @NameInMap("cpname")
        public String cpname;

        /**
         * <p>产品编号</p>
         */
        @NameInMap("cpno")
        public String cpno;

        /**
         * <p>产品备注</p>
         */
        @NameInMap("cpremark")
        public String cpremark;

        /**
         * <p>产品型号</p>
         */
        @NameInMap("cptype")
        public String cptype;

        /**
         * <p>产品单位</p>
         */
        @NameInMap("cpunit")
        public String cpunit;

        /**
         * <p>产品重量</p>
         */
        @NameInMap("cpweight")
        public String cpweight;

        /**
         * <p>创建人</p>
         */
        @NameInMap("data_userid")
        public String dataUserid;

        /**
         * <p>默认供应商</p>
         */
        @NameInMap("gysid")
        public String gysid;

        /**
         * <p>批次号管理（是，否）</p>
         */
        @NameInMap("ispicimanage")
        public String ispicimanage;

        /**
         * <p>序列号管理（是，否）</p>
         */
        @NameInMap("issnmanage")
        public String issnmanage;

        /**
         * <p>是否算库存（计算，不计算，计算(按基准规格)）</p>
         */
        @NameInMap("isstock")
        public String isstock;

        /**
         * <p>产品状态（正常，停售，下架）</p>
         */
        @NameInMap("isstop")
        public String isstop;

        /**
         * <p>零售价格</p>
         */
        @NameInMap("preprice1")
        public String preprice1;

        /**
         * <p>预设价格1</p>
         */
        @NameInMap("preprice2")
        public String preprice2;

        /**
         * <p>预设价格2</p>
         */
        @NameInMap("preprice3")
        public String preprice3;

        /**
         * <p>预设价格3</p>
         */
        @NameInMap("preprice4")
        public String preprice4;

        /**
         * <p>库存下限</p>
         */
        @NameInMap("stockdown")
        public String stockdown;

        /**
         * <p>库存上限</p>
         */
        @NameInMap("stockup")
        public String stockup;

        /**
         * <p>产品类别</p>
         */
        @NameInMap("typeid")
        public String typeid;

        /**
         * <p>单位换算</p>
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
