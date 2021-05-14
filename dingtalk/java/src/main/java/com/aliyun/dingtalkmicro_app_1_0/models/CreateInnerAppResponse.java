// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class CreateInnerAppResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateInnerAppResponseBody body;

    public static CreateInnerAppResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateInnerAppResponse self = new CreateInnerAppResponse();
        return TeaModel.build(map, self);
    }

    public CreateInnerAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateInnerAppResponse setBody(CreateInnerAppResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateInnerAppResponseBody getBody() {
        return this.body;
    }

}
