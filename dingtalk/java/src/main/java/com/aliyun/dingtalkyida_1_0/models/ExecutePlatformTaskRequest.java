// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ExecutePlatformTaskRequest extends TeaModel {
    // 审批结果
    @NameInMap("outResult")
    public String outResult;

    // 是否不执行校验&关联操作
    @NameInMap("noExecuteExpressions")
    public String noExecuteExpressions;

    // 应用ID
    @NameInMap("appType")
    public String appType;

    // 更新的表单数据
    @NameInMap("formDataJson")
    public String formDataJson;

    // 应用秘钥
    @NameInMap("systemToken")
    public String systemToken;

    // 语言
    @NameInMap("language")
    public String language;

    // 审批意见
    @NameInMap("remark")
    public String remark;

    // 流程实例ID
    @NameInMap("processInstanceId")
    public String processInstanceId;

    // 钉钉的userId
    @NameInMap("userId")
    public String userId;

    public static ExecutePlatformTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        ExecutePlatformTaskRequest self = new ExecutePlatformTaskRequest();
        return TeaModel.build(map, self);
    }

    public ExecutePlatformTaskRequest setOutResult(String outResult) {
        this.outResult = outResult;
        return this;
    }
    public String getOutResult() {
        return this.outResult;
    }

    public ExecutePlatformTaskRequest setNoExecuteExpressions(String noExecuteExpressions) {
        this.noExecuteExpressions = noExecuteExpressions;
        return this;
    }
    public String getNoExecuteExpressions() {
        return this.noExecuteExpressions;
    }

    public ExecutePlatformTaskRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public ExecutePlatformTaskRequest setFormDataJson(String formDataJson) {
        this.formDataJson = formDataJson;
        return this;
    }
    public String getFormDataJson() {
        return this.formDataJson;
    }

    public ExecutePlatformTaskRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public ExecutePlatformTaskRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public ExecutePlatformTaskRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public ExecutePlatformTaskRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public ExecutePlatformTaskRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
