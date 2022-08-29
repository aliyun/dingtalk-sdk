// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetQeneralTaxpayerInfoResponseBody extends TeaModel {
    // 返回结果
    // DEPARTMENT:主管机关
    // END_DATE:有效日期止
    // ENT_NAME:纳税人名称
    // QUALIFICATION 纳税人资格
    // START_DATE:有效日期起
    // TAXPAYER_NUM:纳税人识别号
    // JUDGE_DATE:认定时间
    @NameInMap("data")
    public String data;

    // 总条数
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
