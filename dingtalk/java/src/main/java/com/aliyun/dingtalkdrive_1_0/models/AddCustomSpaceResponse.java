// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class AddCustomSpaceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddCustomSpaceResponseBody body;

    public static AddCustomSpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        AddCustomSpaceResponse self = new AddCustomSpaceResponse();
        return TeaModel.build(map, self);
    }

    public AddCustomSpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddCustomSpaceResponse setBody(AddCustomSpaceResponseBody body) {
        this.body = body;
        return this;
    }
    public AddCustomSpaceResponseBody getBody() {
        return this.body;
    }

}
