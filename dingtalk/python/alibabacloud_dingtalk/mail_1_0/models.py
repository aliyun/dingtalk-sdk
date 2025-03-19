# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import BinaryIO, List, Dict, Any


class DraftMessageBody(TeaModel):
    def __init__(
        self,
        body_html: BinaryIO = None,
        body_text: BinaryIO = None,
    ):
        # This parameter is required.
        self.body_html = body_html
        # This parameter is required.
        self.body_text = body_text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body_html is not None:
            result['bodyHtml'] = self.body_html
        if self.body_text is not None:
            result['bodyText'] = self.body_text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bodyHtml') is not None:
            self.body_html = m.get('bodyHtml')
        if m.get('bodyText') is not None:
            self.body_text = m.get('bodyText')
        return self


class Recipient(TeaModel):
    def __init__(
        self,
        email: BinaryIO = None,
        name: BinaryIO = None,
    ):
        self.email = email
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.email is not None:
            result['email'] = self.email
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class DraftMessage(TeaModel):
    def __init__(
        self,
        bcc_recipients: List[Recipient] = None,
        body: DraftMessageBody = None,
        cc_recipients: List[Recipient] = None,
        from_: Recipient = None,
        internet_message_headers: Dict[str, Any] = None,
        internet_message_id: BinaryIO = None,
        is_read_receipt_requested: bool = None,
        priority: BinaryIO = None,
        reply_to: Recipient = None,
        subject: BinaryIO = None,
        summary: BinaryIO = None,
        tags: List[BinaryIO] = None,
        to_recipients: List[Recipient] = None,
    ):
        # This parameter is required.
        self.bcc_recipients = bcc_recipients
        # This parameter is required.
        self.body = body
        # This parameter is required.
        self.cc_recipients = cc_recipients
        # This parameter is required.
        self.from_ = from_
        # This parameter is required.
        self.internet_message_headers = internet_message_headers
        # This parameter is required.
        self.internet_message_id = internet_message_id
        # This parameter is required.
        self.is_read_receipt_requested = is_read_receipt_requested
        # This parameter is required.
        self.priority = priority
        # This parameter is required.
        self.reply_to = reply_to
        # This parameter is required.
        self.subject = subject
        # This parameter is required.
        self.summary = summary
        # This parameter is required.
        self.tags = tags
        # This parameter is required.
        self.to_recipients = to_recipients

    def validate(self):
        if self.bcc_recipients:
            for k in self.bcc_recipients:
                if k:
                    k.validate()
        if self.body:
            self.body.validate()
        if self.cc_recipients:
            for k in self.cc_recipients:
                if k:
                    k.validate()
        if self.from_:
            self.from_.validate()
        if self.reply_to:
            self.reply_to.validate()
        if self.to_recipients:
            for k in self.to_recipients:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['bccRecipients'] = []
        if self.bcc_recipients is not None:
            for k in self.bcc_recipients:
                result['bccRecipients'].append(k.to_map() if k else None)
        if self.body is not None:
            result['body'] = self.body.to_map()
        result['ccRecipients'] = []
        if self.cc_recipients is not None:
            for k in self.cc_recipients:
                result['ccRecipients'].append(k.to_map() if k else None)
        if self.from_ is not None:
            result['from'] = self.from_.to_map()
        if self.internet_message_headers is not None:
            result['internetMessageHeaders'] = self.internet_message_headers
        if self.internet_message_id is not None:
            result['internetMessageId'] = self.internet_message_id
        if self.is_read_receipt_requested is not None:
            result['isReadReceiptRequested'] = self.is_read_receipt_requested
        if self.priority is not None:
            result['priority'] = self.priority
        if self.reply_to is not None:
            result['replyTo'] = self.reply_to.to_map()
        if self.subject is not None:
            result['subject'] = self.subject
        if self.summary is not None:
            result['summary'] = self.summary
        if self.tags is not None:
            result['tags'] = self.tags
        result['toRecipients'] = []
        if self.to_recipients is not None:
            for k in self.to_recipients:
                result['toRecipients'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.bcc_recipients = []
        if m.get('bccRecipients') is not None:
            for k in m.get('bccRecipients'):
                temp_model = Recipient()
                self.bcc_recipients.append(temp_model.from_map(k))
        if m.get('body') is not None:
            temp_model = DraftMessageBody()
            self.body = temp_model.from_map(m['body'])
        self.cc_recipients = []
        if m.get('ccRecipients') is not None:
            for k in m.get('ccRecipients'):
                temp_model = Recipient()
                self.cc_recipients.append(temp_model.from_map(k))
        if m.get('from') is not None:
            temp_model = Recipient()
            self.from_ = temp_model.from_map(m['from'])
        if m.get('internetMessageHeaders') is not None:
            self.internet_message_headers = m.get('internetMessageHeaders')
        if m.get('internetMessageId') is not None:
            self.internet_message_id = m.get('internetMessageId')
        if m.get('isReadReceiptRequested') is not None:
            self.is_read_receipt_requested = m.get('isReadReceiptRequested')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('replyTo') is not None:
            temp_model = Recipient()
            self.reply_to = temp_model.from_map(m['replyTo'])
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('tags') is not None:
            self.tags = m.get('tags')
        self.to_recipients = []
        if m.get('toRecipients') is not None:
            for k in m.get('toRecipients'):
                temp_model = Recipient()
                self.to_recipients.append(temp_model.from_map(k))
        return self


class MessageBody(TeaModel):
    def __init__(
        self,
        body_html: BinaryIO = None,
        body_text: BinaryIO = None,
    ):
        # This parameter is required.
        self.body_html = body_html
        # This parameter is required.
        self.body_text = body_text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body_html is not None:
            result['bodyHtml'] = self.body_html
        if self.body_text is not None:
            result['bodyText'] = self.body_text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bodyHtml') is not None:
            self.body_html = m.get('bodyHtml')
        if m.get('bodyText') is not None:
            self.body_text = m.get('bodyText')
        return self


class Message(TeaModel):
    def __init__(
        self,
        bcc_recipients: List[Recipient] = None,
        body: MessageBody = None,
        cc_recipients: List[Recipient] = None,
        conversation_id: BinaryIO = None,
        folder_id: BinaryIO = None,
        from_: Recipient = None,
        has_attachments: bool = None,
        id: BinaryIO = None,
        internet_message_headers: Dict[str, Any] = None,
        internet_message_id: BinaryIO = None,
        is_forwarded: bool = None,
        is_read: bool = None,
        is_read_receipt_requested: bool = None,
        is_replied: bool = None,
        last_modified_date_time: BinaryIO = None,
        priority: BinaryIO = None,
        received_date_time: BinaryIO = None,
        reply_to: Recipient = None,
        sent_date_time: BinaryIO = None,
        subject: BinaryIO = None,
        summary: BinaryIO = None,
        tags: List[str] = None,
        to_recipients: List[Recipient] = None,
    ):
        # This parameter is required.
        self.bcc_recipients = bcc_recipients
        # This parameter is required.
        self.body = body
        # This parameter is required.
        self.cc_recipients = cc_recipients
        # This parameter is required.
        self.conversation_id = conversation_id
        # This parameter is required.
        self.folder_id = folder_id
        # This parameter is required.
        self.from_ = from_
        # This parameter is required.
        self.has_attachments = has_attachments
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.internet_message_headers = internet_message_headers
        # This parameter is required.
        self.internet_message_id = internet_message_id
        # This parameter is required.
        self.is_forwarded = is_forwarded
        # This parameter is required.
        self.is_read = is_read
        # This parameter is required.
        self.is_read_receipt_requested = is_read_receipt_requested
        # This parameter is required.
        self.is_replied = is_replied
        # This parameter is required.
        self.last_modified_date_time = last_modified_date_time
        # This parameter is required.
        self.priority = priority
        # This parameter is required.
        self.received_date_time = received_date_time
        # This parameter is required.
        self.reply_to = reply_to
        # This parameter is required.
        self.sent_date_time = sent_date_time
        # This parameter is required.
        self.subject = subject
        # This parameter is required.
        self.summary = summary
        # This parameter is required.
        self.tags = tags
        # This parameter is required.
        self.to_recipients = to_recipients

    def validate(self):
        if self.bcc_recipients:
            for k in self.bcc_recipients:
                if k:
                    k.validate()
        if self.body:
            self.body.validate()
        if self.cc_recipients:
            for k in self.cc_recipients:
                if k:
                    k.validate()
        if self.from_:
            self.from_.validate()
        if self.reply_to:
            self.reply_to.validate()
        if self.to_recipients:
            for k in self.to_recipients:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['bccRecipients'] = []
        if self.bcc_recipients is not None:
            for k in self.bcc_recipients:
                result['bccRecipients'].append(k.to_map() if k else None)
        if self.body is not None:
            result['body'] = self.body.to_map()
        result['ccRecipients'] = []
        if self.cc_recipients is not None:
            for k in self.cc_recipients:
                result['ccRecipients'].append(k.to_map() if k else None)
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.folder_id is not None:
            result['folderId'] = self.folder_id
        if self.from_ is not None:
            result['from'] = self.from_.to_map()
        if self.has_attachments is not None:
            result['hasAttachments'] = self.has_attachments
        if self.id is not None:
            result['id'] = self.id
        if self.internet_message_headers is not None:
            result['internetMessageHeaders'] = self.internet_message_headers
        if self.internet_message_id is not None:
            result['internetMessageId'] = self.internet_message_id
        if self.is_forwarded is not None:
            result['isForwarded'] = self.is_forwarded
        if self.is_read is not None:
            result['isRead'] = self.is_read
        if self.is_read_receipt_requested is not None:
            result['isReadReceiptRequested'] = self.is_read_receipt_requested
        if self.is_replied is not None:
            result['isReplied'] = self.is_replied
        if self.last_modified_date_time is not None:
            result['lastModifiedDateTime'] = self.last_modified_date_time
        if self.priority is not None:
            result['priority'] = self.priority
        if self.received_date_time is not None:
            result['receivedDateTime'] = self.received_date_time
        if self.reply_to is not None:
            result['replyTo'] = self.reply_to.to_map()
        if self.sent_date_time is not None:
            result['sentDateTime'] = self.sent_date_time
        if self.subject is not None:
            result['subject'] = self.subject
        if self.summary is not None:
            result['summary'] = self.summary
        if self.tags is not None:
            result['tags'] = self.tags
        result['toRecipients'] = []
        if self.to_recipients is not None:
            for k in self.to_recipients:
                result['toRecipients'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.bcc_recipients = []
        if m.get('bccRecipients') is not None:
            for k in m.get('bccRecipients'):
                temp_model = Recipient()
                self.bcc_recipients.append(temp_model.from_map(k))
        if m.get('body') is not None:
            temp_model = MessageBody()
            self.body = temp_model.from_map(m['body'])
        self.cc_recipients = []
        if m.get('ccRecipients') is not None:
            for k in m.get('ccRecipients'):
                temp_model = Recipient()
                self.cc_recipients.append(temp_model.from_map(k))
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('folderId') is not None:
            self.folder_id = m.get('folderId')
        if m.get('from') is not None:
            temp_model = Recipient()
            self.from_ = temp_model.from_map(m['from'])
        if m.get('hasAttachments') is not None:
            self.has_attachments = m.get('hasAttachments')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('internetMessageHeaders') is not None:
            self.internet_message_headers = m.get('internetMessageHeaders')
        if m.get('internetMessageId') is not None:
            self.internet_message_id = m.get('internetMessageId')
        if m.get('isForwarded') is not None:
            self.is_forwarded = m.get('isForwarded')
        if m.get('isRead') is not None:
            self.is_read = m.get('isRead')
        if m.get('isReadReceiptRequested') is not None:
            self.is_read_receipt_requested = m.get('isReadReceiptRequested')
        if m.get('isReplied') is not None:
            self.is_replied = m.get('isReplied')
        if m.get('lastModifiedDateTime') is not None:
            self.last_modified_date_time = m.get('lastModifiedDateTime')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('receivedDateTime') is not None:
            self.received_date_time = m.get('receivedDateTime')
        if m.get('replyTo') is not None:
            temp_model = Recipient()
            self.reply_to = temp_model.from_map(m['replyTo'])
        if m.get('sentDateTime') is not None:
            self.sent_date_time = m.get('sentDateTime')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('tags') is not None:
            self.tags = m.get('tags')
        self.to_recipients = []
        if m.get('toRecipients') is not None:
            for k in m.get('toRecipients'):
                temp_model = Recipient()
                self.to_recipients.append(temp_model.from_map(k))
        return self


class CreateMailFolderHeaders(TeaModel):
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


class CreateMailFolderRequest(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        extensions: Dict[str, Any] = None,
        foler_id: str = None,
    ):
        # This parameter is required.
        self.display_name = display_name
        self.extensions = extensions
        self.foler_id = foler_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.extensions is not None:
            result['extensions'] = self.extensions
        if self.foler_id is not None:
            result['folerId'] = self.foler_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('extensions') is not None:
            self.extensions = m.get('extensions')
        if m.get('folerId') is not None:
            self.foler_id = m.get('folerId')
        return self


class CreateMailFolderResponseBodyFolder(TeaModel):
    def __init__(
        self,
        child_folder_count: int = None,
        display_name: str = None,
        extensions: Dict[str, Any] = None,
        id: str = None,
        parent_folder_id: str = None,
        total_item_count: int = None,
        unread_item_count: int = None,
    ):
        self.child_folder_count = child_folder_count
        self.display_name = display_name
        self.extensions = extensions
        self.id = id
        self.parent_folder_id = parent_folder_id
        self.total_item_count = total_item_count
        self.unread_item_count = unread_item_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.child_folder_count is not None:
            result['childFolderCount'] = self.child_folder_count
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.extensions is not None:
            result['extensions'] = self.extensions
        if self.id is not None:
            result['id'] = self.id
        if self.parent_folder_id is not None:
            result['parentFolderId'] = self.parent_folder_id
        if self.total_item_count is not None:
            result['totalItemCount'] = self.total_item_count
        if self.unread_item_count is not None:
            result['unreadItemCount'] = self.unread_item_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('childFolderCount') is not None:
            self.child_folder_count = m.get('childFolderCount')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('extensions') is not None:
            self.extensions = m.get('extensions')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('parentFolderId') is not None:
            self.parent_folder_id = m.get('parentFolderId')
        if m.get('totalItemCount') is not None:
            self.total_item_count = m.get('totalItemCount')
        if m.get('unreadItemCount') is not None:
            self.unread_item_count = m.get('unreadItemCount')
        return self


class CreateMailFolderResponseBody(TeaModel):
    def __init__(
        self,
        folder: CreateMailFolderResponseBodyFolder = None,
        request_id: str = None,
    ):
        self.folder = folder
        self.request_id = request_id

    def validate(self):
        if self.folder:
            self.folder.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.folder is not None:
            result['folder'] = self.folder.to_map()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('folder') is not None:
            temp_model = CreateMailFolderResponseBodyFolder()
            self.folder = temp_model.from_map(m['folder'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class CreateMailFolderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateMailFolderResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = CreateMailFolderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateUserHeaders(TeaModel):
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


class CreateUserRequest(TeaModel):
    def __init__(
        self,
        email: str = None,
        employee_type: str = None,
        name: str = None,
        password: str = None,
    ):
        # This parameter is required.
        self.email = email
        # This parameter is required.
        self.employee_type = employee_type
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.password = password

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.email is not None:
            result['email'] = self.email
        if self.employee_type is not None:
            result['employeeType'] = self.employee_type
        if self.name is not None:
            result['name'] = self.name
        if self.password is not None:
            result['password'] = self.password
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('employeeType') is not None:
            self.employee_type = m.get('employeeType')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('password') is not None:
            self.password = m.get('password')
        return self


class CreateUserResponseBody(TeaModel):
    def __init__(
        self,
        email: str = None,
    ):
        self.email = email

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.email is not None:
            result['email'] = self.email
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('email') is not None:
            self.email = m.get('email')
        return self


class CreateUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateUserResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = CreateUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListMailFoldersHeaders(TeaModel):
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


class ListMailFoldersRequest(TeaModel):
    def __init__(
        self,
        folder_id: str = None,
    ):
        self.folder_id = folder_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.folder_id is not None:
            result['folderId'] = self.folder_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('folderId') is not None:
            self.folder_id = m.get('folderId')
        return self


class ListMailFoldersResponseBodyFolders(TeaModel):
    def __init__(
        self,
        child_folder_count: int = None,
        display_name: str = None,
        extensions: Dict[str, str] = None,
        id: str = None,
        parent_folder_id: str = None,
        total_item_count: int = None,
        unread_item_count: int = None,
    ):
        # This parameter is required.
        self.child_folder_count = child_folder_count
        # This parameter is required.
        self.display_name = display_name
        self.extensions = extensions
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.parent_folder_id = parent_folder_id
        # This parameter is required.
        self.total_item_count = total_item_count
        # This parameter is required.
        self.unread_item_count = unread_item_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.child_folder_count is not None:
            result['childFolderCount'] = self.child_folder_count
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.extensions is not None:
            result['extensions'] = self.extensions
        if self.id is not None:
            result['id'] = self.id
        if self.parent_folder_id is not None:
            result['parentFolderId'] = self.parent_folder_id
        if self.total_item_count is not None:
            result['totalItemCount'] = self.total_item_count
        if self.unread_item_count is not None:
            result['unreadItemCount'] = self.unread_item_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('childFolderCount') is not None:
            self.child_folder_count = m.get('childFolderCount')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('extensions') is not None:
            self.extensions = m.get('extensions')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('parentFolderId') is not None:
            self.parent_folder_id = m.get('parentFolderId')
        if m.get('totalItemCount') is not None:
            self.total_item_count = m.get('totalItemCount')
        if m.get('unreadItemCount') is not None:
            self.unread_item_count = m.get('unreadItemCount')
        return self


class ListMailFoldersResponseBody(TeaModel):
    def __init__(
        self,
        folders: List[ListMailFoldersResponseBodyFolders] = None,
    ):
        self.folders = folders

    def validate(self):
        if self.folders:
            for k in self.folders:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['folders'] = []
        if self.folders is not None:
            for k in self.folders:
                result['folders'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.folders = []
        if m.get('folders') is not None:
            for k in m.get('folders'):
                temp_model = ListMailFoldersResponseBodyFolders()
                self.folders.append(temp_model.from_map(k))
        return self


class ListMailFoldersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListMailFoldersResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = ListMailFoldersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


