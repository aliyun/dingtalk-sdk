// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveAndSubmitAuthInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public SaveAndSubmitAuthInfoResponse setBody(SaveAndSubmitAuthInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveAndSubmitAuthInfoResponseBody getBody() {
        return this.body;
    }

}
