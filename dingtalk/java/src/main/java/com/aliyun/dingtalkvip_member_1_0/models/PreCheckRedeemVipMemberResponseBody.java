// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvip_member_1_0.models;

import com.aliyun.tea.*;

public class PreCheckRedeemVipMemberResponseBody extends TeaModel {
    @NameInMap("bizRequestId")
    public String bizRequestId;

    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public Boolean result;

    public static PreCheckRedeemVipMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PreCheckRedeemVipMemberResponseBody self = new PreCheckRedeemVipMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public PreCheckRedeemVipMemberResponseBody setBizRequestId(String bizRequestId) {
        this.bizRequestId = bizRequestId;
        return this;
    }
    public String getBizRequestId() {
        return this.bizRequestId;
    }

    public PreCheckRedeemVipMemberResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public PreCheckRedeemVipMemberResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public PreCheckRedeemVipMemberResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
