// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class AddPluginRuleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddPluginRuleResponseBody body;

    public static AddPluginRuleResponse build(java.util.Map<String, ?> map) throws Exception {
        AddPluginRuleResponse self = new AddPluginRuleResponse();
        return TeaModel.build(map, self);
    }

    public AddPluginRuleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddPluginRuleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddPluginRuleResponse setBody(AddPluginRuleResponseBody body) {
        this.body = body;
        return this;
    }
    public AddPluginRuleResponseBody getBody() {
        return this.body;
    }

}
