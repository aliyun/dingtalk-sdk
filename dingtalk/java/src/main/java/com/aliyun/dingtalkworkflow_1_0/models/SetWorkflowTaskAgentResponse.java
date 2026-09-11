// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SetWorkflowTaskAgentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetWorkflowTaskAgentResponseBody body;

    public static SetWorkflowTaskAgentResponse build(java.util.Map<String, ?> map) throws Exception {
        SetWorkflowTaskAgentResponse self = new SetWorkflowTaskAgentResponse();
        return TeaModel.build(map, self);
    }

    public SetWorkflowTaskAgentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetWorkflowTaskAgentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetWorkflowTaskAgentResponse setBody(SetWorkflowTaskAgentResponseBody body) {
        this.body = body;
        return this;
    }
    public SetWorkflowTaskAgentResponseBody getBody() {
        return this.body;
    }

}
