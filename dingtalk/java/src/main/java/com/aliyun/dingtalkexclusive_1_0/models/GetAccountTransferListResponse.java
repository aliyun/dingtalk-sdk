// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetAccountTransferListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetAccountTransferListResponse setBody(GetAccountTransferListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAccountTransferListResponseBody getBody() {
        return this.body;
    }

}
