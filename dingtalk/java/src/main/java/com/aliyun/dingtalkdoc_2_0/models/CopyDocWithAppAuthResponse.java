// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CopyDocWithAppAuthResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CopyDocWithAppAuthResponseBody body;

    public static CopyDocWithAppAuthResponse build(java.util.Map<String, ?> map) throws Exception {
        CopyDocWithAppAuthResponse self = new CopyDocWithAppAuthResponse();
        return TeaModel.build(map, self);
    }

    public CopyDocWithAppAuthResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CopyDocWithAppAuthResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CopyDocWithAppAuthResponse setBody(CopyDocWithAppAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public CopyDocWithAppAuthResponseBody getBody() {
        return this.body;
    }

}
