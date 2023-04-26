// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ExecuteTaskRequest extends TeaModel {
    @NameInMap("appType")
    public String appType;

    @NameInMap("digitalSignUrl")
    public String digitalSignUrl;

    @NameInMap("formDataJson")
    public String formDataJson;

    @NameInMap("language")
    public String language;

    @NameInMap("noExecuteExpressions")
    public String noExecuteExpressions;

    @NameInMap("outResult")
    public String outResult;

    @NameInMap("processInstanceId")
    public String processInstanceId;

    @NameInMap("remark")
    public String remark;

    @NameInMap("systemToken")
    public String systemToken;

    @NameInMap("taskId")
    public Long taskId;

    @NameInMap("userId")
    public String userId;

    public static ExecuteTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        ExecuteTaskRequest self = new ExecuteTaskRequest();
        return TeaModel.build(map, self);
    }

    public ExecuteTaskRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public ExecuteTaskRequest setDigitalSignUrl(String digitalSignUrl) {
        this.digitalSignUrl = digitalSignUrl;
        return this;
    }
    public String getDigitalSignUrl() {
        return this.digitalSignUrl;
    }

    public ExecuteTaskRequest setFormDataJson(String formDataJson) {
        this.formDataJson = formDataJson;
        return this;
    }
    public String getFormDataJson() {
        return this.formDataJson;
    }

    public ExecuteTaskRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public ExecuteTaskRequest setNoExecuteExpressions(String noExecuteExpressions) {
        this.noExecuteExpressions = noExecuteExpressions;
        return this;
    }
    public String getNoExecuteExpressions() {
        return this.noExecuteExpressions;
    }

    public ExecuteTaskRequest setOutResult(String outResult) {
        this.outResult = outResult;
        return this;
    }
    public String getOutResult() {
        return this.outResult;
    }

    public ExecuteTaskRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public ExecuteTaskRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public ExecuteTaskRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public ExecuteTaskRequest setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

    public ExecuteTaskRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
