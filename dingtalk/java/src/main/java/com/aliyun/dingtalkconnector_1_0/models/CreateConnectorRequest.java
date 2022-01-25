// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class CreateConnectorRequest extends TeaModel {
    @NameInMap("connectorInfo")
    public java.util.List<CreateConnectorRequestConnectorInfo> connectorInfo;

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

    public static class CreateConnectorRequestConnectorInfo extends TeaModel {
        // 连接器下action api请求url域名，当baseVariables中无apiDomain，该项必填
        @NameInMap("apiDomain")
        public String apiDomain;

        // 连接器下action api请求时使用http加密签名，当baseVariables无apiSecret，该项必填
        @NameInMap("apiSecret")
        public String apiSecret;

        @NameInMap("appId")
        public Long appId;

        // 变量列表。目前支持将apiDomain、apiSecret声明为基础变量。若声明为变量，则对应属性可不传值
        @NameInMap("baseVariables")
        public java.util.List<String> baseVariables;

        @NameInMap("description")
        public String description;

        @NameInMap("iconMediaId")
        public String iconMediaId;

        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

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

        public CreateConnectorRequestConnectorInfo setBaseVariables(java.util.List<String> baseVariables) {
            this.baseVariables = baseVariables;
            return this;
        }
        public java.util.List<String> getBaseVariables() {
            return this.baseVariables;
        }

        public CreateConnectorRequestConnectorInfo setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
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
