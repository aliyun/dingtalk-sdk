// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UnsignUserAgreementRequest extends TeaModel {
    // 协议编号
    @NameInMap("agreementNo")
    public String agreementNo;

    // 业务代码
    @NameInMap("bizCode")
    public String bizCode;

    // 业务场景
    @NameInMap("bizScene")
    public String bizScene;

    // 主机构编号
    @NameInMap("instId")
    public String instId;

    // 子机构编号
    @NameInMap("subInstId")
    public String subInstId;

    // 付款人staffId
    @NameInMap("userId")
    public String userId;

    public static UnsignUserAgreementRequest build(java.util.Map<String, ?> map) throws Exception {
        UnsignUserAgreementRequest self = new UnsignUserAgreementRequest();
        return TeaModel.build(map, self);
    }

    public UnsignUserAgreementRequest setAgreementNo(String agreementNo) {
        this.agreementNo = agreementNo;
        return this;
    }
    public String getAgreementNo() {
        return this.agreementNo;
    }

    public UnsignUserAgreementRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public UnsignUserAgreementRequest setBizScene(String bizScene) {
        this.bizScene = bizScene;
        return this;
    }
    public String getBizScene() {
        return this.bizScene;
    }

    public UnsignUserAgreementRequest setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public UnsignUserAgreementRequest setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public UnsignUserAgreementRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
