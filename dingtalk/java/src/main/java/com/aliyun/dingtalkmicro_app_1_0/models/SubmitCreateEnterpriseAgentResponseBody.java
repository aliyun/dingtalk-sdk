// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class SubmitCreateEnterpriseAgentResponseBody extends TeaModel {
    @NameInMap("expiresIn")
    public String expiresIn;

    @NameInMap("interval")
    public String interval;

    @NameInMap("retryCount")
    public String retryCount;

    @NameInMap("status")
    public String status;

    @NameInMap("taskId")
    public String taskId;

    public static SubmitCreateEnterpriseAgentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SubmitCreateEnterpriseAgentResponseBody self = new SubmitCreateEnterpriseAgentResponseBody();
        return TeaModel.build(map, self);
    }

    public SubmitCreateEnterpriseAgentResponseBody setExpiresIn(String expiresIn) {
        this.expiresIn = expiresIn;
        return this;
    }
    public String getExpiresIn() {
        return this.expiresIn;
    }

    public SubmitCreateEnterpriseAgentResponseBody setInterval(String interval) {
        this.interval = interval;
        return this;
    }
    public String getInterval() {
        return this.interval;
    }

    public SubmitCreateEnterpriseAgentResponseBody setRetryCount(String retryCount) {
        this.retryCount = retryCount;
        return this;
    }
    public String getRetryCount() {
        return this.retryCount;
    }

    public SubmitCreateEnterpriseAgentResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public SubmitCreateEnterpriseAgentResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
