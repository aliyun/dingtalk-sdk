// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class QueryTaskOfProjectResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryTaskOfProjectResponseBody body;

    public static QueryTaskOfProjectResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTaskOfProjectResponse self = new QueryTaskOfProjectResponse();
        return TeaModel.build(map, self);
    }

    public QueryTaskOfProjectResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTaskOfProjectResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryTaskOfProjectResponse setBody(QueryTaskOfProjectResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTaskOfProjectResponseBody getBody() {
        return this.body;
    }

}
