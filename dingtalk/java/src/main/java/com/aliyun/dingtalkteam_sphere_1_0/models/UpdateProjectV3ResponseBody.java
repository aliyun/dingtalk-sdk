// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class UpdateProjectV3ResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public UpdateProjectV3ResponseBodyResult result;

    public static UpdateProjectV3ResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateProjectV3ResponseBody self = new UpdateProjectV3ResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateProjectV3ResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public UpdateProjectV3ResponseBody setResult(UpdateProjectV3ResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateProjectV3ResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateProjectV3ResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        public static UpdateProjectV3ResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateProjectV3ResponseBodyResult self = new UpdateProjectV3ResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateProjectV3ResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
