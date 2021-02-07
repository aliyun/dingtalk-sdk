// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class OrderResaleRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("serviceStartTime")
    public Long serviceStartTime;

    @NameInMap("serviceStopTime")
    public Long serviceStopTime;

    @NameInMap("orderCreateTime")
    public Long orderCreateTime;

    @NameInMap("orderId")
    public String orderId;

    @NameInMap("quantity")
    public Long quantity;

    @NameInMap("dingIsvAccessToken")
    public String dingIsvAccessToken;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    public static OrderResaleRequest build(java.util.Map<String, ?> map) throws Exception {
        OrderResaleRequest self = new OrderResaleRequest();
        return TeaModel.build(map, self);
    }

    public OrderResaleRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public OrderResaleRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
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

    public OrderResaleRequest setDingIsvAccessToken(String dingIsvAccessToken) {
        this.dingIsvAccessToken = dingIsvAccessToken;
        return this;
    }
    public String getDingIsvAccessToken() {
        return this.dingIsvAccessToken;
    }

    public OrderResaleRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

}
