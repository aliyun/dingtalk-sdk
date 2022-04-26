// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserCredentialsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryUserCredentialsResponseBody body;

    public static QueryUserCredentialsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserCredentialsResponse self = new QueryUserCredentialsResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserCredentialsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserCredentialsResponse setBody(QueryUserCredentialsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserCredentialsResponseBody getBody() {
        return this.body;
    }

}
