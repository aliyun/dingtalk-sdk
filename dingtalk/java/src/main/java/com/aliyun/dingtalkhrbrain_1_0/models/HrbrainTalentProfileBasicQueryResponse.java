// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainTalentProfileBasicQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainTalentProfileBasicQueryResponseBody body;

    public static HrbrainTalentProfileBasicQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainTalentProfileBasicQueryResponse self = new HrbrainTalentProfileBasicQueryResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainTalentProfileBasicQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainTalentProfileBasicQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainTalentProfileBasicQueryResponse setBody(HrbrainTalentProfileBasicQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainTalentProfileBasicQueryResponseBody getBody() {
        return this.body;
    }

}
