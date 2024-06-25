// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetBasicInfoResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[     {       &quot;ENT_NAME&quot;: &quot;xx&quot;,       &quot;LEGAL_NAME&quot;: &quot;xx&quot;,       &quot;ES_DATE&quot;: &quot;2006-12-07&quot;,       &quot;ENT_STATUS&quot;: &quot;在营&quot;,       &quot;REG_CAP&quot;: &quot;1000万人民币&quot;,       &quot;REC_CAP&quot;: &quot;1000万人民币&quot;,       &quot;SOCIAL_CREDIT_CODE&quot;: &quot;91330108793696828A&quot;,       &quot;LICENSE_NUMBER&quot;: &quot;330108000000965&quot;,       &quot;ORG_NO&quot;: &quot;793696828&quot;,       &quot;TAX_NUM&quot;: &quot;91330108793696828A&quot;,       &quot;ENT_TYPE&quot;: &quot;有限责任公司(非自然人投资或控股的法人独资)&quot;,       &quot;INDUSTRY_NAME_LV1&quot;: &quot;租赁和商务服务业&quot;,       &quot;INDUSTRY_NAME_LV2&quot;: &quot;商务服务业&quot;,       &quot;OP_FROM&quot;: &quot;2006-12-07&quot;,       &quot;OP_TO&quot;: &quot;2036-12-06&quot;,       &quot;COLLEGUES_NUM&quot;: &quot;6&quot;,       &quot;ENT_NAME_ENG&quot;: &quot;Hangzhou Ali Baba Advertising Co.,Ltd.&quot;,       &quot;FORMER_NAMES&quot;: &quot;xx&quot;,       &quot;REG_ORG&quot;: &quot;xx&quot;,       &quot;REG_ORG_PROVINCE&quot;: &quot;浙江省&quot;,       &quot;REG_ORG_CITY&quot;: &quot;杭州市&quot;,       &quot;REG_ORG_DISTRICT&quot;: &quot;滨江区&quot;,       &quot;STD_REG_CAP&quot;: 10000000     }   ]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetBasicInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetBasicInfoResponseBody self = new GetBasicInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetBasicInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetBasicInfoResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
