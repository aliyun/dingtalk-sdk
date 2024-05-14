// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class RelatedSpacesResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("items")
    public java.util.List<RelatedSpacesResponseBodyItems> items;

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
         * <p>This parameter is required.</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>This parameter is required.</p>
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
         * <p>This parameter is required.</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>This parameter is required.</p>
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
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
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
        @NameInMap("dentryActions")
        public java.util.List<String> dentryActions;

        @NameInMap("pinned")
        public Boolean pinned;

        @NameInMap("roleCode")
        public String roleCode;

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
        @NameInMap("cover")
        public String cover;

        @NameInMap("description")
        public String description;

        @NameInMap("hdIconVO")
        public RelatedSpacesResponseBodyItemsHdIconVO hdIconVO;

        @NameInMap("iconVO")
        public RelatedSpacesResponseBodyItemsIconVO iconVO;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("owner")
        public RelatedSpacesResponseBodyItemsOwner owner;

        @NameInMap("recentList")
        public java.util.List<DentryModel> recentList;

        @NameInMap("type")
        public Integer type;

        @NameInMap("url")
        public String url;

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
