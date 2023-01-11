// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class ChannelOrdersRequest extends TeaModel {
    /**
     * <p>商品id</p>
     */
    @NameInMap("itemCode")
    public String itemCode;

    /**
     * <p>商品名称</p>
     */
    @NameInMap("itemName")
    public String itemName;

    /**
     * <p>下单时间</p>
     */
    @NameInMap("orderCreateTime")
    public Float orderCreateTime;

    /**
     * <p>isv方的订单Id（用于幂等，请保证唯一性）</p>
     */
    @NameInMap("orderId")
    public String orderId;

    /**
     * <p>支付金额（以分为单位，仅作记录，不作为凭证）</p>
     */
    @NameInMap("payFee")
    public Float payFee;

    /**
     * <p>购买数量</p>
     */
    @NameInMap("quantity")
    public Float quantity;

    public static ChannelOrdersRequest build(java.util.Map<String, ?> map) throws Exception {
        ChannelOrdersRequest self = new ChannelOrdersRequest();
        return TeaModel.build(map, self);
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

    public ChannelOrdersRequest setOrderCreateTime(Float orderCreateTime) {
        this.orderCreateTime = orderCreateTime;
        return this;
    }
    public Float getOrderCreateTime() {
        return this.orderCreateTime;
    }

    public ChannelOrdersRequest setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

    public ChannelOrdersRequest setPayFee(Float payFee) {
        this.payFee = payFee;
        return this;
    }
    public Float getPayFee() {
        return this.payFee;
    }

    public ChannelOrdersRequest setQuantity(Float quantity) {
        this.quantity = quantity;
        return this;
    }
    public Float getQuantity() {
        return this.quantity;
    }

}
