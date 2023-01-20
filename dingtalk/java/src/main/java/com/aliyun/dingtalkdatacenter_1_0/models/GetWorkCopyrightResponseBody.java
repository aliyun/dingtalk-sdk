// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetWorkCopyrightResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>EntName:企业名称</p>
     * <p>CopyName:作品全称</p>
     * <p>TypeName:作品类别</p>
     * <p>CopyNum:登记号</p>
     * <p>SuccessDate:创作完成日期</p>
     * <p>FirstDate:首次发表日期</p>
     * <p>ApprovalDate:登记批准日期</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
    @NameInMap("total")
    public Long total;

    public static GetWorkCopyrightResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetWorkCopyrightResponseBody self = new GetWorkCopyrightResponseBody();
        return TeaModel.build(map, self);
    }

    public GetWorkCopyrightResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetWorkCopyrightResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
