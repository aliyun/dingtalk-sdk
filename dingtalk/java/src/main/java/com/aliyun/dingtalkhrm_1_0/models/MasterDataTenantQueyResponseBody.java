// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataTenantQueyResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<MasterDataTenantQueyResponseBodyResult> result;

    public static MasterDataTenantQueyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MasterDataTenantQueyResponseBody self = new MasterDataTenantQueyResponseBody();
        return TeaModel.build(map, self);
    }

    public MasterDataTenantQueyResponseBody setResult(java.util.List<MasterDataTenantQueyResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<MasterDataTenantQueyResponseBodyResult> getResult() {
        return this.result;
    }

    public static class MasterDataTenantQueyResponseBodyResult extends TeaModel {
        @NameInMap("hasData")
        public Boolean hasData;

        @NameInMap("integrateDataAuth")
        public Boolean integrateDataAuth;

        @NameInMap("name")
        public String name;

        @NameInMap("readAuth")
        public Boolean readAuth;

        @NameInMap("tenantId")
        public Long tenantId;

        @NameInMap("type")
        public Integer type;

        public static MasterDataTenantQueyResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            MasterDataTenantQueyResponseBodyResult self = new MasterDataTenantQueyResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public MasterDataTenantQueyResponseBodyResult setHasData(Boolean hasData) {
            this.hasData = hasData;
            return this;
        }
        public Boolean getHasData() {
            return this.hasData;
        }

        public MasterDataTenantQueyResponseBodyResult setIntegrateDataAuth(Boolean integrateDataAuth) {
            this.integrateDataAuth = integrateDataAuth;
            return this;
        }
        public Boolean getIntegrateDataAuth() {
            return this.integrateDataAuth;
        }

        public MasterDataTenantQueyResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public MasterDataTenantQueyResponseBodyResult setReadAuth(Boolean readAuth) {
            this.readAuth = readAuth;
            return this;
        }
        public Boolean getReadAuth() {
            return this.readAuth;
        }

        public MasterDataTenantQueyResponseBodyResult setTenantId(Long tenantId) {
            this.tenantId = tenantId;
            return this;
        }
        public Long getTenantId() {
            return this.tenantId;
        }

        public MasterDataTenantQueyResponseBodyResult setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

}
