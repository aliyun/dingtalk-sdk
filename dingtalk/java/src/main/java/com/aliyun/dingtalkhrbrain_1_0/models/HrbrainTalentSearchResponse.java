// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainTalentSearchResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainTalentSearchResponseBody body;

    public static HrbrainTalentSearchResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainTalentSearchResponse self = new HrbrainTalentSearchResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainTalentSearchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainTalentSearchResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainTalentSearchResponse setBody(HrbrainTalentSearchResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainTalentSearchResponseBody getBody() {
        return this.body;
    }

}
