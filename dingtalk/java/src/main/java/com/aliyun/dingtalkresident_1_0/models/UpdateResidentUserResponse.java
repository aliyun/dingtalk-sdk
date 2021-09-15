// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentUserResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateResidentUserResponseBody body;

    public static UpdateResidentUserResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidentUserResponse self = new UpdateResidentUserResponse();
        return TeaModel.build(map, self);
    }

    public UpdateResidentUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateResidentUserResponse setBody(UpdateResidentUserResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateResidentUserResponseBody getBody() {
        return this.body;
    }

}
