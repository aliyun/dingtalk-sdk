// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmBenefitQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrmBenefitQueryResponseBody body;

    public static HrmBenefitQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        HrmBenefitQueryResponse self = new HrmBenefitQueryResponse();
        return TeaModel.build(map, self);
    }

    public HrmBenefitQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrmBenefitQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrmBenefitQueryResponse setBody(HrmBenefitQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public HrmBenefitQueryResponseBody getBody() {
        return this.body;
    }

}
