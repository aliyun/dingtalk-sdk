// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataSaveResponseBody extends TeaModel {
    // 是否全部保存成功
    @NameInMap("allSuccess")
    public Boolean allSuccess;

    // 保存失败的结果，全部保存成功时为空
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
        // 业务流水唯一标识，和入参一致
        @NameInMap("bizUk")
        public String bizUk;

        // 是否成功
        @NameInMap("success")
        public Boolean success;

        // 错误码
        @NameInMap("errorCode")
        public String errorCode;

        // 错误信息
        @NameInMap("errorMsg")
        public String errorMsg;

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

        public MasterDataSaveResponseBodyFailResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
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

    }

}
