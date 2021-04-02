// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GenerateCaldavAccountResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GenerateCaldavAccountResponseBody body;

    public static GenerateCaldavAccountResponse build(java.util.Map<String, ?> map) throws Exception {
        GenerateCaldavAccountResponse self = new GenerateCaldavAccountResponse();
        return TeaModel.build(map, self);
    }

    public GenerateCaldavAccountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GenerateCaldavAccountResponse setBody(GenerateCaldavAccountResponseBody body) {
        this.body = body;
        return this;
    }
    public GenerateCaldavAccountResponseBody getBody() {
        return this.body;
    }

}
