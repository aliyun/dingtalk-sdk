// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendTemplateInteractiveCardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendTemplateInteractiveCardResponseBody body;

    public static SendTemplateInteractiveCardResponse build(java.util.Map<String, ?> map) throws Exception {
        SendTemplateInteractiveCardResponse self = new SendTemplateInteractiveCardResponse();
        return TeaModel.build(map, self);
    }

    public SendTemplateInteractiveCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendTemplateInteractiveCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendTemplateInteractiveCardResponse setBody(SendTemplateInteractiveCardResponseBody body) {
        this.body = body;
        return this;
    }
    public SendTemplateInteractiveCardResponseBody getBody() {
        return this.body;
    }

}
