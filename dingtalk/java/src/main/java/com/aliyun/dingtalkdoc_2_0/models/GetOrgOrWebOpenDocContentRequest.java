// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetOrgOrWebOpenDocContentRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("generateCp")
    public Boolean generateCp;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("scopeType")
    public Integer scopeType;

    /**
     * <strong>example:</strong>
     * <p>markdown</p>
     */
    @NameInMap("targetFormat")
    public String targetFormat;

    public static GetOrgOrWebOpenDocContentRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOrgOrWebOpenDocContentRequest self = new GetOrgOrWebOpenDocContentRequest();
        return TeaModel.build(map, self);
    }

    public GetOrgOrWebOpenDocContentRequest setGenerateCp(Boolean generateCp) {
        this.generateCp = generateCp;
        return this;
    }
    public Boolean getGenerateCp() {
        return this.generateCp;
    }

    public GetOrgOrWebOpenDocContentRequest setScopeType(Integer scopeType) {
        this.scopeType = scopeType;
        return this;
    }
    public Integer getScopeType() {
        return this.scopeType;
    }

    public GetOrgOrWebOpenDocContentRequest setTargetFormat(String targetFormat) {
        this.targetFormat = targetFormat;
        return this;
    }
    public String getTargetFormat() {
        return this.targetFormat;
    }

}
