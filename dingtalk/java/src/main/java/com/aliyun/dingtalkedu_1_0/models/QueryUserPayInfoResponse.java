// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryUserPayInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryUserPayInfoResponseBody body;

    public static QueryUserPayInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserPayInfoResponse self = new QueryUserPayInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserPayInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserPayInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserPayInfoResponse setBody(QueryUserPayInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserPayInfoResponseBody getBody() {
        return this.body;
    }

}
