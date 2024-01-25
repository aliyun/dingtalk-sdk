// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryGroupIdResponseBody body;

    public static QueryGroupIdResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupIdResponse self = new QueryGroupIdResponse();
        return TeaModel.build(map, self);
    }

    public QueryGroupIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGroupIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGroupIdResponse setBody(QueryGroupIdResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupIdResponseBody getBody() {
        return this.body;
    }

}
