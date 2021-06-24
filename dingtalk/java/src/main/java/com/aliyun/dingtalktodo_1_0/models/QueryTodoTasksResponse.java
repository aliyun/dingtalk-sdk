// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class QueryTodoTasksResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryTodoTasksResponseBody body;

    public static QueryTodoTasksResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTodoTasksResponse self = new QueryTodoTasksResponse();
        return TeaModel.build(map, self);
    }

    public QueryTodoTasksResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTodoTasksResponse setBody(QueryTodoTasksResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTodoTasksResponseBody getBody() {
        return this.body;
    }

}
