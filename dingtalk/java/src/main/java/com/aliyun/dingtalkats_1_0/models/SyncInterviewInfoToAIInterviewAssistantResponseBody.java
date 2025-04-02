// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class SyncInterviewInfoToAIInterviewAssistantResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static SyncInterviewInfoToAIInterviewAssistantResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncInterviewInfoToAIInterviewAssistantResponseBody self = new SyncInterviewInfoToAIInterviewAssistantResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncInterviewInfoToAIInterviewAssistantResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public SyncInterviewInfoToAIInterviewAssistantResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
