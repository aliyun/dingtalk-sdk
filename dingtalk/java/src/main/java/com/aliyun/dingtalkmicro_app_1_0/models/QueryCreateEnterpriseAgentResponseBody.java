// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class QueryCreateEnterpriseAgentResponseBody extends TeaModel {
    @NameInMap("agentId")
    public String agentId;

    @NameInMap("clientId")
    public String clientId;

    @NameInMap("clientSecret")
    public String clientSecret;

    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("expiresIn")
    public Long expiresIn;

    @NameInMap("gmtCreate")
    public Long gmtCreate;

    @NameInMap("gmtModified")
    public Long gmtModified;

    @NameInMap("interval")
    public Long interval;

    @NameInMap("retryCount")
    public Long retryCount;

    @NameInMap("robotCode")
    public String robotCode;

    @NameInMap("status")
    public String status;

    @NameInMap("taskId")
    public String taskId;

    @NameInMap("unifiedAppId")
    public String unifiedAppId;

    public static QueryCreateEnterpriseAgentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCreateEnterpriseAgentResponseBody self = new QueryCreateEnterpriseAgentResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCreateEnterpriseAgentResponseBody setAgentId(String agentId) {
        this.agentId = agentId;
        return this;
    }
    public String getAgentId() {
        return this.agentId;
    }

    public QueryCreateEnterpriseAgentResponseBody setClientId(String clientId) {
        this.clientId = clientId;
        return this;
    }
    public String getClientId() {
        return this.clientId;
    }

    public QueryCreateEnterpriseAgentResponseBody setClientSecret(String clientSecret) {
        this.clientSecret = clientSecret;
        return this;
    }
    public String getClientSecret() {
        return this.clientSecret;
    }

    public QueryCreateEnterpriseAgentResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public QueryCreateEnterpriseAgentResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public QueryCreateEnterpriseAgentResponseBody setExpiresIn(Long expiresIn) {
        this.expiresIn = expiresIn;
        return this;
    }
    public Long getExpiresIn() {
        return this.expiresIn;
    }

    public QueryCreateEnterpriseAgentResponseBody setGmtCreate(Long gmtCreate) {
        this.gmtCreate = gmtCreate;
        return this;
    }
    public Long getGmtCreate() {
        return this.gmtCreate;
    }

    public QueryCreateEnterpriseAgentResponseBody setGmtModified(Long gmtModified) {
        this.gmtModified = gmtModified;
        return this;
    }
    public Long getGmtModified() {
        return this.gmtModified;
    }

    public QueryCreateEnterpriseAgentResponseBody setInterval(Long interval) {
        this.interval = interval;
        return this;
    }
    public Long getInterval() {
        return this.interval;
    }

    public QueryCreateEnterpriseAgentResponseBody setRetryCount(Long retryCount) {
        this.retryCount = retryCount;
        return this;
    }
    public Long getRetryCount() {
        return this.retryCount;
    }

    public QueryCreateEnterpriseAgentResponseBody setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public QueryCreateEnterpriseAgentResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public QueryCreateEnterpriseAgentResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public QueryCreateEnterpriseAgentResponseBody setUnifiedAppId(String unifiedAppId) {
        this.unifiedAppId = unifiedAppId;
        return this;
    }
    public String getUnifiedAppId() {
        return this.unifiedAppId;
    }

}
