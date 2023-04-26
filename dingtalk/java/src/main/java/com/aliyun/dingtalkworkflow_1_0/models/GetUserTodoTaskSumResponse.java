// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetUserTodoTaskSumResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetUserTodoTaskSumResponseBody body;

    public static GetUserTodoTaskSumResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserTodoTaskSumResponse self = new GetUserTodoTaskSumResponse();
        return TeaModel.build(map, self);
    }

    public GetUserTodoTaskSumResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserTodoTaskSumResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserTodoTaskSumResponse setBody(GetUserTodoTaskSumResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserTodoTaskSumResponseBody getBody() {
        return this.body;
    }

}
