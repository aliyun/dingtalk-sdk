// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ImportGroupChatRequest extends TeaModel {
    @NameInMap("adminIds")
    public java.util.List<String> adminIds;

    @NameInMap("createAt")
    public Long createAt;

    /**
     * <strong>example:</strong>
     * <p>@lADOADma*****QKA</p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>axcf*-<em><strong><strong>-</strong></strong></em>-23da*</p>
     */
    @NameInMap("importUuid")
    public String importUuid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1107****2120</p>
     */
    @NameInMap("owner")
    public String owner;

    /**
     * <strong>example:</strong>
     * <p>c354***-<em><strong>-</strong></em>-b4ea-6f1ab***65</p>
     */
    @NameInMap("templateId")
    public String templateId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>示例群名称</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userList")
    public java.util.Map<String, UserListValue> userList;

    public static ImportGroupChatRequest build(java.util.Map<String, ?> map) throws Exception {
        ImportGroupChatRequest self = new ImportGroupChatRequest();
        return TeaModel.build(map, self);
    }

    public ImportGroupChatRequest setAdminIds(java.util.List<String> adminIds) {
        this.adminIds = adminIds;
        return this;
    }
    public java.util.List<String> getAdminIds() {
        return this.adminIds;
    }

    public ImportGroupChatRequest setCreateAt(Long createAt) {
        this.createAt = createAt;
        return this;
    }
    public Long getCreateAt() {
        return this.createAt;
    }

    public ImportGroupChatRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public ImportGroupChatRequest setImportUuid(String importUuid) {
        this.importUuid = importUuid;
        return this;
    }
    public String getImportUuid() {
        return this.importUuid;
    }

    public ImportGroupChatRequest setOwner(String owner) {
        this.owner = owner;
        return this;
    }
    public String getOwner() {
        return this.owner;
    }

    public ImportGroupChatRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public ImportGroupChatRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public ImportGroupChatRequest setUserList(java.util.Map<String, UserListValue> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.Map<String, UserListValue> getUserList() {
        return this.userList;
    }

}
