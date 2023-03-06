// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddCustomerTrackRequest extends TeaModel {
    /**
     * <p>动态内容（明文未脱敏内容），markdown格式，必填。客户动态列表页的展示规则：如果有maskedContent字段对应动态脱敏内容则优先展示动态脱敏内容，否则优先展示本content字段内容。当显示了动态脱敏内容时用户可以点击页面按钮来查看动态未脱敏明文内容。</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>客户ID</p>
     */
    @NameInMap("customerId")
    public String customerId;

    /**
     * <p>任意业务自定义的数据，可空</p>
     */
    @NameInMap("extraBizInfo")
    public String extraBizInfo;

    /**
     * <p>幂等key，5分钟内避免重复写入，保证幂等，可空</p>
     */
    @NameInMap("idempotentKey")
    public String idempotentKey;

    /**
     * <p>动态脱敏内容，markdown格式，非必填。客户动态列表页的展示规则：如果本字段有值，则优先展示本字段的动态脱敏内容，否则展示content字段内容。当显示了动态脱敏内容时用户可以点击页面按钮来查看动态未脱敏明文内容。</p>
     */
    @NameInMap("maskedContent")
    public String maskedContent;

    /**
     * <p>操作人userId</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>关系类型</p>
     */
    @NameInMap("relationType")
    public String relationType;

    /**
     * <p>动态标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>动态的类型</p>
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
