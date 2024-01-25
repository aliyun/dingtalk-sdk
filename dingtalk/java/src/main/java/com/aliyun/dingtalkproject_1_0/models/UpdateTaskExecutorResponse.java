// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskExecutorResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateTaskExecutorResponseBody body;

    public static UpdateTaskExecutorResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskExecutorResponse self = new UpdateTaskExecutorResponse();
        return TeaModel.build(map, self);
    }

    public UpdateTaskExecutorResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateTaskExecutorResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateTaskExecutorResponse setBody(UpdateTaskExecutorResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTaskExecutorResponseBody getBody() {
        return this.body;
    }

}
