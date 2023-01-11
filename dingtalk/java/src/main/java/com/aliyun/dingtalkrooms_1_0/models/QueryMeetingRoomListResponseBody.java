// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomListResponseBody extends TeaModel {
    /**
     * <p>是否有更多</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>下次查询分页标记</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <p>会议室列表</p>
     */
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
        /**
         * <p>分组id</p>
         */
        @NameInMap("groupId")
        public Long groupId;

        /**
         * <p>分组名称</p>
         */
        @NameInMap("groupName")
        public String groupName;

        /**
         * <p>父分组id</p>
         */
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
        /**
         * <p>位置详细信息</p>
         */
        @NameInMap("desc")
        public String desc;

        /**
         * <p>位置名称</p>
         */
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
        /**
         * <p>企业corpId</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>isv外部会议室id</p>
         */
        @NameInMap("isvRoomId")
        public String isvRoomId;

        /**
         * <p>会议室容量</p>
         */
        @NameInMap("roomCapacity")
        public Integer roomCapacity;

        /**
         * <p>会议室分组</p>
         */
        @NameInMap("roomGroup")
        public QueryMeetingRoomListResponseBodyResultRoomGroup roomGroup;

        /**
         * <p>会议室id</p>
         */
        @NameInMap("roomId")
        public String roomId;

        @NameInMap("roomLabels")
        public java.util.List<QueryMeetingRoomListResponseBodyResultRoomLabels> roomLabels;

        /**
         * <p>会议室位置</p>
         */
        @NameInMap("roomLocation")
        public QueryMeetingRoomListResponseBodyResultRoomLocation roomLocation;

        /**
         * <p>会议室名称</p>
         */
        @NameInMap("roomName")
        public String roomName;

        /**
         * <p>会议室图片</p>
         */
        @NameInMap("roomPicture")
        public String roomPicture;

        /**
         * <p>会议室staffId</p>
         */
        @NameInMap("roomStaffId")
        public String roomStaffId;

        /**
         * <p>会议室状态</p>
         */
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
