// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class SendLiveInteractionPluginEffectsMsgHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static SendLiveInteractionPluginEffectsMsgHeaders build(java.util.Map<String, ?> map) throws Exception {
        SendLiveInteractionPluginEffectsMsgHeaders self = new SendLiveInteractionPluginEffectsMsgHeaders();
        return TeaModel.build(map, self);
    }

    public SendLiveInteractionPluginEffectsMsgHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public SendLiveInteractionPluginEffectsMsgHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
