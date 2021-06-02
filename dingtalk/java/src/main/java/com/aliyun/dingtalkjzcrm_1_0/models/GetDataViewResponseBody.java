// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class GetDataViewResponseBody extends TeaModel {
    @NameInMap("data")
    public GetDataViewResponseBodyData data;

    // 字段明细
    @NameInMap("dataname")
    public java.util.Map<String, java.util.Map<String, ?>> dataname;

    // 响应时间
    @NameInMap("time")
    public String time;

    public static GetDataViewResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDataViewResponseBody self = new GetDataViewResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDataViewResponseBody setData(GetDataViewResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetDataViewResponseBodyData getData() {
        return this.data;
    }

    public GetDataViewResponseBody setDataname(java.util.Map<String, java.util.Map<String, ?>> dataname) {
        this.dataname = dataname;
        return this;
    }
    public java.util.Map<String, java.util.Map<String, ?>> getDataname() {
        return this.dataname;
    }

    public GetDataViewResponseBody setTime(String time) {
        this.time = time;
        return this;
    }
    public String getTime() {
        return this.time;
    }

    public static class GetDataViewResponseBodyData extends TeaModel {
        // 数据详情
        @NameInMap("detail")
        public java.util.Map<String, String> detail;

        public static GetDataViewResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetDataViewResponseBodyData self = new GetDataViewResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetDataViewResponseBodyData setDetail(java.util.Map<String, String> detail) {
            this.detail = detail;
            return this;
        }
        public java.util.Map<String, String> getDetail() {
            return this.detail;
        }

    }

}
