// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class AddSpaceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddSpaceResponseBody body;

    public static AddSpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        AddSpaceResponse self = new AddSpaceResponse();
        return TeaModel.build(map, self);
    }

    public AddSpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddSpaceResponse setBody(AddSpaceResponseBody body) {
        this.body = body;
        return this;
    }
    public AddSpaceResponseBody getBody() {
        return this.body;
    }

}
