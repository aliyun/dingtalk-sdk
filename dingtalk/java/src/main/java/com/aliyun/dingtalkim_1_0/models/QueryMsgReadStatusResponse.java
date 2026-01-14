// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryMsgReadStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMsgReadStatusResponseBody body;

    public static QueryMsgReadStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMsgReadStatusResponse self = new QueryMsgReadStatusResponse();
        return TeaModel.build(map, self);
    }

    public QueryMsgReadStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMsgReadStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMsgReadStatusResponse setBody(QueryMsgReadStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMsgReadStatusResponseBody getBody() {
        return this.body;
    }

}
