// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GrantCspaceAuthorizationResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static GrantCspaceAuthorizationResponse build(java.util.Map<String, ?> map) throws Exception {
        GrantCspaceAuthorizationResponse self = new GrantCspaceAuthorizationResponse();
        return TeaModel.build(map, self);
    }

    public GrantCspaceAuthorizationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
