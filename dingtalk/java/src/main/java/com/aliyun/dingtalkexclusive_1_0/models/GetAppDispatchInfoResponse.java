// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetAppDispatchInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetAppDispatchInfoResponseBody body;

    public static GetAppDispatchInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAppDispatchInfoResponse self = new GetAppDispatchInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetAppDispatchInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAppDispatchInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAppDispatchInfoResponse setBody(GetAppDispatchInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAppDispatchInfoResponseBody getBody() {
        return this.body;
    }

}
