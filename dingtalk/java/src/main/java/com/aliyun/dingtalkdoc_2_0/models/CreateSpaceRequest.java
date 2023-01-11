// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CreateSpaceRequest extends TeaModel {
    /**
     * <p>知识库简介。</p>
     * <p>最大长度50。</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>知识库图标。</p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <p>知识库名称。</p>
     * <p>最大长度50。</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>操作人unionId。</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <p>知识库分组id。只有选择了所属小组的情况下，才需要设置知识库分组。</p>
     */
    @NameInMap("sectionId")
    public String sectionId;

    /**
     * <p>公开范围。</p>
     */
    @NameInMap("shareScope")
    public CreateSpaceRequestShareScope shareScope;

    /**
     * <p>所属小组id。</p>
     */
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
        /**
         * <p>公开范围。</p>
         * <p>0-仅知识库成员可见；</p>
         * <p>1-当前组织所有人可见。</p>
         */
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
