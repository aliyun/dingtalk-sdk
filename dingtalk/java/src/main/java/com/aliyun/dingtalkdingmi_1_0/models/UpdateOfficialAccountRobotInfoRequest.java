// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class UpdateOfficialAccountRobotInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxxx</p>
     */
    @NameInMap("avatar")
    public String avatar;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>小蜜客服机器人</p>
     */
    @NameInMap("brief")
    public String brief;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>小蜜客服机器人是7*24小时智能问答机器人</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>小蜜机器人</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxxx</p>
     */
    @NameInMap("previewMediaUrl")
    public String previewMediaUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>机器人类型参数，服务窗机器人：1，客户群内机器人：2</p>
     */
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
