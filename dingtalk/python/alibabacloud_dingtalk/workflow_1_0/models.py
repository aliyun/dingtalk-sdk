# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class QueryFormInstanceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryFormInstanceRequest(TeaModel):
    def __init__(
        self,
        form_instance_id: str = None,
        form_code: str = None,
        app_uuid: str = None,
    ):
        # 表单实例id
        self.form_instance_id = form_instance_id
        # 表单模板Code
        self.form_code = form_code
        # 应用搭建id
        self.app_uuid = app_uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        return self


class QueryFormInstanceResponseBodyFormInstDataList(TeaModel):
    def __init__(
        self,
        component_type: str = None,
        biz_alias: str = None,
        extend_value: str = None,
        label: str = None,
        value: str = None,
        key: str = None,
    ):
        self.component_type = component_type
        self.biz_alias = biz_alias
        self.extend_value = extend_value
        self.label = label
        self.value = value
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.extend_value is not None:
            result['extendValue'] = self.extend_value
        if self.label is not None:
            result['label'] = self.label
        if self.value is not None:
            result['value'] = self.value
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('extendValue') is not None:
            self.extend_value = m.get('extendValue')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class QueryFormInstanceResponseBody(TeaModel):
    def __init__(
        self,
        form_instance_id: str = None,
        form_inst_data_list: List[QueryFormInstanceResponseBodyFormInstDataList] = None,
        app_uuid: str = None,
        form_code: str = None,
        title: str = None,
        creator: str = None,
        modifier: str = None,
        create_timestamp: int = None,
        modify_timestamp: int = None,
        out_instance_id: str = None,
        out_biz_code: str = None,
        attributes: Dict[str, Any] = None,
    ):
        # 实例id
        self.form_instance_id = form_instance_id
        # 表单数据
        self.form_inst_data_list = form_inst_data_list
        # 应用搭建id
        self.app_uuid = app_uuid
        # 表单模板id
        self.form_code = form_code
        # 表单标题
        self.title = title
        # 创建人
        self.creator = creator
        # 修改人
        self.modifier = modifier
        # 实例创建时间戳
        self.create_timestamp = create_timestamp
        # 实例最近修改时间戳
        self.modify_timestamp = modify_timestamp
        # 外联业务实例id
        self.out_instance_id = out_instance_id
        # 外联业务code
        self.out_biz_code = out_biz_code
        # 扩展信息
        self.attributes = attributes

    def validate(self):
        if self.form_inst_data_list:
            for k in self.form_inst_data_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        result['formInstDataList'] = []
        if self.form_inst_data_list is not None:
            for k in self.form_inst_data_list:
                result['formInstDataList'].append(k.to_map() if k else None)
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.title is not None:
            result['title'] = self.title
        if self.creator is not None:
            result['creator'] = self.creator
        if self.modifier is not None:
            result['modifier'] = self.modifier
        if self.create_timestamp is not None:
            result['createTimestamp'] = self.create_timestamp
        if self.modify_timestamp is not None:
            result['modifyTimestamp'] = self.modify_timestamp
        if self.out_instance_id is not None:
            result['outInstanceId'] = self.out_instance_id
        if self.out_biz_code is not None:
            result['outBizCode'] = self.out_biz_code
        if self.attributes is not None:
            result['attributes'] = self.attributes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        self.form_inst_data_list = []
        if m.get('formInstDataList') is not None:
            for k in m.get('formInstDataList'):
                temp_model = QueryFormInstanceResponseBodyFormInstDataList()
                self.form_inst_data_list.append(temp_model.from_map(k))
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('modifier') is not None:
            self.modifier = m.get('modifier')
        if m.get('createTimestamp') is not None:
            self.create_timestamp = m.get('createTimestamp')
        if m.get('modifyTimestamp') is not None:
            self.modify_timestamp = m.get('modifyTimestamp')
        if m.get('outInstanceId') is not None:
            self.out_instance_id = m.get('outInstanceId')
        if m.get('outBizCode') is not None:
            self.out_biz_code = m.get('outBizCode')
        if m.get('attributes') is not None:
            self.attributes = m.get('attributes')
        return self


class QueryFormInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryFormInstanceResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryFormInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ProcessForecastHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ProcessForecastRequestFormComponentValuesDetailsDetails(TeaModel):
    def __init__(
        self,
        id: str = None,
        biz_alias: str = None,
        name: str = None,
        value: str = None,
        ext_value: str = None,
        component_type: str = None,
    ):
        # 控件id
        self.id = id
        # 控件别名
        self.biz_alias = biz_alias
        # 控件名称
        self.name = name
        # 控件值
        self.value = value
        # 控件扩展值
        self.ext_value = ext_value
        self.component_type = component_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.component_type is not None:
            result['componentType'] = self.component_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        return self


