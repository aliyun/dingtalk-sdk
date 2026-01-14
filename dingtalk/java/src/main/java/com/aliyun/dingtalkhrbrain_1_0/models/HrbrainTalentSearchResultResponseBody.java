// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainTalentSearchResultResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<String> content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static HrbrainTalentSearchResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrbrainTalentSearchResultResponseBody self = new HrbrainTalentSearchResultResponseBody();
        return TeaModel.build(map, self);
    }

    public HrbrainTalentSearchResultResponseBody setContent(java.util.List<String> content) {
        this.content = content;
        return this;
    }
    public java.util.List<String> getContent() {
        return this.content;
    }

    public HrbrainTalentSearchResultResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HrbrainTalentSearchResultResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public HrbrainTalentSearchResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
