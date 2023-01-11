// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetEnvironmentalPenaltiesResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>DEPARTMENT:处罚单位</p>
     * <p>ENT_NAME:企业名称</p>
     * <p>EXEC_STATUS 执行情况</p>
     * <p>PUNISH_BASIS:处罚依据</p>
     * <p>PUNISH_CONTENT:处罚事由</p>
     * <p>PUNISH_LAW:违反法律</p>
     * <p>PUNISH_NUM:决定文书号</p>
     * <p>PUNISH_RES:处罚结果</p>
     * <p>PUNISH_DATE:处罚时间</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
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
