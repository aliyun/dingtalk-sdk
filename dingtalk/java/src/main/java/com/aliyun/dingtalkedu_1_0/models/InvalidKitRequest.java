// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InvalidKitRequest extends TeaModel {
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
     * <p>staffxxx</p>
     */
    @NameInMap("openUserId")
    public String openUserId;

    public static InvalidKitRequest build(java.util.Map<String, ?> map) throws Exception {
        InvalidKitRequest self = new InvalidKitRequest();
        return TeaModel.build(map, self);
    }

    public InvalidKitRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public InvalidKitRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public InvalidKitRequest setIsvProductScene(String isvProductScene) {
        this.isvProductScene = isvProductScene;
        return this;
    }
    public String getIsvProductScene() {
        return this.isvProductScene;
    }

    public InvalidKitRequest setOpenUserId(String openUserId) {
        this.openUserId = openUserId;
        return this;
    }
    public String getOpenUserId() {
        return this.openUserId;
    }

}
