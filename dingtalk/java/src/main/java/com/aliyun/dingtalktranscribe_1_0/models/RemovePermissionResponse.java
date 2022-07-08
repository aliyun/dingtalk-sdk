// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktranscribe_1_0.models;

import com.aliyun.tea.*;

public class RemovePermissionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RemovePermissionResponseBody body;

    public static RemovePermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        RemovePermissionResponse self = new RemovePermissionResponse();
        return TeaModel.build(map, self);
    }

    public RemovePermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemovePermissionResponse setBody(RemovePermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public RemovePermissionResponseBody getBody() {
        return this.body;
    }

}
