// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DebugUnfurlingRegisterRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>3102xxxxxxx</p>
     */
    @NameInMap("appId")
    public String appId;

    @NameInMap("grayGroupIdList")
    public java.util.List<String> grayGroupIdList;

    @NameInMap("grayUserIdList")
    public java.util.List<String> grayUserIdList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("id")
    public Long id;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>37xxxx</p>
     */
    @NameInMap("userId")
    public String userId;

    public static DebugUnfurlingRegisterRequest build(java.util.Map<String, ?> map) throws Exception {
        DebugUnfurlingRegisterRequest self = new DebugUnfurlingRegisterRequest();
        return TeaModel.build(map, self);
    }

    public DebugUnfurlingRegisterRequest setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
    }

    public DebugUnfurlingRegisterRequest setGrayGroupIdList(java.util.List<String> grayGroupIdList) {
        this.grayGroupIdList = grayGroupIdList;
        return this;
    }
    public java.util.List<String> getGrayGroupIdList() {
        return this.grayGroupIdList;
    }

    public DebugUnfurlingRegisterRequest setGrayUserIdList(java.util.List<String> grayUserIdList) {
        this.grayUserIdList = grayUserIdList;
        return this;
    }
    public java.util.List<String> getGrayUserIdList() {
        return this.grayUserIdList;
    }

    public DebugUnfurlingRegisterRequest setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public DebugUnfurlingRegisterRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
