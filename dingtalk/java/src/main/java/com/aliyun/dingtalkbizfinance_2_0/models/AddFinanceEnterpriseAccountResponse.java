// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class AddFinanceEnterpriseAccountResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddFinanceEnterpriseAccountResponseBody body;

    public static AddFinanceEnterpriseAccountResponse build(java.util.Map<String, ?> map) throws Exception {
        AddFinanceEnterpriseAccountResponse self = new AddFinanceEnterpriseAccountResponse();
        return TeaModel.build(map, self);
    }

    public AddFinanceEnterpriseAccountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddFinanceEnterpriseAccountResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddFinanceEnterpriseAccountResponse setBody(AddFinanceEnterpriseAccountResponseBody body) {
        this.body = body;
        return this;
    }
    public AddFinanceEnterpriseAccountResponseBody getBody() {
        return this.body;
    }

}
