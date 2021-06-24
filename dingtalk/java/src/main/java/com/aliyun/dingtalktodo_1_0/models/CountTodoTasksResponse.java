// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CountTodoTasksResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CountTodoTasksResponseBody body;

    public static CountTodoTasksResponse build(java.util.Map<String, ?> map) throws Exception {
        CountTodoTasksResponse self = new CountTodoTasksResponse();
        return TeaModel.build(map, self);
    }

    public CountTodoTasksResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CountTodoTasksResponse setBody(CountTodoTasksResponseBody body) {
        this.body = body;
        return this;
    }
    public CountTodoTasksResponseBody getBody() {
        return this.body;
    }

}
