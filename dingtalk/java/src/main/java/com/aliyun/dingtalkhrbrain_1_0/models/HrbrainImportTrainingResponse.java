// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportTrainingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportTrainingResponseBody body;

    public static HrbrainImportTrainingResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportTrainingResponse self = new HrbrainImportTrainingResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportTrainingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportTrainingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportTrainingResponse setBody(HrbrainImportTrainingResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportTrainingResponseBody getBody() {
        return this.body;
    }

}
