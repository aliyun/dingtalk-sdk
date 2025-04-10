// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class AssistantResponseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AssistantResponseResponseBody body;

    public static AssistantResponseResponse build(java.util.Map<String, ?> map) throws Exception {
        AssistantResponseResponse self = new AssistantResponseResponse();
        return TeaModel.build(map, self);
    }

    public AssistantResponseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AssistantResponseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AssistantResponseResponse setBody(AssistantResponseResponseBody body) {
        this.body = body;
        return this;
    }
    public AssistantResponseResponseBody getBody() {
        return this.body;
    }

}
