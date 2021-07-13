// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class InvokeHtmlBundleBuildResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public InvokeHtmlBundleBuildResponseBody body;

    public static InvokeHtmlBundleBuildResponse build(java.util.Map<String, ?> map) throws Exception {
        InvokeHtmlBundleBuildResponse self = new InvokeHtmlBundleBuildResponse();
        return TeaModel.build(map, self);
    }

    public InvokeHtmlBundleBuildResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InvokeHtmlBundleBuildResponse setBody(InvokeHtmlBundleBuildResponseBody body) {
        this.body = body;
        return this;
    }
    public InvokeHtmlBundleBuildResponseBody getBody() {
        return this.body;
    }

}
