// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDatasGetRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>uk1231</p>
     */
    @NameInMap("objId")
    public String objId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PERFORMANCE</p>
     */
    @NameInMap("scopeCode")
    public String scopeCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>3</p>
     */
    @NameInMap("tenantId")
    public Long tenantId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>base</p>
     */
    @NameInMap("viewEntityCode")
    public String viewEntityCode;

    public static MasterDatasGetRequest build(java.util.Map<String, ?> map) throws Exception {
        MasterDatasGetRequest self = new MasterDatasGetRequest();
        return TeaModel.build(map, self);
    }

    public MasterDatasGetRequest setObjId(String objId) {
        this.objId = objId;
        return this;
    }
    public String getObjId() {
        return this.objId;
    }

    public MasterDatasGetRequest setScopeCode(String scopeCode) {
        this.scopeCode = scopeCode;
        return this;
    }
    public String getScopeCode() {
        return this.scopeCode;
    }

    public MasterDatasGetRequest setTenantId(Long tenantId) {
        this.tenantId = tenantId;
        return this;
    }
    public Long getTenantId() {
        return this.tenantId;
    }

    public MasterDatasGetRequest setViewEntityCode(String viewEntityCode) {
        this.viewEntityCode = viewEntityCode;
        return this;
    }
    public String getViewEntityCode() {
        return this.viewEntityCode;
    }

}
