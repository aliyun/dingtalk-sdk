// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class DeleteAssistantThreadResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteAssistantThreadResponseBody body;

    public static DeleteAssistantThreadResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteAssistantThreadResponse self = new DeleteAssistantThreadResponse();
        return TeaModel.build(map, self);
    }

    public DeleteAssistantThreadResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteAssistantThreadResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteAssistantThreadResponse setBody(DeleteAssistantThreadResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteAssistantThreadResponseBody getBody() {
        return this.body;
    }

}
