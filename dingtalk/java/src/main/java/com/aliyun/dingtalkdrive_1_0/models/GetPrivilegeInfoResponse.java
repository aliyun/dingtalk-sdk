// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivilegeInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetPrivilegeInfoResponseBody body;

    public static GetPrivilegeInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPrivilegeInfoResponse self = new GetPrivilegeInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetPrivilegeInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPrivilegeInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPrivilegeInfoResponse setBody(GetPrivilegeInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPrivilegeInfoResponseBody getBody() {
        return this.body;
    }

}
