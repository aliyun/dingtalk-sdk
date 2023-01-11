// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetCheckInSchemaTemplateRequest extends TeaModel {
    /**
     * <p>业务码：</p>
     * <p>- water_mark_checkin 水印签到</p>
     * <br>
     * <br>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>群会话ID。</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>场景码：</p>
     * <p>- water_mark_checkin_h3yun 开放场景码</p>
     * <br>
     * <br>
     */
    @NameInMap("sceneCode")
    public String sceneCode;

    /**
     * <p>用户的userid。</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetCheckInSchemaTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCheckInSchemaTemplateRequest self = new GetCheckInSchemaTemplateRequest();
        return TeaModel.build(map, self);
    }

    public GetCheckInSchemaTemplateRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public GetCheckInSchemaTemplateRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GetCheckInSchemaTemplateRequest setSceneCode(String sceneCode) {
        this.sceneCode = sceneCode;
        return this;
    }
    public String getSceneCode() {
        return this.sceneCode;
    }

    public GetCheckInSchemaTemplateRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
