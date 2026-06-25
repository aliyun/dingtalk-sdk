// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class ConfirmFirmwareUpgradeHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static ConfirmFirmwareUpgradeHeaders build(java.util.Map<String, ?> map) throws Exception {
        ConfirmFirmwareUpgradeHeaders self = new ConfirmFirmwareUpgradeHeaders();
        return TeaModel.build(map, self);
    }

    public ConfirmFirmwareUpgradeHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public ConfirmFirmwareUpgradeHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
