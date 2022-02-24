// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class UpdateActionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateActionResponseBody body;

    public static UpdateActionResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateActionResponse self = new UpdateActionResponse();
        return TeaModel.build(map, self);
    }

    public UpdateActionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateActionResponse setBody(UpdateActionResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateActionResponseBody getBody() {
        return this.body;
    }

}