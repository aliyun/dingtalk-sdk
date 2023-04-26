// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListStarsResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("starList")
    public java.util.List<ListStarsResponseBodyStarList> starList;

    public static ListStarsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListStarsResponseBody self = new ListStarsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListStarsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListStarsResponseBody setStarList(java.util.List<ListStarsResponseBodyStarList> starList) {
        this.starList = starList;
        return this;
    }
    public java.util.List<ListStarsResponseBodyStarList> getStarList() {
        return this.starList;
    }

    public static class ListStarsResponseBodyStarListDentryInfoCreator extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static ListStarsResponseBodyStarListDentryInfoCreator build(java.util.Map<String, ?> map) throws Exception {
            ListStarsResponseBodyStarListDentryInfoCreator self = new ListStarsResponseBodyStarListDentryInfoCreator();
            return TeaModel.build(map, self);
        }

        public ListStarsResponseBodyStarListDentryInfoCreator setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListStarsResponseBodyStarListDentryInfoCreator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ListStarsResponseBodyStarListDentryInfoModifier extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static ListStarsResponseBodyStarListDentryInfoModifier build(java.util.Map<String, ?> map) throws Exception {
            ListStarsResponseBodyStarListDentryInfoModifier self = new ListStarsResponseBodyStarListDentryInfoModifier();
            return TeaModel.build(map, self);
        }

        public ListStarsResponseBodyStarListDentryInfoModifier setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListStarsResponseBodyStarListDentryInfoModifier setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ListStarsResponseBodyStarListDentryInfo extends TeaModel {
        @NameInMap("createTime")
        public String createTime;

        @NameInMap("creator")
        public ListStarsResponseBodyStarListDentryInfoCreator creator;

        @NameInMap("extension")
        public String extension;

        @NameInMap("id")
        public String id;

        @NameInMap("mobileUrl")
        public String mobileUrl;

        @NameInMap("modifiedTime")
        public String modifiedTime;

        @NameInMap("modifier")
        public ListStarsResponseBodyStarListDentryInfoModifier modifier;

        @NameInMap("name")
        public String name;

        @NameInMap("pcUrl")
        public String pcUrl;

        @NameInMap("spaceId")
        public String spaceId;

        @NameInMap("status")
        public String status;

        @NameInMap("type")
        public String type;

        @NameInMap("uuid")
        public String uuid;

        public static ListStarsResponseBodyStarListDentryInfo build(java.util.Map<String, ?> map) throws Exception {
            ListStarsResponseBodyStarListDentryInfo self = new ListStarsResponseBodyStarListDentryInfo();
            return TeaModel.build(map, self);
        }

        public ListStarsResponseBodyStarListDentryInfo setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListStarsResponseBodyStarListDentryInfo setCreator(ListStarsResponseBodyStarListDentryInfoCreator creator) {
            this.creator = creator;
            return this;
        }
        public ListStarsResponseBodyStarListDentryInfoCreator getCreator() {
            return this.creator;
        }

        public ListStarsResponseBodyStarListDentryInfo setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public ListStarsResponseBodyStarListDentryInfo setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListStarsResponseBodyStarListDentryInfo setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public ListStarsResponseBodyStarListDentryInfo setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public ListStarsResponseBodyStarListDentryInfo setModifier(ListStarsResponseBodyStarListDentryInfoModifier modifier) {
            this.modifier = modifier;
            return this;
        }
        public ListStarsResponseBodyStarListDentryInfoModifier getModifier() {
            return this.modifier;
        }

        public ListStarsResponseBodyStarListDentryInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListStarsResponseBodyStarListDentryInfo setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public ListStarsResponseBodyStarListDentryInfo setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public ListStarsResponseBodyStarListDentryInfo setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public ListStarsResponseBodyStarListDentryInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public ListStarsResponseBodyStarListDentryInfo setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

    }

    public static class ListStarsResponseBodyStarListSpaceInfo extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        public static ListStarsResponseBodyStarListSpaceInfo build(java.util.Map<String, ?> map) throws Exception {
            ListStarsResponseBodyStarListSpaceInfo self = new ListStarsResponseBodyStarListSpaceInfo();
            return TeaModel.build(map, self);
        }

        public ListStarsResponseBodyStarListSpaceInfo setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListStarsResponseBodyStarListSpaceInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class ListStarsResponseBodyStarListTeamInfo extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        public static ListStarsResponseBodyStarListTeamInfo build(java.util.Map<String, ?> map) throws Exception {
            ListStarsResponseBodyStarListTeamInfo self = new ListStarsResponseBodyStarListTeamInfo();
            return TeaModel.build(map, self);
        }

        public ListStarsResponseBodyStarListTeamInfo setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListStarsResponseBodyStarListTeamInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class ListStarsResponseBodyStarList extends TeaModel {
        @NameInMap("createTime")
        public String createTime;

        @NameInMap("dentryInfo")
        public ListStarsResponseBodyStarListDentryInfo dentryInfo;

        @NameInMap("dentryPermissionRole")
        public String dentryPermissionRole;

        @NameInMap("id")
        public String id;

        @NameInMap("isDeleted")
        public Boolean isDeleted;

        @NameInMap("modifiedTime")
        public String modifiedTime;

        @NameInMap("spaceInfo")
        public ListStarsResponseBodyStarListSpaceInfo spaceInfo;

        @NameInMap("spacePermissionRole")
        public String spacePermissionRole;

        @NameInMap("starType")
        public String starType;

        @NameInMap("teamInfo")
        public ListStarsResponseBodyStarListTeamInfo teamInfo;

        public static ListStarsResponseBodyStarList build(java.util.Map<String, ?> map) throws Exception {
            ListStarsResponseBodyStarList self = new ListStarsResponseBodyStarList();
            return TeaModel.build(map, self);
        }

        public ListStarsResponseBodyStarList setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListStarsResponseBodyStarList setDentryInfo(ListStarsResponseBodyStarListDentryInfo dentryInfo) {
            this.dentryInfo = dentryInfo;
            return this;
        }
        public ListStarsResponseBodyStarListDentryInfo getDentryInfo() {
            return this.dentryInfo;
        }

        public ListStarsResponseBodyStarList setDentryPermissionRole(String dentryPermissionRole) {
            this.dentryPermissionRole = dentryPermissionRole;
            return this;
        }
        public String getDentryPermissionRole() {
            return this.dentryPermissionRole;
        }

        public ListStarsResponseBodyStarList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListStarsResponseBodyStarList setIsDeleted(Boolean isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Boolean getIsDeleted() {
            return this.isDeleted;
        }

        public ListStarsResponseBodyStarList setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public ListStarsResponseBodyStarList setSpaceInfo(ListStarsResponseBodyStarListSpaceInfo spaceInfo) {
            this.spaceInfo = spaceInfo;
            return this;
        }
        public ListStarsResponseBodyStarListSpaceInfo getSpaceInfo() {
            return this.spaceInfo;
        }

        public ListStarsResponseBodyStarList setSpacePermissionRole(String spacePermissionRole) {
            this.spacePermissionRole = spacePermissionRole;
            return this;
        }
        public String getSpacePermissionRole() {
            return this.spacePermissionRole;
        }

        public ListStarsResponseBodyStarList setStarType(String starType) {
            this.starType = starType;
            return this;
        }
        public String getStarType() {
            return this.starType;
        }

        public ListStarsResponseBodyStarList setTeamInfo(ListStarsResponseBodyStarListTeamInfo teamInfo) {
            this.teamInfo = teamInfo;
            return this;
        }
        public ListStarsResponseBodyStarListTeamInfo getTeamInfo() {
            return this.teamInfo;
        }

    }

}
