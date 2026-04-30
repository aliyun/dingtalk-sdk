// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetGroupMembersByUserTokenResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetGroupMembersByUserTokenResponseBody body;

    public static GetGroupMembersByUserTokenResponse build(java.util.Map<String, ?> map) throws Exception {
        GetGroupMembersByUserTokenResponse self = new GetGroupMembersByUserTokenResponse();
        return TeaModel.build(map, self);
    }

    public GetGroupMembersByUserTokenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetGroupMembersByUserTokenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetGroupMembersByUserTokenResponse setBody(GetGroupMembersByUserTokenResponseBody body) {
        this.body = body;
        return this;
    }
    public GetGroupMembersByUserTokenResponseBody getBody() {
        return this.body;
    }

}
