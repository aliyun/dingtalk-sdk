// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class QueryTradeOrderRequest extends TeaModel {
    // 外部订单号
    @NameInMap("outerOrderId")
    public String outerOrderId;

    // 内部订单号
    @NameInMap("orderId")
    public Long orderId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    public static QueryTradeOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryTradeOrderRequest self = new QueryTradeOrderRequest();
        return TeaModel.build(map, self);
    }

    public QueryTradeOrderRequest setOuterOrderId(String outerOrderId) {
        this.outerOrderId = outerOrderId;
        return this;
    }
    public String getOuterOrderId() {
        return this.outerOrderId;
    }

    public QueryTradeOrderRequest setOrderId(Long orderId) {
        this.orderId = orderId;
        return this;
    }
    public Long getOrderId() {
        return this.orderId;
    }

    public QueryTradeOrderRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public QueryTradeOrderRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

}
