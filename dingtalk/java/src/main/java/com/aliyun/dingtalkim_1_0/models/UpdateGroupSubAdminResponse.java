// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupSubAdminResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateGroupSubAdminResponseBody body;

    public static UpdateGroupSubAdminResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupSubAdminResponse self = new UpdateGroupSubAdminResponse();
        return TeaModel.build(map, self);
    }

    public UpdateGroupSubAdminResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateGroupSubAdminResponse setBody(UpdateGroupSubAdminResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateGroupSubAdminResponseBody getBody() {
        return this.body;
    }

}
