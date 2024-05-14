// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class CreateConnectorRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("connectorInfo")
    public java.util.List<CreateConnectorRequestConnectorInfo> connectorInfo;

    @NameInMap("integratorFlag")
    public String integratorFlag;

    public static CreateConnectorRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateConnectorRequest self = new CreateConnectorRequest();
        return TeaModel.build(map, self);
    }

    public CreateConnectorRequest setConnectorInfo(java.util.List<CreateConnectorRequestConnectorInfo> connectorInfo) {
        this.connectorInfo = connectorInfo;
        return this;
    }
    public java.util.List<CreateConnectorRequestConnectorInfo> getConnectorInfo() {
        return this.connectorInfo;
    }

    public CreateConnectorRequest setIntegratorFlag(String integratorFlag) {
        this.integratorFlag = integratorFlag;
        return this;
    }
    public String getIntegratorFlag() {
        return this.integratorFlag;
    }

    public static class CreateConnectorRequestConnectorInfo extends TeaModel {
        @NameInMap("apiDomain")
        public String apiDomain;

        @NameInMap("apiSecret")
        public String apiSecret;

        @NameInMap("appId")
        public Long appId;

        @NameInMap("authValueEnv")
        public Boolean authValueEnv;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("description")
        public String description;

        @NameInMap("domainEnv")
        public Boolean domainEnv;

        @NameInMap("iconMediaId")
        public String iconMediaId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        public static CreateConnectorRequestConnectorInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateConnectorRequestConnectorInfo self = new CreateConnectorRequestConnectorInfo();
            return TeaModel.build(map, self);
        }

        public CreateConnectorRequestConnectorInfo setApiDomain(String apiDomain) {
            this.apiDomain = apiDomain;
            return this;
        }
        public String getApiDomain() {
            return this.apiDomain;
        }

        public CreateConnectorRequestConnectorInfo setApiSecret(String apiSecret) {
            this.apiSecret = apiSecret;
            return this;
        }
        public String getApiSecret() {
            return this.apiSecret;
        }

        public CreateConnectorRequestConnectorInfo setAppId(Long appId) {
            this.appId = appId;
            return this;
        }
        public Long getAppId() {
            return this.appId;
        }

        public CreateConnectorRequestConnectorInfo setAuthValueEnv(Boolean authValueEnv) {
            this.authValueEnv = authValueEnv;
            return this;
        }
        public Boolean getAuthValueEnv() {
            return this.authValueEnv;
        }

        public CreateConnectorRequestConnectorInfo setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CreateConnectorRequestConnectorInfo setDomainEnv(Boolean domainEnv) {
            this.domainEnv = domainEnv;
            return this;
        }
        public Boolean getDomainEnv() {
            return this.domainEnv;
        }

        public CreateConnectorRequestConnectorInfo setIconMediaId(String iconMediaId) {
            this.iconMediaId = iconMediaId;
            return this;
        }
        public String getIconMediaId() {
            return this.iconMediaId;
        }

        public CreateConnectorRequestConnectorInfo setIntegratorConnectorId(String integratorConnectorId) {
            this.integratorConnectorId = integratorConnectorId;
            return this;
        }
        public String getIntegratorConnectorId() {
            return this.integratorConnectorId;
        }

        public CreateConnectorRequestConnectorInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
