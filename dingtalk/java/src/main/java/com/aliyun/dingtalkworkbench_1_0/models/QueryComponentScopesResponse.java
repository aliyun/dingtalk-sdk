// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class QueryComponentScopesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public QueryComponentScopesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryComponentScopesResponse setBody(QueryComponentScopesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryComponentScopesResponseBody getBody() {
        return this.body;
    }

}
