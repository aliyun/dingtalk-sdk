// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class UpdateConnectorRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("connectorInfo")
    public java.util.List<UpdateConnectorRequestConnectorInfo> connectorInfo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("integratorFlag")
    public String integratorFlag;

    public static UpdateConnectorRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateConnectorRequest self = new UpdateConnectorRequest();
        return TeaModel.build(map, self);
    }

    public UpdateConnectorRequest setConnectorInfo(java.util.List<UpdateConnectorRequestConnectorInfo> connectorInfo) {
        this.connectorInfo = connectorInfo;
        return this;
    }
    public java.util.List<UpdateConnectorRequestConnectorInfo> getConnectorInfo() {
        return this.connectorInfo;
    }

    public UpdateConnectorRequest setIntegratorFlag(String integratorFlag) {
        this.integratorFlag = integratorFlag;
        return this;
    }
    public String getIntegratorFlag() {
        return this.integratorFlag;
    }

    public static class UpdateConnectorRequestConnectorInfo extends TeaModel {
        @NameInMap("apiDomain")
        public String apiDomain;

        @NameInMap("apiSecret")
        public String apiSecret;

        @NameInMap("appId")
        public Long appId;

        @NameInMap("authValueEnv")
        public Boolean authValueEnv;

        @NameInMap("description")
        public String description;

        @NameInMap("dingConnectorId")
        public String dingConnectorId;

        @NameInMap("domainEnv")
        public Boolean domainEnv;

        @NameInMap("iconMediaId")
        public String iconMediaId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

        @NameInMap("name")
        public String name;

        public static UpdateConnectorRequestConnectorInfo build(java.util.Map<String, ?> map) throws Exception {
            UpdateConnectorRequestConnectorInfo self = new UpdateConnectorRequestConnectorInfo();
            return TeaModel.build(map, self);
        }

        public UpdateConnectorRequestConnectorInfo setApiDomain(String apiDomain) {
            this.apiDomain = apiDomain;
            return this;
        }
        public String getApiDomain() {
            return this.apiDomain;
        }

        public UpdateConnectorRequestConnectorInfo setApiSecret(String apiSecret) {
            this.apiSecret = apiSecret;
            return this;
        }
        public String getApiSecret() {
            return this.apiSecret;
        }

        public UpdateConnectorRequestConnectorInfo setAppId(Long appId) {
            this.appId = appId;
            return this;
        }
        public Long getAppId() {
            return this.appId;
        }

        public UpdateConnectorRequestConnectorInfo setAuthValueEnv(Boolean authValueEnv) {
            this.authValueEnv = authValueEnv;
            return this;
        }
        public Boolean getAuthValueEnv() {
            return this.authValueEnv;
        }

        public UpdateConnectorRequestConnectorInfo setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public UpdateConnectorRequestConnectorInfo setDingConnectorId(String dingConnectorId) {
            this.dingConnectorId = dingConnectorId;
            return this;
        }
        public String getDingConnectorId() {
            return this.dingConnectorId;
        }

        public UpdateConnectorRequestConnectorInfo setDomainEnv(Boolean domainEnv) {
            this.domainEnv = domainEnv;
            return this;
        }
        public Boolean getDomainEnv() {
            return this.domainEnv;
        }

        public UpdateConnectorRequestConnectorInfo setIconMediaId(String iconMediaId) {
            this.iconMediaId = iconMediaId;
            return this;
        }
        public String getIconMediaId() {
            return this.iconMediaId;
        }

        public UpdateConnectorRequestConnectorInfo setIntegratorConnectorId(String integratorConnectorId) {
            this.integratorConnectorId = integratorConnectorId;
            return this;
        }
        public String getIntegratorConnectorId() {
            return this.integratorConnectorId;
        }

        public UpdateConnectorRequestConnectorInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
