// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktranscribe_1_0.models;

import com.aliyun.tea.*;

public class UpdatePermissionForUsersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public UpdatePermissionForUsersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdatePermissionForUsersResponse setBody(UpdatePermissionForUsersResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdatePermissionForUsersResponseBody getBody() {
        return this.body;
    }

}
