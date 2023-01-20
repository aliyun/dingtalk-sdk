// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetChangeRecordResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>Type:变更事项</p>
     * <p>ChangeDate:变更日期</p>
     * <p>BeforeContent:变更前</p>
     * <p>AfterContent:变更后</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
    @NameInMap("total")
    public Long total;

    public static GetChangeRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetChangeRecordResponseBody self = new GetChangeRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public GetChangeRecordResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetChangeRecordResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
