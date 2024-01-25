// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class UpdateCardWithDelegateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateCardWithDelegateResponseBody body;

    public static UpdateCardWithDelegateResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCardWithDelegateResponse self = new UpdateCardWithDelegateResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCardWithDelegateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCardWithDelegateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateCardWithDelegateResponse setBody(UpdateCardWithDelegateResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCardWithDelegateResponseBody getBody() {
        return this.body;
    }

}
