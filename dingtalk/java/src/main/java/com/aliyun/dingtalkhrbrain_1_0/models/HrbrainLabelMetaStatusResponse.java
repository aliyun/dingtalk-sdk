// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelMetaStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainLabelMetaStatusResponseBody body;

    public static HrbrainLabelMetaStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelMetaStatusResponse self = new HrbrainLabelMetaStatusResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelMetaStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainLabelMetaStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainLabelMetaStatusResponse setBody(HrbrainLabelMetaStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainLabelMetaStatusResponseBody getBody() {
        return this.body;
    }

}
