// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainTalentProfileAttachmentQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainTalentProfileAttachmentQueryResponseBody body;

    public static HrbrainTalentProfileAttachmentQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainTalentProfileAttachmentQueryResponse self = new HrbrainTalentProfileAttachmentQueryResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainTalentProfileAttachmentQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainTalentProfileAttachmentQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainTalentProfileAttachmentQueryResponse setBody(HrbrainTalentProfileAttachmentQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainTalentProfileAttachmentQueryResponseBody getBody() {
        return this.body;
    }

}
