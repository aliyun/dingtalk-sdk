// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryGroupIdResponse setBody(QueryGroupIdResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupIdResponseBody getBody() {
        return this.body;
    }

}
