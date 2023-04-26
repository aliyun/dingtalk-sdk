// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class ChannelOrdersRequest extends TeaModel {
    @NameInMap("itemCode")
    public String itemCode;

    @NameInMap("itemName")
    public String itemName;

    @NameInMap("orderCreateTime")
    public Float orderCreateTime;

    @NameInMap("orderId")
    public String orderId;

    @NameInMap("payFee")
    public Float payFee;

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
