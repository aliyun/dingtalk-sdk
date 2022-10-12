// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class AppendSpaceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AppendSpaceResponseBody body;

    public static AppendSpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        AppendSpaceResponse self = new AppendSpaceResponse();
        return TeaModel.build(map, self);
    }

    public AppendSpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AppendSpaceResponse setBody(AppendSpaceResponseBody body) {
        this.body = body;
        return this;
    }
    public AppendSpaceResponseBody getBody() {
        return this.body;
    }

}
