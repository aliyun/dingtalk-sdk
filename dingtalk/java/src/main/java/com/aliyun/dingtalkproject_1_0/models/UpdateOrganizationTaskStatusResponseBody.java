// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateOrganizationTaskStatusResponseBodyResult result;

    public static UpdateOrganizationTaskStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskStatusResponseBody self = new UpdateOrganizationTaskStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskStatusResponseBody setResult(UpdateOrganizationTaskStatusResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateOrganizationTaskStatusResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateOrganizationTaskStatusResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("isDone")
        public Boolean isDone;

        /**
         * <strong>example:</strong>
         * <p>2022-06-08T07:32:48.958Z</p>
         */
        @NameInMap("updateTime")
        public String updateTime;

        public static UpdateOrganizationTaskStatusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateOrganizationTaskStatusResponseBodyResult self = new UpdateOrganizationTaskStatusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateOrganizationTaskStatusResponseBodyResult setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

        public UpdateOrganizationTaskStatusResponseBodyResult setUpdateTime(String updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public String getUpdateTime() {
            return this.updateTime;
        }

    }

}
