// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class UpdateIntegratedTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public UpdateIntegratedTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateIntegratedTaskResponse setBody(UpdateIntegratedTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateIntegratedTaskResponseBody getBody() {
        return this.body;
    }

}
