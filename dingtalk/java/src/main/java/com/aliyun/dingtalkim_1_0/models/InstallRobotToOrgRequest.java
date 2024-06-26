// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class InstallRobotToOrgRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>这是小丁</p>
     */
    @NameInMap("brief")
    public String brief;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>我是小丁</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>@lALPDe7s26Bre</p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>小丁</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("outgoingToken")
    public String outgoingToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>https://*.com</p>
     */
    @NameInMap("outgoingUrl")
    public String outgoingUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>@lALPDe7s26Bre</p>
     */
    @NameInMap("previewMediaId")
    public String previewMediaId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static InstallRobotToOrgRequest build(java.util.Map<String, ?> map) throws Exception {
        InstallRobotToOrgRequest self = new InstallRobotToOrgRequest();
        return TeaModel.build(map, self);
    }

    public InstallRobotToOrgRequest setBrief(String brief) {
        this.brief = brief;
        return this;
    }
    public String getBrief() {
        return this.brief;
    }

    public InstallRobotToOrgRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public InstallRobotToOrgRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public InstallRobotToOrgRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public InstallRobotToOrgRequest setOutgoingToken(String outgoingToken) {
        this.outgoingToken = outgoingToken;
        return this;
    }
    public String getOutgoingToken() {
        return this.outgoingToken;
    }

    public InstallRobotToOrgRequest setOutgoingUrl(String outgoingUrl) {
        this.outgoingUrl = outgoingUrl;
        return this;
    }
    public String getOutgoingUrl() {
        return this.outgoingUrl;
    }

    public InstallRobotToOrgRequest setPreviewMediaId(String previewMediaId) {
        this.previewMediaId = previewMediaId;
        return this;
    }
    public String getPreviewMediaId() {
        return this.previewMediaId;
    }

    public InstallRobotToOrgRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
