// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskTaskflowstatusResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateTaskTaskflowstatusResponseBodyResult result;

    public static UpdateTaskTaskflowstatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskTaskflowstatusResponseBody self = new UpdateTaskTaskflowstatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTaskTaskflowstatusResponseBody setResult(UpdateTaskTaskflowstatusResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateTaskTaskflowstatusResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateTaskTaskflowstatusResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        public static UpdateTaskTaskflowstatusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateTaskTaskflowstatusResponseBodyResult self = new UpdateTaskTaskflowstatusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateTaskTaskflowstatusResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
