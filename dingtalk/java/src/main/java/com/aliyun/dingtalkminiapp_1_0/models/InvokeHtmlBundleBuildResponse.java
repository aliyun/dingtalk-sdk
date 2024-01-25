// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class InvokeHtmlBundleBuildResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public InvokeHtmlBundleBuildResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InvokeHtmlBundleBuildResponse setBody(InvokeHtmlBundleBuildResponseBody body) {
        this.body = body;
        return this;
    }
    public InvokeHtmlBundleBuildResponseBody getBody() {
        return this.body;
    }

}
