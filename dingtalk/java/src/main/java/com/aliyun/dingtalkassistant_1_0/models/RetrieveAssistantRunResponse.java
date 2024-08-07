// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RetrieveAssistantRunResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RetrieveAssistantRunResponseBody body;

    public static RetrieveAssistantRunResponse build(java.util.Map<String, ?> map) throws Exception {
        RetrieveAssistantRunResponse self = new RetrieveAssistantRunResponse();
        return TeaModel.build(map, self);
    }

    public RetrieveAssistantRunResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RetrieveAssistantRunResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RetrieveAssistantRunResponse setBody(RetrieveAssistantRunResponseBody body) {
        this.body = body;
        return this;
    }
    public RetrieveAssistantRunResponseBody getBody() {
        return this.body;
    }

}
