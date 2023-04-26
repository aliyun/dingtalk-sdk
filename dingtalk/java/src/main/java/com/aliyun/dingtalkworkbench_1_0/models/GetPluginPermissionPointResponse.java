// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class GetPluginPermissionPointResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetPluginPermissionPointResponseBody body;

    public static GetPluginPermissionPointResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPluginPermissionPointResponse self = new GetPluginPermissionPointResponse();
        return TeaModel.build(map, self);
    }

    public GetPluginPermissionPointResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPluginPermissionPointResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPluginPermissionPointResponse setBody(GetPluginPermissionPointResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPluginPermissionPointResponseBody getBody() {
        return this.body;
    }

}
