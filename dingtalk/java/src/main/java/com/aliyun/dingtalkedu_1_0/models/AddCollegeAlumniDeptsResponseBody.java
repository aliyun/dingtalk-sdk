// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddCollegeAlumniDeptsResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<AddCollegeAlumniDeptsResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static AddCollegeAlumniDeptsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddCollegeAlumniDeptsResponseBody self = new AddCollegeAlumniDeptsResponseBody();
        return TeaModel.build(map, self);
    }

    public AddCollegeAlumniDeptsResponseBody setResult(java.util.List<AddCollegeAlumniDeptsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<AddCollegeAlumniDeptsResponseBodyResult> getResult() {
        return this.result;
    }

    public AddCollegeAlumniDeptsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AddCollegeAlumniDeptsResponseBodyResult extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("deptType")
        public String deptType;

        @NameInMap("hasSubDept")
        public Boolean hasSubDept;

        @NameInMap("name")
        public String name;

        @NameInMap("superId")
        public Long superId;

        public static AddCollegeAlumniDeptsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddCollegeAlumniDeptsResponseBodyResult self = new AddCollegeAlumniDeptsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddCollegeAlumniDeptsResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public AddCollegeAlumniDeptsResponseBodyResult setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public AddCollegeAlumniDeptsResponseBodyResult setDeptType(String deptType) {
            this.deptType = deptType;
            return this;
        }
        public String getDeptType() {
            return this.deptType;
        }

        public AddCollegeAlumniDeptsResponseBodyResult setHasSubDept(Boolean hasSubDept) {
            this.hasSubDept = hasSubDept;
            return this;
        }
        public Boolean getHasSubDept() {
            return this.hasSubDept;
        }

        public AddCollegeAlumniDeptsResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public AddCollegeAlumniDeptsResponseBodyResult setSuperId(Long superId) {
            this.superId = superId;
            return this;
        }
        public Long getSuperId() {
            return this.superId;
        }

    }

}
