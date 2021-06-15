// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdateApaasAppResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateApaasAppResponseBody body;

    public static UpdateApaasAppResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateApaasAppResponse self = new UpdateApaasAppResponse();
        return TeaModel.build(map, self);
    }

    public UpdateApaasAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateApaasAppResponse setBody(UpdateApaasAppResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateApaasAppResponseBody getBody() {
        return this.body;
    }

}
