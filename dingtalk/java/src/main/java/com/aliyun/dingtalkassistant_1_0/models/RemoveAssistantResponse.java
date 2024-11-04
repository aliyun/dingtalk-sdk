// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RemoveAssistantResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RemoveAssistantResponseBody body;

    public static RemoveAssistantResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveAssistantResponse self = new RemoveAssistantResponse();
        return TeaModel.build(map, self);
    }

    public RemoveAssistantResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemoveAssistantResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RemoveAssistantResponse setBody(RemoveAssistantResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveAssistantResponseBody getBody() {
        return this.body;
    }

}
