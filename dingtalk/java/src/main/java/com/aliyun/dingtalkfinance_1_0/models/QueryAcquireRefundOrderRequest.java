// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryAcquireRefundOrderRequest extends TeaModel {
    // 外部退款订单流水号
    @NameInMap("outRefundNo")
    public String outRefundNo;

    public static QueryAcquireRefundOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAcquireRefundOrderRequest self = new QueryAcquireRefundOrderRequest();
        return TeaModel.build(map, self);
    }

    public QueryAcquireRefundOrderRequest setOutRefundNo(String outRefundNo) {
        this.outRefundNo = outRefundNo;
        return this;
    }
    public String getOutRefundNo() {
        return this.outRefundNo;
    }

}
