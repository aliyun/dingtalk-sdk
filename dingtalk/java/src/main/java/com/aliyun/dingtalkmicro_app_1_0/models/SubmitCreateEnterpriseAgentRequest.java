// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class SubmitCreateEnterpriseAgentRequest extends TeaModel {
    @NameInMap("appName")
    public String appName;

    @NameInMap("desc")
    public String desc;

    @NameInMap("previewMediaId")
    public String previewMediaId;

    @NameInMap("robotMediaId")
    public String robotMediaId;

    @NameInMap("robotName")
    public String robotName;

    @NameInMap("taskId")
    public String taskId;

    @NameInMap("userid")
    public String userid;

    public static SubmitCreateEnterpriseAgentRequest build(java.util.Map<String, ?> map) throws Exception {
        SubmitCreateEnterpriseAgentRequest self = new SubmitCreateEnterpriseAgentRequest();
        return TeaModel.build(map, self);
    }

    public SubmitCreateEnterpriseAgentRequest setAppName(String appName) {
        this.appName = appName;
        return this;
    }
    public String getAppName() {
        return this.appName;
    }

    public SubmitCreateEnterpriseAgentRequest setDesc(String desc) {
        this.desc = desc;
        return this;
    }
    public String getDesc() {
        return this.desc;
    }

    public SubmitCreateEnterpriseAgentRequest setPreviewMediaId(String previewMediaId) {
        this.previewMediaId = previewMediaId;
        return this;
    }
    public String getPreviewMediaId() {
        return this.previewMediaId;
    }

    public SubmitCreateEnterpriseAgentRequest setRobotMediaId(String robotMediaId) {
        this.robotMediaId = robotMediaId;
        return this;
    }
    public String getRobotMediaId() {
        return this.robotMediaId;
    }

    public SubmitCreateEnterpriseAgentRequest setRobotName(String robotName) {
        this.robotName = robotName;
        return this;
    }
    public String getRobotName() {
        return this.robotName;
    }

    public SubmitCreateEnterpriseAgentRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public SubmitCreateEnterpriseAgentRequest setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
    }

}
