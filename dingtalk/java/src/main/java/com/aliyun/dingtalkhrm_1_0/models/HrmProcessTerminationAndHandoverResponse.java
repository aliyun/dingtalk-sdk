// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmProcessTerminationAndHandoverResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrmProcessTerminationAndHandoverResponseBody body;

    public static HrmProcessTerminationAndHandoverResponse build(java.util.Map<String, ?> map) throws Exception {
        HrmProcessTerminationAndHandoverResponse self = new HrmProcessTerminationAndHandoverResponse();
        return TeaModel.build(map, self);
    }

    public HrmProcessTerminationAndHandoverResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrmProcessTerminationAndHandoverResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrmProcessTerminationAndHandoverResponse setBody(HrmProcessTerminationAndHandoverResponseBody body) {
        this.body = body;
        return this;
    }
    public HrmProcessTerminationAndHandoverResponseBody getBody() {
        return this.body;
    }

}
