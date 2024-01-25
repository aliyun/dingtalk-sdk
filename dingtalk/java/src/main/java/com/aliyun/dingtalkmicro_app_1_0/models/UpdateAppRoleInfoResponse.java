// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdateAppRoleInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateAppRoleInfoResponseBody body;

    public static UpdateAppRoleInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateAppRoleInfoResponse self = new UpdateAppRoleInfoResponse();
        return TeaModel.build(map, self);
    }

    public UpdateAppRoleInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateAppRoleInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateAppRoleInfoResponse setBody(UpdateAppRoleInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateAppRoleInfoResponseBody getBody() {
        return this.body;
    }

}
