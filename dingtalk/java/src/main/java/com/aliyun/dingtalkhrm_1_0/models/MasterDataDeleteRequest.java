// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataDeleteRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<MasterDataDeleteRequestBody> body;

    @NameInMap("tenantId")
    public Long tenantId;

    public static MasterDataDeleteRequest build(java.util.Map<String, ?> map) throws Exception {
        MasterDataDeleteRequest self = new MasterDataDeleteRequest();
        return TeaModel.build(map, self);
    }

    public MasterDataDeleteRequest setBody(java.util.List<MasterDataDeleteRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<MasterDataDeleteRequestBody> getBody() {
        return this.body;
    }

    public MasterDataDeleteRequest setTenantId(Long tenantId) {
        this.tenantId = tenantId;
        return this;
    }
    public Long getTenantId() {
        return this.tenantId;
    }

    public static class MasterDataDeleteRequestBodyFieldList extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("valueStr")
        public String valueStr;

        public static MasterDataDeleteRequestBodyFieldList build(java.util.Map<String, ?> map) throws Exception {
            MasterDataDeleteRequestBodyFieldList self = new MasterDataDeleteRequestBodyFieldList();
            return TeaModel.build(map, self);
        }

        public MasterDataDeleteRequestBodyFieldList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public MasterDataDeleteRequestBodyFieldList setValueStr(String valueStr) {
            this.valueStr = valueStr;
            return this;
        }
        public String getValueStr() {
            return this.valueStr;
        }

    }

    public static class MasterDataDeleteRequestBodyScope extends TeaModel {
        @NameInMap("scopeCode")
        public String scopeCode;

        @NameInMap("version")
        public Integer version;

        public static MasterDataDeleteRequestBodyScope build(java.util.Map<String, ?> map) throws Exception {
            MasterDataDeleteRequestBodyScope self = new MasterDataDeleteRequestBodyScope();
            return TeaModel.build(map, self);
        }

        public MasterDataDeleteRequestBodyScope setScopeCode(String scopeCode) {
            this.scopeCode = scopeCode;
            return this;
        }
        public String getScopeCode() {
            return this.scopeCode;
        }

        public MasterDataDeleteRequestBodyScope setVersion(Integer version) {
            this.version = version;
            return this;
        }
        public Integer getVersion() {
            return this.version;
        }

    }

    public static class MasterDataDeleteRequestBody extends TeaModel {
        @NameInMap("bizTime")
        public Long bizTime;

        @NameInMap("bizUk")
        public String bizUk;

        @NameInMap("entityCode")
        public String entityCode;

        @NameInMap("fieldList")
        public java.util.List<MasterDataDeleteRequestBodyFieldList> fieldList;

        @NameInMap("scope")
        public MasterDataDeleteRequestBodyScope scope;

        public static MasterDataDeleteRequestBody build(java.util.Map<String, ?> map) throws Exception {
            MasterDataDeleteRequestBody self = new MasterDataDeleteRequestBody();
            return TeaModel.build(map, self);
        }

        public MasterDataDeleteRequestBody setBizTime(Long bizTime) {
            this.bizTime = bizTime;
            return this;
        }
        public Long getBizTime() {
            return this.bizTime;
        }

        public MasterDataDeleteRequestBody setBizUk(String bizUk) {
            this.bizUk = bizUk;
            return this;
        }
        public String getBizUk() {
            return this.bizUk;
        }

        public MasterDataDeleteRequestBody setEntityCode(String entityCode) {
            this.entityCode = entityCode;
            return this;
        }
        public String getEntityCode() {
            return this.entityCode;
        }

        public MasterDataDeleteRequestBody setFieldList(java.util.List<MasterDataDeleteRequestBodyFieldList> fieldList) {
            this.fieldList = fieldList;
            return this;
        }
        public java.util.List<MasterDataDeleteRequestBodyFieldList> getFieldList() {
            return this.fieldList;
        }

        public MasterDataDeleteRequestBody setScope(MasterDataDeleteRequestBodyScope scope) {
            this.scope = scope;
            return this;
        }
        public MasterDataDeleteRequestBodyScope getScope() {
            return this.scope;
        }

    }

}
