// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UnsignUserAgreementRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>23021_12342134</p>
     */
    @NameInMap("agreementNo")
    public String agreementNo;

    /**
     * <strong>example:</strong>
     * <p>TRADE</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <strong>example:</strong>
     * <p>WITHHOLDING</p>
     */
    @NameInMap("bizScene")
    public String bizScene;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>202111090001</p>
     */
    @NameInMap("instId")
    public String instId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1001</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2120493284</p>
     */
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
