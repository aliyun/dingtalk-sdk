// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryFormInstanceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryFormInstanceResponseBody body;

    public static QueryFormInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryFormInstanceResponse self = new QueryFormInstanceResponse();
        return TeaModel.build(map, self);
    }

    public QueryFormInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryFormInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryFormInstanceResponse setBody(QueryFormInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryFormInstanceResponseBody getBody() {
        return this.body;
    }

}
