// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteAwardRecordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeleteAwardRecordsResponseBody body;

    public static HrbrainDeleteAwardRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteAwardRecordsResponse self = new HrbrainDeleteAwardRecordsResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteAwardRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeleteAwardRecordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeleteAwardRecordsResponse setBody(HrbrainDeleteAwardRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeleteAwardRecordsResponseBody getBody() {
        return this.body;
    }

}
