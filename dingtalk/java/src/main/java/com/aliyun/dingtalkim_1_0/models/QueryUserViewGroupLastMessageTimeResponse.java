// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUserViewGroupLastMessageTimeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUserViewGroupLastMessageTimeResponseBody body;

    public static QueryUserViewGroupLastMessageTimeResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserViewGroupLastMessageTimeResponse self = new QueryUserViewGroupLastMessageTimeResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserViewGroupLastMessageTimeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserViewGroupLastMessageTimeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserViewGroupLastMessageTimeResponse setBody(QueryUserViewGroupLastMessageTimeResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserViewGroupLastMessageTimeResponseBody getBody() {
        return this.body;
    }

}
