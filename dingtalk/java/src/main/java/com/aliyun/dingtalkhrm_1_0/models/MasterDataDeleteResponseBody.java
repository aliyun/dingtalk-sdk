// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataDeleteResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("allSuccess")
    public Boolean allSuccess;

    @NameInMap("failResult")
    public java.util.List<MasterDataDeleteResponseBodyFailResult> failResult;

    public static MasterDataDeleteResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MasterDataDeleteResponseBody self = new MasterDataDeleteResponseBody();
        return TeaModel.build(map, self);
    }

    public MasterDataDeleteResponseBody setAllSuccess(Boolean allSuccess) {
        this.allSuccess = allSuccess;
        return this;
    }
    public Boolean getAllSuccess() {
        return this.allSuccess;
    }

    public MasterDataDeleteResponseBody setFailResult(java.util.List<MasterDataDeleteResponseBodyFailResult> failResult) {
        this.failResult = failResult;
        return this;
    }
    public java.util.List<MasterDataDeleteResponseBodyFailResult> getFailResult() {
        return this.failResult;
    }

    public static class MasterDataDeleteResponseBodyFailResult extends TeaModel {
        @NameInMap("bizUK")
        public String bizUK;

        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("errorMsg")
        public String errorMsg;

        @NameInMap("success")
        public Boolean success;

        public static MasterDataDeleteResponseBodyFailResult build(java.util.Map<String, ?> map) throws Exception {
            MasterDataDeleteResponseBodyFailResult self = new MasterDataDeleteResponseBodyFailResult();
            return TeaModel.build(map, self);
        }

        public MasterDataDeleteResponseBodyFailResult setBizUK(String bizUK) {
            this.bizUK = bizUK;
            return this;
        }
        public String getBizUK() {
            return this.bizUK;
        }

        public MasterDataDeleteResponseBodyFailResult setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public MasterDataDeleteResponseBodyFailResult setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public MasterDataDeleteResponseBodyFailResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
