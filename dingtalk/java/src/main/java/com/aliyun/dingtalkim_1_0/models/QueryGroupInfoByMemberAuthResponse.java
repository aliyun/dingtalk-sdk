// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupInfoByMemberAuthResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryGroupInfoByMemberAuthResponseBody body;

    public static QueryGroupInfoByMemberAuthResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupInfoByMemberAuthResponse self = new QueryGroupInfoByMemberAuthResponse();
        return TeaModel.build(map, self);
    }

    public QueryGroupInfoByMemberAuthResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGroupInfoByMemberAuthResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGroupInfoByMemberAuthResponse setBody(QueryGroupInfoByMemberAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupInfoByMemberAuthResponseBody getBody() {
        return this.body;
    }

}
