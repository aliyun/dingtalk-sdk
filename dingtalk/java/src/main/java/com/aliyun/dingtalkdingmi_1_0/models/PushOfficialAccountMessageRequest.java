// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushOfficialAccountMessageRequest extends TeaModel {
    // 企业corpId
    @NameInMap("dingCorpId")
    public String dingCorpId;

    // 用户id(在服务窗对应虚拟企业中的用户id)
    @NameInMap("userId")
    public String userId;

    // 消息类型
    @NameInMap("msgKey")
    public String msgKey;

    // 消息模板替换参数
    @NameInMap("msgParam")
    public String msgParam;

    public static PushOfficialAccountMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        PushOfficialAccountMessageRequest self = new PushOfficialAccountMessageRequest();
        return TeaModel.build(map, self);
    }

    public PushOfficialAccountMessageRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public PushOfficialAccountMessageRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public PushOfficialAccountMessageRequest setMsgKey(String msgKey) {
        this.msgKey = msgKey;
        return this;
    }
    public String getMsgKey() {
        return this.msgKey;
    }

    public PushOfficialAccountMessageRequest setMsgParam(String msgParam) {
        this.msgParam = msgParam;
        return this;
    }
    public String getMsgParam() {
        return this.msgParam;
    }

}
