// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SavePrintTplDetailInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public Long result;

    public static SavePrintTplDetailInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SavePrintTplDetailInfoResponseBody self = new SavePrintTplDetailInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public SavePrintTplDetailInfoResponseBody setResult(Long result) {
        this.result = result;
        return this;
    }
    public Long getResult() {
        return this.result;
    }

}
