// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelMetaResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainLabelMetaResponseBody body;

    public static HrbrainLabelMetaResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelMetaResponse self = new HrbrainLabelMetaResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelMetaResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainLabelMetaResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainLabelMetaResponse setBody(HrbrainLabelMetaResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainLabelMetaResponseBody getBody() {
        return this.body;
    }

}
