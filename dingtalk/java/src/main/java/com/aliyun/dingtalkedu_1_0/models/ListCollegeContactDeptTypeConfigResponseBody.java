// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ListCollegeContactDeptTypeConfigResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<ListCollegeContactDeptTypeConfigResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static ListCollegeContactDeptTypeConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListCollegeContactDeptTypeConfigResponseBody self = new ListCollegeContactDeptTypeConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public ListCollegeContactDeptTypeConfigResponseBody setResult(java.util.List<ListCollegeContactDeptTypeConfigResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListCollegeContactDeptTypeConfigResponseBodyResult> getResult() {
        return this.result;
    }

    public ListCollegeContactDeptTypeConfigResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ListCollegeContactDeptTypeConfigResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>contact_class_dept</p>
         */
        @NameInMap("deptType")
        public String deptType;

        /**
         * <strong>example:</strong>
         * <p>班级</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("userDef")
        public Boolean userDef;

        public static ListCollegeContactDeptTypeConfigResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListCollegeContactDeptTypeConfigResponseBodyResult self = new ListCollegeContactDeptTypeConfigResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListCollegeContactDeptTypeConfigResponseBodyResult setDeptType(String deptType) {
            this.deptType = deptType;
            return this;
        }
        public String getDeptType() {
            return this.deptType;
        }

        public ListCollegeContactDeptTypeConfigResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListCollegeContactDeptTypeConfigResponseBodyResult setUserDef(Boolean userDef) {
            this.userDef = userDef;
            return this;
        }
        public Boolean getUserDef() {
            return this.userDef;
        }

    }

}
