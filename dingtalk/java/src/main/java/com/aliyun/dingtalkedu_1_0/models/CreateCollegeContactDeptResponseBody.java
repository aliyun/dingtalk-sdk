// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCollegeContactDeptResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateCollegeContactDeptResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateCollegeContactDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCollegeContactDeptResponseBody self = new CreateCollegeContactDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCollegeContactDeptResponseBody setResult(CreateCollegeContactDeptResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateCollegeContactDeptResponseBodyResult getResult() {
        return this.result;
    }

    public CreateCollegeContactDeptResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateCollegeContactDeptResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        public static CreateCollegeContactDeptResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateCollegeContactDeptResponseBodyResult self = new CreateCollegeContactDeptResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateCollegeContactDeptResponseBodyResult setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

    }

}
