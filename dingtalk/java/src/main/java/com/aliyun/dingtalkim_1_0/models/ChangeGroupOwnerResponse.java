// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ChangeGroupOwnerResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ChangeGroupOwnerResponseBody body;

    public static ChangeGroupOwnerResponse build(java.util.Map<String, ?> map) throws Exception {
        ChangeGroupOwnerResponse self = new ChangeGroupOwnerResponse();
        return TeaModel.build(map, self);
    }

    public ChangeGroupOwnerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChangeGroupOwnerResponse setBody(ChangeGroupOwnerResponseBody body) {
        this.body = body;
        return this;
    }
    public ChangeGroupOwnerResponseBody getBody() {
        return this.body;
    }

}
