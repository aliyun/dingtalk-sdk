// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class DeployFunctionCallbackRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>202201061234</p>
     */
    @NameInMap("appId")
    public String appId;

    /**
     * <strong>example:</strong>
     * <p>abc.com</p>
     */
    @NameInMap("customDomain")
    public String customDomain;

    /**
     * <strong>example:</strong>
     * <p>RELEASE</p>
     */
    @NameInMap("deployStage")
    public String deployStage;

    /**
     * <strong>example:</strong>
     * <p>assdfasdfWwd12212</p>
     */
    @NameInMap("gateWayAppKey")
    public String gateWayAppKey;

    /**
     * <strong>example:</strong>
     * <p>fasdfsfasdf1212Sff</p>
     */
    @NameInMap("gateWayAppSecret")
    public String gateWayAppSecret;

    /**
     * <strong>example:</strong>
     * <p>1111shanghai-aliyunapi.com</p>
     */
    @NameInMap("gateWayDomain")
    public String gateWayDomain;

    public static DeployFunctionCallbackRequest build(java.util.Map<String, ?> map) throws Exception {
        DeployFunctionCallbackRequest self = new DeployFunctionCallbackRequest();
        return TeaModel.build(map, self);
    }

    public DeployFunctionCallbackRequest setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
    }

    public DeployFunctionCallbackRequest setCustomDomain(String customDomain) {
        this.customDomain = customDomain;
        return this;
    }
    public String getCustomDomain() {
        return this.customDomain;
    }

    public DeployFunctionCallbackRequest setDeployStage(String deployStage) {
        this.deployStage = deployStage;
        return this;
    }
    public String getDeployStage() {
        return this.deployStage;
    }

    public DeployFunctionCallbackRequest setGateWayAppKey(String gateWayAppKey) {
        this.gateWayAppKey = gateWayAppKey;
        return this;
    }
    public String getGateWayAppKey() {
        return this.gateWayAppKey;
    }

    public DeployFunctionCallbackRequest setGateWayAppSecret(String gateWayAppSecret) {
        this.gateWayAppSecret = gateWayAppSecret;
        return this;
    }
    public String getGateWayAppSecret() {
        return this.gateWayAppSecret;
    }

    public DeployFunctionCallbackRequest setGateWayDomain(String gateWayDomain) {
        this.gateWayDomain = gateWayDomain;
        return this;
    }
    public String getGateWayDomain() {
        return this.gateWayDomain;
    }

}
