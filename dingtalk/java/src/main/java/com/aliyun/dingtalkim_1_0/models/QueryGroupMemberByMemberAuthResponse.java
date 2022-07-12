// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMemberByMemberAuthResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryGroupMemberByMemberAuthResponse setBody(QueryGroupMemberByMemberAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupMemberByMemberAuthResponseBody getBody() {
        return this.body;
    }

}