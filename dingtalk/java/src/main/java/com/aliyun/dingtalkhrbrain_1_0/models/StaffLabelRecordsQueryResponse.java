// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class StaffLabelRecordsQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public StaffLabelRecordsQueryResponseBody body;

    public static StaffLabelRecordsQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        StaffLabelRecordsQueryResponse self = new StaffLabelRecordsQueryResponse();
        return TeaModel.build(map, self);
    }

    public StaffLabelRecordsQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public StaffLabelRecordsQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public StaffLabelRecordsQueryResponse setBody(StaffLabelRecordsQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public StaffLabelRecordsQueryResponseBody getBody() {
        return this.body;
    }

}
