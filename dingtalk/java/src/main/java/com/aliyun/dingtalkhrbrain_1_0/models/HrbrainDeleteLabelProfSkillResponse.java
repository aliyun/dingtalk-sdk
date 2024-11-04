// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteLabelProfSkillResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeleteLabelProfSkillResponseBody body;

    public static HrbrainDeleteLabelProfSkillResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteLabelProfSkillResponse self = new HrbrainDeleteLabelProfSkillResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteLabelProfSkillResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeleteLabelProfSkillResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeleteLabelProfSkillResponse setBody(HrbrainDeleteLabelProfSkillResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeleteLabelProfSkillResponseBody getBody() {
        return this.body;
    }

}
