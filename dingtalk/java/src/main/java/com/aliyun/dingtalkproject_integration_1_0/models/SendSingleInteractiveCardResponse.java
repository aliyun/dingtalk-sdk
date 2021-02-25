// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_integration_1_0.models;

import com.aliyun.tea.*;

public class SendSingleInteractiveCardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public java.util.Map<String, ?> body;

    public static SendSingleInteractiveCardResponse build(java.util.Map<String, ?> map) throws Exception {
        SendSingleInteractiveCardResponse self = new SendSingleInteractiveCardResponse();
        return TeaModel.build(map, self);
    }

    public SendSingleInteractiveCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendSingleInteractiveCardResponse setBody(java.util.Map<String, ?> body) {
        this.body = body;
        return this;
    }
    public java.util.Map<String, ?> getBody() {
        return this.body;
    }

}
