// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListContactRestrictSettingResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<ListContactRestrictSettingResponseBodyList> list;

    @NameInMap("nextToken")
    public Long nextToken;

    public static ListContactRestrictSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListContactRestrictSettingResponseBody self = new ListContactRestrictSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public ListContactRestrictSettingResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListContactRestrictSettingResponseBody setList(java.util.List<ListContactRestrictSettingResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListContactRestrictSettingResponseBodyList> getList() {
        return this.list;
    }

    public ListContactRestrictSettingResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class ListContactRestrictSettingResponseBodyList extends TeaModel {
        @NameInMap("active")
        public Boolean active;

        @NameInMap("description")
        public String description;

        @NameInMap("excludeDeptIds")
        public java.util.List<Long> excludeDeptIds;

        @NameInMap("excludeTagIds")
        public java.util.List<Long> excludeTagIds;

        @NameInMap("excludeUserIds")
        public java.util.List<String> excludeUserIds;

        @NameInMap("id")
        public Long id;

        @NameInMap("name")
        public String name;

        @NameInMap("restrictInSearch")
        public Boolean restrictInSearch;

        @NameInMap("restrictInUserProfile")
        public Boolean restrictInUserProfile;

        @NameInMap("subjectDeptIds")
        public java.util.List<Long> subjectDeptIds;

        @NameInMap("subjectTagIds")
        public java.util.List<Long> subjectTagIds;

        @NameInMap("subjectUserIds")
        public java.util.List<String> subjectUserIds;

        @NameInMap("type")
        public String type;

        public static ListContactRestrictSettingResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListContactRestrictSettingResponseBodyList self = new ListContactRestrictSettingResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListContactRestrictSettingResponseBodyList setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public ListContactRestrictSettingResponseBodyList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListContactRestrictSettingResponseBodyList setExcludeDeptIds(java.util.List<Long> excludeDeptIds) {
            this.excludeDeptIds = excludeDeptIds;
            return this;
        }
        public java.util.List<Long> getExcludeDeptIds() {
            return this.excludeDeptIds;
        }

        public ListContactRestrictSettingResponseBodyList setExcludeTagIds(java.util.List<Long> excludeTagIds) {
            this.excludeTagIds = excludeTagIds;
            return this;
        }
        public java.util.List<Long> getExcludeTagIds() {
            return this.excludeTagIds;
        }

        public ListContactRestrictSettingResponseBodyList setExcludeUserIds(java.util.List<String> excludeUserIds) {
            this.excludeUserIds = excludeUserIds;
            return this;
        }
        public java.util.List<String> getExcludeUserIds() {
            return this.excludeUserIds;
        }

        public ListContactRestrictSettingResponseBodyList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public ListContactRestrictSettingResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListContactRestrictSettingResponseBodyList setRestrictInSearch(Boolean restrictInSearch) {
            this.restrictInSearch = restrictInSearch;
            return this;
        }
        public Boolean getRestrictInSearch() {
            return this.restrictInSearch;
        }

        public ListContactRestrictSettingResponseBodyList setRestrictInUserProfile(Boolean restrictInUserProfile) {
            this.restrictInUserProfile = restrictInUserProfile;
            return this;
        }
        public Boolean getRestrictInUserProfile() {
            return this.restrictInUserProfile;
        }

        public ListContactRestrictSettingResponseBodyList setSubjectDeptIds(java.util.List<Long> subjectDeptIds) {
            this.subjectDeptIds = subjectDeptIds;
            return this;
        }
        public java.util.List<Long> getSubjectDeptIds() {
            return this.subjectDeptIds;
        }

        public ListContactRestrictSettingResponseBodyList setSubjectTagIds(java.util.List<Long> subjectTagIds) {
            this.subjectTagIds = subjectTagIds;
            return this;
        }
        public java.util.List<Long> getSubjectTagIds() {
            return this.subjectTagIds;
        }

        public ListContactRestrictSettingResponseBodyList setSubjectUserIds(java.util.List<String> subjectUserIds) {
            this.subjectUserIds = subjectUserIds;
            return this;
        }
        public java.util.List<String> getSubjectUserIds() {
            return this.subjectUserIds;
        }

        public ListContactRestrictSettingResponseBodyList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
