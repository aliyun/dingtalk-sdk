// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class UpdateProcessInstanceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateProcessInstanceResponseBody body;

    public static UpdateProcessInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateProcessInstanceResponse self = new UpdateProcessInstanceResponse();
        return TeaModel.build(map, self);
    }

    public UpdateProcessInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateProcessInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateProcessInstanceResponse setBody(UpdateProcessInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateProcessInstanceResponseBody getBody() {
        return this.body;
    }

}
