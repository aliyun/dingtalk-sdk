// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetCollegeContactStandardStruDeptDetailResponseBody extends TeaModel {
    @NameInMap("result")
    public GetCollegeContactStandardStruDeptDetailResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetCollegeContactStandardStruDeptDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCollegeContactStandardStruDeptDetailResponseBody self = new GetCollegeContactStandardStruDeptDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCollegeContactStandardStruDeptDetailResponseBody setResult(GetCollegeContactStandardStruDeptDetailResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetCollegeContactStandardStruDeptDetailResponseBodyResult getResult() {
        return this.result;
    }

    public GetCollegeContactStandardStruDeptDetailResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetCollegeContactStandardStruDeptDetailResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>456</p>
         */
        @NameInMap("struId")
        public Long struId;

        /**
         * <strong>example:</strong>
         * <p>890</p>
         */
        @NameInMap("studentDeptId")
        public Long studentDeptId;

        /**
         * <strong>example:</strong>
         * <p>678</p>
         */
        @NameInMap("teacherDeptId")
        public Long teacherDeptId;

        public static GetCollegeContactStandardStruDeptDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetCollegeContactStandardStruDeptDetailResponseBodyResult self = new GetCollegeContactStandardStruDeptDetailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetCollegeContactStandardStruDeptDetailResponseBodyResult setStruId(Long struId) {
            this.struId = struId;
            return this;
        }
        public Long getStruId() {
            return this.struId;
        }

        public GetCollegeContactStandardStruDeptDetailResponseBodyResult setStudentDeptId(Long studentDeptId) {
            this.studentDeptId = studentDeptId;
            return this;
        }
        public Long getStudentDeptId() {
            return this.studentDeptId;
        }

        public GetCollegeContactStandardStruDeptDetailResponseBodyResult setTeacherDeptId(Long teacherDeptId) {
            this.teacherDeptId = teacherDeptId;
            return this;
        }
        public Long getTeacherDeptId() {
            return this.teacherDeptId;
        }

    }

}
