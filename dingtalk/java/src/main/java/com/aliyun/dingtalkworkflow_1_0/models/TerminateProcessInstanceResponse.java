// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class TerminateProcessInstanceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public TerminateProcessInstanceResponseBody body;

    public static TerminateProcessInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        TerminateProcessInstanceResponse self = new TerminateProcessInstanceResponse();
        return TeaModel.build(map, self);
    }

    public TerminateProcessInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TerminateProcessInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TerminateProcessInstanceResponse setBody(TerminateProcessInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public TerminateProcessInstanceResponseBody getBody() {
        return this.body;
    }

}
