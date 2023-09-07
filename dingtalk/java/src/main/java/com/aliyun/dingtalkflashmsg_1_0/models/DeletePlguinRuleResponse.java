// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class DeletePlguinRuleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DeletePlguinRuleResponseBody body;

    public static DeletePlguinRuleResponse build(java.util.Map<String, ?> map) throws Exception {
        DeletePlguinRuleResponse self = new DeletePlguinRuleResponse();
        return TeaModel.build(map, self);
    }

    public DeletePlguinRuleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeletePlguinRuleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeletePlguinRuleResponse setBody(DeletePlguinRuleResponseBody body) {
        this.body = body;
        return this;
    }
    public DeletePlguinRuleResponseBody getBody() {
        return this.body;
    }

}
