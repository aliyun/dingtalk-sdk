// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryUserFaceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUserFaceResponseBody body;

    public static QueryUserFaceResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserFaceResponse self = new QueryUserFaceResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserFaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserFaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserFaceResponse setBody(QueryUserFaceResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserFaceResponseBody getBody() {
        return this.body;
    }

}
