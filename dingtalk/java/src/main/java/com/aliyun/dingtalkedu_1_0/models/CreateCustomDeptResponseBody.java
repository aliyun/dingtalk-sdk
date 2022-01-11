// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomDeptResponseBody extends TeaModel {
    // result
    @NameInMap("result")
    public CreateCustomDeptResponseBodyResult result;

    // success
    @NameInMap("success")
    public Boolean success;

    public static CreateCustomDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomDeptResponseBody self = new CreateCustomDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCustomDeptResponseBody setResult(CreateCustomDeptResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateCustomDeptResponseBodyResult getResult() {
        return this.result;
    }

    public CreateCustomDeptResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateCustomDeptResponseBodyResult extends TeaModel {
        // 部门ID
        @NameInMap("deptId")
        public Long deptId;

        public static CreateCustomDeptResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateCustomDeptResponseBodyResult self = new CreateCustomDeptResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateCustomDeptResponseBodyResult setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

    }

}
