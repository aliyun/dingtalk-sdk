// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupRequest extends TeaModel {
    @NameInMap("add_extidlist")
    public java.util.List<String> addExtidlist;

    @NameInMap("add_useridlist")
    public java.util.List<String> addUseridlist;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("chatid")
    public String chatid;

    @NameInMap("del_extidlist")
    public java.util.List<String> delExtidlist;

    @NameInMap("del_useridlist")
    public java.util.List<String> delUseridlist;

    @NameInMap("icon")
    public String icon;

    @NameInMap("managementOptions")
    public UpdateGroupRequestManagementOptions managementOptions;

    @NameInMap("name")
    public String name;

    @NameInMap("owner")
    public String owner;

    @NameInMap("ownerType")
    public String ownerType;

    public static UpdateGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupRequest self = new UpdateGroupRequest();
        return TeaModel.build(map, self);
    }

    public UpdateGroupRequest setAddExtidlist(java.util.List<String> addExtidlist) {
        this.addExtidlist = addExtidlist;
        return this;
    }
    public java.util.List<String> getAddExtidlist() {
        return this.addExtidlist;
    }

    public UpdateGroupRequest setAddUseridlist(java.util.List<String> addUseridlist) {
        this.addUseridlist = addUseridlist;
        return this;
    }
    public java.util.List<String> getAddUseridlist() {
        return this.addUseridlist;
    }

    public UpdateGroupRequest setChatid(String chatid) {
        this.chatid = chatid;
        return this;
    }
    public String getChatid() {
        return this.chatid;
    }

    public UpdateGroupRequest setDelExtidlist(java.util.List<String> delExtidlist) {
        this.delExtidlist = delExtidlist;
        return this;
    }
    public java.util.List<String> getDelExtidlist() {
        return this.delExtidlist;
    }

    public UpdateGroupRequest setDelUseridlist(java.util.List<String> delUseridlist) {
        this.delUseridlist = delUseridlist;
        return this;
    }
    public java.util.List<String> getDelUseridlist() {
        return this.delUseridlist;
    }

    public UpdateGroupRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public UpdateGroupRequest setManagementOptions(UpdateGroupRequestManagementOptions managementOptions) {
        this.managementOptions = managementOptions;
        return this;
    }
    public UpdateGroupRequestManagementOptions getManagementOptions() {
        return this.managementOptions;
    }

    public UpdateGroupRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateGroupRequest setOwner(String owner) {
        this.owner = owner;
        return this;
    }
    public String getOwner() {
        return this.owner;
    }

    public UpdateGroupRequest setOwnerType(String ownerType) {
        this.ownerType = ownerType;
        return this;
    }
    public String getOwnerType() {
        return this.ownerType;
    }

    public static class UpdateGroupRequestManagementOptions extends TeaModel {
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

        public static UpdateGroupRequestManagementOptions build(java.util.Map<String, ?> map) throws Exception {
            UpdateGroupRequestManagementOptions self = new UpdateGroupRequestManagementOptions();
            return TeaModel.build(map, self);
        }

        public UpdateGroupRequestManagementOptions setChatBannedType(Integer chatBannedType) {
            this.chatBannedType = chatBannedType;
            return this;
        }
        public Integer getChatBannedType() {
            return this.chatBannedType;
        }

        public UpdateGroupRequestManagementOptions setManagementType(Integer managementType) {
            this.managementType = managementType;
            return this;
        }
        public Integer getManagementType() {
            return this.managementType;
        }

        public UpdateGroupRequestManagementOptions setMentionAllAuthority(Integer mentionAllAuthority) {
            this.mentionAllAuthority = mentionAllAuthority;
            return this;
        }
        public Integer getMentionAllAuthority() {
            return this.mentionAllAuthority;
        }

        public UpdateGroupRequestManagementOptions setSearchable(Integer searchable) {
            this.searchable = searchable;
            return this;
        }
        public Integer getSearchable() {
            return this.searchable;
        }

        public UpdateGroupRequestManagementOptions setShowHistoryType(Integer showHistoryType) {
            this.showHistoryType = showHistoryType;
            return this;
        }
        public Integer getShowHistoryType() {
            return this.showHistoryType;
        }

        public UpdateGroupRequestManagementOptions setValidationType(Integer validationType) {
            this.validationType = validationType;
            return this;
        }
        public Integer getValidationType() {
            return this.validationType;
        }

    }

}
