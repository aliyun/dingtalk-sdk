// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetCidsByBotCodeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCidsByBotCodeResponseBody body;

    public static GetCidsByBotCodeResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCidsByBotCodeResponse self = new GetCidsByBotCodeResponse();
        return TeaModel.build(map, self);
    }

    public GetCidsByBotCodeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCidsByBotCodeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCidsByBotCodeResponse setBody(GetCidsByBotCodeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCidsByBotCodeResponseBody getBody() {
        return this.body;
    }

}
