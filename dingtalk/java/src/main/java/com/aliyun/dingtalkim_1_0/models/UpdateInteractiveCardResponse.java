// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateInteractiveCardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public UpdateInteractiveCardResponse setBody(UpdateInteractiveCardResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInteractiveCardResponseBody getBody() {
        return this.body;
    }

}
