// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivateStoreCapacityUsageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPrivateStoreCapacityUsageResponseBody body;

    public static GetPrivateStoreCapacityUsageResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPrivateStoreCapacityUsageResponse self = new GetPrivateStoreCapacityUsageResponse();
        return TeaModel.build(map, self);
    }

    public GetPrivateStoreCapacityUsageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPrivateStoreCapacityUsageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPrivateStoreCapacityUsageResponse setBody(GetPrivateStoreCapacityUsageResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPrivateStoreCapacityUsageResponseBody getBody() {
        return this.body;
    }

}
