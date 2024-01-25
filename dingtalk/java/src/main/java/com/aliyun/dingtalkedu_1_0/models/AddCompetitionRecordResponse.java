// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddCompetitionRecordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddCompetitionRecordResponseBody body;

    public static AddCompetitionRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        AddCompetitionRecordResponse self = new AddCompetitionRecordResponse();
        return TeaModel.build(map, self);
    }

    public AddCompetitionRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddCompetitionRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddCompetitionRecordResponse setBody(AddCompetitionRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public AddCompetitionRecordResponseBody getBody() {
        return this.body;
    }

}
