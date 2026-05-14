// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class RestartInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_XCEXXX</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>node_xxx</p>
     */
    @NameInMap("currentActivityId")
    public String currentActivityId;

    /**
     * <strong>example:</strong>
     * <p>vpc（国内、默认）/ sgp_vpc（海外）</p>
     */
    @NameInMap("envProfile")
    public String envProfile;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>FORM-XXX</p>
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
     * <p>098661XXX</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sid-restartevent</p>
     */
    @NameInMap("targetActivityId")
    public String targetActivityId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123XXX</p>
     */
    @NameInMap("taskId")
    public String taskId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>173XXX</p>
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
