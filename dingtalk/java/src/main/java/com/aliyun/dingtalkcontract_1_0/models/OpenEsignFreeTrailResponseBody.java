// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class OpenEsignFreeTrailResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public OpenEsignFreeTrailResponseBodyResult result;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static OpenEsignFreeTrailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OpenEsignFreeTrailResponseBody self = new OpenEsignFreeTrailResponseBody();
        return TeaModel.build(map, self);
    }

    public OpenEsignFreeTrailResponseBody setResult(OpenEsignFreeTrailResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public OpenEsignFreeTrailResponseBodyResult getResult() {
        return this.result;
    }

    public OpenEsignFreeTrailResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class OpenEsignFreeTrailResponseBodyResult extends TeaModel {
        @NameInMap("message")
        public String message;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static OpenEsignFreeTrailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            OpenEsignFreeTrailResponseBodyResult self = new OpenEsignFreeTrailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public OpenEsignFreeTrailResponseBodyResult setMessage(String message) {
            this.message = message;
            return this;
        }
        public String getMessage() {
            return this.message;
        }

        public OpenEsignFreeTrailResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
