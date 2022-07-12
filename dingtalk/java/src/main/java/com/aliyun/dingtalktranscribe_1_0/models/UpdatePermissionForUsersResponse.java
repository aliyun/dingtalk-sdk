// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktranscribe_1_0.models;

import com.aliyun.tea.*;

public class UpdatePermissionForUsersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdatePermissionForUsersResponseBody body;

    public static UpdatePermissionForUsersResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdatePermissionForUsersResponse self = new UpdatePermissionForUsersResponse();
        return TeaModel.build(map, self);
    }

    public UpdatePermissionForUsersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdatePermissionForUsersResponse setBody(UpdatePermissionForUsersResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdatePermissionForUsersResponseBody getBody() {
        return this.body;
    }

}