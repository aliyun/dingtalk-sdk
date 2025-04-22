// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpgradeToServiceGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpgradeToServiceGroupResponseBody body;

    public static UpgradeToServiceGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        UpgradeToServiceGroupResponse self = new UpgradeToServiceGroupResponse();
        return TeaModel.build(map, self);
    }

    public UpgradeToServiceGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpgradeToServiceGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpgradeToServiceGroupResponse setBody(UpgradeToServiceGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public UpgradeToServiceGroupResponseBody getBody() {
        return this.body;
    }

}
