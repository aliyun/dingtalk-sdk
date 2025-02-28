// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class CreateCollectionOrderRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0.01</p>
     */
    @NameInMap("amount")
    public String amount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>a</p>
     */
    @NameInMap("collectionInfoId")
    public String collectionInfoId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>a</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    /**
     * <strong>example:</strong>
     * <p>收款</p>
     */
    @NameInMap("remark")
    public String remark;

    public static CreateCollectionOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCollectionOrderRequest self = new CreateCollectionOrderRequest();
        return TeaModel.build(map, self);
    }

    public CreateCollectionOrderRequest setAmount(String amount) {
        this.amount = amount;
        return this;
    }
    public String getAmount() {
        return this.amount;
    }

    public CreateCollectionOrderRequest setCollectionInfoId(String collectionInfoId) {
        this.collectionInfoId = collectionInfoId;
        return this;
    }
    public String getCollectionInfoId() {
        return this.collectionInfoId;
    }

    public CreateCollectionOrderRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public CreateCollectionOrderRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

}
