// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetMsgLocationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetMsgLocationResponseBody body;

    public static GetMsgLocationResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMsgLocationResponse self = new GetMsgLocationResponse();
        return TeaModel.build(map, self);
    }

    public GetMsgLocationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMsgLocationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetMsgLocationResponse setBody(GetMsgLocationResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMsgLocationResponseBody getBody() {
        return this.body;
    }

}