class ProcessForecastRequestFormComponentValuesDetails(TeaModel):
    def __init__(
        self,
        id: str = None,
        biz_alias: str = None,
        name: str = None,
        value: str = None,
        ext_value: str = None,
        details: List[ProcessForecastRequestFormComponentValuesDetailsDetails] = None,
    ):
        # 控件id
        self.id = id
        # 控件别名
        self.biz_alias = biz_alias
        # 控件名称
        self.name = name
        # 控件值
        self.value = value
        # 控件扩展值
        self.ext_value = ext_value
        self.details = details

    def validate(self):
        if self.details:
            for k in self.details:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        result['details'] = []
        if self.details is not None:
            for k in self.details:
                result['details'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        self.details = []
        if m.get('details') is not None:
            for k in m.get('details'):
                temp_model = ProcessForecastRequestFormComponentValuesDetailsDetails()
                self.details.append(temp_model.from_map(k))
        return self


class ProcessForecastRequestFormComponentValues(TeaModel):
    def __init__(
        self,
        id: str = None,
        biz_alias: str = None,
        name: str = None,
        value: str = None,
        ext_value: str = None,
        component_type: str = None,
        details: List[ProcessForecastRequestFormComponentValuesDetails] = None,
    ):
        # 控件id
        self.id = id
        # 控件别名
        self.biz_alias = biz_alias
        # 控件名称
        self.name = name
        # 控件值
        self.value = value
        # 控件扩展值
        self.ext_value = ext_value
        # 控件类型
        self.component_type = component_type
        self.details = details

    def validate(self):
        if self.details:
            for k in self.details:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.component_type is not None:
            result['componentType'] = self.component_type
        result['details'] = []
        if self.details is not None:
            for k in self.details:
                result['details'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        self.details = []
        if m.get('details') is not None:
            for k in m.get('details'):
                temp_model = ProcessForecastRequestFormComponentValuesDetails()
                self.details.append(temp_model.from_map(k))
        return self


class ProcessForecastRequest(TeaModel):
    def __init__(
        self,
        ding_corp_id: str = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        request_id: str = None,
        process_code: str = None,
        dept_id: int = None,
        user_id: str = None,
        form_component_values: List[ProcessForecastRequestFormComponentValues] = None,
    ):
        self.ding_corp_id = ding_corp_id
        self.ding_org_id = ding_org_id
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        self.request_id = request_id
        # 审批流的唯一码
        self.process_code = process_code
        # 部门ID
        self.dept_id = dept_id
        # 审批发起人的userId
        self.user_id = user_id
        # 表单数据内容，控件列表
        self.form_component_values = form_component_values

    def validate(self):
        if self.form_component_values:
            for k in self.form_component_values:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.request_id is not None:
            result['RequestId'] = self.request_id
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        result['formComponentValues'] = []
        if self.form_component_values is not None:
            for k in self.form_component_values:
                result['formComponentValues'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('RequestId') is not None:
            self.request_id = m.get('RequestId')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        self.form_component_values = []
        if m.get('formComponentValues') is not None:
            for k in m.get('formComponentValues'):
                temp_model = ProcessForecastRequestFormComponentValues()
                self.form_component_values.append(temp_model.from_map(k))
        return self


class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals(TeaModel):
    def __init__(
        self,
        work_no: str = None,
        user_name: str = None,
    ):
        # 员工 userId
        self.work_no = work_no
        # 员工姓名
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.work_no is not None:
            result['workNo'] = self.work_no
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels(TeaModel):
    def __init__(
        self,
        labels: str = None,
        label_names: str = None,
    ):
        # 角色 id
        self.labels = labels
        # 角色名字
        self.label_names = label_names

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.labels is not None:
            result['labels'] = self.labels
        if self.label_names is not None:
            result['labelNames'] = self.label_names
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labels') is not None:
            self.labels = m.get('labels')
        if m.get('labelNames') is not None:
            self.label_names = m.get('labelNames')
        return self


class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange(TeaModel):
    def __init__(
        self,
        approvals: List[ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals] = None,
        labels: List[ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels] = None,
    ):
        # 审批指定成员
        self.approvals = approvals
        # 审批指定角色
        self.labels = labels

    def validate(self):
        if self.approvals:
            for k in self.approvals:
                if k:
                    k.validate()
        if self.labels:
            for k in self.labels:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['approvals'] = []
        if self.approvals is not None:
            for k in self.approvals:
                result['approvals'].append(k.to_map() if k else None)
        result['labels'] = []
        if self.labels is not None:
            for k in self.labels:
                result['labels'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.approvals = []
        if m.get('approvals') is not None:
            for k in m.get('approvals'):
                temp_model = ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals()
                self.approvals.append(temp_model.from_map(k))
        self.labels = []
        if m.get('labels') is not None:
            for k in m.get('labels'):
                temp_model = ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels()
                self.labels.append(temp_model.from_map(k))
        return self


class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor(TeaModel):
    def __init__(
        self,
        actor_key: str = None,
        actor_type: str = None,
        actor_selection_type: str = None,
        actor_selection_range: ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange = None,
        allowed_multi: bool = None,
        approval_type: str = None,
        approval_method: str = None,
        actor_activate_type: str = None,
        required: bool = None,
    ):
        # 节点操作人 key
        self.actor_key = actor_key
        # 节点操作人类型
        self.actor_type = actor_type
        # 节点操作人选择范围类型
        self.actor_selection_type = actor_selection_type
        # 节点操作人选择范围
        self.actor_selection_range = actor_selection_range
        # 是否允许多选，还是仅允许选一人
        self.allowed_multi = allowed_multi
        # 节点审批类型
        self.approval_type = approval_type
        # 节点审批方式
        self.approval_method = approval_method
        # 节点激活类型
        self.actor_activate_type = actor_activate_type
        # 该审批人节点在发起审批时是否必填
        self.required = required

    def validate(self):
        if self.actor_selection_range:
            self.actor_selection_range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actor_key is not None:
            result['actorKey'] = self.actor_key
        if self.actor_type is not None:
            result['actorType'] = self.actor_type
        if self.actor_selection_type is not None:
            result['actorSelectionType'] = self.actor_selection_type
        if self.actor_selection_range is not None:
            result['actorSelectionRange'] = self.actor_selection_range.to_map()
        if self.allowed_multi is not None:
            result['allowedMulti'] = self.allowed_multi
        if self.approval_type is not None:
            result['approvalType'] = self.approval_type
        if self.approval_method is not None:
            result['approvalMethod'] = self.approval_method
        if self.actor_activate_type is not None:
            result['actorActivateType'] = self.actor_activate_type
        if self.required is not None:
            result['required'] = self.required
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actorKey') is not None:
            self.actor_key = m.get('actorKey')
        if m.get('actorType') is not None:
            self.actor_type = m.get('actorType')
        if m.get('actorSelectionType') is not None:
            self.actor_selection_type = m.get('actorSelectionType')
        if m.get('actorSelectionRange') is not None:
            temp_model = ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange()
            self.actor_selection_range = temp_model.from_map(m['actorSelectionRange'])
        if m.get('allowedMulti') is not None:
            self.allowed_multi = m.get('allowedMulti')
        if m.get('approvalType') is not None:
            self.approval_type = m.get('approvalType')
        if m.get('approvalMethod') is not None:
            self.approval_method = m.get('approvalMethod')
        if m.get('actorActivateType') is not None:
            self.actor_activate_type = m.get('actorActivateType')
        if m.get('required') is not None:
            self.required = m.get('required')
        return self


class ProcessForecastResponseBodyResultWorkflowActivityRules(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        prev_activity_id: str = None,
        activity_name: str = None,
        activity_type: str = None,
        is_target_select: bool = None,
        workflow_actor: ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor = None,
    ):
        # 节点 id
        self.activity_id = activity_id
        # 流程中前一个节点的 id
        self.prev_activity_id = prev_activity_id
        # 节点名称
        self.activity_name = activity_name
        # 规则类型
        self.activity_type = activity_type
        # 是否自选审批节点
        self.is_target_select = is_target_select
        # 节点操作人信息
        self.workflow_actor = workflow_actor

    def validate(self):
        if self.workflow_actor:
            self.workflow_actor.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.prev_activity_id is not None:
            result['prevActivityId'] = self.prev_activity_id
        if self.activity_name is not None:
            result['activityName'] = self.activity_name
        if self.activity_type is not None:
            result['activityType'] = self.activity_type
        if self.is_target_select is not None:
            result['isTargetSelect'] = self.is_target_select
        if self.workflow_actor is not None:
            result['workflowActor'] = self.workflow_actor.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('prevActivityId') is not None:
            self.prev_activity_id = m.get('prevActivityId')
        if m.get('activityName') is not None:
            self.activity_name = m.get('activityName')
        if m.get('activityType') is not None:
            self.activity_type = m.get('activityType')
        if m.get('isTargetSelect') is not None:
            self.is_target_select = m.get('isTargetSelect')
        if m.get('workflowActor') is not None:
            temp_model = ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor()
            self.workflow_actor = temp_model.from_map(m['workflowActor'])
        return self


class ProcessForecastResponseBodyResultWorkflowForecastNodes(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        out_id: str = None,
    ):
        # 节点 id
        self.activity_id = activity_id
        # 节点出线 id
        self.out_id = out_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.out_id is not None:
            result['outId'] = self.out_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('outId') is not None:
            self.out_id = m.get('outId')
        return self


class ProcessForecastResponseBodyResult(TeaModel):
    def __init__(
        self,
        is_forecast_success: bool = None,
        process_code: str = None,
        user_id: str = None,
        process_id: int = None,
        is_static_workflow: bool = None,
        workflow_activity_rules: List[ProcessForecastResponseBodyResultWorkflowActivityRules] = None,
        workflow_forecast_nodes: List[ProcessForecastResponseBodyResultWorkflowForecastNodes] = None,
    ):
        # 是否预测成功
        self.is_forecast_success = is_forecast_success
        # 流程 code
        self.process_code = process_code
        # 用户 id
        self.user_id = user_id
        # 流程 id
        self.process_id = process_id
        # 是否静态流程
        self.is_static_workflow = is_static_workflow
        self.workflow_activity_rules = workflow_activity_rules
        self.workflow_forecast_nodes = workflow_forecast_nodes

    def validate(self):
        if self.workflow_activity_rules:
            for k in self.workflow_activity_rules:
                if k:
                    k.validate()
        if self.workflow_forecast_nodes:
            for k in self.workflow_forecast_nodes:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_forecast_success is not None:
            result['isForecastSuccess'] = self.is_forecast_success
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.process_id is not None:
            result['processId'] = self.process_id
        if self.is_static_workflow is not None:
            result['isStaticWorkflow'] = self.is_static_workflow
        result['workflowActivityRules'] = []
        if self.workflow_activity_rules is not None:
            for k in self.workflow_activity_rules:
                result['workflowActivityRules'].append(k.to_map() if k else None)
        result['workflowForecastNodes'] = []
        if self.workflow_forecast_nodes is not None:
            for k in self.workflow_forecast_nodes:
                result['workflowForecastNodes'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isForecastSuccess') is not None:
            self.is_forecast_success = m.get('isForecastSuccess')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('processId') is not None:
            self.process_id = m.get('processId')
        if m.get('isStaticWorkflow') is not None:
            self.is_static_workflow = m.get('isStaticWorkflow')
        self.workflow_activity_rules = []
        if m.get('workflowActivityRules') is not None:
            for k in m.get('workflowActivityRules'):
                temp_model = ProcessForecastResponseBodyResultWorkflowActivityRules()
                self.workflow_activity_rules.append(temp_model.from_map(k))
        self.workflow_forecast_nodes = []
        if m.get('workflowForecastNodes') is not None:
            for k in m.get('workflowForecastNodes'):
                temp_model = ProcessForecastResponseBodyResultWorkflowForecastNodes()
                self.workflow_forecast_nodes.append(temp_model.from_map(k))
        return self


class ProcessForecastResponseBody(TeaModel):
    def __init__(
        self,
        result: ProcessForecastResponseBodyResult = None,
    ):
        # 返回结果
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = ProcessForecastResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class ProcessForecastResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ProcessForecastResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = ProcessForecastResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAllProcessInstancesHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryAllProcessInstancesRequest(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        max_results: int = None,
        start_time_in_mills: int = None,
        end_time_in_mills: int = None,
        process_code: str = None,
        app_uuid: str = None,
    ):
        # 分页起始值
        self.next_token = next_token
        # 分页大小
        self.max_results = max_results
        # 开始时间
        self.start_time_in_mills = start_time_in_mills
        # 结束时间
        self.end_time_in_mills = end_time_in_mills
        # 模板编码
        self.process_code = process_code
        # 应用编码
        self.app_uuid = app_uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.start_time_in_mills is not None:
            result['startTimeInMills'] = self.start_time_in_mills
        if self.end_time_in_mills is not None:
            result['endTimeInMills'] = self.end_time_in_mills
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('startTimeInMills') is not None:
            self.start_time_in_mills = m.get('startTimeInMills')
        if m.get('endTimeInMills') is not None:
            self.end_time_in_mills = m.get('endTimeInMills')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        return self


class QueryAllProcessInstancesResponseBodyResultListFormComponentValues(TeaModel):
    def __init__(
        self,
        name: str = None,
        id: str = None,
        value: str = None,
        ext_value: str = None,
    ):
        # 控件名称
        self.name = name
        # 控件id
        self.id = id
        # 控件数据
        self.value = value
        # 控件扩展数据
        self.ext_value = ext_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.id is not None:
            result['id'] = self.id
        if self.value is not None:
            result['value'] = self.value
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        return self


class QueryAllProcessInstancesResponseBodyResultList(TeaModel):
    def __init__(
        self,
        process_instance_id: str = None,
        main_process_instance_id: str = None,
        finish_time: int = None,
        attached_process_instance_ids: str = None,
        business_id: str = None,
        title: str = None,
        originator_dept_id: str = None,
        result: str = None,
        create_time: int = None,
        originator_userid: str = None,
        status: str = None,
        form_component_values: List[QueryAllProcessInstancesResponseBodyResultListFormComponentValues] = None,
    ):
        # 流程实例ID
        self.process_instance_id = process_instance_id
        # 主单实例Id
        self.main_process_instance_id = main_process_instance_id
        # 审批结束时间
        self.finish_time = finish_time
        # 附属单信息
        self.attached_process_instance_ids = attached_process_instance_ids
        # 审批单编号
        self.business_id = business_id
        # 审批单标题
        self.title = title
        # 发起人部门id
        self.originator_dept_id = originator_dept_id
        # 审批结果
        self.result = result
        # 审批单创建时间
        self.create_time = create_time
        # 发起者userId
        self.originator_userid = originator_userid
        # 审批单状态
        self.status = status
        self.form_component_values = form_component_values

    def validate(self):
        if self.form_component_values:
            for k in self.form_component_values:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.main_process_instance_id is not None:
            result['mainProcessInstanceId'] = self.main_process_instance_id
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.attached_process_instance_ids is not None:
            result['attachedProcessInstanceIds'] = self.attached_process_instance_ids
        if self.business_id is not None:
            result['businessId'] = self.business_id
        if self.title is not None:
            result['title'] = self.title
        if self.originator_dept_id is not None:
            result['originatorDeptId'] = self.originator_dept_id
        if self.result is not None:
            result['result'] = self.result
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.originator_userid is not None:
            result['originatorUserid'] = self.originator_userid
        if self.status is not None:
            result['status'] = self.status
        result['formComponentValues'] = []
        if self.form_component_values is not None:
            for k in self.form_component_values:
                result['formComponentValues'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('mainProcessInstanceId') is not None:
            self.main_process_instance_id = m.get('mainProcessInstanceId')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('attachedProcessInstanceIds') is not None:
            self.attached_process_instance_ids = m.get('attachedProcessInstanceIds')
        if m.get('businessId') is not None:
            self.business_id = m.get('businessId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('originatorDeptId') is not None:
            self.originator_dept_id = m.get('originatorDeptId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('originatorUserid') is not None:
            self.originator_userid = m.get('originatorUserid')
        if m.get('status') is not None:
            self.status = m.get('status')
        self.form_component_values = []
        if m.get('formComponentValues') is not None:
            for k in m.get('formComponentValues'):
                temp_model = QueryAllProcessInstancesResponseBodyResultListFormComponentValues()
                self.form_component_values.append(temp_model.from_map(k))
        return self


class QueryAllProcessInstancesResponseBodyResult(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        has_more: bool = None,
        max_results: int = None,
        list: List[QueryAllProcessInstancesResponseBodyResultList] = None,
    ):
        # 下次获取数据的游标
        self.next_token = next_token
        # 是否有更多数据
        self.has_more = has_more
        # 总数
        self.max_results = max_results
        self.list = list

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryAllProcessInstancesResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryAllProcessInstancesResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryAllProcessInstancesResponseBodyResult = None,
    ):
        # result
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryAllProcessInstancesResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QueryAllProcessInstancesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllProcessInstancesResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryAllProcessInstancesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAllFormInstancesHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryAllFormInstancesRequest(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        max_results: int = None,
        app_uuid: str = None,
        form_code: str = None,
    ):
        # 分页游标，第一次调用传空或者null
        self.next_token = next_token
        # 翻页size
        self.max_results = max_results
        # 应用搭建id
        self.app_uuid = app_uuid
        # 表单模板id
        self.form_code = form_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.form_code is not None:
            result['formCode'] = self.form_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        return self


class QueryAllFormInstancesResponseBodyResultValuesFormInstDataList(TeaModel):
    def __init__(
        self,
        component_type: str = None,
        biz_alias: str = None,
        extend_value: str = None,
        label: str = None,
        value: str = None,
        key: str = None,
    ):
        # 控件类型
        self.component_type = component_type
        # 控件别名
        self.biz_alias = biz_alias
        # 表单控件扩展数据
        self.extend_value = extend_value
        # 控件名称
        self.label = label
        # 控件填写的数据
        self.value = value
        # 控件唯一id
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.extend_value is not None:
            result['extendValue'] = self.extend_value
        if self.label is not None:
            result['label'] = self.label
        if self.value is not None:
            result['value'] = self.value
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('extendValue') is not None:
            self.extend_value = m.get('extendValue')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class QueryAllFormInstancesResponseBodyResultValues(TeaModel):
    def __init__(
        self,
        form_instance_id: str = None,
        app_uuid: str = None,
        form_code: str = None,
        title: str = None,
        creator: str = None,
        modifier: str = None,
        create_timestamp: int = None,
        modify_timestamp: int = None,
        out_instance_id: str = None,
        out_biz_code: str = None,
        attributes: Dict[str, Any] = None,
        form_inst_data_list: List[QueryAllFormInstancesResponseBodyResultValuesFormInstDataList] = None,
    ):
        # 表单实例id
        self.form_instance_id = form_instance_id
        # 应用搭建id
        self.app_uuid = app_uuid
        # 表单模板code
        self.form_code = form_code
        # 标题
        self.title = title
        # 创建人
        self.creator = creator
        # 修改人
        self.modifier = modifier
        # 创建时间
        self.create_timestamp = create_timestamp
        # 修改时间
        self.modify_timestamp = modify_timestamp
        # 外部实例编码
        self.out_instance_id = out_instance_id
        # 外部业务编码
        self.out_biz_code = out_biz_code
        # 扩展信息
        self.attributes = attributes
        # 表单实例数据
        self.form_inst_data_list = form_inst_data_list

    def validate(self):
        if self.form_inst_data_list:
            for k in self.form_inst_data_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.title is not None:
            result['title'] = self.title
        if self.creator is not None:
            result['creator'] = self.creator
        if self.modifier is not None:
            result['modifier'] = self.modifier
        if self.create_timestamp is not None:
            result['createTimestamp'] = self.create_timestamp
        if self.modify_timestamp is not None:
            result['modifyTimestamp'] = self.modify_timestamp
        if self.out_instance_id is not None:
            result['outInstanceId'] = self.out_instance_id
        if self.out_biz_code is not None:
            result['outBizCode'] = self.out_biz_code
        if self.attributes is not None:
            result['attributes'] = self.attributes
        result['formInstDataList'] = []
        if self.form_inst_data_list is not None:
            for k in self.form_inst_data_list:
                result['formInstDataList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('modifier') is not None:
            self.modifier = m.get('modifier')
        if m.get('createTimestamp') is not None:
            self.create_timestamp = m.get('createTimestamp')
        if m.get('modifyTimestamp') is not None:
            self.modify_timestamp = m.get('modifyTimestamp')
        if m.get('outInstanceId') is not None:
            self.out_instance_id = m.get('outInstanceId')
        if m.get('outBizCode') is not None:
            self.out_biz_code = m.get('outBizCode')
        if m.get('attributes') is not None:
            self.attributes = m.get('attributes')
        self.form_inst_data_list = []
        if m.get('formInstDataList') is not None:
            for k in m.get('formInstDataList'):
                temp_model = QueryAllFormInstancesResponseBodyResultValuesFormInstDataList()
                self.form_inst_data_list.append(temp_model.from_map(k))
        return self


class QueryAllFormInstancesResponseBodyResult(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        has_more: bool = None,
        max_results: int = None,
        values: List[QueryAllFormInstancesResponseBodyResultValues] = None,
    ):
        # 下一页的游标
        self.next_token = next_token
        # 是否有更多数据
        self.has_more = has_more
        # 分页大小
        self.max_results = max_results
        # 表单列表
        self.values = values

    def validate(self):
        if self.values:
            for k in self.values:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        result['values'] = []
        if self.values is not None:
            for k in self.values:
                result['values'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        self.values = []
        if m.get('values') is not None:
            for k in m.get('values'):
                temp_model = QueryAllFormInstancesResponseBodyResultValues()
                self.values.append(temp_model.from_map(k))
        return self


class QueryAllFormInstancesResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryAllFormInstancesResponseBodyResult = None,
    ):
        # 分页结果
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryAllFormInstancesResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QueryAllFormInstancesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllFormInstancesResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryAllFormInstancesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryFormByBizTypeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryFormByBizTypeRequest(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        biz_types: List[str] = None,
    ):
        # 应用搭建id
        self.app_uuid = app_uuid
        # 表单业务标识
        self.biz_types = biz_types

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.biz_types is not None:
            result['bizTypes'] = self.biz_types
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('bizTypes') is not None:
            self.biz_types = m.get('bizTypes')
        return self


class QueryFormByBizTypeResponseBodyResult(TeaModel):
    def __init__(
        self,
        creator: str = None,
        app_uuid: str = None,
        form_code: str = None,
        form_uuid: str = None,
        name: str = None,
        memo: str = None,
        owner_id: str = None,
        app_type: int = None,
        biz_type: str = None,
        status: str = None,
        create_time: int = None,
        modifed_time: int = None,
        content: str = None,
    ):
        # 创建人
        self.creator = creator
        # 应用搭建id
        self.app_uuid = app_uuid
        # 模板code
        self.form_code = form_code
        # 表单uuid
        self.form_uuid = form_uuid
        # 模板名称
        self.name = name
        # 模板描述
        self.memo = memo
        # 数据归属id
        self.owner_id = owner_id
        # 表单类型，0为流程表单，1为数据表单
        self.app_type = app_type
        # 业务标识
        self.biz_type = biz_type
        # 模板状态
        self.status = status
        # 创建时间
        self.create_time = create_time
        # 修改时间
        self.modifed_time = modifed_time
        # 表单控件描述
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator is not None:
            result['creator'] = self.creator
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.name is not None:
            result['name'] = self.name
        if self.memo is not None:
            result['memo'] = self.memo
        if self.owner_id is not None:
            result['ownerId'] = self.owner_id
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.status is not None:
            result['status'] = self.status
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.modifed_time is not None:
            result['modifedTime'] = self.modifed_time
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        if m.get('ownerId') is not None:
            self.owner_id = m.get('ownerId')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('modifedTime') is not None:
            self.modifed_time = m.get('modifedTime')
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class QueryFormByBizTypeResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryFormByBizTypeResponseBodyResult] = None,
    ):
        # 模板列表
        self.result = result

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryFormByBizTypeResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryFormByBizTypeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryFormByBizTypeResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryFormByBizTypeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class FormCreateHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class FormCreateRequestFormComponentsPropsOptions(TeaModel):
    def __init__(
        self,
        value: str = None,
        key: str = None,
    ):
        # 选项的显示内容
        self.value = value
        # 选项的唯一主键
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.value is not None:
            result['value'] = self.value
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class FormCreateRequestFormComponentsPropsStatField(TeaModel):
    def __init__(
        self,
        component_id: str = None,
        label: str = None,
        upper: bool = None,
        pay_enable: str = None,
    ):
        # 需要统计的明细控件内子控件id
        self.component_id = component_id
        # 子控件标题
        self.label = label
        # 金额控件是否需要大写
        self.upper = upper
        self.pay_enable = pay_enable

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_id is not None:
            result['componentId'] = self.component_id
        if self.label is not None:
            result['label'] = self.label
        if self.upper is not None:
            result['upper'] = self.upper
        if self.pay_enable is not None:
            result['payEnable'] = self.pay_enable
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentId') is not None:
            self.component_id = m.get('componentId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        if m.get('payEnable') is not None:
            self.pay_enable = m.get('payEnable')
        return self


class FormCreateRequestFormComponentsPropsDataSourceTarget(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        app_type: int = None,
        biz_type: str = None,
        form_code: str = None,
    ):
        # 应用appUuid
        self.app_uuid = app_uuid
        # 表单类型，0流程表单
        self.app_type = app_type
        # 关联表单业务标识
        self.biz_type = biz_type
        # 关联表单的formCode
        self.form_code = form_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.form_code is not None:
            result['formCode'] = self.form_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        return self


class FormCreateRequestFormComponentsPropsDataSource(TeaModel):
    def __init__(
        self,
        type: str = None,
        target: FormCreateRequestFormComponentsPropsDataSourceTarget = None,
    ):
        # 关联类型，form关联表单
        self.type = type
        # 关联表单信息
        self.target = target

    def validate(self):
        if self.target:
            self.target.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.target is not None:
            result['target'] = self.target.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('target') is not None:
            temp_model = FormCreateRequestFormComponentsPropsDataSourceTarget()
            self.target = temp_model.from_map(m['target'])
        return self


class FormCreateRequestFormComponentsPropsFieldsPropsOptions(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        # 每一个选项的唯一键
        self.key = key
        # 每一个选项的值
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class FormCreateRequestFormComponentsPropsFieldsProps(TeaModel):
    def __init__(
        self,
        component_id: str = None,
        label: str = None,
        label_editable_freeze: bool = None,
        required: bool = None,
        required_editable_freeze: bool = None,
        print: str = None,
        content: str = None,
        format: str = None,
        options: List[FormCreateRequestFormComponentsPropsFieldsPropsOptions] = None,
        upper: str = None,
        unit: str = None,
        placeholder: str = None,
        biz_alias: str = None,
        biz_type: str = None,
        duration: bool = None,
        choice: str = None,
        disabled: bool = None,
        align: str = None,
    ):
        # 表单中控件的唯一id
        self.component_id = component_id
        # 控件标题
        self.label = label
        # label是否禁用修改
        self.label_editable_freeze = label_editable_freeze
        # 必填
        self.required = required
        # 必填是否可修改
        self.required_editable_freeze = required_editable_freeze
        # 是否可打印
        self.print = print
        # 说明文字控件内容
        self.content = content
        # 时间格式
        self.format = format
        # 选项内容
        self.options = options
        # 是否需要大写，1需要大写，0不需要
        self.upper = upper
        # 时间单位（天、小时）
        self.unit = unit
        # 输入提示
        self.placeholder = placeholder
        # 业务别名
        self.biz_alias = biz_alias
        # 套件的业务标识
        self.biz_type = biz_type
        # 是否自动计算时长
        self.duration = duration
        # 联系人控件是否支持多选，1多选，0单选
        self.choice = choice
        # 是否不可编辑
        self.disabled = disabled
        # 文字提示控件显示方式（top|middle|bottom）
        self.align = align

    def validate(self):
        if self.options:
            for k in self.options:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_id is not None:
            result['componentId'] = self.component_id
        if self.label is not None:
            result['label'] = self.label
        if self.label_editable_freeze is not None:
            result['labelEditableFreeze'] = self.label_editable_freeze
        if self.required is not None:
            result['required'] = self.required
        if self.required_editable_freeze is not None:
            result['requiredEditableFreeze'] = self.required_editable_freeze
        if self.print is not None:
            result['print'] = self.print
        if self.content is not None:
            result['content'] = self.content
        if self.format is not None:
            result['format'] = self.format
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.upper is not None:
            result['upper'] = self.upper
        if self.unit is not None:
            result['unit'] = self.unit
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.duration is not None:
            result['duration'] = self.duration
        if self.choice is not None:
            result['choice'] = self.choice
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.align is not None:
            result['align'] = self.align
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentId') is not None:
            self.component_id = m.get('componentId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('labelEditableFreeze') is not None:
            self.label_editable_freeze = m.get('labelEditableFreeze')
        if m.get('required') is not None:
            self.required = m.get('required')
        if m.get('requiredEditableFreeze') is not None:
            self.required_editable_freeze = m.get('requiredEditableFreeze')
        if m.get('print') is not None:
            self.print = m.get('print')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('format') is not None:
            self.format = m.get('format')
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = FormCreateRequestFormComponentsPropsFieldsPropsOptions()
                self.options.append(temp_model.from_map(k))
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('align') is not None:
            self.align = m.get('align')
        return self


class FormCreateRequestFormComponentsPropsFields(TeaModel):
    def __init__(
        self,
        component_type: str = None,
        props: FormCreateRequestFormComponentsPropsFieldsProps = None,
    ):
        # 关联显示字段类型
        self.component_type = component_type
        # 关联显示字段属性
        self.props = props

    def validate(self):
        if self.props:
            self.props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.props is not None:
            result['props'] = self.props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('props') is not None:
            temp_model = FormCreateRequestFormComponentsPropsFieldsProps()
            self.props = temp_model.from_map(m['props'])
        return self


class FormCreateRequestFormComponentsPropsAvailableTemplates(TeaModel):
    def __init__(
        self,
        name: str = None,
        process_code: str = None,
    ):
        # 表单名称
        self.name = name
        # 表单模板processCode
        self.process_code = process_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class FormCreateRequestFormComponentsProps(TeaModel):
    def __init__(
        self,
        component_id: str = None,
        label: str = None,
        async_condition: bool = None,
        required: bool = None,
        content: str = None,
        format: str = None,
        upper: str = None,
        unit: str = None,
        placeholder: str = None,
        biz_alias: str = None,
        biz_type: str = None,
        duration: bool = None,
        choice: str = None,
        disabled: bool = None,
        align: str = None,
        invisible: bool = None,
        link: str = None,
        vertical_print: bool = None,
        formula: str = None,
        common_biz_type: str = None,
        options: List[FormCreateRequestFormComponentsPropsOptions] = None,
        print: str = None,
        stat_field: List[FormCreateRequestFormComponentsPropsStatField] = None,
        data_source: FormCreateRequestFormComponentsPropsDataSource = None,
        fields: List[FormCreateRequestFormComponentsPropsFields] = None,
        address_model: str = None,
        multiple: bool = None,
        limit: int = None,
        available_templates: List[FormCreateRequestFormComponentsPropsAvailableTemplates] = None,
        table_view_mode: str = None,
    ):
        # 控件表单内唯一id
        self.component_id = component_id
        # 控件标题
        self.label = label
        # 套件中控件是否可设置为分条件字段
        self.async_condition = async_condition
        # 是否必填
        self.required = required
        # 说明文字控件内容
        self.content = content
        # 时间格式
        self.format = format
        # 金额控件是否需要大写，1不需要大写，其他需要大写
        self.upper = upper
        # 时间单位（天、小时）
        self.unit = unit
        # 输入提示
        self.placeholder = placeholder
        # 业务别名
        self.biz_alias = biz_alias
        # 套件的业务标识
        self.biz_type = biz_type
        # 是否自动计算时长
        self.duration = duration
        # 联系人控件是否支持多选，1多选，0单选
        self.choice = choice
        # 是否不可编辑
        self.disabled = disabled
        # 文字提示控件显示方式:top|middle|bottom
        self.align = align
        # 是否隐藏字段
        self.invisible = invisible
        # 说明文字控件链接地址
        self.link = link
        # 明细打印方式false横向，true纵向
        self.vertical_print = vertical_print
        # 公式
        self.formula = formula
        # 自定义控件渲染标识
        self.common_biz_type = common_biz_type
        # 单选多选控件选项列表
        self.options = options
        # 字段是否可打印，1打印，0不打印，默认打印
        self.print = print
        # 明细控件数据汇总统计
        self.stat_field = stat_field
        # 关联审批单、关联表单数据源配置
        self.data_source = data_source
        # 关联显示字段
        self.fields = fields
        # 地址控件模式city省市,district省市区,street省市区街道
        self.address_model = address_model
        # 部门控件是否可多选
        self.multiple = multiple
        # 评分控件上限
        self.limit = limit
        # 关联审批单控件限定模板列表
        self.available_templates = available_templates
        # 明细填写方式，table（表格）、list（列表）
        self.table_view_mode = table_view_mode

    def validate(self):
        if self.options:
            for k in self.options:
                if k:
                    k.validate()
        if self.stat_field:
            for k in self.stat_field:
                if k:
                    k.validate()
        if self.data_source:
            self.data_source.validate()
        if self.fields:
            for k in self.fields:
                if k:
                    k.validate()
        if self.available_templates:
            for k in self.available_templates:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_id is not None:
            result['componentId'] = self.component_id
        if self.label is not None:
            result['label'] = self.label
        if self.async_condition is not None:
            result['asyncCondition'] = self.async_condition
        if self.required is not None:
            result['required'] = self.required
        if self.content is not None:
            result['content'] = self.content
        if self.format is not None:
            result['format'] = self.format
        if self.upper is not None:
            result['upper'] = self.upper
        if self.unit is not None:
            result['unit'] = self.unit
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.duration is not None:
            result['duration'] = self.duration
        if self.choice is not None:
            result['choice'] = self.choice
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.align is not None:
            result['align'] = self.align
        if self.invisible is not None:
            result['invisible'] = self.invisible
        if self.link is not None:
            result['link'] = self.link
        if self.vertical_print is not None:
            result['verticalPrint'] = self.vertical_print
        if self.formula is not None:
            result['formula'] = self.formula
        if self.common_biz_type is not None:
            result['commonBizType'] = self.common_biz_type
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.print is not None:
            result['print'] = self.print
        result['statField'] = []
        if self.stat_field is not None:
            for k in self.stat_field:
                result['statField'].append(k.to_map() if k else None)
        if self.data_source is not None:
            result['dataSource'] = self.data_source.to_map()
        result['fields'] = []
        if self.fields is not None:
            for k in self.fields:
                result['fields'].append(k.to_map() if k else None)
        if self.address_model is not None:
            result['addressModel'] = self.address_model
        if self.multiple is not None:
            result['multiple'] = self.multiple
        if self.limit is not None:
            result['limit'] = self.limit
        result['availableTemplates'] = []
        if self.available_templates is not None:
            for k in self.available_templates:
                result['availableTemplates'].append(k.to_map() if k else None)
        if self.table_view_mode is not None:
            result['tableViewMode'] = self.table_view_mode
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentId') is not None:
            self.component_id = m.get('componentId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('asyncCondition') is not None:
            self.async_condition = m.get('asyncCondition')
        if m.get('required') is not None:
            self.required = m.get('required')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('format') is not None:
            self.format = m.get('format')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('align') is not None:
            self.align = m.get('align')
        if m.get('invisible') is not None:
            self.invisible = m.get('invisible')
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('verticalPrint') is not None:
            self.vertical_print = m.get('verticalPrint')
        if m.get('formula') is not None:
            self.formula = m.get('formula')
        if m.get('commonBizType') is not None:
            self.common_biz_type = m.get('commonBizType')
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = FormCreateRequestFormComponentsPropsOptions()
                self.options.append(temp_model.from_map(k))
        if m.get('print') is not None:
            self.print = m.get('print')
        self.stat_field = []
        if m.get('statField') is not None:
            for k in m.get('statField'):
                temp_model = FormCreateRequestFormComponentsPropsStatField()
                self.stat_field.append(temp_model.from_map(k))
        if m.get('dataSource') is not None:
            temp_model = FormCreateRequestFormComponentsPropsDataSource()
            self.data_source = temp_model.from_map(m['dataSource'])
        self.fields = []
        if m.get('fields') is not None:
            for k in m.get('fields'):
                temp_model = FormCreateRequestFormComponentsPropsFields()
                self.fields.append(temp_model.from_map(k))
        if m.get('addressModel') is not None:
            self.address_model = m.get('addressModel')
        if m.get('multiple') is not None:
            self.multiple = m.get('multiple')
        if m.get('limit') is not None:
            self.limit = m.get('limit')
        self.available_templates = []
        if m.get('availableTemplates') is not None:
            for k in m.get('availableTemplates'):
                temp_model = FormCreateRequestFormComponentsPropsAvailableTemplates()
                self.available_templates.append(temp_model.from_map(k))
        if m.get('tableViewMode') is not None:
            self.table_view_mode = m.get('tableViewMode')
        return self


class FormCreateRequestFormComponentsChildrenPropsOptions(TeaModel):
    def __init__(
        self,
        value: str = None,
        key: str = None,
    ):
        # 选项的显示内容
        self.value = value
        # 选项的唯一主键
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.value is not None:
            result['value'] = self.value
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class FormCreateRequestFormComponentsChildrenPropsStatField(TeaModel):
    def __init__(
        self,
        component_id: str = None,
        label: str = None,
        upper: bool = None,
        pay_enable: str = None,
    ):
        self.component_id = component_id
        self.label = label
        self.upper = upper
        self.pay_enable = pay_enable

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_id is not None:
            result['componentId'] = self.component_id
        if self.label is not None:
            result['label'] = self.label
        if self.upper is not None:
            result['upper'] = self.upper
        if self.pay_enable is not None:
            result['payEnable'] = self.pay_enable
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentId') is not None:
            self.component_id = m.get('componentId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        if m.get('payEnable') is not None:
            self.pay_enable = m.get('payEnable')
        return self


class FormCreateRequestFormComponentsChildrenPropsDataSourceTarget(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        app_type: int = None,
        biz_type: str = None,
        form_code: str = None,
    ):
        self.app_uuid = app_uuid
        self.app_type = app_type
        self.biz_type = biz_type
        self.form_code = form_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.form_code is not None:
            result['formCode'] = self.form_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        return self


class FormCreateRequestFormComponentsChildrenPropsDataSource(TeaModel):
    def __init__(
        self,
        type: str = None,
        target: FormCreateRequestFormComponentsChildrenPropsDataSourceTarget = None,
    ):
        self.type = type
        self.target = target

    def validate(self):
        if self.target:
            self.target.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.target is not None:
            result['target'] = self.target.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('target') is not None:
            temp_model = FormCreateRequestFormComponentsChildrenPropsDataSourceTarget()
            self.target = temp_model.from_map(m['target'])
        return self


class FormCreateRequestFormComponentsChildrenPropsFieldsPropsOptions(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        # 每一个选项的唯一键
        self.key = key
        # 每一个选项的值
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class FormCreateRequestFormComponentsChildrenPropsFieldsProps(TeaModel):
    def __init__(
        self,
        component_id: str = None,
        label: str = None,
        label_editable_freeze: bool = None,
        required: bool = None,
        required_editable_freeze: bool = None,
        print: str = None,
        content: str = None,
        format: str = None,
        options: List[FormCreateRequestFormComponentsChildrenPropsFieldsPropsOptions] = None,
        not_upper: str = None,
        unit: str = None,
        placeholder: str = None,
        biz_alias: str = None,
        biz_type: str = None,
        duration: bool = None,
        choice: str = None,
        disabled: bool = None,
        align: str = None,
    ):
        # 表单中控件的唯一id
        self.component_id = component_id
        # 控件标题
        self.label = label
        # label是否禁用修改
        self.label_editable_freeze = label_editable_freeze
        # 必填
        self.required = required
        # 必填是否可修改
        self.required_editable_freeze = required_editable_freeze
        self.print = print
        # 说明文字控件内容
        self.content = content
        # 时间格式
        self.format = format
        # 选项内容
        self.options = options
        # 是否需要大写，1不需要大写，其他需要大写
        self.not_upper = not_upper
        # 时间单位（天、小时）
        self.unit = unit
        # 输入提示
        self.placeholder = placeholder
        # 业务别名
        self.biz_alias = biz_alias
        # 套件的业务标识
        self.biz_type = biz_type
        # 是否自动计算时长
        self.duration = duration
        # 联系人控件是否支持多选，1多选，0单选
        self.choice = choice
        # 是否不可编辑
        self.disabled = disabled
        # 文字提示控件显示方式（top|middle|bottom）
        self.align = align

    def validate(self):
        if self.options:
            for k in self.options:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_id is not None:
            result['componentId'] = self.component_id
        if self.label is not None:
            result['label'] = self.label
        if self.label_editable_freeze is not None:
            result['labelEditableFreeze'] = self.label_editable_freeze
        if self.required is not None:
            result['required'] = self.required
        if self.required_editable_freeze is not None:
            result['requiredEditableFreeze'] = self.required_editable_freeze
        if self.print is not None:
            result['print'] = self.print
        if self.content is not None:
            result['content'] = self.content
        if self.format is not None:
            result['format'] = self.format
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.not_upper is not None:
            result['notUpper'] = self.not_upper
        if self.unit is not None:
            result['unit'] = self.unit
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.duration is not None:
            result['duration'] = self.duration
        if self.choice is not None:
            result['choice'] = self.choice
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.align is not None:
            result['align'] = self.align
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentId') is not None:
            self.component_id = m.get('componentId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('labelEditableFreeze') is not None:
            self.label_editable_freeze = m.get('labelEditableFreeze')
        if m.get('required') is not None:
            self.required = m.get('required')
        if m.get('requiredEditableFreeze') is not None:
            self.required_editable_freeze = m.get('requiredEditableFreeze')
        if m.get('print') is not None:
            self.print = m.get('print')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('format') is not None:
            self.format = m.get('format')
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = FormCreateRequestFormComponentsChildrenPropsFieldsPropsOptions()
                self.options.append(temp_model.from_map(k))
        if m.get('notUpper') is not None:
            self.not_upper = m.get('notUpper')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('align') is not None:
            self.align = m.get('align')
        return self


class FormCreateRequestFormComponentsChildrenPropsFields(TeaModel):
    def __init__(
        self,
        component_type: str = None,
        props: FormCreateRequestFormComponentsChildrenPropsFieldsProps = None,
    ):
        self.component_type = component_type
        self.props = props

    def validate(self):
        if self.props:
            self.props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.props is not None:
            result['props'] = self.props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('props') is not None:
            temp_model = FormCreateRequestFormComponentsChildrenPropsFieldsProps()
            self.props = temp_model.from_map(m['props'])
        return self


class FormCreateRequestFormComponentsChildrenPropsAvailableTemplates(TeaModel):
    def __init__(
        self,
        name: str = None,
        process_code: str = None,
    ):
        # 模板名称
        self.name = name
        # 模板processCode
        self.process_code = process_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class FormCreateRequestFormComponentsChildrenProps(TeaModel):
    def __init__(
        self,
        component_id: str = None,
        label: str = None,
        async_condition: bool = None,
        required: bool = None,
        content: str = None,
        format: str = None,
        upper: str = None,
        unit: str = None,
        placeholder: str = None,
        biz_alias: str = None,
        biz_type: str = None,
        duration: bool = None,
        choice: str = None,
        disabled: bool = None,
        align: str = None,
        invisible: bool = None,
        link: str = None,
        vertical_print: bool = None,
        formula: str = None,
        common_biz_type: str = None,
        options: List[FormCreateRequestFormComponentsChildrenPropsOptions] = None,
        print: str = None,
        stat_field: List[FormCreateRequestFormComponentsChildrenPropsStatField] = None,
        data_source: FormCreateRequestFormComponentsChildrenPropsDataSource = None,
        fields: List[FormCreateRequestFormComponentsChildrenPropsFields] = None,
        address_model: str = None,
        multiple: bool = None,
        limit: int = None,
        available_templates: List[FormCreateRequestFormComponentsChildrenPropsAvailableTemplates] = None,
        table_view_mode: str = None,
    ):
        self.component_id = component_id
        # 控件标题
        self.label = label
        # 套件中控件是否可设置为分条件字段
        self.async_condition = async_condition
        # 必填
        self.required = required
        # 说明文字控件内容
        self.content = content
        # 时间格式
        self.format = format
        # 金额是否需要大写，1不需要大写，其他需要大写
        self.upper = upper
        # 时间单位（天、小时）
        self.unit = unit
        # 输入提示
        self.placeholder = placeholder
        # 业务别名
        self.biz_alias = biz_alias
        # 套件的业务标识
        self.biz_type = biz_type
        # 是否自动计算时长
        self.duration = duration
        # 联系人控件是否支持多选，1多选，0单选
        self.choice = choice
        # 是否不可编辑
        self.disabled = disabled
        # 文字提示控件显示方式:top|middle|bottom
        self.align = align
        # 是否隐藏字段
        self.invisible = invisible
        # 说明文字控件链接地址
        self.link = link
        # 明细打印方式false横向，true纵向
        self.vertical_print = vertical_print
        # 公式
        self.formula = formula
        # 自定义控件渲染标识
        self.common_biz_type = common_biz_type
        # 单选多选控件选项列表
        self.options = options
        # 是否可被打印
        self.print = print
        # 明细汇总统计设置
        self.stat_field = stat_field
        # 数据源配置
        self.data_source = data_source
        # 关联显示字段配置
        self.fields = fields
        # 地址控件模式
        self.address_model = address_model
        # 部门控件是否支持多选
        self.multiple = multiple
        # 评分控件上限
        self.limit = limit
        # 关联审批单表单筛选列表
        self.available_templates = available_templates
        # 明细填写方式，table（表格）、list（列表）
        self.table_view_mode = table_view_mode

    def validate(self):
        if self.options:
            for k in self.options:
                if k:
                    k.validate()
        if self.stat_field:
            for k in self.stat_field:
                if k:
                    k.validate()
        if self.data_source:
            self.data_source.validate()
        if self.fields:
            for k in self.fields:
                if k:
                    k.validate()
        if self.available_templates:
            for k in self.available_templates:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_id is not None:
            result['componentId'] = self.component_id
        if self.label is not None:
            result['label'] = self.label
        if self.async_condition is not None:
            result['asyncCondition'] = self.async_condition
        if self.required is not None:
            result['required'] = self.required
        if self.content is not None:
            result['content'] = self.content
        if self.format is not None:
            result['format'] = self.format
        if self.upper is not None:
            result['upper'] = self.upper
        if self.unit is not None:
            result['unit'] = self.unit
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.duration is not None:
            result['duration'] = self.duration
        if self.choice is not None:
            result['choice'] = self.choice
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.align is not None:
            result['align'] = self.align
        if self.invisible is not None:
            result['invisible'] = self.invisible
        if self.link is not None:
            result['link'] = self.link
        if self.vertical_print is not None:
            result['verticalPrint'] = self.vertical_print
        if self.formula is not None:
            result['formula'] = self.formula
        if self.common_biz_type is not None:
            result['commonBizType'] = self.common_biz_type
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.print is not None:
            result['print'] = self.print
        result['statField'] = []
        if self.stat_field is not None:
            for k in self.stat_field:
                result['statField'].append(k.to_map() if k else None)
        if self.data_source is not None:
            result['dataSource'] = self.data_source.to_map()
        result['fields'] = []
        if self.fields is not None:
            for k in self.fields:
                result['fields'].append(k.to_map() if k else None)
        if self.address_model is not None:
            result['addressModel'] = self.address_model
        if self.multiple is not None:
            result['multiple'] = self.multiple
        if self.limit is not None:
            result['limit'] = self.limit
        result['availableTemplates'] = []
        if self.available_templates is not None:
            for k in self.available_templates:
                result['availableTemplates'].append(k.to_map() if k else None)
        if self.table_view_mode is not None:
            result['tableViewMode'] = self.table_view_mode
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentId') is not None:
            self.component_id = m.get('componentId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('asyncCondition') is not None:
            self.async_condition = m.get('asyncCondition')
        if m.get('required') is not None:
            self.required = m.get('required')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('format') is not None:
            self.format = m.get('format')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('align') is not None:
            self.align = m.get('align')
        if m.get('invisible') is not None:
            self.invisible = m.get('invisible')
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('verticalPrint') is not None:
            self.vertical_print = m.get('verticalPrint')
        if m.get('formula') is not None:
            self.formula = m.get('formula')
        if m.get('commonBizType') is not None:
            self.common_biz_type = m.get('commonBizType')
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = FormCreateRequestFormComponentsChildrenPropsOptions()
                self.options.append(temp_model.from_map(k))
        if m.get('print') is not None:
            self.print = m.get('print')
        self.stat_field = []
        if m.get('statField') is not None:
            for k in m.get('statField'):
                temp_model = FormCreateRequestFormComponentsChildrenPropsStatField()
                self.stat_field.append(temp_model.from_map(k))
        if m.get('dataSource') is not None:
            temp_model = FormCreateRequestFormComponentsChildrenPropsDataSource()
            self.data_source = temp_model.from_map(m['dataSource'])
        self.fields = []
        if m.get('fields') is not None:
            for k in m.get('fields'):
                temp_model = FormCreateRequestFormComponentsChildrenPropsFields()
                self.fields.append(temp_model.from_map(k))
        if m.get('addressModel') is not None:
            self.address_model = m.get('addressModel')
        if m.get('multiple') is not None:
            self.multiple = m.get('multiple')
        if m.get('limit') is not None:
            self.limit = m.get('limit')
        self.available_templates = []
        if m.get('availableTemplates') is not None:
            for k in m.get('availableTemplates'):
                temp_model = FormCreateRequestFormComponentsChildrenPropsAvailableTemplates()
                self.available_templates.append(temp_model.from_map(k))
        if m.get('tableViewMode') is not None:
            self.table_view_mode = m.get('tableViewMode')
        return self


class FormCreateRequestFormComponentsChildrenChildrenPropsOptions(TeaModel):
    def __init__(
        self,
        value: str = None,
        key: str = None,
    ):
        # 选项的显示内容
        self.value = value
        # 选项的唯一主键
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.value is not None:
            result['value'] = self.value
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class FormCreateRequestFormComponentsChildrenChildrenPropsStatField(TeaModel):
    def __init__(
        self,
        component_id: str = None,
        label: str = None,
        upper: bool = None,
        pay_enable: str = None,
    ):
        self.component_id = component_id
        self.label = label
        self.upper = upper
        self.pay_enable = pay_enable

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_id is not None:
            result['componentId'] = self.component_id
        if self.label is not None:
            result['label'] = self.label
        if self.upper is not None:
            result['upper'] = self.upper
        if self.pay_enable is not None:
            result['payEnable'] = self.pay_enable
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentId') is not None:
            self.component_id = m.get('componentId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        if m.get('payEnable') is not None:
            self.pay_enable = m.get('payEnable')
        return self


class FormCreateRequestFormComponentsChildrenChildrenPropsDataSourceTarget(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        app_type: int = None,
        biz_type: str = None,
        form_code: str = None,
    ):
        self.app_uuid = app_uuid
        self.app_type = app_type
        self.biz_type = biz_type
        self.form_code = form_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.form_code is not None:
            result['formCode'] = self.form_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        return self


class FormCreateRequestFormComponentsChildrenChildrenPropsDataSource(TeaModel):
    def __init__(
        self,
        type: str = None,
        target: FormCreateRequestFormComponentsChildrenChildrenPropsDataSourceTarget = None,
    ):
        self.type = type
        self.target = target

    def validate(self):
        if self.target:
            self.target.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.target is not None:
            result['target'] = self.target.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('target') is not None:
            temp_model = FormCreateRequestFormComponentsChildrenChildrenPropsDataSourceTarget()
            self.target = temp_model.from_map(m['target'])
        return self


class FormCreateRequestFormComponentsChildrenChildrenPropsFieldsPropsOptions(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        # 每一个选项的唯一键
        self.key = key
        # 每一个选项的值
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps(TeaModel):
    def __init__(
        self,
        component_id: str = None,
        label: str = None,
        required: bool = None,
        print: str = None,
        content: str = None,
        format: str = None,
        options: List[FormCreateRequestFormComponentsChildrenChildrenPropsFieldsPropsOptions] = None,
        upper: str = None,
        unit: str = None,
        placeholder: str = None,
        biz_alias: str = None,
        biz_type: str = None,
        duration: bool = None,
        choice: str = None,
        disabled: bool = None,
        align: str = None,
    ):
        # 表单中控件的唯一id
        self.component_id = component_id
        # 控件标题
        self.label = label
        # 必填
        self.required = required
        # 字段是否可被打印，1表示打印, 0表示打印，默认打印
        self.print = print
        # 说明文字控件内容
        self.content = content
        # 时间格式
        self.format = format
        # 选项内容
        self.options = options
        # 是否需要大写，1需要大写，0不需要，默认1
        self.upper = upper
        # 时间单位（天、小时）
        self.unit = unit
        # 输入提示
        self.placeholder = placeholder
        # 业务别名
        self.biz_alias = biz_alias
        # 套件的业务标识
        self.biz_type = biz_type
        # 是否自动计算时长
        self.duration = duration
        # 联系人控件是否支持多选，1多选，0单选
        self.choice = choice
        # 是否不可编辑
        self.disabled = disabled
        # 文字提示控件显示方式（top|middle|bottom）
        self.align = align

    def validate(self):
        if self.options:
            for k in self.options:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_id is not None:
            result['componentId'] = self.component_id
        if self.label is not None:
            result['label'] = self.label
        if self.required is not None:
            result['required'] = self.required
        if self.print is not None:
            result['print'] = self.print
        if self.content is not None:
            result['content'] = self.content
        if self.format is not None:
            result['format'] = self.format
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.upper is not None:
            result['upper'] = self.upper
        if self.unit is not None:
            result['unit'] = self.unit
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.duration is not None:
            result['duration'] = self.duration
        if self.choice is not None:
            result['choice'] = self.choice
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.align is not None:
            result['align'] = self.align
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentId') is not None:
            self.component_id = m.get('componentId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('required') is not None:
            self.required = m.get('required')
        if m.get('print') is not None:
            self.print = m.get('print')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('format') is not None:
            self.format = m.get('format')
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = FormCreateRequestFormComponentsChildrenChildrenPropsFieldsPropsOptions()
                self.options.append(temp_model.from_map(k))
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('align') is not None:
            self.align = m.get('align')
        return self


class FormCreateRequestFormComponentsChildrenChildrenPropsFields(TeaModel):
    def __init__(
        self,
        component_type: str = None,
        props: FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps = None,
    ):
        self.component_type = component_type
        self.props = props

    def validate(self):
        if self.props:
            self.props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.props is not None:
            result['props'] = self.props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('props') is not None:
            temp_model = FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps()
            self.props = temp_model.from_map(m['props'])
        return self


class FormCreateRequestFormComponentsChildrenChildrenProps(TeaModel):
    def __init__(
        self,
        component_id: str = None,
        label: str = None,
        async_condition: bool = None,
        required: bool = None,
        content: str = None,
        format: str = None,
        upper: str = None,
        unit: str = None,
        placeholder: str = None,
        biz_alias: str = None,
        biz_type: str = None,
        duration: bool = None,
        choice: str = None,
        disabled: bool = None,
        align: str = None,
        invisible: bool = None,
        link: str = None,
        vertical_print: bool = None,
        formula: str = None,
        common_biz_type: str = None,
        options: List[FormCreateRequestFormComponentsChildrenChildrenPropsOptions] = None,
        print: str = None,
        stat_field: List[FormCreateRequestFormComponentsChildrenChildrenPropsStatField] = None,
        data_source: FormCreateRequestFormComponentsChildrenChildrenPropsDataSource = None,
        fields: List[FormCreateRequestFormComponentsChildrenChildrenPropsFields] = None,
    ):
        self.component_id = component_id
        # 控件标题
        self.label = label
        # 套件中控件是否可设置为分条件字段
        self.async_condition = async_condition
        # 必填
        self.required = required
        # 说明文字控件内容
        self.content = content
        # 时间格式
        self.format = format
        # 是否需要大写，1需要大写，0不需要大写
        self.upper = upper
        # 时间单位（天、小时）
        self.unit = unit
        # 输入提示
        self.placeholder = placeholder
        # 业务别名
        self.biz_alias = biz_alias
        # 套件的业务标识
        self.biz_type = biz_type
        # 是否自动计算时长
        self.duration = duration
        # 联系人控件是否支持多选，1多选，0单选
        self.choice = choice
        # 是否不可编辑
        self.disabled = disabled
        # 文字提示控件显示方式:top|middle|bottom
        self.align = align
        # 是否隐藏字段
        self.invisible = invisible
        # 说明文字控件链接地址
        self.link = link
        # 明细排版方式false横向，true纵向
        self.vertical_print = vertical_print
        # 公式
        self.formula = formula
        # 自定义控件渲染标识
        self.common_biz_type = common_biz_type
        self.options = options
        self.print = print
        self.stat_field = stat_field
        self.data_source = data_source
        self.fields = fields

    def validate(self):
        if self.options:
            for k in self.options:
                if k:
                    k.validate()
        if self.stat_field:
            for k in self.stat_field:
                if k:
                    k.validate()
        if self.data_source:
            self.data_source.validate()
        if self.fields:
            for k in self.fields:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_id is not None:
            result['componentId'] = self.component_id
        if self.label is not None:
            result['label'] = self.label
        if self.async_condition is not None:
            result['asyncCondition'] = self.async_condition
        if self.required is not None:
            result['required'] = self.required
        if self.content is not None:
            result['content'] = self.content
        if self.format is not None:
            result['format'] = self.format
        if self.upper is not None:
            result['upper'] = self.upper
        if self.unit is not None:
            result['unit'] = self.unit
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.duration is not None:
            result['duration'] = self.duration
        if self.choice is not None:
            result['choice'] = self.choice
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.align is not None:
            result['align'] = self.align
        if self.invisible is not None:
            result['invisible'] = self.invisible
        if self.link is not None:
            result['link'] = self.link
        if self.vertical_print is not None:
            result['verticalPrint'] = self.vertical_print
        if self.formula is not None:
            result['formula'] = self.formula
        if self.common_biz_type is not None:
            result['commonBizType'] = self.common_biz_type
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.print is not None:
            result['print'] = self.print
        result['statField'] = []
        if self.stat_field is not None:
            for k in self.stat_field:
                result['statField'].append(k.to_map() if k else None)
        if self.data_source is not None:
            result['dataSource'] = self.data_source.to_map()
        result['fields'] = []
        if self.fields is not None:
            for k in self.fields:
                result['fields'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentId') is not None:
            self.component_id = m.get('componentId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('asyncCondition') is not None:
            self.async_condition = m.get('asyncCondition')
        if m.get('required') is not None:
            self.required = m.get('required')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('format') is not None:
            self.format = m.get('format')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('align') is not None:
            self.align = m.get('align')
        if m.get('invisible') is not None:
            self.invisible = m.get('invisible')
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('verticalPrint') is not None:
            self.vertical_print = m.get('verticalPrint')
        if m.get('formula') is not None:
            self.formula = m.get('formula')
        if m.get('commonBizType') is not None:
            self.common_biz_type = m.get('commonBizType')
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = FormCreateRequestFormComponentsChildrenChildrenPropsOptions()
                self.options.append(temp_model.from_map(k))
        if m.get('print') is not None:
            self.print = m.get('print')
        self.stat_field = []
        if m.get('statField') is not None:
            for k in m.get('statField'):
                temp_model = FormCreateRequestFormComponentsChildrenChildrenPropsStatField()
                self.stat_field.append(temp_model.from_map(k))
        if m.get('dataSource') is not None:
            temp_model = FormCreateRequestFormComponentsChildrenChildrenPropsDataSource()
            self.data_source = temp_model.from_map(m['dataSource'])
        self.fields = []
        if m.get('fields') is not None:
            for k in m.get('fields'):
                temp_model = FormCreateRequestFormComponentsChildrenChildrenPropsFields()
                self.fields.append(temp_model.from_map(k))
        return self


class FormCreateRequestFormComponentsChildrenChildren(TeaModel):
    def __init__(
        self,
        component_type: str = None,
        props: FormCreateRequestFormComponentsChildrenChildrenProps = None,
    ):
        self.component_type = component_type
        self.props = props

    def validate(self):
        if self.props:
            self.props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.props is not None:
            result['props'] = self.props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('props') is not None:
            temp_model = FormCreateRequestFormComponentsChildrenChildrenProps()
            self.props = temp_model.from_map(m['props'])
        return self


class FormCreateRequestFormComponentsChildren(TeaModel):
    def __init__(
        self,
        component_type: str = None,
        props: FormCreateRequestFormComponentsChildrenProps = None,
        children: List[FormCreateRequestFormComponentsChildrenChildren] = None,
    ):
        # 控件类型
        self.component_type = component_type
        # 控件属性
        self.props = props
        # 子控件列表
        self.children = children

    def validate(self):
        if self.props:
            self.props.validate()
        if self.children:
            for k in self.children:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.props is not None:
            result['props'] = self.props.to_map()
        result['children'] = []
        if self.children is not None:
            for k in self.children:
                result['children'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('props') is not None:
            temp_model = FormCreateRequestFormComponentsChildrenProps()
            self.props = temp_model.from_map(m['props'])
        self.children = []
        if m.get('children') is not None:
            for k in m.get('children'):
                temp_model = FormCreateRequestFormComponentsChildrenChildren()
                self.children.append(temp_model.from_map(k))
        return self


class FormCreateRequestFormComponents(TeaModel):
    def __init__(
        self,
        component_type: str = None,
        props: FormCreateRequestFormComponentsProps = None,
        children: List[FormCreateRequestFormComponentsChildren] = None,
    ):
        # 控件类型
        self.component_type = component_type
        # 控件属性
        self.props = props
        # 子控件列表
        self.children = children

    def validate(self):
        if self.props:
            self.props.validate()
        if self.children:
            for k in self.children:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.props is not None:
            result['props'] = self.props.to_map()
        result['children'] = []
        if self.children is not None:
            for k in self.children:
                result['children'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('props') is not None:
            temp_model = FormCreateRequestFormComponentsProps()
            self.props = temp_model.from_map(m['props'])
        self.children = []
        if m.get('children') is not None:
            for k in m.get('children'):
                temp_model = FormCreateRequestFormComponentsChildren()
                self.children.append(temp_model.from_map(k))
        return self


class FormCreateRequest(TeaModel):
    def __init__(
        self,
        ding_corp_id: str = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        request_id: str = None,
        process_code: str = None,
        name: str = None,
        description: str = None,
        form_components: List[FormCreateRequestFormComponents] = None,
    ):
        self.ding_corp_id = ding_corp_id
        self.ding_org_id = ding_org_id
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        self.request_id = request_id
        self.process_code = process_code
        # 表单模板名称
        self.name = name
        # 表单模板描述
        self.description = description
        # 表单控件列表
        self.form_components = form_components

    def validate(self):
        if self.form_components:
            for k in self.form_components:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.request_id is not None:
            result['RequestId'] = self.request_id
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.name is not None:
            result['name'] = self.name
        if self.description is not None:
            result['description'] = self.description
        result['formComponents'] = []
        if self.form_components is not None:
            for k in self.form_components:
                result['formComponents'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('RequestId') is not None:
            self.request_id = m.get('RequestId')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('description') is not None:
            self.description = m.get('description')
        self.form_components = []
        if m.get('formComponents') is not None:
            for k in m.get('formComponents'):
                temp_model = FormCreateRequestFormComponents()
                self.form_components.append(temp_model.from_map(k))
        return self


class FormCreateResponseBodyResult(TeaModel):
    def __init__(
        self,
        process_code: str = None,
    ):
        # 保存或更新的表单code
        self.process_code = process_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class FormCreateResponseBody(TeaModel):
    def __init__(
        self,
        result: FormCreateResponseBodyResult = None,
    ):
        # 表单模板信息
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = FormCreateResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class FormCreateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: FormCreateResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = FormCreateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class StartProcessInstanceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class StartProcessInstanceRequestApprovers(TeaModel):
    def __init__(
        self,
        action_type: str = None,
        user_ids: List[str] = None,
    ):
        # 审批类型
        self.action_type = action_type
        # 审批人列表
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_type is not None:
            result['actionType'] = self.action_type
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionType') is not None:
            self.action_type = m.get('actionType')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class StartProcessInstanceRequestTargetSelectActioners(TeaModel):
    def __init__(
        self,
        actioner_key: str = None,
        actioner_user_ids: List[str] = None,
    ):
        # 自选节点的规则key
        self.actioner_key = actioner_key
        # 操作人userId列表
        self.actioner_user_ids = actioner_user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actioner_key is not None:
            result['actionerKey'] = self.actioner_key
        if self.actioner_user_ids is not None:
            result['actionerUserIds'] = self.actioner_user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionerKey') is not None:
            self.actioner_key = m.get('actionerKey')
        if m.get('actionerUserIds') is not None:
            self.actioner_user_ids = m.get('actionerUserIds')
        return self


class StartProcessInstanceRequestFormComponentValuesDetailsDetails(TeaModel):
    def __init__(
        self,
        id: str = None,
        biz_alias: str = None,
        name: str = None,
        value: str = None,
        ext_value: str = None,
        component_type: str = None,
    ):
        # 控件id
        self.id = id
        # 控件别名
        self.biz_alias = biz_alias
        # 控件名称
        self.name = name
        # 控件值
        self.value = value
        # 控件扩展值
        self.ext_value = ext_value
        # 控件类型
        self.component_type = component_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.component_type is not None:
            result['componentType'] = self.component_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        return self


class StartProcessInstanceRequestFormComponentValuesDetails(TeaModel):
    def __init__(
        self,
        id: str = None,
        biz_alias: str = None,
        name: str = None,
        value: str = None,
        ext_value: str = None,
        details: List[StartProcessInstanceRequestFormComponentValuesDetailsDetails] = None,
    ):
        # 控件id
        self.id = id
        # 控件别名
        self.biz_alias = biz_alias
        # 控件名称
        self.name = name
        # 控件值
        self.value = value
        # 控件扩展值
        self.ext_value = ext_value
        self.details = details

    def validate(self):
        if self.details:
            for k in self.details:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        result['details'] = []
        if self.details is not None:
            for k in self.details:
                result['details'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        self.details = []
        if m.get('details') is not None:
            for k in m.get('details'):
                temp_model = StartProcessInstanceRequestFormComponentValuesDetailsDetails()
                self.details.append(temp_model.from_map(k))
        return self


class StartProcessInstanceRequestFormComponentValues(TeaModel):
    def __init__(
        self,
        id: str = None,
        biz_alias: str = None,
        name: str = None,
        value: str = None,
        ext_value: str = None,
        component_type: str = None,
        details: List[StartProcessInstanceRequestFormComponentValuesDetails] = None,
    ):
        # 控件id
        self.id = id
        # 控件别名
        self.biz_alias = biz_alias
        # 控件名称
        self.name = name
        # 控件值
        self.value = value
        # 控件扩展值
        self.ext_value = ext_value
        # 控件类型
        self.component_type = component_type
        self.details = details

    def validate(self):
        if self.details:
            for k in self.details:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.component_type is not None:
            result['componentType'] = self.component_type
        result['details'] = []
        if self.details is not None:
            for k in self.details:
                result['details'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        self.details = []
        if m.get('details') is not None:
            for k in m.get('details'):
                temp_model = StartProcessInstanceRequestFormComponentValuesDetails()
                self.details.append(temp_model.from_map(k))
        return self


class StartProcessInstanceRequest(TeaModel):
    def __init__(
        self,
        originator_user_id: str = None,
        process_code: str = None,
        dept_id: int = None,
        microapp_agent_id: int = None,
        approvers: List[StartProcessInstanceRequestApprovers] = None,
        cc_list: List[str] = None,
        cc_position: str = None,
        target_select_actioners: List[StartProcessInstanceRequestTargetSelectActioners] = None,
        form_component_values: List[StartProcessInstanceRequestFormComponentValues] = None,
        request_id: str = None,
        ding_corp_id: str = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
    ):
        # 审批发起人的userId
        self.originator_user_id = originator_user_id
        # 审批流的唯一码
        self.process_code = process_code
        # 部门ID
        self.dept_id = dept_id
        # 企业微应用标识
        self.microapp_agent_id = microapp_agent_id
        # 不使用审批流模板时，直接指定审批人列表
        self.approvers = approvers
        # 抄送人userId列表
        self.cc_list = cc_list
        # 抄送时间
        self.cc_position = cc_position
        # 使用审批流模板时，模板上的自选操作人列表
        self.target_select_actioners = target_select_actioners
        # 表单数据内容，控件列表
        self.form_component_values = form_component_values
        self.request_id = request_id
        self.ding_corp_id = ding_corp_id
        self.ding_org_id = ding_org_id
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type

    def validate(self):
        if self.approvers:
            for k in self.approvers:
                if k:
                    k.validate()
        if self.target_select_actioners:
            for k in self.target_select_actioners:
                if k:
                    k.validate()
        if self.form_component_values:
            for k in self.form_component_values:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.originator_user_id is not None:
            result['originatorUserId'] = self.originator_user_id
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.microapp_agent_id is not None:
            result['microappAgentId'] = self.microapp_agent_id
        result['approvers'] = []
        if self.approvers is not None:
            for k in self.approvers:
                result['approvers'].append(k.to_map() if k else None)
        if self.cc_list is not None:
            result['ccList'] = self.cc_list
        if self.cc_position is not None:
            result['ccPosition'] = self.cc_position
        result['targetSelectActioners'] = []
        if self.target_select_actioners is not None:
            for k in self.target_select_actioners:
                result['targetSelectActioners'].append(k.to_map() if k else None)
        result['formComponentValues'] = []
        if self.form_component_values is not None:
            for k in self.form_component_values:
                result['formComponentValues'].append(k.to_map() if k else None)
        if self.request_id is not None:
            result['RequestId'] = self.request_id
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('originatorUserId') is not None:
            self.originator_user_id = m.get('originatorUserId')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('microappAgentId') is not None:
            self.microapp_agent_id = m.get('microappAgentId')
        self.approvers = []
        if m.get('approvers') is not None:
            for k in m.get('approvers'):
                temp_model = StartProcessInstanceRequestApprovers()
                self.approvers.append(temp_model.from_map(k))
        if m.get('ccList') is not None:
            self.cc_list = m.get('ccList')
        if m.get('ccPosition') is not None:
            self.cc_position = m.get('ccPosition')
        self.target_select_actioners = []
        if m.get('targetSelectActioners') is not None:
            for k in m.get('targetSelectActioners'):
                temp_model = StartProcessInstanceRequestTargetSelectActioners()
                self.target_select_actioners.append(temp_model.from_map(k))
        self.form_component_values = []
        if m.get('formComponentValues') is not None:
            for k in m.get('formComponentValues'):
                temp_model = StartProcessInstanceRequestFormComponentValues()
                self.form_component_values.append(temp_model.from_map(k))
        if m.get('RequestId') is not None:
            self.request_id = m.get('RequestId')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        return self


class StartProcessInstanceResponseBody(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
    ):
        # 审批实例id
        self.instance_id = instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        return self


class StartProcessInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: StartProcessInstanceResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = StartProcessInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


