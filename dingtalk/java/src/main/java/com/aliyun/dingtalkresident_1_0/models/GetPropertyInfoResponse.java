// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetPropertyInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetPropertyInfoResponseBody body;

    public static GetPropertyInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPropertyInfoResponse self = new GetPropertyInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetPropertyInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPropertyInfoResponse setBody(GetPropertyInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPropertyInfoResponseBody getBody() {
        return this.body;
    }

}
