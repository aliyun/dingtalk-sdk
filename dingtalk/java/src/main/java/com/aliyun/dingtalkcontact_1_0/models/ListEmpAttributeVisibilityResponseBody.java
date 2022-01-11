// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListEmpAttributeVisibilityResponseBody extends TeaModel {
    // 是否还有数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 设置列表
    @NameInMap("list")
    public java.util.List<ListEmpAttributeVisibilityResponseBodyList> list;

    // 下一次拉取时的offset
    @NameInMap("nextCursor")
    public Long nextCursor;

    public static ListEmpAttributeVisibilityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListEmpAttributeVisibilityResponseBody self = new ListEmpAttributeVisibilityResponseBody();
        return TeaModel.build(map, self);
    }

    public ListEmpAttributeVisibilityResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListEmpAttributeVisibilityResponseBody setList(java.util.List<ListEmpAttributeVisibilityResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListEmpAttributeVisibilityResponseBodyList> getList() {
        return this.list;
    }

    public ListEmpAttributeVisibilityResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public static class ListEmpAttributeVisibilityResponseBodyList extends TeaModel {
        // 是否生效
        @NameInMap("active")
        public Boolean active;

        // 设置描述
        @NameInMap("description")
        public String description;

        // 白名单部门id列表
        @NameInMap("excludeDeptIds")
        public java.util.List<Long> excludeDeptIds;

        // 白名单用户id列表
        @NameInMap("excludeStaffIds")
        public java.util.List<String> excludeStaffIds;

        // 白名单角色id列表
        @NameInMap("excludeTagIds")
        public java.util.List<Long> excludeTagIds;

        // 设置时间
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 修改时间
        @NameInMap("gmtModified")
        public String gmtModified;

        // 隐藏的字段id列表
        @NameInMap("hideFields")
        public java.util.List<String> hideFields;

        // id
        @NameInMap("id")
        public Long id;

        // 名称
        @NameInMap("name")
        public String name;

        // 被查看的部门id列表
        @NameInMap("objectDeptIds")
        public java.util.List<Long> objectDeptIds;

        // 被查看的用户id列表
        @NameInMap("objectStaffIds")
        public java.util.List<String> objectStaffIds;

        // 被查看的角色id列表
        @NameInMap("objectTagIds")
        public java.util.List<Long> objectTagIds;

        public static ListEmpAttributeVisibilityResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListEmpAttributeVisibilityResponseBodyList self = new ListEmpAttributeVisibilityResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListEmpAttributeVisibilityResponseBodyList setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public ListEmpAttributeVisibilityResponseBodyList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListEmpAttributeVisibilityResponseBodyList setExcludeDeptIds(java.util.List<Long> excludeDeptIds) {
            this.excludeDeptIds = excludeDeptIds;
            return this;
        }
        public java.util.List<Long> getExcludeDeptIds() {
            return this.excludeDeptIds;
        }

        public ListEmpAttributeVisibilityResponseBodyList setExcludeStaffIds(java.util.List<String> excludeStaffIds) {
            this.excludeStaffIds = excludeStaffIds;
            return this;
        }
        public java.util.List<String> getExcludeStaffIds() {
            return this.excludeStaffIds;
        }

        public ListEmpAttributeVisibilityResponseBodyList setExcludeTagIds(java.util.List<Long> excludeTagIds) {
            this.excludeTagIds = excludeTagIds;
            return this;
        }
        public java.util.List<Long> getExcludeTagIds() {
            return this.excludeTagIds;
        }

        public ListEmpAttributeVisibilityResponseBodyList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public ListEmpAttributeVisibilityResponseBodyList setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public ListEmpAttributeVisibilityResponseBodyList setHideFields(java.util.List<String> hideFields) {
            this.hideFields = hideFields;
            return this;
        }
        public java.util.List<String> getHideFields() {
            return this.hideFields;
        }

        public ListEmpAttributeVisibilityResponseBodyList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public ListEmpAttributeVisibilityResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListEmpAttributeVisibilityResponseBodyList setObjectDeptIds(java.util.List<Long> objectDeptIds) {
            this.objectDeptIds = objectDeptIds;
            return this;
        }
        public java.util.List<Long> getObjectDeptIds() {
            return this.objectDeptIds;
        }

        public ListEmpAttributeVisibilityResponseBodyList setObjectStaffIds(java.util.List<String> objectStaffIds) {
            this.objectStaffIds = objectStaffIds;
            return this;
        }
        public java.util.List<String> getObjectStaffIds() {
            return this.objectStaffIds;
        }

        public ListEmpAttributeVisibilityResponseBodyList setObjectTagIds(java.util.List<Long> objectTagIds) {
            this.objectTagIds = objectTagIds;
            return this;
        }
        public java.util.List<Long> getObjectTagIds() {
            return this.objectTagIds;
        }

    }

}
