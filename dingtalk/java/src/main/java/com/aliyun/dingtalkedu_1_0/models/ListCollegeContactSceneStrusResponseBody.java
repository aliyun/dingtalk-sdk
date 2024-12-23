// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ListCollegeContactSceneStrusResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<ListCollegeContactSceneStrusResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static ListCollegeContactSceneStrusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListCollegeContactSceneStrusResponseBody self = new ListCollegeContactSceneStrusResponseBody();
        return TeaModel.build(map, self);
    }

    public ListCollegeContactSceneStrusResponseBody setResult(java.util.List<ListCollegeContactSceneStrusResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListCollegeContactSceneStrusResponseBodyResult> getResult() {
        return this.result;
    }

    public ListCollegeContactSceneStrusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ListCollegeContactSceneStrusResponseBodyResult extends TeaModel {
        @NameInMap("enable")
        public Boolean enable;

        @NameInMap("hasStruFixedDept")
        public Boolean hasStruFixedDept;

        /**
         * <strong>example:</strong>
         * <p>这是科研架构简介</p>
         */
        @NameInMap("struBrief")
        public String struBrief;

        /**
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("struId")
        public Long struId;

        /**
         * <strong>example:</strong>
         * <p>科研架构</p>
         */
        @NameInMap("struName")
        public String struName;

        /**
         * <strong>example:</strong>
         * <p>stru_research_dept</p>
         */
        @NameInMap("struType")
        public String struType;

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

        public static ListCollegeContactSceneStrusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListCollegeContactSceneStrusResponseBodyResult self = new ListCollegeContactSceneStrusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListCollegeContactSceneStrusResponseBodyResult setEnable(Boolean enable) {
            this.enable = enable;
            return this;
        }
        public Boolean getEnable() {
            return this.enable;
        }

        public ListCollegeContactSceneStrusResponseBodyResult setHasStruFixedDept(Boolean hasStruFixedDept) {
            this.hasStruFixedDept = hasStruFixedDept;
            return this;
        }
        public Boolean getHasStruFixedDept() {
            return this.hasStruFixedDept;
        }

        public ListCollegeContactSceneStrusResponseBodyResult setStruBrief(String struBrief) {
            this.struBrief = struBrief;
            return this;
        }
        public String getStruBrief() {
            return this.struBrief;
        }

        public ListCollegeContactSceneStrusResponseBodyResult setStruId(Long struId) {
            this.struId = struId;
            return this;
        }
        public Long getStruId() {
            return this.struId;
        }

        public ListCollegeContactSceneStrusResponseBodyResult setStruName(String struName) {
            this.struName = struName;
            return this;
        }
        public String getStruName() {
            return this.struName;
        }

        public ListCollegeContactSceneStrusResponseBodyResult setStruType(String struType) {
            this.struType = struType;
            return this;
        }
        public String getStruType() {
            return this.struType;
        }

        public ListCollegeContactSceneStrusResponseBodyResult setStudentDeptId(Long studentDeptId) {
            this.studentDeptId = studentDeptId;
            return this;
        }
        public Long getStudentDeptId() {
            return this.studentDeptId;
        }

        public ListCollegeContactSceneStrusResponseBodyResult setTeacherDeptId(Long teacherDeptId) {
            this.teacherDeptId = teacherDeptId;
            return this;
        }
        public Long getTeacherDeptId() {
            return this.teacherDeptId;
        }

    }

}
