// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_2_0.models;

import com.aliyun.tea.*;

public class CreateAssistantMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateAssistantMessageResponseBody body;

    public static CreateAssistantMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateAssistantMessageResponse self = new CreateAssistantMessageResponse();
        return TeaModel.build(map, self);
    }

    public CreateAssistantMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateAssistantMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateAssistantMessageResponse setBody(CreateAssistantMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateAssistantMessageResponseBody getBody() {
        return this.body;
    }

}
