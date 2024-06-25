// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetCheckInSchemaTemplateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>water_mark_checkin</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1234567</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <strong>example:</strong>
     * <p>water_mark_checkin</p>
     */
    @NameInMap("sceneCode")
    public String sceneCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manage123</p>
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
