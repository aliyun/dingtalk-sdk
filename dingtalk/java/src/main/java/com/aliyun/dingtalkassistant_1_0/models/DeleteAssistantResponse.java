// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class DeleteAssistantResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteAssistantResponseBody body;

    public static DeleteAssistantResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteAssistantResponse self = new DeleteAssistantResponse();
        return TeaModel.build(map, self);
    }

    public DeleteAssistantResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteAssistantResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteAssistantResponse setBody(DeleteAssistantResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteAssistantResponseBody getBody() {
        return this.body;
    }

}
