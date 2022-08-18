// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class AddPermissionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddPermissionResponseBody body;

    public static AddPermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        AddPermissionResponse self = new AddPermissionResponse();
        return TeaModel.build(map, self);
    }

    public AddPermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddPermissionResponse setBody(AddPermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public AddPermissionResponseBody getBody() {
        return this.body;
    }

}