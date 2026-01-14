// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_2_0.models;

import com.aliyun.tea.*;

public class RetrieveAssistantMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RetrieveAssistantMessageResponseBody body;

    public static RetrieveAssistantMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        RetrieveAssistantMessageResponse self = new RetrieveAssistantMessageResponse();
        return TeaModel.build(map, self);
    }

    public RetrieveAssistantMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RetrieveAssistantMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RetrieveAssistantMessageResponse setBody(RetrieveAssistantMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public RetrieveAssistantMessageResponseBody getBody() {
        return this.body;
    }

}
