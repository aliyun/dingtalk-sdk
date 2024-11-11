// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class OpenKitRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>{&quot;&quot;}</p>
     */
    @NameInMap("attributes")
    public String attributes;

    /**
     * <strong>example:</strong>
     * <p>dingxxx</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>ISV_XXX</p>
     */
    @NameInMap("isvCode")
    public String isvCode;

    /**
     * <strong>example:</strong>
     * <p>course</p>
     */
    @NameInMap("isvProductScene")
    public String isvProductScene;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("openEndTime")
    public Long openEndTime;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("openStartTime")
    public Long openStartTime;

    /**
     * <strong>example:</strong>
     * <p>staffxxx</p>
     */
    @NameInMap("openUserId")
    public String openUserId;

    public static OpenKitRequest build(java.util.Map<String, ?> map) throws Exception {
        OpenKitRequest self = new OpenKitRequest();
        return TeaModel.build(map, self);
    }

    public OpenKitRequest setAttributes(String attributes) {
        this.attributes = attributes;
        return this;
    }
    public String getAttributes() {
        return this.attributes;
    }

    public OpenKitRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public OpenKitRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public OpenKitRequest setIsvProductScene(String isvProductScene) {
        this.isvProductScene = isvProductScene;
        return this;
    }
    public String getIsvProductScene() {
        return this.isvProductScene;
    }

    public OpenKitRequest setOpenEndTime(Long openEndTime) {
        this.openEndTime = openEndTime;
        return this;
    }
    public Long getOpenEndTime() {
        return this.openEndTime;
    }

    public OpenKitRequest setOpenStartTime(Long openStartTime) {
        this.openStartTime = openStartTime;
        return this;
    }
    public Long getOpenStartTime() {
        return this.openStartTime;
    }

    public OpenKitRequest setOpenUserId(String openUserId) {
        this.openUserId = openUserId;
        return this;
    }
    public String getOpenUserId() {
        return this.openUserId;
    }

}
