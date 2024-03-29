// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUserInfoResponseBody body;

    public static QueryUserInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserInfoResponse self = new QueryUserInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserInfoResponse setBody(QueryUserInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserInfoResponseBody getBody() {
        return this.body;
    }

}
