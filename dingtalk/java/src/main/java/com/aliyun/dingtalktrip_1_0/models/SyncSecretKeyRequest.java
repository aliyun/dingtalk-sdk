// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncSecretKeyRequest extends TeaModel {
    // 操作类型，ADD/QUERY/MODIFY/DEL
    @NameInMap("actionType")
    public String actionType;

    // 验签加密串
    @NameInMap("secretString")
    public String secretString;

    // 钉钉侧对应的组织ID
    @NameInMap("targetCorpId")
    public String targetCorpId;

    // 商旅侧appkey
    @NameInMap("tripAppKey")
    public String tripAppKey;

    // 商旅对接密钥
    @NameInMap("tripAppSecurity")
    public String tripAppSecurity;

    // 商旅侧组织ID
    @NameInMap("tripCorpId")
    public String tripCorpId;

    public static SyncSecretKeyRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncSecretKeyRequest self = new SyncSecretKeyRequest();
        return TeaModel.build(map, self);
    }

    public SyncSecretKeyRequest setActionType(String actionType) {
        this.actionType = actionType;
        return this;
    }
    public String getActionType() {
        return this.actionType;
    }

    public SyncSecretKeyRequest setSecretString(String secretString) {
        this.secretString = secretString;
        return this;
    }
    public String getSecretString() {
        return this.secretString;
    }

    public SyncSecretKeyRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

    public SyncSecretKeyRequest setTripAppKey(String tripAppKey) {
        this.tripAppKey = tripAppKey;
        return this;
    }
    public String getTripAppKey() {
        return this.tripAppKey;
    }

    public SyncSecretKeyRequest setTripAppSecurity(String tripAppSecurity) {
        this.tripAppSecurity = tripAppSecurity;
        return this;
    }
    public String getTripAppSecurity() {
        return this.tripAppSecurity;
    }

    public SyncSecretKeyRequest setTripCorpId(String tripCorpId) {
        this.tripCorpId = tripCorpId;
        return this;
    }
    public String getTripCorpId() {
        return this.tripCorpId;
    }

}
