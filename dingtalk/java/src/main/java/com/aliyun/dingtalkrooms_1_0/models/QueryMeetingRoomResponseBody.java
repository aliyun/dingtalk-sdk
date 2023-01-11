// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryMeetingRoomResponseBodyResult result;

    public static QueryMeetingRoomResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomResponseBody self = new QueryMeetingRoomResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomResponseBody setResult(QueryMeetingRoomResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryMeetingRoomResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryMeetingRoomResponseBodyResultRoomGroup extends TeaModel {
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

        public static QueryMeetingRoomResponseBodyResultRoomGroup build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomResponseBodyResultRoomGroup self = new QueryMeetingRoomResponseBodyResultRoomGroup();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomResponseBodyResultRoomGroup setGroupId(Long groupId) {
            this.groupId = groupId;
            return this;
        }
        public Long getGroupId() {
            return this.groupId;
        }

        public QueryMeetingRoomResponseBodyResultRoomGroup setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public QueryMeetingRoomResponseBodyResultRoomGroup setParentId(Long parentId) {
            this.parentId = parentId;
            return this;
        }
        public Long getParentId() {
            return this.parentId;
        }

    }

    public static class QueryMeetingRoomResponseBodyResultRoomLabels extends TeaModel {
        @NameInMap("labelId")
        public Long labelId;

        @NameInMap("labelName")
        public String labelName;

        public static QueryMeetingRoomResponseBodyResultRoomLabels build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomResponseBodyResultRoomLabels self = new QueryMeetingRoomResponseBodyResultRoomLabels();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomResponseBodyResultRoomLabels setLabelId(Long labelId) {
            this.labelId = labelId;
            return this;
        }
        public Long getLabelId() {
            return this.labelId;
        }

        public QueryMeetingRoomResponseBodyResultRoomLabels setLabelName(String labelName) {
            this.labelName = labelName;
            return this;
        }
        public String getLabelName() {
            return this.labelName;
        }

    }

    public static class QueryMeetingRoomResponseBodyResultRoomLocation extends TeaModel {
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

        public static QueryMeetingRoomResponseBodyResultRoomLocation build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomResponseBodyResultRoomLocation self = new QueryMeetingRoomResponseBodyResultRoomLocation();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomResponseBodyResultRoomLocation setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public QueryMeetingRoomResponseBodyResultRoomLocation setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryMeetingRoomResponseBodyResult extends TeaModel {
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
        public QueryMeetingRoomResponseBodyResultRoomGroup roomGroup;

        /**
         * <p>会议室id</p>
         */
        @NameInMap("roomId")
        public String roomId;

        @NameInMap("roomLabels")
        public java.util.List<QueryMeetingRoomResponseBodyResultRoomLabels> roomLabels;

        /**
         * <p>会议室位置</p>
         */
        @NameInMap("roomLocation")
        public QueryMeetingRoomResponseBodyResultRoomLocation roomLocation;

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

        public static QueryMeetingRoomResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomResponseBodyResult self = new QueryMeetingRoomResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryMeetingRoomResponseBodyResult setIsvRoomId(String isvRoomId) {
            this.isvRoomId = isvRoomId;
            return this;
        }
        public String getIsvRoomId() {
            return this.isvRoomId;
        }

        public QueryMeetingRoomResponseBodyResult setRoomCapacity(Integer roomCapacity) {
            this.roomCapacity = roomCapacity;
            return this;
        }
        public Integer getRoomCapacity() {
            return this.roomCapacity;
        }

        public QueryMeetingRoomResponseBodyResult setRoomGroup(QueryMeetingRoomResponseBodyResultRoomGroup roomGroup) {
            this.roomGroup = roomGroup;
            return this;
        }
        public QueryMeetingRoomResponseBodyResultRoomGroup getRoomGroup() {
            return this.roomGroup;
        }

        public QueryMeetingRoomResponseBodyResult setRoomId(String roomId) {
            this.roomId = roomId;
            return this;
        }
        public String getRoomId() {
            return this.roomId;
        }

        public QueryMeetingRoomResponseBodyResult setRoomLabels(java.util.List<QueryMeetingRoomResponseBodyResultRoomLabels> roomLabels) {
            this.roomLabels = roomLabels;
            return this;
        }
        public java.util.List<QueryMeetingRoomResponseBodyResultRoomLabels> getRoomLabels() {
            return this.roomLabels;
        }

        public QueryMeetingRoomResponseBodyResult setRoomLocation(QueryMeetingRoomResponseBodyResultRoomLocation roomLocation) {
            this.roomLocation = roomLocation;
            return this;
        }
        public QueryMeetingRoomResponseBodyResultRoomLocation getRoomLocation() {
            return this.roomLocation;
        }

        public QueryMeetingRoomResponseBodyResult setRoomName(String roomName) {
            this.roomName = roomName;
            return this;
        }
        public String getRoomName() {
            return this.roomName;
        }

        public QueryMeetingRoomResponseBodyResult setRoomPicture(String roomPicture) {
            this.roomPicture = roomPicture;
            return this;
        }
        public String getRoomPicture() {
            return this.roomPicture;
        }

        public QueryMeetingRoomResponseBodyResult setRoomStaffId(String roomStaffId) {
            this.roomStaffId = roomStaffId;
            return this;
        }
        public String getRoomStaffId() {
            return this.roomStaffId;
        }

        public QueryMeetingRoomResponseBodyResult setRoomStatus(Integer roomStatus) {
            this.roomStatus = roomStatus;
            return this;
        }
        public Integer getRoomStatus() {
            return this.roomStatus;
        }

    }

}
