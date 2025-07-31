// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class DeployAssistantResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeployAssistantResponseBody body;

    public static DeployAssistantResponse build(java.util.Map<String, ?> map) throws Exception {
        DeployAssistantResponse self = new DeployAssistantResponse();
        return TeaModel.build(map, self);
    }

    public DeployAssistantResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeployAssistantResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeployAssistantResponse setBody(DeployAssistantResponseBody body) {
        this.body = body;
        return this;
    }
    public DeployAssistantResponseBody getBody() {
        return this.body;
    }

}
