// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeletePromRecordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeletePromRecordsResponseBody body;

    public static HrbrainDeletePromRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeletePromRecordsResponse self = new HrbrainDeletePromRecordsResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeletePromRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeletePromRecordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeletePromRecordsResponse setBody(HrbrainDeletePromRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeletePromRecordsResponseBody getBody() {
        return this.body;
    }

}
