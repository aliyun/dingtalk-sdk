// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmMokaOapiResponseBody extends TeaModel {
    @NameInMap("bizSuccess")
    public Boolean bizSuccess;

    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public java.util.Map<String, ?> result;

    public static HrmMokaOapiResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrmMokaOapiResponseBody self = new HrmMokaOapiResponseBody();
        return TeaModel.build(map, self);
    }

    public HrmMokaOapiResponseBody setBizSuccess(Boolean bizSuccess) {
        this.bizSuccess = bizSuccess;
        return this;
    }
    public Boolean getBizSuccess() {
        return this.bizSuccess;
    }

    public HrmMokaOapiResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public HrmMokaOapiResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public HrmMokaOapiResponseBody setResult(java.util.Map<String, ?> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, ?> getResult() {
        return this.result;
    }

}
