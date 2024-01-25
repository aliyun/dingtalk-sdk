// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateInteractiveCardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateInteractiveCardResponseBody body;

    public static UpdateInteractiveCardResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateInteractiveCardResponse self = new UpdateInteractiveCardResponse();
        return TeaModel.build(map, self);
    }

    public UpdateInteractiveCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateInteractiveCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateInteractiveCardResponse setBody(UpdateInteractiveCardResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInteractiveCardResponseBody getBody() {
        return this.body;
    }

}
