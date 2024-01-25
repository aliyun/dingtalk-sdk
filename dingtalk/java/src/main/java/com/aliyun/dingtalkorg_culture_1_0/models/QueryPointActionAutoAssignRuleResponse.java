// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryPointActionAutoAssignRuleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryPointActionAutoAssignRuleResponseBody body;

    public static QueryPointActionAutoAssignRuleResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPointActionAutoAssignRuleResponse self = new QueryPointActionAutoAssignRuleResponse();
        return TeaModel.build(map, self);
    }

    public QueryPointActionAutoAssignRuleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPointActionAutoAssignRuleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryPointActionAutoAssignRuleResponse setBody(QueryPointActionAutoAssignRuleResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPointActionAutoAssignRuleResponseBody getBody() {
        return this.body;
    }

}
