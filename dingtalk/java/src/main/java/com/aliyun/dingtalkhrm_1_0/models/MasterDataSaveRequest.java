// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataSaveRequest extends TeaModel {
    // 主数据
    @NameInMap("body")
    public java.util.List<MasterDataSaveRequestBody> body;

    // 租户id
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
        // 字段名
        @NameInMap("name")
        public String name;

        // 字段string值
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
        // 业务域code，如PERFORMANCE，系统分配
        @NameInMap("scopeCode")
        public String scopeCode;

        // 业务域版本，接入时系统分配，默认传1
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
        // 数据变更时间戳，用以保证更新操作的顺序性
        @NameInMap("bizTime")
        public Long bizTime;

        // 数据流水唯一标识，如流水号，用以唯一确认一条写入数据
        @NameInMap("bizUk")
        public String bizUk;

        // 业务域下的细分领域实体
        @NameInMap("entityCode")
        public String entityCode;

        // 数据字段列表
        @NameInMap("fieldList")
        public java.util.List<MasterDataSaveRequestBodyFieldList> fieldList;

        // 业务域描述，系统分配
        @NameInMap("scope")
        public MasterDataSaveRequestBodyScope scope;

        // 员工id
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
