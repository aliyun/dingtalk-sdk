// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetAccountTransferListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAccountTransferListResponseBody body;

    public static GetAccountTransferListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAccountTransferListResponse self = new GetAccountTransferListResponse();
        return TeaModel.build(map, self);
    }

    public GetAccountTransferListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAccountTransferListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAccountTransferListResponse setBody(GetAccountTransferListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAccountTransferListResponseBody getBody() {
        return this.body;
    }

}
