// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class CopyWorkflowResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CopyWorkflowResponseBody body;

    public static CopyWorkflowResponse build(java.util.Map<String, ?> map) throws Exception {
        CopyWorkflowResponse self = new CopyWorkflowResponse();
        return TeaModel.build(map, self);
    }

    public CopyWorkflowResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CopyWorkflowResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CopyWorkflowResponse setBody(CopyWorkflowResponseBody body) {
        this.body = body;
        return this;
    }
    public CopyWorkflowResponseBody getBody() {
        return this.body;
    }

}
