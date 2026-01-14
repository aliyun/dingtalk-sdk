// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_2_0.models;

import com.aliyun.tea.*;

public class RetrieveAssistantThreadResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RetrieveAssistantThreadResponseBody body;

    public static RetrieveAssistantThreadResponse build(java.util.Map<String, ?> map) throws Exception {
        RetrieveAssistantThreadResponse self = new RetrieveAssistantThreadResponse();
        return TeaModel.build(map, self);
    }

    public RetrieveAssistantThreadResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RetrieveAssistantThreadResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RetrieveAssistantThreadResponse setBody(RetrieveAssistantThreadResponseBody body) {
        this.body = body;
        return this;
    }
    public RetrieveAssistantThreadResponseBody getBody() {
        return this.body;
    }

}
