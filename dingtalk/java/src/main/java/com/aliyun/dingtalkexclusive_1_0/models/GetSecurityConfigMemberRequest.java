// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetSecurityConfigMemberRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ctrl.xxx</p>
     */
    @NameInMap("configKey")
    public String configKey;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextToken")
    public Float nextToken;

    public static GetSecurityConfigMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSecurityConfigMemberRequest self = new GetSecurityConfigMemberRequest();
        return TeaModel.build(map, self);
    }

    public GetSecurityConfigMemberRequest setConfigKey(String configKey) {
        this.configKey = configKey;
        return this;
    }
    public String getConfigKey() {
        return this.configKey;
    }

    public GetSecurityConfigMemberRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetSecurityConfigMemberRequest setNextToken(Float nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Float getNextToken() {
        return this.nextToken;
    }

}
