// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvip_member_1_0.models;

import com.aliyun.tea.*;

public class DirectRedeemVipMemberByMobileResponseBody extends TeaModel {
    @NameInMap("bizRequestId")
    public String bizRequestId;

    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public Boolean result;

    public static DirectRedeemVipMemberByMobileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DirectRedeemVipMemberByMobileResponseBody self = new DirectRedeemVipMemberByMobileResponseBody();
        return TeaModel.build(map, self);
    }

    public DirectRedeemVipMemberByMobileResponseBody setBizRequestId(String bizRequestId) {
        this.bizRequestId = bizRequestId;
        return this;
    }
    public String getBizRequestId() {
        return this.bizRequestId;
    }

    public DirectRedeemVipMemberByMobileResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public DirectRedeemVipMemberByMobileResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public DirectRedeemVipMemberByMobileResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
