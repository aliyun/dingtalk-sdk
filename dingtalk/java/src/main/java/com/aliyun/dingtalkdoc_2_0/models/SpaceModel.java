// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SpaceModel extends TeaModel {
    /**
     * <p>封面</p>
     */
    @NameInMap("cover")
    public String cover;

    /**
     * <p>空间描述信息</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>知识库高清图标</p>
     */
    @NameInMap("hdIconVO")
    public SpaceModelHdIconVO hdIconVO;

    /**
     * <p>知识库图标</p>
     */
    @NameInMap("iconVO")
    public SpaceModelIconVO iconVO;

    /**
     * <p>知识库id。</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <p>知识库名称。</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>知识库所有者。</p>
     */
    @NameInMap("owner")
    public SpaceModelOwner owner;

    /**
     * <p>知识库中最近编辑的三篇文档。</p>
     */
    @NameInMap("recentList")
    public java.util.List<DentryModel> recentList;

    /**
     * <p>知识库类型。</p>
     */
    @NameInMap("type")
    public Integer type;

    /**
     * <p>知识库访问url。</p>
     */
    @NameInMap("url")
    public String url;

    /**
     * <p>访问者对当前知识库的权限等信息。</p>
     */
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

    public SpaceModel setHdIconVO(SpaceModelHdIconVO hdIconVO) {
        this.hdIconVO = hdIconVO;
        return this;
    }
    public SpaceModelHdIconVO getHdIconVO() {
        return this.hdIconVO;
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

    public static class SpaceModelHdIconVO extends TeaModel {
        /**
         * <p>图标</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>图标类型</p>
         */
        @NameInMap("type")
        public String type;

        public static SpaceModelHdIconVO build(java.util.Map<String, ?> map) throws Exception {
            SpaceModelHdIconVO self = new SpaceModelHdIconVO();
            return TeaModel.build(map, self);
        }

        public SpaceModelHdIconVO setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public SpaceModelHdIconVO setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class SpaceModelIconVO extends TeaModel {
        /**
         * <p>图标</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>图标类型</p>
         */
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
        /**
         * <p>用户名称。</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>用户unionId。</p>
         */
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
        /**
         * <p>节点的操作列表。</p>
         */
        @NameInMap("dentryActions")
        public java.util.List<String> dentryActions;

        /**
         * <p>权限</p>
         */
        @NameInMap("roleCode")
        public String roleCode;

        /**
         * <p>空间的操作列表。</p>
         */
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
