// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetMicroAppUserAccessResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetMicroAppUserAccessResponseBody body;

    public static GetMicroAppUserAccessResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMicroAppUserAccessResponse self = new GetMicroAppUserAccessResponse();
        return TeaModel.build(map, self);
    }

    public GetMicroAppUserAccessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMicroAppUserAccessResponse setBody(GetMicroAppUserAccessResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMicroAppUserAccessResponseBody getBody() {
        return this.body;
    }

}
