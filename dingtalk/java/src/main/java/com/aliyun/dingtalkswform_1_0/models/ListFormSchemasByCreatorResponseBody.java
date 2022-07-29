// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class ListFormSchemasByCreatorResponseBody extends TeaModel {
    // 返回结果对象。
    @NameInMap("result")
    public ListFormSchemasByCreatorResponseBodyResult result;

    // 是否成功。
    @NameInMap("success")
    public Boolean success;

    public static ListFormSchemasByCreatorResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListFormSchemasByCreatorResponseBody self = new ListFormSchemasByCreatorResponseBody();
        return TeaModel.build(map, self);
    }

    public ListFormSchemasByCreatorResponseBody setResult(ListFormSchemasByCreatorResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ListFormSchemasByCreatorResponseBodyResult getResult() {
        return this.result;
    }

    public ListFormSchemasByCreatorResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ListFormSchemasByCreatorResponseBodyResultListSetting extends TeaModel {
        // 表单类型：  0：一次性填表  1：周期性填表
        @NameInMap("bizType")
        public Integer bizType;

        // 创建时间。iso8601格式。
        @NameInMap("createTime")
        public String createTime;

        // 截止时间。iso8601格式。
        @NameInMap("endTime")
        public String endTime;

        // 表单类型：  0：一次性填表  1：周期性填表
        @NameInMap("formType")
        public Integer formType;

        // 填表周期，周一到周日分别用1-7表示。
        @NameInMap("loopDays")
        public java.util.List<Integer> loopDays;

        // 循环执行的时间点。
        @NameInMap("loopTime")
        public String loopTime;

        // 填表是否终止的标记。
        @NameInMap("stop")
        public Boolean stop;

        public static ListFormSchemasByCreatorResponseBodyResultListSetting build(java.util.Map<String, ?> map) throws Exception {
            ListFormSchemasByCreatorResponseBodyResultListSetting self = new ListFormSchemasByCreatorResponseBodyResultListSetting();
            return TeaModel.build(map, self);
        }

        public ListFormSchemasByCreatorResponseBodyResultListSetting setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

        public ListFormSchemasByCreatorResponseBodyResultListSetting setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListFormSchemasByCreatorResponseBodyResultListSetting setEndTime(String endTime) {
            this.endTime = endTime;
            return this;
        }
        public String getEndTime() {
            return this.endTime;
        }

        public ListFormSchemasByCreatorResponseBodyResultListSetting setFormType(Integer formType) {
            this.formType = formType;
            return this;
        }
        public Integer getFormType() {
            return this.formType;
        }

        public ListFormSchemasByCreatorResponseBodyResultListSetting setLoopDays(java.util.List<Integer> loopDays) {
            this.loopDays = loopDays;
            return this;
        }
        public java.util.List<Integer> getLoopDays() {
            return this.loopDays;
        }

        public ListFormSchemasByCreatorResponseBodyResultListSetting setLoopTime(String loopTime) {
            this.loopTime = loopTime;
            return this;
        }
        public String getLoopTime() {
            return this.loopTime;
        }

        public ListFormSchemasByCreatorResponseBodyResultListSetting setStop(Boolean stop) {
            this.stop = stop;
            return this;
        }
        public Boolean getStop() {
            return this.stop;
        }

    }

    public static class ListFormSchemasByCreatorResponseBodyResultList extends TeaModel {
        // 创建人。
        @NameInMap("creator")
        public String creator;

        // 填表code，用此code可调接口获取填表列表。
        @NameInMap("formCode")
        public String formCode;

        // 填表提示。
        @NameInMap("memo")
        public String memo;

        // 填表名称。
        @NameInMap("name")
        public String name;

        // 填表设置。
        @NameInMap("setting")
        public ListFormSchemasByCreatorResponseBodyResultListSetting setting;

        public static ListFormSchemasByCreatorResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            ListFormSchemasByCreatorResponseBodyResultList self = new ListFormSchemasByCreatorResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public ListFormSchemasByCreatorResponseBodyResultList setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public ListFormSchemasByCreatorResponseBodyResultList setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

        public ListFormSchemasByCreatorResponseBodyResultList setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public ListFormSchemasByCreatorResponseBodyResultList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListFormSchemasByCreatorResponseBodyResultList setSetting(ListFormSchemasByCreatorResponseBodyResultListSetting setting) {
            this.setting = setting;
            return this;
        }
        public ListFormSchemasByCreatorResponseBodyResultListSetting getSetting() {
            return this.setting;
        }

    }

    public static class ListFormSchemasByCreatorResponseBodyResult extends TeaModel {
        // 是否还有下一页数据。
        @NameInMap("hasMore")
        public Boolean hasMore;

        // 创建的填表列表。
        @NameInMap("list")
        public java.util.List<ListFormSchemasByCreatorResponseBodyResultList> list;

        // 下一次分页offset的值。
        @NameInMap("nextToken")
        public Long nextToken;

        public static ListFormSchemasByCreatorResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListFormSchemasByCreatorResponseBodyResult self = new ListFormSchemasByCreatorResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListFormSchemasByCreatorResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public ListFormSchemasByCreatorResponseBodyResult setList(java.util.List<ListFormSchemasByCreatorResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<ListFormSchemasByCreatorResponseBodyResultList> getList() {
            return this.list;
        }

        public ListFormSchemasByCreatorResponseBodyResult setNextToken(Long nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public Long getNextToken() {
            return this.nextToken;
        }

    }

}
