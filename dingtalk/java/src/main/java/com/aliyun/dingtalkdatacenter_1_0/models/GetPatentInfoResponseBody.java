// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetPatentInfoResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>EntName:企业名称</p>
     * <p>PatentType:专利类型</p>
     * <p>PatentName:专利名</p>
     * <p>PatentStatus:专利状态</p>
     * <p>RequestNum:申请号</p>
     * <p>RequestDate:申请日</p>
     * <p>PublicNum:公开(公告)号</p>
     * <p>PublicDate:公开(公告)日</p>
     * <p>InventorList:发明人</p>
     * <p>PatenteeList:专利权人</p>
     * <p>CateNum:分类号</p>
     * <p>PrioNum:优先权号</p>
     * <p>PrioDate:优先权日</p>
     * <p>Agency:专利代理机构</p>
     * <p>Agent:代理人</p>
     * <p>Brief:简要说明</p>
     * <p>MainClaim:主权项</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
    @NameInMap("total")
    public Long total;

    public static GetPatentInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPatentInfoResponseBody self = new GetPatentInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPatentInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetPatentInfoResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
