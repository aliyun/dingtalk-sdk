// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QuerySchemaAndProcessResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QuerySchemaAndProcessResponseBody body;

    public static QuerySchemaAndProcessResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySchemaAndProcessResponse self = new QuerySchemaAndProcessResponse();
        return TeaModel.build(map, self);
    }

    public QuerySchemaAndProcessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySchemaAndProcessResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySchemaAndProcessResponse setBody(QuerySchemaAndProcessResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySchemaAndProcessResponseBody getBody() {
        return this.body;
    }

}
