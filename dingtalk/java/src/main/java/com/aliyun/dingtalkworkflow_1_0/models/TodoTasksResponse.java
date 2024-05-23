// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class TodoTasksResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TodoTasksResponseBody body;

    public static TodoTasksResponse build(java.util.Map<String, ?> map) throws Exception {
        TodoTasksResponse self = new TodoTasksResponse();
        return TeaModel.build(map, self);
    }

    public TodoTasksResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TodoTasksResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TodoTasksResponse setBody(TodoTasksResponseBody body) {
        this.body = body;
        return this;
    }
    public TodoTasksResponseBody getBody() {
        return this.body;
    }

}
