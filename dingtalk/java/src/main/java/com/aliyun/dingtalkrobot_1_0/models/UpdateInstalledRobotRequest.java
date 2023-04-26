// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class UpdateInstalledRobotRequest extends TeaModel {
    @NameInMap("brief")
    public String brief;

    @NameInMap("description")
    public String description;

    @NameInMap("icon")
    public String icon;

    @NameInMap("name")
    public String name;

    @NameInMap("robotCode")
    public String robotCode;

    @NameInMap("updateType")
    public Integer updateType;

    public static UpdateInstalledRobotRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInstalledRobotRequest self = new UpdateInstalledRobotRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInstalledRobotRequest setBrief(String brief) {
        this.brief = brief;
        return this;
    }
    public String getBrief() {
        return this.brief;
    }

    public UpdateInstalledRobotRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateInstalledRobotRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public UpdateInstalledRobotRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateInstalledRobotRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public UpdateInstalledRobotRequest setUpdateType(Integer updateType) {
        this.updateType = updateType;
        return this;
    }
    public Integer getUpdateType() {
        return this.updateType;
    }

}
