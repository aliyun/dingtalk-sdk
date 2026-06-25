// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmcp_1_0.models;

import com.aliyun.tea.*;

public class GetSkillDetailResponseBody extends TeaModel {
    @NameInMap("categories")
    public java.util.List<GetSkillDetailResponseBodyCategories> categories;

    @NameInMap("dependencies")
    public java.util.List<GetSkillDetailResponseBodyDependencies> dependencies;

    @NameInMap("description")
    public String description;

    @NameInMap("detailUrl")
    public String detailUrl;

    @NameInMap("icon")
    public String icon;

    @NameInMap("introduction")
    public String introduction;

    @NameInMap("name")
    public String name;

    @NameInMap("packageUrl")
    public String packageUrl;

    @NameInMap("skillId")
    public String skillId;

    public static GetSkillDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSkillDetailResponseBody self = new GetSkillDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSkillDetailResponseBody setCategories(java.util.List<GetSkillDetailResponseBodyCategories> categories) {
        this.categories = categories;
        return this;
    }
    public java.util.List<GetSkillDetailResponseBodyCategories> getCategories() {
        return this.categories;
    }

    public GetSkillDetailResponseBody setDependencies(java.util.List<GetSkillDetailResponseBodyDependencies> dependencies) {
        this.dependencies = dependencies;
        return this;
    }
    public java.util.List<GetSkillDetailResponseBodyDependencies> getDependencies() {
        return this.dependencies;
    }

    public GetSkillDetailResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetSkillDetailResponseBody setDetailUrl(String detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public String getDetailUrl() {
        return this.detailUrl;
    }

    public GetSkillDetailResponseBody setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public GetSkillDetailResponseBody setIntroduction(String introduction) {
        this.introduction = introduction;
        return this;
    }
    public String getIntroduction() {
        return this.introduction;
    }

    public GetSkillDetailResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetSkillDetailResponseBody setPackageUrl(String packageUrl) {
        this.packageUrl = packageUrl;
        return this;
    }
    public String getPackageUrl() {
        return this.packageUrl;
    }

    public GetSkillDetailResponseBody setSkillId(String skillId) {
        this.skillId = skillId;
        return this;
    }
    public String getSkillId() {
        return this.skillId;
    }

    public static class GetSkillDetailResponseBodyCategories extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("displayName")
        public String displayName;

        public static GetSkillDetailResponseBodyCategories build(java.util.Map<String, ?> map) throws Exception {
            GetSkillDetailResponseBodyCategories self = new GetSkillDetailResponseBodyCategories();
            return TeaModel.build(map, self);
        }

        public GetSkillDetailResponseBodyCategories setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetSkillDetailResponseBodyCategories setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class GetSkillDetailResponseBodyDependencies extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("refId")
        public String refId;

        @NameInMap("required")
        public Boolean required;

        @NameInMap("type")
        public String type;

        public static GetSkillDetailResponseBodyDependencies build(java.util.Map<String, ?> map) throws Exception {
            GetSkillDetailResponseBodyDependencies self = new GetSkillDetailResponseBodyDependencies();
            return TeaModel.build(map, self);
        }

        public GetSkillDetailResponseBodyDependencies setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public GetSkillDetailResponseBodyDependencies setRefId(String refId) {
            this.refId = refId;
            return this;
        }
        public String getRefId() {
            return this.refId;
        }

        public GetSkillDetailResponseBodyDependencies setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public GetSkillDetailResponseBodyDependencies setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
