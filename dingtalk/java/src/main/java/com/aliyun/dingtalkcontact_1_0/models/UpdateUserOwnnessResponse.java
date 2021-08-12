// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateUserOwnnessResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateUserOwnnessResponseBody body;

    public static UpdateUserOwnnessResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateUserOwnnessResponse self = new UpdateUserOwnnessResponse();
        return TeaModel.build(map, self);
    }

    public UpdateUserOwnnessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateUserOwnnessResponse setBody(UpdateUserOwnnessResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateUserOwnnessResponseBody getBody() {
        return this.body;
    }

}
