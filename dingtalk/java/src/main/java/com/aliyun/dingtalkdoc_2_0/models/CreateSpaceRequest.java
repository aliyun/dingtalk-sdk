// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CreateSpaceRequest extends TeaModel {
    // 知识库简介。
    // 最大长度50。
    @NameInMap("description")
    public String description;

    // 知识库图标。
    @NameInMap("icon")
    public String icon;

    // 知识库名称。
    // 最大长度50。
    @NameInMap("name")
    public String name;

    // 操作人unionId。
    @NameInMap("operatorId")
    public String operatorId;

    // 知识库分组id。只有选择了所属小组的情况下，才需要设置知识库分组。
    @NameInMap("sectionId")
    public String sectionId;

    // 公开范围。
    @NameInMap("shareScope")
    public CreateSpaceRequestShareScope shareScope;

    // 所属小组id。
    @NameInMap("teamId")
    public String teamId;

    public static CreateSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateSpaceRequest self = new CreateSpaceRequest();
        return TeaModel.build(map, self);
    }

    public CreateSpaceRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateSpaceRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public CreateSpaceRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateSpaceRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CreateSpaceRequest setSectionId(String sectionId) {
        this.sectionId = sectionId;
        return this;
    }
    public String getSectionId() {
        return this.sectionId;
    }

    public CreateSpaceRequest setShareScope(CreateSpaceRequestShareScope shareScope) {
        this.shareScope = shareScope;
        return this;
    }
    public CreateSpaceRequestShareScope getShareScope() {
        return this.shareScope;
    }

    public CreateSpaceRequest setTeamId(String teamId) {
        this.teamId = teamId;
        return this;
    }
    public String getTeamId() {
        return this.teamId;
    }

    public static class CreateSpaceRequestShareScope extends TeaModel {
        // 公开范围。
        // 0-仅知识库成员可见；
        // 1-当前组织所有人可见。
        @NameInMap("scope")
        public Integer scope;

        public static CreateSpaceRequestShareScope build(java.util.Map<String, ?> map) throws Exception {
            CreateSpaceRequestShareScope self = new CreateSpaceRequestShareScope();
            return TeaModel.build(map, self);
        }

        public CreateSpaceRequestShareScope setScope(Integer scope) {
            this.scope = scope;
            return this;
        }
        public Integer getScope() {
            return this.scope;
        }

    }

}
