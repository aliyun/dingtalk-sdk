// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetInstanceByIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetInstanceByIdResponseBody body;

    public static GetInstanceByIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetInstanceByIdResponse self = new GetInstanceByIdResponse();
        return TeaModel.build(map, self);
    }

    public GetInstanceByIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetInstanceByIdResponse setBody(GetInstanceByIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetInstanceByIdResponseBody getBody() {
        return this.body;
    }

}
