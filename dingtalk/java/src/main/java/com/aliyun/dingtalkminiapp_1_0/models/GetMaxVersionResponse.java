// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class GetMaxVersionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetMaxVersionResponseBody body;

    public static GetMaxVersionResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMaxVersionResponse self = new GetMaxVersionResponse();
        return TeaModel.build(map, self);
    }

    public GetMaxVersionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMaxVersionResponse setBody(GetMaxVersionResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMaxVersionResponseBody getBody() {
        return this.body;
    }

}
