// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryVerifyResultResponseBody extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("factorCode")
    public String factorCode;

    @NameInMap("factorDesc")
    public String factorDesc;

    @NameInMap("resultCode")
    public String resultCode;

    @NameInMap("resultDesc")
    public String resultDesc;

    @NameInMap("state")
    public String state;

    @NameInMap("userId")
    public String userId;

    @NameInMap("verifyTimestamp")
    public Long verifyTimestamp;

    public static QueryVerifyResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryVerifyResultResponseBody self = new QueryVerifyResultResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryVerifyResultResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryVerifyResultResponseBody setFactorCode(String factorCode) {
        this.factorCode = factorCode;
        return this;
    }
    public String getFactorCode() {
        return this.factorCode;
    }

    public QueryVerifyResultResponseBody setFactorDesc(String factorDesc) {
        this.factorDesc = factorDesc;
        return this;
    }
    public String getFactorDesc() {
        return this.factorDesc;
    }

    public QueryVerifyResultResponseBody setResultCode(String resultCode) {
        this.resultCode = resultCode;
        return this;
    }
    public String getResultCode() {
        return this.resultCode;
    }

    public QueryVerifyResultResponseBody setResultDesc(String resultDesc) {
        this.resultDesc = resultDesc;
        return this;
    }
    public String getResultDesc() {
        return this.resultDesc;
    }

    public QueryVerifyResultResponseBody setState(String state) {
        this.state = state;
        return this;
    }
    public String getState() {
        return this.state;
    }

    public QueryVerifyResultResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public QueryVerifyResultResponseBody setVerifyTimestamp(Long verifyTimestamp) {
        this.verifyTimestamp = verifyTimestamp;
        return this;
    }
    public Long getVerifyTimestamp() {
        return this.verifyTimestamp;
    }

}
