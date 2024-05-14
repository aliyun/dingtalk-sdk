// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmProcessRegularRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operationId")
    public String operationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("regularDate")
    public Long regularDate;

    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static HrmProcessRegularRequest build(java.util.Map<String, ?> map) throws Exception {
        HrmProcessRegularRequest self = new HrmProcessRegularRequest();
        return TeaModel.build(map, self);
    }

    public HrmProcessRegularRequest setOperationId(String operationId) {
        this.operationId = operationId;
        return this;
    }
    public String getOperationId() {
        return this.operationId;
    }

    public HrmProcessRegularRequest setRegularDate(Long regularDate) {
        this.regularDate = regularDate;
        return this;
    }
    public Long getRegularDate() {
        return this.regularDate;
    }

    public HrmProcessRegularRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public HrmProcessRegularRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
