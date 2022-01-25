// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPayResultResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryPayResultResponseBody body;

    public static QueryPayResultResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPayResultResponse self = new QueryPayResultResponse();
        return TeaModel.build(map, self);
    }

    public QueryPayResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPayResultResponse setBody(QueryPayResultResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPayResultResponseBody getBody() {
        return this.body;
    }

}
