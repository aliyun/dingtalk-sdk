// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateConditionalFormattingRuleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateConditionalFormattingRuleResponseBody body;

    public static CreateConditionalFormattingRuleResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateConditionalFormattingRuleResponse self = new CreateConditionalFormattingRuleResponse();
        return TeaModel.build(map, self);
    }

    public CreateConditionalFormattingRuleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateConditionalFormattingRuleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateConditionalFormattingRuleResponse setBody(CreateConditionalFormattingRuleResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateConditionalFormattingRuleResponseBody getBody() {
        return this.body;
    }

}
