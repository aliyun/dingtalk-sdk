// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class PublishRuleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public PublishRuleResponseBody body;

    public static PublishRuleResponse build(java.util.Map<String, ?> map) throws Exception {
        PublishRuleResponse self = new PublishRuleResponse();
        return TeaModel.build(map, self);
    }

    public PublishRuleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PublishRuleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PublishRuleResponse setBody(PublishRuleResponseBody body) {
        this.body = body;
        return this;
    }
    public PublishRuleResponseBody getBody() {
        return this.body;
    }

}
