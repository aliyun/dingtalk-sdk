// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkreport_1_0.models;

import com.aliyun.tea.*;

public class GetSubmitStatisticsResponseBody extends TeaModel {
    @NameInMap("shouldRemindTimes")
    public Integer shouldRemindTimes;

    @NameInMap("templateName")
    public String templateName;

    @NameInMap("userDeptMap")
    public java.util.Map<String, String> userDeptMap;

    @NameInMap("userIdCountMap")
    public java.util.Map<String, Long> userIdCountMap;

    @NameInMap("userIdStatusMap")
    public java.util.Map<String, java.util.Map<String, ?>> userIdStatusMap;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    @NameInMap("userMap")
    public java.util.Map<String, UserMapValue> userMap;

    public static GetSubmitStatisticsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSubmitStatisticsResponseBody self = new GetSubmitStatisticsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSubmitStatisticsResponseBody setShouldRemindTimes(Integer shouldRemindTimes) {
        this.shouldRemindTimes = shouldRemindTimes;
        return this;
    }
    public Integer getShouldRemindTimes() {
        return this.shouldRemindTimes;
    }

    public GetSubmitStatisticsResponseBody setTemplateName(String templateName) {
        this.templateName = templateName;
        return this;
    }
    public String getTemplateName() {
        return this.templateName;
    }

    public GetSubmitStatisticsResponseBody setUserDeptMap(java.util.Map<String, String> userDeptMap) {
        this.userDeptMap = userDeptMap;
        return this;
    }
    public java.util.Map<String, String> getUserDeptMap() {
        return this.userDeptMap;
    }

    public GetSubmitStatisticsResponseBody setUserIdCountMap(java.util.Map<String, Long> userIdCountMap) {
        this.userIdCountMap = userIdCountMap;
        return this;
    }
    public java.util.Map<String, Long> getUserIdCountMap() {
        return this.userIdCountMap;
    }

    public GetSubmitStatisticsResponseBody setUserIdStatusMap(java.util.Map<String, java.util.Map<String, ?>> userIdStatusMap) {
        this.userIdStatusMap = userIdStatusMap;
        return this;
    }
    public java.util.Map<String, java.util.Map<String, ?>> getUserIdStatusMap() {
        return this.userIdStatusMap;
    }

    public GetSubmitStatisticsResponseBody setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

    public GetSubmitStatisticsResponseBody setUserMap(java.util.Map<String, UserMapValue> userMap) {
        this.userMap = userMap;
        return this;
    }
    public java.util.Map<String, UserMapValue> getUserMap() {
        return this.userMap;
    }

}
