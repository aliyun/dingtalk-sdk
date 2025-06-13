// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class IsOrgMicroAppVisibleByUserIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IsOrgMicroAppVisibleByUserIdResponseBody body;

    public static IsOrgMicroAppVisibleByUserIdResponse build(java.util.Map<String, ?> map) throws Exception {
        IsOrgMicroAppVisibleByUserIdResponse self = new IsOrgMicroAppVisibleByUserIdResponse();
        return TeaModel.build(map, self);
    }

    public IsOrgMicroAppVisibleByUserIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IsOrgMicroAppVisibleByUserIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IsOrgMicroAppVisibleByUserIdResponse setBody(IsOrgMicroAppVisibleByUserIdResponseBody body) {
        this.body = body;
        return this;
    }
    public IsOrgMicroAppVisibleByUserIdResponseBody getBody() {
        return this.body;
    }

}
