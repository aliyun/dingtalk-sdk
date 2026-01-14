// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelDataUpsertResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainLabelDataUpsertResponseBody body;

    public static HrbrainLabelDataUpsertResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelDataUpsertResponse self = new HrbrainLabelDataUpsertResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelDataUpsertResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainLabelDataUpsertResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainLabelDataUpsertResponse setBody(HrbrainLabelDataUpsertResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainLabelDataUpsertResponseBody getBody() {
        return this.body;
    }

}
