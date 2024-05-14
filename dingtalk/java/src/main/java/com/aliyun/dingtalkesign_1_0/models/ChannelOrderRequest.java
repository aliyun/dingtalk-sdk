// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class ChannelOrderRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("itemCode")
    public String itemCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("itemName")
    public String itemName;

    @NameInMap("orderCreateTime")
    public Long orderCreateTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("orderId")
    public String orderId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("payFee")
    public Long payFee;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("quantity")
    public Long quantity;

    public static ChannelOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        ChannelOrderRequest self = new ChannelOrderRequest();
        return TeaModel.build(map, self);
    }

    public ChannelOrderRequest setItemCode(String itemCode) {
        this.itemCode = itemCode;
        return this;
    }
    public String getItemCode() {
        return this.itemCode;
    }

    public ChannelOrderRequest setItemName(String itemName) {
        this.itemName = itemName;
        return this;
    }
    public String getItemName() {
        return this.itemName;
    }

    public ChannelOrderRequest setOrderCreateTime(Long orderCreateTime) {
        this.orderCreateTime = orderCreateTime;
        return this;
    }
    public Long getOrderCreateTime() {
        return this.orderCreateTime;
    }

    public ChannelOrderRequest setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

    public ChannelOrderRequest setPayFee(Long payFee) {
        this.payFee = payFee;
        return this;
    }
    public Long getPayFee() {
        return this.payFee;
    }

    public ChannelOrderRequest setQuantity(Long quantity) {
        this.quantity = quantity;
        return this;
    }
    public Long getQuantity() {
        return this.quantity;
    }

}
