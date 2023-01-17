// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class GetActionDetailResponseBody extends TeaModel {
    /**
     * <p>连接资产标识</p>
     */
    @NameInMap("connectAssetUri")
    public String connectAssetUri;

    /**
     * <p>调用时以JsonSchema描述的入参格式</p>
     */
    @NameInMap("inputSchema")
    public String inputSchema;

    /**
     * <p>执行动作集成配置信息</p>
     */
    @NameInMap("integrationConfig")
    public GetActionDetailResponseBodyIntegrationConfig integrationConfig;

    /**
     * <p>执行动作的名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>调用时以JsonSchema描述的出参格式</p>
     */
    @NameInMap("outputSchema")
    public String outputSchema;

    /**
     * <p>执行动作的ID</p>
     */
    @NameInMap("refId")
    public String refId;

    /**
     * <p>执行动作提供组织</p>
     */
    @NameInMap("refProviderCorpId")
    public String refProviderCorpId;

    /**
     * <p>连接资产类型</p>
     */
    @NameInMap("refType")
    public String refType;

    public static GetActionDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetActionDetailResponseBody self = new GetActionDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetActionDetailResponseBody setConnectAssetUri(String connectAssetUri) {
        this.connectAssetUri = connectAssetUri;
        return this;
    }
    public String getConnectAssetUri() {
        return this.connectAssetUri;
    }

    public GetActionDetailResponseBody setInputSchema(String inputSchema) {
        this.inputSchema = inputSchema;
        return this;
    }
    public String getInputSchema() {
        return this.inputSchema;
    }

    public GetActionDetailResponseBody setIntegrationConfig(GetActionDetailResponseBodyIntegrationConfig integrationConfig) {
        this.integrationConfig = integrationConfig;
        return this;
    }
    public GetActionDetailResponseBodyIntegrationConfig getIntegrationConfig() {
        return this.integrationConfig;
    }

    public GetActionDetailResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetActionDetailResponseBody setOutputSchema(String outputSchema) {
        this.outputSchema = outputSchema;
        return this;
    }
    public String getOutputSchema() {
        return this.outputSchema;
    }

    public GetActionDetailResponseBody setRefId(String refId) {
        this.refId = refId;
        return this;
    }
    public String getRefId() {
        return this.refId;
    }

    public GetActionDetailResponseBody setRefProviderCorpId(String refProviderCorpId) {
        this.refProviderCorpId = refProviderCorpId;
        return this;
    }
    public String getRefProviderCorpId() {
        return this.refProviderCorpId;
    }

    public GetActionDetailResponseBody setRefType(String refType) {
        this.refType = refType;
        return this;
    }
    public String getRefType() {
        return this.refType;
    }

    public static class GetActionDetailResponseBodyIntegrationConfigCategoryNames extends TeaModel {
        /**
         * <p>类目名称</p>
         */
        @NameInMap("value")
        public String value;

        public static GetActionDetailResponseBodyIntegrationConfigCategoryNames build(java.util.Map<String, ?> map) throws Exception {
            GetActionDetailResponseBodyIntegrationConfigCategoryNames self = new GetActionDetailResponseBodyIntegrationConfigCategoryNames();
            return TeaModel.build(map, self);
        }

        public GetActionDetailResponseBodyIntegrationConfigCategoryNames setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetActionDetailResponseBodyIntegrationConfigProps extends TeaModel {
        /**
         * <p>配置的KEY值</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <p>配置的属性值</p>
         */
        @NameInMap("value")
        public String value;

        public static GetActionDetailResponseBodyIntegrationConfigProps build(java.util.Map<String, ?> map) throws Exception {
            GetActionDetailResponseBodyIntegrationConfigProps self = new GetActionDetailResponseBodyIntegrationConfigProps();
            return TeaModel.build(map, self);
        }

        public GetActionDetailResponseBodyIntegrationConfigProps setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public GetActionDetailResponseBodyIntegrationConfigProps setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetActionDetailResponseBodyIntegrationConfig extends TeaModel {
        /**
         * <p>类目配置</p>
         */
        @NameInMap("categoryNames")
        public java.util.List<GetActionDetailResponseBodyIntegrationConfigCategoryNames> categoryNames;

        /**
         * <p>集成对象的名称</p>
         */
        @NameInMap("entityName")
        public String entityName;

        /**
         * <p>其它额外属性</p>
         */
        @NameInMap("props")
        public java.util.List<GetActionDetailResponseBodyIntegrationConfigProps> props;

        public static GetActionDetailResponseBodyIntegrationConfig build(java.util.Map<String, ?> map) throws Exception {
            GetActionDetailResponseBodyIntegrationConfig self = new GetActionDetailResponseBodyIntegrationConfig();
            return TeaModel.build(map, self);
        }

        public GetActionDetailResponseBodyIntegrationConfig setCategoryNames(java.util.List<GetActionDetailResponseBodyIntegrationConfigCategoryNames> categoryNames) {
            this.categoryNames = categoryNames;
            return this;
        }
        public java.util.List<GetActionDetailResponseBodyIntegrationConfigCategoryNames> getCategoryNames() {
            return this.categoryNames;
        }

        public GetActionDetailResponseBodyIntegrationConfig setEntityName(String entityName) {
            this.entityName = entityName;
            return this;
        }
        public String getEntityName() {
            return this.entityName;
        }

        public GetActionDetailResponseBodyIntegrationConfig setProps(java.util.List<GetActionDetailResponseBodyIntegrationConfigProps> props) {
            this.props = props;
            return this;
        }
        public java.util.List<GetActionDetailResponseBodyIntegrationConfigProps> getProps() {
            return this.props;
        }

    }

}
