// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class CreateMiniAppResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateMiniAppResponseBody body;

    public static CreateMiniAppResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateMiniAppResponse self = new CreateMiniAppResponse();
        return TeaModel.build(map, self);
    }

    public CreateMiniAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateMiniAppResponse setBody(CreateMiniAppResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateMiniAppResponseBody getBody() {
        return this.body;
    }

}
