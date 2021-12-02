// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class CreateJsapiTicketResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateJsapiTicketResponseBody body;

    public static CreateJsapiTicketResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateJsapiTicketResponse self = new CreateJsapiTicketResponse();
        return TeaModel.build(map, self);
    }

    public CreateJsapiTicketResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateJsapiTicketResponse setBody(CreateJsapiTicketResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateJsapiTicketResponseBody getBody() {
        return this.body;
    }

}
