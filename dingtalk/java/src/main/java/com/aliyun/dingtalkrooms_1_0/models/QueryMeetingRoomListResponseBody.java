// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomListResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

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
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("groupId")
        public Long groupId;

        /**
         * <strong>example:</strong>
         * <p>测试分组</p>
         */
        @NameInMap("groupName")
        public String groupName;

        /**
         * <strong>example:</strong>
         * <p>0</p>
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
         * <strong>example:</strong>
         * <p>xx市xx区xx街道xx号</p>
         */
        @NameInMap("desc")
        public String desc;

        /**
         * <strong>example:</strong>
         * <p>xxx公司</p>
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
         * <strong>example:</strong>
         * <p>ding994a046bca84545935c2f4657eb6378f</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>xxxIsvRoomId</p>
         */
        @NameInMap("isvRoomId")
        public String isvRoomId;

        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("roomCapacity")
        public Integer roomCapacity;

        @NameInMap("roomGroup")
        public QueryMeetingRoomListResponseBodyResultRoomGroup roomGroup;

        /**
         * <strong>example:</strong>
         * <p>0ffb71843fbb7fc362cb1a0de97fd20b808b09d6ca6282ed</p>
         */
        @NameInMap("roomId")
        public String roomId;

        @NameInMap("roomLabels")
        public java.util.List<QueryMeetingRoomListResponseBodyResultRoomLabels> roomLabels;

        @NameInMap("roomLocation")
        public QueryMeetingRoomListResponseBodyResultRoomLocation roomLocation;

        /**
         * <strong>example:</strong>
         * <p>测试会议室</p>
         */
        @NameInMap("roomName")
        public String roomName;

        /**
         * <strong>example:</strong>
         * <p><a href="https://static.dingtalk.com/media/lADPDgfLPFjNPu3NAWjNAWg_360_360.jpg">https://static.dingtalk.com/media/lADPDgfLPFjNPu3NAWjNAWg_360_360.jpg</a></p>
         */
        @NameInMap("roomPicture")
        public String roomPicture;

        /**
         * <strong>example:</strong>
         * <p>01224148194623278976</p>
         */
        @NameInMap("roomStaffId")
        public String roomStaffId;

        /**
         * <strong>example:</strong>
         * <p>0.全员可用 1.仅管理员可用</p>
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
