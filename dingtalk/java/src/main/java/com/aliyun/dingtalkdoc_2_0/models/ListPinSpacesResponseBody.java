// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListPinSpacesResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("resultItems")
    public java.util.List<ListPinSpacesResponseBodyResultItems> resultItems;

    public static ListPinSpacesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListPinSpacesResponseBody self = new ListPinSpacesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListPinSpacesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListPinSpacesResponseBody setResultItems(java.util.List<ListPinSpacesResponseBodyResultItems> resultItems) {
        this.resultItems = resultItems;
        return this;
    }
    public java.util.List<ListPinSpacesResponseBodyResultItems> getResultItems() {
        return this.resultItems;
    }

    public static class ListPinSpacesResponseBodyResultItemsSpaceInfoCreator extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static ListPinSpacesResponseBodyResultItemsSpaceInfoCreator build(java.util.Map<String, ?> map) throws Exception {
            ListPinSpacesResponseBodyResultItemsSpaceInfoCreator self = new ListPinSpacesResponseBodyResultItemsSpaceInfoCreator();
            return TeaModel.build(map, self);
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfoCreator setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfoCreator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO extends TeaModel {
        @NameInMap("icon")
        public String icon;

        @NameInMap("type")
        public String type;

        public static ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO build(java.util.Map<String, ?> map) throws Exception {
            ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO self = new ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO();
            return TeaModel.build(map, self);
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class ListPinSpacesResponseBodyResultItemsSpaceInfoModifier extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static ListPinSpacesResponseBodyResultItemsSpaceInfoModifier build(java.util.Map<String, ?> map) throws Exception {
            ListPinSpacesResponseBodyResultItemsSpaceInfoModifier self = new ListPinSpacesResponseBodyResultItemsSpaceInfoModifier();
            return TeaModel.build(map, self);
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfoModifier setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfoModifier setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ListPinSpacesResponseBodyResultItemsSpaceInfo extends TeaModel {
        @NameInMap("cover")
        public String cover;

        @NameInMap("createTime")
        public String createTime;

        @NameInMap("creator")
        public ListPinSpacesResponseBodyResultItemsSpaceInfoCreator creator;

        @NameInMap("description")
        public String description;

        @NameInMap("iconVO")
        public ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO iconVO;

        @NameInMap("id")
        public String id;

        @NameInMap("mobileUrl")
        public String mobileUrl;

        @NameInMap("modifiedTime")
        public String modifiedTime;

        @NameInMap("modifier")
        public ListPinSpacesResponseBodyResultItemsSpaceInfoModifier modifier;

        @NameInMap("name")
        public String name;

        @NameInMap("pcUrl")
        public String pcUrl;

        public static ListPinSpacesResponseBodyResultItemsSpaceInfo build(java.util.Map<String, ?> map) throws Exception {
            ListPinSpacesResponseBodyResultItemsSpaceInfo self = new ListPinSpacesResponseBodyResultItemsSpaceInfo();
            return TeaModel.build(map, self);
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfo setCover(String cover) {
            this.cover = cover;
            return this;
        }
        public String getCover() {
            return this.cover;
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfo setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfo setCreator(ListPinSpacesResponseBodyResultItemsSpaceInfoCreator creator) {
            this.creator = creator;
            return this;
        }
        public ListPinSpacesResponseBodyResultItemsSpaceInfoCreator getCreator() {
            return this.creator;
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfo setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfo setIconVO(ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO iconVO) {
            this.iconVO = iconVO;
            return this;
        }
        public ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO getIconVO() {
            return this.iconVO;
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfo setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfo setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfo setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfo setModifier(ListPinSpacesResponseBodyResultItemsSpaceInfoModifier modifier) {
            this.modifier = modifier;
            return this;
        }
        public ListPinSpacesResponseBodyResultItemsSpaceInfoModifier getModifier() {
            return this.modifier;
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListPinSpacesResponseBodyResultItemsSpaceInfo setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

    }

    public static class ListPinSpacesResponseBodyResultItemsTeamInfo extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        public static ListPinSpacesResponseBodyResultItemsTeamInfo build(java.util.Map<String, ?> map) throws Exception {
            ListPinSpacesResponseBodyResultItemsTeamInfo self = new ListPinSpacesResponseBodyResultItemsTeamInfo();
            return TeaModel.build(map, self);
        }

        public ListPinSpacesResponseBodyResultItemsTeamInfo setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListPinSpacesResponseBodyResultItemsTeamInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class ListPinSpacesResponseBodyResultItems extends TeaModel {
        @NameInMap("createTime")
        public String createTime;

        @NameInMap("modifiedTime")
        public String modifiedTime;

        @NameInMap("spaceInfo")
        public ListPinSpacesResponseBodyResultItemsSpaceInfo spaceInfo;

        @NameInMap("spacePermissionRole")
        public String spacePermissionRole;

        @NameInMap("teamInfo")
        public ListPinSpacesResponseBodyResultItemsTeamInfo teamInfo;

        public static ListPinSpacesResponseBodyResultItems build(java.util.Map<String, ?> map) throws Exception {
            ListPinSpacesResponseBodyResultItems self = new ListPinSpacesResponseBodyResultItems();
            return TeaModel.build(map, self);
        }

        public ListPinSpacesResponseBodyResultItems setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListPinSpacesResponseBodyResultItems setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public ListPinSpacesResponseBodyResultItems setSpaceInfo(ListPinSpacesResponseBodyResultItemsSpaceInfo spaceInfo) {
            this.spaceInfo = spaceInfo;
            return this;
        }
        public ListPinSpacesResponseBodyResultItemsSpaceInfo getSpaceInfo() {
            return this.spaceInfo;
        }

        public ListPinSpacesResponseBodyResultItems setSpacePermissionRole(String spacePermissionRole) {
            this.spacePermissionRole = spacePermissionRole;
            return this;
        }
        public String getSpacePermissionRole() {
            return this.spacePermissionRole;
        }

        public ListPinSpacesResponseBodyResultItems setTeamInfo(ListPinSpacesResponseBodyResultItemsTeamInfo teamInfo) {
            this.teamInfo = teamInfo;
            return this;
        }
        public ListPinSpacesResponseBodyResultItemsTeamInfo getTeamInfo() {
            return this.teamInfo;
        }

    }

}
