// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddCustomerTrackRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="http://******">华佗</a>创建了合同：<strong>今日合同</strong></p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>fb037d68-c1bd-4be2-8c3b-6739261d1332</p>
     */
    @NameInMap("customerId")
    public String customerId;

    /**
     * <strong>example:</strong>
     * <p>{&quot;bizId&quot;:&quot;1&quot;}</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("extraBizInfo")
    public String extraBizInfo;

    /**
     * <strong>example:</strong>
     * <p>fb037d68-c1bd-4be2-8c3b-6739261d1332-1</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("idempotentKey")
    public String idempotentKey;

    /**
     * <strong>example:</strong>
     * <p><a href="http://******">华佗</a>创建了合同：<strong>今日合同</strong></p>
     */
    @NameInMap("maskedContent")
    public String maskedContent;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manager1120</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>crm_customer</p>
     */
    @NameInMap("relationType")
    public String relationType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>创建合同</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>212</p>
     */
    @NameInMap("type")
    public Integer type;

    public static AddCustomerTrackRequest build(java.util.Map<String, ?> map) throws Exception {
        AddCustomerTrackRequest self = new AddCustomerTrackRequest();
        return TeaModel.build(map, self);
    }

    public AddCustomerTrackRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public AddCustomerTrackRequest setCustomerId(String customerId) {
        this.customerId = customerId;
        return this;
    }
    public String getCustomerId() {
        return this.customerId;
    }

    public AddCustomerTrackRequest setExtraBizInfo(String extraBizInfo) {
        this.extraBizInfo = extraBizInfo;
        return this;
    }
    public String getExtraBizInfo() {
        return this.extraBizInfo;
    }

    public AddCustomerTrackRequest setIdempotentKey(String idempotentKey) {
        this.idempotentKey = idempotentKey;
        return this;
    }
    public String getIdempotentKey() {
        return this.idempotentKey;
    }

    public AddCustomerTrackRequest setMaskedContent(String maskedContent) {
        this.maskedContent = maskedContent;
        return this;
    }
    public String getMaskedContent() {
        return this.maskedContent;
    }

    public AddCustomerTrackRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public AddCustomerTrackRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

    public AddCustomerTrackRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public AddCustomerTrackRequest setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

}
