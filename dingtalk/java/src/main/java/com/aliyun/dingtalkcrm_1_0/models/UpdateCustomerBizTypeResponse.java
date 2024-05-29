// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateCustomerBizTypeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateCustomerBizTypeResponseBody body;

    public static UpdateCustomerBizTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCustomerBizTypeResponse self = new UpdateCustomerBizTypeResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCustomerBizTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCustomerBizTypeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateCustomerBizTypeResponse setBody(UpdateCustomerBizTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCustomerBizTypeResponseBody getBody() {
        return this.body;
    }

}
