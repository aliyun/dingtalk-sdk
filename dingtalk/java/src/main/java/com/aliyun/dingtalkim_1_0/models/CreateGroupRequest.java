// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupRequest extends TeaModel {
    @NameInMap("conversationTag")
    public Long conversationTag;

    @NameInMap("extidlist")
    public java.util.List<String> extidlist;

    @NameInMap("icon")
    public String icon;

    @NameInMap("managementOptions")
    public CreateGroupRequestManagementOptions managementOptions;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("owner")
    public String owner;

    @NameInMap("ownerType")
    public String ownerType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("useridlist")
    public java.util.List<String> useridlist;

    public static CreateGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupRequest self = new CreateGroupRequest();
        return TeaModel.build(map, self);
    }

    public CreateGroupRequest setConversationTag(Long conversationTag) {
        this.conversationTag = conversationTag;
        return this;
    }
    public Long getConversationTag() {
        return this.conversationTag;
    }

    public CreateGroupRequest setExtidlist(java.util.List<String> extidlist) {
        this.extidlist = extidlist;
        return this;
    }
    public java.util.List<String> getExtidlist() {
        return this.extidlist;
    }

    public CreateGroupRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public CreateGroupRequest setManagementOptions(CreateGroupRequestManagementOptions managementOptions) {
        this.managementOptions = managementOptions;
        return this;
    }
    public CreateGroupRequestManagementOptions getManagementOptions() {
        return this.managementOptions;
    }

    public CreateGroupRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateGroupRequest setOwner(String owner) {
        this.owner = owner;
        return this;
    }
    public String getOwner() {
        return this.owner;
    }

    public CreateGroupRequest setOwnerType(String ownerType) {
        this.ownerType = ownerType;
        return this;
    }
    public String getOwnerType() {
        return this.ownerType;
    }

    public CreateGroupRequest setUseridlist(java.util.List<String> useridlist) {
        this.useridlist = useridlist;
        return this;
    }
    public java.util.List<String> getUseridlist() {
        return this.useridlist;
    }

    public static class CreateGroupRequestManagementOptions extends TeaModel {
        @NameInMap("chatBannedType")
        public Integer chatBannedType;

        @NameInMap("managementType")
        public Integer managementType;

        @NameInMap("mentionAllAuthority")
        public Integer mentionAllAuthority;

        @NameInMap("searchable")
        public Integer searchable;

        @NameInMap("showHistoryType")
        public Integer showHistoryType;

        @NameInMap("validationType")
        public Integer validationType;

        public static CreateGroupRequestManagementOptions build(java.util.Map<String, ?> map) throws Exception {
            CreateGroupRequestManagementOptions self = new CreateGroupRequestManagementOptions();
            return TeaModel.build(map, self);
        }

        public CreateGroupRequestManagementOptions setChatBannedType(Integer chatBannedType) {
            this.chatBannedType = chatBannedType;
            return this;
        }
        public Integer getChatBannedType() {
            return this.chatBannedType;
        }

        public CreateGroupRequestManagementOptions setManagementType(Integer managementType) {
            this.managementType = managementType;
            return this;
        }
        public Integer getManagementType() {
            return this.managementType;
        }

        public CreateGroupRequestManagementOptions setMentionAllAuthority(Integer mentionAllAuthority) {
            this.mentionAllAuthority = mentionAllAuthority;
            return this;
        }
        public Integer getMentionAllAuthority() {
            return this.mentionAllAuthority;
        }

        public CreateGroupRequestManagementOptions setSearchable(Integer searchable) {
            this.searchable = searchable;
            return this;
        }
        public Integer getSearchable() {
            return this.searchable;
        }

        public CreateGroupRequestManagementOptions setShowHistoryType(Integer showHistoryType) {
            this.showHistoryType = showHistoryType;
            return this;
        }
        public Integer getShowHistoryType() {
            return this.showHistoryType;
        }

        public CreateGroupRequestManagementOptions setValidationType(Integer validationType) {
            this.validationType = validationType;
            return this;
        }
        public Integer getValidationType() {
            return this.validationType;
        }

    }

}
