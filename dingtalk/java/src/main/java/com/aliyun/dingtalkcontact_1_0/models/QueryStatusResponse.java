// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryStatusResponseBody body;

    public static QueryStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryStatusResponse self = new QueryStatusResponse();
        return TeaModel.build(map, self);
    }

    public QueryStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryStatusResponse setBody(QueryStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryStatusResponseBody getBody() {
        return this.body;
    }

}
