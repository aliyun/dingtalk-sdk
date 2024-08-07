// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class OpenOemMicroAppResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OpenOemMicroAppResponseBody body;

    public static OpenOemMicroAppResponse build(java.util.Map<String, ?> map) throws Exception {
        OpenOemMicroAppResponse self = new OpenOemMicroAppResponse();
        return TeaModel.build(map, self);
    }

    public OpenOemMicroAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OpenOemMicroAppResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OpenOemMicroAppResponse setBody(OpenOemMicroAppResponseBody body) {
        this.body = body;
        return this;
    }
    public OpenOemMicroAppResponseBody getBody() {
        return this.body;
    }

}
