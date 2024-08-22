// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class CreateAssistantResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateAssistantResponseBody body;

    public static CreateAssistantResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateAssistantResponse self = new CreateAssistantResponse();
        return TeaModel.build(map, self);
    }

    public CreateAssistantResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateAssistantResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateAssistantResponse setBody(CreateAssistantResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateAssistantResponseBody getBody() {
        return this.body;
    }

}
