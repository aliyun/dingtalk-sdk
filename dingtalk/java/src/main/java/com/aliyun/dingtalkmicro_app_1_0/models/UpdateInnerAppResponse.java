// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdateInnerAppResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateInnerAppResponseBody body;

    public static UpdateInnerAppResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateInnerAppResponse self = new UpdateInnerAppResponse();
        return TeaModel.build(map, self);
    }

    public UpdateInnerAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateInnerAppResponse setBody(UpdateInnerAppResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInnerAppResponseBody getBody() {
        return this.body;
    }

}
