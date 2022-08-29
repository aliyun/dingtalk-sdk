// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class CreateIntegratedTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateIntegratedTaskResponseBody body;

    public static CreateIntegratedTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateIntegratedTaskResponse self = new CreateIntegratedTaskResponse();
        return TeaModel.build(map, self);
    }

    public CreateIntegratedTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateIntegratedTaskResponse setBody(CreateIntegratedTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateIntegratedTaskResponseBody getBody() {
        return this.body;
    }

}
