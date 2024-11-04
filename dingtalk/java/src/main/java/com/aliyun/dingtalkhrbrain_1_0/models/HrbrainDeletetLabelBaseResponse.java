// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeletetLabelBaseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeletetLabelBaseResponseBody body;

    public static HrbrainDeletetLabelBaseResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeletetLabelBaseResponse self = new HrbrainDeletetLabelBaseResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeletetLabelBaseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeletetLabelBaseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeletetLabelBaseResponse setBody(HrbrainDeletetLabelBaseResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeletetLabelBaseResponseBody getBody() {
        return this.body;
    }

}
