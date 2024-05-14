// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPhysicalClassroomResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public QueryPhysicalClassroomResponseBodyResult result;

    /**
     * <p>This parameter is required.</p>
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
        @NameInMap("classroomBuilding")
        public String classroomBuilding;

        @NameInMap("classroomCampus")
        public String classroomCampus;

        @NameInMap("classroomFloor")
        public String classroomFloor;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("classroomId")
        public Long classroomId;

        @NameInMap("classroomName")
        public String classroomName;

        @NameInMap("classroomNumber")
        public String classroomNumber;

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
