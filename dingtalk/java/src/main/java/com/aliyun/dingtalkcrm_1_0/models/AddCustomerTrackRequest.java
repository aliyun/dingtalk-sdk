// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddCustomerTrackRequest extends TeaModel {
    // 动态内容,markdown格式
    @NameInMap("content")
    public String content;

    // 客户ID
    @NameInMap("customerId")
    public String customerId;

    // 任意业务自定义的数据，可空
    @NameInMap("extraBizInfo")
    public String extraBizInfo;

    // 幂等key，5分钟内避免重复写入，保证幂等，可空
    @NameInMap("idempotentKey")
    public String idempotentKey;

    // 操作人userId
    @NameInMap("operatorUserId")
    public String operatorUserId;

    // 关系类型
    @NameInMap("relationType")
    public String relationType;

    // 动态标题
    @NameInMap("title")
    public String title;

    // 动态的类型
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
