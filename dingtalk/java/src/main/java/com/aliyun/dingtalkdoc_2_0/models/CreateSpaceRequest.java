// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CreateSpaceRequest extends TeaModel {
    @NameInMap("description")
    public String description;

    @NameInMap("icon")
    public String icon;

    @NameInMap("name")
    public String name;

    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("sectionId")
    public String sectionId;

    @NameInMap("shareScope")
    public CreateSpaceRequestShareScope shareScope;

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
