// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class SaveSalaryArchivesResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.Map<String, ?> result;

    public static SaveSalaryArchivesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveSalaryArchivesResponseBody self = new SaveSalaryArchivesResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveSalaryArchivesResponseBody setResult(java.util.Map<String, ?> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, ?> getResult() {
        return this.result;
    }

}
