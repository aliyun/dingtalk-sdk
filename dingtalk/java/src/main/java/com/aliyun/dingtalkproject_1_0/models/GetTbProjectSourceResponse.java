// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetTbProjectSourceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetTbProjectSourceResponseBody body;

    public static GetTbProjectSourceResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTbProjectSourceResponse self = new GetTbProjectSourceResponse();
        return TeaModel.build(map, self);
    }

    public GetTbProjectSourceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTbProjectSourceResponse setBody(GetTbProjectSourceResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTbProjectSourceResponseBody getBody() {
        return this.body;
    }

}
