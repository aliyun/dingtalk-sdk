// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetAttachmentTemporaryUrlRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>006f870b-4d1c-4cd0-85b3-2e866798e947</p>
     */
    @NameInMap("attachmentId")
    public String attachmentId;

    public static GetAttachmentTemporaryUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAttachmentTemporaryUrlRequest self = new GetAttachmentTemporaryUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetAttachmentTemporaryUrlRequest setAttachmentId(String attachmentId) {
        this.attachmentId = attachmentId;
        return this;
    }
    public String getAttachmentId() {
        return this.attachmentId;
    }

}
