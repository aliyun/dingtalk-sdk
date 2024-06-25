// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class UpdateInstalledRobotRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>钉钉的助手机器人</p>
     */
    @NameInMap("brief")
    public String brief;

    /**
     * <strong>example:</strong>
     * <p>钉钉的助手机器人的详细描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <strong>example:</strong>
     * <p>@IAfnkdsanfnkljn</p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <strong>example:</strong>
     * <p>钉钉助手</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingXXXXXXXXXX</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
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
