// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesShareListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMinutesShareListResponseBody body;

    public static QueryMinutesShareListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesShareListResponse self = new QueryMinutesShareListResponse();
        return TeaModel.build(map, self);
    }

    public QueryMinutesShareListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMinutesShareListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMinutesShareListResponse setBody(QueryMinutesShareListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMinutesShareListResponseBody getBody() {
        return this.body;
    }

}
