// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryBatchTradeOrderRequest extends TeaModel {
    // ISV/企业自建应用suiteId
    @NameInMap("suiteId")
    public String suiteId;

    // ISV的cropId
    @NameInMap("isvCorpId")
    public String isvCorpId;

    // 外部商户批次号列表
    @NameInMap("outBatchNos")
    public java.util.List<String> outBatchNos;

    public static QueryBatchTradeOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryBatchTradeOrderRequest self = new QueryBatchTradeOrderRequest();
        return TeaModel.build(map, self);
    }

    public QueryBatchTradeOrderRequest setSuiteId(String suiteId) {
        this.suiteId = suiteId;
        return this;
    }
    public String getSuiteId() {
        return this.suiteId;
    }

    public QueryBatchTradeOrderRequest setIsvCorpId(String isvCorpId) {
        this.isvCorpId = isvCorpId;
        return this;
    }
    public String getIsvCorpId() {
        return this.isvCorpId;
    }

    public QueryBatchTradeOrderRequest setOutBatchNos(java.util.List<String> outBatchNos) {
        this.outBatchNos = outBatchNos;
        return this;
    }
    public java.util.List<String> getOutBatchNos() {
        return this.outBatchNos;
    }

}
