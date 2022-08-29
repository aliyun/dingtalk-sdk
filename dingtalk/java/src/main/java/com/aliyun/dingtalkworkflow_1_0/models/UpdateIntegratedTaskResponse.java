// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class UpdateIntegratedTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateIntegratedTaskResponseBody body;

    public static UpdateIntegratedTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateIntegratedTaskResponse self = new UpdateIntegratedTaskResponse();
        return TeaModel.build(map, self);
    }

    public UpdateIntegratedTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateIntegratedTaskResponse setBody(UpdateIntegratedTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateIntegratedTaskResponseBody getBody() {
        return this.body;
    }

}
