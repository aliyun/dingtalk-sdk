// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetWebChannelUserTokenRequest extends TeaModel {
    @NameInMap("foreignId")
    public String foreignId;

    @NameInMap("nick")
    public String nick;

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
