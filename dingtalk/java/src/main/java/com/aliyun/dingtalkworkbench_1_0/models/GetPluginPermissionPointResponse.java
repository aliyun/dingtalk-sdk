// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class GetPluginPermissionPointResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

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

    public GetPluginPermissionPointResponse setBody(GetPluginPermissionPointResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPluginPermissionPointResponseBody getBody() {
        return this.body;
    }

}
