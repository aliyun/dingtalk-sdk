// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryPositionVersionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryPositionVersionResponseBody body;

    public static QueryPositionVersionResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPositionVersionResponse self = new QueryPositionVersionResponse();
        return TeaModel.build(map, self);
    }

    public QueryPositionVersionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPositionVersionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryPositionVersionResponse setBody(QueryPositionVersionResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPositionVersionResponseBody getBody() {
        return this.body;
    }

}
