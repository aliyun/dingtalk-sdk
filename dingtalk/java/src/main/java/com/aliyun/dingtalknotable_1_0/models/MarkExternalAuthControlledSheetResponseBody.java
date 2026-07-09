// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class MarkExternalAuthControlledSheetResponseBody extends TeaModel {
    @NameInMap("sheetId")
    public String sheetId;

    @NameInMap("success")
    public Boolean success;

    public static MarkExternalAuthControlledSheetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MarkExternalAuthControlledSheetResponseBody self = new MarkExternalAuthControlledSheetResponseBody();
        return TeaModel.build(map, self);
    }

    public MarkExternalAuthControlledSheetResponseBody setSheetId(String sheetId) {
        this.sheetId = sheetId;
        return this;
    }
    public String getSheetId() {
        return this.sheetId;
    }

    public MarkExternalAuthControlledSheetResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
