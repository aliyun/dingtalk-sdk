// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUnReadMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUnReadMessageResponseBody body;

    public static QueryUnReadMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUnReadMessageResponse self = new QueryUnReadMessageResponse();
        return TeaModel.build(map, self);
    }

    public QueryUnReadMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUnReadMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUnReadMessageResponse setBody(QueryUnReadMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUnReadMessageResponseBody getBody() {
        return this.body;
    }

}
