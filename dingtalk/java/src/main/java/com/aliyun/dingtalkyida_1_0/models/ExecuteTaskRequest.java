// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ExecuteTaskRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_PBKT0MFBEBTDO8T7SLVP</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <strong>example:</strong>
     * <p><a href="https://tianshu-vpc.oss-cn-sahnghai.aliyuncs.com">https://tianshu-vpc.oss-cn-sahnghai.aliyuncs.com</a></p>
     */
    @NameInMap("digitalSignUrl")
    public String digitalSignUrl;

    /**
     * <strong>example:</strong>
     * <p>未知</p>
     */
    @NameInMap("formDataJson")
    public String formDataJson;

    /**
     * <strong>example:</strong>
     * <p>zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <strong>example:</strong>
     * <p>y</p>
     */
    @NameInMap("noExecuteExpressions")
    public String noExecuteExpressions;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>AGREE</p>
     */
    @NameInMap("outResult")
    public String outResult;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>f30233fb-72e1-4af4-8cb8-c7e0ea9ee530</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>确认同意</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>hexxyy</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>12002575</p>
     */
    @NameInMap("taskId")
    public Long taskId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>未知</p>
     */
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
