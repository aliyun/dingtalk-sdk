// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeListCollegeSubDeptResponseBody extends TeaModel {
    /**
     * <p>部门信息列表</p>
     */
    @NameInMap("collegeDeptInfoSimpleList")
    public java.util.List<CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList> collegeDeptInfoSimpleList;

    public static CollegeListCollegeSubDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeListCollegeSubDeptResponseBody self = new CollegeListCollegeSubDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeListCollegeSubDeptResponseBody setCollegeDeptInfoSimpleList(java.util.List<CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList> collegeDeptInfoSimpleList) {
        this.collegeDeptInfoSimpleList = collegeDeptInfoSimpleList;
        return this;
    }
    public java.util.List<CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList> getCollegeDeptInfoSimpleList() {
        return this.collegeDeptInfoSimpleList;
    }

    public static class CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList extends TeaModel {
        /**
         * <p>部门id</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <p>部门名称</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <p>部门类型</p>
         */
        @NameInMap("deptType")
        public String deptType;

        public static CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList build(java.util.Map<String, ?> map) throws Exception {
            CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList self = new CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList();
            return TeaModel.build(map, self);
        }

        public CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList setDeptType(String deptType) {
            this.deptType = deptType;
            return this;
        }
        public String getDeptType() {
            return this.deptType;
        }

    }

}
