// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryIntegratedTodoTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryIntegratedTodoTaskResponseBody body;

    public static QueryIntegratedTodoTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryIntegratedTodoTaskResponse self = new QueryIntegratedTodoTaskResponse();
        return TeaModel.build(map, self);
    }

    public QueryIntegratedTodoTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryIntegratedTodoTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryIntegratedTodoTaskResponse setBody(QueryIntegratedTodoTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryIntegratedTodoTaskResponseBody getBody() {
        return this.body;
    }

}
