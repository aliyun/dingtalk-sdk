// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupOwnerResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateGroupOwnerResponseBody body;

    public static UpdateGroupOwnerResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupOwnerResponse self = new UpdateGroupOwnerResponse();
        return TeaModel.build(map, self);
    }

    public UpdateGroupOwnerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateGroupOwnerResponse setBody(UpdateGroupOwnerResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateGroupOwnerResponseBody getBody() {
        return this.body;
    }

}
