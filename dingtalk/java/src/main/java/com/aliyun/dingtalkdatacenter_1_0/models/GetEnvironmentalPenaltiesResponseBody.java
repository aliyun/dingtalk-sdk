// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetEnvironmentalPenaltiesResponseBody extends TeaModel {
    // 返回结果
    // DEPARTMENT:处罚单位
    // ENT_NAME:企业名称
    // EXEC_STATUS 执行情况
    // PUNISH_BASIS:处罚依据
    // PUNISH_CONTENT:处罚事由
    // PUNISH_LAW:违反法律
    // PUNISH_NUM:决定文书号
    // PUNISH_RES:处罚结果
    // PUNISH_DATE:处罚时间
    @NameInMap("data")
    public String data;

    // 总条数
    @NameInMap("total")
    public Long total;

    public static GetEnvironmentalPenaltiesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetEnvironmentalPenaltiesResponseBody self = new GetEnvironmentalPenaltiesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetEnvironmentalPenaltiesResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetEnvironmentalPenaltiesResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
