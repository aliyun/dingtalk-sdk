// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkamdp_1_0.models;

import com.aliyun.tea.*;

public class AmdpEmployeeDataPushResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AmdpEmployeeDataPushResponseBody body;

    public static AmdpEmployeeDataPushResponse build(java.util.Map<String, ?> map) throws Exception {
        AmdpEmployeeDataPushResponse self = new AmdpEmployeeDataPushResponse();
        return TeaModel.build(map, self);
    }

    public AmdpEmployeeDataPushResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AmdpEmployeeDataPushResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AmdpEmployeeDataPushResponse setBody(AmdpEmployeeDataPushResponseBody body) {
        this.body = body;
        return this;
    }
    public AmdpEmployeeDataPushResponseBody getBody() {
        return this.body;
    }

}
