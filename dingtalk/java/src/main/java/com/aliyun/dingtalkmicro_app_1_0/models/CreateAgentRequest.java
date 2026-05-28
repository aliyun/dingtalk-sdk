// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class CreateAgentRequest extends TeaModel {
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

    @NameInMap("userid")
    public String userid;

    public static CreateAgentRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAgentRequest self = new CreateAgentRequest();
        return TeaModel.build(map, self);
    }

    public CreateAgentRequest setAppName(String appName) {
        this.appName = appName;
        return this;
    }
    public String getAppName() {
        return this.appName;
    }

    public CreateAgentRequest setDesc(String desc) {
        this.desc = desc;
        return this;
    }
    public String getDesc() {
        return this.desc;
    }

    public CreateAgentRequest setPreviewMediaId(String previewMediaId) {
        this.previewMediaId = previewMediaId;
        return this;
    }
    public String getPreviewMediaId() {
        return this.previewMediaId;
    }

    public CreateAgentRequest setRobotMediaId(String robotMediaId) {
        this.robotMediaId = robotMediaId;
        return this;
    }
    public String getRobotMediaId() {
        return this.robotMediaId;
    }

    public CreateAgentRequest setRobotName(String robotName) {
        this.robotName = robotName;
        return this;
    }
    public String getRobotName() {
        return this.robotName;
    }

    public CreateAgentRequest setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
    }

}
