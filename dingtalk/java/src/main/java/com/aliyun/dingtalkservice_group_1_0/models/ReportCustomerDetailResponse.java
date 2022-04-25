// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ReportCustomerDetailResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ReportCustomerDetailResponseBody body;

    public static ReportCustomerDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        ReportCustomerDetailResponse self = new ReportCustomerDetailResponse();
        return TeaModel.build(map, self);
    }

    public ReportCustomerDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReportCustomerDetailResponse setBody(ReportCustomerDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public ReportCustomerDetailResponseBody getBody() {
        return this.body;
    }

}
