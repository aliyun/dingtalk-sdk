// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchRecallPrivateChatResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>5fe11095f46315d8d30d3f8XXXXXX:SYSTEM_ERROR</p>
     */
    @NameInMap("failedResult")
    public java.util.Map<String, String> failedResult;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("successResult")
    public java.util.List<String> successResult;

    public static BatchRecallPrivateChatResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchRecallPrivateChatResponseBody self = new BatchRecallPrivateChatResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchRecallPrivateChatResponseBody setFailedResult(java.util.Map<String, String> failedResult) {
        this.failedResult = failedResult;
        return this;
    }
    public java.util.Map<String, String> getFailedResult() {
        return this.failedResult;
    }

    public BatchRecallPrivateChatResponseBody setSuccessResult(java.util.List<String> successResult) {
        this.successResult = successResult;
        return this;
    }
    public java.util.List<String> getSuccessResult() {
        return this.successResult;
    }

}
