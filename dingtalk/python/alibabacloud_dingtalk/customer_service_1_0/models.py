# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class CreateTicketHeaders(TeaModel):
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


class CreateTicketRequestProperties(TeaModel):
    def __init__(
        self,
        name: str = None,
        value: str = None,
    ):
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class CreateTicketRequest(TeaModel):
    def __init__(
        self,
        source_id: str = None,
        foreign_id: str = None,
        foreign_name: str = None,
        open_instance_id: str = None,
        production_type: int = None,
        template_id: str = None,
        title: str = None,
        properties: List[CreateTicketRequestProperties] = None,
    ):
        # 会员来源
        self.source_id = source_id
        # 第三方会员ID
        self.foreign_id = foreign_id
        # 第三方会员名称
        self.foreign_name = foreign_name
        # 实例ID
        self.open_instance_id = open_instance_id
        # 智能客服产品
        self.production_type = production_type
        # 工单模板ID
        self.template_id = template_id
        # 工单标题
        self.title = title
        # 工单表单
        self.properties = properties

    def validate(self):
        if self.properties:
            for k in self.properties:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.foreign_id is not None:
            result['foreignId'] = self.foreign_id
        if self.foreign_name is not None:
            result['foreignName'] = self.foreign_name
        if self.open_instance_id is not None:
            result['openInstanceId'] = self.open_instance_id
        if self.production_type is not None:
            result['productionType'] = self.production_type
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.title is not None:
            result['title'] = self.title
        result['properties'] = []
        if self.properties is not None:
            for k in self.properties:
                result['properties'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('foreignId') is not None:
            self.foreign_id = m.get('foreignId')
        if m.get('foreignName') is not None:
            self.foreign_name = m.get('foreignName')
        if m.get('openInstanceId') is not None:
            self.open_instance_id = m.get('openInstanceId')
        if m.get('productionType') is not None:
            self.production_type = m.get('productionType')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('title') is not None:
            self.title = m.get('title')
        self.properties = []
        if m.get('properties') is not None:
            for k in m.get('properties'):
                temp_model = CreateTicketRequestProperties()
                self.properties.append(temp_model.from_map(k))
        return self


class CreateTicketResponseBody(TeaModel):
    def __init__(
        self,
        ticket_id: str = None,
    ):
        # 新创建工单ID
        self.ticket_id = ticket_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ticket_id is not None:
            result['ticketId'] = self.ticket_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ticketId') is not None:
            self.ticket_id = m.get('ticketId')
        return self


class CreateTicketResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateTicketResponseBody = None,
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
            temp_model = CreateTicketResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserSourceListHeaders(TeaModel):
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


class GetUserSourceListRequest(TeaModel):
    def __init__(
        self,
        open_instance_id: str = None,
        description: str = None,
        org_name: str = None,
        org_id: int = None,
        corp_id: str = None,
        production_type: int = None,
    ):
        self.open_instance_id = open_instance_id
        self.description = description
        self.org_name = org_name
        self.org_id = org_id
        self.corp_id = corp_id
        self.production_type = production_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_instance_id is not None:
            result['openInstanceId'] = self.open_instance_id
        if self.description is not None:
            result['description'] = self.description
        if self.org_name is not None:
            result['orgName'] = self.org_name
        if self.org_id is not None:
            result['orgId'] = self.org_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.production_type is not None:
            result['productionType'] = self.production_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openInstanceId') is not None:
            self.open_instance_id = m.get('openInstanceId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        if m.get('orgId') is not None:
            self.org_id = m.get('orgId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('productionType') is not None:
            self.production_type = m.get('productionType')
        return self


class GetUserSourceListResponseBodyResult(TeaModel):
    def __init__(
        self,
        id: int = None,
        status: int = None,
        description: str = None,
        config: str = None,
        vendor: str = None,
        name: str = None,
    ):
        self.id = id
        self.status = status
        self.description = description
        self.config = config
        self.vendor = vendor
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.status is not None:
            result['status'] = self.status
        if self.description is not None:
            result['description'] = self.description
        if self.config is not None:
            result['config'] = self.config
        if self.vendor is not None:
            result['vendor'] = self.vendor
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('config') is not None:
            self.config = m.get('config')
        if m.get('vendor') is not None:
            self.vendor = m.get('vendor')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class GetUserSourceListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetUserSourceListResponseBodyResult] = None,
    ):
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
                temp_model = GetUserSourceListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetUserSourceListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserSourceListResponseBody = None,
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
            temp_model = GetUserSourceListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PageListRobotHeaders(TeaModel):
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


class PageListRobotRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        open_instance_id: str = None,
        production_type: int = None,
        next_token: int = None,
        max_results: int = None,
    ):
        # 查询的企业Id
        self.corp_id = corp_id
        # 多实例ID
        self.open_instance_id = open_instance_id
        # 产品类型
        self.production_type = production_type
        # 用来标记当前开始读取的位置，置空表示从头开始
        self.next_token = next_token
        # 本次读取的最大数据记录数量
        self.max_results = max_results

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.open_instance_id is not None:
            result['openInstanceId'] = self.open_instance_id
        if self.production_type is not None:
            result['productionType'] = self.production_type
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('openInstanceId') is not None:
            self.open_instance_id = m.get('openInstanceId')
        if m.get('productionType') is not None:
            self.production_type = m.get('productionType')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class PageListRobotResponseBodyList(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        app_key: str = None,
        account_id: int = None,
        status: int = None,
    ):
        # 机器人自增Id
        self.id = id
        # 机器人名称
        self.name = name
        # 机器人APPKEY
        self.app_key = app_key
        # 机器人所在租户ID
        self.account_id = account_id
        # 机器人状态
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.app_key is not None:
            result['appKey'] = self.app_key
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class PageListRobotResponseBody(TeaModel):
    def __init__(
        self,
        total: int = None,
        next_cursor: int = None,
        has_more: bool = None,
        list: List[PageListRobotResponseBodyList] = None,
    ):
        # 查询结果总数
        self.total = total
        # 下一次查询起始游标
        self.next_cursor = next_cursor
        # 是否有更多结果
        self.has_more = has_more
        # 查询结果列表
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
        if self.total is not None:
            result['total'] = self.total
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('total') is not None:
            self.total = m.get('total')
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = PageListRobotResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class PageListRobotResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: PageListRobotResponseBody = None,
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
            temp_model = PageListRobotResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PageListActionHeaders(TeaModel):
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


