// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetColumnWidthResponseBody extends TeaModel {
    @NameInMap("sheetId")
    public String sheetId;

    @NameInMap("sheetName")
    public String sheetName;

    public static SetColumnWidthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetColumnWidthResponseBody self = new SetColumnWidthResponseBody();
        return TeaModel.build(map, self);
    }

    public SetColumnWidthResponseBody setSheetId(String sheetId) {
        this.sheetId = sheetId;
        return this;
    }
    public String getSheetId() {
        return this.sheetId;
    }

    public SetColumnWidthResponseBody setSheetName(String sheetName) {
        this.sheetName = sheetName;
        return this;
    }
    public String getSheetName() {
        return this.sheetName;
    }

}
