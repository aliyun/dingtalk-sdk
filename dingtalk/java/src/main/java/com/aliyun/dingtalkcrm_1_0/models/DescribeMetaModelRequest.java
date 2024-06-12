// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DescribeMetaModelRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizTypes")
    public java.util.List<String> bizTypes;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tenant")
    public String tenant;

    public static DescribeMetaModelRequest build(java.util.Map<String, ?> map) throws Exception {
        DescribeMetaModelRequest self = new DescribeMetaModelRequest();
        return TeaModel.build(map, self);
    }

    public DescribeMetaModelRequest setBizTypes(java.util.List<String> bizTypes) {
        this.bizTypes = bizTypes;
        return this;
    }
    public java.util.List<String> getBizTypes() {
        return this.bizTypes;
    }

    public DescribeMetaModelRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public DescribeMetaModelRequest setTenant(String tenant) {
        this.tenant = tenant;
        return this;
    }
    public String getTenant() {
        return this.tenant;
    }

}
