// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgTodoTasksResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryOrgTodoTasksResponseBody body;

    public static QueryOrgTodoTasksResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgTodoTasksResponse self = new QueryOrgTodoTasksResponse();
        return TeaModel.build(map, self);
    }

    public QueryOrgTodoTasksResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOrgTodoTasksResponse setBody(QueryOrgTodoTasksResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOrgTodoTasksResponseBody getBody() {
        return this.body;
    }

}
