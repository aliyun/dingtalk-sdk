// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetCollegeAlumniDeptsResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetCollegeAlumniDeptsResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static GetCollegeAlumniDeptsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCollegeAlumniDeptsResponseBody self = new GetCollegeAlumniDeptsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCollegeAlumniDeptsResponseBody setResult(java.util.List<GetCollegeAlumniDeptsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetCollegeAlumniDeptsResponseBodyResult> getResult() {
        return this.result;
    }

    public GetCollegeAlumniDeptsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetCollegeAlumniDeptsResponseBodyResult extends TeaModel {
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

        public static GetCollegeAlumniDeptsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetCollegeAlumniDeptsResponseBodyResult self = new GetCollegeAlumniDeptsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetCollegeAlumniDeptsResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetCollegeAlumniDeptsResponseBodyResult setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public GetCollegeAlumniDeptsResponseBodyResult setDeptType(String deptType) {
            this.deptType = deptType;
            return this;
        }
        public String getDeptType() {
            return this.deptType;
        }

        public GetCollegeAlumniDeptsResponseBodyResult setHasSubDept(Boolean hasSubDept) {
            this.hasSubDept = hasSubDept;
            return this;
        }
        public Boolean getHasSubDept() {
            return this.hasSubDept;
        }

        public GetCollegeAlumniDeptsResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetCollegeAlumniDeptsResponseBodyResult setSuperId(Long superId) {
            this.superId = superId;
            return this;
        }
        public Long getSuperId() {
            return this.superId;
        }

    }

}
