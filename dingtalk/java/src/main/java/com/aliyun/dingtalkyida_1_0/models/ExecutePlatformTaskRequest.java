// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ExecutePlatformTaskRequest extends TeaModel {
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
     * <p>●
     * agree</p>
     * <p>●
     * disagree</p>
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
     * <p>hexxyyddd</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>yida_pub_account</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ExecutePlatformTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        ExecutePlatformTaskRequest self = new ExecutePlatformTaskRequest();
        return TeaModel.build(map, self);
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

    public ExecutePlatformTaskRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public ExecutePlatformTaskRequest setNoExecuteExpressions(String noExecuteExpressions) {
        this.noExecuteExpressions = noExecuteExpressions;
        return this;
    }
    public String getNoExecuteExpressions() {
        return this.noExecuteExpressions;
    }

    public ExecutePlatformTaskRequest setOutResult(String outResult) {
        this.outResult = outResult;
        return this;
    }
    public String getOutResult() {
        return this.outResult;
    }

    public ExecutePlatformTaskRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public ExecutePlatformTaskRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public ExecutePlatformTaskRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public ExecutePlatformTaskRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
