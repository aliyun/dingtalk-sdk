// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GroupQueryByAttrResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public GroupQueryByAttrResponseBodyData data;

    @NameInMap("message")
    public String message;

    public static GroupQueryByAttrResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GroupQueryByAttrResponseBody self = new GroupQueryByAttrResponseBody();
        return TeaModel.build(map, self);
    }

    public GroupQueryByAttrResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public GroupQueryByAttrResponseBody setData(GroupQueryByAttrResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GroupQueryByAttrResponseBodyData getData() {
        return this.data;
    }

    public GroupQueryByAttrResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GroupQueryByAttrResponseBodyDataList extends TeaModel {
        @NameInMap("groupMemberCount")
        public Integer groupMemberCount;

        @NameInMap("groupName")
        public String groupName;

        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("ownerJobNo")
        public String ownerJobNo;

        @NameInMap("ownerUserName")
        public String ownerUserName;

        public static GroupQueryByAttrResponseBodyDataList build(java.util.Map<String, ?> map) throws Exception {
            GroupQueryByAttrResponseBodyDataList self = new GroupQueryByAttrResponseBodyDataList();
            return TeaModel.build(map, self);
        }

        public GroupQueryByAttrResponseBodyDataList setGroupMemberCount(Integer groupMemberCount) {
            this.groupMemberCount = groupMemberCount;
            return this;
        }
        public Integer getGroupMemberCount() {
            return this.groupMemberCount;
        }

        public GroupQueryByAttrResponseBodyDataList setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public GroupQueryByAttrResponseBodyDataList setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public GroupQueryByAttrResponseBodyDataList setOwnerJobNo(String ownerJobNo) {
            this.ownerJobNo = ownerJobNo;
            return this;
        }
        public String getOwnerJobNo() {
            return this.ownerJobNo;
        }

        public GroupQueryByAttrResponseBodyDataList setOwnerUserName(String ownerUserName) {
            this.ownerUserName = ownerUserName;
            return this;
        }
        public String getOwnerUserName() {
            return this.ownerUserName;
        }

    }

    public static class GroupQueryByAttrResponseBodyData extends TeaModel {
        @NameInMap("counts")
        public Long counts;

        @NameInMap("list")
        public java.util.List<GroupQueryByAttrResponseBodyDataList> list;

        @NameInMap("pageIndex")
        public Long pageIndex;

        @NameInMap("pageSize")
        public Long pageSize;

        public static GroupQueryByAttrResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GroupQueryByAttrResponseBodyData self = new GroupQueryByAttrResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GroupQueryByAttrResponseBodyData setCounts(Long counts) {
            this.counts = counts;
            return this;
        }
        public Long getCounts() {
            return this.counts;
        }

        public GroupQueryByAttrResponseBodyData setList(java.util.List<GroupQueryByAttrResponseBodyDataList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<GroupQueryByAttrResponseBodyDataList> getList() {
            return this.list;
        }

        public GroupQueryByAttrResponseBodyData setPageIndex(Long pageIndex) {
            this.pageIndex = pageIndex;
            return this;
        }
        public Long getPageIndex() {
            return this.pageIndex;
        }

        public GroupQueryByAttrResponseBodyData setPageSize(Long pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Long getPageSize() {
            return this.pageSize;
        }

    }

}
