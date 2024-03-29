// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetWebChannelUserTokenResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetWebChannelUserTokenResponseBody body;

    public static GetWebChannelUserTokenResponse build(java.util.Map<String, ?> map) throws Exception {
        GetWebChannelUserTokenResponse self = new GetWebChannelUserTokenResponse();
        return TeaModel.build(map, self);
    }

    public GetWebChannelUserTokenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetWebChannelUserTokenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetWebChannelUserTokenResponse setBody(GetWebChannelUserTokenResponseBody body) {
        this.body = body;
        return this;
    }
    public GetWebChannelUserTokenResponseBody getBody() {
        return this.body;
    }

}
