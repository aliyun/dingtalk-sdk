// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetMsgLocationResponseBody extends TeaModel {
    @NameInMap("msgLocationUrl")
    public String msgLocationUrl;

    public static GetMsgLocationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMsgLocationResponseBody self = new GetMsgLocationResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMsgLocationResponseBody setMsgLocationUrl(String msgLocationUrl) {
        this.msgLocationUrl = msgLocationUrl;
        return this;
    }
    public String getMsgLocationUrl() {
        return this.msgLocationUrl;
    }

}
