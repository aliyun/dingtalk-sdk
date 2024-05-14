// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class OrderResaleRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
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
    @NameInMap("quantity")
    public Long quantity;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("serviceStartTime")
    public Long serviceStartTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("serviceStopTime")
    public Long serviceStopTime;

    public static OrderResaleRequest build(java.util.Map<String, ?> map) throws Exception {
        OrderResaleRequest self = new OrderResaleRequest();
        return TeaModel.build(map, self);
    }

    public OrderResaleRequest setOrderCreateTime(Long orderCreateTime) {
        this.orderCreateTime = orderCreateTime;
        return this;
    }
    public Long getOrderCreateTime() {
        return this.orderCreateTime;
    }

    public OrderResaleRequest setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

    public OrderResaleRequest setQuantity(Long quantity) {
        this.quantity = quantity;
        return this;
    }
    public Long getQuantity() {
        return this.quantity;
    }

    public OrderResaleRequest setServiceStartTime(Long serviceStartTime) {
        this.serviceStartTime = serviceStartTime;
        return this;
    }
    public Long getServiceStartTime() {
        return this.serviceStartTime;
    }

    public OrderResaleRequest setServiceStopTime(Long serviceStopTime) {
        this.serviceStopTime = serviceStopTime;
        return this;
    }
    public Long getServiceStopTime() {
        return this.serviceStopTime;
    }

}
