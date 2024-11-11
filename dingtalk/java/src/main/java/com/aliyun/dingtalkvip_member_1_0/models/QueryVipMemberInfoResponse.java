// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvip_member_1_0.models;

import com.aliyun.tea.*;

public class QueryVipMemberInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryVipMemberInfoResponseBody body;

    public static QueryVipMemberInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryVipMemberInfoResponse self = new QueryVipMemberInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryVipMemberInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryVipMemberInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryVipMemberInfoResponse setBody(QueryVipMemberInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryVipMemberInfoResponseBody getBody() {
        return this.body;
    }

}
