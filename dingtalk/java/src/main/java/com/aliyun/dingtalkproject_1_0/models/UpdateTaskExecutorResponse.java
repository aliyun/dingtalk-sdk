// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskExecutorResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public UpdateTaskExecutorResponse setBody(UpdateTaskExecutorResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTaskExecutorResponseBody getBody() {
        return this.body;
    }

}
