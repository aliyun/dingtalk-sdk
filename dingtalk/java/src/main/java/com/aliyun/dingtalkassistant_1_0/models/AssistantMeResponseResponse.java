// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class AssistantMeResponseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AssistantMeResponseResponseBody body;

    public static AssistantMeResponseResponse build(java.util.Map<String, ?> map) throws Exception {
        AssistantMeResponseResponse self = new AssistantMeResponseResponse();
        return TeaModel.build(map, self);
    }

    public AssistantMeResponseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AssistantMeResponseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AssistantMeResponseResponse setBody(AssistantMeResponseResponseBody body) {
        this.body = body;
        return this;
    }
    public AssistantMeResponseResponseBody getBody() {
        return this.body;
    }

}
