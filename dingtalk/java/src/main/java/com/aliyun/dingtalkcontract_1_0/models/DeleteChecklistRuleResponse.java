// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class DeleteChecklistRuleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteChecklistRuleResponseBody body;

    public static DeleteChecklistRuleResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteChecklistRuleResponse self = new DeleteChecklistRuleResponse();
        return TeaModel.build(map, self);
    }

    public DeleteChecklistRuleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteChecklistRuleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteChecklistRuleResponse setBody(DeleteChecklistRuleResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteChecklistRuleResponseBody getBody() {
        return this.body;
    }

}
