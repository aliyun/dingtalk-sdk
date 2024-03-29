// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class CreateJsapiTicketResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public CreateJsapiTicketResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateJsapiTicketResponse setBody(CreateJsapiTicketResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateJsapiTicketResponseBody getBody() {
        return this.body;
    }

}
