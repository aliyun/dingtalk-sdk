// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateChecklistRuleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateChecklistRuleResponseBody body;

    public static CreateChecklistRuleResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateChecklistRuleResponse self = new CreateChecklistRuleResponse();
        return TeaModel.build(map, self);
    }

    public CreateChecklistRuleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateChecklistRuleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateChecklistRuleResponse setBody(CreateChecklistRuleResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateChecklistRuleResponseBody getBody() {
        return this.body;
    }

}
