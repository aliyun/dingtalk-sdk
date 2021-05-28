// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListRoleInfoByUserResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListRoleInfoByUserResponseBody body;

    public static ListRoleInfoByUserResponse build(java.util.Map<String, ?> map) throws Exception {
        ListRoleInfoByUserResponse self = new ListRoleInfoByUserResponse();
        return TeaModel.build(map, self);
    }

    public ListRoleInfoByUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListRoleInfoByUserResponse setBody(ListRoleInfoByUserResponseBody body) {
        this.body = body;
        return this;
    }
    public ListRoleInfoByUserResponseBody getBody() {
        return this.body;
    }

}
