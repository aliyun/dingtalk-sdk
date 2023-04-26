// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryUserBehaviorResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryUserBehaviorResponseBody body;

    public static QueryUserBehaviorResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserBehaviorResponse self = new QueryUserBehaviorResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserBehaviorResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserBehaviorResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserBehaviorResponse setBody(QueryUserBehaviorResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserBehaviorResponseBody getBody() {
        return this.body;
    }

}
