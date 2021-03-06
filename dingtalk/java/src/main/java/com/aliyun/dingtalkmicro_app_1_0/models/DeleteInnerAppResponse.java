// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class DeleteInnerAppResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteInnerAppResponseBody body;

    public static DeleteInnerAppResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteInnerAppResponse self = new DeleteInnerAppResponse();
        return TeaModel.build(map, self);
    }

    public DeleteInnerAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteInnerAppResponse setBody(DeleteInnerAppResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteInnerAppResponseBody getBody() {
        return this.body;
    }

}
