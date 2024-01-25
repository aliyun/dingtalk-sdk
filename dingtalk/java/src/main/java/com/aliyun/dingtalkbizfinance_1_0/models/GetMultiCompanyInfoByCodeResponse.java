// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetMultiCompanyInfoByCodeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetMultiCompanyInfoByCodeResponseBody body;

    public static GetMultiCompanyInfoByCodeResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMultiCompanyInfoByCodeResponse self = new GetMultiCompanyInfoByCodeResponse();
        return TeaModel.build(map, self);
    }

    public GetMultiCompanyInfoByCodeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMultiCompanyInfoByCodeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetMultiCompanyInfoByCodeResponse setBody(GetMultiCompanyInfoByCodeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMultiCompanyInfoByCodeResponseBody getBody() {
        return this.body;
    }

}
