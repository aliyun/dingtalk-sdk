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
        // 位置详细信息
        @NameInMap("desc")
        public String desc;

        // 位置名称
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
        // 企业corpId
        @NameInMap("corpId")
        public String corpId;

        // isv外部会议室id
        @NameInMap("isvRoomId")
        public String isvRoomId;

        // 会议室容量
        @NameInMap("roomCapacity")
        public Integer roomCapacity;

        // 会议室id
        @NameInMap("roomId")
        public String roomId;

        @NameInMap("roomLabels")
        public java.util.List<QueryMeetingRoomResponseBodyResultRoomLabels> roomLabels;

        // 会议室位置
        @NameInMap("roomLocation")
        public QueryMeetingRoomResponseBodyResultRoomLocation roomLocation;

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
