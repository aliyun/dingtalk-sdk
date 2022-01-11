// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RedirectTaskRequest extends TeaModel {
    // 应用ID
    @NameInMap("appType")
    public String appType;

    // 是否应用管理员进行转交; ●
    // 可选项 : y/n
    // 
    // ●
    // y,则userId必须传应用管理员工号，或者yida_pub_account
    // 
    // ●
    // n, userId必须传任务的当前执行人
    @NameInMap("byManager")
    public String byManager;

    // 语言环境; 可选值：zh_CN/en_US
    @NameInMap("language")
    public String language;

    // 新的任务处理人工号
    @NameInMap("nowActionExecutorId")
    public String nowActionExecutorId;

    // 实例ID
    @NameInMap("processInstanceId")
    public String processInstanceId;

    // 转交备注
    @NameInMap("remark")
    public String remark;

    // 验权token; 在应用数据中获取。
    @NameInMap("systemToken")
    public String systemToken;

    // 任务ID
    @NameInMap("taskId")
    public Long taskId;

    // 钉钉的userId
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
