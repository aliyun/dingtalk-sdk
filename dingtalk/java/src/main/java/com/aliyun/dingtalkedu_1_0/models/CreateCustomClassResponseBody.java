// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomClassResponseBody extends TeaModel {
    /**
     * <p>result</p>
     */
    @NameInMap("result")
    public CreateCustomClassResponseBodyResult result;

    /**
     * <p>success</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static CreateCustomClassResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomClassResponseBody self = new CreateCustomClassResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCustomClassResponseBody setResult(CreateCustomClassResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateCustomClassResponseBodyResult getResult() {
        return this.result;
    }

    public CreateCustomClassResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateCustomClassResponseBodyResult extends TeaModel {
        /**
         * <p>班级ID</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        public static CreateCustomClassResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateCustomClassResponseBodyResult self = new CreateCustomClassResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateCustomClassResponseBodyResult setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

    }

}
