// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetBindChildInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetBindChildInfoResponseBody body;

    public static GetBindChildInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBindChildInfoResponse self = new GetBindChildInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetBindChildInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetBindChildInfoResponse setBody(GetBindChildInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetBindChildInfoResponseBody getBody() {
        return this.body;
    }

}
