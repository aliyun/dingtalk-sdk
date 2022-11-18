// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetFieldDefByUuidResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetFieldDefByUuidResponseBody body;

    public static GetFieldDefByUuidResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFieldDefByUuidResponse self = new GetFieldDefByUuidResponse();
        return TeaModel.build(map, self);
    }

    public GetFieldDefByUuidResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFieldDefByUuidResponse setBody(GetFieldDefByUuidResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFieldDefByUuidResponseBody getBody() {
        return this.body;
    }

}
