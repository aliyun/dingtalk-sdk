// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCollegeContactSceneStruResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateCollegeContactSceneStruResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateCollegeContactSceneStruResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCollegeContactSceneStruResponseBody self = new CreateCollegeContactSceneStruResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCollegeContactSceneStruResponseBody setResult(CreateCollegeContactSceneStruResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateCollegeContactSceneStruResponseBodyResult getResult() {
        return this.result;
    }

    public CreateCollegeContactSceneStruResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateCollegeContactSceneStruResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("struId")
        public Long struId;

        /**
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("studentDeptId")
        public Long studentDeptId;

        /**
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("teacherDeptId")
        public Long teacherDeptId;

        public static CreateCollegeContactSceneStruResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateCollegeContactSceneStruResponseBodyResult self = new CreateCollegeContactSceneStruResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateCollegeContactSceneStruResponseBodyResult setStruId(Long struId) {
            this.struId = struId;
            return this;
        }
        public Long getStruId() {
            return this.struId;
        }

        public CreateCollegeContactSceneStruResponseBodyResult setStudentDeptId(Long studentDeptId) {
            this.studentDeptId = studentDeptId;
            return this;
        }
        public Long getStudentDeptId() {
            return this.studentDeptId;
        }

        public CreateCollegeContactSceneStruResponseBodyResult setTeacherDeptId(Long teacherDeptId) {
            this.teacherDeptId = teacherDeptId;
            return this;
        }
        public Long getTeacherDeptId() {
            return this.teacherDeptId;
        }

    }

}
