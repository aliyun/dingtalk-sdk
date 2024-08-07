// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class CreateAssistantThreadResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateAssistantThreadResponseBody body;

    public static CreateAssistantThreadResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateAssistantThreadResponse self = new CreateAssistantThreadResponse();
        return TeaModel.build(map, self);
    }

    public CreateAssistantThreadResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateAssistantThreadResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateAssistantThreadResponse setBody(CreateAssistantThreadResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateAssistantThreadResponseBody getBody() {
        return this.body;
    }

}
