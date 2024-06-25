// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CreateSpaceRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>这里是知识库的简介</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <strong>example:</strong>
     * <p><a href="https://img.alicdn.com/imgextra/i1/O1***.png">https://img.alicdn.com/imgextra/i1/O1***.png</a></p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>测试知识库</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>YEp3JcM******UIbhwiE</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <strong>example:</strong>
     * <p>l6gYG9****mo9Z</p>
     */
    @NameInMap("sectionId")
    public String sectionId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("shareScope")
    public CreateSpaceRequestShareScope shareScope;

    /**
     * <strong>example:</strong>
     * <p>5YRB***GDAr</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
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
