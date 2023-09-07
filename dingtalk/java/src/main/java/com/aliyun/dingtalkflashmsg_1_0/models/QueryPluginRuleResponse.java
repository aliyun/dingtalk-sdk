// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class QueryPluginRuleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryPluginRuleResponseBody body;

    public static QueryPluginRuleResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPluginRuleResponse self = new QueryPluginRuleResponse();
        return TeaModel.build(map, self);
    }

    public QueryPluginRuleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPluginRuleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryPluginRuleResponse setBody(QueryPluginRuleResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPluginRuleResponseBody getBody() {
        return this.body;
    }

}
