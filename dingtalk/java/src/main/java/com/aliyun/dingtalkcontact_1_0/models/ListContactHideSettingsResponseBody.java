// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListContactHideSettingsResponseBody extends TeaModel {
    // 是否还有数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 设置列表
    @NameInMap("list")
    public java.util.List<ListContactHideSettingsResponseBodyList> list;

    // 下一次拉取数据时的offset
    @NameInMap("nextToken")
    public Long nextToken;

    public static ListContactHideSettingsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListContactHideSettingsResponseBody self = new ListContactHideSettingsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListContactHideSettingsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListContactHideSettingsResponseBody setList(java.util.List<ListContactHideSettingsResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListContactHideSettingsResponseBodyList> getList() {
        return this.list;
    }

    public ListContactHideSettingsResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class ListContactHideSettingsResponseBodyList extends TeaModel {
        // 规则是否生效
        @NameInMap("active")
        public Boolean active;

        // 设置描述
        @NameInMap("description")
        public String description;

        // 白名单部门列表
        @NameInMap("excludeDeptIds")
        public java.util.List<Long> excludeDeptIds;

        // 白名单用户列表
        @NameInMap("excludeStaffIds")
        public java.util.List<String> excludeStaffIds;

        // 白名单角色列表
        @NameInMap("excludeTagIds")
        public java.util.List<Long> excludeTagIds;

        // settingId
        @NameInMap("id")
        public Long id;

        // 设置名称
        @NameInMap("name")
        public String name;

        // 要隐藏的部门列表
        @NameInMap("objectDeptIds")
        public java.util.List<Long> objectDeptIds;

        // 要隐藏的员工列表
        @NameInMap("objectStaffIds")
        public java.util.List<String> objectStaffIds;

        // 要影藏的角色列表
        @NameInMap("objectTagIds")
        public java.util.List<Long> objectTagIds;

        public static ListContactHideSettingsResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListContactHideSettingsResponseBodyList self = new ListContactHideSettingsResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListContactHideSettingsResponseBodyList setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public ListContactHideSettingsResponseBodyList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListContactHideSettingsResponseBodyList setExcludeDeptIds(java.util.List<Long> excludeDeptIds) {
            this.excludeDeptIds = excludeDeptIds;
            return this;
        }
        public java.util.List<Long> getExcludeDeptIds() {
            return this.excludeDeptIds;
        }

        public ListContactHideSettingsResponseBodyList setExcludeStaffIds(java.util.List<String> excludeStaffIds) {
            this.excludeStaffIds = excludeStaffIds;
            return this;
        }
        public java.util.List<String> getExcludeStaffIds() {
            return this.excludeStaffIds;
        }

        public ListContactHideSettingsResponseBodyList setExcludeTagIds(java.util.List<Long> excludeTagIds) {
            this.excludeTagIds = excludeTagIds;
            return this;
        }
        public java.util.List<Long> getExcludeTagIds() {
            return this.excludeTagIds;
        }

        public ListContactHideSettingsResponseBodyList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public ListContactHideSettingsResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListContactHideSettingsResponseBodyList setObjectDeptIds(java.util.List<Long> objectDeptIds) {
            this.objectDeptIds = objectDeptIds;
            return this;
        }
        public java.util.List<Long> getObjectDeptIds() {
            return this.objectDeptIds;
        }

        public ListContactHideSettingsResponseBodyList setObjectStaffIds(java.util.List<String> objectStaffIds) {
            this.objectStaffIds = objectStaffIds;
            return this;
        }
        public java.util.List<String> getObjectStaffIds() {
            return this.objectStaffIds;
        }

        public ListContactHideSettingsResponseBodyList setObjectTagIds(java.util.List<Long> objectTagIds) {
            this.objectTagIds = objectTagIds;
            return this;
        }
        public java.util.List<Long> getObjectTagIds() {
            return this.objectTagIds;
        }

    }

}
