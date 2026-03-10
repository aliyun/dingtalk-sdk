// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class BusinessCodeCallbackResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BusinessCodeCallbackResponseBody body;

    public static BusinessCodeCallbackResponse build(java.util.Map<String, ?> map) throws Exception {
        BusinessCodeCallbackResponse self = new BusinessCodeCallbackResponse();
        return TeaModel.build(map, self);
    }

    public BusinessCodeCallbackResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BusinessCodeCallbackResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BusinessCodeCallbackResponse setBody(BusinessCodeCallbackResponseBody body) {
        this.body = body;
        return this;
    }
    public BusinessCodeCallbackResponseBody getBody() {
        return this.body;
    }

}
