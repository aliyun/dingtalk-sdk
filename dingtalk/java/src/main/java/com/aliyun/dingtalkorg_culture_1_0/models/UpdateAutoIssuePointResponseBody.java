// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class UpdateAutoIssuePointResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateAutoIssuePointResponseBodyResult result;

    // 调用是否成功
    @NameInMap("success")
    public Boolean success;

    public static UpdateAutoIssuePointResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateAutoIssuePointResponseBody self = new UpdateAutoIssuePointResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateAutoIssuePointResponseBody setResult(UpdateAutoIssuePointResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateAutoIssuePointResponseBodyResult getResult() {
        return this.result;
    }

    public UpdateAutoIssuePointResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class UpdateAutoIssuePointResponseBodyResult extends TeaModel {
        // 下次自动发放时间
        @NameInMap("nextAutoIssuePointTime")
        public Long nextAutoIssuePointTime;

        public static UpdateAutoIssuePointResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateAutoIssuePointResponseBodyResult self = new UpdateAutoIssuePointResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateAutoIssuePointResponseBodyResult setNextAutoIssuePointTime(Long nextAutoIssuePointTime) {
            this.nextAutoIssuePointTime = nextAutoIssuePointTime;
            return this;
        }
        public Long getNextAutoIssuePointTime() {
            return this.nextAutoIssuePointTime;
        }

    }

}
