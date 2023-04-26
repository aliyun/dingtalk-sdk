// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddDeptResponseBody extends TeaModel {
    @NameInMap("result")
    public SupplyAddDeptResponseBodyResult result;

    public static SupplyAddDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyAddDeptResponseBody self = new SupplyAddDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyAddDeptResponseBody setResult(SupplyAddDeptResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SupplyAddDeptResponseBodyResult getResult() {
        return this.result;
    }

    public static class SupplyAddDeptResponseBodyResult extends TeaModel {
        @NameInMap("deptId")
        public Long deptId;

        public static SupplyAddDeptResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SupplyAddDeptResponseBodyResult self = new SupplyAddDeptResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SupplyAddDeptResponseBodyResult setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

    }

}
