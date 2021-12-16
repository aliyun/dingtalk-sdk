// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetCardInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetCardInfoResponseBody body;

    public static GetCardInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCardInfoResponse self = new GetCardInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetCardInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCardInfoResponse setBody(GetCardInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCardInfoResponseBody getBody() {
        return this.body;
    }

}
