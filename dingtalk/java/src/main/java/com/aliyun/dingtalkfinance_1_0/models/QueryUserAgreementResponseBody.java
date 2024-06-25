// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryUserAgreementResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>201220123212312</p>
     */
    @NameInMap("agreementNo")
    public String agreementNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding123123234234</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2021-11-11 10:10:10</p>
     */
    @NameInMap("gmtExpire")
    public String gmtExpire;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2021-11-11 10:10:10</p>
     */
    @NameInMap("gmtSign")
    public String gmtSign;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2021-11-11 10:10:10</p>
     */
    @NameInMap("gmtValid")
    public String gmtValid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2021000001</p>
     */
    @NameInMap("instId")
    public String instId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ALIPAY</p>
     */
    @NameInMap("payChannel")
    public String payChannel;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>*川</p>
     */
    @NameInMap("payChannelAccountName")
    public String payChannelAccountName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>139*****0</p>
     */
    @NameInMap("payChannelAccountNo")
    public String payChannelAccountNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SUCCESS</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>101</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>54646545</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryUserAgreementResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserAgreementResponseBody self = new QueryUserAgreementResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserAgreementResponseBody setAgreementNo(String agreementNo) {
        this.agreementNo = agreementNo;
        return this;
    }
    public String getAgreementNo() {
        return this.agreementNo;
    }

    public QueryUserAgreementResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryUserAgreementResponseBody setGmtExpire(String gmtExpire) {
        this.gmtExpire = gmtExpire;
        return this;
    }
    public String getGmtExpire() {
        return this.gmtExpire;
    }

    public QueryUserAgreementResponseBody setGmtSign(String gmtSign) {
        this.gmtSign = gmtSign;
        return this;
    }
    public String getGmtSign() {
        return this.gmtSign;
    }

    public QueryUserAgreementResponseBody setGmtValid(String gmtValid) {
        this.gmtValid = gmtValid;
        return this;
    }
    public String getGmtValid() {
        return this.gmtValid;
    }

    public QueryUserAgreementResponseBody setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public QueryUserAgreementResponseBody setPayChannel(String payChannel) {
        this.payChannel = payChannel;
        return this;
    }
    public String getPayChannel() {
        return this.payChannel;
    }

    public QueryUserAgreementResponseBody setPayChannelAccountName(String payChannelAccountName) {
        this.payChannelAccountName = payChannelAccountName;
        return this;
    }
    public String getPayChannelAccountName() {
        return this.payChannelAccountName;
    }

    public QueryUserAgreementResponseBody setPayChannelAccountNo(String payChannelAccountNo) {
        this.payChannelAccountNo = payChannelAccountNo;
        return this;
    }
    public String getPayChannelAccountNo() {
        return this.payChannelAccountNo;
    }

    public QueryUserAgreementResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public QueryUserAgreementResponseBody setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public QueryUserAgreementResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
