// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetTodoTasksResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumGetTodoTasksResponseBody body;

    public static PremiumGetTodoTasksResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetTodoTasksResponse self = new PremiumGetTodoTasksResponse();
        return TeaModel.build(map, self);
    }

    public PremiumGetTodoTasksResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumGetTodoTasksResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumGetTodoTasksResponse setBody(PremiumGetTodoTasksResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumGetTodoTasksResponseBody getBody() {
        return this.body;
    }

}
