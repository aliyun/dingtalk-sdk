# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class DeleteKnowledgeHeaders(TeaModel):
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


class DeleteKnowledgeRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_team_id: str = None,
        library_key: str = None,
        source: str = None,
        source_primary_key: str = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 开放团队ID
        self.open_team_id = open_team_id
        # 知识库的唯一标识 比如:天工知识库ID
        self.library_key = library_key
        # 知识点来源 CCM:天工知识库
        self.source = source
        # 知识点唯一标识
        self.source_primary_key = source_primary_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.library_key is not None:
            result['libraryKey'] = self.library_key
        if self.source is not None:
            result['source'] = self.source
        if self.source_primary_key is not None:
            result['sourcePrimaryKey'] = self.source_primary_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('libraryKey') is not None:
            self.library_key = m.get('libraryKey')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('sourcePrimaryKey') is not None:
            self.source_primary_key = m.get('sourcePrimaryKey')
        return self


class DeleteKnowledgeResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 是否成功
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteKnowledgeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteKnowledgeResponseBody = None,
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
            temp_model = DeleteKnowledgeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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


class CreateTicketRequestSceneContextGroupMsgs(TeaModel):
    def __init__(
        self,
        open_msg_id: str = None,
        anchor: bool = None,
    ):
        # 勾选消息openMsgId
        self.open_msg_id = open_msg_id
        # 是否为锚点消息
        self.anchor = anchor

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_msg_id is not None:
            result['openMsgId'] = self.open_msg_id
        if self.anchor is not None:
            result['anchor'] = self.anchor
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openMsgId') is not None:
            self.open_msg_id = m.get('openMsgId')
        if m.get('anchor') is not None:
            self.anchor = m.get('anchor')
        return self


class CreateTicketRequestSceneContext(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        relevantor_union_ids: List[str] = None,
        group_msgs: List[CreateTicketRequestSceneContextGroupMsgs] = None,
        topic_id: str = None,
    ):
        # 服务群openConversationId
        self.open_conversation_id = open_conversation_id
        # 工单相关人UnionId列表
        self.relevantor_union_ids = relevantor_union_ids
        # 工单相关的群消息列表
        self.group_msgs = group_msgs
        # VOC类型工单，对应话题ID
        self.topic_id = topic_id

    def validate(self):
        if self.group_msgs:
            for k in self.group_msgs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.relevantor_union_ids is not None:
            result['relevantorUnionIds'] = self.relevantor_union_ids
        result['groupMsgs'] = []
        if self.group_msgs is not None:
            for k in self.group_msgs:
                result['groupMsgs'].append(k.to_map() if k else None)
        if self.topic_id is not None:
            result['topicId'] = self.topic_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('relevantorUnionIds') is not None:
            self.relevantor_union_ids = m.get('relevantorUnionIds')
        self.group_msgs = []
        if m.get('groupMsgs') is not None:
            for k in m.get('groupMsgs'):
                temp_model = CreateTicketRequestSceneContextGroupMsgs()
                self.group_msgs.append(temp_model.from_map(k))
        if m.get('topicId') is not None:
            self.topic_id = m.get('topicId')
        return self


class CreateTicketRequestNotify(TeaModel):
    def __init__(
        self,
        work_notice_receiver_union_ids: List[str] = None,
        group_notice_receiver_union_ids: List[str] = None,
        notice_all_group_member: bool = None,
    ):
        # 企业工作通知接收人（钉钉UnionId）
        self.work_notice_receiver_union_ids = work_notice_receiver_union_ids
        # 服务群通知接收人（钉钉UnionId）
        self.group_notice_receiver_union_ids = group_notice_receiver_union_ids
        # 是否向群内推送一个全员可见工单通知卡片
        self.notice_all_group_member = notice_all_group_member

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.work_notice_receiver_union_ids is not None:
            result['workNoticeReceiverUnionIds'] = self.work_notice_receiver_union_ids
        if self.group_notice_receiver_union_ids is not None:
            result['groupNoticeReceiverUnionIds'] = self.group_notice_receiver_union_ids
        if self.notice_all_group_member is not None:
            result['noticeAllGroupMember'] = self.notice_all_group_member
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('workNoticeReceiverUnionIds') is not None:
            self.work_notice_receiver_union_ids = m.get('workNoticeReceiverUnionIds')
        if m.get('groupNoticeReceiverUnionIds') is not None:
            self.group_notice_receiver_union_ids = m.get('groupNoticeReceiverUnionIds')
        if m.get('noticeAllGroupMember') is not None:
            self.notice_all_group_member = m.get('noticeAllGroupMember')
        return self


class CreateTicketRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_team_id: str = None,
        creator_union_id: str = None,
        processor_union_ids: List[str] = None,
        scene: str = None,
        scene_context: CreateTicketRequestSceneContext = None,
        open_template_biz_id: str = None,
        title: str = None,
        custom_fields: str = None,
        notify: CreateTicketRequestNotify = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 开放团队ID
        self.open_team_id = open_team_id
        # 工单创建人UnionId
        self.creator_union_id = creator_union_id
        # 工单处理人UnionId列表
        self.processor_union_ids = processor_union_ids
        # 工单场景 SG 或 VOC
        self.scene = scene
        # 工单场景信息
        self.scene_context = scene_context
        # 工单模板业务ID
        self.open_template_biz_id = open_template_biz_id
        # 工单标题
        self.title = title
        # 自定义组件字段值(JSON格式)
        self.custom_fields = custom_fields
        # 通知接收人配置
        self.notify = notify

    def validate(self):
        if self.scene_context:
            self.scene_context.validate()
        if self.notify:
            self.notify.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.processor_union_ids is not None:
            result['processorUnionIds'] = self.processor_union_ids
        if self.scene is not None:
            result['scene'] = self.scene
        if self.scene_context is not None:
            result['sceneContext'] = self.scene_context.to_map()
        if self.open_template_biz_id is not None:
            result['openTemplateBizId'] = self.open_template_biz_id
        if self.title is not None:
            result['title'] = self.title
        if self.custom_fields is not None:
            result['customFields'] = self.custom_fields
        if self.notify is not None:
            result['notify'] = self.notify.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('processorUnionIds') is not None:
            self.processor_union_ids = m.get('processorUnionIds')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('sceneContext') is not None:
            temp_model = CreateTicketRequestSceneContext()
            self.scene_context = temp_model.from_map(m['sceneContext'])
        if m.get('openTemplateBizId') is not None:
            self.open_template_biz_id = m.get('openTemplateBizId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('customFields') is not None:
            self.custom_fields = m.get('customFields')
        if m.get('notify') is not None:
            temp_model = CreateTicketRequestNotify()
            self.notify = temp_model.from_map(m['notify'])
        return self


class CreateTicketResponseBody(TeaModel):
    def __init__(
        self,
        open_ticket_id: str = None,
    ):
        # 工单开放ID
        self.open_ticket_id = open_ticket_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
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


class AssignTicketHeaders(TeaModel):
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


class AssignTicketRequestTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        # 文件名
        self.file_name = file_name
        # 文件key
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class AssignTicketRequestTicketMemo(TeaModel):
    def __init__(
        self,
        memo: str = None,
        attachments: List[AssignTicketRequestTicketMemoAttachments] = None,
    ):
        # 备注文字
        self.memo = memo
        # 备注相关的附件
        self.attachments = attachments

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.memo is not None:
            result['memo'] = self.memo
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = AssignTicketRequestTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        return self


class AssignTicketRequestNotify(TeaModel):
    def __init__(
        self,
        work_notice_receiver_union_ids: List[str] = None,
        group_notice_receiver_union_ids: List[str] = None,
        notice_all_group_member: bool = None,
    ):
        self.work_notice_receiver_union_ids = work_notice_receiver_union_ids
        self.group_notice_receiver_union_ids = group_notice_receiver_union_ids
        # 是否向群内推送一个全员可见工单通知卡片
        self.notice_all_group_member = notice_all_group_member

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.work_notice_receiver_union_ids is not None:
            result['workNoticeReceiverUnionIds'] = self.work_notice_receiver_union_ids
        if self.group_notice_receiver_union_ids is not None:
            result['groupNoticeReceiverUnionIds'] = self.group_notice_receiver_union_ids
        if self.notice_all_group_member is not None:
            result['noticeAllGroupMember'] = self.notice_all_group_member
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('workNoticeReceiverUnionIds') is not None:
            self.work_notice_receiver_union_ids = m.get('workNoticeReceiverUnionIds')
        if m.get('groupNoticeReceiverUnionIds') is not None:
            self.group_notice_receiver_union_ids = m.get('groupNoticeReceiverUnionIds')
        if m.get('noticeAllGroupMember') is not None:
            self.notice_all_group_member = m.get('noticeAllGroupMember')
        return self


class AssignTicketRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        operator_union_id: str = None,
        open_ticket_id: str = None,
        processor_union_ids: List[str] = None,
        ticket_memo: AssignTicketRequestTicketMemo = None,
        notify: AssignTicketRequestNotify = None,
        open_team_id: str = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 操作人unionId（管理员）
        self.operator_union_id = operator_union_id
        # 工单开放ID
        self.open_ticket_id = open_ticket_id
        self.processor_union_ids = processor_union_ids
        # 备注
        self.ticket_memo = ticket_memo
        self.notify = notify
        # 开放团队ID
        self.open_team_id = open_team_id

    def validate(self):
        if self.ticket_memo:
            self.ticket_memo.validate()
        if self.notify:
            self.notify.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.processor_union_ids is not None:
            result['processorUnionIds'] = self.processor_union_ids
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        if self.notify is not None:
            result['notify'] = self.notify.to_map()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('processorUnionIds') is not None:
            self.processor_union_ids = m.get('processorUnionIds')
        if m.get('ticketMemo') is not None:
            temp_model = AssignTicketRequestTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        if m.get('notify') is not None:
            temp_model = AssignTicketRequestNotify()
            self.notify = temp_model.from_map(m['notify'])
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class AssignTicketResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class FinishTicketHeaders(TeaModel):
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


class FinishTicketRequestTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        # 文件名
        self.file_name = file_name
        # 文件key
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class FinishTicketRequestTicketMemo(TeaModel):
    def __init__(
        self,
        memo: str = None,
        attachments: List[FinishTicketRequestTicketMemoAttachments] = None,
    ):
        # 备注文字
        self.memo = memo
        # 备注相关的附件
        self.attachments = attachments

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.memo is not None:
            result['memo'] = self.memo
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = FinishTicketRequestTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        return self


class FinishTicketRequestNotify(TeaModel):
    def __init__(
        self,
        work_notice_receiver_union_ids: List[str] = None,
        group_notice_receiver_union_ids: List[str] = None,
        notice_all_group_member: bool = None,
    ):
        # 企业工作通知接收人（钉钉UnionId）
        self.work_notice_receiver_union_ids = work_notice_receiver_union_ids
        # 群中通知接收人（钉钉UnionId）
        self.group_notice_receiver_union_ids = group_notice_receiver_union_ids
        # 是否向群内推送一个全员可见工单通知卡片
        self.notice_all_group_member = notice_all_group_member

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.work_notice_receiver_union_ids is not None:
            result['workNoticeReceiverUnionIds'] = self.work_notice_receiver_union_ids
        if self.group_notice_receiver_union_ids is not None:
            result['groupNoticeReceiverUnionIds'] = self.group_notice_receiver_union_ids
        if self.notice_all_group_member is not None:
            result['noticeAllGroupMember'] = self.notice_all_group_member
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('workNoticeReceiverUnionIds') is not None:
            self.work_notice_receiver_union_ids = m.get('workNoticeReceiverUnionIds')
        if m.get('groupNoticeReceiverUnionIds') is not None:
            self.group_notice_receiver_union_ids = m.get('groupNoticeReceiverUnionIds')
        if m.get('noticeAllGroupMember') is not None:
            self.notice_all_group_member = m.get('noticeAllGroupMember')
        return self


class FinishTicketRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_team_id: str = None,
        processor_union_id: str = None,
        open_ticket_id: str = None,
        ticket_memo: FinishTicketRequestTicketMemo = None,
        notify: FinishTicketRequestNotify = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        self.open_team_id = open_team_id
        # 当前工单处理人
        self.processor_union_id = processor_union_id
        # 工单开放id
        self.open_ticket_id = open_ticket_id
        # 备注
        self.ticket_memo = ticket_memo
        # 工单通知
        self.notify = notify

    def validate(self):
        if self.ticket_memo:
            self.ticket_memo.validate()
        if self.notify:
            self.notify.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.processor_union_id is not None:
            result['processorUnionId'] = self.processor_union_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        if self.notify is not None:
            result['notify'] = self.notify.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('processorUnionId') is not None:
            self.processor_union_id = m.get('processorUnionId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('ticketMemo') is not None:
            temp_model = FinishTicketRequestTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        if m.get('notify') is not None:
            temp_model = FinishTicketRequestNotify()
            self.notify = temp_model.from_map(m['notify'])
        return self


class FinishTicketResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class SearchGroupHeaders(TeaModel):
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


class SearchGroupRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_conversation_id: str = None,
        group_name: str = None,
        open_team_id: str = None,
        open_group_set_id: str = None,
        next_token: str = None,
        max_results: int = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 群名称
        self.group_name = group_name
        # 开放团队ID
        self.open_team_id = open_team_id
        # 开群组ID
        self.open_group_set_id = open_group_set_id
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
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class SearchGroupResponseBodyRecords(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        group_name: str = None,
        open_team_id: str = None,
        open_group_set_id: str = None,
    ):
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 群名称
        self.group_name = group_name
        # 开放团队ID
        self.open_team_id = open_team_id
        # 开放群组ID
        self.open_group_set_id = open_group_set_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        return self


class SearchGroupResponseBody(TeaModel):
    def __init__(
        self,
        total_count: int = None,
        next_token: str = None,
        max_results: int = None,
        records: List[SearchGroupResponseBodyRecords] = None,
    ):
        # 本次请求条件下的数据总量，此参数为可选参数，默认可不返回。本次请求条件下的数据总量，此参数为可选参数，默认可不返回
        self.total_count = total_count
        # 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        self.next_token = next_token
        # 本次请求所返回的最大记录条数。
        self.max_results = max_results
        # 已读未读信息列表
        self.records = records

    def validate(self):
        if self.records:
            for k in self.records:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = SearchGroupResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        return self


class SearchGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SearchGroupResponseBody = None,
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
            temp_model = SearchGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTicketHeaders(TeaModel):
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


class UpdateTicketRequestTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        # 文件名
        self.file_name = file_name
        # 文件key
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class UpdateTicketRequestTicketMemo(TeaModel):
    def __init__(
        self,
        memo: str = None,
        attachments: List[UpdateTicketRequestTicketMemoAttachments] = None,
    ):
        # 备注文字
        self.memo = memo
        # 备注相关的附件
        self.attachments = attachments

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.memo is not None:
            result['memo'] = self.memo
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = UpdateTicketRequestTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        return self


class UpdateTicketRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_team_id: str = None,
        processor_union_id: str = None,
        open_ticket_id: str = None,
        custom_fields: str = None,
        ticket_memo: UpdateTicketRequestTicketMemo = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 团队ID
        self.open_team_id = open_team_id
        # 工单处理人unionId
        self.processor_union_id = processor_union_id
        # 工单开放id
        self.open_ticket_id = open_ticket_id
        # 自定义字段值JSON格式
        self.custom_fields = custom_fields
        # 备注
        self.ticket_memo = ticket_memo

    def validate(self):
        if self.ticket_memo:
            self.ticket_memo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.processor_union_id is not None:
            result['processorUnionId'] = self.processor_union_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.custom_fields is not None:
            result['customFields'] = self.custom_fields
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('processorUnionId') is not None:
            self.processor_union_id = m.get('processorUnionId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('customFields') is not None:
            self.custom_fields = m.get('customFields')
        if m.get('ticketMemo') is not None:
            temp_model = UpdateTicketRequestTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        return self


class UpdateTicketResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class CreateGroupHeaders(TeaModel):
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


class CreateGroupRequest(TeaModel):
    def __init__(
        self,
        group_biz_id: str = None,
        open_team_id: str = None,
        open_group_set_id: str = None,
        group_name: str = None,
        owner_staff_id: str = None,
        member_staff_ids: List[str] = None,
        group_tag_names: List[str] = None,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
    ):
        # 业务关联id
        self.group_biz_id = group_biz_id
        # 开放团队ID
        self.open_team_id = open_team_id
        # 开放群组ID
        self.open_group_set_id = open_group_set_id
        # 群名称
        self.group_name = group_name
        # 群主员工ID
        self.owner_staff_id = owner_staff_id
        # 群成员员工ID列表
        self.member_staff_ids = member_staff_ids
        # 群标签
        self.group_tag_names = group_tag_names
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_biz_id is not None:
            result['groupBizId'] = self.group_biz_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.owner_staff_id is not None:
            result['ownerStaffId'] = self.owner_staff_id
        if self.member_staff_ids is not None:
            result['memberStaffIds'] = self.member_staff_ids
        if self.group_tag_names is not None:
            result['groupTagNames'] = self.group_tag_names
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupBizId') is not None:
            self.group_biz_id = m.get('groupBizId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('ownerStaffId') is not None:
            self.owner_staff_id = m.get('ownerStaffId')
        if m.get('memberStaffIds') is not None:
            self.member_staff_ids = m.get('memberStaffIds')
        if m.get('groupTagNames') is not None:
            self.group_tag_names = m.get('groupTagNames')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        return self


class CreateGroupResponseBody(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        group_url: str = None,
    ):
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 入群url
        self.group_url = group_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.group_url is not None:
            result['groupUrl'] = self.group_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('groupUrl') is not None:
            self.group_url = m.get('groupUrl')
        return self


class CreateGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateGroupResponseBody = None,
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
            temp_model = CreateGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TransferTicketHeaders(TeaModel):
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


class TransferTicketRequestTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        self.file_name = file_name
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class TransferTicketRequestTicketMemo(TeaModel):
    def __init__(
        self,
        memo: str = None,
        attachments: List[TransferTicketRequestTicketMemoAttachments] = None,
    ):
        # 文字备注
        self.memo = memo
        # 备注相关的附件
        self.attachments = attachments

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.memo is not None:
            result['memo'] = self.memo
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = TransferTicketRequestTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        return self


class TransferTicketRequestNotify(TeaModel):
    def __init__(
        self,
        work_notice_receiver_union_ids: List[str] = None,
        group_notice_receiver_union_ids: List[str] = None,
        notice_all_group_member: bool = None,
    ):
        # 企业工作通知接收人（钉钉UnionId）
        self.work_notice_receiver_union_ids = work_notice_receiver_union_ids
        # 群中通知接收人（钉钉UnionId）
        self.group_notice_receiver_union_ids = group_notice_receiver_union_ids
        # 是否向群内推送一个全员可见工单通知卡片
        self.notice_all_group_member = notice_all_group_member

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.work_notice_receiver_union_ids is not None:
            result['workNoticeReceiverUnionIds'] = self.work_notice_receiver_union_ids
        if self.group_notice_receiver_union_ids is not None:
            result['groupNoticeReceiverUnionIds'] = self.group_notice_receiver_union_ids
        if self.notice_all_group_member is not None:
            result['noticeAllGroupMember'] = self.notice_all_group_member
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('workNoticeReceiverUnionIds') is not None:
            self.work_notice_receiver_union_ids = m.get('workNoticeReceiverUnionIds')
        if m.get('groupNoticeReceiverUnionIds') is not None:
            self.group_notice_receiver_union_ids = m.get('groupNoticeReceiverUnionIds')
        if m.get('noticeAllGroupMember') is not None:
            self.notice_all_group_member = m.get('noticeAllGroupMember')
        return self


class TransferTicketRequest(TeaModel):
    def __init__(
        self,
        processor_union_id: str = None,
        open_ticket_id: str = None,
        processor_union_ids: List[str] = None,
        ticket_memo: TransferTicketRequestTicketMemo = None,
        notify: TransferTicketRequestNotify = None,
        open_team_id: str = None,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
    ):
        # 工单处理人
        self.processor_union_id = processor_union_id
        # 工单开放ID
        self.open_ticket_id = open_ticket_id
        # 被转单人UnionId列表
        self.processor_union_ids = processor_union_ids
        # 工单备注
        self.ticket_memo = ticket_memo
        self.notify = notify
        # 开放团队ID
        self.open_team_id = open_team_id
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type

    def validate(self):
        if self.ticket_memo:
            self.ticket_memo.validate()
        if self.notify:
            self.notify.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.processor_union_id is not None:
            result['processorUnionId'] = self.processor_union_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.processor_union_ids is not None:
            result['processorUnionIds'] = self.processor_union_ids
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        if self.notify is not None:
            result['notify'] = self.notify.to_map()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processorUnionId') is not None:
            self.processor_union_id = m.get('processorUnionId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('processorUnionIds') is not None:
            self.processor_union_ids = m.get('processorUnionIds')
        if m.get('ticketMemo') is not None:
            temp_model = TransferTicketRequestTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        if m.get('notify') is not None:
            temp_model = TransferTicketRequestNotify()
            self.notify = temp_model.from_map(m['notify'])
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        return self


class TransferTicketResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class AddKnowledgeHeaders(TeaModel):
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


class AddKnowledgeRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_team_id: str = None,
        library_key: str = None,
        source: str = None,
        source_primary_key: str = None,
        type: str = None,
        title: str = None,
        content: str = None,
        link_url: str = None,
        version: str = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 开放团队ID
        self.open_team_id = open_team_id
        # 知识库的唯一标识
        self.library_key = library_key
        # 知识点来源
        self.source = source
        # 知识点唯一标识
        self.source_primary_key = source_primary_key
        # 知识点类型 NORMAL：普通型 CARD：卡片 CONDITION：条件
        self.type = type
        # 知识点名称
        self.title = title
        # 知识点内容
        self.content = content
        # CCM的知识点外链
        self.link_url = link_url
        # 知识点版本号
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.library_key is not None:
            result['libraryKey'] = self.library_key
        if self.source is not None:
            result['source'] = self.source
        if self.source_primary_key is not None:
            result['sourcePrimaryKey'] = self.source_primary_key
        if self.type is not None:
            result['type'] = self.type
        if self.title is not None:
            result['title'] = self.title
        if self.content is not None:
            result['content'] = self.content
        if self.link_url is not None:
            result['linkUrl'] = self.link_url
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('libraryKey') is not None:
            self.library_key = m.get('libraryKey')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('sourcePrimaryKey') is not None:
            self.source_primary_key = m.get('sourcePrimaryKey')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('linkUrl') is not None:
            self.link_url = m.get('linkUrl')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class AddKnowledgeResponseBody(TeaModel):
    def __init__(
        self,
        open_knowledge_id: str = None,
    ):
        # 开放知识点ID
        self.open_knowledge_id = open_knowledge_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_knowledge_id is not None:
            result['openKnowledgeId'] = self.open_knowledge_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openKnowledgeId') is not None:
            self.open_knowledge_id = m.get('openKnowledgeId')
        return self


class AddKnowledgeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddKnowledgeResponseBody = None,
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
            temp_model = AddKnowledgeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchGetGroupSetConfigHeaders(TeaModel):
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


class BatchGetGroupSetConfigRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_team_id: str = None,
        open_group_set_id: str = None,
        config_keys: List[str] = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 开放团队id
        self.open_team_id = open_team_id
        # 开放群组id
        self.open_group_set_id = open_group_set_id
        # 配置项key列表
        self.config_keys = config_keys

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.config_keys is not None:
            result['configKeys'] = self.config_keys
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('configKeys') is not None:
            self.config_keys = m.get('configKeys')
        return self


class BatchGetGroupSetConfigResponseBodyGroupSetConfigs(TeaModel):
    def __init__(
        self,
        config_key: str = None,
        config_value: str = None,
    ):
        # 配置项key
        self.config_key = config_key
        # 配置项值
        self.config_value = config_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.config_key is not None:
            result['configKey'] = self.config_key
        if self.config_value is not None:
            result['configValue'] = self.config_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('configKey') is not None:
            self.config_key = m.get('configKey')
        if m.get('configValue') is not None:
            self.config_value = m.get('configValue')
        return self


class BatchGetGroupSetConfigResponseBody(TeaModel):
    def __init__(
        self,
        group_set_configs: List[BatchGetGroupSetConfigResponseBodyGroupSetConfigs] = None,
    ):
        # 群粗配置列表
        self.group_set_configs = group_set_configs

    def validate(self):
        if self.group_set_configs:
            for k in self.group_set_configs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupSetConfigs'] = []
        if self.group_set_configs is not None:
            for k in self.group_set_configs:
                result['groupSetConfigs'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_set_configs = []
        if m.get('groupSetConfigs') is not None:
            for k in m.get('groupSetConfigs'):
                temp_model = BatchGetGroupSetConfigResponseBodyGroupSetConfigs()
                self.group_set_configs.append(temp_model.from_map(k))
        return self


class BatchGetGroupSetConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: BatchGetGroupSetConfigResponseBody = None,
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
            temp_model = BatchGetGroupSetConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListTicketOperateRecordHeaders(TeaModel):
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


class ListTicketOperateRecordRequest(TeaModel):
    def __init__(
        self,
        open_team_id: str = None,
        open_ticket_id: str = None,
    ):
        # 开放团队ID
        self.open_team_id = open_team_id
        # 工单开放ID
        self.open_ticket_id = open_ticket_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        return self


class ListTicketOperateRecordResponseBodyRecordsOperator(TeaModel):
    def __init__(
        self,
        union_id: str = None,
        nick_name: str = None,
    ):
        self.union_id = union_id
        self.nick_name = nick_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        return self


class ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        self.file_name = file_name
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class ListTicketOperateRecordResponseBodyRecordsTicketMemo(TeaModel):
    def __init__(
        self,
        memo: str = None,
        attachments: List[ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments] = None,
    ):
        self.memo = memo
        self.attachments = attachments

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.memo is not None:
            result['memo'] = self.memo
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        return self


class ListTicketOperateRecordResponseBodyRecords(TeaModel):
    def __init__(
        self,
        open_ticket_id: str = None,
        operate_time: str = None,
        operation: str = None,
        operation_display_name: str = None,
        operator: ListTicketOperateRecordResponseBodyRecordsOperator = None,
        ticket_memo: ListTicketOperateRecordResponseBodyRecordsTicketMemo = None,
        operate_data: str = None,
    ):
        # 工单开放ID
        self.open_ticket_id = open_ticket_id
        # 操作时间
        self.operate_time = operate_time
        # 动作
        self.operation = operation
        # 动作展示名
        self.operation_display_name = operation_display_name
        self.operator = operator
        self.ticket_memo = ticket_memo
        self.operate_data = operate_data

    def validate(self):
        if self.operator:
            self.operator.validate()
        if self.ticket_memo:
            self.ticket_memo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.operate_time is not None:
            result['operateTime'] = self.operate_time
        if self.operation is not None:
            result['operation'] = self.operation
        if self.operation_display_name is not None:
            result['operationDisplayName'] = self.operation_display_name
        if self.operator is not None:
            result['operator'] = self.operator.to_map()
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        if self.operate_data is not None:
            result['operateData'] = self.operate_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('operateTime') is not None:
            self.operate_time = m.get('operateTime')
        if m.get('operation') is not None:
            self.operation = m.get('operation')
        if m.get('operationDisplayName') is not None:
            self.operation_display_name = m.get('operationDisplayName')
        if m.get('operator') is not None:
            temp_model = ListTicketOperateRecordResponseBodyRecordsOperator()
            self.operator = temp_model.from_map(m['operator'])
        if m.get('ticketMemo') is not None:
            temp_model = ListTicketOperateRecordResponseBodyRecordsTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        if m.get('operateData') is not None:
            self.operate_data = m.get('operateData')
        return self


class ListTicketOperateRecordResponseBody(TeaModel):
    def __init__(
        self,
        records: List[ListTicketOperateRecordResponseBodyRecords] = None,
    ):
        # Id of the request
        self.records = records

    def validate(self):
        if self.records:
            for k in self.records:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = ListTicketOperateRecordResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        return self


class ListTicketOperateRecordResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListTicketOperateRecordResponseBody = None,
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
            temp_model = ListTicketOperateRecordResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryServiceGroupMessageReadStatusHeaders(TeaModel):
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


class QueryServiceGroupMessageReadStatusRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_token_grant_type: int = None,
        ding_suite_key: str = None,
        open_team_id: str = None,
        open_conversation_id: str = None,
        open_msg_task_id: str = None,
        next_token: str = None,
        max_results: int = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_suite_key = ding_suite_key
        # 开放团队ID
        self.open_team_id = open_team_id
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 开放消息ID
        self.open_msg_task_id = open_msg_task_id
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
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_msg_task_id is not None:
            result['openMsgTaskId'] = self.open_msg_task_id
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openMsgTaskId') is not None:
            self.open_msg_task_id = m.get('openMsgTaskId')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class QueryServiceGroupMessageReadStatusResponseBodyRecords(TeaModel):
    def __init__(
        self,
        receiver_user_id: str = None,
        receiver_union_id: str = None,
        read_status: int = None,
        receiver_name: str = None,
        receiver_ding_talk_id: str = None,
    ):
        # 已读人员为企业员工则有值
        self.receiver_user_id = receiver_user_id
        # 已读人员为非企业员工则有值
        self.receiver_union_id = receiver_union_id
        # 状态：已读1/未读0
        self.read_status = read_status
        # 接收者昵称
        self.receiver_name = receiver_name
        # 接收者dingtalkId
        self.receiver_ding_talk_id = receiver_ding_talk_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.receiver_user_id is not None:
            result['receiverUserId'] = self.receiver_user_id
        if self.receiver_union_id is not None:
            result['receiverUnionId'] = self.receiver_union_id
        if self.read_status is not None:
            result['readStatus'] = self.read_status
        if self.receiver_name is not None:
            result['receiverName'] = self.receiver_name
        if self.receiver_ding_talk_id is not None:
            result['receiverDingTalkId'] = self.receiver_ding_talk_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('receiverUserId') is not None:
            self.receiver_user_id = m.get('receiverUserId')
        if m.get('receiverUnionId') is not None:
            self.receiver_union_id = m.get('receiverUnionId')
        if m.get('readStatus') is not None:
            self.read_status = m.get('readStatus')
        if m.get('receiverName') is not None:
            self.receiver_name = m.get('receiverName')
        if m.get('receiverDingTalkId') is not None:
            self.receiver_ding_talk_id = m.get('receiverDingTalkId')
        return self


class QueryServiceGroupMessageReadStatusResponseBody(TeaModel):
    def __init__(
        self,
        total_count: int = None,
        next_token: str = None,
        max_results: int = None,
        records: List[QueryServiceGroupMessageReadStatusResponseBodyRecords] = None,
    ):
        # 本次请求条件下的数据总量，此参数为可选参数，默认可不返回。本次请求条件下的数据总量，此参数为可选参数，默认可不返回
        self.total_count = total_count
        # 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        self.next_token = next_token
        # 本次请求所返回的最大记录条数。
        self.max_results = max_results
        # 已读未读信息列表
        self.records = records

    def validate(self):
        if self.records:
            for k in self.records:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = QueryServiceGroupMessageReadStatusResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        return self


class QueryServiceGroupMessageReadStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryServiceGroupMessageReadStatusResponseBody = None,
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
            temp_model = QueryServiceGroupMessageReadStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddLibraryHeaders(TeaModel):
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


class AddLibraryRequest(TeaModel):
    def __init__(
        self,
        ding_token_grant_type: int = None,
        ding_isv_org_id: int = None,
        ding_suite_key: str = None,
        ding_org_id: int = None,
        open_team_ids: List[str] = None,
        title: str = None,
        description: str = None,
        type: str = None,
        source: str = None,
        source_primary_key: str = None,
        user_id: str = None,
    ):
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_org_id = ding_org_id
        # 团队id列表
        self.open_team_ids = open_team_ids
        # 知识库名称
        self.title = title
        # 知识库描述
        self.description = description
        # 知识库类型 INTERNAL:内部知识库 EXTERNAL:外部知识库
        self.type = type
        # 知识来源
        self.source = source
        # 知识库的唯一性标识
        self.source_primary_key = source_primary_key
        # 员工ID
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.open_team_ids is not None:
            result['openTeamIds'] = self.open_team_ids
        if self.title is not None:
            result['title'] = self.title
        if self.description is not None:
            result['description'] = self.description
        if self.type is not None:
            result['type'] = self.type
        if self.source is not None:
            result['source'] = self.source
        if self.source_primary_key is not None:
            result['sourcePrimaryKey'] = self.source_primary_key
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('openTeamIds') is not None:
            self.open_team_ids = m.get('openTeamIds')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('sourcePrimaryKey') is not None:
            self.source_primary_key = m.get('sourcePrimaryKey')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class AddLibraryResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # success
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AddLibraryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddLibraryResponseBody = None,
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
            temp_model = AddLibraryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGroupHeaders(TeaModel):
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


class QueryGroupRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_team_id: str = None,
        open_conversation_id: str = None,
        biz_id: str = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 开放团队ID
        self.open_team_id = open_team_id
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 业务关联ID，和开放群ID二选一传
        self.biz_id = biz_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        return self


class QueryGroupResponseBody(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        group_name: str = None,
        open_team_id: str = None,
        open_group_set_id: str = None,
        group_url: str = None,
        robot_code: str = None,
        robot_name: str = None,
        biz_id: str = None,
    ):
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 群名称
        self.group_name = group_name
        # 开放团队ID
        self.open_team_id = open_team_id
        # 开放群组ID
        self.open_group_set_id = open_group_set_id
        # 入群URL
        self.group_url = group_url
        # 服务群机器人code
        self.robot_code = robot_code
        # 服务群机器人名称
        self.robot_name = robot_name
        # 群bizId
        self.biz_id = biz_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.group_url is not None:
            result['groupUrl'] = self.group_url
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.robot_name is not None:
            result['robotName'] = self.robot_name
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('groupUrl') is not None:
            self.group_url = m.get('groupUrl')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('robotName') is not None:
            self.robot_name = m.get('robotName')
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        return self


class QueryGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryGroupResponseBody = None,
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
            temp_model = QueryGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CloseHumanSessionHeaders(TeaModel):
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


class CloseHumanSessionRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_team_id: str = None,
        open_conversation_id: str = None,
        visitor_union_id: int = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 开放团队id
        self.open_team_id = open_team_id
        # 开放会话id
        self.open_conversation_id = open_conversation_id
        # 访客unionid
        self.visitor_union_id = visitor_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.visitor_union_id is not None:
            result['visitorUnionId'] = self.visitor_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('visitorUnionId') is not None:
            self.visitor_union_id = m.get('visitorUnionId')
        return self


class CloseHumanSessionResponseBody(TeaModel):
    def __init__(
        self,
        session_id: int = None,
    ):
        self.session_id = session_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.session_id is not None:
            result['sessionId'] = self.session_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sessionId') is not None:
            self.session_id = m.get('sessionId')
        return self


class CloseHumanSessionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CloseHumanSessionResponseBody = None,
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
            temp_model = CloseHumanSessionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UrgeTicketHeaders(TeaModel):
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


class UrgeTicketRequestTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        # 文件名
        self.file_name = file_name
        # 文件key
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class UrgeTicketRequestTicketMemo(TeaModel):
    def __init__(
        self,
        memo: str = None,
        attachments: List[UrgeTicketRequestTicketMemoAttachments] = None,
    ):
        # 备注文字
        self.memo = memo
        # 备注相关的附件
        self.attachments = attachments

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.memo is not None:
            result['memo'] = self.memo
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = UrgeTicketRequestTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        return self


class UrgeTicketRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        operator_union_id: str = None,
        open_ticket_id: str = None,
        ticket_memo: UrgeTicketRequestTicketMemo = None,
        open_team_id: str = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 工单催单操作人UnionId
        self.operator_union_id = operator_union_id
        # 工单开放id
        self.open_ticket_id = open_ticket_id
        # 备注
        self.ticket_memo = ticket_memo
        # 开放团队ID
        self.open_team_id = open_team_id

    def validate(self):
        if self.ticket_memo:
            self.ticket_memo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('ticketMemo') is not None:
            temp_model = UrgeTicketRequestTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class UrgeTicketResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class GetTicketHeaders(TeaModel):
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


class GetTicketRequest(TeaModel):
    def __init__(
        self,
        open_team_id: str = None,
        open_ticket_id: str = None,
    ):
        # eKWh3GBwsKEiE
        self.open_team_id = open_team_id
        # hNiPO2OVktNMiE
        self.open_ticket_id = open_ticket_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        return self


class GetTicketResponseBodyCreator(TeaModel):
    def __init__(
        self,
        union_id: str = None,
        nick_name: str = None,
    ):
        self.union_id = union_id
        self.nick_name = nick_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        return self


class GetTicketResponseBodyProcessor(TeaModel):
    def __init__(
        self,
        union_id: str = None,
        nick_name: str = None,
    ):
        self.union_id = union_id
        self.nick_name = nick_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        return self


class GetTicketResponseBodyTakers(TeaModel):
    def __init__(
        self,
        union_id: str = None,
        nick_name: str = None,
    ):
        self.union_id = union_id
        self.nick_name = nick_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        return self


class GetTicketResponseBodyTemplate(TeaModel):
    def __init__(
        self,
        open_template_id: str = None,
        open_template_biz_id: str = None,
        template_name: str = None,
    ):
        # 工单模版ID
        self.open_template_id = open_template_id
        # 工单模版业务ID
        self.open_template_biz_id = open_template_biz_id
        # 工单模版名称
        self.template_name = template_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_template_id is not None:
            result['openTemplateId'] = self.open_template_id
        if self.open_template_biz_id is not None:
            result['openTemplateBizId'] = self.open_template_biz_id
        if self.template_name is not None:
            result['templateName'] = self.template_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTemplateId') is not None:
            self.open_template_id = m.get('openTemplateId')
        if m.get('openTemplateBizId') is not None:
            self.open_template_biz_id = m.get('openTemplateBizId')
        if m.get('templateName') is not None:
            self.template_name = m.get('templateName')
        return self


class GetTicketResponseBody(TeaModel):
    def __init__(
        self,
        open_ticket_id: str = None,
        create_time: str = None,
        update_time: str = None,
        open_conversation_id: str = None,
        creator: GetTicketResponseBodyCreator = None,
        processor: GetTicketResponseBodyProcessor = None,
        takers: List[GetTicketResponseBodyTakers] = None,
        stage: str = None,
        title: str = None,
        custom_fields: str = None,
        scene: str = None,
        scene_context: str = None,
        template: GetTicketResponseBodyTemplate = None,
    ):
        # Id of the request
        self.open_ticket_id = open_ticket_id
        self.create_time = create_time
        self.update_time = update_time
        self.open_conversation_id = open_conversation_id
        self.creator = creator
        self.processor = processor
        self.takers = takers
        self.stage = stage
        self.title = title
        self.custom_fields = custom_fields
        self.scene = scene
        self.scene_context = scene_context
        self.template = template

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.processor:
            self.processor.validate()
        if self.takers:
            for k in self.takers:
                if k:
                    k.validate()
        if self.template:
            self.template.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.processor is not None:
            result['processor'] = self.processor.to_map()
        result['takers'] = []
        if self.takers is not None:
            for k in self.takers:
                result['takers'].append(k.to_map() if k else None)
        if self.stage is not None:
            result['stage'] = self.stage
        if self.title is not None:
            result['title'] = self.title
        if self.custom_fields is not None:
            result['customFields'] = self.custom_fields
        if self.scene is not None:
            result['scene'] = self.scene
        if self.scene_context is not None:
            result['sceneContext'] = self.scene_context
        if self.template is not None:
            result['template'] = self.template.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('creator') is not None:
            temp_model = GetTicketResponseBodyCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('processor') is not None:
            temp_model = GetTicketResponseBodyProcessor()
            self.processor = temp_model.from_map(m['processor'])
        self.takers = []
        if m.get('takers') is not None:
            for k in m.get('takers'):
                temp_model = GetTicketResponseBodyTakers()
                self.takers.append(temp_model.from_map(k))
        if m.get('stage') is not None:
            self.stage = m.get('stage')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('customFields') is not None:
            self.custom_fields = m.get('customFields')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('sceneContext') is not None:
            self.scene_context = m.get('sceneContext')
        if m.get('template') is not None:
            temp_model = GetTicketResponseBodyTemplate()
            self.template = temp_model.from_map(m['template'])
        return self


class GetTicketResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetTicketResponseBody = None,
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
            temp_model = GetTicketResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOssTempUrlHeaders(TeaModel):
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


class GetOssTempUrlRequest(TeaModel):
    def __init__(
        self,
        open_team_id: str = None,
        key: str = None,
        file_name: str = None,
        fetch_mode: str = None,
    ):
        # 团队开放ID
        self.open_team_id = open_team_id
        # oss文件key
        self.key = key
        # 文件名
        self.file_name = file_name
        # 访问模式 AUTO(自动，例如在浏览器中如果是图片，PDF等可以在线直接查看，不能在线看时自动下载)、DOWNLOAD（直接下载）
        self.fetch_mode = fetch_mode

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.key is not None:
            result['key'] = self.key
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.fetch_mode is not None:
            result['fetchMode'] = self.fetch_mode
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fetchMode') is not None:
            self.fetch_mode = m.get('fetchMode')
        return self


class GetOssTempUrlResponseBody(TeaModel):
    def __init__(
        self,
        url: str = None,
    ):
        # Id of the request
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetOssTempUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetOssTempUrlResponseBody = None,
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
            temp_model = GetOssTempUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TakeTicketHeaders(TeaModel):
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


class TakeTicketRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_team_id: str = None,
        taker_union_id: str = None,
        open_ticket_id: str = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        self.open_team_id = open_team_id
        self.taker_union_id = taker_union_id
        self.open_ticket_id = open_ticket_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.taker_union_id is not None:
            result['takerUnionId'] = self.taker_union_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('takerUnionId') is not None:
            self.taker_union_id = m.get('takerUnionId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        return self


class TakeTicketResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class SendServiceGroupMessageHeaders(TeaModel):
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


class SendServiceGroupMessageRequestBtns(TeaModel):
    def __init__(
        self,
        action_url: str = None,
        title: str = None,
    ):
        # 跳转地址
        self.action_url = action_url
        # 按钮名称
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_url is not None:
            result['actionURL'] = self.action_url
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionURL') is not None:
            self.action_url = m.get('actionURL')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class SendServiceGroupMessageRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_token_grant_type: int = None,
        ding_suite_key: str = None,
        target_open_conversation_id: str = None,
        title: str = None,
        content: str = None,
        is_at_all: bool = None,
        at_mobiles: List[str] = None,
        at_dingtalk_ids: List[str] = None,
        at_union_ids: List[str] = None,
        receiver_mobiles: List[str] = None,
        receiver_dingtalk_ids: List[str] = None,
        receiver_union_ids: List[str] = None,
        message_type: str = None,
        btn_orientation: str = None,
        btns: List[SendServiceGroupMessageRequestBtns] = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_suite_key = ding_suite_key
        # 开放群ID
        self.target_open_conversation_id = target_open_conversation_id
        # 标题
        self.title = title
        # 内容
        self.content = content
        # 是否 at所有人
        self.is_at_all = is_at_all
        # at 手机号
        self.at_mobiles = at_mobiles
        # at dingtalkId
        self.at_dingtalk_ids = at_dingtalk_ids
        # at unionIds
        self.at_union_ids = at_union_ids
        # 手机号接收者
        self.receiver_mobiles = receiver_mobiles
        # dingtalkId接收者
        self.receiver_dingtalk_ids = receiver_dingtalk_ids
        # unionId接收者
        self.receiver_union_ids = receiver_union_ids
        # 消息类型：MARKDOWN，ACTIONCARD
        self.message_type = message_type
        # 排列方式：0-按钮竖直排列，1-按钮横向排列
        self.btn_orientation = btn_orientation
        # actionCard按钮
        self.btns = btns

    def validate(self):
        if self.btns:
            for k in self.btns:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.target_open_conversation_id is not None:
            result['targetOpenConversationId'] = self.target_open_conversation_id
        if self.title is not None:
            result['title'] = self.title
        if self.content is not None:
            result['content'] = self.content
        if self.is_at_all is not None:
            result['isAtAll'] = self.is_at_all
        if self.at_mobiles is not None:
            result['atMobiles'] = self.at_mobiles
        if self.at_dingtalk_ids is not None:
            result['atDingtalkIds'] = self.at_dingtalk_ids
        if self.at_union_ids is not None:
            result['atUnionIds'] = self.at_union_ids
        if self.receiver_mobiles is not None:
            result['receiverMobiles'] = self.receiver_mobiles
        if self.receiver_dingtalk_ids is not None:
            result['receiverDingtalkIds'] = self.receiver_dingtalk_ids
        if self.receiver_union_ids is not None:
            result['receiverUnionIds'] = self.receiver_union_ids
        if self.message_type is not None:
            result['messageType'] = self.message_type
        if self.btn_orientation is not None:
            result['btnOrientation'] = self.btn_orientation
        result['btns'] = []
        if self.btns is not None:
            for k in self.btns:
                result['btns'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('targetOpenConversationId') is not None:
            self.target_open_conversation_id = m.get('targetOpenConversationId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('isAtAll') is not None:
            self.is_at_all = m.get('isAtAll')
        if m.get('atMobiles') is not None:
            self.at_mobiles = m.get('atMobiles')
        if m.get('atDingtalkIds') is not None:
            self.at_dingtalk_ids = m.get('atDingtalkIds')
        if m.get('atUnionIds') is not None:
            self.at_union_ids = m.get('atUnionIds')
        if m.get('receiverMobiles') is not None:
            self.receiver_mobiles = m.get('receiverMobiles')
        if m.get('receiverDingtalkIds') is not None:
            self.receiver_dingtalk_ids = m.get('receiverDingtalkIds')
        if m.get('receiverUnionIds') is not None:
            self.receiver_union_ids = m.get('receiverUnionIds')
        if m.get('messageType') is not None:
            self.message_type = m.get('messageType')
        if m.get('btnOrientation') is not None:
            self.btn_orientation = m.get('btnOrientation')
        self.btns = []
        if m.get('btns') is not None:
            for k in m.get('btns'):
                temp_model = SendServiceGroupMessageRequestBtns()
                self.btns.append(temp_model.from_map(k))
        return self


class SendServiceGroupMessageResponseBody(TeaModel):
    def __init__(
        self,
        open_msg_task_id: str = None,
    ):
        # 开放消息任务ID
        self.open_msg_task_id = open_msg_task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_msg_task_id is not None:
            result['openMsgTaskId'] = self.open_msg_task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openMsgTaskId') is not None:
            self.open_msg_task_id = m.get('openMsgTaskId')
        return self


class SendServiceGroupMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendServiceGroupMessageResponseBody = None,
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
            temp_model = SendServiceGroupMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetStoragePolicyHeaders(TeaModel):
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


class GetStoragePolicyRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_team_id: str = None,
        biz_type: str = None,
        file_size: int = None,
        file_name: str = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 团队ID
        self.open_team_id = open_team_id
        # 业务类型
        self.biz_type = biz_type
        # 文件大小，单位字节
        self.file_size = file_size
        # 文件名称
        self.file_name = file_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.file_name is not None:
            result['fileName'] = self.file_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        return self


class GetStoragePolicyResponseBody(TeaModel):
    def __init__(
        self,
        key: str = None,
        policy: str = None,
        access_key_id: str = None,
        endpoint: str = None,
        signature: str = None,
    ):
        # Id of the request
        self.key = key
        self.policy = policy
        self.access_key_id = access_key_id
        self.endpoint = endpoint
        self.signature = signature

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.policy is not None:
            result['policy'] = self.policy
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.endpoint is not None:
            result['endpoint'] = self.endpoint
        if self.signature is not None:
            result['signature'] = self.signature
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('policy') is not None:
            self.policy = m.get('policy')
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('endpoint') is not None:
            self.endpoint = m.get('endpoint')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        return self


class GetStoragePolicyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetStoragePolicyResponseBody = None,
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
            temp_model = GetStoragePolicyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListUserTeamsHeaders(TeaModel):
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


class ListUserTeamsResponseBodyTeams(TeaModel):
    def __init__(
        self,
        open_team_id: str = None,
        team_name: str = None,
    ):
        # 开放团队ID
        self.open_team_id = open_team_id
        # 团队名称
        self.team_name = team_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.team_name is not None:
            result['teamName'] = self.team_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('teamName') is not None:
            self.team_name = m.get('teamName')
        return self


class ListUserTeamsResponseBody(TeaModel):
    def __init__(
        self,
        teams: List[ListUserTeamsResponseBodyTeams] = None,
    ):
        # teams
        self.teams = teams

    def validate(self):
        if self.teams:
            for k in self.teams:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['teams'] = []
        if self.teams is not None:
            for k in self.teams:
                result['teams'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.teams = []
        if m.get('teams') is not None:
            for k in m.get('teams'):
                temp_model = ListUserTeamsResponseBodyTeams()
                self.teams.append(temp_model.from_map(k))
        return self


class ListUserTeamsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListUserTeamsResponseBody = None,
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
            temp_model = ListUserTeamsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddTicketMemoHeaders(TeaModel):
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


class AddTicketMemoRequestTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        # 文件名
        self.file_name = file_name
        # 文件key
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class AddTicketMemoRequestTicketMemo(TeaModel):
    def __init__(
        self,
        memo: str = None,
        attachments: List[AddTicketMemoRequestTicketMemoAttachments] = None,
    ):
        # 文字备注
        self.memo = memo
        # 备注相关的附件
        self.attachments = attachments

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.memo is not None:
            result['memo'] = self.memo
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = AddTicketMemoRequestTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        return self


class AddTicketMemoRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_team_id: str = None,
        processor_union_id: str = None,
        open_ticket_id: str = None,
        ticket_memo: AddTicketMemoRequestTicketMemo = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 开放团队ID
        self.open_team_id = open_team_id
        # 当前工单处理人
        self.processor_union_id = processor_union_id
        # 工单开放ID
        self.open_ticket_id = open_ticket_id
        # 备注
        self.ticket_memo = ticket_memo

    def validate(self):
        if self.ticket_memo:
            self.ticket_memo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.processor_union_id is not None:
            result['processorUnionId'] = self.processor_union_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('processorUnionId') is not None:
            self.processor_union_id = m.get('processorUnionId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('ticketMemo') is not None:
            temp_model = AddTicketMemoRequestTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        return self


class AddTicketMemoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


