// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryUserAgreementResponseBody extends TeaModel {
    // 用户id
    @NameInMap("staffId")
    public String staffId;

    // 组织id
    @NameInMap("corpId")
    public String corpId;

    // 主机构id
    @NameInMap("instId")
    public String instId;

    // 子机构id
    @NameInMap("subInstId")
    public String subInstId;

    // 支付渠道
    @NameInMap("payChannel")
    public String payChannel;

    // 协议编号
    @NameInMap("agreementNo")
    public String agreementNo;

    // 实际支付账号（脱敏）
    @NameInMap("payChannelAccountNo")
    public String payChannelAccountNo;

    // 实际支付账户名（脱敏）
    @NameInMap("payChannelAccountName")
    public String payChannelAccountName;

    // 实际签约日期
    @NameInMap("gmtSign")
    public String gmtSign;

    // 签约状态
    @NameInMap("status")
    public String status;

    // 实际生效日期
    @NameInMap("gmtValid")
    public String gmtValid;

    // 实际过期日期
    @NameInMap("gmtExpire")
    public String gmtExpire;

    public static QueryUserAgreementResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserAgreementResponseBody self = new QueryUserAgreementResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserAgreementResponseBody setStaffId(String staffId) {
        this.staffId = staffId;
        return this;
    }
    public String getStaffId() {
        return this.staffId;
    }

    public QueryUserAgreementResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryUserAgreementResponseBody setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public QueryUserAgreementResponseBody setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public QueryUserAgreementResponseBody setPayChannel(String payChannel) {
        this.payChannel = payChannel;
        return this;
    }
    public String getPayChannel() {
        return this.payChannel;
    }

    public QueryUserAgreementResponseBody setAgreementNo(String agreementNo) {
        this.agreementNo = agreementNo;
        return this;
    }
    public String getAgreementNo() {
        return this.agreementNo;
    }

    public QueryUserAgreementResponseBody setPayChannelAccountNo(String payChannelAccountNo) {
        this.payChannelAccountNo = payChannelAccountNo;
        return this;
    }
    public String getPayChannelAccountNo() {
        return this.payChannelAccountNo;
    }

    public QueryUserAgreementResponseBody setPayChannelAccountName(String payChannelAccountName) {
        this.payChannelAccountName = payChannelAccountName;
        return this;
    }
    public String getPayChannelAccountName() {
        return this.payChannelAccountName;
    }

    public QueryUserAgreementResponseBody setGmtSign(String gmtSign) {
        this.gmtSign = gmtSign;
        return this;
    }
    public String getGmtSign() {
        return this.gmtSign;
    }

    public QueryUserAgreementResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public QueryUserAgreementResponseBody setGmtValid(String gmtValid) {
        this.gmtValid = gmtValid;
        return this;
    }
    public String getGmtValid() {
        return this.gmtValid;
    }

    public QueryUserAgreementResponseBody setGmtExpire(String gmtExpire) {
        this.gmtExpire = gmtExpire;
        return this;
    }
    public String getGmtExpire() {
        return this.gmtExpire;
    }

}
