// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UploadAttachmentResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static UploadAttachmentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UploadAttachmentResponseBody self = new UploadAttachmentResponseBody();
        return TeaModel.build(map, self);
    }

    public UploadAttachmentResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public UploadAttachmentResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
