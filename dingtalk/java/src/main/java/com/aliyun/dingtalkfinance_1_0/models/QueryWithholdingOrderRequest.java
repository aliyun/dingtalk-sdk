// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryWithholdingOrderRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>202100001</p>
     */
    @NameInMap("outTradeNo")
    public String outTradeNo;

    public static QueryWithholdingOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryWithholdingOrderRequest self = new QueryWithholdingOrderRequest();
        return TeaModel.build(map, self);
    }

    public QueryWithholdingOrderRequest setOutTradeNo(String outTradeNo) {
        this.outTradeNo = outTradeNo;
        return this;
    }
    public String getOutTradeNo() {
        return this.outTradeNo;
    }

}
