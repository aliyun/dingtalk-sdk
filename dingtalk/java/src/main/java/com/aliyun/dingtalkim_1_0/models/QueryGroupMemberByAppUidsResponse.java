// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMemberByAppUidsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryGroupMemberByAppUidsResponseBody body;

    public static QueryGroupMemberByAppUidsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMemberByAppUidsResponse self = new QueryGroupMemberByAppUidsResponse();
        return TeaModel.build(map, self);
    }

    public QueryGroupMemberByAppUidsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGroupMemberByAppUidsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGroupMemberByAppUidsResponse setBody(QueryGroupMemberByAppUidsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupMemberByAppUidsResponseBody getBody() {
        return this.body;
    }

}
