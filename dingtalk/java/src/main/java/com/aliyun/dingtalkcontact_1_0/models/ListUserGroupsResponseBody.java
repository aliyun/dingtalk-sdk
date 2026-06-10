// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListUserGroupsResponseBody extends TeaModel {
    @NameInMap("result")
    public ListUserGroupsResponseBodyResult result;

    public static ListUserGroupsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListUserGroupsResponseBody self = new ListUserGroupsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListUserGroupsResponseBody setResult(ListUserGroupsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ListUserGroupsResponseBodyResult getResult() {
        return this.result;
    }

    public static class ListUserGroupsResponseBodyResultGroups extends TeaModel {
        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("groupCode")
        public String groupCode;

        @NameInMap("groupType")
        public String groupType;

        @NameInMap("name")
        public String name;

        @NameInMap("status")
        public String status;

        public static ListUserGroupsResponseBodyResultGroups build(java.util.Map<String, ?> map) throws Exception {
            ListUserGroupsResponseBodyResultGroups self = new ListUserGroupsResponseBodyResultGroups();
            return TeaModel.build(map, self);
        }

        public ListUserGroupsResponseBodyResultGroups setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public ListUserGroupsResponseBodyResultGroups setGroupCode(String groupCode) {
            this.groupCode = groupCode;
            return this;
        }
        public String getGroupCode() {
            return this.groupCode;
        }

        public ListUserGroupsResponseBodyResultGroups setGroupType(String groupType) {
            this.groupType = groupType;
            return this;
        }
        public String getGroupType() {
            return this.groupType;
        }

        public ListUserGroupsResponseBodyResultGroups setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListUserGroupsResponseBodyResultGroups setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

    public static class ListUserGroupsResponseBodyResult extends TeaModel {
        @NameInMap("groups")
        public java.util.List<ListUserGroupsResponseBodyResultGroups> groups;

        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("nextOffset")
        public Long nextOffset;

        public static ListUserGroupsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListUserGroupsResponseBodyResult self = new ListUserGroupsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListUserGroupsResponseBodyResult setGroups(java.util.List<ListUserGroupsResponseBodyResultGroups> groups) {
            this.groups = groups;
            return this;
        }
        public java.util.List<ListUserGroupsResponseBodyResultGroups> getGroups() {
            return this.groups;
        }

        public ListUserGroupsResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public ListUserGroupsResponseBodyResult setNextOffset(Long nextOffset) {
            this.nextOffset = nextOffset;
            return this;
        }
        public Long getNextOffset() {
            return this.nextOffset;
        }

    }

}
