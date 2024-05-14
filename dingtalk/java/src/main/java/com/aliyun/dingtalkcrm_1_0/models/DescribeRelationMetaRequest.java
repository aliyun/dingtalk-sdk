// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DescribeRelationMetaRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("relationTypes")
    public java.util.List<String> relationTypes;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tenant")
    public String tenant;

    public static DescribeRelationMetaRequest build(java.util.Map<String, ?> map) throws Exception {
        DescribeRelationMetaRequest self = new DescribeRelationMetaRequest();
        return TeaModel.build(map, self);
    }

    public DescribeRelationMetaRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public DescribeRelationMetaRequest setRelationTypes(java.util.List<String> relationTypes) {
        this.relationTypes = relationTypes;
        return this;
    }
    public java.util.List<String> getRelationTypes() {
        return this.relationTypes;
    }

    public DescribeRelationMetaRequest setTenant(String tenant) {
        this.tenant = tenant;
        return this;
    }
    public String getTenant() {
        return this.tenant;
    }

}
