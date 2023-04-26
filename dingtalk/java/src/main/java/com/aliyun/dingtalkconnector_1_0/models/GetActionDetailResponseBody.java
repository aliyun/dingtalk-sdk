// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class GetActionDetailResponseBody extends TeaModel {
    @NameInMap("connectAssetUri")
    public String connectAssetUri;

    @NameInMap("inputSchema")
    public String inputSchema;

    @NameInMap("integrationConfig")
    public GetActionDetailResponseBodyIntegrationConfig integrationConfig;

    @NameInMap("name")
    public String name;

    @NameInMap("outputSchema")
    public String outputSchema;

    @NameInMap("refId")
    public String refId;

    @NameInMap("refProviderCorpId")
    public String refProviderCorpId;

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
        @NameInMap("key")
        public String key;

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
        @NameInMap("categoryNames")
        public java.util.List<GetActionDetailResponseBodyIntegrationConfigCategoryNames> categoryNames;

        @NameInMap("entityName")
        public String entityName;

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
