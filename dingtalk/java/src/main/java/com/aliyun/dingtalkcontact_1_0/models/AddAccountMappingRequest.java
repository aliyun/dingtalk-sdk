// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AddAccountMappingRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("domain")
    public String domain;

    @NameInMap("extension")
    public java.util.Map<String, String> extension;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("outId")
    public String outId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("outTenantId")
    public String outTenantId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static AddAccountMappingRequest build(java.util.Map<String, ?> map) throws Exception {
        AddAccountMappingRequest self = new AddAccountMappingRequest();
        return TeaModel.build(map, self);
    }

    public AddAccountMappingRequest setDomain(String domain) {
        this.domain = domain;
        return this;
    }
    public String getDomain() {
        return this.domain;
    }

    public AddAccountMappingRequest setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

    public AddAccountMappingRequest setOutId(String outId) {
        this.outId = outId;
        return this;
    }
    public String getOutId() {
        return this.outId;
    }

    public AddAccountMappingRequest setOutTenantId(String outTenantId) {
        this.outTenantId = outTenantId;
        return this;
    }
    public String getOutTenantId() {
        return this.outTenantId;
    }

    public AddAccountMappingRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
