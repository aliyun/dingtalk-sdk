// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class DeleteEnterpriseAccountResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteEnterpriseAccountResponseBody body;

    public static DeleteEnterpriseAccountResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteEnterpriseAccountResponse self = new DeleteEnterpriseAccountResponse();
        return TeaModel.build(map, self);
    }

    public DeleteEnterpriseAccountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteEnterpriseAccountResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteEnterpriseAccountResponse setBody(DeleteEnterpriseAccountResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteEnterpriseAccountResponseBody getBody() {
        return this.body;
    }

}
