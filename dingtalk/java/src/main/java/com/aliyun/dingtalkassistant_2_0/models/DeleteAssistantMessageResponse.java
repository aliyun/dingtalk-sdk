// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_2_0.models;

import com.aliyun.tea.*;

public class DeleteAssistantMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteAssistantMessageResponseBody body;

    public static DeleteAssistantMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteAssistantMessageResponse self = new DeleteAssistantMessageResponse();
        return TeaModel.build(map, self);
    }

    public DeleteAssistantMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteAssistantMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteAssistantMessageResponse setBody(DeleteAssistantMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteAssistantMessageResponseBody getBody() {
        return this.body;
    }

}
