// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetResidentInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetResidentInfoResponseBody body;

    public static GetResidentInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetResidentInfoResponse self = new GetResidentInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetResidentInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetResidentInfoResponse setBody(GetResidentInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetResidentInfoResponseBody getBody() {
        return this.body;
    }

}
