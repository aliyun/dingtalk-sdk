// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskStageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateTaskStageResponseBody body;

    public static UpdateTaskStageResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskStageResponse self = new UpdateTaskStageResponse();
        return TeaModel.build(map, self);
    }

    public UpdateTaskStageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateTaskStageResponse setBody(UpdateTaskStageResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTaskStageResponseBody getBody() {
        return this.body;
    }

}
