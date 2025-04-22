// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpgradeToExternalGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpgradeToExternalGroupResponseBody body;

    public static UpgradeToExternalGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        UpgradeToExternalGroupResponse self = new UpgradeToExternalGroupResponse();
        return TeaModel.build(map, self);
    }

    public UpgradeToExternalGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpgradeToExternalGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpgradeToExternalGroupResponse setBody(UpgradeToExternalGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public UpgradeToExternalGroupResponseBody getBody() {
        return this.body;
    }

}
