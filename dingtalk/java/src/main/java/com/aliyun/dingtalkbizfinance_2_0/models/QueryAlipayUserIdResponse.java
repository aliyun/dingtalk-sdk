// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryAlipayUserIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAlipayUserIdResponseBody body;

    public static QueryAlipayUserIdResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAlipayUserIdResponse self = new QueryAlipayUserIdResponse();
        return TeaModel.build(map, self);
    }

    public QueryAlipayUserIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAlipayUserIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAlipayUserIdResponse setBody(QueryAlipayUserIdResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAlipayUserIdResponseBody getBody() {
        return this.body;
    }

}
