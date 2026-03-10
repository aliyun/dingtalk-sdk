// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesChaptersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMinutesChaptersResponseBody body;

    public static QueryMinutesChaptersResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesChaptersResponse self = new QueryMinutesChaptersResponse();
        return TeaModel.build(map, self);
    }

    public QueryMinutesChaptersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMinutesChaptersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMinutesChaptersResponse setBody(QueryMinutesChaptersResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMinutesChaptersResponseBody getBody() {
        return this.body;
    }

}
