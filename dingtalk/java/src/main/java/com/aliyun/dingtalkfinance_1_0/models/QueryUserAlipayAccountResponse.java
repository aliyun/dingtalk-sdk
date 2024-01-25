// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryUserAlipayAccountResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUserAlipayAccountResponseBody body;

    public static QueryUserAlipayAccountResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserAlipayAccountResponse self = new QueryUserAlipayAccountResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserAlipayAccountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserAlipayAccountResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserAlipayAccountResponse setBody(QueryUserAlipayAccountResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserAlipayAccountResponseBody getBody() {
        return this.body;
    }

}
