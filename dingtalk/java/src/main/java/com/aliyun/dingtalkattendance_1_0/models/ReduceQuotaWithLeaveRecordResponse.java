// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ReduceQuotaWithLeaveRecordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ReduceQuotaWithLeaveRecordResponseBody body;

    public static ReduceQuotaWithLeaveRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        ReduceQuotaWithLeaveRecordResponse self = new ReduceQuotaWithLeaveRecordResponse();
        return TeaModel.build(map, self);
    }

    public ReduceQuotaWithLeaveRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReduceQuotaWithLeaveRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ReduceQuotaWithLeaveRecordResponse setBody(ReduceQuotaWithLeaveRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public ReduceQuotaWithLeaveRecordResponseBody getBody() {
        return this.body;
    }

}
