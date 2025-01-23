// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesPlayInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMinutesPlayInfoResponseBody body;

    public static QueryMinutesPlayInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesPlayInfoResponse self = new QueryMinutesPlayInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryMinutesPlayInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMinutesPlayInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMinutesPlayInfoResponse setBody(QueryMinutesPlayInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMinutesPlayInfoResponseBody getBody() {
        return this.body;
    }

}
