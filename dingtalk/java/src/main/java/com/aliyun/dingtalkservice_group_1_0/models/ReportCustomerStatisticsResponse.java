// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ReportCustomerStatisticsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ReportCustomerStatisticsResponseBody body;

    public static ReportCustomerStatisticsResponse build(java.util.Map<String, ?> map) throws Exception {
        ReportCustomerStatisticsResponse self = new ReportCustomerStatisticsResponse();
        return TeaModel.build(map, self);
    }

    public ReportCustomerStatisticsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReportCustomerStatisticsResponse setBody(ReportCustomerStatisticsResponseBody body) {
        this.body = body;
        return this;
    }
    public ReportCustomerStatisticsResponseBody getBody() {
        return this.body;
    }

}
