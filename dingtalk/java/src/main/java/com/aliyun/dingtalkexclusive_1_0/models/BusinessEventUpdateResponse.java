// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class BusinessEventUpdateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BusinessEventUpdateResponseBody body;

    public static BusinessEventUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        BusinessEventUpdateResponse self = new BusinessEventUpdateResponse();
        return TeaModel.build(map, self);
    }

    public BusinessEventUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BusinessEventUpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BusinessEventUpdateResponse setBody(BusinessEventUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public BusinessEventUpdateResponseBody getBody() {
        return this.body;
    }

}
