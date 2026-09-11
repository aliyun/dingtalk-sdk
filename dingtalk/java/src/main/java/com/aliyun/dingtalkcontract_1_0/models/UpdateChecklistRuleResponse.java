// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class UpdateChecklistRuleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateChecklistRuleResponseBody body;

    public static UpdateChecklistRuleResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateChecklistRuleResponse self = new UpdateChecklistRuleResponse();
        return TeaModel.build(map, self);
    }

    public UpdateChecklistRuleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateChecklistRuleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateChecklistRuleResponse setBody(UpdateChecklistRuleResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateChecklistRuleResponseBody getBody() {
        return this.body;
    }

}
