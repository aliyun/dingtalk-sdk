// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryAcrossCloudStroageConfigsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetCloudType")
    public Integer targetCloudType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static QueryAcrossCloudStroageConfigsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAcrossCloudStroageConfigsRequest self = new QueryAcrossCloudStroageConfigsRequest();
        return TeaModel.build(map, self);
    }

    public QueryAcrossCloudStroageConfigsRequest setTargetCloudType(Integer targetCloudType) {
        this.targetCloudType = targetCloudType;
        return this;
    }
    public Integer getTargetCloudType() {
        return this.targetCloudType;
    }

    public QueryAcrossCloudStroageConfigsRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
