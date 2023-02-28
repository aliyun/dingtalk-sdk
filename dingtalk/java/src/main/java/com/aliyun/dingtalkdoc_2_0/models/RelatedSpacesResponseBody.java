// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class RelatedSpacesResponseBody extends TeaModel {
    /**
     * <p>是否还有更多数据。</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("items")
    public java.util.List<RelatedSpacesResponseBodyItems> items;

    /**
     * <p>分页游标。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    public static RelatedSpacesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RelatedSpacesResponseBody self = new RelatedSpacesResponseBody();
        return TeaModel.build(map, self);
    }

    public RelatedSpacesResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public RelatedSpacesResponseBody setItems(java.util.List<RelatedSpacesResponseBodyItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<RelatedSpacesResponseBodyItems> getItems() {
        return this.items;
    }

    public RelatedSpacesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class RelatedSpacesResponseBodyItemsHdIconVO extends TeaModel {
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

        public static RelatedSpacesResponseBodyItemsHdIconVO build(java.util.Map<String, ?> map) throws Exception {
            RelatedSpacesResponseBodyItemsHdIconVO self = new RelatedSpacesResponseBodyItemsHdIconVO();
            return TeaModel.build(map, self);
        }

        public RelatedSpacesResponseBodyItemsHdIconVO setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public RelatedSpacesResponseBodyItemsHdIconVO setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class RelatedSpacesResponseBodyItemsIconVO extends TeaModel {
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

        public static RelatedSpacesResponseBodyItemsIconVO build(java.util.Map<String, ?> map) throws Exception {
            RelatedSpacesResponseBodyItemsIconVO self = new RelatedSpacesResponseBodyItemsIconVO();
            return TeaModel.build(map, self);
        }

        public RelatedSpacesResponseBodyItemsIconVO setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public RelatedSpacesResponseBodyItemsIconVO setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class RelatedSpacesResponseBodyItemsOwner extends TeaModel {
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

        public static RelatedSpacesResponseBodyItemsOwner build(java.util.Map<String, ?> map) throws Exception {
            RelatedSpacesResponseBodyItemsOwner self = new RelatedSpacesResponseBodyItemsOwner();
            return TeaModel.build(map, self);
        }

        public RelatedSpacesResponseBodyItemsOwner setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public RelatedSpacesResponseBodyItemsOwner setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class RelatedSpacesResponseBodyItemsVisitorInfo extends TeaModel {
        /**
         * <p>节点的操作列表。</p>
         */
        @NameInMap("dentryActions")
        public java.util.List<String> dentryActions;

        /**
         * <p>是否置顶</p>
         */
        @NameInMap("pinned")
        public Boolean pinned;

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

        public static RelatedSpacesResponseBodyItemsVisitorInfo build(java.util.Map<String, ?> map) throws Exception {
            RelatedSpacesResponseBodyItemsVisitorInfo self = new RelatedSpacesResponseBodyItemsVisitorInfo();
            return TeaModel.build(map, self);
        }

        public RelatedSpacesResponseBodyItemsVisitorInfo setDentryActions(java.util.List<String> dentryActions) {
            this.dentryActions = dentryActions;
            return this;
        }
        public java.util.List<String> getDentryActions() {
            return this.dentryActions;
        }

        public RelatedSpacesResponseBodyItemsVisitorInfo setPinned(Boolean pinned) {
            this.pinned = pinned;
            return this;
        }
        public Boolean getPinned() {
            return this.pinned;
        }

        public RelatedSpacesResponseBodyItemsVisitorInfo setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

        public RelatedSpacesResponseBodyItemsVisitorInfo setSpaceActions(java.util.List<String> spaceActions) {
            this.spaceActions = spaceActions;
            return this;
        }
        public java.util.List<String> getSpaceActions() {
            return this.spaceActions;
        }

    }

    public static class RelatedSpacesResponseBodyItems extends TeaModel {
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
        public RelatedSpacesResponseBodyItemsHdIconVO hdIconVO;

        /**
         * <p>知识库图标</p>
         */
        @NameInMap("iconVO")
        public RelatedSpacesResponseBodyItemsIconVO iconVO;

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
        public RelatedSpacesResponseBodyItemsOwner owner;

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
        public RelatedSpacesResponseBodyItemsVisitorInfo visitorInfo;

        public static RelatedSpacesResponseBodyItems build(java.util.Map<String, ?> map) throws Exception {
            RelatedSpacesResponseBodyItems self = new RelatedSpacesResponseBodyItems();
            return TeaModel.build(map, self);
        }

        public RelatedSpacesResponseBodyItems setCover(String cover) {
            this.cover = cover;
            return this;
        }
        public String getCover() {
            return this.cover;
        }

        public RelatedSpacesResponseBodyItems setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public RelatedSpacesResponseBodyItems setHdIconVO(RelatedSpacesResponseBodyItemsHdIconVO hdIconVO) {
            this.hdIconVO = hdIconVO;
            return this;
        }
        public RelatedSpacesResponseBodyItemsHdIconVO getHdIconVO() {
            return this.hdIconVO;
        }

        public RelatedSpacesResponseBodyItems setIconVO(RelatedSpacesResponseBodyItemsIconVO iconVO) {
            this.iconVO = iconVO;
            return this;
        }
        public RelatedSpacesResponseBodyItemsIconVO getIconVO() {
            return this.iconVO;
        }

        public RelatedSpacesResponseBodyItems setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public RelatedSpacesResponseBodyItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public RelatedSpacesResponseBodyItems setOwner(RelatedSpacesResponseBodyItemsOwner owner) {
            this.owner = owner;
            return this;
        }
        public RelatedSpacesResponseBodyItemsOwner getOwner() {
            return this.owner;
        }

        public RelatedSpacesResponseBodyItems setRecentList(java.util.List<DentryModel> recentList) {
            this.recentList = recentList;
            return this;
        }
        public java.util.List<DentryModel> getRecentList() {
            return this.recentList;
        }

        public RelatedSpacesResponseBodyItems setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

        public RelatedSpacesResponseBodyItems setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public RelatedSpacesResponseBodyItems setVisitorInfo(RelatedSpacesResponseBodyItemsVisitorInfo visitorInfo) {
            this.visitorInfo = visitorInfo;
            return this;
        }
        public RelatedSpacesResponseBodyItemsVisitorInfo getVisitorInfo() {
            return this.visitorInfo;
        }

    }

}
