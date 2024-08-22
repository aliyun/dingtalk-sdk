// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryMessageSendResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMessageSendResultResponseBody body;

    public static QueryMessageSendResultResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMessageSendResultResponse self = new QueryMessageSendResultResponse();
        return TeaModel.build(map, self);
    }

    public QueryMessageSendResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMessageSendResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMessageSendResultResponse setBody(QueryMessageSendResultResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMessageSendResultResponseBody getBody() {
        return this.body;
    }

}
