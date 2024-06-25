// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class GetActionDetailResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>dca://ding32fff839a3e0105d.connect.dingtalk.com/ding32fff839a3e0105d/action/G-ACT-101FDEBD3C6E213DB474000P</p>
     */
    @NameInMap("connectAssetUri")
    public String connectAssetUri;

    /**
     * <strong>example:</strong>
     * <p>{&quot;title&quot;:&quot;A registration form&quot;,&quot;description&quot;:&quot;A simple form example.&quot;,&quot;type&quot;:&quot;object&quot;,&quot;required&quot;:[],&quot;properties&quot;:{&quot;password&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;title&quot;:&quot;Password&quot;,&quot;minLength&quot;:3},&quot;telephone&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;title&quot;:&quot;Telephone&quot;,&quot;minLength&quot;:10}}}</p>
     */
    @NameInMap("inputSchema")
    public String inputSchema;

    @NameInMap("integrationConfig")
    public GetActionDetailResponseBodyIntegrationConfig integrationConfig;

    /**
     * <strong>example:</strong>
     * <p>XX执行动作</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>{&quot;title&quot;:&quot;A registration form&quot;,&quot;description&quot;:&quot;A simple form example.&quot;,&quot;type&quot;:&quot;object&quot;,&quot;required&quot;:[],&quot;properties&quot;:{&quot;password&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;title&quot;:&quot;Password&quot;,&quot;minLength&quot;:3},&quot;telephone&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;title&quot;:&quot;Telephone&quot;,&quot;minLength&quot;:10}}}</p>
     */
    @NameInMap("outputSchema")
    public String outputSchema;

    /**
     * <strong>example:</strong>
     * <p>G-ACT-101FDEBD3C6E213DB474000P</p>
     */
    @NameInMap("refId")
    public String refId;

    /**
     * <strong>example:</strong>
     * <p>ding32fff839a3e0105d</p>
     */
    @NameInMap("refProviderCorpId")
    public String refProviderCorpId;

    /**
     * <strong>example:</strong>
     * <p>action</p>
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
         * <strong>example:</strong>
         * <p>应用</p>
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
         * <strong>example:</strong>
         * <p>SAMPLE_KEY</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <strong>example:</strong>
         * <p>VALUE</p>
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
        @NameInMap("categoryNames")
        public java.util.List<GetActionDetailResponseBodyIntegrationConfigCategoryNames> categoryNames;

        /**
         * <strong>example:</strong>
         * <p>表单</p>
         */
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
