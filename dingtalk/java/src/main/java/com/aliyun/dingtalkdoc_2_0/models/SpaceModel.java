// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SpaceModel extends TeaModel {
    // 封面
    @NameInMap("cover")
    public String cover;

    // 空间描述信息
    @NameInMap("description")
    public String description;

    // 知识库图标
    @NameInMap("iconVO")
    public SpaceModelIconVO iconVO;

    // 知识库id。
    @NameInMap("id")
    public String id;

    // 知识库名称。
    @NameInMap("name")
    public String name;

    // 知识库所有者。
    @NameInMap("owner")
    public SpaceModelOwner owner;

    // 知识库中最近编辑的三篇文档。
    @NameInMap("recentList")
    public java.util.List<DentryModel> recentList;

    // 知识库类型。
    @NameInMap("type")
    public Integer type;

    // 知识库访问url。
    @NameInMap("url")
    public String url;

    // 访问者对当前知识库的权限等信息。
    @NameInMap("visitorInfo")
    public SpaceModelVisitorInfo visitorInfo;

    public static SpaceModel build(java.util.Map<String, ?> map) throws Exception {
        SpaceModel self = new SpaceModel();
        return TeaModel.build(map, self);
    }

    public SpaceModel setCover(String cover) {
        this.cover = cover;
        return this;
    }
    public String getCover() {
        return this.cover;
    }

    public SpaceModel setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public SpaceModel setIconVO(SpaceModelIconVO iconVO) {
        this.iconVO = iconVO;
        return this;
    }
    public SpaceModelIconVO getIconVO() {
        return this.iconVO;
    }

    public SpaceModel setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public SpaceModel setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public SpaceModel setOwner(SpaceModelOwner owner) {
        this.owner = owner;
        return this;
    }
    public SpaceModelOwner getOwner() {
        return this.owner;
    }

    public SpaceModel setRecentList(java.util.List<DentryModel> recentList) {
        this.recentList = recentList;
        return this;
    }
    public java.util.List<DentryModel> getRecentList() {
        return this.recentList;
    }

    public SpaceModel setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

    public SpaceModel setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public SpaceModel setVisitorInfo(SpaceModelVisitorInfo visitorInfo) {
        this.visitorInfo = visitorInfo;
        return this;
    }
    public SpaceModelVisitorInfo getVisitorInfo() {
        return this.visitorInfo;
    }

    public static class SpaceModelIconVO extends TeaModel {
        // 图标
        @NameInMap("icon")
        public String icon;

        // 图标类型
        @NameInMap("type")
        public String type;

        public static SpaceModelIconVO build(java.util.Map<String, ?> map) throws Exception {
            SpaceModelIconVO self = new SpaceModelIconVO();
            return TeaModel.build(map, self);
        }

        public SpaceModelIconVO setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public SpaceModelIconVO setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class SpaceModelOwner extends TeaModel {
        // 用户名称。
        @NameInMap("name")
        public String name;

        // 用户unionId。
        @NameInMap("unionId")
        public String unionId;

        public static SpaceModelOwner build(java.util.Map<String, ?> map) throws Exception {
            SpaceModelOwner self = new SpaceModelOwner();
            return TeaModel.build(map, self);
        }

        public SpaceModelOwner setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SpaceModelOwner setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class SpaceModelVisitorInfo extends TeaModel {
        // 节点的操作列表。
        @NameInMap("dentryActions")
        public java.util.List<String> dentryActions;

        // 权限
        @NameInMap("roleCode")
        public String roleCode;

        // 空间的操作列表。
        @NameInMap("spaceActions")
        public java.util.List<String> spaceActions;

        public static SpaceModelVisitorInfo build(java.util.Map<String, ?> map) throws Exception {
            SpaceModelVisitorInfo self = new SpaceModelVisitorInfo();
            return TeaModel.build(map, self);
        }

        public SpaceModelVisitorInfo setDentryActions(java.util.List<String> dentryActions) {
            this.dentryActions = dentryActions;
            return this;
        }
        public java.util.List<String> getDentryActions() {
            return this.dentryActions;
        }

        public SpaceModelVisitorInfo setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

        public SpaceModelVisitorInfo setSpaceActions(java.util.List<String> spaceActions) {
            this.spaceActions = spaceActions;
            return this;
        }
        public java.util.List<String> getSpaceActions() {
            return this.spaceActions;
        }

    }

}
