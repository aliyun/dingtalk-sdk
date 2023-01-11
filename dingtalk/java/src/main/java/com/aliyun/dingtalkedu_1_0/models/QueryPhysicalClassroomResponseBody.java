// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPhysicalClassroomResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     */
    @NameInMap("result")
    public QueryPhysicalClassroomResponseBodyResult result;

    /**
     * <p>请求是否成功</p>
     */
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
        /**
         * <p>教室教学楼</p>
         */
        @NameInMap("classroomBuilding")
        public String classroomBuilding;

        /**
         * <p>教室校区</p>
         */
        @NameInMap("classroomCampus")
        public String classroomCampus;

        /**
         * <p>教室楼层</p>
         */
        @NameInMap("classroomFloor")
        public String classroomFloor;

        /**
         * <p>教室ID</p>
         */
        @NameInMap("classroomId")
        public Long classroomId;

        /**
         * <p>教室名称</p>
         */
        @NameInMap("classroomName")
        public String classroomName;

        /**
         * <p>教室房间号</p>
         */
        @NameInMap("classroomNumber")
        public String classroomNumber;

        /**
         * <p>是否支持直播</p>
         */
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
