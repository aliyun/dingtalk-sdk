// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListFormRemarksResponseBody extends TeaModel {
    /**
     * <p>formRemarkVoMap</p>
     */
    @NameInMap("formRemarkVoMap")
    public java.util.Map<String, ?> formRemarkVoMap;

    public static ListFormRemarksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListFormRemarksResponseBody self = new ListFormRemarksResponseBody();
        return TeaModel.build(map, self);
    }

    public ListFormRemarksResponseBody setFormRemarkVoMap(java.util.Map<String, ?> formRemarkVoMap) {
        this.formRemarkVoMap = formRemarkVoMap;
        return this;
    }
    public java.util.Map<String, ?> getFormRemarkVoMap() {
        return this.formRemarkVoMap;
    }

}
