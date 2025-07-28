// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryBizMinutesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryBizMinutesResponseBody body;

    public static QueryBizMinutesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryBizMinutesResponse self = new QueryBizMinutesResponse();
        return TeaModel.build(map, self);
    }

    public QueryBizMinutesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryBizMinutesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryBizMinutesResponse setBody(QueryBizMinutesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBizMinutesResponseBody getBody() {
        return this.body;
    }

}
