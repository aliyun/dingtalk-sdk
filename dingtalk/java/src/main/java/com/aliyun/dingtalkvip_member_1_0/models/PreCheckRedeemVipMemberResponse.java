// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvip_member_1_0.models;

import com.aliyun.tea.*;

public class PreCheckRedeemVipMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PreCheckRedeemVipMemberResponseBody body;

    public static PreCheckRedeemVipMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        PreCheckRedeemVipMemberResponse self = new PreCheckRedeemVipMemberResponse();
        return TeaModel.build(map, self);
    }

    public PreCheckRedeemVipMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PreCheckRedeemVipMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PreCheckRedeemVipMemberResponse setBody(PreCheckRedeemVipMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public PreCheckRedeemVipMemberResponseBody getBody() {
        return this.body;
    }

}
