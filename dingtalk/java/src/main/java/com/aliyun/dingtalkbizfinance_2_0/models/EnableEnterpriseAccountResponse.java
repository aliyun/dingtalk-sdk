// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class EnableEnterpriseAccountResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EnableEnterpriseAccountResponseBody body;

    public static EnableEnterpriseAccountResponse build(java.util.Map<String, ?> map) throws Exception {
        EnableEnterpriseAccountResponse self = new EnableEnterpriseAccountResponse();
        return TeaModel.build(map, self);
    }

    public EnableEnterpriseAccountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EnableEnterpriseAccountResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EnableEnterpriseAccountResponse setBody(EnableEnterpriseAccountResponseBody body) {
        this.body = body;
        return this;
    }
    public EnableEnterpriseAccountResponseBody getBody() {
        return this.body;
    }

}
