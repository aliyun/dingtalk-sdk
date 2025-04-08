// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteTrainingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeleteTrainingResponseBody body;

    public static HrbrainDeleteTrainingResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteTrainingResponse self = new HrbrainDeleteTrainingResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteTrainingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeleteTrainingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeleteTrainingResponse setBody(HrbrainDeleteTrainingResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeleteTrainingResponseBody getBody() {
        return this.body;
    }

}
