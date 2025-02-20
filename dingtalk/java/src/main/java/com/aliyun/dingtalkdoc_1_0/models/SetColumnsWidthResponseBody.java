// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetColumnsWidthResponseBody extends TeaModel {
    @NameInMap("sheetId")
    public String sheetId;

    @NameInMap("sheetName")
    public String sheetName;

    public static SetColumnsWidthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetColumnsWidthResponseBody self = new SetColumnsWidthResponseBody();
        return TeaModel.build(map, self);
    }

    public SetColumnsWidthResponseBody setSheetId(String sheetId) {
        this.sheetId = sheetId;
        return this;
    }
    public String getSheetId() {
        return this.sheetId;
    }

    public SetColumnsWidthResponseBody setSheetName(String sheetName) {
        this.sheetName = sheetName;
        return this;
    }
    public String getSheetName() {
        return this.sheetName;
    }

}
