// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteUserCarbonEnergyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public WriteUserCarbonEnergyResponse setBody(WriteUserCarbonEnergyResponseBody body) {
        this.body = body;
        return this;
    }
    public WriteUserCarbonEnergyResponseBody getBody() {
        return this.body;
    }

}
