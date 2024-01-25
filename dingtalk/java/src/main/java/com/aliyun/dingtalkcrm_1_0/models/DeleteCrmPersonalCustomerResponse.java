// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteCrmPersonalCustomerResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteCrmPersonalCustomerResponseBody body;

    public static DeleteCrmPersonalCustomerResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteCrmPersonalCustomerResponse self = new DeleteCrmPersonalCustomerResponse();
        return TeaModel.build(map, self);
    }

    public DeleteCrmPersonalCustomerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteCrmPersonalCustomerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteCrmPersonalCustomerResponse setBody(DeleteCrmPersonalCustomerResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteCrmPersonalCustomerResponseBody getBody() {
        return this.body;
    }

}
