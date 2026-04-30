// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class RestartInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_XCE0EVXS6DYG3YDYC5RD</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("currentActivityId")
    public String currentActivityId;

    @NameInMap("envProfile")
    public String envProfile;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("procInstanceId")
    public String procInstanceId;

    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetActivityId")
    public String targetActivityId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>task-123</p>
     */
    @NameInMap("taskId")
    public String taskId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding173982232112232</p>
     */
    @NameInMap("userId")
    public String userId;

    public static RestartInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        RestartInstanceRequest self = new RestartInstanceRequest();
        return TeaModel.build(map, self);
    }

    public RestartInstanceRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public RestartInstanceRequest setCurrentActivityId(String currentActivityId) {
        this.currentActivityId = currentActivityId;
        return this;
    }
    public String getCurrentActivityId() {
        return this.currentActivityId;
    }

    public RestartInstanceRequest setEnvProfile(String envProfile) {
        this.envProfile = envProfile;
        return this;
    }
    public String getEnvProfile() {
        return this.envProfile;
    }

    public RestartInstanceRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public RestartInstanceRequest setProcInstanceId(String procInstanceId) {
        this.procInstanceId = procInstanceId;
        return this;
    }
    public String getProcInstanceId() {
        return this.procInstanceId;
    }

    public RestartInstanceRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public RestartInstanceRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public RestartInstanceRequest setTargetActivityId(String targetActivityId) {
        this.targetActivityId = targetActivityId;
        return this;
    }
    public String getTargetActivityId() {
        return this.targetActivityId;
    }

    public RestartInstanceRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public RestartInstanceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
