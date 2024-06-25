// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataSaveResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("allSuccess")
    public Boolean allSuccess;

    @NameInMap("failResult")
    public java.util.List<MasterDataSaveResponseBodyFailResult> failResult;

    public static MasterDataSaveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MasterDataSaveResponseBody self = new MasterDataSaveResponseBody();
        return TeaModel.build(map, self);
    }

    public MasterDataSaveResponseBody setAllSuccess(Boolean allSuccess) {
        this.allSuccess = allSuccess;
        return this;
    }
    public Boolean getAllSuccess() {
        return this.allSuccess;
    }

    public MasterDataSaveResponseBody setFailResult(java.util.List<MasterDataSaveResponseBodyFailResult> failResult) {
        this.failResult = failResult;
        return this;
    }
    public java.util.List<MasterDataSaveResponseBodyFailResult> getFailResult() {
        return this.failResult;
    }

    public static class MasterDataSaveResponseBodyFailResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>uk123</p>
         */
        @NameInMap("bizUk")
        public String bizUk;

        /**
         * <strong>example:</strong>
         * <p>S0005</p>
         */
        @NameInMap("errorCode")
        public String errorCode;

        /**
         * <strong>example:</strong>
         * <p>主键冲突</p>
         */
        @NameInMap("errorMsg")
        public String errorMsg;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static MasterDataSaveResponseBodyFailResult build(java.util.Map<String, ?> map) throws Exception {
            MasterDataSaveResponseBodyFailResult self = new MasterDataSaveResponseBodyFailResult();
            return TeaModel.build(map, self);
        }

        public MasterDataSaveResponseBodyFailResult setBizUk(String bizUk) {
            this.bizUk = bizUk;
            return this;
        }
        public String getBizUk() {
            return this.bizUk;
        }

        public MasterDataSaveResponseBodyFailResult setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public MasterDataSaveResponseBodyFailResult setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public MasterDataSaveResponseBodyFailResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
