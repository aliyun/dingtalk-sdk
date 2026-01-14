// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainTalentSearchResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainTalentSearchResultResponseBody body;

    public static HrbrainTalentSearchResultResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainTalentSearchResultResponse self = new HrbrainTalentSearchResultResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainTalentSearchResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainTalentSearchResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainTalentSearchResultResponse setBody(HrbrainTalentSearchResultResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainTalentSearchResultResponseBody getBody() {
        return this.body;
    }

}
