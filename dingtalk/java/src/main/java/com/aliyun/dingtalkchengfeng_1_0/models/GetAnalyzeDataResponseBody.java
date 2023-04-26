// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetAnalyzeDataResponseBody extends TeaModel {
    @NameInMap("content")
    public OpenAnalyzeDataDTO content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static GetAnalyzeDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAnalyzeDataResponseBody self = new GetAnalyzeDataResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAnalyzeDataResponseBody setContent(OpenAnalyzeDataDTO content) {
        this.content = content;
        return this;
    }
    public OpenAnalyzeDataDTO getContent() {
        return this.content;
    }

    public GetAnalyzeDataResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetAnalyzeDataResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
