// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditQuotationRecordRequest extends TeaModel {
    // 编辑数据
    @NameInMap("data")
    public EditQuotationRecordRequestData data;

    // 数据类型，固定填写161
    @NameInMap("datatype")
    public Long datatype;

    // 数据id，不填或者填0为新增数据
    @NameInMap("msgid")
    public Long msgid;

    // 时间戳
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
        // 报价人
        @NameInMap("bj_bjren")
        public String bjBjren;

        // 包装运输
        @NameInMap("bj_bzremark")
        public String bjBzremark;

        // 对应客户
        @NameInMap("bj_customerid")
        public String bjCustomerid;

        // 报价日期
        @NameInMap("bj_date")
        public String bjDate;

        // 附加费用金额
        @NameInMap("bj_fjmoney")
        public String bjFjmoney;

        // 附加费用分类
        @NameInMap("bj_fjmoneylx")
        public String bjFjmoneylx;

        // 付款说明
        @NameInMap("bj_fkremark")
        public String bjFkremark;

        // 交付说明
        @NameInMap("bj_jfremark")
        public String bjJfremark;

        // 接收人
        @NameInMap("bj_jshren")
        public String bjJshren;

        // 优惠抹零金额
        @NameInMap("bj_kjmoney")
        public String bjKjmoney;

        // 联系方式
        @NameInMap("bj_lianxi")
        public String bjLianxi;

        // 优惠折扣率
        @NameInMap("bj_moneyzhekou")
        public String bjMoneyzhekou;

        // 报价单号
        @NameInMap("bj_number")
        public String bjNumber;

        // 报价(总)
        @NameInMap("bj_price")
        public String bjPrice;

        // 备注
        @NameInMap("bj_remark")
        public String bjRemark;

        // 转成订单
        @NameInMap("bj_state")
        public String bjState;

        // 主题
        @NameInMap("bj_title")
        public String bjTitle;

        // 对应机会
        @NameInMap("bj_xshid")
        public String bjXshid;

        // 产品明细，json格式
        @NameInMap("child_mx")
        public String childMx;

        // 创建人
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
