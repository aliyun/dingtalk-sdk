// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdateApaasAppRequest extends TeaModel {
    @NameInMap("appName")
    public String appName;

    @NameInMap("appIcon")
    public String appIcon;

    @NameInMap("appStatus")
    public Integer appStatus;

    @NameInMap("opUserId")
    public String opUserId;

    @NameInMap("bizAppId")
    public String bizAppId;

    public static UpdateApaasAppRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateApaasAppRequest self = new UpdateApaasAppRequest();
        return TeaModel.build(map, self);
    }

    public UpdateApaasAppRequest setAppName(String appName) {
        this.appName = appName;
        return this;
    }
    public String getAppName() {
        return this.appName;
    }

    public UpdateApaasAppRequest setAppIcon(String appIcon) {
        this.appIcon = appIcon;
        return this;
    }
    public String getAppIcon() {
        return this.appIcon;
    }

    public UpdateApaasAppRequest setAppStatus(Integer appStatus) {
        this.appStatus = appStatus;
        return this;
    }
    public Integer getAppStatus() {
        return this.appStatus;
    }

    public UpdateApaasAppRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public UpdateApaasAppRequest setBizAppId(String bizAppId) {
        this.bizAppId = bizAppId;
        return this;
    }
    public String getBizAppId() {
        return this.bizAppId;
    }

}
