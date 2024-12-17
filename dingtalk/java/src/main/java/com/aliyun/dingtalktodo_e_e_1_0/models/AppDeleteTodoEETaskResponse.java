// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class AppDeleteTodoEETaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AppDeleteTodoEETaskResponseBody body;

    public static AppDeleteTodoEETaskResponse build(java.util.Map<String, ?> map) throws Exception {
        AppDeleteTodoEETaskResponse self = new AppDeleteTodoEETaskResponse();
        return TeaModel.build(map, self);
    }

    public AppDeleteTodoEETaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AppDeleteTodoEETaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AppDeleteTodoEETaskResponse setBody(AppDeleteTodoEETaskResponseBody body) {
        this.body = body;
        return this;
    }
    public AppDeleteTodoEETaskResponseBody getBody() {
        return this.body;
    }

}
