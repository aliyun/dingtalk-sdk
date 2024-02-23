// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncCostCenterEntityResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SyncCostCenterEntityResponseBody body;

    public static SyncCostCenterEntityResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncCostCenterEntityResponse self = new SyncCostCenterEntityResponse();
        return TeaModel.build(map, self);
    }

    public SyncCostCenterEntityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncCostCenterEntityResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncCostCenterEntityResponse setBody(SyncCostCenterEntityResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncCostCenterEntityResponseBody getBody() {
        return this.body;
    }

}
