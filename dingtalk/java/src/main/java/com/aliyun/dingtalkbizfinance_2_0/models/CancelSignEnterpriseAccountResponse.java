// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class CancelSignEnterpriseAccountResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CancelSignEnterpriseAccountResponseBody body;

    public static CancelSignEnterpriseAccountResponse build(java.util.Map<String, ?> map) throws Exception {
        CancelSignEnterpriseAccountResponse self = new CancelSignEnterpriseAccountResponse();
        return TeaModel.build(map, self);
    }

    public CancelSignEnterpriseAccountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CancelSignEnterpriseAccountResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CancelSignEnterpriseAccountResponse setBody(CancelSignEnterpriseAccountResponseBody body) {
        this.body = body;
        return this;
    }
    public CancelSignEnterpriseAccountResponseBody getBody() {
        return this.body;
    }

}
