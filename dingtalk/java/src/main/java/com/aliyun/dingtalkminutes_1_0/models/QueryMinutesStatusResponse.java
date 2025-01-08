// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMinutesStatusResponseBody body;

    public static QueryMinutesStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesStatusResponse self = new QueryMinutesStatusResponse();
        return TeaModel.build(map, self);
    }

    public QueryMinutesStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMinutesStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMinutesStatusResponse setBody(QueryMinutesStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMinutesStatusResponseBody getBody() {
        return this.body;
    }

}
