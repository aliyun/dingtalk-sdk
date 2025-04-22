// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SubmitAiSportDataRequest extends TeaModel {
    @NameInMap("data")
    public java.util.Map<String, String> data;

    @NameInMap("dataType")
    public String dataType;

    @NameInMap("operateType")
    public String operateType;

    public static SubmitAiSportDataRequest build(java.util.Map<String, ?> map) throws Exception {
        SubmitAiSportDataRequest self = new SubmitAiSportDataRequest();
        return TeaModel.build(map, self);
    }

    public SubmitAiSportDataRequest setData(java.util.Map<String, String> data) {
        this.data = data;
        return this;
    }
    public java.util.Map<String, String> getData() {
        return this.data;
    }

    public SubmitAiSportDataRequest setDataType(String dataType) {
        this.dataType = dataType;
        return this;
    }
    public String getDataType() {
        return this.dataType;
    }

    public SubmitAiSportDataRequest setOperateType(String operateType) {
        this.operateType = operateType;
        return this;
    }
    public String getOperateType() {
        return this.operateType;
    }

}
