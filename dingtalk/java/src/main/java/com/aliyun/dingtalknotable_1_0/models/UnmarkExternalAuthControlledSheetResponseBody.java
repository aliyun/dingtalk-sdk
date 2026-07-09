// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class UnmarkExternalAuthControlledSheetResponseBody extends TeaModel {
    @NameInMap("sheetId")
    public String sheetId;

    @NameInMap("success")
    public Boolean success;

    public static UnmarkExternalAuthControlledSheetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UnmarkExternalAuthControlledSheetResponseBody self = new UnmarkExternalAuthControlledSheetResponseBody();
        return TeaModel.build(map, self);
    }

    public UnmarkExternalAuthControlledSheetResponseBody setSheetId(String sheetId) {
        this.sheetId = sheetId;
        return this;
    }
    public String getSheetId() {
        return this.sheetId;
    }

    public UnmarkExternalAuthControlledSheetResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
