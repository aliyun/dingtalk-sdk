// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupNameResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateGroupNameResponseBody body;

    public static UpdateGroupNameResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupNameResponse self = new UpdateGroupNameResponse();
        return TeaModel.build(map, self);
    }

    public UpdateGroupNameResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateGroupNameResponse setBody(UpdateGroupNameResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateGroupNameResponseBody getBody() {
        return this.body;
    }

}
