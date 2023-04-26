// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskStartdateResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateTaskStartdateResponseBodyResult result;

    public static UpdateTaskStartdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskStartdateResponseBody self = new UpdateTaskStartdateResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTaskStartdateResponseBody setResult(UpdateTaskStartdateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateTaskStartdateResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateTaskStartdateResponseBodyResult extends TeaModel {
        @NameInMap("startDate")
        public String startDate;

        @NameInMap("updated")
        public String updated;

        public static UpdateTaskStartdateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateTaskStartdateResponseBodyResult self = new UpdateTaskStartdateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateTaskStartdateResponseBodyResult setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public UpdateTaskStartdateResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
