// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class QueryUserFollowStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryUserFollowStatusResponseBody body;

    public static QueryUserFollowStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserFollowStatusResponse self = new QueryUserFollowStatusResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserFollowStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserFollowStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserFollowStatusResponse setBody(QueryUserFollowStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserFollowStatusResponseBody getBody() {
        return this.body;
    }

}
