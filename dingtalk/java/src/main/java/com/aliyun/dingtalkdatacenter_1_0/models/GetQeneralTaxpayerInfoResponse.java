// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetQeneralTaxpayerInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetQeneralTaxpayerInfoResponse setBody(GetQeneralTaxpayerInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetQeneralTaxpayerInfoResponseBody getBody() {
        return this.body;
    }

}
