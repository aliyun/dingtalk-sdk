// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUserGroupAliasTitleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUserGroupAliasTitleResponseBody body;

    public static QueryUserGroupAliasTitleResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserGroupAliasTitleResponse self = new QueryUserGroupAliasTitleResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserGroupAliasTitleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserGroupAliasTitleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserGroupAliasTitleResponse setBody(QueryUserGroupAliasTitleResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserGroupAliasTitleResponseBody getBody() {
        return this.body;
    }

}
