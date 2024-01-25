// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryGroupMemberResponseBody body;

    public static QueryGroupMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMemberResponse self = new QueryGroupMemberResponse();
        return TeaModel.build(map, self);
    }

    public QueryGroupMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGroupMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGroupMemberResponse setBody(QueryGroupMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupMemberResponseBody getBody() {
        return this.body;
    }

}
