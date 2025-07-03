// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvip_member_1_0.models;

import com.aliyun.tea.*;

public class InvalidRedeemVipMemberByBizRequestIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InvalidRedeemVipMemberByBizRequestIdResponseBody body;

    public static InvalidRedeemVipMemberByBizRequestIdResponse build(java.util.Map<String, ?> map) throws Exception {
        InvalidRedeemVipMemberByBizRequestIdResponse self = new InvalidRedeemVipMemberByBizRequestIdResponse();
        return TeaModel.build(map, self);
    }

    public InvalidRedeemVipMemberByBizRequestIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InvalidRedeemVipMemberByBizRequestIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InvalidRedeemVipMemberByBizRequestIdResponse setBody(InvalidRedeemVipMemberByBizRequestIdResponseBody body) {
        this.body = body;
        return this;
    }
    public InvalidRedeemVipMemberByBizRequestIdResponseBody getBody() {
        return this.body;
    }

}
