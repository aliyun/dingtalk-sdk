// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ShiftAddResponseBody extends TeaModel {
    @NameInMap("result")
    public ShiftAddResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static ShiftAddResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ShiftAddResponseBody self = new ShiftAddResponseBody();
        return TeaModel.build(map, self);
    }

    public ShiftAddResponseBody setResult(ShiftAddResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ShiftAddResponseBodyResult getResult() {
        return this.result;
    }

    public ShiftAddResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ShiftAddResponseBodyResult extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("shiftId")
        public Long shiftId;

        public static ShiftAddResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ShiftAddResponseBodyResult self = new ShiftAddResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ShiftAddResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ShiftAddResponseBodyResult setShiftId(Long shiftId) {
            this.shiftId = shiftId;
            return this;
        }
        public Long getShiftId() {
            return this.shiftId;
        }

    }

}
