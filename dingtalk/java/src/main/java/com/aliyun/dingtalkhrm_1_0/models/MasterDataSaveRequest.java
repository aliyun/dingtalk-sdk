// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataSaveRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<MasterDataSaveRequestBody> body;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tenantId")
    public Long tenantId;

    public static MasterDataSaveRequest build(java.util.Map<String, ?> map) throws Exception {
        MasterDataSaveRequest self = new MasterDataSaveRequest();
        return TeaModel.build(map, self);
    }

    public MasterDataSaveRequest setBody(java.util.List<MasterDataSaveRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<MasterDataSaveRequestBody> getBody() {
        return this.body;
    }

    public MasterDataSaveRequest setTenantId(Long tenantId) {
        this.tenantId = tenantId;
        return this;
    }
    public Long getTenantId() {
        return this.tenantId;
    }

    public static class MasterDataSaveRequestBodyFieldList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("valueStr")
        public String valueStr;

        public static MasterDataSaveRequestBodyFieldList build(java.util.Map<String, ?> map) throws Exception {
            MasterDataSaveRequestBodyFieldList self = new MasterDataSaveRequestBodyFieldList();
            return TeaModel.build(map, self);
        }

        public MasterDataSaveRequestBodyFieldList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public MasterDataSaveRequestBodyFieldList setValueStr(String valueStr) {
            this.valueStr = valueStr;
            return this;
        }
        public String getValueStr() {
            return this.valueStr;
        }

    }

    public static class MasterDataSaveRequestBodyScope extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("scopeCode")
        public String scopeCode;

        @NameInMap("version")
        public Integer version;

        public static MasterDataSaveRequestBodyScope build(java.util.Map<String, ?> map) throws Exception {
            MasterDataSaveRequestBodyScope self = new MasterDataSaveRequestBodyScope();
            return TeaModel.build(map, self);
        }

        public MasterDataSaveRequestBodyScope setScopeCode(String scopeCode) {
            this.scopeCode = scopeCode;
            return this;
        }
        public String getScopeCode() {
            return this.scopeCode;
        }

        public MasterDataSaveRequestBodyScope setVersion(Integer version) {
            this.version = version;
            return this;
        }
        public Integer getVersion() {
            return this.version;
        }

    }

    public static class MasterDataSaveRequestBody extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizTime")
        public Long bizTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizUk")
        public String bizUk;

        @NameInMap("entityCode")
        public String entityCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldList")
        public java.util.List<MasterDataSaveRequestBodyFieldList> fieldList;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("scope")
        public MasterDataSaveRequestBodyScope scope;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userId")
        public String userId;

        public static MasterDataSaveRequestBody build(java.util.Map<String, ?> map) throws Exception {
            MasterDataSaveRequestBody self = new MasterDataSaveRequestBody();
            return TeaModel.build(map, self);
        }

        public MasterDataSaveRequestBody setBizTime(Long bizTime) {
            this.bizTime = bizTime;
            return this;
        }
        public Long getBizTime() {
            return this.bizTime;
        }

        public MasterDataSaveRequestBody setBizUk(String bizUk) {
            this.bizUk = bizUk;
            return this;
        }
        public String getBizUk() {
            return this.bizUk;
        }

        public MasterDataSaveRequestBody setEntityCode(String entityCode) {
            this.entityCode = entityCode;
            return this;
        }
        public String getEntityCode() {
            return this.entityCode;
        }

        public MasterDataSaveRequestBody setFieldList(java.util.List<MasterDataSaveRequestBodyFieldList> fieldList) {
            this.fieldList = fieldList;
            return this;
        }
        public java.util.List<MasterDataSaveRequestBodyFieldList> getFieldList() {
            return this.fieldList;
        }

        public MasterDataSaveRequestBody setScope(MasterDataSaveRequestBodyScope scope) {
            this.scope = scope;
            return this;
        }
        public MasterDataSaveRequestBodyScope getScope() {
            return this.scope;
        }

        public MasterDataSaveRequestBody setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
