// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractExtractResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryContractExtractResultResponseBody body;

    public static QueryContractExtractResultResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryContractExtractResultResponse self = new QueryContractExtractResultResponse();
        return TeaModel.build(map, self);
    }

    public QueryContractExtractResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryContractExtractResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryContractExtractResultResponse setBody(QueryContractExtractResultResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryContractExtractResultResponseBody getBody() {
        return this.body;
    }

}
