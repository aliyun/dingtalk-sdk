// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetInnerAppResponseBody extends TeaModel {
    @NameInMap("agentId")
    public Long agentId;

    @NameInMap("appName")
    public String appName;

    @NameInMap("customerAppId")
    public String customerAppId;

    @NameInMap("mobileLoginAddressKey")
    public String mobileLoginAddressKey;

    @NameInMap("mobileLoginLoginUrl")
    public String mobileLoginLoginUrl;

    @NameInMap("mobileOriginalHomepageUrl")
    public String mobileOriginalHomepageUrl;

    @NameInMap("mobileTransferUrl")
    public String mobileTransferUrl;

    @NameInMap("pcEffectiveHomepageUrl")
    public String pcEffectiveHomepageUrl;

    @NameInMap("pcLoginAddressKey")
    public String pcLoginAddressKey;

    @NameInMap("pcLoginLoginUrl")
    public String pcLoginLoginUrl;

    @NameInMap("pcOriginalHomepageUrl")
    public String pcOriginalHomepageUrl;

    @NameInMap("pcTransferUrl")
    public String pcTransferUrl;

    public static GetInnerAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetInnerAppResponseBody self = new GetInnerAppResponseBody();
        return TeaModel.build(map, self);
    }

    public GetInnerAppResponseBody setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public GetInnerAppResponseBody setAppName(String appName) {
        this.appName = appName;
        return this;
    }
    public String getAppName() {
        return this.appName;
    }

    public GetInnerAppResponseBody setCustomerAppId(String customerAppId) {
        this.customerAppId = customerAppId;
        return this;
    }
    public String getCustomerAppId() {
        return this.customerAppId;
    }

    public GetInnerAppResponseBody setMobileLoginAddressKey(String mobileLoginAddressKey) {
        this.mobileLoginAddressKey = mobileLoginAddressKey;
        return this;
    }
    public String getMobileLoginAddressKey() {
        return this.mobileLoginAddressKey;
    }

    public GetInnerAppResponseBody setMobileLoginLoginUrl(String mobileLoginLoginUrl) {
        this.mobileLoginLoginUrl = mobileLoginLoginUrl;
        return this;
    }
    public String getMobileLoginLoginUrl() {
        return this.mobileLoginLoginUrl;
    }

    public GetInnerAppResponseBody setMobileOriginalHomepageUrl(String mobileOriginalHomepageUrl) {
        this.mobileOriginalHomepageUrl = mobileOriginalHomepageUrl;
        return this;
    }
    public String getMobileOriginalHomepageUrl() {
        return this.mobileOriginalHomepageUrl;
    }

    public GetInnerAppResponseBody setMobileTransferUrl(String mobileTransferUrl) {
        this.mobileTransferUrl = mobileTransferUrl;
        return this;
    }
    public String getMobileTransferUrl() {
        return this.mobileTransferUrl;
    }

    public GetInnerAppResponseBody setPcEffectiveHomepageUrl(String pcEffectiveHomepageUrl) {
        this.pcEffectiveHomepageUrl = pcEffectiveHomepageUrl;
        return this;
    }
    public String getPcEffectiveHomepageUrl() {
        return this.pcEffectiveHomepageUrl;
    }

    public GetInnerAppResponseBody setPcLoginAddressKey(String pcLoginAddressKey) {
        this.pcLoginAddressKey = pcLoginAddressKey;
        return this;
    }
    public String getPcLoginAddressKey() {
        return this.pcLoginAddressKey;
    }

    public GetInnerAppResponseBody setPcLoginLoginUrl(String pcLoginLoginUrl) {
        this.pcLoginLoginUrl = pcLoginLoginUrl;
        return this;
    }
    public String getPcLoginLoginUrl() {
        return this.pcLoginLoginUrl;
    }

    public GetInnerAppResponseBody setPcOriginalHomepageUrl(String pcOriginalHomepageUrl) {
        this.pcOriginalHomepageUrl = pcOriginalHomepageUrl;
        return this;
    }
    public String getPcOriginalHomepageUrl() {
        return this.pcOriginalHomepageUrl;
    }

    public GetInnerAppResponseBody setPcTransferUrl(String pcTransferUrl) {
        this.pcTransferUrl = pcTransferUrl;
        return this;
    }
    public String getPcTransferUrl() {
        return this.pcTransferUrl;
    }

}