class PageListActionRequest(TeaModel):
    def __init__(
        self,
        open_instance_id: str = None,
        production_type: int = None,
        next_token: str = None,
        max_results: int = None,
    ):
        # 实例id
        self.open_instance_id = open_instance_id
        # 产品类型
        self.production_type = production_type
        # 用来标记当前开始读取的位置，置空表示从头开始。
        self.next_token = next_token
        # 本次读取的最大数据记录数量，此参数为可选参数，用户传入为空时，应该有默认值。应设置最大值限制，最大不超过100
        self.max_results = max_results

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_instance_id is not None:
            result['openInstanceId'] = self.open_instance_id
        if self.production_type is not None:
            result['productionType'] = self.production_type
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openInstanceId') is not None:
            self.open_instance_id = m.get('openInstanceId')
        if m.get('productionType') is not None:
            self.production_type = m.get('productionType')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class PageListActionResponseBodyListActionContent(TeaModel):
    def __init__(
        self,
        display_value: str = None,
        display_name: str = None,
        name: str = None,
        value: str = None,
        value_type: str = None,
    ):
        # displayValue
        self.display_value = display_value
        # displayName
        self.display_name = display_name
        # name
        self.name = name
        # value
        self.value = value
        # valueType
        self.value_type = value_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_value is not None:
            result['displayValue'] = self.display_value
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        if self.value_type is not None:
            result['valueType'] = self.value_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayValue') is not None:
            self.display_value = m.get('displayValue')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('valueType') is not None:
            self.value_type = m.get('valueType')
        return self


