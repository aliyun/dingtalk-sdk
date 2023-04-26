// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddCustomerTrackRequest extends TeaModel {
    @NameInMap("content")
    public String content;

    @NameInMap("customerId")
    public String customerId;

    @NameInMap("extraBizInfo")
    public String extraBizInfo;

    @NameInMap("idempotentKey")
    public String idempotentKey;

    @NameInMap("maskedContent")
    public String maskedContent;

    @NameInMap("operatorUserId")
    public String operatorUserId;

    @NameInMap("relationType")
    public String relationType;

    @NameInMap("title")
    public String title;

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
