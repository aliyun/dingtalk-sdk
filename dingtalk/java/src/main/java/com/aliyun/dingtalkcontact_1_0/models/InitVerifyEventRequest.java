// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class InitVerifyEventRequest extends TeaModel {
    @NameInMap("callerDeviceId")
    public String callerDeviceId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("factorCodeList")
    public java.util.List<String> factorCodeList;

    @NameInMap("state")
    public String state;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static InitVerifyEventRequest build(java.util.Map<String, ?> map) throws Exception {
        InitVerifyEventRequest self = new InitVerifyEventRequest();
        return TeaModel.build(map, self);
    }

    public InitVerifyEventRequest setCallerDeviceId(String callerDeviceId) {
        this.callerDeviceId = callerDeviceId;
        return this;
    }
    public String getCallerDeviceId() {
        return this.callerDeviceId;
    }

    public InitVerifyEventRequest setFactorCodeList(java.util.List<String> factorCodeList) {
        this.factorCodeList = factorCodeList;
        return this;
    }
    public java.util.List<String> getFactorCodeList() {
        return this.factorCodeList;
    }

    public InitVerifyEventRequest setState(String state) {
        this.state = state;
        return this;
    }
    public String getState() {
        return this.state;
    }

    public InitVerifyEventRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
