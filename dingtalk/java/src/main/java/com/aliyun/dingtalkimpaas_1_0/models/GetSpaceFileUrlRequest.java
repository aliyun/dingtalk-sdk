// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceFileUrlRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fileId")
    public String fileId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("senderUid")
    public String senderUid;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("spaceId")
    public String spaceId;

    public static GetSpaceFileUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceFileUrlRequest self = new GetSpaceFileUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetSpaceFileUrlRequest setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

    public GetSpaceFileUrlRequest setSenderUid(String senderUid) {
        this.senderUid = senderUid;
        return this;
    }
    public String getSenderUid() {
        return this.senderUid;
    }

    public GetSpaceFileUrlRequest setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

}
