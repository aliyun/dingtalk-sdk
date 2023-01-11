// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class ListFormSchemasByCreatorResponseBody extends TeaModel {
    /**
     * <p>返回结果对象。</p>
     */
    @NameInMap("result")
    public ListFormSchemasByCreatorResponseBodyResult result;

    /**
     * <p>是否成功。</p>
     */
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
        /**
         * <p>表单类型：  0：一次性填表  1：周期性填表</p>
         */
        @NameInMap("bizType")
        public Integer bizType;

        /**
         * <p>创建时间。iso8601格式。</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <p>截止时间。iso8601格式。</p>
         */
        @NameInMap("endTime")
        public String endTime;

        /**
         * <p>表单类型：  0：一次性填表  1：周期性填表</p>
         */
        @NameInMap("formType")
        public Integer formType;

        /**
         * <p>填表周期，周一到周日分别用1-7表示。</p>
         */
        @NameInMap("loopDays")
        public java.util.List<Integer> loopDays;

        /**
         * <p>循环执行的时间点。</p>
         */
        @NameInMap("loopTime")
        public String loopTime;

        /**
         * <p>填表是否终止的标记。</p>
         */
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
        /**
         * <p>创建人。</p>
         */
        @NameInMap("creator")
        public String creator;

        /**
         * <p>填表code，用此code可调接口获取填表列表。</p>
         */
        @NameInMap("formCode")
        public String formCode;

        /**
         * <p>填表提示。</p>
         */
        @NameInMap("memo")
        public String memo;

        /**
         * <p>填表名称。</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>填表设置。</p>
         */
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
        /**
         * <p>是否还有下一页数据。</p>
         */
        @NameInMap("hasMore")
        public Boolean hasMore;

        /**
         * <p>创建的填表列表。</p>
         */
        @NameInMap("list")
        public java.util.List<ListFormSchemasByCreatorResponseBodyResultList> list;

        /**
         * <p>下一次分页offset的值。</p>
         */
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
