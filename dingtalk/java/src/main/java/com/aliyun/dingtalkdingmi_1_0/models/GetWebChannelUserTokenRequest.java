// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetWebChannelUserTokenRequest extends TeaModel {
    // 调用方在小蜜客服平台申请的业务账号体系的id
    @NameInMap("source")
    public Long source;

    // 登录用户在业务账号体系内的昵称
    @NameInMap("nick")
    public String nick;

    // 企业corpId
    @NameInMap("dingCorpId")
    public String dingCorpId;

    // 登录用户在业务账号体系内的用户id
    @NameInMap("foreignId")
    public String foreignId;

    public static GetWebChannelUserTokenRequest build(java.util.Map<String, ?> map) throws Exception {
        GetWebChannelUserTokenRequest self = new GetWebChannelUserTokenRequest();
        return TeaModel.build(map, self);
    }

    public GetWebChannelUserTokenRequest setSource(Long source) {
        this.source = source;
        return this;
    }
    public Long getSource() {
        return this.source;
    }

    public GetWebChannelUserTokenRequest setNick(String nick) {
        this.nick = nick;
        return this;
    }
    public String getNick() {
        return this.nick;
    }

    public GetWebChannelUserTokenRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public GetWebChannelUserTokenRequest setForeignId(String foreignId) {
        this.foreignId = foreignId;
        return this;
    }
    public String getForeignId() {
        return this.foreignId;
    }

}
