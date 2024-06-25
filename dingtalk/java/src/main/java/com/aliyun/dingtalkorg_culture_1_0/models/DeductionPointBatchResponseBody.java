// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class DeductionPointBatchResponseBody extends TeaModel {
    @NameInMap("result")
    public DeductionPointBatchResponseBodyResult result;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static DeductionPointBatchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeductionPointBatchResponseBody self = new DeductionPointBatchResponseBody();
        return TeaModel.build(map, self);
    }

    public DeductionPointBatchResponseBody setResult(DeductionPointBatchResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DeductionPointBatchResponseBodyResult getResult() {
        return this.result;
    }

    public DeductionPointBatchResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>banliang#-20005</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>Fail</p>
         */
        @NameInMap("invokeStatus")
        public String invokeStatus;

        /**
         * <strong>example:</strong>
         * <p>freeze already settle</p>
         */
        @NameInMap("msg")
        public String msg;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>34345435345</p>
         */
        @NameInMap("outId")
        public String outId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>01274411491620908910</p>
         */
        @NameInMap("userId")
        public String userId;

        public static DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS build(java.util.Map<String, ?> map) throws Exception {
            DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS self = new DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS();
            return TeaModel.build(map, self);
        }

        public DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS setInvokeStatus(String invokeStatus) {
            this.invokeStatus = invokeStatus;
            return this;
        }
        public String getInvokeStatus() {
            return this.invokeStatus;
        }

        public DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS setMsg(String msg) {
            this.msg = msg;
            return this;
        }
        public String getMsg() {
            return this.msg;
        }

        public DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS setOutId(String outId) {
            this.outId = outId;
            return this;
        }
        public String getOutId() {
            return this.outId;
        }

        public DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class DeductionPointBatchResponseBodyResult extends TeaModel {
        @NameInMap("openPointInvokeResultDTOS")
        public java.util.List<DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS> openPointInvokeResultDTOS;

        public static DeductionPointBatchResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DeductionPointBatchResponseBodyResult self = new DeductionPointBatchResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DeductionPointBatchResponseBodyResult setOpenPointInvokeResultDTOS(java.util.List<DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS> openPointInvokeResultDTOS) {
            this.openPointInvokeResultDTOS = openPointInvokeResultDTOS;
            return this;
        }
        public java.util.List<DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS> getOpenPointInvokeResultDTOS() {
            return this.openPointInvokeResultDTOS;
        }

    }

}
