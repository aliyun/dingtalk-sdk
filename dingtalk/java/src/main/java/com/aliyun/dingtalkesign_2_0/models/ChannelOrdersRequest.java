// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class ChannelOrdersRequest extends TeaModel {
    @NameInMap("dingCorpId")
    public String dingCorpId;

    // isv方的订单Id（用于幂等，请保证唯一性）
    @NameInMap("orderId")
    public String orderId;

    // 商品id
    @NameInMap("itemCode")
    public String itemCode;

    // 商品名称
    @NameInMap("itemName")
    public String itemName;

    // 购买数量
    @NameInMap("quantity")
    public Float quantity;

    // 支付金额（以分为单位，仅作记录，不作为凭证）
    @NameInMap("payFee")
    public Float payFee;

    // 下单时间
    @NameInMap("orderCreateTime")
    public Float orderCreateTime;

    public static ChannelOrdersRequest build(java.util.Map<String, ?> map) throws Exception {
        ChannelOrdersRequest self = new ChannelOrdersRequest();
        return TeaModel.build(map, self);
    }

    public ChannelOrdersRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public ChannelOrdersRequest setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

    public ChannelOrdersRequest setItemCode(String itemCode) {
        this.itemCode = itemCode;
        return this;
    }
    public String getItemCode() {
        return this.itemCode;
    }

    public ChannelOrdersRequest setItemName(String itemName) {
        this.itemName = itemName;
        return this;
    }
    public String getItemName() {
        return this.itemName;
    }

    public ChannelOrdersRequest setQuantity(Float quantity) {
        this.quantity = quantity;
        return this;
    }
    public Float getQuantity() {
        return this.quantity;
    }

    public ChannelOrdersRequest setPayFee(Float payFee) {
        this.payFee = payFee;
        return this;
    }
    public Float getPayFee() {
        return this.payFee;
    }

    public ChannelOrdersRequest setOrderCreateTime(Float orderCreateTime) {
        this.orderCreateTime = orderCreateTime;
        return this;
    }
    public Float getOrderCreateTime() {
        return this.orderCreateTime;
    }

}
