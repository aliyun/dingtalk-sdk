// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryBatchTradeOrderRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("outBatchNos")
    public java.util.List<String> outBatchNos;

    public static QueryBatchTradeOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryBatchTradeOrderRequest self = new QueryBatchTradeOrderRequest();
        return TeaModel.build(map, self);
    }

    public QueryBatchTradeOrderRequest setOutBatchNos(java.util.List<String> outBatchNos) {
        this.outBatchNos = outBatchNos;
        return this;
    }
    public java.util.List<String> getOutBatchNos() {
        return this.outBatchNos;
    }

}
