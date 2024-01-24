// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EduListUserByFromUserIdsResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<EduListUserByFromUserIdsResponseBodyResult> result;

    public static EduListUserByFromUserIdsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EduListUserByFromUserIdsResponseBody self = new EduListUserByFromUserIdsResponseBody();
        return TeaModel.build(map, self);
    }

    public EduListUserByFromUserIdsResponseBody setResult(java.util.List<EduListUserByFromUserIdsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<EduListUserByFromUserIdsResponseBodyResult> getResult() {
        return this.result;
    }

    public static class EduListUserByFromUserIdsResponseBodyResult extends TeaModel {
        @NameInMap("campusId")
        public Long campusId;

        @NameInMap("classId")
        public Long classId;

        @NameInMap("gradeId")
        public Long gradeId;

        @NameInMap("name")
        public String name;

        @NameInMap("periodId")
        public Long periodId;

        @NameInMap("role")
        public String role;

        @NameInMap("userId")
        public String userId;

        public static EduListUserByFromUserIdsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            EduListUserByFromUserIdsResponseBodyResult self = new EduListUserByFromUserIdsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public EduListUserByFromUserIdsResponseBodyResult setCampusId(Long campusId) {
            this.campusId = campusId;
            return this;
        }
        public Long getCampusId() {
            return this.campusId;
        }

        public EduListUserByFromUserIdsResponseBodyResult setClassId(Long classId) {
            this.classId = classId;
            return this;
        }
        public Long getClassId() {
            return this.classId;
        }

        public EduListUserByFromUserIdsResponseBodyResult setGradeId(Long gradeId) {
            this.gradeId = gradeId;
            return this;
        }
        public Long getGradeId() {
            return this.gradeId;
        }

        public EduListUserByFromUserIdsResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public EduListUserByFromUserIdsResponseBodyResult setPeriodId(Long periodId) {
            this.periodId = periodId;
            return this;
        }
        public Long getPeriodId() {
            return this.periodId;
        }

        public EduListUserByFromUserIdsResponseBodyResult setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

        public EduListUserByFromUserIdsResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
