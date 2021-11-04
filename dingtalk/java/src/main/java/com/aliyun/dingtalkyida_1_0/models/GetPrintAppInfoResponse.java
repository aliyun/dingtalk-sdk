// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetPrintAppInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetPrintAppInfoResponseBody body;

    public static GetPrintAppInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPrintAppInfoResponse self = new GetPrintAppInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetPrintAppInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPrintAppInfoResponse setBody(GetPrintAppInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPrintAppInfoResponseBody getBody() {
        return this.body;
    }

}
