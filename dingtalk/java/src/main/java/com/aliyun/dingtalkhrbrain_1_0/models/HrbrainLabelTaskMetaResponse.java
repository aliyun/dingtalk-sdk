// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelTaskMetaResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainLabelTaskMetaResponseBody body;

    public static HrbrainLabelTaskMetaResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelTaskMetaResponse self = new HrbrainLabelTaskMetaResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelTaskMetaResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainLabelTaskMetaResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainLabelTaskMetaResponse setBody(HrbrainLabelTaskMetaResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainLabelTaskMetaResponseBody getBody() {
        return this.body;
    }

}
