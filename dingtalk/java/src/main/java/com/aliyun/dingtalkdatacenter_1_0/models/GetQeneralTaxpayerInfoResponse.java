// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetQeneralTaxpayerInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetQeneralTaxpayerInfoResponseBody body;

    public static GetQeneralTaxpayerInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetQeneralTaxpayerInfoResponse self = new GetQeneralTaxpayerInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetQeneralTaxpayerInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetQeneralTaxpayerInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetQeneralTaxpayerInfoResponse setBody(GetQeneralTaxpayerInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetQeneralTaxpayerInfoResponseBody getBody() {
        return this.body;
    }

}
