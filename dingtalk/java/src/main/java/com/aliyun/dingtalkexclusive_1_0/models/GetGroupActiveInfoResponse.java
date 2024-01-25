// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGroupActiveInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetGroupActiveInfoResponseBody body;

    public static GetGroupActiveInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetGroupActiveInfoResponse self = new GetGroupActiveInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetGroupActiveInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetGroupActiveInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetGroupActiveInfoResponse setBody(GetGroupActiveInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetGroupActiveInfoResponseBody getBody() {
        return this.body;
    }

}
