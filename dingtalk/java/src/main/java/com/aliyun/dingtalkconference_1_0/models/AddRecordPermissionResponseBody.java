// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class AddRecordPermissionResponseBody extends TeaModel {
    @NameInMap("code")
    public String code;

    public static AddRecordPermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddRecordPermissionResponseBody self = new AddRecordPermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public AddRecordPermissionResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
