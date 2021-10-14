// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryPayAccountListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryPayAccountListResponseBody body;

    public static QueryPayAccountListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPayAccountListResponse self = new QueryPayAccountListResponse();
        return TeaModel.build(map, self);
    }

    public QueryPayAccountListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPayAccountListResponse setBody(QueryPayAccountListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPayAccountListResponseBody getBody() {
        return this.body;
    }

}
