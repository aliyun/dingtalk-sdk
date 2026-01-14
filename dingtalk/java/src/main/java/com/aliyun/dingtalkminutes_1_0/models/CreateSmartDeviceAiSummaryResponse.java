// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class CreateSmartDeviceAiSummaryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateSmartDeviceAiSummaryResponseBody body;

    public static CreateSmartDeviceAiSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateSmartDeviceAiSummaryResponse self = new CreateSmartDeviceAiSummaryResponse();
        return TeaModel.build(map, self);
    }

    public CreateSmartDeviceAiSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateSmartDeviceAiSummaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateSmartDeviceAiSummaryResponse setBody(CreateSmartDeviceAiSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateSmartDeviceAiSummaryResponseBody getBody() {
        return this.body;
    }

}
