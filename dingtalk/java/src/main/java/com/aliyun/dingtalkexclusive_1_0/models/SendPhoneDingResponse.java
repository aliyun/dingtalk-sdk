// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SendPhoneDingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SendPhoneDingResponseBody body;

    public static SendPhoneDingResponse build(java.util.Map<String, ?> map) throws Exception {
        SendPhoneDingResponse self = new SendPhoneDingResponse();
        return TeaModel.build(map, self);
    }

    public SendPhoneDingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendPhoneDingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendPhoneDingResponse setBody(SendPhoneDingResponseBody body) {
        this.body = body;
        return this;
    }
    public SendPhoneDingResponseBody getBody() {
        return this.body;
    }

}
