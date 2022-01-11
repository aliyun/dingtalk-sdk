// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class UpdateOfficialAccountRobotInfoRequest extends TeaModel {
    // 机器人头像
    @NameInMap("avatar")
    public String avatar;

    // 机器人简介
    @NameInMap("brief")
    public String brief;

    // 机器人描述
    @NameInMap("description")
    public String description;

    // 机器人名称
    @NameInMap("name")
    public String name;

    // 机器人预览图
    @NameInMap("previewMediaUrl")
    public String previewMediaUrl;

    // 机器人类型参数
    @NameInMap("type")
    public String type;

    public static UpdateOfficialAccountRobotInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateOfficialAccountRobotInfoRequest self = new UpdateOfficialAccountRobotInfoRequest();
        return TeaModel.build(map, self);
    }

    public UpdateOfficialAccountRobotInfoRequest setAvatar(String avatar) {
        this.avatar = avatar;
        return this;
    }
    public String getAvatar() {
        return this.avatar;
    }

    public UpdateOfficialAccountRobotInfoRequest setBrief(String brief) {
        this.brief = brief;
        return this;
    }
    public String getBrief() {
        return this.brief;
    }

    public UpdateOfficialAccountRobotInfoRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateOfficialAccountRobotInfoRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateOfficialAccountRobotInfoRequest setPreviewMediaUrl(String previewMediaUrl) {
        this.previewMediaUrl = previewMediaUrl;
        return this;
    }
    public String getPreviewMediaUrl() {
        return this.previewMediaUrl;
    }

    public UpdateOfficialAccountRobotInfoRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
