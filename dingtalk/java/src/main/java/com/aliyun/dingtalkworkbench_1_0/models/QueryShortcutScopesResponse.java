// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class QueryShortcutScopesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryShortcutScopesResponseBody body;

    public static QueryShortcutScopesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryShortcutScopesResponse self = new QueryShortcutScopesResponse();
        return TeaModel.build(map, self);
    }

    public QueryShortcutScopesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryShortcutScopesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryShortcutScopesResponse setBody(QueryShortcutScopesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryShortcutScopesResponseBody getBody() {
        return this.body;
    }

}
