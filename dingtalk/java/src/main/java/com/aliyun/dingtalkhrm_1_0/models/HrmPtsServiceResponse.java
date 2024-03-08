// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmPtsServiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrmPtsServiceResponseBody body;

    public static HrmPtsServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        HrmPtsServiceResponse self = new HrmPtsServiceResponse();
        return TeaModel.build(map, self);
    }

    public HrmPtsServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrmPtsServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrmPtsServiceResponse setBody(HrmPtsServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public HrmPtsServiceResponseBody getBody() {
        return this.body;
    }

}
