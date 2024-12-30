// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractCompareResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryContractCompareResultResponseBody body;

    public static QueryContractCompareResultResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryContractCompareResultResponse self = new QueryContractCompareResultResponse();
        return TeaModel.build(map, self);
    }

    public QueryContractCompareResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryContractCompareResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryContractCompareResultResponse setBody(QueryContractCompareResultResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryContractCompareResultResponseBody getBody() {
        return this.body;
    }

}
