// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdpaas_1_0.models;

import com.aliyun.tea.*;

public class InstallCoolAppOrderToGroupRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>cidxxx</p>
     */
    @NameInMap("conversationId")
    public String conversationId;

    @NameInMap("sortedPluginIdList")
    public java.util.List<Long> sortedPluginIdList;

    /**
     * <strong>example:</strong>
     * <p>template-id-xxx</p>
     */
    @NameInMap("templateId")
    public String templateId;

    @NameInMap("unsortedPluginIdList")
    public java.util.List<Long> unsortedPluginIdList;

    public static InstallCoolAppOrderToGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        InstallCoolAppOrderToGroupRequest self = new InstallCoolAppOrderToGroupRequest();
        return TeaModel.build(map, self);
    }

    public InstallCoolAppOrderToGroupRequest setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public InstallCoolAppOrderToGroupRequest setSortedPluginIdList(java.util.List<Long> sortedPluginIdList) {
        this.sortedPluginIdList = sortedPluginIdList;
        return this;
    }
    public java.util.List<Long> getSortedPluginIdList() {
        return this.sortedPluginIdList;
    }

    public InstallCoolAppOrderToGroupRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public InstallCoolAppOrderToGroupRequest setUnsortedPluginIdList(java.util.List<Long> unsortedPluginIdList) {
        this.unsortedPluginIdList = unsortedPluginIdList;
        return this;
    }
    public java.util.List<Long> getUnsortedPluginIdList() {
        return this.unsortedPluginIdList;
    }

}
