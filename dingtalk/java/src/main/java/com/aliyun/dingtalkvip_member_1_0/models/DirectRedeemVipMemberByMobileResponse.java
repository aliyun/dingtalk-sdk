// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvip_member_1_0.models;

import com.aliyun.tea.*;

public class DirectRedeemVipMemberByMobileResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DirectRedeemVipMemberByMobileResponseBody body;

    public static DirectRedeemVipMemberByMobileResponse build(java.util.Map<String, ?> map) throws Exception {
        DirectRedeemVipMemberByMobileResponse self = new DirectRedeemVipMemberByMobileResponse();
        return TeaModel.build(map, self);
    }

    public DirectRedeemVipMemberByMobileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DirectRedeemVipMemberByMobileResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DirectRedeemVipMemberByMobileResponse setBody(DirectRedeemVipMemberByMobileResponseBody body) {
        this.body = body;
        return this;
    }
    public DirectRedeemVipMemberByMobileResponseBody getBody() {
        return this.body;
    }

}
