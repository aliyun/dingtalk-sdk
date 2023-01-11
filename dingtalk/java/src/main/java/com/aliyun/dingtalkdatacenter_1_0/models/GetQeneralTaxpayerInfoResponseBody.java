// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetQeneralTaxpayerInfoResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>DEPARTMENT:主管机关</p>
     * <p>END_DATE:有效日期止</p>
     * <p>ENT_NAME:纳税人名称</p>
     * <p>QUALIFICATION 纳税人资格</p>
     * <p>START_DATE:有效日期起</p>
     * <p>TAXPAYER_NUM:纳税人识别号</p>
     * <p>JUDGE_DATE:认定时间</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
    @NameInMap("total")
    public Long total;

    public static GetQeneralTaxpayerInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetQeneralTaxpayerInfoResponseBody self = new GetQeneralTaxpayerInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetQeneralTaxpayerInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetQeneralTaxpayerInfoResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
