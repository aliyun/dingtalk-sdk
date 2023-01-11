// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryUserAgreementResponseBody extends TeaModel {
    /**
     * <p>协议编号</p>
     */
    @NameInMap("agreementNo")
    public String agreementNo;

    /**
     * <p>组织id</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>实际过期日期</p>
     */
    @NameInMap("gmtExpire")
    public String gmtExpire;

    /**
     * <p>实际签约日期</p>
     */
    @NameInMap("gmtSign")
    public String gmtSign;

    /**
     * <p>实际生效日期</p>
     */
    @NameInMap("gmtValid")
    public String gmtValid;

    /**
     * <p>主机构id</p>
     */
    @NameInMap("instId")
    public String instId;

    /**
     * <p>支付渠道</p>
     */
    @NameInMap("payChannel")
    public String payChannel;

    /**
     * <p>实际支付账户名（脱敏）</p>
     */
    @NameInMap("payChannelAccountName")
    public String payChannelAccountName;

    /**
     * <p>实际支付账号（脱敏）</p>
     */
    @NameInMap("payChannelAccountNo")
    public String payChannelAccountNo;

    /**
     * <p>签约状态</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>子机构id</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    /**
     * <p>用户id</p>
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
