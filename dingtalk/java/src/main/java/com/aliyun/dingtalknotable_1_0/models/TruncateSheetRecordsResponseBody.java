// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class TruncateSheetRecordsResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static TruncateSheetRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TruncateSheetRecordsResponseBody self = new TruncateSheetRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public TruncateSheetRecordsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
