// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateFinanceEnterpriseAccountResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateFinanceEnterpriseAccountResponseBody body;

    public static UpdateFinanceEnterpriseAccountResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateFinanceEnterpriseAccountResponse self = new UpdateFinanceEnterpriseAccountResponse();
        return TeaModel.build(map, self);
    }

    public UpdateFinanceEnterpriseAccountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateFinanceEnterpriseAccountResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateFinanceEnterpriseAccountResponse setBody(UpdateFinanceEnterpriseAccountResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateFinanceEnterpriseAccountResponseBody getBody() {
        return this.body;
    }

}
