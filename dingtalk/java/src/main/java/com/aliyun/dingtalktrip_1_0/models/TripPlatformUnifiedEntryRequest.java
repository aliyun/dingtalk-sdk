// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class TripPlatformUnifiedEntryRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>{&quot;projects&quot;:[{&quot;thirdId&quot;:&quot;00001&quot;,&quot;number&quot;:&quot;00001&quot;,&quot;scope&quot;:1,&quot;action&quot;:0,&quot;name&quot;:&quot;总务01项目&quot;}]}</p>
     */
    @NameInMap("messages")
    public String messages;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>partner_syncProject</p>
     */
    @NameInMap("method")
    public String method;

    public static TripPlatformUnifiedEntryRequest build(java.util.Map<String, ?> map) throws Exception {
        TripPlatformUnifiedEntryRequest self = new TripPlatformUnifiedEntryRequest();
        return TeaModel.build(map, self);
    }

    public TripPlatformUnifiedEntryRequest setMessages(String messages) {
        this.messages = messages;
        return this;
    }
    public String getMessages() {
        return this.messages;
    }

    public TripPlatformUnifiedEntryRequest setMethod(String method) {
        this.method = method;
        return this;
    }
    public String getMethod() {
        return this.method;
    }

}
