// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class QueryAllTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAllTaskResponseBody body;

    public static QueryAllTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAllTaskResponse self = new QueryAllTaskResponse();
        return TeaModel.build(map, self);
    }

    public QueryAllTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAllTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAllTaskResponse setBody(QueryAllTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAllTaskResponseBody getBody() {
        return this.body;
    }

}
