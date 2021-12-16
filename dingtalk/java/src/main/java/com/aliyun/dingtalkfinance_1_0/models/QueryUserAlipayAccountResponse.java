// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryUserAlipayAccountResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryUserAlipayAccountResponse setBody(QueryUserAlipayAccountResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserAlipayAccountResponseBody getBody() {
        return this.body;
    }

}
