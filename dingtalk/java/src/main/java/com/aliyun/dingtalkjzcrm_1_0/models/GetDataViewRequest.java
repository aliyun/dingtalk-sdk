// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class GetDataViewRequest extends TeaModel {
    /**
     * <p>数据类型，参考数据类型ID对照表</p>
     */
    @NameInMap("datatype")
    public String datatype;

    /**
     * <p>数据id</p>
     */
    @NameInMap("msgid")
    public Long msgid;

    public static GetDataViewRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDataViewRequest self = new GetDataViewRequest();
        return TeaModel.build(map, self);
    }

    public GetDataViewRequest setDatatype(String datatype) {
        this.datatype = datatype;
        return this;
    }
    public String getDatatype() {
        return this.datatype;
    }

    public GetDataViewRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

}
