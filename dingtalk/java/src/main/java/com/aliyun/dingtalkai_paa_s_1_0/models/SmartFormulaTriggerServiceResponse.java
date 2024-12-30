// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartFormulaTriggerServiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SmartFormulaTriggerServiceResponseBody body;

    public static SmartFormulaTriggerServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        SmartFormulaTriggerServiceResponse self = new SmartFormulaTriggerServiceResponse();
        return TeaModel.build(map, self);
    }

    public SmartFormulaTriggerServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SmartFormulaTriggerServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SmartFormulaTriggerServiceResponse setBody(SmartFormulaTriggerServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public SmartFormulaTriggerServiceResponseBody getBody() {
        return this.body;
    }

}
