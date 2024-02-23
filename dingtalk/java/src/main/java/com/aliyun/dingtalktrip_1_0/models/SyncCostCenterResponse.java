// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncCostCenterResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SyncCostCenterResponseBody body;

    public static SyncCostCenterResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncCostCenterResponse self = new SyncCostCenterResponse();
        return TeaModel.build(map, self);
    }

    public SyncCostCenterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncCostCenterResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncCostCenterResponse setBody(SyncCostCenterResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncCostCenterResponseBody getBody() {
        return this.body;
    }

}
