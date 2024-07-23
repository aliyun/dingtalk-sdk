// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class CreateNoteForIsvResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static CreateNoteForIsvResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateNoteForIsvResponseBody self = new CreateNoteForIsvResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateNoteForIsvResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
