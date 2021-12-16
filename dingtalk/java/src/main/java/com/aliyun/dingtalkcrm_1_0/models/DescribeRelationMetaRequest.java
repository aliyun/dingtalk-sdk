// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DescribeRelationMetaRequest extends TeaModel {
    @NameInMap("tenant")
    public String tenant;

    @NameInMap("operatorUserId")
    public String operatorUserId;

    @NameInMap("relationTypes")
    public java.util.List<String> relationTypes;

    public static DescribeRelationMetaRequest build(java.util.Map<String, ?> map) throws Exception {
        DescribeRelationMetaRequest self = new DescribeRelationMetaRequest();
        return TeaModel.build(map, self);
    }

    public DescribeRelationMetaRequest setTenant(String tenant) {
        this.tenant = tenant;
        return this;
    }
    public String getTenant() {
        return this.tenant;
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

}