class PageListActionResponseBodyList(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
        operator: str = None,
        operator_role: str = None,
        action_code: str = None,
        action_content: List[PageListActionResponseBodyListActionContent] = None,
    ):
        # operatorId
        self.operator_id = operator_id
        # operator
        self.operator = operator
        # operatorRole
        self.operator_role = operator_role
        # actionCode
        self.action_code = action_code
        # actionContent
        self.action_content = action_content

    def validate(self):
        if self.action_content:
            for k in self.action_content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.operator is not None:
            result['operator'] = self.operator
        if self.operator_role is not None:
            result['operatorRole'] = self.operator_role
        if self.action_code is not None:
            result['actionCode'] = self.action_code
        result['actionContent'] = []
        if self.action_content is not None:
            for k in self.action_content:
                result['actionContent'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('operatorRole') is not None:
            self.operator_role = m.get('operatorRole')
        if m.get('actionCode') is not None:
            self.action_code = m.get('actionCode')
        self.action_content = []
        if m.get('actionContent') is not None:
            for k in m.get('actionContent'):
                temp_model = PageListActionResponseBodyListActionContent()
                self.action_content.append(temp_model.from_map(k))
        return self


class PageListActionResponseBody(TeaModel):
    def __init__(
        self,
        next_cursor: int = None,
        total: int = None,
        list: List[PageListActionResponseBodyList] = None,
    ):
        # nextCursor
        self.next_cursor = next_cursor
        # total
        self.total = total
        # list
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
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.total is not None:
            result['total'] = self.total
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('total') is not None:
            self.total = m.get('total')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = PageListActionResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class PageListActionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: PageListActionResponseBody = None,
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
            temp_model = PageListActionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ExecuteActivityHeaders(TeaModel):
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


class ExecuteActivityRequestProperties(TeaModel):
    def __init__(
        self,
        name: str = None,
        value: str = None,
    ):
        # 字段的key
        self.name = name
        # 字段的值
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class ExecuteActivityRequest(TeaModel):
    def __init__(
        self,
        source_id: str = None,
        foreign_id: str = None,
        foreign_name: str = None,
        activity_code: str = None,
        open_instance_id: str = None,
        production_type: int = None,
        properties: List[ExecuteActivityRequestProperties] = None,
    ):
        # 来源ID
        self.source_id = source_id
        # 会员ID
        self.foreign_id = foreign_id
        # 会员名称
        self.foreign_name = foreign_name
        # 动作编码
        self.activity_code = activity_code
        # 实例id
        self.open_instance_id = open_instance_id
        # 产品类型
        self.production_type = production_type
        # 工单表单字段
        self.properties = properties

    def validate(self):
        if self.properties:
            for k in self.properties:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.foreign_id is not None:
            result['foreignId'] = self.foreign_id
        if self.foreign_name is not None:
            result['foreignName'] = self.foreign_name
        if self.activity_code is not None:
            result['activityCode'] = self.activity_code
        if self.open_instance_id is not None:
            result['openInstanceId'] = self.open_instance_id
        if self.production_type is not None:
            result['productionType'] = self.production_type
        result['properties'] = []
        if self.properties is not None:
            for k in self.properties:
                result['properties'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('foreignId') is not None:
            self.foreign_id = m.get('foreignId')
        if m.get('foreignName') is not None:
            self.foreign_name = m.get('foreignName')
        if m.get('activityCode') is not None:
            self.activity_code = m.get('activityCode')
        if m.get('openInstanceId') is not None:
            self.open_instance_id = m.get('openInstanceId')
        if m.get('productionType') is not None:
            self.production_type = m.get('productionType')
        self.properties = []
        if m.get('properties') is not None:
            for k in m.get('properties'):
                temp_model = ExecuteActivityRequestProperties()
                self.properties.append(temp_model.from_map(k))
        return self


class ExecuteActivityResponseBody(TeaModel):
    def __init__(
        self,
        task_id: str = None,
    ):
        # 任务id
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class ExecuteActivityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ExecuteActivityResponseBody = None,
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
            temp_model = ExecuteActivityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PageListTicketHeaders(TeaModel):
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


class PageListTicketRequest(TeaModel):
    def __init__(
        self,
        open_instance_id: str = None,
        production_type: int = None,
        template_id: str = None,
        ticket_id: str = None,
        source_id: str = None,
        foreign_id: str = None,
        ticket_status: str = None,
        start_time: int = None,
        end_time: int = None,
        next_token: str = None,
        max_results: int = None,
    ):
        # 实例id
        self.open_instance_id = open_instance_id
        # 产品类型
        self.production_type = production_type
        # 工单模板
        self.template_id = template_id
        # 工单ID
        self.ticket_id = ticket_id
        # 来源
        self.source_id = source_id
        # 第三方用户id
        self.foreign_id = foreign_id
        # 工单状态
        self.ticket_status = ticket_status
        # 开始时间
        self.start_time = start_time
        # 结束时间
        self.end_time = end_time
        # 用来标记当前开始读取的位置，置空表示从头开始
        self.next_token = next_token
        # 本次读取的最大数据记录数量
        self.max_results = max_results

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_instance_id is not None:
            result['openInstanceId'] = self.open_instance_id
        if self.production_type is not None:
            result['productionType'] = self.production_type
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.ticket_id is not None:
            result['ticketId'] = self.ticket_id
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.foreign_id is not None:
            result['foreignId'] = self.foreign_id
        if self.ticket_status is not None:
            result['ticketStatus'] = self.ticket_status
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openInstanceId') is not None:
            self.open_instance_id = m.get('openInstanceId')
        if m.get('productionType') is not None:
            self.production_type = m.get('productionType')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('ticketId') is not None:
            self.ticket_id = m.get('ticketId')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('foreignId') is not None:
            self.foreign_id = m.get('foreignId')
        if m.get('ticketStatus') is not None:
            self.ticket_status = m.get('ticketStatus')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class PageListTicketResponseBodyList(TeaModel):
    def __init__(
        self,
        foreign_id: str = None,
        source_id: str = None,
        foreign_name: str = None,
        template_id: str = None,
        title: str = None,
        ticket_id: str = None,
        ticket_status: str = None,
        open_instance_id: str = None,
        production_type: int = None,
        gmt_create: str = None,
        gmt_modified: str = None,
        biz_data_map: Dict[str, Any] = None,
    ):
        # foreignId
        self.foreign_id = foreign_id
        # sourceId
        self.source_id = source_id
        # foreignName
        self.foreign_name = foreign_name
        # templateId
        self.template_id = template_id
        # title
        self.title = title
        # ticketId
        self.ticket_id = ticket_id
        # ticketStatus
        self.ticket_status = ticket_status
        # openInstanceId
        self.open_instance_id = open_instance_id
        # productionType
        self.production_type = production_type
        # gmtCreate
        self.gmt_create = gmt_create
        # gmtModified
        self.gmt_modified = gmt_modified
        # bizDataMap
        self.biz_data_map = biz_data_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.foreign_id is not None:
            result['foreignId'] = self.foreign_id
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.foreign_name is not None:
            result['foreignName'] = self.foreign_name
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.title is not None:
            result['title'] = self.title
        if self.ticket_id is not None:
            result['ticketId'] = self.ticket_id
        if self.ticket_status is not None:
            result['ticketStatus'] = self.ticket_status
        if self.open_instance_id is not None:
            result['openInstanceId'] = self.open_instance_id
        if self.production_type is not None:
            result['productionType'] = self.production_type
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.biz_data_map is not None:
            result['bizDataMap'] = self.biz_data_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('foreignId') is not None:
            self.foreign_id = m.get('foreignId')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('foreignName') is not None:
            self.foreign_name = m.get('foreignName')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('ticketId') is not None:
            self.ticket_id = m.get('ticketId')
        if m.get('ticketStatus') is not None:
            self.ticket_status = m.get('ticketStatus')
        if m.get('openInstanceId') is not None:
            self.open_instance_id = m.get('openInstanceId')
        if m.get('productionType') is not None:
            self.production_type = m.get('productionType')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('bizDataMap') is not None:
            self.biz_data_map = m.get('bizDataMap')
        return self


class PageListTicketResponseBody(TeaModel):
    def __init__(
        self,
        next_cursor: int = None,
        total: int = None,
        list: List[PageListTicketResponseBodyList] = None,
    ):
        # nextCursor
        self.next_cursor = next_cursor
        # total
        self.total = total
        # list
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
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.total is not None:
            result['total'] = self.total
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('total') is not None:
            self.total = m.get('total')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = PageListTicketResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class PageListTicketResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: PageListTicketResponseBody = None,
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
            temp_model = PageListTicketResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


