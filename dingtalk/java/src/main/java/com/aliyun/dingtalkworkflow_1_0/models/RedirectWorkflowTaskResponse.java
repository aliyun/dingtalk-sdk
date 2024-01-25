// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class RedirectWorkflowTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RedirectWorkflowTaskResponseBody body;

    public static RedirectWorkflowTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        RedirectWorkflowTaskResponse self = new RedirectWorkflowTaskResponse();
        return TeaModel.build(map, self);
    }

    public RedirectWorkflowTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RedirectWorkflowTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RedirectWorkflowTaskResponse setBody(RedirectWorkflowTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public RedirectWorkflowTaskResponseBody getBody() {
        return this.body;
    }

}
