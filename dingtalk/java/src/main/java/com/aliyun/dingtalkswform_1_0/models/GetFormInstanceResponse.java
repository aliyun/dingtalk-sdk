// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class GetFormInstanceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetFormInstanceResponseBody body;

    public static GetFormInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFormInstanceResponse self = new GetFormInstanceResponse();
        return TeaModel.build(map, self);
    }

    public GetFormInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFormInstanceResponse setBody(GetFormInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFormInstanceResponseBody getBody() {
        return this.body;
    }

}
