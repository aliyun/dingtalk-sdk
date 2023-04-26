// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryInstancesByMultiConditionsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryInstancesByMultiConditionsResponseBody body;

    public static QueryInstancesByMultiConditionsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryInstancesByMultiConditionsResponse self = new QueryInstancesByMultiConditionsResponse();
        return TeaModel.build(map, self);
    }

    public QueryInstancesByMultiConditionsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryInstancesByMultiConditionsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryInstancesByMultiConditionsResponse setBody(QueryInstancesByMultiConditionsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryInstancesByMultiConditionsResponseBody getBody() {
        return this.body;
    }

}
