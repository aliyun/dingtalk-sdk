// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class UpdateConnectorRequest extends TeaModel {
    @NameInMap("connectorInfo")
    public java.util.List<UpdateConnectorRequestConnectorInfo> connectorInfo;

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

    public static class UpdateConnectorRequestConnectorInfo extends TeaModel {
        // 连接器中执行动作的接口路径域名。
        @NameInMap("apiDomain")
        public String apiDomain;

        // 连接器中执行动作接口的加密签名。
        @NameInMap("apiSecret")
        public String apiSecret;

        // 应用id。
        @NameInMap("appId")
        public Long appId;

        // 将执行动作鉴权值设为环境变量。
        @NameInMap("authValueEnv")
        public Boolean authValueEnv;

        // 连接器描述。
        @NameInMap("description")
        public String description;

        // 连接平台连接器唯一标识。
        @NameInMap("dingConnectorId")
        public String dingConnectorId;

        // 将执行动作域名设为环境变量。
        @NameInMap("domainEnv")
        public Boolean domainEnv;

        @NameInMap("iconMediaId")
        public String iconMediaId;

        // 服务商的连接器唯一标识。
        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

        // 连接器名称。
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
