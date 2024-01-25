// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveAndSubmitAuthInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SaveAndSubmitAuthInfoResponseBody body;

    public static SaveAndSubmitAuthInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveAndSubmitAuthInfoResponse self = new SaveAndSubmitAuthInfoResponse();
        return TeaModel.build(map, self);
    }

    public SaveAndSubmitAuthInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveAndSubmitAuthInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveAndSubmitAuthInfoResponse setBody(SaveAndSubmitAuthInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveAndSubmitAuthInfoResponseBody getBody() {
        return this.body;
    }

}
