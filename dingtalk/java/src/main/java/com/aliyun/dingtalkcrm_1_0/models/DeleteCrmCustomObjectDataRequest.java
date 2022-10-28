// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteCrmCustomObjectDataRequest extends TeaModel {
    // 自定义对象表单code。
    @NameInMap("formCode")
    public String formCode;

    public static DeleteCrmCustomObjectDataRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteCrmCustomObjectDataRequest self = new DeleteCrmCustomObjectDataRequest();
        return TeaModel.build(map, self);
    }

    public DeleteCrmCustomObjectDataRequest setFormCode(String formCode) {
        this.formCode = formCode;
        return this;
    }
    public String getFormCode() {
        return this.formCode;
    }

}
