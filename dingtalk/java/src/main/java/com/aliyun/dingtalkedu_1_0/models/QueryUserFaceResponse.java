// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryUserFaceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryUserFaceResponse setBody(QueryUserFaceResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserFaceResponseBody getBody() {
        return this.body;
    }

}
