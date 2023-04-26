// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserExtInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryUserExtInfoResponseBody body;

    public static QueryUserExtInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserExtInfoResponse self = new QueryUserExtInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserExtInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserExtInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserExtInfoResponse setBody(QueryUserExtInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserExtInfoResponseBody getBody() {
        return this.body;
    }

}
