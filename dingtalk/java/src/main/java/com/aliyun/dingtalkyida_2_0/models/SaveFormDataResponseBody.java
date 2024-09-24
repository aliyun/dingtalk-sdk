// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class SaveFormDataResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>FINST-XIA66E71N7HSLK7H4KOZ388EEOP03A46YAYRK1</p>
     */
    @NameInMap("result")
    public String result;

    public static SaveFormDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveFormDataResponseBody self = new SaveFormDataResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveFormDataResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
