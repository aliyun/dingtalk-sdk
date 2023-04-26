// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class QueryTradeOrderRequest extends TeaModel {
    @NameInMap("orderId")
    public Long orderId;

    @NameInMap("outerOrderId")
    public String outerOrderId;

    public static QueryTradeOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryTradeOrderRequest self = new QueryTradeOrderRequest();
        return TeaModel.build(map, self);
    }

    public QueryTradeOrderRequest setOrderId(Long orderId) {
        this.orderId = orderId;
        return this;
    }
    public Long getOrderId() {
        return this.orderId;
    }

    public QueryTradeOrderRequest setOuterOrderId(String outerOrderId) {
        this.outerOrderId = outerOrderId;
        return this;
    }
    public String getOuterOrderId() {
        return this.outerOrderId;
    }

}
