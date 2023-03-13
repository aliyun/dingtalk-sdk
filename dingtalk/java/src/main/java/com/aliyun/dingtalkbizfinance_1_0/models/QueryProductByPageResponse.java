// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryProductByPageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryProductByPageResponseBody body;

    public static QueryProductByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryProductByPageResponse self = new QueryProductByPageResponse();
        return TeaModel.build(map, self);
    }

    public QueryProductByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryProductByPageResponse setBody(QueryProductByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryProductByPageResponseBody getBody() {
        return this.body;
    }

}
