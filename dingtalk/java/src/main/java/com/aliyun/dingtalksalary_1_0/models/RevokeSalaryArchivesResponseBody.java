// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class RevokeSalaryArchivesResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.Map<String, ?> result;

    public static RevokeSalaryArchivesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RevokeSalaryArchivesResponseBody self = new RevokeSalaryArchivesResponseBody();
        return TeaModel.build(map, self);
    }

    public RevokeSalaryArchivesResponseBody setResult(java.util.Map<String, ?> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, ?> getResult() {
        return this.result;
    }

}
