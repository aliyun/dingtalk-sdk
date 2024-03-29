// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskStageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public UpdateTaskStageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateTaskStageResponse setBody(UpdateTaskStageResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTaskStageResponseBody getBody() {
        return this.body;
    }

}
