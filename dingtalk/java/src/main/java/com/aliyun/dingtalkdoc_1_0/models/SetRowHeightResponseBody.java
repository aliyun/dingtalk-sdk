// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetRowHeightResponseBody extends TeaModel {
    @NameInMap("sheetId")
    public String sheetId;

    @NameInMap("sheetName")
    public String sheetName;

    public static SetRowHeightResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetRowHeightResponseBody self = new SetRowHeightResponseBody();
        return TeaModel.build(map, self);
    }

    public SetRowHeightResponseBody setSheetId(String sheetId) {
        this.sheetId = sheetId;
        return this;
    }
    public String getSheetId() {
        return this.sheetId;
    }

    public SetRowHeightResponseBody setSheetName(String sheetName) {
        this.sheetName = sheetName;
        return this;
    }
    public String getSheetName() {
        return this.sheetName;
    }

}
