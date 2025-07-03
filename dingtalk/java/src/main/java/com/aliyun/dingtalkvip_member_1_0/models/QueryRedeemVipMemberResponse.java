// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvip_member_1_0.models;

import com.aliyun.tea.*;

public class QueryRedeemVipMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryRedeemVipMemberResponseBody body;

    public static QueryRedeemVipMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryRedeemVipMemberResponse self = new QueryRedeemVipMemberResponse();
        return TeaModel.build(map, self);
    }

    public QueryRedeemVipMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryRedeemVipMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryRedeemVipMemberResponse setBody(QueryRedeemVipMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRedeemVipMemberResponseBody getBody() {
        return this.body;
    }

}
