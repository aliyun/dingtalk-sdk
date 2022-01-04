// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryRegisterOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryRegisterOrderResponse setBody(QueryRegisterOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRegisterOrderResponseBody getBody() {
        return this.body;
    }

}
