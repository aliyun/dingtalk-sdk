// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetMsgConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetMsgConfigResponseBody body;

    public static GetMsgConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMsgConfigResponse self = new GetMsgConfigResponse();
        return TeaModel.build(map, self);
    }

    public GetMsgConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMsgConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetMsgConfigResponse setBody(GetMsgConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMsgConfigResponseBody getBody() {
        return this.body;
    }

}
