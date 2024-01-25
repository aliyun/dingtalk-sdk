// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteUserCarbonEnergyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public WriteUserCarbonEnergyResponseBody body;

    public static WriteUserCarbonEnergyResponse build(java.util.Map<String, ?> map) throws Exception {
        WriteUserCarbonEnergyResponse self = new WriteUserCarbonEnergyResponse();
        return TeaModel.build(map, self);
    }

    public WriteUserCarbonEnergyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public WriteUserCarbonEnergyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public WriteUserCarbonEnergyResponse setBody(WriteUserCarbonEnergyResponseBody body) {
        this.body = body;
        return this;
    }
    public WriteUserCarbonEnergyResponseBody getBody() {
        return this.body;
    }

}
