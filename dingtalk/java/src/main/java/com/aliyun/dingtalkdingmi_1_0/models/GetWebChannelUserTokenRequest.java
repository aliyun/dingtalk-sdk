// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetWebChannelUserTokenRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123abc</p>
     */
    @NameInMap("foreignId")
    public String foreignId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>客户abc</p>
     */
    @NameInMap("nick")
    public String nick;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("source")
    public Long source;

    public static GetWebChannelUserTokenRequest build(java.util.Map<String, ?> map) throws Exception {
        GetWebChannelUserTokenRequest self = new GetWebChannelUserTokenRequest();
        return TeaModel.build(map, self);
    }

    public GetWebChannelUserTokenRequest setForeignId(String foreignId) {
        this.foreignId = foreignId;
        return this;
    }
    public String getForeignId() {
        return this.foreignId;
    }

    public GetWebChannelUserTokenRequest setNick(String nick) {
        this.nick = nick;
        return this;
    }
    public String getNick() {
        return this.nick;
    }

    public GetWebChannelUserTokenRequest setSource(Long source) {
        this.source = source;
        return this;
    }
    public Long getSource() {
        return this.source;
    }

}
