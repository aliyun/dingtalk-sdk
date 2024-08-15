// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RetrieveAssistantScopeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RetrieveAssistantScopeResponseBody body;

    public static RetrieveAssistantScopeResponse build(java.util.Map<String, ?> map) throws Exception {
        RetrieveAssistantScopeResponse self = new RetrieveAssistantScopeResponse();
        return TeaModel.build(map, self);
    }

    public RetrieveAssistantScopeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RetrieveAssistantScopeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RetrieveAssistantScopeResponse setBody(RetrieveAssistantScopeResponseBody body) {
        this.body = body;
        return this;
    }
    public RetrieveAssistantScopeResponseBody getBody() {
        return this.body;
    }

}
