// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class QueryComponentScopesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryComponentScopesResponseBody body;

    public static QueryComponentScopesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryComponentScopesResponse self = new QueryComponentScopesResponse();
        return TeaModel.build(map, self);
    }

    public QueryComponentScopesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryComponentScopesResponse setBody(QueryComponentScopesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryComponentScopesResponseBody getBody() {
        return this.body;
    }

}
