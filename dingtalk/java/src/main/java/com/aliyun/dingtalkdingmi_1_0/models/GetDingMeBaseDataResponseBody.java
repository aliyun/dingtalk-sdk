// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetDingMeBaseDataResponseBody extends TeaModel {
    // 是否缓存
    @NameInMap("fromCache")
    public Boolean fromCache;

    // 运行时间
    @NameInMap("runtime")
    public Long runtime;

    // 结果集
    @NameInMap("rawset")
    public java.util.List<java.util.Map<String, String>> rawset;

    // 字段解释
    @NameInMap("tips")
    public java.util.Map<String, ?> tips;

    public static GetDingMeBaseDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDingMeBaseDataResponseBody self = new GetDingMeBaseDataResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDingMeBaseDataResponseBody setFromCache(Boolean fromCache) {
        this.fromCache = fromCache;
        return this;
    }
    public Boolean getFromCache() {
        return this.fromCache;
    }

    public GetDingMeBaseDataResponseBody setRuntime(Long runtime) {
        this.runtime = runtime;
        return this;
    }
    public Long getRuntime() {
        return this.runtime;
    }

    public GetDingMeBaseDataResponseBody setRawset(java.util.List<java.util.Map<String, String>> rawset) {
        this.rawset = rawset;
        return this;
    }
    public java.util.List<java.util.Map<String, String>> getRawset() {
        return this.rawset;
    }

    public GetDingMeBaseDataResponseBody setTips(java.util.Map<String, ?> tips) {
        this.tips = tips;
        return this;
    }
    public java.util.Map<String, ?> getTips() {
        return this.tips;
    }

}
