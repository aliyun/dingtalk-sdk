// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class UpdateInstalledRobotRequest extends TeaModel {
    /**
     * <p>机器人的简要描述。</p>
     */
    @NameInMap("brief")
    public String brief;

    /**
     * <p>机器人的详细描述。</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>机器人图标的mediaId。</p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <p>机器人的名称。</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>机器人的robotCode。</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    /**
     * <p>更新名字或头像时是否更新群里已添加机器人的名字或头像。</p>
     * <p>0-不更新群里机器人名字或头像</p>
     * <p>1-更新群里机器人名字或头像</p>
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
