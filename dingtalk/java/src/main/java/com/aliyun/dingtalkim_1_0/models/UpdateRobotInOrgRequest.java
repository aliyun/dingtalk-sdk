// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateRobotInOrgRequest extends TeaModel {
    @NameInMap("brief")
    public String brief;

    @NameInMap("description")
    public String description;

    @NameInMap("icon")
    public String icon;

    @NameInMap("name")
    public String name;

    @NameInMap("outgoingToken")
    public String outgoingToken;

    @NameInMap("outgoingUrl")
    public String outgoingUrl;

    @NameInMap("previewMediaId")
    public String previewMediaId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static UpdateRobotInOrgRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateRobotInOrgRequest self = new UpdateRobotInOrgRequest();
        return TeaModel.build(map, self);
    }

    public UpdateRobotInOrgRequest setBrief(String brief) {
        this.brief = brief;
        return this;
    }
    public String getBrief() {
        return this.brief;
    }

    public UpdateRobotInOrgRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateRobotInOrgRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public UpdateRobotInOrgRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateRobotInOrgRequest setOutgoingToken(String outgoingToken) {
        this.outgoingToken = outgoingToken;
        return this;
    }
    public String getOutgoingToken() {
        return this.outgoingToken;
    }

    public UpdateRobotInOrgRequest setOutgoingUrl(String outgoingUrl) {
        this.outgoingUrl = outgoingUrl;
        return this;
    }
    public String getOutgoingUrl() {
        return this.outgoingUrl;
    }

    public UpdateRobotInOrgRequest setPreviewMediaId(String previewMediaId) {
        this.previewMediaId = previewMediaId;
        return this;
    }
    public String getPreviewMediaId() {
        return this.previewMediaId;
    }

    public UpdateRobotInOrgRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
