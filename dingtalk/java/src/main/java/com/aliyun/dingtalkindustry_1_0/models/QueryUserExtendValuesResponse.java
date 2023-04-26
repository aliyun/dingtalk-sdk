// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserExtendValuesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryUserExtendValuesResponseBody body;

    public static QueryUserExtendValuesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserExtendValuesResponse self = new QueryUserExtendValuesResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserExtendValuesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserExtendValuesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserExtendValuesResponse setBody(QueryUserExtendValuesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserExtendValuesResponseBody getBody() {
        return this.body;
    }

}
