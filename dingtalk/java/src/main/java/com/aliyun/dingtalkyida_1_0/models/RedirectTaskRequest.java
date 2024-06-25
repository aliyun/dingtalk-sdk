// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RedirectTaskRequest extends TeaModel {
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
     * <p>y</p>
     */
    @NameInMap("byManager")
    public String byManager;

    /**
     * <strong>example:</strong>
     * <p>zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nowActionExecutorId")
    public String nowActionExecutorId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>task-123</p>
     */
    @NameInMap("taskId")
    public Long taskId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static RedirectTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        RedirectTaskRequest self = new RedirectTaskRequest();
        return TeaModel.build(map, self);
    }

    public RedirectTaskRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public RedirectTaskRequest setByManager(String byManager) {
        this.byManager = byManager;
        return this;
    }
    public String getByManager() {
        return this.byManager;
    }

    public RedirectTaskRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public RedirectTaskRequest setNowActionExecutorId(String nowActionExecutorId) {
        this.nowActionExecutorId = nowActionExecutorId;
        return this;
    }
    public String getNowActionExecutorId() {
        return this.nowActionExecutorId;
    }

    public RedirectTaskRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public RedirectTaskRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public RedirectTaskRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public RedirectTaskRequest setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

    public RedirectTaskRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
