// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncBusinessSignInfoRequest extends TeaModel {
    // 签约企业所支持的订单类目，如机票、酒店、火车票、打车。
    // 枚举值如下：
    // ["HOTEL","FLIGHT","TAXI","TRAIN"]
    @NameInMap("bizTypeList")
    public java.util.List<String> bizTypeList;

    // 开通企业支付的时间戳，毫秒
    // 
    @NameInMap("gmtOrgPay")
    public String gmtOrgPay;

    // 签约时间戳，毫秒
    // 
    @NameInMap("gmtSign")
    public String gmtSign;

    // 开通企业支付状态
    // 
    @NameInMap("orgPayStatus")
    public String orgPayStatus;

    // 企业签约状态
    @NameInMap("signStatus")
    public String signStatus;

    // 签约企业corpId
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static SyncBusinessSignInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncBusinessSignInfoRequest self = new SyncBusinessSignInfoRequest();
        return TeaModel.build(map, self);
    }

    public SyncBusinessSignInfoRequest setBizTypeList(java.util.List<String> bizTypeList) {
        this.bizTypeList = bizTypeList;
        return this;
    }
    public java.util.List<String> getBizTypeList() {
        return this.bizTypeList;
    }

    public SyncBusinessSignInfoRequest setGmtOrgPay(String gmtOrgPay) {
        this.gmtOrgPay = gmtOrgPay;
        return this;
    }
    public String getGmtOrgPay() {
        return this.gmtOrgPay;
    }

    public SyncBusinessSignInfoRequest setGmtSign(String gmtSign) {
        this.gmtSign = gmtSign;
        return this;
    }
    public String getGmtSign() {
        return this.gmtSign;
    }

    public SyncBusinessSignInfoRequest setOrgPayStatus(String orgPayStatus) {
        this.orgPayStatus = orgPayStatus;
        return this;
    }
    public String getOrgPayStatus() {
        return this.orgPayStatus;
    }

    public SyncBusinessSignInfoRequest setSignStatus(String signStatus) {
        this.signStatus = signStatus;
        return this;
    }
    public String getSignStatus() {
        return this.signStatus;
    }

    public SyncBusinessSignInfoRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
