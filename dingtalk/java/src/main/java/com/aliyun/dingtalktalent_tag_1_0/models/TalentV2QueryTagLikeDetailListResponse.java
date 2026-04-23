// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2QueryTagLikeDetailListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentV2QueryTagLikeDetailListResponseBody body;

    public static TalentV2QueryTagLikeDetailListResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentV2QueryTagLikeDetailListResponse self = new TalentV2QueryTagLikeDetailListResponse();
        return TeaModel.build(map, self);
    }

    public TalentV2QueryTagLikeDetailListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentV2QueryTagLikeDetailListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentV2QueryTagLikeDetailListResponse setBody(TalentV2QueryTagLikeDetailListResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentV2QueryTagLikeDetailListResponseBody getBody() {
        return this.body;
    }

}
