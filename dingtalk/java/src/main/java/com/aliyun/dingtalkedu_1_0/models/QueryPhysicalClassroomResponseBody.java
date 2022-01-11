// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPhysicalClassroomResponseBody extends TeaModel {
    // 返回结果
    @NameInMap("result")
    public QueryPhysicalClassroomResponseBodyResult result;

    // 请求是否成功
    @NameInMap("success")
    public Boolean success;

    public static QueryPhysicalClassroomResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPhysicalClassroomResponseBody self = new QueryPhysicalClassroomResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPhysicalClassroomResponseBody setResult(QueryPhysicalClassroomResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryPhysicalClassroomResponseBodyResult getResult() {
        return this.result;
    }

    public QueryPhysicalClassroomResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryPhysicalClassroomResponseBodyResult extends TeaModel {
        // 教室教学楼
        @NameInMap("classroomBuilding")
        public String classroomBuilding;

        // 教室校区
        @NameInMap("classroomCampus")
        public String classroomCampus;

        // 教室楼层
        @NameInMap("classroomFloor")
        public String classroomFloor;

        // 教室ID
        @NameInMap("classroomId")
        public Long classroomId;

        // 教室名称
        @NameInMap("classroomName")
        public String classroomName;

        // 教室房间号
        @NameInMap("classroomNumber")
        public String classroomNumber;

        // 是否支持直播
        @NameInMap("directBroadcast")
        public String directBroadcast;

        public static QueryPhysicalClassroomResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryPhysicalClassroomResponseBodyResult self = new QueryPhysicalClassroomResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryPhysicalClassroomResponseBodyResult setClassroomBuilding(String classroomBuilding) {
            this.classroomBuilding = classroomBuilding;
            return this;
        }
        public String getClassroomBuilding() {
            return this.classroomBuilding;
        }

        public QueryPhysicalClassroomResponseBodyResult setClassroomCampus(String classroomCampus) {
            this.classroomCampus = classroomCampus;
            return this;
        }
        public String getClassroomCampus() {
            return this.classroomCampus;
        }

        public QueryPhysicalClassroomResponseBodyResult setClassroomFloor(String classroomFloor) {
            this.classroomFloor = classroomFloor;
            return this;
        }
        public String getClassroomFloor() {
            return this.classroomFloor;
        }

        public QueryPhysicalClassroomResponseBodyResult setClassroomId(Long classroomId) {
            this.classroomId = classroomId;
            return this;
        }
        public Long getClassroomId() {
            return this.classroomId;
        }

        public QueryPhysicalClassroomResponseBodyResult setClassroomName(String classroomName) {
            this.classroomName = classroomName;
            return this;
        }
        public String getClassroomName() {
            return this.classroomName;
        }

        public QueryPhysicalClassroomResponseBodyResult setClassroomNumber(String classroomNumber) {
            this.classroomNumber = classroomNumber;
            return this;
        }
        public String getClassroomNumber() {
            return this.classroomNumber;
        }

        public QueryPhysicalClassroomResponseBodyResult setDirectBroadcast(String directBroadcast) {
            this.directBroadcast = directBroadcast;
            return this;
        }
        public String getDirectBroadcast() {
            return this.directBroadcast;
        }

    }

}
