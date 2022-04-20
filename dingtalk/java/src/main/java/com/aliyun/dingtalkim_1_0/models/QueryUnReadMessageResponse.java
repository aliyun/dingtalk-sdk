// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUnReadMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryUnReadMessageResponse setBody(QueryUnReadMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUnReadMessageResponseBody getBody() {
        return this.body;
    }

}
