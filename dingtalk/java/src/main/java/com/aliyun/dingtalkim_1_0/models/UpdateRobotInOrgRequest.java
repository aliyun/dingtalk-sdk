// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateRobotInOrgRequest extends TeaModel {
    // 简介
    @NameInMap("brief")
    public String brief;

    // 描述
    @NameInMap("description")
    public String description;

    // 机器人meidaId
    @NameInMap("icon")
    public String icon;

    // 机器人名称
    @NameInMap("name")
    public String name;

    // 消息回调验证token
    @NameInMap("outgoingToken")
    public String outgoingToken;

    // 消息回调地址
    @NameInMap("outgoingUrl")
    public String outgoingUrl;

    // 预览图mediaId
    @NameInMap("previewMediaId")
    public String previewMediaId;

    // 机器人编码
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
