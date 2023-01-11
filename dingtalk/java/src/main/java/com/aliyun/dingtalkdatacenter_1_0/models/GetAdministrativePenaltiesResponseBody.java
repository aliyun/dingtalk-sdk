// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetAdministrativePenaltiesResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>DATE_COL:处罚日期</p>
     * <p>NUMBER:决定书文号</p>
     * <p>ILLEGAL_TYPE:处罚类型</p>
     * <p>DEPARTMENT:处罚机关</p>
     * <p>PUBLIC_DATE 公示日期</p>
     * <p>CONTENT:处罚内容</p>
     * <p>BASED_ON:处罚依据</p>
     * <p>DESCRIPTION:处罚判决书</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
    @NameInMap("total")
    public Long total;

    public static GetAdministrativePenaltiesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAdministrativePenaltiesResponseBody self = new GetAdministrativePenaltiesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAdministrativePenaltiesResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetAdministrativePenaltiesResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
