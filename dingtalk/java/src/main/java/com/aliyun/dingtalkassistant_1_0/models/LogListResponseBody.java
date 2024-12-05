// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class LogListResponseBody extends TeaModel {
    @NameInMap("result")
    public LogListResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static LogListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        LogListResponseBody self = new LogListResponseBody();
        return TeaModel.build(map, self);
    }

    public LogListResponseBody setResult(LogListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public LogListResponseBodyResult getResult() {
        return this.result;
    }

    public LogListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class LogListResponseBodyResultList extends TeaModel {
        @NameInMap("actionNames")
        public String actionNames;

        @NameInMap("customChannel")
        public String customChannel;

        @NameInMap("input")
        public String input;

        @NameInMap("name")
        public String name;

        @NameInMap("output")
        public String output;

        @NameInMap("result")
        public String result;

        @NameInMap("scene")
        public String scene;

        @NameInMap("time")
        public Long time;

        @NameInMap("unionId")
        public String unionId;

        @NameInMap("userId")
        public String userId;

        public static LogListResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            LogListResponseBodyResultList self = new LogListResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public LogListResponseBodyResultList setActionNames(String actionNames) {
            this.actionNames = actionNames;
            return this;
        }
        public String getActionNames() {
            return this.actionNames;
        }

        public LogListResponseBodyResultList setCustomChannel(String customChannel) {
            this.customChannel = customChannel;
            return this;
        }
        public String getCustomChannel() {
            return this.customChannel;
        }

        public LogListResponseBodyResultList setInput(String input) {
            this.input = input;
            return this;
        }
        public String getInput() {
            return this.input;
        }

        public LogListResponseBodyResultList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public LogListResponseBodyResultList setOutput(String output) {
            this.output = output;
            return this;
        }
        public String getOutput() {
            return this.output;
        }

        public LogListResponseBodyResultList setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public LogListResponseBodyResultList setScene(String scene) {
            this.scene = scene;
            return this;
        }
        public String getScene() {
            return this.scene;
        }

        public LogListResponseBodyResultList setTime(Long time) {
            this.time = time;
            return this;
        }
        public Long getTime() {
            return this.time;
        }

        public LogListResponseBodyResultList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public LogListResponseBodyResultList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class LogListResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<LogListResponseBodyResultList> list;

        @NameInMap("totalCount")
        public Integer totalCount;

        public static LogListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            LogListResponseBodyResult self = new LogListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public LogListResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public LogListResponseBodyResult setList(java.util.List<LogListResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<LogListResponseBodyResultList> getList() {
            return this.list;
        }

        public LogListResponseBodyResult setTotalCount(Integer totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Integer getTotalCount() {
            return this.totalCount;
        }

    }

}
