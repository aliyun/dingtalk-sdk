// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class LiandanluTextToImageModelResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public LiandanluTextToImageModelResponseBodyResult result;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static LiandanluTextToImageModelResponseBody build(java.util.Map<String, ?> map) throws Exception {
        LiandanluTextToImageModelResponseBody self = new LiandanluTextToImageModelResponseBody();
        return TeaModel.build(map, self);
    }

    public LiandanluTextToImageModelResponseBody setResult(LiandanluTextToImageModelResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public LiandanluTextToImageModelResponseBodyResult getResult() {
        return this.result;
    }

    public LiandanluTextToImageModelResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class LiandanluTextToImageModelResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>0112_1222</p>
         */
        @NameInMap("requestId")
        public String requestId;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("taskId")
        public String taskId;

        /**
         * <strong>example:</strong>
         * <p>SUCCEEDED</p>
         */
        @NameInMap("taskStatus")
        public String taskStatus;

        public static LiandanluTextToImageModelResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            LiandanluTextToImageModelResponseBodyResult self = new LiandanluTextToImageModelResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public LiandanluTextToImageModelResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

        public LiandanluTextToImageModelResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public LiandanluTextToImageModelResponseBodyResult setTaskStatus(String taskStatus) {
            this.taskStatus = taskStatus;
            return this;
        }
        public String getTaskStatus() {
            return this.taskStatus;
        }

    }

}
