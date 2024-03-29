// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class CreateDeliveryPlanResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateDeliveryPlanResponseBody body;

    public static CreateDeliveryPlanResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateDeliveryPlanResponse self = new CreateDeliveryPlanResponse();
        return TeaModel.build(map, self);
    }

    public CreateDeliveryPlanResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateDeliveryPlanResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateDeliveryPlanResponse setBody(CreateDeliveryPlanResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateDeliveryPlanResponseBody getBody() {
        return this.body;
    }

}
