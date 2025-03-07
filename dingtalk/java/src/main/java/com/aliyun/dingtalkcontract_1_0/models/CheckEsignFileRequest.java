// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CheckEsignFileRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fileId")
    public String fileId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("spaceId")
    public String spaceId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CheckEsignFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CheckEsignFileRequest self = new CheckEsignFileRequest();
        return TeaModel.build(map, self);
    }

    public CheckEsignFileRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CheckEsignFileRequest setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

    public CheckEsignFileRequest setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public CheckEsignFileRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
