// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QuerySubscribeStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QuerySubscribeStatusResponseBody body;

    public static QuerySubscribeStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySubscribeStatusResponse self = new QuerySubscribeStatusResponse();
        return TeaModel.build(map, self);
    }

    public QuerySubscribeStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySubscribeStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySubscribeStatusResponse setBody(QuerySubscribeStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySubscribeStatusResponseBody getBody() {
        return this.body;
    }

}
