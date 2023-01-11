// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class ResaleOrderRequest extends TeaModel {
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
     * <p>购买数量（电子合同份数）</p>
     */
    @NameInMap("quantity")
    public Float quantity;

    /**
     * <p>合同生效起始时间</p>
     */
    @NameInMap("serviceStartTime")
    public Float serviceStartTime;

    /**
     * <p>合同失效截止日期，默认有效时间一年</p>
     */
    @NameInMap("serviceStopTime")
    public Float serviceStopTime;

    public static ResaleOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        ResaleOrderRequest self = new ResaleOrderRequest();
        return TeaModel.build(map, self);
    }

    public ResaleOrderRequest setOrderCreateTime(Float orderCreateTime) {
        this.orderCreateTime = orderCreateTime;
        return this;
    }
    public Float getOrderCreateTime() {
        return this.orderCreateTime;
    }

    public ResaleOrderRequest setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

    public ResaleOrderRequest setQuantity(Float quantity) {
        this.quantity = quantity;
        return this;
    }
    public Float getQuantity() {
        return this.quantity;
    }

    public ResaleOrderRequest setServiceStartTime(Float serviceStartTime) {
        this.serviceStartTime = serviceStartTime;
        return this;
    }
    public Float getServiceStartTime() {
        return this.serviceStartTime;
    }

    public ResaleOrderRequest setServiceStopTime(Float serviceStopTime) {
        this.serviceStopTime = serviceStopTime;
        return this;
    }
    public Float getServiceStopTime() {
        return this.serviceStopTime;
    }

}
