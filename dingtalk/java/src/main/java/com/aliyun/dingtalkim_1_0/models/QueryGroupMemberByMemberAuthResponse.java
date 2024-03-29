// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMemberByMemberAuthResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryGroupMemberByMemberAuthResponseBody body;

    public static QueryGroupMemberByMemberAuthResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMemberByMemberAuthResponse self = new QueryGroupMemberByMemberAuthResponse();
        return TeaModel.build(map, self);
    }

    public QueryGroupMemberByMemberAuthResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGroupMemberByMemberAuthResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGroupMemberByMemberAuthResponse setBody(QueryGroupMemberByMemberAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupMemberByMemberAuthResponseBody getBody() {
        return this.body;
    }

}
