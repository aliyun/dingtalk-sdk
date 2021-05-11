// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class UpdateDingPortalPageScopeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static UpdateDingPortalPageScopeResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateDingPortalPageScopeResponse self = new UpdateDingPortalPageScopeResponse();
        return TeaModel.build(map, self);
    }

    public UpdateDingPortalPageScopeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
