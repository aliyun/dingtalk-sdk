// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryRegisterOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryRegisterOrderResponseBody body;

    public static QueryRegisterOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryRegisterOrderResponse self = new QueryRegisterOrderResponse();
        return TeaModel.build(map, self);
    }

    public QueryRegisterOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryRegisterOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryRegisterOrderResponse setBody(QueryRegisterOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRegisterOrderResponseBody getBody() {
        return this.body;
    }

}
