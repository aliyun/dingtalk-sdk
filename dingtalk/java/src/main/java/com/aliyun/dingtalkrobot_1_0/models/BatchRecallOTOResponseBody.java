// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchRecallOTOResponseBody extends TeaModel {
    /**
     * <p>撤回失败的消息id及对应的失败原因</p>
     */
    @NameInMap("failedResult")
    public java.util.Map<String, String> failedResult;

    /**
     * <p>撤回成功的消息id</p>
     */
    @NameInMap("successResult")
    public java.util.List<String> successResult;

    public static BatchRecallOTOResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchRecallOTOResponseBody self = new BatchRecallOTOResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchRecallOTOResponseBody setFailedResult(java.util.Map<String, String> failedResult) {
        this.failedResult = failedResult;
        return this;
    }
    public java.util.Map<String, String> getFailedResult() {
        return this.failedResult;
    }

    public BatchRecallOTOResponseBody setSuccessResult(java.util.List<String> successResult) {
        this.successResult = successResult;
        return this;
    }
    public java.util.List<String> getSuccessResult() {
        return this.successResult;
    }

}
