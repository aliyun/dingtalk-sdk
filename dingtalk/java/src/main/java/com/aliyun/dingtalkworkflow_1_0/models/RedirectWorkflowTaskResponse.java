// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class RedirectWorkflowTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public RedirectWorkflowTaskResponse setBody(RedirectWorkflowTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public RedirectWorkflowTaskResponseBody getBody() {
        return this.body;
    }

}
