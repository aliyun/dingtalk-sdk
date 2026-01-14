// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelMetaUpdateResponseBody extends TeaModel {
    @NameInMap("content")
    public String content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static HrbrainLabelMetaUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelMetaUpdateResponseBody self = new HrbrainLabelMetaUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelMetaUpdateResponseBody setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public HrbrainLabelMetaUpdateResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HrbrainLabelMetaUpdateResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public HrbrainLabelMetaUpdateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
