// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListContactRestrictSettingResponseBody extends TeaModel {
    // 是否还有数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 设置列表
    @NameInMap("list")
    public java.util.List<ListContactRestrictSettingResponseBodyList> list;

    // 下一次拉取数据时的token
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
        // 是否生效
        @NameInMap("active")
        public Boolean active;

        // 规则描述
        @NameInMap("description")
        public String description;

        // 白名单用户deptId列表
        @NameInMap("excludeDeptIds")
        public java.util.List<Long> excludeDeptIds;

        // 白名单用户tagId列表
        @NameInMap("excludeTagIds")
        public java.util.List<Long> excludeTagIds;

        // 白名单用户userId列表
        @NameInMap("excludeUserIds")
        public java.util.List<String> excludeUserIds;

        // 设置id
        @NameInMap("id")
        public Long id;

        // 规则名称
        @NameInMap("name")
        public String name;

        // 主体用户deptId列表
        @NameInMap("subjectDeptIds")
        public java.util.List<Long> subjectDeptIds;

        // 主体用户tagId列表
        @NameInMap("subjectTagIds")
        public java.util.List<Long> subjectTagIds;

        // 主体用户userId列表
        @NameInMap("subjectUserIds")
        public java.util.List<String> subjectUserIds;

        // 限制类型
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
