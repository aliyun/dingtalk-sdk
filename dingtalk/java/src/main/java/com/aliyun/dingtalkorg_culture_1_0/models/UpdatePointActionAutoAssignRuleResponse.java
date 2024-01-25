// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class UpdatePointActionAutoAssignRuleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdatePointActionAutoAssignRuleResponseBody body;

    public static UpdatePointActionAutoAssignRuleResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdatePointActionAutoAssignRuleResponse self = new UpdatePointActionAutoAssignRuleResponse();
        return TeaModel.build(map, self);
    }

    public UpdatePointActionAutoAssignRuleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdatePointActionAutoAssignRuleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdatePointActionAutoAssignRuleResponse setBody(UpdatePointActionAutoAssignRuleResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdatePointActionAutoAssignRuleResponseBody getBody() {
        return this.body;
    }

}
