// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AddAccountMappingRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>BizName1</p>
     */
    @NameInMap("domain")
    public String domain;

    /**
     * <strong>example:</strong>
     * <p>单key和单value的长度不超过100</p>
     */
    @NameInMap("extension")
    public java.util.Map<String, String> extension;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>o_123</p>
     */
    @NameInMap("outId")
    public String outId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>t_123,如果不区分，填写固定值</p>
     */
    @NameInMap("outTenantId")
    public String outTenantId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>id_123</p>
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
