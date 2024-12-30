// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartFormulaResultServiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SmartFormulaResultServiceResponseBody body;

    public static SmartFormulaResultServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        SmartFormulaResultServiceResponse self = new SmartFormulaResultServiceResponse();
        return TeaModel.build(map, self);
    }

    public SmartFormulaResultServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SmartFormulaResultServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SmartFormulaResultServiceResponse setBody(SmartFormulaResultServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public SmartFormulaResultServiceResponseBody getBody() {
        return this.body;
    }

}
