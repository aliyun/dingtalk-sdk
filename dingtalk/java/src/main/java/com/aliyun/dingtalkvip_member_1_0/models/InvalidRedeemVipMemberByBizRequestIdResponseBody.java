// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvip_member_1_0.models;

import com.aliyun.tea.*;

public class InvalidRedeemVipMemberByBizRequestIdResponseBody extends TeaModel {
    @NameInMap("bizRequestId")
    public String bizRequestId;

    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public String result;

    public static InvalidRedeemVipMemberByBizRequestIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InvalidRedeemVipMemberByBizRequestIdResponseBody self = new InvalidRedeemVipMemberByBizRequestIdResponseBody();
        return TeaModel.build(map, self);
    }

    public InvalidRedeemVipMemberByBizRequestIdResponseBody setBizRequestId(String bizRequestId) {
        this.bizRequestId = bizRequestId;
        return this;
    }
    public String getBizRequestId() {
        return this.bizRequestId;
    }

    public InvalidRedeemVipMemberByBizRequestIdResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public InvalidRedeemVipMemberByBizRequestIdResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public InvalidRedeemVipMemberByBizRequestIdResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
