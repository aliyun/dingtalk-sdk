// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomListResponseBody extends TeaModel {
    // 是否有更多
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 下次查询分页标记
    @NameInMap("nextToken")
    public Long nextToken;

    // 会议室列表
    @NameInMap("result")
    public java.util.List<QueryMeetingRoomListResponseBodyResult> result;

    public static QueryMeetingRoomListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomListResponseBody self = new QueryMeetingRoomListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomListResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryMeetingRoomListResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryMeetingRoomListResponseBody setResult(java.util.List<QueryMeetingRoomListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryMeetingRoomListResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryMeetingRoomListResponseBodyResultRoomGroup extends TeaModel {
        // 分组id
        @NameInMap("groupId")
        public Long groupId;

        // 分组名称
        @NameInMap("groupName")
        public String groupName;

        // 父分组id
        @NameInMap("parentId")
        public Long parentId;

        public static QueryMeetingRoomListResponseBodyResultRoomGroup build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomListResponseBodyResultRoomGroup self = new QueryMeetingRoomListResponseBodyResultRoomGroup();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomListResponseBodyResultRoomGroup setGroupId(Long groupId) {
            this.groupId = groupId;
            return this;
        }
        public Long getGroupId() {
            return this.groupId;
        }

        public QueryMeetingRoomListResponseBodyResultRoomGroup setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public QueryMeetingRoomListResponseBodyResultRoomGroup setParentId(Long parentId) {
            this.parentId = parentId;
            return this;
        }
        public Long getParentId() {
            return this.parentId;
        }

    }

    public static class QueryMeetingRoomListResponseBodyResultRoomLabels extends TeaModel {
        @NameInMap("labelId")
        public Long labelId;

        @NameInMap("labelName")
        public String labelName;

        public static QueryMeetingRoomListResponseBodyResultRoomLabels build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomListResponseBodyResultRoomLabels self = new QueryMeetingRoomListResponseBodyResultRoomLabels();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomListResponseBodyResultRoomLabels setLabelId(Long labelId) {
            this.labelId = labelId;
            return this;
        }
        public Long getLabelId() {
            return this.labelId;
        }

        public QueryMeetingRoomListResponseBodyResultRoomLabels setLabelName(String labelName) {
            this.labelName = labelName;
            return this;
        }
        public String getLabelName() {
            return this.labelName;
        }

    }

    public static class QueryMeetingRoomListResponseBodyResultRoomLocation extends TeaModel {
        // 位置详细信息
        @NameInMap("desc")
        public String desc;

        // 位置名称
        @NameInMap("title")
        public String title;

        public static QueryMeetingRoomListResponseBodyResultRoomLocation build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomListResponseBodyResultRoomLocation self = new QueryMeetingRoomListResponseBodyResultRoomLocation();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomListResponseBodyResultRoomLocation setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public QueryMeetingRoomListResponseBodyResultRoomLocation setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryMeetingRoomListResponseBodyResult extends TeaModel {
        // 企业corpId
        @NameInMap("corpId")
        public String corpId;

        // isv外部会议室id
        @NameInMap("isvRoomId")
        public String isvRoomId;

        // 会议室容量
        @NameInMap("roomCapacity")
        public Integer roomCapacity;

        // 会议室分组
        @NameInMap("roomGroup")
        public QueryMeetingRoomListResponseBodyResultRoomGroup roomGroup;

        // 会议室id
        @NameInMap("roomId")
        public String roomId;

        @NameInMap("roomLabels")
        public java.util.List<QueryMeetingRoomListResponseBodyResultRoomLabels> roomLabels;

        // 会议室位置
        @NameInMap("roomLocation")
        public QueryMeetingRoomListResponseBodyResultRoomLocation roomLocation;

        // 会议室名称
        @NameInMap("roomName")
        public String roomName;

        // 会议室图片
        @NameInMap("roomPicture")
        public String roomPicture;

        // 会议室staffId
        @NameInMap("roomStaffId")
        public String roomStaffId;

        // 会议室状态
        @NameInMap("roomStatus")
        public Integer roomStatus;

        public static QueryMeetingRoomListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomListResponseBodyResult self = new QueryMeetingRoomListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomListResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryMeetingRoomListResponseBodyResult setIsvRoomId(String isvRoomId) {
            this.isvRoomId = isvRoomId;
            return this;
        }
        public String getIsvRoomId() {
            return this.isvRoomId;
        }

        public QueryMeetingRoomListResponseBodyResult setRoomCapacity(Integer roomCapacity) {
            this.roomCapacity = roomCapacity;
            return this;
        }
        public Integer getRoomCapacity() {
            return this.roomCapacity;
        }

        public QueryMeetingRoomListResponseBodyResult setRoomGroup(QueryMeetingRoomListResponseBodyResultRoomGroup roomGroup) {
            this.roomGroup = roomGroup;
            return this;
        }
        public QueryMeetingRoomListResponseBodyResultRoomGroup getRoomGroup() {
            return this.roomGroup;
        }

        public QueryMeetingRoomListResponseBodyResult setRoomId(String roomId) {
            this.roomId = roomId;
            return this;
        }
        public String getRoomId() {
            return this.roomId;
        }

        public QueryMeetingRoomListResponseBodyResult setRoomLabels(java.util.List<QueryMeetingRoomListResponseBodyResultRoomLabels> roomLabels) {
            this.roomLabels = roomLabels;
            return this;
        }
        public java.util.List<QueryMeetingRoomListResponseBodyResultRoomLabels> getRoomLabels() {
            return this.roomLabels;
        }

        public QueryMeetingRoomListResponseBodyResult setRoomLocation(QueryMeetingRoomListResponseBodyResultRoomLocation roomLocation) {
            this.roomLocation = roomLocation;
            return this;
        }
        public QueryMeetingRoomListResponseBodyResultRoomLocation getRoomLocation() {
            return this.roomLocation;
        }

        public QueryMeetingRoomListResponseBodyResult setRoomName(String roomName) {
            this.roomName = roomName;
            return this;
        }
        public String getRoomName() {
            return this.roomName;
        }

        public QueryMeetingRoomListResponseBodyResult setRoomPicture(String roomPicture) {
            this.roomPicture = roomPicture;
            return this;
        }
        public String getRoomPicture() {
            return this.roomPicture;
        }

        public QueryMeetingRoomListResponseBodyResult setRoomStaffId(String roomStaffId) {
            this.roomStaffId = roomStaffId;
            return this;
        }
        public String getRoomStaffId() {
            return this.roomStaffId;
        }

        public QueryMeetingRoomListResponseBodyResult setRoomStatus(Integer roomStatus) {
            this.roomStatus = roomStatus;
            return this;
        }
        public Integer getRoomStatus() {
            return this.roomStatus;
        }

    }

}
