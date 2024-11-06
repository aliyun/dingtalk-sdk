# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import List, Dict, Any


class AvaliableTemplate(TeaModel):
    def __init__(
        self,
        name: str = None,
        process_code: str = None,
    ):
        # This parameter is required.
        self.name = name
        # This parameter is required.
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


class FormDataSourceTarget(TeaModel):
    def __init__(
        self,
        app_type: int = None,
        app_uuid: str = None,
        biz_type: str = None,
        form_code: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.app_uuid = app_uuid
        self.biz_type = biz_type
        # This parameter is required.
        self.form_code = form_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.form_code is not None:
            result['formCode'] = self.form_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        return self


class FormDataSource(TeaModel):
    def __init__(
        self,
        target: FormDataSourceTarget = None,
        type: str = None,
    ):
        # This parameter is required.
        self.target = target
        self.type = type

    def validate(self):
        if self.target:
            self.target.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target is not None:
            result['target'] = self.target.to_map()
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('target') is not None:
            temp_model = FormDataSourceTarget()
            self.target = temp_model.from_map(m['target'])
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class SelectOption(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        self.key = key
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


class FormComponentPropsStatField(TeaModel):
    def __init__(
        self,
        component_id: str = None,
        label: str = None,
        upper: str = None,
    ):
        # This parameter is required.
        self.component_id = component_id
        # This parameter is required.
        self.label = label
        self.upper = upper

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentId') is not None:
            self.component_id = m.get('componentId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        return self


class FormComponentProps(TeaModel):
    def __init__(
        self,
        action_name: str = None,
        address_model: str = None,
        align: str = None,
        async_condition: bool = None,
        available_templates: List[AvaliableTemplate] = None,
        biz_alias: str = None,
        biz_type: str = None,
        choice: str = None,
        common_biz_type: str = None,
        component_id: str = None,
        content: str = None,
        data_source: FormDataSource = None,
        disabled: bool = None,
        duration: bool = None,
        duration_label: str = None,
        format: str = None,
        formula: str = None,
        invisible: bool = None,
        label: str = None,
        limit: int = None,
        link: str = None,
        max_length: int = None,
        mode: str = None,
        multiple: bool = None,
        options: List[SelectOption] = None,
        placeholder: str = None,
        precision: int = None,
        print: str = None,
        required: bool = None,
        stat_field: List[FormComponentPropsStatField] = None,
        table_view_mode: str = None,
        unit: str = None,
        upper: str = None,
        vertical_print: bool = None,
    ):
        self.action_name = action_name
        self.address_model = address_model
        self.align = align
        self.async_condition = async_condition
        self.available_templates = available_templates
        self.biz_alias = biz_alias
        self.biz_type = biz_type
        self.choice = choice
        self.common_biz_type = common_biz_type
        self.component_id = component_id
        self.content = content
        self.data_source = data_source
        self.disabled = disabled
        self.duration = duration
        self.duration_label = duration_label
        self.format = format
        self.formula = formula
        self.invisible = invisible
        self.label = label
        self.limit = limit
        self.link = link
        self.max_length = max_length
        self.mode = mode
        self.multiple = multiple
        self.options = options
        self.placeholder = placeholder
        self.precision = precision
        self.print = print
        self.required = required
        self.stat_field = stat_field
        self.table_view_mode = table_view_mode
        self.unit = unit
        self.upper = upper
        self.vertical_print = vertical_print

    def validate(self):
        if self.available_templates:
            for k in self.available_templates:
                if k:
                    k.validate()
        if self.data_source:
            self.data_source.validate()
        if self.options:
            for k in self.options:
                if k:
                    k.validate()
        if self.stat_field:
            for k in self.stat_field:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_name is not None:
            result['actionName'] = self.action_name
        if self.address_model is not None:
            result['addressModel'] = self.address_model
        if self.align is not None:
            result['align'] = self.align
        if self.async_condition is not None:
            result['asyncCondition'] = self.async_condition
        result['availableTemplates'] = []
        if self.available_templates is not None:
            for k in self.available_templates:
                result['availableTemplates'].append(k.to_map() if k else None)
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.choice is not None:
            result['choice'] = self.choice
        if self.common_biz_type is not None:
            result['commonBizType'] = self.common_biz_type
        if self.component_id is not None:
            result['componentId'] = self.component_id
        if self.content is not None:
            result['content'] = self.content
        if self.data_source is not None:
            result['dataSource'] = self.data_source.to_map()
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.duration is not None:
            result['duration'] = self.duration
        if self.duration_label is not None:
            result['durationLabel'] = self.duration_label
        if self.format is not None:
            result['format'] = self.format
        if self.formula is not None:
            result['formula'] = self.formula
        if self.invisible is not None:
            result['invisible'] = self.invisible
        if self.label is not None:
            result['label'] = self.label
        if self.limit is not None:
            result['limit'] = self.limit
        if self.link is not None:
            result['link'] = self.link
        if self.max_length is not None:
            result['maxLength'] = self.max_length
        if self.mode is not None:
            result['mode'] = self.mode
        if self.multiple is not None:
            result['multiple'] = self.multiple
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.precision is not None:
            result['precision'] = self.precision
        if self.print is not None:
            result['print'] = self.print
        if self.required is not None:
            result['required'] = self.required
        result['statField'] = []
        if self.stat_field is not None:
            for k in self.stat_field:
                result['statField'].append(k.to_map() if k else None)
        if self.table_view_mode is not None:
            result['tableViewMode'] = self.table_view_mode
        if self.unit is not None:
            result['unit'] = self.unit
        if self.upper is not None:
            result['upper'] = self.upper
        if self.vertical_print is not None:
            result['verticalPrint'] = self.vertical_print
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionName') is not None:
            self.action_name = m.get('actionName')
        if m.get('addressModel') is not None:
            self.address_model = m.get('addressModel')
        if m.get('align') is not None:
            self.align = m.get('align')
        if m.get('asyncCondition') is not None:
            self.async_condition = m.get('asyncCondition')
        self.available_templates = []
        if m.get('availableTemplates') is not None:
            for k in m.get('availableTemplates'):
                temp_model = AvaliableTemplate()
                self.available_templates.append(temp_model.from_map(k))
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('commonBizType') is not None:
            self.common_biz_type = m.get('commonBizType')
        if m.get('componentId') is not None:
            self.component_id = m.get('componentId')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('dataSource') is not None:
            temp_model = FormDataSource()
            self.data_source = temp_model.from_map(m['dataSource'])
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('durationLabel') is not None:
            self.duration_label = m.get('durationLabel')
        if m.get('format') is not None:
            self.format = m.get('format')
        if m.get('formula') is not None:
            self.formula = m.get('formula')
        if m.get('invisible') is not None:
            self.invisible = m.get('invisible')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('limit') is not None:
            self.limit = m.get('limit')
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('maxLength') is not None:
            self.max_length = m.get('maxLength')
        if m.get('mode') is not None:
            self.mode = m.get('mode')
        if m.get('multiple') is not None:
            self.multiple = m.get('multiple')
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = SelectOption()
                self.options.append(temp_model.from_map(k))
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('precision') is not None:
            self.precision = m.get('precision')
        if m.get('print') is not None:
            self.print = m.get('print')
        if m.get('required') is not None:
            self.required = m.get('required')
        self.stat_field = []
        if m.get('statField') is not None:
            for k in m.get('statField'):
                temp_model = FormComponentPropsStatField()
                self.stat_field.append(temp_model.from_map(k))
        if m.get('tableViewMode') is not None:
            self.table_view_mode = m.get('tableViewMode')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        if m.get('verticalPrint') is not None:
            self.vertical_print = m.get('verticalPrint')
        return self


class FormComponent(TeaModel):
    def __init__(
        self,
        children: List['FormComponent'] = None,
        component_type: str = None,
        props: FormComponentProps = None,
    ):
        self.children = children
        # This parameter is required.
        self.component_type = component_type
        # This parameter is required.
        self.props = props

    def validate(self):
        if self.children:
            for k in self.children:
                if k:
                    k.validate()
        if self.props:
            self.props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['children'] = []
        if self.children is not None:
            for k in self.children:
                result['children'].append(k.to_map() if k else None)
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.props is not None:
            result['props'] = self.props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.children = []
        if m.get('children') is not None:
            for k in m.get('children'):
                temp_model = FormComponent()
                self.children.append(temp_model.from_map(k))
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('props') is not None:
            temp_model = FormComponentProps()
            self.props = temp_model.from_map(m['props'])
        return self


class ResultValue(TeaModel):
    def __init__(
        self,
        result: bool = None,
        message: str = None,
    ):
        self.result = result
        self.message = message

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class AddApproveDentryAuthHeaders(TeaModel):
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


class AddApproveDentryAuthRequestFileInfos(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        space_id: int = None,
    ):
        # This parameter is required.
        self.file_id = file_id
        # This parameter is required.
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class AddApproveDentryAuthRequest(TeaModel):
    def __init__(
        self,
        file_infos: List[AddApproveDentryAuthRequestFileInfos] = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.file_infos = file_infos
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        if self.file_infos:
            for k in self.file_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['fileInfos'] = []
        if self.file_infos is not None:
            for k in self.file_infos:
                result['fileInfos'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.file_infos = []
        if m.get('fileInfos') is not None:
            for k in m.get('fileInfos'):
                temp_model = AddApproveDentryAuthRequestFileInfos()
                self.file_infos.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class AddApproveDentryAuthResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AddApproveDentryAuthResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddApproveDentryAuthResponseBody = None,
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
            temp_model = AddApproveDentryAuthResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddProcessInstanceCommentHeaders(TeaModel):
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


class AddProcessInstanceCommentRequestFileAttachments(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        file_size: str = None,
        file_type: str = None,
        space_id: str = None,
    ):
        self.file_id = file_id
        self.file_name = file_name
        self.file_size = file_size
        self.file_type = file_type
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class AddProcessInstanceCommentRequestFile(TeaModel):
    def __init__(
        self,
        attachments: List[AddProcessInstanceCommentRequestFileAttachments] = None,
        photos: List[str] = None,
    ):
        self.attachments = attachments
        self.photos = photos

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
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.photos is not None:
            result['photos'] = self.photos
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = AddProcessInstanceCommentRequestFileAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('photos') is not None:
            self.photos = m.get('photos')
        return self


class AddProcessInstanceCommentRequest(TeaModel):
    def __init__(
        self,
        comment_user_id: str = None,
        file: AddProcessInstanceCommentRequestFile = None,
        process_instance_id: str = None,
        text: str = None,
    ):
        # This parameter is required.
        self.comment_user_id = comment_user_id
        self.file = file
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.text = text

    def validate(self):
        if self.file:
            self.file.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.comment_user_id is not None:
            result['commentUserId'] = self.comment_user_id
        if self.file is not None:
            result['file'] = self.file.to_map()
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commentUserId') is not None:
            self.comment_user_id = m.get('commentUserId')
        if m.get('file') is not None:
            temp_model = AddProcessInstanceCommentRequestFile()
            self.file = temp_model.from_map(m['file'])
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class AddProcessInstanceCommentResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AddProcessInstanceCommentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddProcessInstanceCommentResponseBody = None,
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
            temp_model = AddProcessInstanceCommentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchExecuteProcessInstancesHeaders(TeaModel):
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


class BatchExecuteProcessInstancesRequestTaskInfoList(TeaModel):
    def __init__(
        self,
        process_instance_id: str = None,
        task_id: int = None,
    ):
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class BatchExecuteProcessInstancesRequest(TeaModel):
    def __init__(
        self,
        actioner_user_id: str = None,
        remark: str = None,
        result: str = None,
        task_info_list: List[BatchExecuteProcessInstancesRequestTaskInfoList] = None,
    ):
        # This parameter is required.
        self.actioner_user_id = actioner_user_id
        self.remark = remark
        # This parameter is required.
        self.result = result
        # This parameter is required.
        self.task_info_list = task_info_list

    def validate(self):
        if self.task_info_list:
            for k in self.task_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actioner_user_id is not None:
            result['actionerUserId'] = self.actioner_user_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.result is not None:
            result['result'] = self.result
        result['taskInfoList'] = []
        if self.task_info_list is not None:
            for k in self.task_info_list:
                result['taskInfoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionerUserId') is not None:
            self.actioner_user_id = m.get('actionerUserId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('result') is not None:
            self.result = m.get('result')
        self.task_info_list = []
        if m.get('taskInfoList') is not None:
            for k in m.get('taskInfoList'):
                temp_model = BatchExecuteProcessInstancesRequestTaskInfoList()
                self.task_info_list.append(temp_model.from_map(k))
        return self


class BatchExecuteProcessInstancesResponseBody(TeaModel):
    def __init__(
        self,
        result: Dict[str, ResultValue] = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            for v in self.result.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['result'] = {}
        if self.result is not None:
            for k, v in self.result.items():
                result['result'][k] = v.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = {}
        if m.get('result') is not None:
            for k, v in m.get('result').items():
                temp_model = ResultValue()
                self.result[k] = temp_model.from_map(v)
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class BatchExecuteProcessInstancesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchExecuteProcessInstancesResponseBody = None,
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
            temp_model = BatchExecuteProcessInstancesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchTasksRedirectHeaders(TeaModel):
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


class BatchTasksRedirectRequest(TeaModel):
    def __init__(
        self,
        handover_user_id: str = None,
        manager_user_id: str = None,
        task_ids: List[int] = None,
        transferee_user_id: str = None,
    ):
        # This parameter is required.
        self.handover_user_id = handover_user_id
        # This parameter is required.
        self.manager_user_id = manager_user_id
        # This parameter is required.
        self.task_ids = task_ids
        # This parameter is required.
        self.transferee_user_id = transferee_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.handover_user_id is not None:
            result['handoverUserId'] = self.handover_user_id
        if self.manager_user_id is not None:
            result['managerUserId'] = self.manager_user_id
        if self.task_ids is not None:
            result['taskIds'] = self.task_ids
        if self.transferee_user_id is not None:
            result['transfereeUserId'] = self.transferee_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('handoverUserId') is not None:
            self.handover_user_id = m.get('handoverUserId')
        if m.get('managerUserId') is not None:
            self.manager_user_id = m.get('managerUserId')
        if m.get('taskIds') is not None:
            self.task_ids = m.get('taskIds')
        if m.get('transfereeUserId') is not None:
            self.transferee_user_id = m.get('transfereeUserId')
        return self


class BatchTasksRedirectResponseBodyResultRedirectResults(TeaModel):
    def __init__(
        self,
        error_msg: str = None,
        success: bool = None,
        task_id: int = None,
    ):
        self.error_msg = error_msg
        # This parameter is required.
        self.success = success
        # This parameter is required.
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.success is not None:
            result['success'] = self.success
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class BatchTasksRedirectResponseBodyResult(TeaModel):
    def __init__(
        self,
        fail_count: int = None,
        redirect_results: List[BatchTasksRedirectResponseBodyResultRedirectResults] = None,
        total_count: int = None,
    ):
        # This parameter is required.
        self.fail_count = fail_count
        # This parameter is required.
        self.redirect_results = redirect_results
        # This parameter is required.
        self.total_count = total_count

    def validate(self):
        if self.redirect_results:
            for k in self.redirect_results:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fail_count is not None:
            result['failCount'] = self.fail_count
        result['redirectResults'] = []
        if self.redirect_results is not None:
            for k in self.redirect_results:
                result['redirectResults'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failCount') is not None:
            self.fail_count = m.get('failCount')
        self.redirect_results = []
        if m.get('redirectResults') is not None:
            for k in m.get('redirectResults'):
                temp_model = BatchTasksRedirectResponseBodyResultRedirectResults()
                self.redirect_results.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class BatchTasksRedirectResponseBody(TeaModel):
    def __init__(
        self,
        result: BatchTasksRedirectResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = BatchTasksRedirectResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class BatchTasksRedirectResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchTasksRedirectResponseBody = None,
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
            temp_model = BatchTasksRedirectResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchUpdateProcessInstanceHeaders(TeaModel):
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


class BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests(TeaModel):
    def __init__(
        self,
        notifiers: List[BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers] = None,
        process_instance_id: str = None,
        result: str = None,
        status: str = None,
    ):
        self.notifiers = notifiers
        # This parameter is required.
        self.process_instance_id = process_instance_id
        self.result = result
        # This parameter is required.
        self.status = status

    def validate(self):
        if self.notifiers:
            for k in self.notifiers:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['notifiers'] = []
        if self.notifiers is not None:
            for k in self.notifiers:
                result['notifiers'].append(k.to_map() if k else None)
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.notifiers = []
        if m.get('notifiers') is not None:
            for k in m.get('notifiers'):
                temp_model = BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers()
                self.notifiers.append(temp_model.from_map(k))
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class BatchUpdateProcessInstanceRequest(TeaModel):
    def __init__(
        self,
        update_process_instance_requests: List[BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests] = None,
    ):
        self.update_process_instance_requests = update_process_instance_requests

    def validate(self):
        if self.update_process_instance_requests:
            for k in self.update_process_instance_requests:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['updateProcessInstanceRequests'] = []
        if self.update_process_instance_requests is not None:
            for k in self.update_process_instance_requests:
                result['updateProcessInstanceRequests'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.update_process_instance_requests = []
        if m.get('updateProcessInstanceRequests') is not None:
            for k in m.get('updateProcessInstanceRequests'):
                temp_model = BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests()
                self.update_process_instance_requests.append(temp_model.from_map(k))
        return self


class BatchUpdateProcessInstanceResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
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


class BatchUpdateProcessInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchUpdateProcessInstanceResponseBody = None,
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
            temp_model = BatchUpdateProcessInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CancelIntegratedTaskHeaders(TeaModel):
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


class CancelIntegratedTaskRequest(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        activity_ids: List[str] = None,
        process_instance_id: str = None,
    ):
        # This parameter is required.
        self.activity_id = activity_id
        self.activity_ids = activity_ids
        # This parameter is required.
        self.process_instance_id = process_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.activity_ids is not None:
            result['activityIds'] = self.activity_ids
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('activityIds') is not None:
            self.activity_ids = m.get('activityIds')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        return self


class CancelIntegratedTaskResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
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


class CancelIntegratedTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CancelIntegratedTaskResponseBody = None,
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
            temp_model = CancelIntegratedTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CleanProcessDataHeaders(TeaModel):
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


class CleanProcessDataRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        process_code: str = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.process_code = process_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class CleanProcessDataResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
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


class CleanProcessDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CleanProcessDataResponseBody = None,
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
            temp_model = CleanProcessDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CopyProcessHeaders(TeaModel):
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


class CopyProcessRequestCopyOptions(TeaModel):
    def __init__(
        self,
        copy_type: int = None,
    ):
        self.copy_type = copy_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.copy_type is not None:
            result['copyType'] = self.copy_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('copyType') is not None:
            self.copy_type = m.get('copyType')
        return self


class CopyProcessRequestSourceProcessVOList(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        name: str = None,
        process_code: str = None,
    ):
        self.biz_type = biz_type
        self.name = name
        # This parameter is required.
        self.process_code = process_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.name is not None:
            result['name'] = self.name
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class CopyProcessRequest(TeaModel):
    def __init__(
        self,
        copy_options: CopyProcessRequestCopyOptions = None,
        source_corp_id: str = None,
        source_process_volist: List[CopyProcessRequestSourceProcessVOList] = None,
    ):
        self.copy_options = copy_options
        # This parameter is required.
        self.source_corp_id = source_corp_id
        # This parameter is required.
        self.source_process_volist = source_process_volist

    def validate(self):
        if self.copy_options:
            self.copy_options.validate()
        if self.source_process_volist:
            for k in self.source_process_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.copy_options is not None:
            result['copyOptions'] = self.copy_options.to_map()
        if self.source_corp_id is not None:
            result['sourceCorpId'] = self.source_corp_id
        result['sourceProcessVOList'] = []
        if self.source_process_volist is not None:
            for k in self.source_process_volist:
                result['sourceProcessVOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('copyOptions') is not None:
            temp_model = CopyProcessRequestCopyOptions()
            self.copy_options = temp_model.from_map(m['copyOptions'])
        if m.get('sourceCorpId') is not None:
            self.source_corp_id = m.get('sourceCorpId')
        self.source_process_volist = []
        if m.get('sourceProcessVOList') is not None:
            for k in m.get('sourceProcessVOList'):
                temp_model = CopyProcessRequestSourceProcessVOList()
                self.source_process_volist.append(temp_model.from_map(k))
        return self


class CopyProcessResponseBodyResult(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        name: str = None,
        process_code: str = None,
    ):
        self.biz_type = biz_type
        self.name = name
        self.process_code = process_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.name is not None:
            result['name'] = self.name
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class CopyProcessResponseBody(TeaModel):
    def __init__(
        self,
        result: List[CopyProcessResponseBodyResult] = None,
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
                temp_model = CopyProcessResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class CopyProcessResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CopyProcessResponseBody = None,
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
            temp_model = CopyProcessResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateIntegratedTaskHeaders(TeaModel):
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


class CreateIntegratedTaskRequestFeatureConfigFeaturesCallback(TeaModel):
    def __init__(
        self,
        api_key: str = None,
        app_uuid: str = None,
        version: str = None,
    ):
        self.api_key = api_key
        self.app_uuid = app_uuid
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_key is not None:
            result['apiKey'] = self.api_key
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiKey') is not None:
            self.api_key = m.get('apiKey')
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class CreateIntegratedTaskRequestFeatureConfigFeatures(TeaModel):
    def __init__(
        self,
        callback: CreateIntegratedTaskRequestFeatureConfigFeaturesCallback = None,
        config: str = None,
        mobile_url: str = None,
        name: str = None,
        pc_url: str = None,
        run_type: str = None,
    ):
        self.callback = callback
        self.config = config
        self.mobile_url = mobile_url
        self.name = name
        self.pc_url = pc_url
        self.run_type = run_type

    def validate(self):
        if self.callback:
            self.callback.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback is not None:
            result['callback'] = self.callback.to_map()
        if self.config is not None:
            result['config'] = self.config
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        if self.name is not None:
            result['name'] = self.name
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.run_type is not None:
            result['runType'] = self.run_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callback') is not None:
            temp_model = CreateIntegratedTaskRequestFeatureConfigFeaturesCallback()
            self.callback = temp_model.from_map(m['callback'])
        if m.get('config') is not None:
            self.config = m.get('config')
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('runType') is not None:
            self.run_type = m.get('runType')
        return self


class CreateIntegratedTaskRequestFeatureConfig(TeaModel):
    def __init__(
        self,
        features: List[CreateIntegratedTaskRequestFeatureConfigFeatures] = None,
    ):
        self.features = features

    def validate(self):
        if self.features:
            for k in self.features:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['features'] = []
        if self.features is not None:
            for k in self.features:
                result['features'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.features = []
        if m.get('features') is not None:
            for k in m.get('features'):
                temp_model = CreateIntegratedTaskRequestFeatureConfigFeatures()
                self.features.append(temp_model.from_map(k))
        return self


class CreateIntegratedTaskRequestTasks(TeaModel):
    def __init__(
        self,
        custom_data: str = None,
        url: str = None,
        user_id: str = None,
    ):
        self.custom_data = custom_data
        self.url = url
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_data is not None:
            result['customData'] = self.custom_data
        if self.url is not None:
            result['url'] = self.url
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customData') is not None:
            self.custom_data = m.get('customData')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateIntegratedTaskRequest(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        feature_config: CreateIntegratedTaskRequestFeatureConfig = None,
        process_instance_id: str = None,
        tasks: List[CreateIntegratedTaskRequestTasks] = None,
    ):
        self.activity_id = activity_id
        self.feature_config = feature_config
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.tasks = tasks

    def validate(self):
        if self.feature_config:
            self.feature_config.validate()
        if self.tasks:
            for k in self.tasks:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.feature_config is not None:
            result['featureConfig'] = self.feature_config.to_map()
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        result['tasks'] = []
        if self.tasks is not None:
            for k in self.tasks:
                result['tasks'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('featureConfig') is not None:
            temp_model = CreateIntegratedTaskRequestFeatureConfig()
            self.feature_config = temp_model.from_map(m['featureConfig'])
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        self.tasks = []
        if m.get('tasks') is not None:
            for k in m.get('tasks'):
                temp_model = CreateIntegratedTaskRequestTasks()
                self.tasks.append(temp_model.from_map(k))
        return self


class CreateIntegratedTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        task_id: int = None,
        user_id: str = None,
    ):
        self.task_id = task_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateIntegratedTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: List[CreateIntegratedTaskResponseBodyResult] = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = CreateIntegratedTaskResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateIntegratedTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateIntegratedTaskResponseBody = None,
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
            temp_model = CreateIntegratedTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteDirHeaders(TeaModel):
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


class DeleteDirRequest(TeaModel):
    def __init__(
        self,
        dir_id: str = None,
        operate_user_id: str = None,
    ):
        self.dir_id = dir_id
        # This parameter is required.
        self.operate_user_id = operate_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dir_id is not None:
            result['dirId'] = self.dir_id
        if self.operate_user_id is not None:
            result['operateUserId'] = self.operate_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dirId') is not None:
            self.dir_id = m.get('dirId')
        if m.get('operateUserId') is not None:
            self.operate_user_id = m.get('operateUserId')
        return self


class DeleteDirResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
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


class DeleteDirResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteDirResponseBody = None,
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
            temp_model = DeleteDirResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteProcessHeaders(TeaModel):
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


class DeleteProcessRequest(TeaModel):
    def __init__(
        self,
        clean_running_task: bool = None,
        process_code: str = None,
    ):
        self.clean_running_task = clean_running_task
        # This parameter is required.
        self.process_code = process_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.clean_running_task is not None:
            result['cleanRunningTask'] = self.clean_running_task
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cleanRunningTask') is not None:
            self.clean_running_task = m.get('cleanRunningTask')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class DeleteProcessResponseBodyResult(TeaModel):
    def __init__(
        self,
        process_code: str = None,
    ):
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


class DeleteProcessResponseBody(TeaModel):
    def __init__(
        self,
        result: DeleteProcessResponseBodyResult = None,
    ):
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
            temp_model = DeleteProcessResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class DeleteProcessResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteProcessResponseBody = None,
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
            temp_model = DeleteProcessResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ExecuteProcessInstanceHeaders(TeaModel):
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


class ExecuteProcessInstanceRequestFileAttachments(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        file_size: str = None,
        file_type: str = None,
        space_id: str = None,
    ):
        self.file_id = file_id
        self.file_name = file_name
        self.file_size = file_size
        self.file_type = file_type
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class ExecuteProcessInstanceRequestFile(TeaModel):
    def __init__(
        self,
        attachments: List[ExecuteProcessInstanceRequestFileAttachments] = None,
        photos: List[str] = None,
    ):
        self.attachments = attachments
        self.photos = photos

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
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.photos is not None:
            result['photos'] = self.photos
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = ExecuteProcessInstanceRequestFileAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('photos') is not None:
            self.photos = m.get('photos')
        return self


class ExecuteProcessInstanceRequest(TeaModel):
    def __init__(
        self,
        actioner_user_id: str = None,
        file: ExecuteProcessInstanceRequestFile = None,
        process_instance_id: str = None,
        remark: str = None,
        result: str = None,
        task_id: int = None,
    ):
        # This parameter is required.
        self.actioner_user_id = actioner_user_id
        self.file = file
        # This parameter is required.
        self.process_instance_id = process_instance_id
        self.remark = remark
        # This parameter is required.
        self.result = result
        # This parameter is required.
        self.task_id = task_id

    def validate(self):
        if self.file:
            self.file.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actioner_user_id is not None:
            result['actionerUserId'] = self.actioner_user_id
        if self.file is not None:
            result['file'] = self.file.to_map()
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.result is not None:
            result['result'] = self.result
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionerUserId') is not None:
            self.actioner_user_id = m.get('actionerUserId')
        if m.get('file') is not None:
            temp_model = ExecuteProcessInstanceRequestFile()
            self.file = temp_model.from_map(m['file'])
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class ExecuteProcessInstanceResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ExecuteProcessInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ExecuteProcessInstanceResponseBody = None,
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
            temp_model = ExecuteProcessInstanceResponseBody()
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


class FormCreateRequestTemplateConfig(TeaModel):
    def __init__(
        self,
        dir_id: str = None,
        disable_delete_process: bool = None,
        disable_form_edit: bool = None,
        disable_homepage: bool = None,
        disable_resubmit: bool = None,
        disable_stop_process_button: bool = None,
        hidden: bool = None,
        origin_dir_id: str = None,
    ):
        self.dir_id = dir_id
        self.disable_delete_process = disable_delete_process
        self.disable_form_edit = disable_form_edit
        self.disable_homepage = disable_homepage
        self.disable_resubmit = disable_resubmit
        self.disable_stop_process_button = disable_stop_process_button
        self.hidden = hidden
        self.origin_dir_id = origin_dir_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dir_id is not None:
            result['dirId'] = self.dir_id
        if self.disable_delete_process is not None:
            result['disableDeleteProcess'] = self.disable_delete_process
        if self.disable_form_edit is not None:
            result['disableFormEdit'] = self.disable_form_edit
        if self.disable_homepage is not None:
            result['disableHomepage'] = self.disable_homepage
        if self.disable_resubmit is not None:
            result['disableResubmit'] = self.disable_resubmit
        if self.disable_stop_process_button is not None:
            result['disableStopProcessButton'] = self.disable_stop_process_button
        if self.hidden is not None:
            result['hidden'] = self.hidden
        if self.origin_dir_id is not None:
            result['originDirId'] = self.origin_dir_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dirId') is not None:
            self.dir_id = m.get('dirId')
        if m.get('disableDeleteProcess') is not None:
            self.disable_delete_process = m.get('disableDeleteProcess')
        if m.get('disableFormEdit') is not None:
            self.disable_form_edit = m.get('disableFormEdit')
        if m.get('disableHomepage') is not None:
            self.disable_homepage = m.get('disableHomepage')
        if m.get('disableResubmit') is not None:
            self.disable_resubmit = m.get('disableResubmit')
        if m.get('disableStopProcessButton') is not None:
            self.disable_stop_process_button = m.get('disableStopProcessButton')
        if m.get('hidden') is not None:
            self.hidden = m.get('hidden')
        if m.get('originDirId') is not None:
            self.origin_dir_id = m.get('originDirId')
        return self


class FormCreateRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        form_components: List[FormComponent] = None,
        name: str = None,
        process_code: str = None,
        template_config: FormCreateRequestTemplateConfig = None,
    ):
        self.description = description
        # This parameter is required.
        self.form_components = form_components
        # This parameter is required.
        self.name = name
        self.process_code = process_code
        self.template_config = template_config

    def validate(self):
        if self.form_components:
            for k in self.form_components:
                if k:
                    k.validate()
        if self.template_config:
            self.template_config.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        result['formComponents'] = []
        if self.form_components is not None:
            for k in self.form_components:
                result['formComponents'].append(k.to_map() if k else None)
        if self.name is not None:
            result['name'] = self.name
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.template_config is not None:
            result['templateConfig'] = self.template_config.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        self.form_components = []
        if m.get('formComponents') is not None:
            for k in m.get('formComponents'):
                temp_model = FormComponent()
                self.form_components.append(temp_model.from_map(k))
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('templateConfig') is not None:
            temp_model = FormCreateRequestTemplateConfig()
            self.template_config = temp_model.from_map(m['templateConfig'])
        return self


class FormCreateResponseBodyResult(TeaModel):
    def __init__(
        self,
        process_code: str = None,
    ):
        # This parameter is required.
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
        status_code: int = None,
        body: FormCreateResponseBody = None,
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
            temp_model = FormCreateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAttachmentSpaceHeaders(TeaModel):
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


class GetAttachmentSpaceRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        user_id: str = None,
    ):
        self.agent_id = agent_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetAttachmentSpaceResponseBodyResult(TeaModel):
    def __init__(
        self,
        space_id: int = None,
    ):
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class GetAttachmentSpaceResponseBody(TeaModel):
    def __init__(
        self,
        result: GetAttachmentSpaceResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetAttachmentSpaceResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetAttachmentSpaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAttachmentSpaceResponseBody = None,
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
            temp_model = GetAttachmentSpaceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetConditionFormComponentHeaders(TeaModel):
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


class GetConditionFormComponentRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        process_code: str = None,
    ):
        self.agent_id = agent_id
        # This parameter is required.
        self.process_code = process_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class GetConditionFormComponentResponseBodyResult(TeaModel):
    def __init__(
        self,
        id: str = None,
        label: str = None,
    ):
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.label = label

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.label is not None:
            result['label'] = self.label
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('label') is not None:
            self.label = m.get('label')
        return self


class GetConditionFormComponentResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetConditionFormComponentResponseBodyResult] = None,
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
                temp_model = GetConditionFormComponentResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetConditionFormComponentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetConditionFormComponentResponseBody = None,
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
            temp_model = GetConditionFormComponentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCrmProcCodesHeaders(TeaModel):
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


class GetCrmProcCodesResponseBody(TeaModel):
    def __init__(
        self,
        result: List[str] = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class GetCrmProcCodesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetCrmProcCodesResponseBody = None,
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
            temp_model = GetCrmProcCodesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFieldModifiedHistoryHeaders(TeaModel):
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


class GetFieldModifiedHistoryRequest(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        process_instance_id: str = None,
    ):
        # This parameter is required.
        self.field_id = field_id
        # This parameter is required.
        self.process_instance_id = process_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        return self


class GetFieldModifiedHistoryResponseBodyResult(TeaModel):
    def __init__(
        self,
        create_time: str = None,
        field_id: str = None,
        name: str = None,
        user_id: str = None,
        value: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        self.field_id = field_id
        self.name = name
        self.user_id = user_id
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetFieldModifiedHistoryResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetFieldModifiedHistoryResponseBodyResult] = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = GetFieldModifiedHistoryResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetFieldModifiedHistoryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFieldModifiedHistoryResponseBody = None,
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
            temp_model = GetFieldModifiedHistoryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetHandSignDownloadUrlHeaders(TeaModel):
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


class GetHandSignDownloadUrlRequest(TeaModel):
    def __init__(
        self,
        hand_sign_token: str = None,
        process_instance_id: str = None,
    ):
        # This parameter is required.
        self.hand_sign_token = hand_sign_token
        # This parameter is required.
        self.process_instance_id = process_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hand_sign_token is not None:
            result['handSignToken'] = self.hand_sign_token
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('handSignToken') is not None:
            self.hand_sign_token = m.get('handSignToken')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        return self


class GetHandSignDownloadUrlResponseBodyResult(TeaModel):
    def __init__(
        self,
        download_url: str = None,
        expire_in: int = None,
    ):
        self.download_url = download_url
        self.expire_in = expire_in

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.download_url is not None:
            result['downloadUrl'] = self.download_url
        if self.expire_in is not None:
            result['expireIn'] = self.expire_in
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('downloadUrl') is not None:
            self.download_url = m.get('downloadUrl')
        if m.get('expireIn') is not None:
            self.expire_in = m.get('expireIn')
        return self


class GetHandSignDownloadUrlResponseBody(TeaModel):
    def __init__(
        self,
        result: GetHandSignDownloadUrlResponseBodyResult = None,
        success: str = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetHandSignDownloadUrlResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetHandSignDownloadUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetHandSignDownloadUrlResponseBody = None,
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
            temp_model = GetHandSignDownloadUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetManageProcessByStaffIdHeaders(TeaModel):
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


class GetManageProcessByStaffIdRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetManageProcessByStaffIdResponseBodyResult(TeaModel):
    def __init__(
        self,
        attendance_type: int = None,
        flow_title: str = None,
        gmt_modified: str = None,
        icon_name: str = None,
        icon_url: str = None,
        new_process: bool = None,
        process_code: str = None,
    ):
        self.attendance_type = attendance_type
        self.flow_title = flow_title
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.gmt_modified = gmt_modified
        self.icon_name = icon_name
        self.icon_url = icon_url
        self.new_process = new_process
        self.process_code = process_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attendance_type is not None:
            result['attendanceType'] = self.attendance_type
        if self.flow_title is not None:
            result['flowTitle'] = self.flow_title
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.icon_name is not None:
            result['iconName'] = self.icon_name
        if self.icon_url is not None:
            result['iconUrl'] = self.icon_url
        if self.new_process is not None:
            result['newProcess'] = self.new_process
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attendanceType') is not None:
            self.attendance_type = m.get('attendanceType')
        if m.get('flowTitle') is not None:
            self.flow_title = m.get('flowTitle')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('iconName') is not None:
            self.icon_name = m.get('iconName')
        if m.get('iconUrl') is not None:
            self.icon_url = m.get('iconUrl')
        if m.get('newProcess') is not None:
            self.new_process = m.get('newProcess')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class GetManageProcessByStaffIdResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetManageProcessByStaffIdResponseBodyResult] = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = GetManageProcessByStaffIdResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetManageProcessByStaffIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetManageProcessByStaffIdResponseBody = None,
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
            temp_model = GetManageProcessByStaffIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetProcessCodeByNameHeaders(TeaModel):
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


class GetProcessCodeByNameRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
    ):
        # This parameter is required.
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class GetProcessCodeByNameResponseBodyResult(TeaModel):
    def __init__(
        self,
        gmt_modified: str = None,
        process_code: str = None,
    ):
        # This parameter is required.
        # 
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.gmt_modified = gmt_modified
        # This parameter is required.
        self.process_code = process_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class GetProcessCodeByNameResponseBody(TeaModel):
    def __init__(
        self,
        result: GetProcessCodeByNameResponseBodyResult = None,
    ):
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
            temp_model = GetProcessCodeByNameResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetProcessCodeByNameResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetProcessCodeByNameResponseBody = None,
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
            temp_model = GetProcessCodeByNameResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetProcessConfigHeaders(TeaModel):
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


class GetProcessConfigRequest(TeaModel):
    def __init__(
        self,
        proc_code: str = None,
    ):
        # This parameter is required.
        self.proc_code = proc_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.proc_code is not None:
            result['procCode'] = self.proc_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('procCode') is not None:
            self.proc_code = m.get('procCode')
        return self


class GetProcessConfigResponseBodyResultCommentConf(TeaModel):
    def __init__(
        self,
        comment_description: str = None,
        comment_hidden_for_proposer: bool = None,
        comment_required: bool = None,
    ):
        self.comment_description = comment_description
        self.comment_hidden_for_proposer = comment_hidden_for_proposer
        self.comment_required = comment_required

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.comment_description is not None:
            result['commentDescription'] = self.comment_description
        if self.comment_hidden_for_proposer is not None:
            result['commentHiddenForProposer'] = self.comment_hidden_for_proposer
        if self.comment_required is not None:
            result['commentRequired'] = self.comment_required
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commentDescription') is not None:
            self.comment_description = m.get('commentDescription')
        if m.get('commentHiddenForProposer') is not None:
            self.comment_hidden_for_proposer = m.get('commentHiddenForProposer')
        if m.get('commentRequired') is not None:
            self.comment_required = m.get('commentRequired')
        return self


class GetProcessConfigResponseBodyResultHandSignConf(TeaModel):
    def __init__(
        self,
        hand_sign_enable: bool = None,
        resign_enable: bool = None,
    ):
        self.hand_sign_enable = hand_sign_enable
        self.resign_enable = resign_enable

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hand_sign_enable is not None:
            result['handSignEnable'] = self.hand_sign_enable
        if self.resign_enable is not None:
            result['resignEnable'] = self.resign_enable
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('handSignEnable') is not None:
            self.hand_sign_enable = m.get('handSignEnable')
        if m.get('resignEnable') is not None:
            self.resign_enable = m.get('resignEnable')
        return self


class GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList(TeaModel):
    def __init__(
        self,
        name: str = None,
        type: str = None,
        value: str = None,
    ):
        self.name = name
        self.type = type
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
        if self.type is not None:
            result['type'] = self.type
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetProcessConfigResponseBodyResultSubstituteSubmitConf(TeaModel):
    def __init__(
        self,
        enable: bool = None,
        submitter_list: List[GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList] = None,
    ):
        self.enable = enable
        self.submitter_list = submitter_list

    def validate(self):
        if self.submitter_list:
            for k in self.submitter_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.enable is not None:
            result['enable'] = self.enable
        result['submitterList'] = []
        if self.submitter_list is not None:
            for k in self.submitter_list:
                result['submitterList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enable') is not None:
            self.enable = m.get('enable')
        self.submitter_list = []
        if m.get('submitterList') is not None:
            for k in m.get('submitterList'):
                temp_model = GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList()
                self.submitter_list.append(temp_model.from_map(k))
        return self


class GetProcessConfigResponseBodyResultTitleGenRule(TeaModel):
    def __init__(
        self,
        express: str = None,
        type: int = None,
    ):
        self.express = express
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.express is not None:
            result['express'] = self.express
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('express') is not None:
            self.express = m.get('express')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetProcessConfigResponseBodyResultVisibility(TeaModel):
    def __init__(
        self,
        type: int = None,
        value: str = None,
    ):
        self.type = type
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetProcessConfigResponseBodyResult(TeaModel):
    def __init__(
        self,
        abstract_gen_rule: List[str] = None,
        activity_auth: str = None,
        allow_revoke: bool = None,
        append_enable: bool = None,
        auto_execute_originator_tasks: bool = None,
        biz_category_id: str = None,
        biz_type: str = None,
        comment_conf: GetProcessConfigResponseBodyResultCommentConf = None,
        duplicate_removal: str = None,
        form_schema: str = None,
        hand_sign_conf: GetProcessConfigResponseBodyResultHandSignConf = None,
        managers: List[str] = None,
        name: str = None,
        process_app_type: bool = None,
        process_config: str = None,
        static_proc: bool = None,
        substitute_submit_conf: GetProcessConfigResponseBodyResultSubstituteSubmitConf = None,
        title_gen_rule: GetProcessConfigResponseBodyResultTitleGenRule = None,
        visibility: List[GetProcessConfigResponseBodyResultVisibility] = None,
    ):
        self.abstract_gen_rule = abstract_gen_rule
        self.activity_auth = activity_auth
        self.allow_revoke = allow_revoke
        self.append_enable = append_enable
        self.auto_execute_originator_tasks = auto_execute_originator_tasks
        self.biz_category_id = biz_category_id
        self.biz_type = biz_type
        self.comment_conf = comment_conf
        self.duplicate_removal = duplicate_removal
        self.form_schema = form_schema
        self.hand_sign_conf = hand_sign_conf
        self.managers = managers
        self.name = name
        self.process_app_type = process_app_type
        self.process_config = process_config
        self.static_proc = static_proc
        self.substitute_submit_conf = substitute_submit_conf
        self.title_gen_rule = title_gen_rule
        self.visibility = visibility

    def validate(self):
        if self.comment_conf:
            self.comment_conf.validate()
        if self.hand_sign_conf:
            self.hand_sign_conf.validate()
        if self.substitute_submit_conf:
            self.substitute_submit_conf.validate()
        if self.title_gen_rule:
            self.title_gen_rule.validate()
        if self.visibility:
            for k in self.visibility:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.abstract_gen_rule is not None:
            result['abstractGenRule'] = self.abstract_gen_rule
        if self.activity_auth is not None:
            result['activityAuth'] = self.activity_auth
        if self.allow_revoke is not None:
            result['allowRevoke'] = self.allow_revoke
        if self.append_enable is not None:
            result['appendEnable'] = self.append_enable
        if self.auto_execute_originator_tasks is not None:
            result['autoExecuteOriginatorTasks'] = self.auto_execute_originator_tasks
        if self.biz_category_id is not None:
            result['bizCategoryId'] = self.biz_category_id
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.comment_conf is not None:
            result['commentConf'] = self.comment_conf.to_map()
        if self.duplicate_removal is not None:
            result['duplicateRemoval'] = self.duplicate_removal
        if self.form_schema is not None:
            result['formSchema'] = self.form_schema
        if self.hand_sign_conf is not None:
            result['handSignConf'] = self.hand_sign_conf.to_map()
        if self.managers is not None:
            result['managers'] = self.managers
        if self.name is not None:
            result['name'] = self.name
        if self.process_app_type is not None:
            result['processAppType'] = self.process_app_type
        if self.process_config is not None:
            result['processConfig'] = self.process_config
        if self.static_proc is not None:
            result['staticProc'] = self.static_proc
        if self.substitute_submit_conf is not None:
            result['substituteSubmitConf'] = self.substitute_submit_conf.to_map()
        if self.title_gen_rule is not None:
            result['titleGenRule'] = self.title_gen_rule.to_map()
        result['visibility'] = []
        if self.visibility is not None:
            for k in self.visibility:
                result['visibility'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('abstractGenRule') is not None:
            self.abstract_gen_rule = m.get('abstractGenRule')
        if m.get('activityAuth') is not None:
            self.activity_auth = m.get('activityAuth')
        if m.get('allowRevoke') is not None:
            self.allow_revoke = m.get('allowRevoke')
        if m.get('appendEnable') is not None:
            self.append_enable = m.get('appendEnable')
        if m.get('autoExecuteOriginatorTasks') is not None:
            self.auto_execute_originator_tasks = m.get('autoExecuteOriginatorTasks')
        if m.get('bizCategoryId') is not None:
            self.biz_category_id = m.get('bizCategoryId')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('commentConf') is not None:
            temp_model = GetProcessConfigResponseBodyResultCommentConf()
            self.comment_conf = temp_model.from_map(m['commentConf'])
        if m.get('duplicateRemoval') is not None:
            self.duplicate_removal = m.get('duplicateRemoval')
        if m.get('formSchema') is not None:
            self.form_schema = m.get('formSchema')
        if m.get('handSignConf') is not None:
            temp_model = GetProcessConfigResponseBodyResultHandSignConf()
            self.hand_sign_conf = temp_model.from_map(m['handSignConf'])
        if m.get('managers') is not None:
            self.managers = m.get('managers')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('processAppType') is not None:
            self.process_app_type = m.get('processAppType')
        if m.get('processConfig') is not None:
            self.process_config = m.get('processConfig')
        if m.get('staticProc') is not None:
            self.static_proc = m.get('staticProc')
        if m.get('substituteSubmitConf') is not None:
            temp_model = GetProcessConfigResponseBodyResultSubstituteSubmitConf()
            self.substitute_submit_conf = temp_model.from_map(m['substituteSubmitConf'])
        if m.get('titleGenRule') is not None:
            temp_model = GetProcessConfigResponseBodyResultTitleGenRule()
            self.title_gen_rule = temp_model.from_map(m['titleGenRule'])
        self.visibility = []
        if m.get('visibility') is not None:
            for k in m.get('visibility'):
                temp_model = GetProcessConfigResponseBodyResultVisibility()
                self.visibility.append(temp_model.from_map(k))
        return self


class GetProcessConfigResponseBody(TeaModel):
    def __init__(
        self,
        result: GetProcessConfigResponseBodyResult = None,
    ):
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
            temp_model = GetProcessConfigResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetProcessConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetProcessConfigResponseBody = None,
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
            temp_model = GetProcessConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetProcessInstanceHeaders(TeaModel):
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


class GetProcessInstanceRequest(TeaModel):
    def __init__(
        self,
        process_instance_id: str = None,
    ):
        # This parameter is required.
        self.process_instance_id = process_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        return self


class GetProcessInstanceResponseBodyResultFormComponentValues(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        component_type: str = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.component_type = component_type
        self.ext_value = ext_value
        self.id = id
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetProcessInstanceResponseBodyResultOperationRecordsAttachments(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        file_size: str = None,
        file_type: str = None,
        space_id: str = None,
    ):
        self.file_id = file_id
        self.file_name = file_name
        self.file_size = file_size
        self.file_type = file_type
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class GetProcessInstanceResponseBodyResultOperationRecords(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        attachments: List[GetProcessInstanceResponseBodyResultOperationRecordsAttachments] = None,
        cc_user_ids: List[str] = None,
        date: str = None,
        images: List[str] = None,
        remark: str = None,
        result: str = None,
        show_name: str = None,
        type: str = None,
        user_id: str = None,
    ):
        self.activity_id = activity_id
        self.attachments = attachments
        self.cc_user_ids = cc_user_ids
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.date = date
        self.images = images
        self.remark = remark
        self.result = result
        self.show_name = show_name
        self.type = type
        self.user_id = user_id

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
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.cc_user_ids is not None:
            result['ccUserIds'] = self.cc_user_ids
        if self.date is not None:
            result['date'] = self.date
        if self.images is not None:
            result['images'] = self.images
        if self.remark is not None:
            result['remark'] = self.remark
        if self.result is not None:
            result['result'] = self.result
        if self.show_name is not None:
            result['showName'] = self.show_name
        if self.type is not None:
            result['type'] = self.type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = GetProcessInstanceResponseBodyResultOperationRecordsAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('ccUserIds') is not None:
            self.cc_user_ids = m.get('ccUserIds')
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('images') is not None:
            self.images = m.get('images')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('showName') is not None:
            self.show_name = m.get('showName')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetProcessInstanceResponseBodyResultTasks(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        create_time: str = None,
        finish_time: str = None,
        mobile_url: str = None,
        pc_url: str = None,
        process_instance_id: str = None,
        result: str = None,
        status: str = None,
        task_id: int = None,
        user_id: str = None,
    ):
        self.activity_id = activity_id
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.finish_time = finish_time
        self.mobile_url = mobile_url
        self.pc_url = pc_url
        self.process_instance_id = process_instance_id
        self.result = result
        self.status = status
        self.task_id = task_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetProcessInstanceResponseBodyResult(TeaModel):
    def __init__(
        self,
        approver_user_ids: List[str] = None,
        attached_process_instance_ids: List[str] = None,
        biz_action: str = None,
        biz_data: str = None,
        business_id: str = None,
        cc_user_ids: List[str] = None,
        create_time: str = None,
        finish_time: str = None,
        form_component_values: List[GetProcessInstanceResponseBodyResultFormComponentValues] = None,
        main_process_instance_id: str = None,
        operation_records: List[GetProcessInstanceResponseBodyResultOperationRecords] = None,
        originator_dept_id: str = None,
        originator_dept_name: str = None,
        originator_user_id: str = None,
        result: str = None,
        status: str = None,
        tasks: List[GetProcessInstanceResponseBodyResultTasks] = None,
        title: str = None,
    ):
        self.approver_user_ids = approver_user_ids
        self.attached_process_instance_ids = attached_process_instance_ids
        self.biz_action = biz_action
        self.biz_data = biz_data
        self.business_id = business_id
        self.cc_user_ids = cc_user_ids
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        self.finish_time = finish_time
        self.form_component_values = form_component_values
        self.main_process_instance_id = main_process_instance_id
        self.operation_records = operation_records
        self.originator_dept_id = originator_dept_id
        self.originator_dept_name = originator_dept_name
        self.originator_user_id = originator_user_id
        self.result = result
        self.status = status
        self.tasks = tasks
        self.title = title

    def validate(self):
        if self.form_component_values:
            for k in self.form_component_values:
                if k:
                    k.validate()
        if self.operation_records:
            for k in self.operation_records:
                if k:
                    k.validate()
        if self.tasks:
            for k in self.tasks:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.approver_user_ids is not None:
            result['approverUserIds'] = self.approver_user_ids
        if self.attached_process_instance_ids is not None:
            result['attachedProcessInstanceIds'] = self.attached_process_instance_ids
        if self.biz_action is not None:
            result['bizAction'] = self.biz_action
        if self.biz_data is not None:
            result['bizData'] = self.biz_data
        if self.business_id is not None:
            result['businessId'] = self.business_id
        if self.cc_user_ids is not None:
            result['ccUserIds'] = self.cc_user_ids
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        result['formComponentValues'] = []
        if self.form_component_values is not None:
            for k in self.form_component_values:
                result['formComponentValues'].append(k.to_map() if k else None)
        if self.main_process_instance_id is not None:
            result['mainProcessInstanceId'] = self.main_process_instance_id
        result['operationRecords'] = []
        if self.operation_records is not None:
            for k in self.operation_records:
                result['operationRecords'].append(k.to_map() if k else None)
        if self.originator_dept_id is not None:
            result['originatorDeptId'] = self.originator_dept_id
        if self.originator_dept_name is not None:
            result['originatorDeptName'] = self.originator_dept_name
        if self.originator_user_id is not None:
            result['originatorUserId'] = self.originator_user_id
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        result['tasks'] = []
        if self.tasks is not None:
            for k in self.tasks:
                result['tasks'].append(k.to_map() if k else None)
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('approverUserIds') is not None:
            self.approver_user_ids = m.get('approverUserIds')
        if m.get('attachedProcessInstanceIds') is not None:
            self.attached_process_instance_ids = m.get('attachedProcessInstanceIds')
        if m.get('bizAction') is not None:
            self.biz_action = m.get('bizAction')
        if m.get('bizData') is not None:
            self.biz_data = m.get('bizData')
        if m.get('businessId') is not None:
            self.business_id = m.get('businessId')
        if m.get('ccUserIds') is not None:
            self.cc_user_ids = m.get('ccUserIds')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        self.form_component_values = []
        if m.get('formComponentValues') is not None:
            for k in m.get('formComponentValues'):
                temp_model = GetProcessInstanceResponseBodyResultFormComponentValues()
                self.form_component_values.append(temp_model.from_map(k))
        if m.get('mainProcessInstanceId') is not None:
            self.main_process_instance_id = m.get('mainProcessInstanceId')
        self.operation_records = []
        if m.get('operationRecords') is not None:
            for k in m.get('operationRecords'):
                temp_model = GetProcessInstanceResponseBodyResultOperationRecords()
                self.operation_records.append(temp_model.from_map(k))
        if m.get('originatorDeptId') is not None:
            self.originator_dept_id = m.get('originatorDeptId')
        if m.get('originatorDeptName') is not None:
            self.originator_dept_name = m.get('originatorDeptName')
        if m.get('originatorUserId') is not None:
            self.originator_user_id = m.get('originatorUserId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        self.tasks = []
        if m.get('tasks') is not None:
            for k in m.get('tasks'):
                temp_model = GetProcessInstanceResponseBodyResultTasks()
                self.tasks.append(temp_model.from_map(k))
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetProcessInstanceResponseBody(TeaModel):
    def __init__(
        self,
        result: GetProcessInstanceResponseBodyResult = None,
        success: str = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetProcessInstanceResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetProcessInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetProcessInstanceResponseBody = None,
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
            temp_model = GetProcessInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetProcessInstanceWithExtraHeaders(TeaModel):
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


class GetProcessInstanceWithExtraRequest(TeaModel):
    def __init__(
        self,
        process_instance_id: str = None,
    ):
        # This parameter is required.
        self.process_instance_id = process_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        return self


class GetProcessInstanceWithExtraResponseBodyResultFormComponentValues(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        component_type: str = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.component_type = component_type
        self.ext_value = ext_value
        self.id = id
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        file_size: str = None,
        file_type: str = None,
        space_id: str = None,
    ):
        self.file_id = file_id
        self.file_name = file_name
        self.file_size = file_size
        self.file_type = file_type
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class GetProcessInstanceWithExtraResponseBodyResultOperationRecords(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        attachments: List[GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments] = None,
        cc_user_ids: List[str] = None,
        date: str = None,
        hand_sign_token: str = None,
        images: List[str] = None,
        remark: str = None,
        result: str = None,
        show_name: str = None,
        type: str = None,
        user_id: str = None,
    ):
        self.activity_id = activity_id
        self.attachments = attachments
        self.cc_user_ids = cc_user_ids
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.date = date
        self.hand_sign_token = hand_sign_token
        self.images = images
        self.remark = remark
        self.result = result
        self.show_name = show_name
        self.type = type
        self.user_id = user_id

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
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.cc_user_ids is not None:
            result['ccUserIds'] = self.cc_user_ids
        if self.date is not None:
            result['date'] = self.date
        if self.hand_sign_token is not None:
            result['handSignToken'] = self.hand_sign_token
        if self.images is not None:
            result['images'] = self.images
        if self.remark is not None:
            result['remark'] = self.remark
        if self.result is not None:
            result['result'] = self.result
        if self.show_name is not None:
            result['showName'] = self.show_name
        if self.type is not None:
            result['type'] = self.type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('ccUserIds') is not None:
            self.cc_user_ids = m.get('ccUserIds')
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('handSignToken') is not None:
            self.hand_sign_token = m.get('handSignToken')
        if m.get('images') is not None:
            self.images = m.get('images')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('showName') is not None:
            self.show_name = m.get('showName')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetProcessInstanceWithExtraResponseBodyResultTasks(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        create_time: str = None,
        finish_time: str = None,
        mobile_url: str = None,
        pc_url: str = None,
        process_instance_id: str = None,
        result: str = None,
        status: str = None,
        task_id: int = None,
        user_id: str = None,
    ):
        self.activity_id = activity_id
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.finish_time = finish_time
        self.mobile_url = mobile_url
        self.pc_url = pc_url
        self.process_instance_id = process_instance_id
        self.result = result
        self.status = status
        self.task_id = task_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetProcessInstanceWithExtraResponseBodyResult(TeaModel):
    def __init__(
        self,
        approver_user_ids: List[str] = None,
        attached_process_instance_ids: List[str] = None,
        biz_action: str = None,
        biz_data: str = None,
        business_id: str = None,
        cc_user_ids: List[str] = None,
        create_time: str = None,
        finish_time: str = None,
        form_component_values: List[GetProcessInstanceWithExtraResponseBodyResultFormComponentValues] = None,
        main_process_instance_id: str = None,
        operation_records: List[GetProcessInstanceWithExtraResponseBodyResultOperationRecords] = None,
        originator_dept_id: str = None,
        originator_dept_name: str = None,
        originator_user_id: str = None,
        result: str = None,
        status: str = None,
        tasks: List[GetProcessInstanceWithExtraResponseBodyResultTasks] = None,
        title: str = None,
    ):
        self.approver_user_ids = approver_user_ids
        self.attached_process_instance_ids = attached_process_instance_ids
        self.biz_action = biz_action
        self.biz_data = biz_data
        self.business_id = business_id
        self.cc_user_ids = cc_user_ids
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        self.finish_time = finish_time
        self.form_component_values = form_component_values
        self.main_process_instance_id = main_process_instance_id
        self.operation_records = operation_records
        self.originator_dept_id = originator_dept_id
        self.originator_dept_name = originator_dept_name
        self.originator_user_id = originator_user_id
        self.result = result
        self.status = status
        self.tasks = tasks
        self.title = title

    def validate(self):
        if self.form_component_values:
            for k in self.form_component_values:
                if k:
                    k.validate()
        if self.operation_records:
            for k in self.operation_records:
                if k:
                    k.validate()
        if self.tasks:
            for k in self.tasks:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.approver_user_ids is not None:
            result['approverUserIds'] = self.approver_user_ids
        if self.attached_process_instance_ids is not None:
            result['attachedProcessInstanceIds'] = self.attached_process_instance_ids
        if self.biz_action is not None:
            result['bizAction'] = self.biz_action
        if self.biz_data is not None:
            result['bizData'] = self.biz_data
        if self.business_id is not None:
            result['businessId'] = self.business_id
        if self.cc_user_ids is not None:
            result['ccUserIds'] = self.cc_user_ids
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        result['formComponentValues'] = []
        if self.form_component_values is not None:
            for k in self.form_component_values:
                result['formComponentValues'].append(k.to_map() if k else None)
        if self.main_process_instance_id is not None:
            result['mainProcessInstanceId'] = self.main_process_instance_id
        result['operationRecords'] = []
        if self.operation_records is not None:
            for k in self.operation_records:
                result['operationRecords'].append(k.to_map() if k else None)
        if self.originator_dept_id is not None:
            result['originatorDeptId'] = self.originator_dept_id
        if self.originator_dept_name is not None:
            result['originatorDeptName'] = self.originator_dept_name
        if self.originator_user_id is not None:
            result['originatorUserId'] = self.originator_user_id
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        result['tasks'] = []
        if self.tasks is not None:
            for k in self.tasks:
                result['tasks'].append(k.to_map() if k else None)
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('approverUserIds') is not None:
            self.approver_user_ids = m.get('approverUserIds')
        if m.get('attachedProcessInstanceIds') is not None:
            self.attached_process_instance_ids = m.get('attachedProcessInstanceIds')
        if m.get('bizAction') is not None:
            self.biz_action = m.get('bizAction')
        if m.get('bizData') is not None:
            self.biz_data = m.get('bizData')
        if m.get('businessId') is not None:
            self.business_id = m.get('businessId')
        if m.get('ccUserIds') is not None:
            self.cc_user_ids = m.get('ccUserIds')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        self.form_component_values = []
        if m.get('formComponentValues') is not None:
            for k in m.get('formComponentValues'):
                temp_model = GetProcessInstanceWithExtraResponseBodyResultFormComponentValues()
                self.form_component_values.append(temp_model.from_map(k))
        if m.get('mainProcessInstanceId') is not None:
            self.main_process_instance_id = m.get('mainProcessInstanceId')
        self.operation_records = []
        if m.get('operationRecords') is not None:
            for k in m.get('operationRecords'):
                temp_model = GetProcessInstanceWithExtraResponseBodyResultOperationRecords()
                self.operation_records.append(temp_model.from_map(k))
        if m.get('originatorDeptId') is not None:
            self.originator_dept_id = m.get('originatorDeptId')
        if m.get('originatorDeptName') is not None:
            self.originator_dept_name = m.get('originatorDeptName')
        if m.get('originatorUserId') is not None:
            self.originator_user_id = m.get('originatorUserId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        self.tasks = []
        if m.get('tasks') is not None:
            for k in m.get('tasks'):
                temp_model = GetProcessInstanceWithExtraResponseBodyResultTasks()
                self.tasks.append(temp_model.from_map(k))
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetProcessInstanceWithExtraResponseBody(TeaModel):
    def __init__(
        self,
        result: GetProcessInstanceWithExtraResponseBodyResult = None,
        success: str = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetProcessInstanceWithExtraResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetProcessInstanceWithExtraResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetProcessInstanceWithExtraResponseBody = None,
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
            temp_model = GetProcessInstanceWithExtraResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSchemaAndProcessconfigBatchllyHeaders(TeaModel):
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


class GetSchemaAndProcessconfigBatchllyRequest(TeaModel):
    def __init__(
        self,
        process_codes: List[str] = None,
    ):
        self.process_codes = process_codes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_codes is not None:
            result['processCodes'] = self.process_codes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processCodes') is not None:
            self.process_codes = m.get('processCodes')
        return self


class GetSchemaAndProcessconfigBatchllyShrinkRequest(TeaModel):
    def __init__(
        self,
        process_codes_shrink: str = None,
    ):
        self.process_codes_shrink = process_codes_shrink

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_codes_shrink is not None:
            result['processCodes'] = self.process_codes_shrink
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processCodes') is not None:
            self.process_codes_shrink = m.get('processCodes')
        return self


class GetSchemaAndProcessconfigBatchllyResponseBodyResult(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        biz_category_id: str = None,
        create_time: str = None,
        creator_user_id: str = None,
        form_uuid: str = None,
        manager_list: str = None,
        memo: str = None,
        name: str = None,
        process_code: str = None,
        process_config: str = None,
        process_id: int = None,
        properties: str = None,
        schema_content: str = None,
        visible_scope: str = None,
    ):
        self.app_uuid = app_uuid
        self.biz_category_id = biz_category_id
        self.create_time = create_time
        self.creator_user_id = creator_user_id
        self.form_uuid = form_uuid
        self.manager_list = manager_list
        self.memo = memo
        self.name = name
        self.process_code = process_code
        self.process_config = process_config
        self.process_id = process_id
        self.properties = properties
        self.schema_content = schema_content
        self.visible_scope = visible_scope

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.biz_category_id is not None:
            result['bizCategoryId'] = self.biz_category_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.manager_list is not None:
            result['managerList'] = self.manager_list
        if self.memo is not None:
            result['memo'] = self.memo
        if self.name is not None:
            result['name'] = self.name
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_config is not None:
            result['processConfig'] = self.process_config
        if self.process_id is not None:
            result['processId'] = self.process_id
        if self.properties is not None:
            result['properties'] = self.properties
        if self.schema_content is not None:
            result['schemaContent'] = self.schema_content
        if self.visible_scope is not None:
            result['visibleScope'] = self.visible_scope
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('bizCategoryId') is not None:
            self.biz_category_id = m.get('bizCategoryId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('managerList') is not None:
            self.manager_list = m.get('managerList')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processConfig') is not None:
            self.process_config = m.get('processConfig')
        if m.get('processId') is not None:
            self.process_id = m.get('processId')
        if m.get('properties') is not None:
            self.properties = m.get('properties')
        if m.get('schemaContent') is not None:
            self.schema_content = m.get('schemaContent')
        if m.get('visibleScope') is not None:
            self.visible_scope = m.get('visibleScope')
        return self


class GetSchemaAndProcessconfigBatchllyResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetSchemaAndProcessconfigBatchllyResponseBodyResult] = None,
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
                temp_model = GetSchemaAndProcessconfigBatchllyResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetSchemaAndProcessconfigBatchllyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSchemaAndProcessconfigBatchllyResponseBody = None,
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
            temp_model = GetSchemaAndProcessconfigBatchllyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSpaceWithDownloadAuthHeaders(TeaModel):
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


class GetSpaceWithDownloadAuthRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        file_id: str = None,
        file_id_list: List[str] = None,
        process_instance_id: str = None,
        user_id: str = None,
        with_comment_attatchment: bool = None,
    ):
        self.agent_id = agent_id
        # This parameter is required.
        self.file_id = file_id
        self.file_id_list = file_id_list
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.user_id = user_id
        self.with_comment_attatchment = with_comment_attatchment

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_id_list is not None:
            result['fileIdList'] = self.file_id_list
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.with_comment_attatchment is not None:
            result['withCommentAttatchment'] = self.with_comment_attatchment
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileIdList') is not None:
            self.file_id_list = m.get('fileIdList')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('withCommentAttatchment') is not None:
            self.with_comment_attatchment = m.get('withCommentAttatchment')
        return self


class GetSpaceWithDownloadAuthResponseBodyResult(TeaModel):
    def __init__(
        self,
        space_id: int = None,
    ):
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class GetSpaceWithDownloadAuthResponseBody(TeaModel):
    def __init__(
        self,
        result: GetSpaceWithDownloadAuthResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetSpaceWithDownloadAuthResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetSpaceWithDownloadAuthResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSpaceWithDownloadAuthResponseBody = None,
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
            temp_model = GetSpaceWithDownloadAuthResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserTodoTaskSumHeaders(TeaModel):
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


class GetUserTodoTaskSumRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetUserTodoTaskSumResponseBody(TeaModel):
    def __init__(
        self,
        result: int = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class GetUserTodoTaskSumResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetUserTodoTaskSumResponseBody = None,
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
            temp_model = GetUserTodoTaskSumResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GrantCspaceAuthorizationHeaders(TeaModel):
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


class GrantCspaceAuthorizationRequest(TeaModel):
    def __init__(
        self,
        duration_seconds: int = None,
        space_id: str = None,
        type: str = None,
        user_id: str = None,
    ):
        self.duration_seconds = duration_seconds
        # This parameter is required.
        self.space_id = space_id
        # This parameter is required.
        self.type = type
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration_seconds is not None:
            result['durationSeconds'] = self.duration_seconds
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.type is not None:
            result['type'] = self.type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('durationSeconds') is not None:
            self.duration_seconds = m.get('durationSeconds')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GrantCspaceAuthorizationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class GrantProcessInstanceForDownloadFileHeaders(TeaModel):
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


class GrantProcessInstanceForDownloadFileRequest(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        process_instance_id: str = None,
        with_comment_attatchment: bool = None,
    ):
        # This parameter is required.
        self.file_id = file_id
        # This parameter is required.
        self.process_instance_id = process_instance_id
        self.with_comment_attatchment = with_comment_attatchment

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.with_comment_attatchment is not None:
            result['withCommentAttatchment'] = self.with_comment_attatchment
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('withCommentAttatchment') is not None:
            self.with_comment_attatchment = m.get('withCommentAttatchment')
        return self


class GrantProcessInstanceForDownloadFileResponseBodyResult(TeaModel):
    def __init__(
        self,
        download_uri: str = None,
        file_id: str = None,
        space_id: int = None,
    ):
        self.download_uri = download_uri
        self.file_id = file_id
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.download_uri is not None:
            result['downloadUri'] = self.download_uri
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('downloadUri') is not None:
            self.download_uri = m.get('downloadUri')
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class GrantProcessInstanceForDownloadFileResponseBody(TeaModel):
    def __init__(
        self,
        result: GrantProcessInstanceForDownloadFileResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GrantProcessInstanceForDownloadFileResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GrantProcessInstanceForDownloadFileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GrantProcessInstanceForDownloadFileResponseBody = None,
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
            temp_model = GrantProcessInstanceForDownloadFileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InsertOrUpdateDirHeaders(TeaModel):
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


class InsertOrUpdateDirRequest(TeaModel):
    def __init__(
        self,
        biz_group: str = None,
        description: str = None,
        name: str = None,
        name_18n: str = None,
        operate_user_id: str = None,
    ):
        self.biz_group = biz_group
        self.description = description
        self.name = name
        # This parameter is required.
        self.name_18n = name_18n
        # This parameter is required.
        self.operate_user_id = operate_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_group is not None:
            result['bizGroup'] = self.biz_group
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.name_18n is not None:
            result['name18n'] = self.name_18n
        if self.operate_user_id is not None:
            result['operateUserId'] = self.operate_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizGroup') is not None:
            self.biz_group = m.get('bizGroup')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('name18n') is not None:
            self.name_18n = m.get('name18n')
        if m.get('operateUserId') is not None:
            self.operate_user_id = m.get('operateUserId')
        return self


class InsertOrUpdateDirResponseBodyResult(TeaModel):
    def __init__(
        self,
        biz_group: str = None,
        dir_id: str = None,
    ):
        self.biz_group = biz_group
        self.dir_id = dir_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_group is not None:
            result['bizGroup'] = self.biz_group
        if self.dir_id is not None:
            result['dirId'] = self.dir_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizGroup') is not None:
            self.biz_group = m.get('bizGroup')
        if m.get('dirId') is not None:
            self.dir_id = m.get('dirId')
        return self


class InsertOrUpdateDirResponseBody(TeaModel):
    def __init__(
        self,
        result: InsertOrUpdateDirResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = InsertOrUpdateDirResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class InsertOrUpdateDirResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InsertOrUpdateDirResponseBody = None,
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
            temp_model = InsertOrUpdateDirResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InstallAppHeaders(TeaModel):
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


class InstallAppRequestInstallOption(TeaModel):
    def __init__(
        self,
        is_sync: bool = None,
    ):
        self.is_sync = is_sync

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_sync is not None:
            result['isSync'] = self.is_sync
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isSync') is not None:
            self.is_sync = m.get('isSync')
        return self


class InstallAppRequest(TeaModel):
    def __init__(
        self,
        biz_group: str = None,
        install_option: InstallAppRequestInstallOption = None,
        source_dir_name: str = None,
    ):
        self.biz_group = biz_group
        # This parameter is required.
        self.install_option = install_option
        # This parameter is required.
        self.source_dir_name = source_dir_name

    def validate(self):
        if self.install_option:
            self.install_option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_group is not None:
            result['bizGroup'] = self.biz_group
        if self.install_option is not None:
            result['installOption'] = self.install_option.to_map()
        if self.source_dir_name is not None:
            result['sourceDirName'] = self.source_dir_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizGroup') is not None:
            self.biz_group = m.get('bizGroup')
        if m.get('installOption') is not None:
            temp_model = InstallAppRequestInstallOption()
            self.install_option = temp_model.from_map(m['installOption'])
        if m.get('sourceDirName') is not None:
            self.source_dir_name = m.get('sourceDirName')
        return self


class InstallAppResponseBodyResult(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        name: str = None,
        process_code: str = None,
    ):
        self.biz_type = biz_type
        self.name = name
        self.process_code = process_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.name is not None:
            result['name'] = self.name
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class InstallAppResponseBody(TeaModel):
    def __init__(
        self,
        result: List[InstallAppResponseBodyResult] = None,
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
                temp_model = InstallAppResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class InstallAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InstallAppResponseBody = None,
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
            temp_model = InstallAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListProcessInstanceIdsHeaders(TeaModel):
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


class ListProcessInstanceIdsRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        max_results: int = None,
        next_token: int = None,
        process_code: str = None,
        start_time: int = None,
        statuses: List[str] = None,
        user_ids: List[str] = None,
    ):
        self.end_time = end_time
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        # This parameter is required.
        self.process_code = process_code
        # This parameter is required.
        self.start_time = start_time
        self.statuses = statuses
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.statuses is not None:
            result['statuses'] = self.statuses
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('statuses') is not None:
            self.statuses = m.get('statuses')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class ListProcessInstanceIdsResponseBodyResult(TeaModel):
    def __init__(
        self,
        list: List[str] = None,
        next_token: str = None,
    ):
        self.list = list
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.list is not None:
            result['list'] = self.list
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('list') is not None:
            self.list = m.get('list')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListProcessInstanceIdsResponseBody(TeaModel):
    def __init__(
        self,
        result: ListProcessInstanceIdsResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = ListProcessInstanceIdsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ListProcessInstanceIdsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListProcessInstanceIdsResponseBody = None,
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
            temp_model = ListProcessInstanceIdsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListTodoWorkRecordsHeaders(TeaModel):
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


class ListTodoWorkRecordsRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
        status: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.status is not None:
            result['status'] = self.status
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListTodoWorkRecordsResponseBodyResultListForms(TeaModel):
    def __init__(
        self,
        content: str = None,
        title: str = None,
    ):
        self.content = content
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class ListTodoWorkRecordsResponseBodyResultList(TeaModel):
    def __init__(
        self,
        forms: List[ListTodoWorkRecordsResponseBodyResultListForms] = None,
        instance_id: str = None,
        task_id: int = None,
        title: str = None,
        url: str = None,
    ):
        self.forms = forms
        self.instance_id = instance_id
        self.task_id = task_id
        self.title = title
        self.url = url

    def validate(self):
        if self.forms:
            for k in self.forms:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['forms'] = []
        if self.forms is not None:
            for k in self.forms:
                result['forms'].append(k.to_map() if k else None)
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.title is not None:
            result['title'] = self.title
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.forms = []
        if m.get('forms') is not None:
            for k in m.get('forms'):
                temp_model = ListTodoWorkRecordsResponseBodyResultListForms()
                self.forms.append(temp_model.from_map(k))
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class ListTodoWorkRecordsResponseBodyResult(TeaModel):
    def __init__(
        self,
        list: List[ListTodoWorkRecordsResponseBodyResultList] = None,
        next_token: int = None,
    ):
        self.list = list
        self.next_token = next_token

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
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListTodoWorkRecordsResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListTodoWorkRecordsResponseBody(TeaModel):
    def __init__(
        self,
        result: ListTodoWorkRecordsResponseBodyResult = None,
    ):
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
            temp_model = ListTodoWorkRecordsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class ListTodoWorkRecordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListTodoWorkRecordsResponseBody = None,
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
            temp_model = ListTodoWorkRecordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListUserVisibleBpmsProcessesHeaders(TeaModel):
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


class ListUserVisibleBpmsProcessesRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListUserVisibleBpmsProcessesResponseBodyResultProcessList(TeaModel):
    def __init__(
        self,
        dir_id: str = None,
        dir_name: str = None,
        icon_url: str = None,
        name: str = None,
        process_code: str = None,
        url: str = None,
    ):
        self.dir_id = dir_id
        self.dir_name = dir_name
        self.icon_url = icon_url
        self.name = name
        self.process_code = process_code
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dir_id is not None:
            result['dirId'] = self.dir_id
        if self.dir_name is not None:
            result['dirName'] = self.dir_name
        if self.icon_url is not None:
            result['iconUrl'] = self.icon_url
        if self.name is not None:
            result['name'] = self.name
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dirId') is not None:
            self.dir_id = m.get('dirId')
        if m.get('dirName') is not None:
            self.dir_name = m.get('dirName')
        if m.get('iconUrl') is not None:
            self.icon_url = m.get('iconUrl')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class ListUserVisibleBpmsProcessesResponseBodyResult(TeaModel):
    def __init__(
        self,
        next_token: int = None,
        process_list: List[ListUserVisibleBpmsProcessesResponseBodyResultProcessList] = None,
    ):
        self.next_token = next_token
        self.process_list = process_list

    def validate(self):
        if self.process_list:
            for k in self.process_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['processList'] = []
        if self.process_list is not None:
            for k in self.process_list:
                result['processList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.process_list = []
        if m.get('processList') is not None:
            for k in m.get('processList'):
                temp_model = ListUserVisibleBpmsProcessesResponseBodyResultProcessList()
                self.process_list.append(temp_model.from_map(k))
        return self


class ListUserVisibleBpmsProcessesResponseBody(TeaModel):
    def __init__(
        self,
        result: ListUserVisibleBpmsProcessesResponseBodyResult = None,
    ):
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
            temp_model = ListUserVisibleBpmsProcessesResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class ListUserVisibleBpmsProcessesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListUserVisibleBpmsProcessesResponseBody = None,
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
            temp_model = ListUserVisibleBpmsProcessesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PagesExportInstancesHeaders(TeaModel):
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


class PagesExportInstancesRequest(TeaModel):
    def __init__(
        self,
        end_time_in_mills: int = None,
        max_results: int = None,
        next_token: str = None,
        order_by: str = None,
        process_code: str = None,
        start_time_in_mills: int = None,
        status: str = None,
    ):
        self.end_time_in_mills = end_time_in_mills
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        self.order_by = order_by
        # This parameter is required.
        self.process_code = process_code
        # This parameter is required.
        self.start_time_in_mills = start_time_in_mills
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time_in_mills is not None:
            result['endTimeInMills'] = self.end_time_in_mills
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.order_by is not None:
            result['orderBy'] = self.order_by
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.start_time_in_mills is not None:
            result['startTimeInMills'] = self.start_time_in_mills
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTimeInMills') is not None:
            self.end_time_in_mills = m.get('endTimeInMills')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('orderBy') is not None:
            self.order_by = m.get('orderBy')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('startTimeInMills') is not None:
            self.start_time_in_mills = m.get('startTimeInMills')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class PagesExportInstancesResponseBodyResultListFormComponentValues(TeaModel):
    def __init__(
        self,
        component_name: str = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.component_name = component_name
        self.ext_value = ext_value
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_name is not None:
            result['componentName'] = self.component_name
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class PagesExportInstancesResponseBodyResultListOperationRecordsAttachments(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        file_size: str = None,
        file_type: str = None,
    ):
        self.file_id = file_id
        self.file_name = file_name
        self.file_size = file_size
        self.file_type = file_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.file_type is not None:
            result['fileType'] = self.file_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        return self


class PagesExportInstancesResponseBodyResultListOperationRecords(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        attachments: List[PagesExportInstancesResponseBodyResultListOperationRecordsAttachments] = None,
        images: List[str] = None,
        operation_type: str = None,
        remark: str = None,
        result: str = None,
        task_id: int = None,
        timestamp: int = None,
        user_id: str = None,
    ):
        self.activity_id = activity_id
        self.attachments = attachments
        self.images = images
        self.operation_type = operation_type
        self.remark = remark
        self.result = result
        self.task_id = task_id
        self.timestamp = timestamp
        self.user_id = user_id

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
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.images is not None:
            result['images'] = self.images
        if self.operation_type is not None:
            result['operationType'] = self.operation_type
        if self.remark is not None:
            result['remark'] = self.remark
        if self.result is not None:
            result['result'] = self.result
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = PagesExportInstancesResponseBodyResultListOperationRecordsAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('images') is not None:
            self.images = m.get('images')
        if m.get('operationType') is not None:
            self.operation_type = m.get('operationType')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PagesExportInstancesResponseBodyResultListTasks(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        create_timestamp: int = None,
        finish_timestamp: int = None,
        result: str = None,
        status: str = None,
        task_id: int = None,
        user_id: str = None,
    ):
        self.activity_id = activity_id
        self.create_timestamp = create_timestamp
        self.finish_timestamp = finish_timestamp
        self.result = result
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.task_id = task_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.create_timestamp is not None:
            result['createTimestamp'] = self.create_timestamp
        if self.finish_timestamp is not None:
            result['finishTimestamp'] = self.finish_timestamp
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('createTimestamp') is not None:
            self.create_timestamp = m.get('createTimestamp')
        if m.get('finishTimestamp') is not None:
            self.finish_timestamp = m.get('finishTimestamp')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PagesExportInstancesResponseBodyResultList(TeaModel):
    def __init__(
        self,
        attached_process_instance_ids: str = None,
        business_id: str = None,
        create_time: int = None,
        finish_time: int = None,
        form_component_values: List[PagesExportInstancesResponseBodyResultListFormComponentValues] = None,
        main_process_instance_id: str = None,
        operation_records: List[PagesExportInstancesResponseBodyResultListOperationRecords] = None,
        originator_dept_id: str = None,
        originator_userid: str = None,
        process_instance_id: str = None,
        result: str = None,
        status: str = None,
        tasks: List[PagesExportInstancesResponseBodyResultListTasks] = None,
        title: str = None,
    ):
        # This parameter is required.
        self.attached_process_instance_ids = attached_process_instance_ids
        # This parameter is required.
        self.business_id = business_id
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
        self.finish_time = finish_time
        # This parameter is required.
        self.form_component_values = form_component_values
        # This parameter is required.
        self.main_process_instance_id = main_process_instance_id
        self.operation_records = operation_records
        # This parameter is required.
        self.originator_dept_id = originator_dept_id
        # This parameter is required.
        self.originator_userid = originator_userid
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.result = result
        # This parameter is required.
        self.status = status
        self.tasks = tasks
        # This parameter is required.
        self.title = title

    def validate(self):
        if self.form_component_values:
            for k in self.form_component_values:
                if k:
                    k.validate()
        if self.operation_records:
            for k in self.operation_records:
                if k:
                    k.validate()
        if self.tasks:
            for k in self.tasks:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attached_process_instance_ids is not None:
            result['attachedProcessInstanceIds'] = self.attached_process_instance_ids
        if self.business_id is not None:
            result['businessId'] = self.business_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        result['formComponentValues'] = []
        if self.form_component_values is not None:
            for k in self.form_component_values:
                result['formComponentValues'].append(k.to_map() if k else None)
        if self.main_process_instance_id is not None:
            result['mainProcessInstanceId'] = self.main_process_instance_id
        result['operationRecords'] = []
        if self.operation_records is not None:
            for k in self.operation_records:
                result['operationRecords'].append(k.to_map() if k else None)
        if self.originator_dept_id is not None:
            result['originatorDeptId'] = self.originator_dept_id
        if self.originator_userid is not None:
            result['originatorUserid'] = self.originator_userid
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        result['tasks'] = []
        if self.tasks is not None:
            for k in self.tasks:
                result['tasks'].append(k.to_map() if k else None)
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attachedProcessInstanceIds') is not None:
            self.attached_process_instance_ids = m.get('attachedProcessInstanceIds')
        if m.get('businessId') is not None:
            self.business_id = m.get('businessId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        self.form_component_values = []
        if m.get('formComponentValues') is not None:
            for k in m.get('formComponentValues'):
                temp_model = PagesExportInstancesResponseBodyResultListFormComponentValues()
                self.form_component_values.append(temp_model.from_map(k))
        if m.get('mainProcessInstanceId') is not None:
            self.main_process_instance_id = m.get('mainProcessInstanceId')
        self.operation_records = []
        if m.get('operationRecords') is not None:
            for k in m.get('operationRecords'):
                temp_model = PagesExportInstancesResponseBodyResultListOperationRecords()
                self.operation_records.append(temp_model.from_map(k))
        if m.get('originatorDeptId') is not None:
            self.originator_dept_id = m.get('originatorDeptId')
        if m.get('originatorUserid') is not None:
            self.originator_userid = m.get('originatorUserid')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        self.tasks = []
        if m.get('tasks') is not None:
            for k in m.get('tasks'):
                temp_model = PagesExportInstancesResponseBodyResultListTasks()
                self.tasks.append(temp_model.from_map(k))
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class PagesExportInstancesResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[PagesExportInstancesResponseBodyResultList] = None,
        next_token: str = None,
    ):
        # This parameter is required.
        self.has_more = has_more
        self.list = list
        # This parameter is required.
        self.next_token = next_token

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = PagesExportInstancesResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class PagesExportInstancesResponseBody(TeaModel):
    def __init__(
        self,
        result: PagesExportInstancesResponseBodyResult = None,
    ):
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
            temp_model = PagesExportInstancesResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class PagesExportInstancesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PagesExportInstancesResponseBody = None,
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
            temp_model = PagesExportInstancesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumAddApproveDentryAuthHeaders(TeaModel):
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


class PremiumAddApproveDentryAuthRequestFileInfos(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        space_id: int = None,
    ):
        # This parameter is required.
        self.file_id = file_id
        # This parameter is required.
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class PremiumAddApproveDentryAuthRequest(TeaModel):
    def __init__(
        self,
        file_infos: List[PremiumAddApproveDentryAuthRequestFileInfos] = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.file_infos = file_infos
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        if self.file_infos:
            for k in self.file_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['fileInfos'] = []
        if self.file_infos is not None:
            for k in self.file_infos:
                result['fileInfos'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.file_infos = []
        if m.get('fileInfos') is not None:
            for k in m.get('fileInfos'):
                temp_model = PremiumAddApproveDentryAuthRequestFileInfos()
                self.file_infos.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PremiumAddApproveDentryAuthResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PremiumAddApproveDentryAuthResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumAddApproveDentryAuthResponseBody = None,
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
            temp_model = PremiumAddApproveDentryAuthResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumBatchExecuteProcessInstancesHeaders(TeaModel):
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


class PremiumBatchExecuteProcessInstancesRequestTaskInfoList(TeaModel):
    def __init__(
        self,
        process_instance_id: str = None,
        task_id: int = None,
    ):
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class PremiumBatchExecuteProcessInstancesRequest(TeaModel):
    def __init__(
        self,
        actioner_user_id: str = None,
        remark: str = None,
        result: str = None,
        task_info_list: List[PremiumBatchExecuteProcessInstancesRequestTaskInfoList] = None,
    ):
        # This parameter is required.
        self.actioner_user_id = actioner_user_id
        self.remark = remark
        # This parameter is required.
        self.result = result
        # This parameter is required.
        self.task_info_list = task_info_list

    def validate(self):
        if self.task_info_list:
            for k in self.task_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actioner_user_id is not None:
            result['actionerUserId'] = self.actioner_user_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.result is not None:
            result['result'] = self.result
        result['taskInfoList'] = []
        if self.task_info_list is not None:
            for k in self.task_info_list:
                result['taskInfoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionerUserId') is not None:
            self.actioner_user_id = m.get('actionerUserId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('result') is not None:
            self.result = m.get('result')
        self.task_info_list = []
        if m.get('taskInfoList') is not None:
            for k in m.get('taskInfoList'):
                temp_model = PremiumBatchExecuteProcessInstancesRequestTaskInfoList()
                self.task_info_list.append(temp_model.from_map(k))
        return self


class PremiumBatchExecuteProcessInstancesResponseBody(TeaModel):
    def __init__(
        self,
        result: Dict[str, ResultValue] = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            for v in self.result.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['result'] = {}
        if self.result is not None:
            for k, v in self.result.items():
                result['result'][k] = v.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = {}
        if m.get('result') is not None:
            for k, v in m.get('result').items():
                temp_model = ResultValue()
                self.result[k] = temp_model.from_map(v)
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PremiumBatchExecuteProcessInstancesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumBatchExecuteProcessInstancesResponseBody = None,
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
            temp_model = PremiumBatchExecuteProcessInstancesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumDelDirHeaders(TeaModel):
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


class PremiumDelDirRequest(TeaModel):
    def __init__(
        self,
        dir_id: str = None,
        operate_user_id: str = None,
    ):
        self.dir_id = dir_id
        # This parameter is required.
        self.operate_user_id = operate_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dir_id is not None:
            result['dirId'] = self.dir_id
        if self.operate_user_id is not None:
            result['operateUserId'] = self.operate_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dirId') is not None:
            self.dir_id = m.get('dirId')
        if m.get('operateUserId') is not None:
            self.operate_user_id = m.get('operateUserId')
        return self


class PremiumDelDirResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
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


class PremiumDelDirResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumDelDirResponseBody = None,
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
            temp_model = PremiumDelDirResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumDeleteFormInstanceHeaders(TeaModel):
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


class PremiumDeleteFormInstanceRequest(TeaModel):
    def __init__(
        self,
        form_instance_ids: List[str] = None,
        process_code: str = None,
        user_id: str = None,
    ):
        self.form_instance_ids = form_instance_ids
        # This parameter is required.
        self.process_code = process_code
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_instance_ids is not None:
            result['formInstanceIds'] = self.form_instance_ids
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formInstanceIds') is not None:
            self.form_instance_ids = m.get('formInstanceIds')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PremiumDeleteFormInstanceResponseBody(TeaModel):
    def __init__(
        self,
        success: str = None,
    ):
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


class PremiumDeleteFormInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumDeleteFormInstanceResponseBody = None,
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
            temp_model = PremiumDeleteFormInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumGetAttachmentSpaceHeaders(TeaModel):
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


class PremiumGetAttachmentSpaceRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        user_id: str = None,
    ):
        self.agent_id = agent_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PremiumGetAttachmentSpaceResponseBodyResult(TeaModel):
    def __init__(
        self,
        space_id: int = None,
    ):
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class PremiumGetAttachmentSpaceResponseBody(TeaModel):
    def __init__(
        self,
        result: PremiumGetAttachmentSpaceResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = PremiumGetAttachmentSpaceResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PremiumGetAttachmentSpaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumGetAttachmentSpaceResponseBody = None,
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
            temp_model = PremiumGetAttachmentSpaceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumGetDoneTasksHeaders(TeaModel):
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


class PremiumGetDoneTasksRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PremiumGetDoneTasksResponseBodyResultList(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        form_massage: str = None,
        originator_id: str = None,
        originator_name: str = None,
        originator_photo: str = None,
        process_create_time: str = None,
        process_end_time: str = None,
        process_instance_id: str = None,
        process_type: int = None,
        result: str = None,
        status: str = None,
        task_id: str = None,
        title: str = None,
        url: str = None,
    ):
        self.activity_id = activity_id
        self.form_massage = form_massage
        self.originator_id = originator_id
        self.originator_name = originator_name
        self.originator_photo = originator_photo
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.process_create_time = process_create_time
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.process_end_time = process_end_time
        self.process_instance_id = process_instance_id
        self.process_type = process_type
        self.result = result
        self.status = status
        self.task_id = task_id
        self.title = title
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.form_massage is not None:
            result['formMassage'] = self.form_massage
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.originator_name is not None:
            result['originatorName'] = self.originator_name
        if self.originator_photo is not None:
            result['originatorPhoto'] = self.originator_photo
        if self.process_create_time is not None:
            result['processCreateTime'] = self.process_create_time
        if self.process_end_time is not None:
            result['processEndTime'] = self.process_end_time
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.process_type is not None:
            result['processType'] = self.process_type
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.title is not None:
            result['title'] = self.title
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('formMassage') is not None:
            self.form_massage = m.get('formMassage')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('originatorName') is not None:
            self.originator_name = m.get('originatorName')
        if m.get('originatorPhoto') is not None:
            self.originator_photo = m.get('originatorPhoto')
        if m.get('processCreateTime') is not None:
            self.process_create_time = m.get('processCreateTime')
        if m.get('processEndTime') is not None:
            self.process_end_time = m.get('processEndTime')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('processType') is not None:
            self.process_type = m.get('processType')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class PremiumGetDoneTasksResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[PremiumGetDoneTasksResponseBodyResultList] = None,
    ):
        self.has_more = has_more
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = PremiumGetDoneTasksResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        return self


class PremiumGetDoneTasksResponseBody(TeaModel):
    def __init__(
        self,
        result: PremiumGetDoneTasksResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = PremiumGetDoneTasksResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PremiumGetDoneTasksResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumGetDoneTasksResponseBody = None,
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
            temp_model = PremiumGetDoneTasksResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumGetFieldModifiedHistoryHeaders(TeaModel):
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


class PremiumGetFieldModifiedHistoryRequest(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        process_instance_id: str = None,
    ):
        # This parameter is required.
        self.field_id = field_id
        # This parameter is required.
        self.process_instance_id = process_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        return self


class PremiumGetFieldModifiedHistoryResponseBodyResult(TeaModel):
    def __init__(
        self,
        create_time: str = None,
        field_id: str = None,
        name: str = None,
        user_id: str = None,
        value: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        self.field_id = field_id
        self.name = name
        self.user_id = user_id
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class PremiumGetFieldModifiedHistoryResponseBody(TeaModel):
    def __init__(
        self,
        result: List[PremiumGetFieldModifiedHistoryResponseBodyResult] = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = PremiumGetFieldModifiedHistoryResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PremiumGetFieldModifiedHistoryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumGetFieldModifiedHistoryResponseBody = None,
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
            temp_model = PremiumGetFieldModifiedHistoryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumGetFormInstanceHeaders(TeaModel):
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


class PremiumGetFormInstanceRequest(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        form_code: str = None,
        form_instance_id: str = None,
    ):
        self.app_uuid = app_uuid
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.form_instance_id = form_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        return self


class PremiumGetFormInstanceResponseBodyFormInstDataList(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        component_type: str = None,
        extend_value: str = None,
        key: str = None,
        label: str = None,
        value: str = None,
    ):
        # This parameter is required.
        self.biz_alias = biz_alias
        # This parameter is required.
        self.component_type = component_type
        # This parameter is required.
        self.extend_value = extend_value
        # This parameter is required.
        self.key = key
        # This parameter is required.
        self.label = label
        # This parameter is required.
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.extend_value is not None:
            result['extendValue'] = self.extend_value
        if self.key is not None:
            result['key'] = self.key
        if self.label is not None:
            result['label'] = self.label
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('extendValue') is not None:
            self.extend_value = m.get('extendValue')
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class PremiumGetFormInstanceResponseBody(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        attributes: Dict[str, Any] = None,
        create_timestamp: int = None,
        creator: str = None,
        form_code: str = None,
        form_inst_data_list: List[PremiumGetFormInstanceResponseBodyFormInstDataList] = None,
        form_instance_id: str = None,
        modifier: str = None,
        modify_timestamp: int = None,
        out_biz_code: str = None,
        out_instance_id: str = None,
        title: str = None,
    ):
        self.app_uuid = app_uuid
        self.attributes = attributes
        self.create_timestamp = create_timestamp
        # This parameter is required.
        self.creator = creator
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.form_inst_data_list = form_inst_data_list
        # This parameter is required.
        self.form_instance_id = form_instance_id
        self.modifier = modifier
        self.modify_timestamp = modify_timestamp
        self.out_biz_code = out_biz_code
        self.out_instance_id = out_instance_id
        self.title = title

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
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.attributes is not None:
            result['attributes'] = self.attributes
        if self.create_timestamp is not None:
            result['createTimestamp'] = self.create_timestamp
        if self.creator is not None:
            result['creator'] = self.creator
        if self.form_code is not None:
            result['formCode'] = self.form_code
        result['formInstDataList'] = []
        if self.form_inst_data_list is not None:
            for k in self.form_inst_data_list:
                result['formInstDataList'].append(k.to_map() if k else None)
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.modifier is not None:
            result['modifier'] = self.modifier
        if self.modify_timestamp is not None:
            result['modifyTimestamp'] = self.modify_timestamp
        if self.out_biz_code is not None:
            result['outBizCode'] = self.out_biz_code
        if self.out_instance_id is not None:
            result['outInstanceId'] = self.out_instance_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('attributes') is not None:
            self.attributes = m.get('attributes')
        if m.get('createTimestamp') is not None:
            self.create_timestamp = m.get('createTimestamp')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        self.form_inst_data_list = []
        if m.get('formInstDataList') is not None:
            for k in m.get('formInstDataList'):
                temp_model = PremiumGetFormInstanceResponseBodyFormInstDataList()
                self.form_inst_data_list.append(temp_model.from_map(k))
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('modifier') is not None:
            self.modifier = m.get('modifier')
        if m.get('modifyTimestamp') is not None:
            self.modify_timestamp = m.get('modifyTimestamp')
        if m.get('outBizCode') is not None:
            self.out_biz_code = m.get('outBizCode')
        if m.get('outInstanceId') is not None:
            self.out_instance_id = m.get('outInstanceId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class PremiumGetFormInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumGetFormInstanceResponseBody = None,
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
            temp_model = PremiumGetFormInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumGetFormInstancesHeaders(TeaModel):
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


class PremiumGetFormInstancesRequest(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        form_code: str = None,
        max_results: int = None,
        next_token: str = None,
    ):
        self.app_uuid = app_uuid
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.max_results = max_results
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        component_type: str = None,
        extend_value: str = None,
        key: str = None,
        label: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        # This parameter is required.
        self.component_type = component_type
        self.extend_value = extend_value
        # This parameter is required.
        self.key = key
        # This parameter is required.
        self.label = label
        # This parameter is required.
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.extend_value is not None:
            result['extendValue'] = self.extend_value
        if self.key is not None:
            result['key'] = self.key
        if self.label is not None:
            result['label'] = self.label
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('extendValue') is not None:
            self.extend_value = m.get('extendValue')
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class PremiumGetFormInstancesResponseBodyResultValues(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        attributes: Dict[str, Any] = None,
        create_timestamp: int = None,
        creator: str = None,
        form_code: str = None,
        form_inst_data_list: List[PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList] = None,
        form_instance_id: str = None,
        modifier: str = None,
        modify_timestamp: int = None,
        out_biz_code: str = None,
        out_instance_id: str = None,
        title: str = None,
    ):
        self.app_uuid = app_uuid
        self.attributes = attributes
        # This parameter is required.
        self.create_timestamp = create_timestamp
        # This parameter is required.
        self.creator = creator
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.form_inst_data_list = form_inst_data_list
        # This parameter is required.
        self.form_instance_id = form_instance_id
        # This parameter is required.
        self.modifier = modifier
        self.modify_timestamp = modify_timestamp
        self.out_biz_code = out_biz_code
        self.out_instance_id = out_instance_id
        # This parameter is required.
        self.title = title

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
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.attributes is not None:
            result['attributes'] = self.attributes
        if self.create_timestamp is not None:
            result['createTimestamp'] = self.create_timestamp
        if self.creator is not None:
            result['creator'] = self.creator
        if self.form_code is not None:
            result['formCode'] = self.form_code
        result['formInstDataList'] = []
        if self.form_inst_data_list is not None:
            for k in self.form_inst_data_list:
                result['formInstDataList'].append(k.to_map() if k else None)
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.modifier is not None:
            result['modifier'] = self.modifier
        if self.modify_timestamp is not None:
            result['modifyTimestamp'] = self.modify_timestamp
        if self.out_biz_code is not None:
            result['outBizCode'] = self.out_biz_code
        if self.out_instance_id is not None:
            result['outInstanceId'] = self.out_instance_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('attributes') is not None:
            self.attributes = m.get('attributes')
        if m.get('createTimestamp') is not None:
            self.create_timestamp = m.get('createTimestamp')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        self.form_inst_data_list = []
        if m.get('formInstDataList') is not None:
            for k in m.get('formInstDataList'):
                temp_model = PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList()
                self.form_inst_data_list.append(temp_model.from_map(k))
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('modifier') is not None:
            self.modifier = m.get('modifier')
        if m.get('modifyTimestamp') is not None:
            self.modify_timestamp = m.get('modifyTimestamp')
        if m.get('outBizCode') is not None:
            self.out_biz_code = m.get('outBizCode')
        if m.get('outInstanceId') is not None:
            self.out_instance_id = m.get('outInstanceId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class PremiumGetFormInstancesResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        max_results: int = None,
        next_token: str = None,
        values: List[PremiumGetFormInstancesResponseBodyResultValues] = None,
    ):
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        # This parameter is required.
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['values'] = []
        if self.values is not None:
            for k in self.values:
                result['values'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.values = []
        if m.get('values') is not None:
            for k in m.get('values'):
                temp_model = PremiumGetFormInstancesResponseBodyResultValues()
                self.values.append(temp_model.from_map(k))
        return self


class PremiumGetFormInstancesResponseBody(TeaModel):
    def __init__(
        self,
        result: PremiumGetFormInstancesResponseBodyResult = None,
    ):
        # This parameter is required.
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
            temp_model = PremiumGetFormInstancesResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class PremiumGetFormInstancesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumGetFormInstancesResponseBody = None,
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
            temp_model = PremiumGetFormInstancesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumGetFormSchemaHeaders(TeaModel):
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


class PremiumGetFormSchemaRequest(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        process_code: str = None,
    ):
        self.app_uuid = app_uuid
        # This parameter is required.
        self.process_code = process_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        id: str = None,
        label: str = None,
        options: List[str] = None,
        required: bool = None,
    ):
        self.biz_alias = biz_alias
        # This parameter is required.
        self.id = id
        self.label = label
        self.options = options
        self.required = required

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.id is not None:
            result['id'] = self.id
        if self.label is not None:
            result['label'] = self.label
        if self.options is not None:
            result['options'] = self.options
        if self.required is not None:
            result['required'] = self.required
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('options') is not None:
            self.options = m.get('options')
        if m.get('required') is not None:
            self.required = m.get('required')
        return self


class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildren(TeaModel):
    def __init__(
        self,
        component_name: str = None,
        props: PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps = None,
    ):
        # This parameter is required.
        self.component_name = component_name
        # This parameter is required.
        self.props = props

    def validate(self):
        if self.props:
            self.props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_name is not None:
            result['componentName'] = self.component_name
        if self.props is not None:
            result['props'] = self.props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        if m.get('props') is not None:
            temp_model = PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps()
            self.props = temp_model.from_map(m['props'])
        return self


class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets(TeaModel):
    def __init__(
        self,
        behavior: str = None,
        field_id: str = None,
    ):
        self.behavior = behavior
        self.field_id = field_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.behavior is not None:
            result['behavior'] = self.behavior
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('behavior') is not None:
            self.behavior = m.get('behavior')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        return self


class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkage(TeaModel):
    def __init__(
        self,
        targets: List[PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets] = None,
        value: str = None,
    ):
        self.targets = targets
        self.value = value

    def validate(self):
        if self.targets:
            for k in self.targets:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['targets'] = []
        if self.targets is not None:
            for k in self.targets:
                result['targets'].append(k.to_map() if k else None)
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.targets = []
        if m.get('targets') is not None:
            for k in m.get('targets'):
                temp_model = PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets()
                self.targets.append(temp_model.from_map(k))
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsObjOptions(TeaModel):
    def __init__(
        self,
        value: str = None,
    ):
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsPush(TeaModel):
    def __init__(
        self,
        attendance_rule: int = None,
        push_switch: int = None,
        push_tag: str = None,
    ):
        self.attendance_rule = attendance_rule
        self.push_switch = push_switch
        self.push_tag = push_tag

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attendance_rule is not None:
            result['attendanceRule'] = self.attendance_rule
        if self.push_switch is not None:
            result['pushSwitch'] = self.push_switch
        if self.push_tag is not None:
            result['pushTag'] = self.push_tag
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attendanceRule') is not None:
            self.attendance_rule = m.get('attendanceRule')
        if m.get('pushSwitch') is not None:
            self.push_switch = m.get('pushSwitch')
        if m.get('pushTag') is not None:
            self.push_tag = m.get('pushTag')
        return self


class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsStatField(TeaModel):
    def __init__(
        self,
        id: str = None,
        label: str = None,
        unit: str = None,
        upper: bool = None,
    ):
        self.id = id
        self.label = label
        self.unit = unit
        self.upper = upper

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.label is not None:
            result['label'] = self.label
        if self.unit is not None:
            result['unit'] = self.unit
        if self.upper is not None:
            result['upper'] = self.upper
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        return self


class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps(TeaModel):
    def __init__(
        self,
        action_name: str = None,
        align: str = None,
        app_id: int = None,
        async_condition: bool = None,
        attend_type_label: str = None,
        behavior_linkage: List[PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkage] = None,
        biz_alias: str = None,
        biz_type: str = None,
        child_field_visible: Dict[str, bool] = None,
        choice: int = None,
        common_biz_type: str = None,
        disabled: bool = None,
        duration: bool = None,
        duration_label: str = None,
        e_sign: bool = None,
        extract: bool = None,
        fields_info: str = None,
        format: str = None,
        formula: str = None,
        hidden: bool = None,
        hidden_in_approval_detail: bool = None,
        hide_label: bool = None,
        holiday_options: List[Dict[str, str]] = None,
        id: str = None,
        label: str = None,
        label_editable_freeze: bool = None,
        link: str = None,
        main_title: str = None,
        not_print: str = None,
        not_upper: str = None,
        obj_options: List[PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsObjOptions] = None,
        options: List[str] = None,
        pay_enable: bool = None,
        placeholder: str = None,
        push: PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsPush = None,
        push_to_attendance: bool = None,
        push_to_calendar: int = None,
        required: bool = None,
        required_editable_freeze: bool = None,
        show_attend_options: bool = None,
        staff_status_enabled: bool = None,
        stat_field: List[PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsStatField] = None,
        table_view_mode: str = None,
        unit: str = None,
        use_calendar: bool = None,
        vertical_print: bool = None,
    ):
        self.action_name = action_name
        self.align = align
        self.app_id = app_id
        self.async_condition = async_condition
        self.attend_type_label = attend_type_label
        self.behavior_linkage = behavior_linkage
        self.biz_alias = biz_alias
        self.biz_type = biz_type
        self.child_field_visible = child_field_visible
        self.choice = choice
        self.common_biz_type = common_biz_type
        self.disabled = disabled
        self.duration = duration
        self.duration_label = duration_label
        self.e_sign = e_sign
        self.extract = extract
        self.fields_info = fields_info
        self.format = format
        self.formula = formula
        self.hidden = hidden
        self.hidden_in_approval_detail = hidden_in_approval_detail
        self.hide_label = hide_label
        self.holiday_options = holiday_options
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.label = label
        self.label_editable_freeze = label_editable_freeze
        self.link = link
        self.main_title = main_title
        self.not_print = not_print
        self.not_upper = not_upper
        self.obj_options = obj_options
        self.options = options
        self.pay_enable = pay_enable
        self.placeholder = placeholder
        self.push = push
        self.push_to_attendance = push_to_attendance
        self.push_to_calendar = push_to_calendar
        self.required = required
        self.required_editable_freeze = required_editable_freeze
        self.show_attend_options = show_attend_options
        self.staff_status_enabled = staff_status_enabled
        self.stat_field = stat_field
        self.table_view_mode = table_view_mode
        self.unit = unit
        self.use_calendar = use_calendar
        self.vertical_print = vertical_print

    def validate(self):
        if self.behavior_linkage:
            for k in self.behavior_linkage:
                if k:
                    k.validate()
        if self.obj_options:
            for k in self.obj_options:
                if k:
                    k.validate()
        if self.push:
            self.push.validate()
        if self.stat_field:
            for k in self.stat_field:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_name is not None:
            result['actionName'] = self.action_name
        if self.align is not None:
            result['align'] = self.align
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.async_condition is not None:
            result['asyncCondition'] = self.async_condition
        if self.attend_type_label is not None:
            result['attendTypeLabel'] = self.attend_type_label
        result['behaviorLinkage'] = []
        if self.behavior_linkage is not None:
            for k in self.behavior_linkage:
                result['behaviorLinkage'].append(k.to_map() if k else None)
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.child_field_visible is not None:
            result['childFieldVisible'] = self.child_field_visible
        if self.choice is not None:
            result['choice'] = self.choice
        if self.common_biz_type is not None:
            result['commonBizType'] = self.common_biz_type
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.duration is not None:
            result['duration'] = self.duration
        if self.duration_label is not None:
            result['durationLabel'] = self.duration_label
        if self.e_sign is not None:
            result['eSign'] = self.e_sign
        if self.extract is not None:
            result['extract'] = self.extract
        if self.fields_info is not None:
            result['fieldsInfo'] = self.fields_info
        if self.format is not None:
            result['format'] = self.format
        if self.formula is not None:
            result['formula'] = self.formula
        if self.hidden is not None:
            result['hidden'] = self.hidden
        if self.hidden_in_approval_detail is not None:
            result['hiddenInApprovalDetail'] = self.hidden_in_approval_detail
        if self.hide_label is not None:
            result['hideLabel'] = self.hide_label
        if self.holiday_options is not None:
            result['holidayOptions'] = self.holiday_options
        if self.id is not None:
            result['id'] = self.id
        if self.label is not None:
            result['label'] = self.label
        if self.label_editable_freeze is not None:
            result['labelEditableFreeze'] = self.label_editable_freeze
        if self.link is not None:
            result['link'] = self.link
        if self.main_title is not None:
            result['mainTitle'] = self.main_title
        if self.not_print is not None:
            result['notPrint'] = self.not_print
        if self.not_upper is not None:
            result['notUpper'] = self.not_upper
        result['objOptions'] = []
        if self.obj_options is not None:
            for k in self.obj_options:
                result['objOptions'].append(k.to_map() if k else None)
        if self.options is not None:
            result['options'] = self.options
        if self.pay_enable is not None:
            result['payEnable'] = self.pay_enable
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.push is not None:
            result['push'] = self.push.to_map()
        if self.push_to_attendance is not None:
            result['pushToAttendance'] = self.push_to_attendance
        if self.push_to_calendar is not None:
            result['pushToCalendar'] = self.push_to_calendar
        if self.required is not None:
            result['required'] = self.required
        if self.required_editable_freeze is not None:
            result['requiredEditableFreeze'] = self.required_editable_freeze
        if self.show_attend_options is not None:
            result['showAttendOptions'] = self.show_attend_options
        if self.staff_status_enabled is not None:
            result['staffStatusEnabled'] = self.staff_status_enabled
        result['statField'] = []
        if self.stat_field is not None:
            for k in self.stat_field:
                result['statField'].append(k.to_map() if k else None)
        if self.table_view_mode is not None:
            result['tableViewMode'] = self.table_view_mode
        if self.unit is not None:
            result['unit'] = self.unit
        if self.use_calendar is not None:
            result['useCalendar'] = self.use_calendar
        if self.vertical_print is not None:
            result['verticalPrint'] = self.vertical_print
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionName') is not None:
            self.action_name = m.get('actionName')
        if m.get('align') is not None:
            self.align = m.get('align')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('asyncCondition') is not None:
            self.async_condition = m.get('asyncCondition')
        if m.get('attendTypeLabel') is not None:
            self.attend_type_label = m.get('attendTypeLabel')
        self.behavior_linkage = []
        if m.get('behaviorLinkage') is not None:
            for k in m.get('behaviorLinkage'):
                temp_model = PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkage()
                self.behavior_linkage.append(temp_model.from_map(k))
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('childFieldVisible') is not None:
            self.child_field_visible = m.get('childFieldVisible')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('commonBizType') is not None:
            self.common_biz_type = m.get('commonBizType')
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('durationLabel') is not None:
            self.duration_label = m.get('durationLabel')
        if m.get('eSign') is not None:
            self.e_sign = m.get('eSign')
        if m.get('extract') is not None:
            self.extract = m.get('extract')
        if m.get('fieldsInfo') is not None:
            self.fields_info = m.get('fieldsInfo')
        if m.get('format') is not None:
            self.format = m.get('format')
        if m.get('formula') is not None:
            self.formula = m.get('formula')
        if m.get('hidden') is not None:
            self.hidden = m.get('hidden')
        if m.get('hiddenInApprovalDetail') is not None:
            self.hidden_in_approval_detail = m.get('hiddenInApprovalDetail')
        if m.get('hideLabel') is not None:
            self.hide_label = m.get('hideLabel')
        if m.get('holidayOptions') is not None:
            self.holiday_options = m.get('holidayOptions')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('labelEditableFreeze') is not None:
            self.label_editable_freeze = m.get('labelEditableFreeze')
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('mainTitle') is not None:
            self.main_title = m.get('mainTitle')
        if m.get('notPrint') is not None:
            self.not_print = m.get('notPrint')
        if m.get('notUpper') is not None:
            self.not_upper = m.get('notUpper')
        self.obj_options = []
        if m.get('objOptions') is not None:
            for k in m.get('objOptions'):
                temp_model = PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsObjOptions()
                self.obj_options.append(temp_model.from_map(k))
        if m.get('options') is not None:
            self.options = m.get('options')
        if m.get('payEnable') is not None:
            self.pay_enable = m.get('payEnable')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('push') is not None:
            temp_model = PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsPush()
            self.push = temp_model.from_map(m['push'])
        if m.get('pushToAttendance') is not None:
            self.push_to_attendance = m.get('pushToAttendance')
        if m.get('pushToCalendar') is not None:
            self.push_to_calendar = m.get('pushToCalendar')
        if m.get('required') is not None:
            self.required = m.get('required')
        if m.get('requiredEditableFreeze') is not None:
            self.required_editable_freeze = m.get('requiredEditableFreeze')
        if m.get('showAttendOptions') is not None:
            self.show_attend_options = m.get('showAttendOptions')
        if m.get('staffStatusEnabled') is not None:
            self.staff_status_enabled = m.get('staffStatusEnabled')
        self.stat_field = []
        if m.get('statField') is not None:
            for k in m.get('statField'):
                temp_model = PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsStatField()
                self.stat_field.append(temp_model.from_map(k))
        if m.get('tableViewMode') is not None:
            self.table_view_mode = m.get('tableViewMode')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('useCalendar') is not None:
            self.use_calendar = m.get('useCalendar')
        if m.get('verticalPrint') is not None:
            self.vertical_print = m.get('verticalPrint')
        return self


class PremiumGetFormSchemaResponseBodyResultSchemaContentItems(TeaModel):
    def __init__(
        self,
        children: List[PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildren] = None,
        component_name: str = None,
        props: PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps = None,
    ):
        self.children = children
        # This parameter is required.
        self.component_name = component_name
        # This parameter is required.
        self.props = props

    def validate(self):
        if self.children:
            for k in self.children:
                if k:
                    k.validate()
        if self.props:
            self.props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['children'] = []
        if self.children is not None:
            for k in self.children:
                result['children'].append(k.to_map() if k else None)
        if self.component_name is not None:
            result['componentName'] = self.component_name
        if self.props is not None:
            result['props'] = self.props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.children = []
        if m.get('children') is not None:
            for k in m.get('children'):
                temp_model = PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildren()
                self.children.append(temp_model.from_map(k))
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        if m.get('props') is not None:
            temp_model = PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps()
            self.props = temp_model.from_map(m['props'])
        return self


class PremiumGetFormSchemaResponseBodyResultSchemaContent(TeaModel):
    def __init__(
        self,
        icon: str = None,
        items: List[PremiumGetFormSchemaResponseBodyResultSchemaContentItems] = None,
        title: str = None,
    ):
        self.icon = icon
        # This parameter is required.
        self.items = items
        # This parameter is required.
        self.title = title

    def validate(self):
        if self.items:
            for k in self.items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = PremiumGetFormSchemaResponseBodyResultSchemaContentItems()
                self.items.append(temp_model.from_map(k))
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class PremiumGetFormSchemaResponseBodyResult(TeaModel):
    def __init__(
        self,
        app_type: int = None,
        creator_user_id: str = None,
        form_code: str = None,
        gmt_create: str = None,
        gmt_modified: str = None,
        icon: str = None,
        memo: str = None,
        name: str = None,
        schema_content: PremiumGetFormSchemaResponseBodyResultSchemaContent = None,
        status: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.creator_user_id = creator_user_id
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.gmt_create = gmt_create
        # This parameter is required.
        self.gmt_modified = gmt_modified
        self.icon = icon
        self.memo = memo
        self.name = name
        # This parameter is required.
        self.schema_content = schema_content
        self.status = status

    def validate(self):
        if self.schema_content:
            self.schema_content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.icon is not None:
            result['icon'] = self.icon
        if self.memo is not None:
            result['memo'] = self.memo
        if self.name is not None:
            result['name'] = self.name
        if self.schema_content is not None:
            result['schemaContent'] = self.schema_content.to_map()
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('schemaContent') is not None:
            temp_model = PremiumGetFormSchemaResponseBodyResultSchemaContent()
            self.schema_content = temp_model.from_map(m['schemaContent'])
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class PremiumGetFormSchemaResponseBody(TeaModel):
    def __init__(
        self,
        result: PremiumGetFormSchemaResponseBodyResult = None,
    ):
        # This parameter is required.
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
            temp_model = PremiumGetFormSchemaResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class PremiumGetFormSchemaResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumGetFormSchemaResponseBody = None,
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
            temp_model = PremiumGetFormSchemaResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumGetNoticedInstancesHeaders(TeaModel):
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


class PremiumGetNoticedInstancesRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PremiumGetNoticedInstancesResponseBodyResultList(TeaModel):
    def __init__(
        self,
        form_massage: str = None,
        originator_id: str = None,
        originator_name: str = None,
        originator_photo: str = None,
        process_create_time: str = None,
        process_end_time: str = None,
        process_instance_id: str = None,
        process_type: int = None,
        result: str = None,
        status: str = None,
        title: str = None,
        url: str = None,
    ):
        self.form_massage = form_massage
        self.originator_id = originator_id
        self.originator_name = originator_name
        self.originator_photo = originator_photo
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.process_create_time = process_create_time
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.process_end_time = process_end_time
        self.process_instance_id = process_instance_id
        self.process_type = process_type
        self.result = result
        self.status = status
        self.title = title
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_massage is not None:
            result['formMassage'] = self.form_massage
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.originator_name is not None:
            result['originatorName'] = self.originator_name
        if self.originator_photo is not None:
            result['originatorPhoto'] = self.originator_photo
        if self.process_create_time is not None:
            result['processCreateTime'] = self.process_create_time
        if self.process_end_time is not None:
            result['processEndTime'] = self.process_end_time
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.process_type is not None:
            result['processType'] = self.process_type
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        if self.title is not None:
            result['title'] = self.title
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formMassage') is not None:
            self.form_massage = m.get('formMassage')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('originatorName') is not None:
            self.originator_name = m.get('originatorName')
        if m.get('originatorPhoto') is not None:
            self.originator_photo = m.get('originatorPhoto')
        if m.get('processCreateTime') is not None:
            self.process_create_time = m.get('processCreateTime')
        if m.get('processEndTime') is not None:
            self.process_end_time = m.get('processEndTime')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('processType') is not None:
            self.process_type = m.get('processType')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class PremiumGetNoticedInstancesResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[PremiumGetNoticedInstancesResponseBodyResultList] = None,
    ):
        self.has_more = has_more
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = PremiumGetNoticedInstancesResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        return self


class PremiumGetNoticedInstancesResponseBody(TeaModel):
    def __init__(
        self,
        result: PremiumGetNoticedInstancesResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = PremiumGetNoticedInstancesResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PremiumGetNoticedInstancesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumGetNoticedInstancesResponseBody = None,
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
            temp_model = PremiumGetNoticedInstancesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumGetProcessInstancesHeaders(TeaModel):
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


class PremiumGetProcessInstancesRequest(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        end_time_in_mills: int = None,
        max_results: int = None,
        next_token: str = None,
        process_code: str = None,
        start_time_in_mills: int = None,
    ):
        self.app_uuid = app_uuid
        self.end_time_in_mills = end_time_in_mills
        # This parameter is required.
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.process_code = process_code
        # This parameter is required.
        self.start_time_in_mills = start_time_in_mills

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.end_time_in_mills is not None:
            result['endTimeInMills'] = self.end_time_in_mills
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.start_time_in_mills is not None:
            result['startTimeInMills'] = self.start_time_in_mills
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('endTimeInMills') is not None:
            self.end_time_in_mills = m.get('endTimeInMills')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('startTimeInMills') is not None:
            self.start_time_in_mills = m.get('startTimeInMills')
        return self


class PremiumGetProcessInstancesResponseBodyResultListFormComponentValues(TeaModel):
    def __init__(
        self,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.ext_value = ext_value
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class PremiumGetProcessInstancesResponseBodyResultListOperationRecordsAttachments(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        file_size: str = None,
        file_type: str = None,
    ):
        self.file_id = file_id
        self.file_name = file_name
        self.file_size = file_size
        self.file_type = file_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.file_type is not None:
            result['fileType'] = self.file_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        return self


class PremiumGetProcessInstancesResponseBodyResultListOperationRecords(TeaModel):
    def __init__(
        self,
        attachments: List[PremiumGetProcessInstancesResponseBodyResultListOperationRecordsAttachments] = None,
        operation_type: str = None,
        remark: str = None,
        result: str = None,
        timestamp: int = None,
        user_id: str = None,
    ):
        self.attachments = attachments
        self.operation_type = operation_type
        self.remark = remark
        self.result = result
        self.timestamp = timestamp
        self.user_id = user_id

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
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.operation_type is not None:
            result['operationType'] = self.operation_type
        if self.remark is not None:
            result['remark'] = self.remark
        if self.result is not None:
            result['result'] = self.result
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = PremiumGetProcessInstancesResponseBodyResultListOperationRecordsAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('operationType') is not None:
            self.operation_type = m.get('operationType')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PremiumGetProcessInstancesResponseBodyResultListTasks(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        create_timestamp: int = None,
        finish_timestamp: int = None,
        result: str = None,
        status: str = None,
        task_id: int = None,
        user_id: str = None,
    ):
        self.activity_id = activity_id
        self.create_timestamp = create_timestamp
        self.finish_timestamp = finish_timestamp
        self.result = result
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.task_id = task_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.create_timestamp is not None:
            result['createTimestamp'] = self.create_timestamp
        if self.finish_timestamp is not None:
            result['finishTimestamp'] = self.finish_timestamp
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('createTimestamp') is not None:
            self.create_timestamp = m.get('createTimestamp')
        if m.get('finishTimestamp') is not None:
            self.finish_timestamp = m.get('finishTimestamp')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PremiumGetProcessInstancesResponseBodyResultList(TeaModel):
    def __init__(
        self,
        attached_process_instance_ids: str = None,
        business_id: str = None,
        create_time: int = None,
        finish_time: int = None,
        form_component_values: List[PremiumGetProcessInstancesResponseBodyResultListFormComponentValues] = None,
        main_process_instance_id: str = None,
        operation_records: List[PremiumGetProcessInstancesResponseBodyResultListOperationRecords] = None,
        originator_dept_id: str = None,
        originator_userid: str = None,
        process_instance_id: str = None,
        result: str = None,
        status: str = None,
        tasks: List[PremiumGetProcessInstancesResponseBodyResultListTasks] = None,
        title: str = None,
    ):
        # This parameter is required.
        self.attached_process_instance_ids = attached_process_instance_ids
        # This parameter is required.
        self.business_id = business_id
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
        self.finish_time = finish_time
        # This parameter is required.
        self.form_component_values = form_component_values
        # This parameter is required.
        self.main_process_instance_id = main_process_instance_id
        self.operation_records = operation_records
        # This parameter is required.
        self.originator_dept_id = originator_dept_id
        # This parameter is required.
        self.originator_userid = originator_userid
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.result = result
        # This parameter is required.
        self.status = status
        self.tasks = tasks
        # This parameter is required.
        self.title = title

    def validate(self):
        if self.form_component_values:
            for k in self.form_component_values:
                if k:
                    k.validate()
        if self.operation_records:
            for k in self.operation_records:
                if k:
                    k.validate()
        if self.tasks:
            for k in self.tasks:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attached_process_instance_ids is not None:
            result['attachedProcessInstanceIds'] = self.attached_process_instance_ids
        if self.business_id is not None:
            result['businessId'] = self.business_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        result['formComponentValues'] = []
        if self.form_component_values is not None:
            for k in self.form_component_values:
                result['formComponentValues'].append(k.to_map() if k else None)
        if self.main_process_instance_id is not None:
            result['mainProcessInstanceId'] = self.main_process_instance_id
        result['operationRecords'] = []
        if self.operation_records is not None:
            for k in self.operation_records:
                result['operationRecords'].append(k.to_map() if k else None)
        if self.originator_dept_id is not None:
            result['originatorDeptId'] = self.originator_dept_id
        if self.originator_userid is not None:
            result['originatorUserid'] = self.originator_userid
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        result['tasks'] = []
        if self.tasks is not None:
            for k in self.tasks:
                result['tasks'].append(k.to_map() if k else None)
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attachedProcessInstanceIds') is not None:
            self.attached_process_instance_ids = m.get('attachedProcessInstanceIds')
        if m.get('businessId') is not None:
            self.business_id = m.get('businessId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        self.form_component_values = []
        if m.get('formComponentValues') is not None:
            for k in m.get('formComponentValues'):
                temp_model = PremiumGetProcessInstancesResponseBodyResultListFormComponentValues()
                self.form_component_values.append(temp_model.from_map(k))
        if m.get('mainProcessInstanceId') is not None:
            self.main_process_instance_id = m.get('mainProcessInstanceId')
        self.operation_records = []
        if m.get('operationRecords') is not None:
            for k in m.get('operationRecords'):
                temp_model = PremiumGetProcessInstancesResponseBodyResultListOperationRecords()
                self.operation_records.append(temp_model.from_map(k))
        if m.get('originatorDeptId') is not None:
            self.originator_dept_id = m.get('originatorDeptId')
        if m.get('originatorUserid') is not None:
            self.originator_userid = m.get('originatorUserid')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        self.tasks = []
        if m.get('tasks') is not None:
            for k in m.get('tasks'):
                temp_model = PremiumGetProcessInstancesResponseBodyResultListTasks()
                self.tasks.append(temp_model.from_map(k))
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class PremiumGetProcessInstancesResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[PremiumGetProcessInstancesResponseBodyResultList] = None,
        max_results: int = None,
        next_token: str = None,
    ):
        # This parameter is required.
        self.has_more = has_more
        self.list = list
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = PremiumGetProcessInstancesResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class PremiumGetProcessInstancesResponseBody(TeaModel):
    def __init__(
        self,
        result: PremiumGetProcessInstancesResponseBodyResult = None,
    ):
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
            temp_model = PremiumGetProcessInstancesResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class PremiumGetProcessInstancesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumGetProcessInstancesResponseBody = None,
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
            temp_model = PremiumGetProcessInstancesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumGetSpaceWithDownloadAuthHeaders(TeaModel):
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


class PremiumGetSpaceWithDownloadAuthRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        file_id: str = None,
        file_id_list: List[str] = None,
        process_instance_id: str = None,
        user_id: str = None,
        with_comment_attatchment: bool = None,
    ):
        self.agent_id = agent_id
        # This parameter is required.
        self.file_id = file_id
        self.file_id_list = file_id_list
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.user_id = user_id
        self.with_comment_attatchment = with_comment_attatchment

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_id_list is not None:
            result['fileIdList'] = self.file_id_list
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.with_comment_attatchment is not None:
            result['withCommentAttatchment'] = self.with_comment_attatchment
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileIdList') is not None:
            self.file_id_list = m.get('fileIdList')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('withCommentAttatchment') is not None:
            self.with_comment_attatchment = m.get('withCommentAttatchment')
        return self


class PremiumGetSpaceWithDownloadAuthResponseBodyResult(TeaModel):
    def __init__(
        self,
        space_id: int = None,
    ):
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class PremiumGetSpaceWithDownloadAuthResponseBody(TeaModel):
    def __init__(
        self,
        result: PremiumGetSpaceWithDownloadAuthResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = PremiumGetSpaceWithDownloadAuthResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PremiumGetSpaceWithDownloadAuthResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumGetSpaceWithDownloadAuthResponseBody = None,
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
            temp_model = PremiumGetSpaceWithDownloadAuthResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumGetSubmittedInstancesHeaders(TeaModel):
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


class PremiumGetSubmittedInstancesRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PremiumGetSubmittedInstancesResponseBodyResultList(TeaModel):
    def __init__(
        self,
        app_type: int = None,
        form_massage: str = None,
        originator_id: str = None,
        originator_name: str = None,
        originator_photo: str = None,
        process_create_time: str = None,
        process_end_time: str = None,
        process_instance_id: str = None,
        process_type: int = None,
        result: str = None,
        status: str = None,
        title: str = None,
        url: str = None,
    ):
        self.app_type = app_type
        self.form_massage = form_massage
        self.originator_id = originator_id
        self.originator_name = originator_name
        self.originator_photo = originator_photo
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.process_create_time = process_create_time
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.process_end_time = process_end_time
        self.process_instance_id = process_instance_id
        self.process_type = process_type
        self.result = result
        self.status = status
        self.title = title
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_massage is not None:
            result['formMassage'] = self.form_massage
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.originator_name is not None:
            result['originatorName'] = self.originator_name
        if self.originator_photo is not None:
            result['originatorPhoto'] = self.originator_photo
        if self.process_create_time is not None:
            result['processCreateTime'] = self.process_create_time
        if self.process_end_time is not None:
            result['processEndTime'] = self.process_end_time
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.process_type is not None:
            result['processType'] = self.process_type
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        if self.title is not None:
            result['title'] = self.title
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formMassage') is not None:
            self.form_massage = m.get('formMassage')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('originatorName') is not None:
            self.originator_name = m.get('originatorName')
        if m.get('originatorPhoto') is not None:
            self.originator_photo = m.get('originatorPhoto')
        if m.get('processCreateTime') is not None:
            self.process_create_time = m.get('processCreateTime')
        if m.get('processEndTime') is not None:
            self.process_end_time = m.get('processEndTime')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('processType') is not None:
            self.process_type = m.get('processType')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class PremiumGetSubmittedInstancesResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[PremiumGetSubmittedInstancesResponseBodyResultList] = None,
    ):
        self.has_more = has_more
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = PremiumGetSubmittedInstancesResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        return self


class PremiumGetSubmittedInstancesResponseBody(TeaModel):
    def __init__(
        self,
        result: PremiumGetSubmittedInstancesResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = PremiumGetSubmittedInstancesResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PremiumGetSubmittedInstancesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumGetSubmittedInstancesResponseBody = None,
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
            temp_model = PremiumGetSubmittedInstancesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumGetTodoTasksHeaders(TeaModel):
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


class PremiumGetTodoTasksRequest(TeaModel):
    def __init__(
        self,
        create_before: str = None,
        page_number: int = None,
        page_size: int = None,
        user_id: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_before = create_before
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_before is not None:
            result['createBefore'] = self.create_before
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createBefore') is not None:
            self.create_before = m.get('createBefore')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PremiumGetTodoTasksResponseBodyResultList(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        app_type: int = None,
        form_massage: str = None,
        originator_id: str = None,
        originator_name: str = None,
        originator_photo: str = None,
        process_create_time: str = None,
        process_end_time: str = None,
        process_instance_id: str = None,
        process_type: int = None,
        status: str = None,
        task_id: str = None,
        title: str = None,
        url: str = None,
    ):
        self.activity_id = activity_id
        self.app_type = app_type
        self.form_massage = form_massage
        self.originator_id = originator_id
        self.originator_name = originator_name
        self.originator_photo = originator_photo
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.process_create_time = process_create_time
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.process_end_time = process_end_time
        self.process_instance_id = process_instance_id
        self.process_type = process_type
        self.status = status
        self.task_id = task_id
        self.title = title
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_massage is not None:
            result['formMassage'] = self.form_massage
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.originator_name is not None:
            result['originatorName'] = self.originator_name
        if self.originator_photo is not None:
            result['originatorPhoto'] = self.originator_photo
        if self.process_create_time is not None:
            result['processCreateTime'] = self.process_create_time
        if self.process_end_time is not None:
            result['processEndTime'] = self.process_end_time
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.process_type is not None:
            result['processType'] = self.process_type
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.title is not None:
            result['title'] = self.title
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formMassage') is not None:
            self.form_massage = m.get('formMassage')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('originatorName') is not None:
            self.originator_name = m.get('originatorName')
        if m.get('originatorPhoto') is not None:
            self.originator_photo = m.get('originatorPhoto')
        if m.get('processCreateTime') is not None:
            self.process_create_time = m.get('processCreateTime')
        if m.get('processEndTime') is not None:
            self.process_end_time = m.get('processEndTime')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('processType') is not None:
            self.process_type = m.get('processType')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class PremiumGetTodoTasksResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[PremiumGetTodoTasksResponseBodyResultList] = None,
        success: bool = None,
    ):
        self.has_more = has_more
        self.list = list
        self.success = success

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = PremiumGetTodoTasksResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PremiumGetTodoTasksResponseBody(TeaModel):
    def __init__(
        self,
        result: PremiumGetTodoTasksResponseBodyResult = None,
    ):
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
            temp_model = PremiumGetTodoTasksResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class PremiumGetTodoTasksResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumGetTodoTasksResponseBody = None,
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
            temp_model = PremiumGetTodoTasksResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumGrantProcessInstanceForDownloadFileHeaders(TeaModel):
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


class PremiumGrantProcessInstanceForDownloadFileRequest(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        process_instance_id: str = None,
        with_comment_attatchment: bool = None,
    ):
        # This parameter is required.
        self.file_id = file_id
        # This parameter is required.
        self.process_instance_id = process_instance_id
        self.with_comment_attatchment = with_comment_attatchment

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.with_comment_attatchment is not None:
            result['withCommentAttatchment'] = self.with_comment_attatchment
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('withCommentAttatchment') is not None:
            self.with_comment_attatchment = m.get('withCommentAttatchment')
        return self


class PremiumGrantProcessInstanceForDownloadFileResponseBodyResult(TeaModel):
    def __init__(
        self,
        download_uri: str = None,
        file_id: str = None,
        space_id: int = None,
    ):
        self.download_uri = download_uri
        self.file_id = file_id
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.download_uri is not None:
            result['downloadUri'] = self.download_uri
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('downloadUri') is not None:
            self.download_uri = m.get('downloadUri')
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class PremiumGrantProcessInstanceForDownloadFileResponseBody(TeaModel):
    def __init__(
        self,
        result: PremiumGrantProcessInstanceForDownloadFileResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = PremiumGrantProcessInstanceForDownloadFileResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PremiumGrantProcessInstanceForDownloadFileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumGrantProcessInstanceForDownloadFileResponseBody = None,
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
            temp_model = PremiumGrantProcessInstanceForDownloadFileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumInsertOrUpdateDirHeaders(TeaModel):
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


class PremiumInsertOrUpdateDirRequest(TeaModel):
    def __init__(
        self,
        biz_group: str = None,
        description: str = None,
        name: str = None,
        name_18n: str = None,
        operate_user_id: str = None,
    ):
        self.biz_group = biz_group
        self.description = description
        self.name = name
        # This parameter is required.
        self.name_18n = name_18n
        # This parameter is required.
        self.operate_user_id = operate_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_group is not None:
            result['bizGroup'] = self.biz_group
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.name_18n is not None:
            result['name18n'] = self.name_18n
        if self.operate_user_id is not None:
            result['operateUserId'] = self.operate_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizGroup') is not None:
            self.biz_group = m.get('bizGroup')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('name18n') is not None:
            self.name_18n = m.get('name18n')
        if m.get('operateUserId') is not None:
            self.operate_user_id = m.get('operateUserId')
        return self


class PremiumInsertOrUpdateDirResponseBodyResult(TeaModel):
    def __init__(
        self,
        biz_group: str = None,
        dir_id: str = None,
    ):
        self.biz_group = biz_group
        self.dir_id = dir_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_group is not None:
            result['bizGroup'] = self.biz_group
        if self.dir_id is not None:
            result['dirId'] = self.dir_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizGroup') is not None:
            self.biz_group = m.get('bizGroup')
        if m.get('dirId') is not None:
            self.dir_id = m.get('dirId')
        return self


class PremiumInsertOrUpdateDirResponseBody(TeaModel):
    def __init__(
        self,
        result: PremiumInsertOrUpdateDirResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = PremiumInsertOrUpdateDirResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PremiumInsertOrUpdateDirResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumInsertOrUpdateDirResponseBody = None,
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
            temp_model = PremiumInsertOrUpdateDirResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumQueryTodoTasksByManagerHeaders(TeaModel):
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


class PremiumQueryTodoTasksByManagerRequest(TeaModel):
    def __init__(
        self,
        actioner_user_id: str = None,
        manager_user_id: str = None,
        max_results: int = None,
        next_token: int = None,
    ):
        # This parameter is required.
        self.actioner_user_id = actioner_user_id
        # This parameter is required.
        self.manager_user_id = manager_user_id
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actioner_user_id is not None:
            result['actionerUserId'] = self.actioner_user_id
        if self.manager_user_id is not None:
            result['managerUserId'] = self.manager_user_id
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionerUserId') is not None:
            self.actioner_user_id = m.get('actionerUserId')
        if m.get('managerUserId') is not None:
            self.manager_user_id = m.get('managerUserId')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class PremiumQueryTodoTasksByManagerResponseBodyResultList(TeaModel):
    def __init__(
        self,
        business_id: str = None,
        can_redirect: bool = None,
        create_time: int = None,
        process_code: str = None,
        process_instance_id: str = None,
        task_id: int = None,
        title: str = None,
        user_id: str = None,
    ):
        self.business_id = business_id
        self.can_redirect = can_redirect
        self.create_time = create_time
        self.process_code = process_code
        self.process_instance_id = process_instance_id
        self.task_id = task_id
        self.title = title
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.business_id is not None:
            result['businessId'] = self.business_id
        if self.can_redirect is not None:
            result['canRedirect'] = self.can_redirect
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('businessId') is not None:
            self.business_id = m.get('businessId')
        if m.get('canRedirect') is not None:
            self.can_redirect = m.get('canRedirect')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PremiumQueryTodoTasksByManagerResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[PremiumQueryTodoTasksByManagerResponseBodyResultList] = None,
    ):
        self.has_more = has_more
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = PremiumQueryTodoTasksByManagerResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        return self


class PremiumQueryTodoTasksByManagerResponseBody(TeaModel):
    def __init__(
        self,
        result: PremiumQueryTodoTasksByManagerResponseBodyResult = None,
    ):
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
            temp_model = PremiumQueryTodoTasksByManagerResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class PremiumQueryTodoTasksByManagerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumQueryTodoTasksByManagerResponseBody = None,
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
            temp_model = PremiumQueryTodoTasksByManagerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumRedirectTasksByManagerHeaders(TeaModel):
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


class PremiumRedirectTasksByManagerRequest(TeaModel):
    def __init__(
        self,
        handover_user_id: str = None,
        manager_user_id: str = None,
        task_ids: List[int] = None,
        transferee_user_id: str = None,
    ):
        # This parameter is required.
        self.handover_user_id = handover_user_id
        # This parameter is required.
        self.manager_user_id = manager_user_id
        # This parameter is required.
        self.task_ids = task_ids
        # This parameter is required.
        self.transferee_user_id = transferee_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.handover_user_id is not None:
            result['handoverUserId'] = self.handover_user_id
        if self.manager_user_id is not None:
            result['managerUserId'] = self.manager_user_id
        if self.task_ids is not None:
            result['taskIds'] = self.task_ids
        if self.transferee_user_id is not None:
            result['transfereeUserId'] = self.transferee_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('handoverUserId') is not None:
            self.handover_user_id = m.get('handoverUserId')
        if m.get('managerUserId') is not None:
            self.manager_user_id = m.get('managerUserId')
        if m.get('taskIds') is not None:
            self.task_ids = m.get('taskIds')
        if m.get('transfereeUserId') is not None:
            self.transferee_user_id = m.get('transfereeUserId')
        return self


class PremiumRedirectTasksByManagerResponseBodyResultRedirectResults(TeaModel):
    def __init__(
        self,
        error_msg: str = None,
        success: bool = None,
        task_id: int = None,
    ):
        self.error_msg = error_msg
        # This parameter is required.
        self.success = success
        # This parameter is required.
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.success is not None:
            result['success'] = self.success
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class PremiumRedirectTasksByManagerResponseBodyResult(TeaModel):
    def __init__(
        self,
        fail_count: int = None,
        redirect_results: List[PremiumRedirectTasksByManagerResponseBodyResultRedirectResults] = None,
        total_count: int = None,
    ):
        # This parameter is required.
        self.fail_count = fail_count
        # This parameter is required.
        self.redirect_results = redirect_results
        # This parameter is required.
        self.total_count = total_count

    def validate(self):
        if self.redirect_results:
            for k in self.redirect_results:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fail_count is not None:
            result['failCount'] = self.fail_count
        result['redirectResults'] = []
        if self.redirect_results is not None:
            for k in self.redirect_results:
                result['redirectResults'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failCount') is not None:
            self.fail_count = m.get('failCount')
        self.redirect_results = []
        if m.get('redirectResults') is not None:
            for k in m.get('redirectResults'):
                temp_model = PremiumRedirectTasksByManagerResponseBodyResultRedirectResults()
                self.redirect_results.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class PremiumRedirectTasksByManagerResponseBody(TeaModel):
    def __init__(
        self,
        result: PremiumRedirectTasksByManagerResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = PremiumRedirectTasksByManagerResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PremiumRedirectTasksByManagerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumRedirectTasksByManagerResponseBody = None,
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
            temp_model = PremiumRedirectTasksByManagerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumSaveFormHeaders(TeaModel):
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


class PremiumSaveFormRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        form_components: List[FormComponent] = None,
        name: str = None,
        process_code: str = None,
        user_id: str = None,
    ):
        self.description = description
        # This parameter is required.
        self.form_components = form_components
        # This parameter is required.
        self.name = name
        self.process_code = process_code
        # This parameter is required.
        self.user_id = user_id

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
        if self.description is not None:
            result['description'] = self.description
        result['formComponents'] = []
        if self.form_components is not None:
            for k in self.form_components:
                result['formComponents'].append(k.to_map() if k else None)
        if self.name is not None:
            result['name'] = self.name
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        self.form_components = []
        if m.get('formComponents') is not None:
            for k in m.get('formComponents'):
                temp_model = FormComponent()
                self.form_components.append(temp_model.from_map(k))
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PremiumSaveFormResponseBodyResult(TeaModel):
    def __init__(
        self,
        process_code: str = None,
    ):
        # This parameter is required.
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


class PremiumSaveFormResponseBody(TeaModel):
    def __init__(
        self,
        result: PremiumSaveFormResponseBodyResult = None,
    ):
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
            temp_model = PremiumSaveFormResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class PremiumSaveFormResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumSaveFormResponseBody = None,
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
            temp_model = PremiumSaveFormResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumSaveFormInstanceHeaders(TeaModel):
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


class PremiumSaveFormInstanceRequestFormComponentValueListDetailsDetails(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        component_type: str = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.component_type = component_type
        self.ext_value = ext_value
        self.id = id
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class PremiumSaveFormInstanceRequestFormComponentValueListDetails(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        details: List[PremiumSaveFormInstanceRequestFormComponentValueListDetailsDetails] = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.details = details
        self.ext_value = ext_value
        self.id = id
        self.name = name
        self.value = value

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
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        result['details'] = []
        if self.details is not None:
            for k in self.details:
                result['details'].append(k.to_map() if k else None)
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        self.details = []
        if m.get('details') is not None:
            for k in m.get('details'):
                temp_model = PremiumSaveFormInstanceRequestFormComponentValueListDetailsDetails()
                self.details.append(temp_model.from_map(k))
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class PremiumSaveFormInstanceRequestFormComponentValueList(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        component_type: str = None,
        details: List[PremiumSaveFormInstanceRequestFormComponentValueListDetails] = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.component_type = component_type
        self.details = details
        self.ext_value = ext_value
        self.id = id
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.value = value

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
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        result['details'] = []
        if self.details is not None:
            for k in self.details:
                result['details'].append(k.to_map() if k else None)
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        self.details = []
        if m.get('details') is not None:
            for k in m.get('details'):
                temp_model = PremiumSaveFormInstanceRequestFormComponentValueListDetails()
                self.details.append(temp_model.from_map(k))
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class PremiumSaveFormInstanceRequest(TeaModel):
    def __init__(
        self,
        form_component_value_list: List[PremiumSaveFormInstanceRequestFormComponentValueList] = None,
        originator_user_id: str = None,
        process_code: str = None,
    ):
        # This parameter is required.
        self.form_component_value_list = form_component_value_list
        # This parameter is required.
        self.originator_user_id = originator_user_id
        # This parameter is required.
        self.process_code = process_code

    def validate(self):
        if self.form_component_value_list:
            for k in self.form_component_value_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['formComponentValueList'] = []
        if self.form_component_value_list is not None:
            for k in self.form_component_value_list:
                result['formComponentValueList'].append(k.to_map() if k else None)
        if self.originator_user_id is not None:
            result['originatorUserId'] = self.originator_user_id
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.form_component_value_list = []
        if m.get('formComponentValueList') is not None:
            for k in m.get('formComponentValueList'):
                temp_model = PremiumSaveFormInstanceRequestFormComponentValueList()
                self.form_component_value_list.append(temp_model.from_map(k))
        if m.get('originatorUserId') is not None:
            self.originator_user_id = m.get('originatorUserId')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class PremiumSaveFormInstanceResponseBody(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
    ):
        # This parameter is required.
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


class PremiumSaveFormInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumSaveFormInstanceResponseBody = None,
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
            temp_model = PremiumSaveFormInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumSaveIntegratedProcessHeaders(TeaModel):
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


class PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback(TeaModel):
    def __init__(
        self,
        api_key: str = None,
        app_uuid: str = None,
        version: str = None,
    ):
        self.api_key = api_key
        self.app_uuid = app_uuid
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_key is not None:
            result['apiKey'] = self.api_key
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiKey') is not None:
            self.api_key = m.get('apiKey')
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures(TeaModel):
    def __init__(
        self,
        callback: PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback = None,
        mobile_url: str = None,
        name: str = None,
        pc_url: str = None,
        run_type: str = None,
    ):
        self.callback = callback
        self.mobile_url = mobile_url
        self.name = name
        self.pc_url = pc_url
        self.run_type = run_type

    def validate(self):
        if self.callback:
            self.callback.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback is not None:
            result['callback'] = self.callback.to_map()
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        if self.name is not None:
            result['name'] = self.name
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.run_type is not None:
            result['runType'] = self.run_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callback') is not None:
            temp_model = PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback()
            self.callback = temp_model.from_map(m['callback'])
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('runType') is not None:
            self.run_type = m.get('runType')
        return self


class PremiumSaveIntegratedProcessRequestProcessFeatureConfig(TeaModel):
    def __init__(
        self,
        features: List[PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures] = None,
    ):
        self.features = features

    def validate(self):
        if self.features:
            for k in self.features:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['features'] = []
        if self.features is not None:
            for k in self.features:
                result['features'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.features = []
        if m.get('features') is not None:
            for k in m.get('features'):
                temp_model = PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures()
                self.features.append(temp_model.from_map(k))
        return self


class PremiumSaveIntegratedProcessRequestTemplateConfig(TeaModel):
    def __init__(
        self,
        create_instance_mobile_url: str = None,
        create_instance_pc_url: str = None,
        disable_send_card: bool = None,
        hidden: bool = None,
        template_edit_url: str = None,
    ):
        self.create_instance_mobile_url = create_instance_mobile_url
        self.create_instance_pc_url = create_instance_pc_url
        self.disable_send_card = disable_send_card
        self.hidden = hidden
        self.template_edit_url = template_edit_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_instance_mobile_url is not None:
            result['createInstanceMobileUrl'] = self.create_instance_mobile_url
        if self.create_instance_pc_url is not None:
            result['createInstancePcUrl'] = self.create_instance_pc_url
        if self.disable_send_card is not None:
            result['disableSendCard'] = self.disable_send_card
        if self.hidden is not None:
            result['hidden'] = self.hidden
        if self.template_edit_url is not None:
            result['templateEditUrl'] = self.template_edit_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createInstanceMobileUrl') is not None:
            self.create_instance_mobile_url = m.get('createInstanceMobileUrl')
        if m.get('createInstancePcUrl') is not None:
            self.create_instance_pc_url = m.get('createInstancePcUrl')
        if m.get('disableSendCard') is not None:
            self.disable_send_card = m.get('disableSendCard')
        if m.get('hidden') is not None:
            self.hidden = m.get('hidden')
        if m.get('templateEditUrl') is not None:
            self.template_edit_url = m.get('templateEditUrl')
        return self


class PremiumSaveIntegratedProcessRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        form_components: List[FormComponent] = None,
        name: str = None,
        process_code: str = None,
        process_feature_config: PremiumSaveIntegratedProcessRequestProcessFeatureConfig = None,
        template_config: PremiumSaveIntegratedProcessRequestTemplateConfig = None,
    ):
        self.description = description
        # This parameter is required.
        self.form_components = form_components
        # This parameter is required.
        self.name = name
        self.process_code = process_code
        self.process_feature_config = process_feature_config
        self.template_config = template_config

    def validate(self):
        if self.form_components:
            for k in self.form_components:
                if k:
                    k.validate()
        if self.process_feature_config:
            self.process_feature_config.validate()
        if self.template_config:
            self.template_config.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        result['formComponents'] = []
        if self.form_components is not None:
            for k in self.form_components:
                result['formComponents'].append(k.to_map() if k else None)
        if self.name is not None:
            result['name'] = self.name
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_feature_config is not None:
            result['processFeatureConfig'] = self.process_feature_config.to_map()
        if self.template_config is not None:
            result['templateConfig'] = self.template_config.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        self.form_components = []
        if m.get('formComponents') is not None:
            for k in m.get('formComponents'):
                temp_model = FormComponent()
                self.form_components.append(temp_model.from_map(k))
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processFeatureConfig') is not None:
            temp_model = PremiumSaveIntegratedProcessRequestProcessFeatureConfig()
            self.process_feature_config = temp_model.from_map(m['processFeatureConfig'])
        if m.get('templateConfig') is not None:
            temp_model = PremiumSaveIntegratedProcessRequestTemplateConfig()
            self.template_config = temp_model.from_map(m['templateConfig'])
        return self


class PremiumSaveIntegratedProcessResponseBodyResult(TeaModel):
    def __init__(
        self,
        process_code: str = None,
    ):
        # This parameter is required.
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


class PremiumSaveIntegratedProcessResponseBody(TeaModel):
    def __init__(
        self,
        result: PremiumSaveIntegratedProcessResponseBodyResult = None,
    ):
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
            temp_model = PremiumSaveIntegratedProcessResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class PremiumSaveIntegratedProcessResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumSaveIntegratedProcessResponseBody = None,
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
            temp_model = PremiumSaveIntegratedProcessResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumSaveIntegratedProcessInstanceHeaders(TeaModel):
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


class PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        component_type: str = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.component_type = component_type
        self.ext_value = ext_value
        self.id = id
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class PremiumSaveIntegratedProcessInstanceRequestNotifiers(TeaModel):
    def __init__(
        self,
        position: str = None,
        userid: str = None,
    ):
        self.position = position
        self.userid = userid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.position is not None:
            result['position'] = self.position
        if self.userid is not None:
            result['userid'] = self.userid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('position') is not None:
            self.position = m.get('position')
        if m.get('userid') is not None:
            self.userid = m.get('userid')
        return self


class PremiumSaveIntegratedProcessInstanceRequest(TeaModel):
    def __init__(
        self,
        biz_data: str = None,
        form_component_value_list: List[PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList] = None,
        notifiers: List[PremiumSaveIntegratedProcessInstanceRequestNotifiers] = None,
        originator_user_id: str = None,
        process_code: str = None,
        title: str = None,
        url: str = None,
    ):
        self.biz_data = biz_data
        self.form_component_value_list = form_component_value_list
        self.notifiers = notifiers
        # This parameter is required.
        self.originator_user_id = originator_user_id
        # This parameter is required.
        self.process_code = process_code
        self.title = title
        # This parameter is required.
        self.url = url

    def validate(self):
        if self.form_component_value_list:
            for k in self.form_component_value_list:
                if k:
                    k.validate()
        if self.notifiers:
            for k in self.notifiers:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_data is not None:
            result['bizData'] = self.biz_data
        result['formComponentValueList'] = []
        if self.form_component_value_list is not None:
            for k in self.form_component_value_list:
                result['formComponentValueList'].append(k.to_map() if k else None)
        result['notifiers'] = []
        if self.notifiers is not None:
            for k in self.notifiers:
                result['notifiers'].append(k.to_map() if k else None)
        if self.originator_user_id is not None:
            result['originatorUserId'] = self.originator_user_id
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.title is not None:
            result['title'] = self.title
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizData') is not None:
            self.biz_data = m.get('bizData')
        self.form_component_value_list = []
        if m.get('formComponentValueList') is not None:
            for k in m.get('formComponentValueList'):
                temp_model = PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList()
                self.form_component_value_list.append(temp_model.from_map(k))
        self.notifiers = []
        if m.get('notifiers') is not None:
            for k in m.get('notifiers'):
                temp_model = PremiumSaveIntegratedProcessInstanceRequestNotifiers()
                self.notifiers.append(temp_model.from_map(k))
        if m.get('originatorUserId') is not None:
            self.originator_user_id = m.get('originatorUserId')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class PremiumSaveIntegratedProcessInstanceResponseBodyResult(TeaModel):
    def __init__(
        self,
        process_instance_id: str = None,
    ):
        self.process_instance_id = process_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        return self


class PremiumSaveIntegratedProcessInstanceResponseBody(TeaModel):
    def __init__(
        self,
        result: PremiumSaveIntegratedProcessInstanceResponseBodyResult = None,
    ):
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
            temp_model = PremiumSaveIntegratedProcessInstanceResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class PremiumSaveIntegratedProcessInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumSaveIntegratedProcessInstanceResponseBody = None,
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
            temp_model = PremiumSaveIntegratedProcessInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumSaveIntegratedTaskHeaders(TeaModel):
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


class PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback(TeaModel):
    def __init__(
        self,
        api_key: str = None,
        app_uuid: str = None,
        version: str = None,
    ):
        self.api_key = api_key
        self.app_uuid = app_uuid
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_key is not None:
            result['apiKey'] = self.api_key
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiKey') is not None:
            self.api_key = m.get('apiKey')
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class PremiumSaveIntegratedTaskRequestFeatureConfigFeatures(TeaModel):
    def __init__(
        self,
        callback: PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback = None,
        config: str = None,
        mobile_url: str = None,
        name: str = None,
        pc_url: str = None,
        run_type: str = None,
    ):
        self.callback = callback
        self.config = config
        self.mobile_url = mobile_url
        self.name = name
        self.pc_url = pc_url
        self.run_type = run_type

    def validate(self):
        if self.callback:
            self.callback.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback is not None:
            result['callback'] = self.callback.to_map()
        if self.config is not None:
            result['config'] = self.config
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        if self.name is not None:
            result['name'] = self.name
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.run_type is not None:
            result['runType'] = self.run_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callback') is not None:
            temp_model = PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback()
            self.callback = temp_model.from_map(m['callback'])
        if m.get('config') is not None:
            self.config = m.get('config')
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('runType') is not None:
            self.run_type = m.get('runType')
        return self


class PremiumSaveIntegratedTaskRequestFeatureConfig(TeaModel):
    def __init__(
        self,
        features: List[PremiumSaveIntegratedTaskRequestFeatureConfigFeatures] = None,
    ):
        self.features = features

    def validate(self):
        if self.features:
            for k in self.features:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['features'] = []
        if self.features is not None:
            for k in self.features:
                result['features'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.features = []
        if m.get('features') is not None:
            for k in m.get('features'):
                temp_model = PremiumSaveIntegratedTaskRequestFeatureConfigFeatures()
                self.features.append(temp_model.from_map(k))
        return self


class PremiumSaveIntegratedTaskRequestTasks(TeaModel):
    def __init__(
        self,
        custom_data: str = None,
        url: str = None,
        user_id: str = None,
    ):
        self.custom_data = custom_data
        self.url = url
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_data is not None:
            result['customData'] = self.custom_data
        if self.url is not None:
            result['url'] = self.url
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customData') is not None:
            self.custom_data = m.get('customData')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PremiumSaveIntegratedTaskRequest(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        feature_config: PremiumSaveIntegratedTaskRequestFeatureConfig = None,
        process_instance_id: str = None,
        tasks: List[PremiumSaveIntegratedTaskRequestTasks] = None,
    ):
        self.activity_id = activity_id
        self.feature_config = feature_config
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.tasks = tasks

    def validate(self):
        if self.feature_config:
            self.feature_config.validate()
        if self.tasks:
            for k in self.tasks:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.feature_config is not None:
            result['featureConfig'] = self.feature_config.to_map()
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        result['tasks'] = []
        if self.tasks is not None:
            for k in self.tasks:
                result['tasks'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('featureConfig') is not None:
            temp_model = PremiumSaveIntegratedTaskRequestFeatureConfig()
            self.feature_config = temp_model.from_map(m['featureConfig'])
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        self.tasks = []
        if m.get('tasks') is not None:
            for k in m.get('tasks'):
                temp_model = PremiumSaveIntegratedTaskRequestTasks()
                self.tasks.append(temp_model.from_map(k))
        return self


class PremiumSaveIntegratedTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        task_id: int = None,
        user_id: str = None,
    ):
        self.task_id = task_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PremiumSaveIntegratedTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: List[PremiumSaveIntegratedTaskResponseBodyResult] = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = PremiumSaveIntegratedTaskResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PremiumSaveIntegratedTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumSaveIntegratedTaskResponseBody = None,
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
            temp_model = PremiumSaveIntegratedTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumUpdateFormInstanceHeaders(TeaModel):
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


class PremiumUpdateFormInstanceRequestFormComponentValueListDetailsDetails(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        component_type: str = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.component_type = component_type
        self.ext_value = ext_value
        self.id = id
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class PremiumUpdateFormInstanceRequestFormComponentValueListDetails(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        details: List[PremiumUpdateFormInstanceRequestFormComponentValueListDetailsDetails] = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.details = details
        self.ext_value = ext_value
        self.id = id
        self.name = name
        self.value = value

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
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        result['details'] = []
        if self.details is not None:
            for k in self.details:
                result['details'].append(k.to_map() if k else None)
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        self.details = []
        if m.get('details') is not None:
            for k in m.get('details'):
                temp_model = PremiumUpdateFormInstanceRequestFormComponentValueListDetailsDetails()
                self.details.append(temp_model.from_map(k))
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class PremiumUpdateFormInstanceRequestFormComponentValueList(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        component_type: str = None,
        details: List[PremiumUpdateFormInstanceRequestFormComponentValueListDetails] = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.component_type = component_type
        self.details = details
        self.ext_value = ext_value
        self.id = id
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.value = value

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
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        result['details'] = []
        if self.details is not None:
            for k in self.details:
                result['details'].append(k.to_map() if k else None)
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        self.details = []
        if m.get('details') is not None:
            for k in m.get('details'):
                temp_model = PremiumUpdateFormInstanceRequestFormComponentValueListDetails()
                self.details.append(temp_model.from_map(k))
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class PremiumUpdateFormInstanceRequest(TeaModel):
    def __init__(
        self,
        form_component_value_list: List[PremiumUpdateFormInstanceRequestFormComponentValueList] = None,
        form_instance_ids: List[str] = None,
        originator_user_id: str = None,
        process_code: str = None,
    ):
        # This parameter is required.
        self.form_component_value_list = form_component_value_list
        self.form_instance_ids = form_instance_ids
        # This parameter is required.
        self.originator_user_id = originator_user_id
        # This parameter is required.
        self.process_code = process_code

    def validate(self):
        if self.form_component_value_list:
            for k in self.form_component_value_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['formComponentValueList'] = []
        if self.form_component_value_list is not None:
            for k in self.form_component_value_list:
                result['formComponentValueList'].append(k.to_map() if k else None)
        if self.form_instance_ids is not None:
            result['formInstanceIds'] = self.form_instance_ids
        if self.originator_user_id is not None:
            result['originatorUserId'] = self.originator_user_id
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.form_component_value_list = []
        if m.get('formComponentValueList') is not None:
            for k in m.get('formComponentValueList'):
                temp_model = PremiumUpdateFormInstanceRequestFormComponentValueList()
                self.form_component_value_list.append(temp_model.from_map(k))
        if m.get('formInstanceIds') is not None:
            self.form_instance_ids = m.get('formInstanceIds')
        if m.get('originatorUserId') is not None:
            self.originator_user_id = m.get('originatorUserId')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class PremiumUpdateFormInstanceResponseBody(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
    ):
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


class PremiumUpdateFormInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumUpdateFormInstanceResponseBody = None,
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
            temp_model = PremiumUpdateFormInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PremiumUpdateProcessInstanceVariablesHeaders(TeaModel):
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


class PremiumUpdateProcessInstanceVariablesRequestVariables(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        ext_value: str = None,
        id: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.ext_value = ext_value
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class PremiumUpdateProcessInstanceVariablesRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        process_code: str = None,
        process_instance_id: str = None,
        remark: str = None,
        variables: List[PremiumUpdateProcessInstanceVariablesRequestVariables] = None,
    ):
        # This parameter is required.
        self.op_user_id = op_user_id
        self.process_code = process_code
        # This parameter is required.
        self.process_instance_id = process_instance_id
        self.remark = remark
        # This parameter is required.
        self.variables = variables

    def validate(self):
        if self.variables:
            for k in self.variables:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.remark is not None:
            result['remark'] = self.remark
        result['variables'] = []
        if self.variables is not None:
            for k in self.variables:
                result['variables'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        self.variables = []
        if m.get('variables') is not None:
            for k in m.get('variables'):
                temp_model = PremiumUpdateProcessInstanceVariablesRequestVariables()
                self.variables.append(temp_model.from_map(k))
        return self


class PremiumUpdateProcessInstanceVariablesResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class PremiumUpdateProcessInstanceVariablesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PremiumUpdateProcessInstanceVariablesResponseBody = None,
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
            temp_model = PremiumUpdateProcessInstanceVariablesResponseBody()
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
        biz_alias: str = None,
        component_type: str = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.component_type = component_type
        self.ext_value = ext_value
        self.id = id
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class ProcessForecastRequestFormComponentValuesDetails(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        details: List[ProcessForecastRequestFormComponentValuesDetailsDetails] = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.details = details
        self.ext_value = ext_value
        self.id = id
        self.name = name
        self.value = value

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
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        result['details'] = []
        if self.details is not None:
            for k in self.details:
                result['details'].append(k.to_map() if k else None)
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        self.details = []
        if m.get('details') is not None:
            for k in m.get('details'):
                temp_model = ProcessForecastRequestFormComponentValuesDetailsDetails()
                self.details.append(temp_model.from_map(k))
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class ProcessForecastRequestFormComponentValues(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        component_type: str = None,
        details: List[ProcessForecastRequestFormComponentValuesDetails] = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.component_type = component_type
        self.details = details
        self.ext_value = ext_value
        self.id = id
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.value = value

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
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        result['details'] = []
        if self.details is not None:
            for k in self.details:
                result['details'].append(k.to_map() if k else None)
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        self.details = []
        if m.get('details') is not None:
            for k in m.get('details'):
                temp_model = ProcessForecastRequestFormComponentValuesDetails()
                self.details.append(temp_model.from_map(k))
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class ProcessForecastRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        form_component_values: List[ProcessForecastRequestFormComponentValues] = None,
        process_code: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.dept_id = dept_id
        # This parameter is required.
        self.form_component_values = form_component_values
        # This parameter is required.
        self.process_code = process_code
        # This parameter is required.
        self.user_id = user_id

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
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        result['formComponentValues'] = []
        if self.form_component_values is not None:
            for k in self.form_component_values:
                result['formComponentValues'].append(k.to_map() if k else None)
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        self.form_component_values = []
        if m.get('formComponentValues') is not None:
            for k in m.get('formComponentValues'):
                temp_model = ProcessForecastRequestFormComponentValues()
                self.form_component_values.append(temp_model.from_map(k))
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals(TeaModel):
    def __init__(
        self,
        user_name: str = None,
        work_no: str = None,
    ):
        self.user_name = user_name
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels(TeaModel):
    def __init__(
        self,
        label_names: str = None,
        labels: str = None,
    ):
        self.label_names = label_names
        self.labels = labels

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_names is not None:
            result['labelNames'] = self.label_names
        if self.labels is not None:
            result['labels'] = self.labels
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelNames') is not None:
            self.label_names = m.get('labelNames')
        if m.get('labels') is not None:
            self.labels = m.get('labels')
        return self


class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange(TeaModel):
    def __init__(
        self,
        approvals: List[ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals] = None,
        labels: List[ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels] = None,
    ):
        self.approvals = approvals
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
        actor_activate_type: str = None,
        actor_key: str = None,
        actor_selection_range: ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange = None,
        actor_selection_type: str = None,
        actor_type: str = None,
        allowed_multi: bool = None,
        approval_method: str = None,
        approval_type: str = None,
        required: bool = None,
    ):
        self.actor_activate_type = actor_activate_type
        self.actor_key = actor_key
        self.actor_selection_range = actor_selection_range
        self.actor_selection_type = actor_selection_type
        self.actor_type = actor_type
        self.allowed_multi = allowed_multi
        self.approval_method = approval_method
        self.approval_type = approval_type
        self.required = required

    def validate(self):
        if self.actor_selection_range:
            self.actor_selection_range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actor_activate_type is not None:
            result['actorActivateType'] = self.actor_activate_type
        if self.actor_key is not None:
            result['actorKey'] = self.actor_key
        if self.actor_selection_range is not None:
            result['actorSelectionRange'] = self.actor_selection_range.to_map()
        if self.actor_selection_type is not None:
            result['actorSelectionType'] = self.actor_selection_type
        if self.actor_type is not None:
            result['actorType'] = self.actor_type
        if self.allowed_multi is not None:
            result['allowedMulti'] = self.allowed_multi
        if self.approval_method is not None:
            result['approvalMethod'] = self.approval_method
        if self.approval_type is not None:
            result['approvalType'] = self.approval_type
        if self.required is not None:
            result['required'] = self.required
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actorActivateType') is not None:
            self.actor_activate_type = m.get('actorActivateType')
        if m.get('actorKey') is not None:
            self.actor_key = m.get('actorKey')
        if m.get('actorSelectionRange') is not None:
            temp_model = ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange()
            self.actor_selection_range = temp_model.from_map(m['actorSelectionRange'])
        if m.get('actorSelectionType') is not None:
            self.actor_selection_type = m.get('actorSelectionType')
        if m.get('actorType') is not None:
            self.actor_type = m.get('actorType')
        if m.get('allowedMulti') is not None:
            self.allowed_multi = m.get('allowedMulti')
        if m.get('approvalMethod') is not None:
            self.approval_method = m.get('approvalMethod')
        if m.get('approvalType') is not None:
            self.approval_type = m.get('approvalType')
        if m.get('required') is not None:
            self.required = m.get('required')
        return self


class ProcessForecastResponseBodyResultWorkflowActivityRules(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        activity_name: str = None,
        activity_type: str = None,
        is_target_select: bool = None,
        prev_activity_id: str = None,
        workflow_actor: ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor = None,
    ):
        self.activity_id = activity_id
        self.activity_name = activity_name
        self.activity_type = activity_type
        self.is_target_select = is_target_select
        self.prev_activity_id = prev_activity_id
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
        if self.activity_name is not None:
            result['activityName'] = self.activity_name
        if self.activity_type is not None:
            result['activityType'] = self.activity_type
        if self.is_target_select is not None:
            result['isTargetSelect'] = self.is_target_select
        if self.prev_activity_id is not None:
            result['prevActivityId'] = self.prev_activity_id
        if self.workflow_actor is not None:
            result['workflowActor'] = self.workflow_actor.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('activityName') is not None:
            self.activity_name = m.get('activityName')
        if m.get('activityType') is not None:
            self.activity_type = m.get('activityType')
        if m.get('isTargetSelect') is not None:
            self.is_target_select = m.get('isTargetSelect')
        if m.get('prevActivityId') is not None:
            self.prev_activity_id = m.get('prevActivityId')
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
        # This parameter is required.
        self.activity_id = activity_id
        # This parameter is required.
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
        is_static_workflow: bool = None,
        process_code: str = None,
        process_id: int = None,
        user_id: str = None,
        workflow_activity_rules: List[ProcessForecastResponseBodyResultWorkflowActivityRules] = None,
        workflow_forecast_nodes: List[ProcessForecastResponseBodyResultWorkflowForecastNodes] = None,
    ):
        # This parameter is required.
        self.is_forecast_success = is_forecast_success
        # This parameter is required.
        self.is_static_workflow = is_static_workflow
        # This parameter is required.
        self.process_code = process_code
        # This parameter is required.
        self.process_id = process_id
        # This parameter is required.
        self.user_id = user_id
        self.workflow_activity_rules = workflow_activity_rules
        # This parameter is required.
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
        if self.is_static_workflow is not None:
            result['isStaticWorkflow'] = self.is_static_workflow
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_id is not None:
            result['processId'] = self.process_id
        if self.user_id is not None:
            result['userId'] = self.user_id
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
        if m.get('isStaticWorkflow') is not None:
            self.is_static_workflow = m.get('isStaticWorkflow')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processId') is not None:
            self.process_id = m.get('processId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
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
        status_code: int = None,
        body: ProcessForecastResponseBody = None,
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
            temp_model = ProcessForecastResponseBody()
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
        app_uuid: str = None,
        form_code: str = None,
        max_results: int = None,
        next_token: str = None,
    ):
        self.app_uuid = app_uuid
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.max_results = max_results
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryAllFormInstancesResponseBodyResultValuesFormInstDataList(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        component_type: str = None,
        extend_value: str = None,
        key: str = None,
        label: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        # This parameter is required.
        self.component_type = component_type
        self.extend_value = extend_value
        # This parameter is required.
        self.key = key
        # This parameter is required.
        self.label = label
        # This parameter is required.
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.extend_value is not None:
            result['extendValue'] = self.extend_value
        if self.key is not None:
            result['key'] = self.key
        if self.label is not None:
            result['label'] = self.label
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('extendValue') is not None:
            self.extend_value = m.get('extendValue')
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class QueryAllFormInstancesResponseBodyResultValues(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        attributes: Dict[str, Any] = None,
        create_timestamp: int = None,
        creator: str = None,
        form_code: str = None,
        form_inst_data_list: List[QueryAllFormInstancesResponseBodyResultValuesFormInstDataList] = None,
        form_instance_id: str = None,
        modifier: str = None,
        modify_timestamp: int = None,
        out_biz_code: str = None,
        out_instance_id: str = None,
        title: str = None,
    ):
        self.app_uuid = app_uuid
        self.attributes = attributes
        # This parameter is required.
        self.create_timestamp = create_timestamp
        # This parameter is required.
        self.creator = creator
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.form_inst_data_list = form_inst_data_list
        # This parameter is required.
        self.form_instance_id = form_instance_id
        # This parameter is required.
        self.modifier = modifier
        self.modify_timestamp = modify_timestamp
        self.out_biz_code = out_biz_code
        self.out_instance_id = out_instance_id
        # This parameter is required.
        self.title = title

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
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.attributes is not None:
            result['attributes'] = self.attributes
        if self.create_timestamp is not None:
            result['createTimestamp'] = self.create_timestamp
        if self.creator is not None:
            result['creator'] = self.creator
        if self.form_code is not None:
            result['formCode'] = self.form_code
        result['formInstDataList'] = []
        if self.form_inst_data_list is not None:
            for k in self.form_inst_data_list:
                result['formInstDataList'].append(k.to_map() if k else None)
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.modifier is not None:
            result['modifier'] = self.modifier
        if self.modify_timestamp is not None:
            result['modifyTimestamp'] = self.modify_timestamp
        if self.out_biz_code is not None:
            result['outBizCode'] = self.out_biz_code
        if self.out_instance_id is not None:
            result['outInstanceId'] = self.out_instance_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('attributes') is not None:
            self.attributes = m.get('attributes')
        if m.get('createTimestamp') is not None:
            self.create_timestamp = m.get('createTimestamp')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        self.form_inst_data_list = []
        if m.get('formInstDataList') is not None:
            for k in m.get('formInstDataList'):
                temp_model = QueryAllFormInstancesResponseBodyResultValuesFormInstDataList()
                self.form_inst_data_list.append(temp_model.from_map(k))
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('modifier') is not None:
            self.modifier = m.get('modifier')
        if m.get('modifyTimestamp') is not None:
            self.modify_timestamp = m.get('modifyTimestamp')
        if m.get('outBizCode') is not None:
            self.out_biz_code = m.get('outBizCode')
        if m.get('outInstanceId') is not None:
            self.out_instance_id = m.get('outInstanceId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryAllFormInstancesResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        max_results: int = None,
        next_token: str = None,
        values: List[QueryAllFormInstancesResponseBodyResultValues] = None,
    ):
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        # This parameter is required.
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['values'] = []
        if self.values is not None:
            for k in self.values:
                result['values'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
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
        # This parameter is required.
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
        status_code: int = None,
        body: QueryAllFormInstancesResponseBody = None,
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
            temp_model = QueryAllFormInstancesResponseBody()
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
        app_uuid: str = None,
        end_time_in_mills: int = None,
        max_results: int = None,
        next_token: str = None,
        process_code: str = None,
        start_time_in_mills: int = None,
    ):
        self.app_uuid = app_uuid
        self.end_time_in_mills = end_time_in_mills
        # This parameter is required.
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.process_code = process_code
        # This parameter is required.
        self.start_time_in_mills = start_time_in_mills

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.end_time_in_mills is not None:
            result['endTimeInMills'] = self.end_time_in_mills
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.start_time_in_mills is not None:
            result['startTimeInMills'] = self.start_time_in_mills
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('endTimeInMills') is not None:
            self.end_time_in_mills = m.get('endTimeInMills')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('startTimeInMills') is not None:
            self.start_time_in_mills = m.get('startTimeInMills')
        return self


class QueryAllProcessInstancesResponseBodyResultListFormComponentValues(TeaModel):
    def __init__(
        self,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.ext_value = ext_value
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        file_size: str = None,
        file_type: str = None,
    ):
        self.file_id = file_id
        self.file_name = file_name
        self.file_size = file_size
        self.file_type = file_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.file_type is not None:
            result['fileType'] = self.file_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        return self


class QueryAllProcessInstancesResponseBodyResultListOperationRecords(TeaModel):
    def __init__(
        self,
        attachments: List[QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments] = None,
        operation_type: str = None,
        remark: str = None,
        result: str = None,
        timestamp: int = None,
        user_id: str = None,
    ):
        self.attachments = attachments
        self.operation_type = operation_type
        self.remark = remark
        self.result = result
        self.timestamp = timestamp
        self.user_id = user_id

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
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.operation_type is not None:
            result['operationType'] = self.operation_type
        if self.remark is not None:
            result['remark'] = self.remark
        if self.result is not None:
            result['result'] = self.result
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('operationType') is not None:
            self.operation_type = m.get('operationType')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryAllProcessInstancesResponseBodyResultListTasks(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        create_timestamp: int = None,
        finish_timestamp: int = None,
        result: str = None,
        status: str = None,
        task_id: int = None,
        user_id: str = None,
    ):
        self.activity_id = activity_id
        self.create_timestamp = create_timestamp
        self.finish_timestamp = finish_timestamp
        self.result = result
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.task_id = task_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.create_timestamp is not None:
            result['createTimestamp'] = self.create_timestamp
        if self.finish_timestamp is not None:
            result['finishTimestamp'] = self.finish_timestamp
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('createTimestamp') is not None:
            self.create_timestamp = m.get('createTimestamp')
        if m.get('finishTimestamp') is not None:
            self.finish_timestamp = m.get('finishTimestamp')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryAllProcessInstancesResponseBodyResultList(TeaModel):
    def __init__(
        self,
        attached_process_instance_ids: str = None,
        business_id: str = None,
        create_time: int = None,
        finish_time: int = None,
        form_component_values: List[QueryAllProcessInstancesResponseBodyResultListFormComponentValues] = None,
        main_process_instance_id: str = None,
        operation_records: List[QueryAllProcessInstancesResponseBodyResultListOperationRecords] = None,
        originator_dept_id: str = None,
        originator_userid: str = None,
        process_instance_id: str = None,
        result: str = None,
        status: str = None,
        tasks: List[QueryAllProcessInstancesResponseBodyResultListTasks] = None,
        title: str = None,
    ):
        # This parameter is required.
        self.attached_process_instance_ids = attached_process_instance_ids
        # This parameter is required.
        self.business_id = business_id
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
        self.finish_time = finish_time
        # This parameter is required.
        self.form_component_values = form_component_values
        # This parameter is required.
        self.main_process_instance_id = main_process_instance_id
        self.operation_records = operation_records
        # This parameter is required.
        self.originator_dept_id = originator_dept_id
        # This parameter is required.
        self.originator_userid = originator_userid
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.result = result
        # This parameter is required.
        self.status = status
        self.tasks = tasks
        # This parameter is required.
        self.title = title

    def validate(self):
        if self.form_component_values:
            for k in self.form_component_values:
                if k:
                    k.validate()
        if self.operation_records:
            for k in self.operation_records:
                if k:
                    k.validate()
        if self.tasks:
            for k in self.tasks:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attached_process_instance_ids is not None:
            result['attachedProcessInstanceIds'] = self.attached_process_instance_ids
        if self.business_id is not None:
            result['businessId'] = self.business_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        result['formComponentValues'] = []
        if self.form_component_values is not None:
            for k in self.form_component_values:
                result['formComponentValues'].append(k.to_map() if k else None)
        if self.main_process_instance_id is not None:
            result['mainProcessInstanceId'] = self.main_process_instance_id
        result['operationRecords'] = []
        if self.operation_records is not None:
            for k in self.operation_records:
                result['operationRecords'].append(k.to_map() if k else None)
        if self.originator_dept_id is not None:
            result['originatorDeptId'] = self.originator_dept_id
        if self.originator_userid is not None:
            result['originatorUserid'] = self.originator_userid
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        result['tasks'] = []
        if self.tasks is not None:
            for k in self.tasks:
                result['tasks'].append(k.to_map() if k else None)
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attachedProcessInstanceIds') is not None:
            self.attached_process_instance_ids = m.get('attachedProcessInstanceIds')
        if m.get('businessId') is not None:
            self.business_id = m.get('businessId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        self.form_component_values = []
        if m.get('formComponentValues') is not None:
            for k in m.get('formComponentValues'):
                temp_model = QueryAllProcessInstancesResponseBodyResultListFormComponentValues()
                self.form_component_values.append(temp_model.from_map(k))
        if m.get('mainProcessInstanceId') is not None:
            self.main_process_instance_id = m.get('mainProcessInstanceId')
        self.operation_records = []
        if m.get('operationRecords') is not None:
            for k in m.get('operationRecords'):
                temp_model = QueryAllProcessInstancesResponseBodyResultListOperationRecords()
                self.operation_records.append(temp_model.from_map(k))
        if m.get('originatorDeptId') is not None:
            self.originator_dept_id = m.get('originatorDeptId')
        if m.get('originatorUserid') is not None:
            self.originator_userid = m.get('originatorUserid')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        self.tasks = []
        if m.get('tasks') is not None:
            for k in m.get('tasks'):
                temp_model = QueryAllProcessInstancesResponseBodyResultListTasks()
                self.tasks.append(temp_model.from_map(k))
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryAllProcessInstancesResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryAllProcessInstancesResponseBodyResultList] = None,
        max_results: int = None,
        next_token: str = None,
    ):
        # This parameter is required.
        self.has_more = has_more
        self.list = list
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryAllProcessInstancesResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryAllProcessInstancesResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryAllProcessInstancesResponseBodyResult = None,
    ):
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
        status_code: int = None,
        body: QueryAllProcessInstancesResponseBody = None,
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
            temp_model = QueryAllProcessInstancesResponseBody()
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
        # This parameter is required.
        self.app_uuid = app_uuid
        # This parameter is required.
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
        app_type: int = None,
        app_uuid: str = None,
        biz_type: str = None,
        content: str = None,
        create_time: int = None,
        creator: str = None,
        form_code: str = None,
        form_uuid: str = None,
        memo: str = None,
        modifed_time: int = None,
        name: str = None,
        owner_id: str = None,
        status: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.app_uuid = app_uuid
        self.biz_type = biz_type
        # This parameter is required.
        self.content = content
        self.create_time = create_time
        self.creator = creator
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.form_uuid = form_uuid
        self.memo = memo
        self.modifed_time = modifed_time
        # This parameter is required.
        self.name = name
        self.owner_id = owner_id
        # This parameter is required.
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.content is not None:
            result['content'] = self.content
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.memo is not None:
            result['memo'] = self.memo
        if self.modifed_time is not None:
            result['modifedTime'] = self.modifed_time
        if self.name is not None:
            result['name'] = self.name
        if self.owner_id is not None:
            result['ownerId'] = self.owner_id
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        if m.get('modifedTime') is not None:
            self.modifed_time = m.get('modifedTime')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('ownerId') is not None:
            self.owner_id = m.get('ownerId')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryFormByBizTypeResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryFormByBizTypeResponseBodyResult] = None,
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
                temp_model = QueryFormByBizTypeResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryFormByBizTypeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryFormByBizTypeResponseBody = None,
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
            temp_model = QueryFormByBizTypeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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
        app_uuid: str = None,
        form_code: str = None,
        form_instance_id: str = None,
    ):
        self.app_uuid = app_uuid
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.form_instance_id = form_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        return self


class QueryFormInstanceResponseBodyFormInstDataList(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        component_type: str = None,
        extend_value: str = None,
        key: str = None,
        label: str = None,
        value: str = None,
    ):
        # This parameter is required.
        self.biz_alias = biz_alias
        # This parameter is required.
        self.component_type = component_type
        # This parameter is required.
        self.extend_value = extend_value
        # This parameter is required.
        self.key = key
        # This parameter is required.
        self.label = label
        # This parameter is required.
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.extend_value is not None:
            result['extendValue'] = self.extend_value
        if self.key is not None:
            result['key'] = self.key
        if self.label is not None:
            result['label'] = self.label
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('extendValue') is not None:
            self.extend_value = m.get('extendValue')
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class QueryFormInstanceResponseBody(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        attributes: Dict[str, Any] = None,
        create_timestamp: int = None,
        creator: str = None,
        form_code: str = None,
        form_inst_data_list: List[QueryFormInstanceResponseBodyFormInstDataList] = None,
        form_instance_id: str = None,
        modifier: str = None,
        modify_timestamp: int = None,
        out_biz_code: str = None,
        out_instance_id: str = None,
        title: str = None,
    ):
        self.app_uuid = app_uuid
        self.attributes = attributes
        self.create_timestamp = create_timestamp
        # This parameter is required.
        self.creator = creator
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.form_inst_data_list = form_inst_data_list
        # This parameter is required.
        self.form_instance_id = form_instance_id
        self.modifier = modifier
        self.modify_timestamp = modify_timestamp
        self.out_biz_code = out_biz_code
        self.out_instance_id = out_instance_id
        self.title = title

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
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.attributes is not None:
            result['attributes'] = self.attributes
        if self.create_timestamp is not None:
            result['createTimestamp'] = self.create_timestamp
        if self.creator is not None:
            result['creator'] = self.creator
        if self.form_code is not None:
            result['formCode'] = self.form_code
        result['formInstDataList'] = []
        if self.form_inst_data_list is not None:
            for k in self.form_inst_data_list:
                result['formInstDataList'].append(k.to_map() if k else None)
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.modifier is not None:
            result['modifier'] = self.modifier
        if self.modify_timestamp is not None:
            result['modifyTimestamp'] = self.modify_timestamp
        if self.out_biz_code is not None:
            result['outBizCode'] = self.out_biz_code
        if self.out_instance_id is not None:
            result['outInstanceId'] = self.out_instance_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('attributes') is not None:
            self.attributes = m.get('attributes')
        if m.get('createTimestamp') is not None:
            self.create_timestamp = m.get('createTimestamp')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        self.form_inst_data_list = []
        if m.get('formInstDataList') is not None:
            for k in m.get('formInstDataList'):
                temp_model = QueryFormInstanceResponseBodyFormInstDataList()
                self.form_inst_data_list.append(temp_model.from_map(k))
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('modifier') is not None:
            self.modifier = m.get('modifier')
        if m.get('modifyTimestamp') is not None:
            self.modify_timestamp = m.get('modifyTimestamp')
        if m.get('outBizCode') is not None:
            self.out_biz_code = m.get('outBizCode')
        if m.get('outInstanceId') is not None:
            self.out_instance_id = m.get('outInstanceId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryFormInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryFormInstanceResponseBody = None,
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
            temp_model = QueryFormInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryIntegratedTodoTaskHeaders(TeaModel):
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


class QueryIntegratedTodoTaskRequest(TeaModel):
    def __init__(
        self,
        create_before: int = None,
        page_number: int = None,
        page_size: int = None,
        user_id: str = None,
    ):
        self.create_before = create_before
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_before is not None:
            result['createBefore'] = self.create_before
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createBefore') is not None:
            self.create_before = m.get('createBefore')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryIntegratedTodoTaskResponseBodyResultList(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        create_time: str = None,
        finish_time: str = None,
        process_instance_id: str = None,
        result: str = None,
        status: str = None,
        task_id: int = None,
        user_id: str = None,
    ):
        self.activity_id = activity_id
        self.create_time = create_time
        self.finish_time = finish_time
        self.process_instance_id = process_instance_id
        self.result = result
        self.status = status
        self.task_id = task_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryIntegratedTodoTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryIntegratedTodoTaskResponseBodyResultList] = None,
    ):
        self.has_more = has_more
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryIntegratedTodoTaskResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryIntegratedTodoTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryIntegratedTodoTaskResponseBodyResult = None,
    ):
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
            temp_model = QueryIntegratedTodoTaskResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QueryIntegratedTodoTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryIntegratedTodoTaskResponseBody = None,
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
            temp_model = QueryIntegratedTodoTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryProcessByBizCategoryIdHeaders(TeaModel):
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


class QueryProcessByBizCategoryIdRequest(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.biz_type = biz_type
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryProcessByBizCategoryIdResponseBodyResult(TeaModel):
    def __init__(
        self,
        description: str = None,
        name: str = None,
        process_code: str = None,
        status: str = None,
    ):
        self.description = description
        self.name = name
        self.process_code = process_code
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryProcessByBizCategoryIdResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryProcessByBizCategoryIdResponseBodyResult] = None,
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
                temp_model = QueryProcessByBizCategoryIdResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryProcessByBizCategoryIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryProcessByBizCategoryIdResponseBody = None,
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
            temp_model = QueryProcessByBizCategoryIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySchemaAndProcessHeaders(TeaModel):
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


class QuerySchemaAndProcessRequest(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        process_code: str = None,
    ):
        self.app_uuid = app_uuid
        # This parameter is required.
        self.process_code = process_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class QuerySchemaAndProcessResponseBodyResult(TeaModel):
    def __init__(
        self,
        app_type: int = None,
        content: str = None,
        hand_sign_enable: str = None,
        icon_url: str = None,
        name: str = None,
        process_config: str = None,
    ):
        self.app_type = app_type
        self.content = content
        self.hand_sign_enable = hand_sign_enable
        self.icon_url = icon_url
        self.name = name
        self.process_config = process_config

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.content is not None:
            result['content'] = self.content
        if self.hand_sign_enable is not None:
            result['handSignEnable'] = self.hand_sign_enable
        if self.icon_url is not None:
            result['iconUrl'] = self.icon_url
        if self.name is not None:
            result['name'] = self.name
        if self.process_config is not None:
            result['processConfig'] = self.process_config
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('handSignEnable') is not None:
            self.hand_sign_enable = m.get('handSignEnable')
        if m.get('iconUrl') is not None:
            self.icon_url = m.get('iconUrl')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('processConfig') is not None:
            self.process_config = m.get('processConfig')
        return self


class QuerySchemaAndProcessResponseBody(TeaModel):
    def __init__(
        self,
        result: QuerySchemaAndProcessResponseBodyResult = None,
    ):
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
            temp_model = QuerySchemaAndProcessResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QuerySchemaAndProcessResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QuerySchemaAndProcessResponseBody = None,
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
            temp_model = QuerySchemaAndProcessResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySchemaByProcessCodeHeaders(TeaModel):
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


class QuerySchemaByProcessCodeRequest(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        process_code: str = None,
    ):
        self.app_uuid = app_uuid
        # This parameter is required.
        self.process_code = process_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        id: str = None,
        label: str = None,
        options: List[str] = None,
        required: bool = None,
    ):
        self.biz_alias = biz_alias
        # This parameter is required.
        self.id = id
        self.label = label
        self.options = options
        self.required = required

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.id is not None:
            result['id'] = self.id
        if self.label is not None:
            result['label'] = self.label
        if self.options is not None:
            result['options'] = self.options
        if self.required is not None:
            result['required'] = self.required
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('options') is not None:
            self.options = m.get('options')
        if m.get('required') is not None:
            self.required = m.get('required')
        return self


class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren(TeaModel):
    def __init__(
        self,
        component_name: str = None,
        props: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps = None,
    ):
        # This parameter is required.
        self.component_name = component_name
        # This parameter is required.
        self.props = props

    def validate(self):
        if self.props:
            self.props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_name is not None:
            result['componentName'] = self.component_name
        if self.props is not None:
            result['props'] = self.props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        if m.get('props') is not None:
            temp_model = QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps()
            self.props = temp_model.from_map(m['props'])
        return self


class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets(TeaModel):
    def __init__(
        self,
        behavior: str = None,
        field_id: str = None,
    ):
        self.behavior = behavior
        self.field_id = field_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.behavior is not None:
            result['behavior'] = self.behavior
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('behavior') is not None:
            self.behavior = m.get('behavior')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        return self


class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage(TeaModel):
    def __init__(
        self,
        targets: List[QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets] = None,
        value: str = None,
    ):
        self.targets = targets
        self.value = value

    def validate(self):
        if self.targets:
            for k in self.targets:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['targets'] = []
        if self.targets is not None:
            for k in self.targets:
                result['targets'].append(k.to_map() if k else None)
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.targets = []
        if m.get('targets') is not None:
            for k in m.get('targets'):
                temp_model = QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets()
                self.targets.append(temp_model.from_map(k))
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions(TeaModel):
    def __init__(
        self,
        value: str = None,
    ):
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush(TeaModel):
    def __init__(
        self,
        attendance_rule: int = None,
        push_switch: int = None,
        push_tag: str = None,
    ):
        self.attendance_rule = attendance_rule
        self.push_switch = push_switch
        self.push_tag = push_tag

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attendance_rule is not None:
            result['attendanceRule'] = self.attendance_rule
        if self.push_switch is not None:
            result['pushSwitch'] = self.push_switch
        if self.push_tag is not None:
            result['pushTag'] = self.push_tag
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attendanceRule') is not None:
            self.attendance_rule = m.get('attendanceRule')
        if m.get('pushSwitch') is not None:
            self.push_switch = m.get('pushSwitch')
        if m.get('pushTag') is not None:
            self.push_tag = m.get('pushTag')
        return self


class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField(TeaModel):
    def __init__(
        self,
        id: str = None,
        label: str = None,
        unit: str = None,
        upper: bool = None,
    ):
        self.id = id
        self.label = label
        self.unit = unit
        self.upper = upper

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.label is not None:
            result['label'] = self.label
        if self.unit is not None:
            result['unit'] = self.unit
        if self.upper is not None:
            result['upper'] = self.upper
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        return self


class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps(TeaModel):
    def __init__(
        self,
        action_name: str = None,
        align: str = None,
        app_id: int = None,
        async_condition: bool = None,
        attend_type_label: str = None,
        behavior_linkage: List[QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage] = None,
        biz_alias: str = None,
        biz_type: str = None,
        child_field_visible: Dict[str, bool] = None,
        choice: int = None,
        common_biz_type: str = None,
        disabled: bool = None,
        duration: bool = None,
        duration_label: str = None,
        e_sign: bool = None,
        extract: bool = None,
        fields_info: str = None,
        format: str = None,
        formula: str = None,
        hidden: bool = None,
        hidden_in_approval_detail: bool = None,
        hide_label: bool = None,
        holiday_options: List[Dict[str, str]] = None,
        id: str = None,
        label: str = None,
        label_editable_freeze: bool = None,
        link: str = None,
        main_title: str = None,
        not_print: str = None,
        not_upper: str = None,
        obj_options: List[QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions] = None,
        options: List[str] = None,
        pay_enable: bool = None,
        placeholder: str = None,
        push: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush = None,
        push_to_attendance: bool = None,
        push_to_calendar: int = None,
        required: bool = None,
        required_editable_freeze: bool = None,
        show_attend_options: bool = None,
        staff_status_enabled: bool = None,
        stat_field: List[QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField] = None,
        table_view_mode: str = None,
        unit: str = None,
        use_calendar: bool = None,
        vertical_print: bool = None,
    ):
        self.action_name = action_name
        self.align = align
        self.app_id = app_id
        self.async_condition = async_condition
        self.attend_type_label = attend_type_label
        self.behavior_linkage = behavior_linkage
        self.biz_alias = biz_alias
        self.biz_type = biz_type
        self.child_field_visible = child_field_visible
        self.choice = choice
        self.common_biz_type = common_biz_type
        self.disabled = disabled
        self.duration = duration
        self.duration_label = duration_label
        self.e_sign = e_sign
        self.extract = extract
        self.fields_info = fields_info
        self.format = format
        self.formula = formula
        self.hidden = hidden
        self.hidden_in_approval_detail = hidden_in_approval_detail
        self.hide_label = hide_label
        self.holiday_options = holiday_options
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.label = label
        self.label_editable_freeze = label_editable_freeze
        self.link = link
        self.main_title = main_title
        self.not_print = not_print
        self.not_upper = not_upper
        self.obj_options = obj_options
        self.options = options
        self.pay_enable = pay_enable
        self.placeholder = placeholder
        self.push = push
        self.push_to_attendance = push_to_attendance
        self.push_to_calendar = push_to_calendar
        self.required = required
        self.required_editable_freeze = required_editable_freeze
        self.show_attend_options = show_attend_options
        self.staff_status_enabled = staff_status_enabled
        self.stat_field = stat_field
        self.table_view_mode = table_view_mode
        self.unit = unit
        self.use_calendar = use_calendar
        self.vertical_print = vertical_print

    def validate(self):
        if self.behavior_linkage:
            for k in self.behavior_linkage:
                if k:
                    k.validate()
        if self.obj_options:
            for k in self.obj_options:
                if k:
                    k.validate()
        if self.push:
            self.push.validate()
        if self.stat_field:
            for k in self.stat_field:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_name is not None:
            result['actionName'] = self.action_name
        if self.align is not None:
            result['align'] = self.align
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.async_condition is not None:
            result['asyncCondition'] = self.async_condition
        if self.attend_type_label is not None:
            result['attendTypeLabel'] = self.attend_type_label
        result['behaviorLinkage'] = []
        if self.behavior_linkage is not None:
            for k in self.behavior_linkage:
                result['behaviorLinkage'].append(k.to_map() if k else None)
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.child_field_visible is not None:
            result['childFieldVisible'] = self.child_field_visible
        if self.choice is not None:
            result['choice'] = self.choice
        if self.common_biz_type is not None:
            result['commonBizType'] = self.common_biz_type
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.duration is not None:
            result['duration'] = self.duration
        if self.duration_label is not None:
            result['durationLabel'] = self.duration_label
        if self.e_sign is not None:
            result['eSign'] = self.e_sign
        if self.extract is not None:
            result['extract'] = self.extract
        if self.fields_info is not None:
            result['fieldsInfo'] = self.fields_info
        if self.format is not None:
            result['format'] = self.format
        if self.formula is not None:
            result['formula'] = self.formula
        if self.hidden is not None:
            result['hidden'] = self.hidden
        if self.hidden_in_approval_detail is not None:
            result['hiddenInApprovalDetail'] = self.hidden_in_approval_detail
        if self.hide_label is not None:
            result['hideLabel'] = self.hide_label
        if self.holiday_options is not None:
            result['holidayOptions'] = self.holiday_options
        if self.id is not None:
            result['id'] = self.id
        if self.label is not None:
            result['label'] = self.label
        if self.label_editable_freeze is not None:
            result['labelEditableFreeze'] = self.label_editable_freeze
        if self.link is not None:
            result['link'] = self.link
        if self.main_title is not None:
            result['mainTitle'] = self.main_title
        if self.not_print is not None:
            result['notPrint'] = self.not_print
        if self.not_upper is not None:
            result['notUpper'] = self.not_upper
        result['objOptions'] = []
        if self.obj_options is not None:
            for k in self.obj_options:
                result['objOptions'].append(k.to_map() if k else None)
        if self.options is not None:
            result['options'] = self.options
        if self.pay_enable is not None:
            result['payEnable'] = self.pay_enable
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.push is not None:
            result['push'] = self.push.to_map()
        if self.push_to_attendance is not None:
            result['pushToAttendance'] = self.push_to_attendance
        if self.push_to_calendar is not None:
            result['pushToCalendar'] = self.push_to_calendar
        if self.required is not None:
            result['required'] = self.required
        if self.required_editable_freeze is not None:
            result['requiredEditableFreeze'] = self.required_editable_freeze
        if self.show_attend_options is not None:
            result['showAttendOptions'] = self.show_attend_options
        if self.staff_status_enabled is not None:
            result['staffStatusEnabled'] = self.staff_status_enabled
        result['statField'] = []
        if self.stat_field is not None:
            for k in self.stat_field:
                result['statField'].append(k.to_map() if k else None)
        if self.table_view_mode is not None:
            result['tableViewMode'] = self.table_view_mode
        if self.unit is not None:
            result['unit'] = self.unit
        if self.use_calendar is not None:
            result['useCalendar'] = self.use_calendar
        if self.vertical_print is not None:
            result['verticalPrint'] = self.vertical_print
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionName') is not None:
            self.action_name = m.get('actionName')
        if m.get('align') is not None:
            self.align = m.get('align')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('asyncCondition') is not None:
            self.async_condition = m.get('asyncCondition')
        if m.get('attendTypeLabel') is not None:
            self.attend_type_label = m.get('attendTypeLabel')
        self.behavior_linkage = []
        if m.get('behaviorLinkage') is not None:
            for k in m.get('behaviorLinkage'):
                temp_model = QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage()
                self.behavior_linkage.append(temp_model.from_map(k))
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('childFieldVisible') is not None:
            self.child_field_visible = m.get('childFieldVisible')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('commonBizType') is not None:
            self.common_biz_type = m.get('commonBizType')
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('durationLabel') is not None:
            self.duration_label = m.get('durationLabel')
        if m.get('eSign') is not None:
            self.e_sign = m.get('eSign')
        if m.get('extract') is not None:
            self.extract = m.get('extract')
        if m.get('fieldsInfo') is not None:
            self.fields_info = m.get('fieldsInfo')
        if m.get('format') is not None:
            self.format = m.get('format')
        if m.get('formula') is not None:
            self.formula = m.get('formula')
        if m.get('hidden') is not None:
            self.hidden = m.get('hidden')
        if m.get('hiddenInApprovalDetail') is not None:
            self.hidden_in_approval_detail = m.get('hiddenInApprovalDetail')
        if m.get('hideLabel') is not None:
            self.hide_label = m.get('hideLabel')
        if m.get('holidayOptions') is not None:
            self.holiday_options = m.get('holidayOptions')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('labelEditableFreeze') is not None:
            self.label_editable_freeze = m.get('labelEditableFreeze')
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('mainTitle') is not None:
            self.main_title = m.get('mainTitle')
        if m.get('notPrint') is not None:
            self.not_print = m.get('notPrint')
        if m.get('notUpper') is not None:
            self.not_upper = m.get('notUpper')
        self.obj_options = []
        if m.get('objOptions') is not None:
            for k in m.get('objOptions'):
                temp_model = QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions()
                self.obj_options.append(temp_model.from_map(k))
        if m.get('options') is not None:
            self.options = m.get('options')
        if m.get('payEnable') is not None:
            self.pay_enable = m.get('payEnable')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('push') is not None:
            temp_model = QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush()
            self.push = temp_model.from_map(m['push'])
        if m.get('pushToAttendance') is not None:
            self.push_to_attendance = m.get('pushToAttendance')
        if m.get('pushToCalendar') is not None:
            self.push_to_calendar = m.get('pushToCalendar')
        if m.get('required') is not None:
            self.required = m.get('required')
        if m.get('requiredEditableFreeze') is not None:
            self.required_editable_freeze = m.get('requiredEditableFreeze')
        if m.get('showAttendOptions') is not None:
            self.show_attend_options = m.get('showAttendOptions')
        if m.get('staffStatusEnabled') is not None:
            self.staff_status_enabled = m.get('staffStatusEnabled')
        self.stat_field = []
        if m.get('statField') is not None:
            for k in m.get('statField'):
                temp_model = QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField()
                self.stat_field.append(temp_model.from_map(k))
        if m.get('tableViewMode') is not None:
            self.table_view_mode = m.get('tableViewMode')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('useCalendar') is not None:
            self.use_calendar = m.get('useCalendar')
        if m.get('verticalPrint') is not None:
            self.vertical_print = m.get('verticalPrint')
        return self


class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems(TeaModel):
    def __init__(
        self,
        children: List[QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren] = None,
        component_name: str = None,
        props: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps = None,
    ):
        self.children = children
        # This parameter is required.
        self.component_name = component_name
        # This parameter is required.
        self.props = props

    def validate(self):
        if self.children:
            for k in self.children:
                if k:
                    k.validate()
        if self.props:
            self.props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['children'] = []
        if self.children is not None:
            for k in self.children:
                result['children'].append(k.to_map() if k else None)
        if self.component_name is not None:
            result['componentName'] = self.component_name
        if self.props is not None:
            result['props'] = self.props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.children = []
        if m.get('children') is not None:
            for k in m.get('children'):
                temp_model = QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren()
                self.children.append(temp_model.from_map(k))
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        if m.get('props') is not None:
            temp_model = QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps()
            self.props = temp_model.from_map(m['props'])
        return self


class QuerySchemaByProcessCodeResponseBodyResultSchemaContent(TeaModel):
    def __init__(
        self,
        icon: str = None,
        items: List[QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems] = None,
        title: str = None,
    ):
        self.icon = icon
        # This parameter is required.
        self.items = items
        # This parameter is required.
        self.title = title

    def validate(self):
        if self.items:
            for k in self.items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems()
                self.items.append(temp_model.from_map(k))
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QuerySchemaByProcessCodeResponseBodyResult(TeaModel):
    def __init__(
        self,
        app_type: int = None,
        app_uuid: str = None,
        biz_type: str = None,
        creator_user_id: str = None,
        custom_setting: str = None,
        engine_type: int = None,
        form_code: str = None,
        form_uuid: str = None,
        gmt_create: str = None,
        gmt_modified: str = None,
        icon: str = None,
        list_order: int = None,
        memo: str = None,
        name: str = None,
        owner_id_type: str = None,
        proc_type: str = None,
        schema_content: QuerySchemaByProcessCodeResponseBodyResultSchemaContent = None,
        status: str = None,
        visible_range: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.app_uuid = app_uuid
        self.biz_type = biz_type
        # This parameter is required.
        self.creator_user_id = creator_user_id
        self.custom_setting = custom_setting
        self.engine_type = engine_type
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.form_uuid = form_uuid
        # This parameter is required.
        self.gmt_create = gmt_create
        # This parameter is required.
        self.gmt_modified = gmt_modified
        self.icon = icon
        self.list_order = list_order
        self.memo = memo
        self.name = name
        # This parameter is required.
        self.owner_id_type = owner_id_type
        self.proc_type = proc_type
        # This parameter is required.
        self.schema_content = schema_content
        self.status = status
        self.visible_range = visible_range

    def validate(self):
        if self.schema_content:
            self.schema_content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.custom_setting is not None:
            result['customSetting'] = self.custom_setting
        if self.engine_type is not None:
            result['engineType'] = self.engine_type
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.icon is not None:
            result['icon'] = self.icon
        if self.list_order is not None:
            result['listOrder'] = self.list_order
        if self.memo is not None:
            result['memo'] = self.memo
        if self.name is not None:
            result['name'] = self.name
        if self.owner_id_type is not None:
            result['ownerIdType'] = self.owner_id_type
        if self.proc_type is not None:
            result['procType'] = self.proc_type
        if self.schema_content is not None:
            result['schemaContent'] = self.schema_content.to_map()
        if self.status is not None:
            result['status'] = self.status
        if self.visible_range is not None:
            result['visibleRange'] = self.visible_range
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('customSetting') is not None:
            self.custom_setting = m.get('customSetting')
        if m.get('engineType') is not None:
            self.engine_type = m.get('engineType')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('listOrder') is not None:
            self.list_order = m.get('listOrder')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('ownerIdType') is not None:
            self.owner_id_type = m.get('ownerIdType')
        if m.get('procType') is not None:
            self.proc_type = m.get('procType')
        if m.get('schemaContent') is not None:
            temp_model = QuerySchemaByProcessCodeResponseBodyResultSchemaContent()
            self.schema_content = temp_model.from_map(m['schemaContent'])
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('visibleRange') is not None:
            self.visible_range = m.get('visibleRange')
        return self


class QuerySchemaByProcessCodeResponseBody(TeaModel):
    def __init__(
        self,
        result: QuerySchemaByProcessCodeResponseBodyResult = None,
    ):
        # This parameter is required.
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
            temp_model = QuerySchemaByProcessCodeResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QuerySchemaByProcessCodeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QuerySchemaByProcessCodeResponseBody = None,
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
            temp_model = QuerySchemaByProcessCodeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RedirectWorkflowTaskHeaders(TeaModel):
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


class RedirectWorkflowTaskRequestFileAttachments(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        file_size: str = None,
        file_type: str = None,
        space_id: str = None,
    ):
        self.file_id = file_id
        self.file_name = file_name
        self.file_size = file_size
        self.file_type = file_type
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class RedirectWorkflowTaskRequestFile(TeaModel):
    def __init__(
        self,
        attachments: List[RedirectWorkflowTaskRequestFileAttachments] = None,
        photos: List[str] = None,
    ):
        self.attachments = attachments
        self.photos = photos

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
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.photos is not None:
            result['photos'] = self.photos
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = RedirectWorkflowTaskRequestFileAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('photos') is not None:
            self.photos = m.get('photos')
        return self


class RedirectWorkflowTaskRequest(TeaModel):
    def __init__(
        self,
        action_name: str = None,
        file: RedirectWorkflowTaskRequestFile = None,
        operate_user_id: str = None,
        remark: str = None,
        task_id: int = None,
        to_user_id: str = None,
    ):
        self.action_name = action_name
        self.file = file
        # This parameter is required.
        self.operate_user_id = operate_user_id
        self.remark = remark
        # This parameter is required.
        self.task_id = task_id
        # This parameter is required.
        self.to_user_id = to_user_id

    def validate(self):
        if self.file:
            self.file.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_name is not None:
            result['actionName'] = self.action_name
        if self.file is not None:
            result['file'] = self.file.to_map()
        if self.operate_user_id is not None:
            result['operateUserId'] = self.operate_user_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.to_user_id is not None:
            result['toUserId'] = self.to_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionName') is not None:
            self.action_name = m.get('actionName')
        if m.get('file') is not None:
            temp_model = RedirectWorkflowTaskRequestFile()
            self.file = temp_model.from_map(m['file'])
        if m.get('operateUserId') is not None:
            self.operate_user_id = m.get('operateUserId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('toUserId') is not None:
            self.to_user_id = m.get('toUserId')
        return self


class RedirectWorkflowTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class RedirectWorkflowTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RedirectWorkflowTaskResponseBody = None,
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
            temp_model = RedirectWorkflowTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveIntegratedInstanceHeaders(TeaModel):
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


class SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback(TeaModel):
    def __init__(
        self,
        api_key: str = None,
        app_uuid: str = None,
        version: str = None,
    ):
        self.api_key = api_key
        self.app_uuid = app_uuid
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_key is not None:
            result['apiKey'] = self.api_key
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiKey') is not None:
            self.api_key = m.get('apiKey')
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class SaveIntegratedInstanceRequestFeatureConfigFeatures(TeaModel):
    def __init__(
        self,
        callback: SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback = None,
        config: str = None,
        mobile_url: str = None,
        name: str = None,
        pc_url: str = None,
        run_type: str = None,
    ):
        self.callback = callback
        self.config = config
        self.mobile_url = mobile_url
        self.name = name
        self.pc_url = pc_url
        self.run_type = run_type

    def validate(self):
        if self.callback:
            self.callback.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback is not None:
            result['callback'] = self.callback.to_map()
        if self.config is not None:
            result['config'] = self.config
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        if self.name is not None:
            result['name'] = self.name
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.run_type is not None:
            result['runType'] = self.run_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callback') is not None:
            temp_model = SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback()
            self.callback = temp_model.from_map(m['callback'])
        if m.get('config') is not None:
            self.config = m.get('config')
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('runType') is not None:
            self.run_type = m.get('runType')
        return self


class SaveIntegratedInstanceRequestFeatureConfig(TeaModel):
    def __init__(
        self,
        features: List[SaveIntegratedInstanceRequestFeatureConfigFeatures] = None,
    ):
        self.features = features

    def validate(self):
        if self.features:
            for k in self.features:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['features'] = []
        if self.features is not None:
            for k in self.features:
                result['features'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.features = []
        if m.get('features') is not None:
            for k in m.get('features'):
                temp_model = SaveIntegratedInstanceRequestFeatureConfigFeatures()
                self.features.append(temp_model.from_map(k))
        return self


class SaveIntegratedInstanceRequestFormComponentValueList(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        component_type: str = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.component_type = component_type
        self.ext_value = ext_value
        self.id = id
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class SaveIntegratedInstanceRequestNotifiers(TeaModel):
    def __init__(
        self,
        position: str = None,
        userid: str = None,
    ):
        self.position = position
        self.userid = userid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.position is not None:
            result['position'] = self.position
        if self.userid is not None:
            result['userid'] = self.userid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('position') is not None:
            self.position = m.get('position')
        if m.get('userid') is not None:
            self.userid = m.get('userid')
        return self


class SaveIntegratedInstanceRequest(TeaModel):
    def __init__(
        self,
        biz_data: str = None,
        feature_config: SaveIntegratedInstanceRequestFeatureConfig = None,
        form_component_value_list: List[SaveIntegratedInstanceRequestFormComponentValueList] = None,
        notifiers: List[SaveIntegratedInstanceRequestNotifiers] = None,
        originator_user_id: str = None,
        process_code: str = None,
        title: str = None,
        url: str = None,
    ):
        self.biz_data = biz_data
        self.feature_config = feature_config
        self.form_component_value_list = form_component_value_list
        self.notifiers = notifiers
        # This parameter is required.
        self.originator_user_id = originator_user_id
        # This parameter is required.
        self.process_code = process_code
        self.title = title
        # This parameter is required.
        self.url = url

    def validate(self):
        if self.feature_config:
            self.feature_config.validate()
        if self.form_component_value_list:
            for k in self.form_component_value_list:
                if k:
                    k.validate()
        if self.notifiers:
            for k in self.notifiers:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_data is not None:
            result['bizData'] = self.biz_data
        if self.feature_config is not None:
            result['featureConfig'] = self.feature_config.to_map()
        result['formComponentValueList'] = []
        if self.form_component_value_list is not None:
            for k in self.form_component_value_list:
                result['formComponentValueList'].append(k.to_map() if k else None)
        result['notifiers'] = []
        if self.notifiers is not None:
            for k in self.notifiers:
                result['notifiers'].append(k.to_map() if k else None)
        if self.originator_user_id is not None:
            result['originatorUserId'] = self.originator_user_id
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.title is not None:
            result['title'] = self.title
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizData') is not None:
            self.biz_data = m.get('bizData')
        if m.get('featureConfig') is not None:
            temp_model = SaveIntegratedInstanceRequestFeatureConfig()
            self.feature_config = temp_model.from_map(m['featureConfig'])
        self.form_component_value_list = []
        if m.get('formComponentValueList') is not None:
            for k in m.get('formComponentValueList'):
                temp_model = SaveIntegratedInstanceRequestFormComponentValueList()
                self.form_component_value_list.append(temp_model.from_map(k))
        self.notifiers = []
        if m.get('notifiers') is not None:
            for k in m.get('notifiers'):
                temp_model = SaveIntegratedInstanceRequestNotifiers()
                self.notifiers.append(temp_model.from_map(k))
        if m.get('originatorUserId') is not None:
            self.originator_user_id = m.get('originatorUserId')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class SaveIntegratedInstanceResponseBodyResult(TeaModel):
    def __init__(
        self,
        process_instance_id: str = None,
    ):
        self.process_instance_id = process_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        return self


class SaveIntegratedInstanceResponseBody(TeaModel):
    def __init__(
        self,
        result: SaveIntegratedInstanceResponseBodyResult = None,
    ):
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
            temp_model = SaveIntegratedInstanceResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SaveIntegratedInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SaveIntegratedInstanceResponseBody = None,
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
            temp_model = SaveIntegratedInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveProcessHeaders(TeaModel):
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


class SaveProcessRequestProcessFeatureConfigFeaturesCallback(TeaModel):
    def __init__(
        self,
        api_key: str = None,
        app_uuid: str = None,
        version: str = None,
    ):
        self.api_key = api_key
        self.app_uuid = app_uuid
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_key is not None:
            result['apiKey'] = self.api_key
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiKey') is not None:
            self.api_key = m.get('apiKey')
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class SaveProcessRequestProcessFeatureConfigFeatures(TeaModel):
    def __init__(
        self,
        callback: SaveProcessRequestProcessFeatureConfigFeaturesCallback = None,
        config: str = None,
        mobile_url: str = None,
        name: str = None,
        pc_url: str = None,
        run_type: str = None,
    ):
        self.callback = callback
        self.config = config
        self.mobile_url = mobile_url
        self.name = name
        self.pc_url = pc_url
        self.run_type = run_type

    def validate(self):
        if self.callback:
            self.callback.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback is not None:
            result['callback'] = self.callback.to_map()
        if self.config is not None:
            result['config'] = self.config
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        if self.name is not None:
            result['name'] = self.name
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.run_type is not None:
            result['runType'] = self.run_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callback') is not None:
            temp_model = SaveProcessRequestProcessFeatureConfigFeaturesCallback()
            self.callback = temp_model.from_map(m['callback'])
        if m.get('config') is not None:
            self.config = m.get('config')
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('runType') is not None:
            self.run_type = m.get('runType')
        return self


class SaveProcessRequestProcessFeatureConfig(TeaModel):
    def __init__(
        self,
        features: List[SaveProcessRequestProcessFeatureConfigFeatures] = None,
    ):
        self.features = features

    def validate(self):
        if self.features:
            for k in self.features:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['features'] = []
        if self.features is not None:
            for k in self.features:
                result['features'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.features = []
        if m.get('features') is not None:
            for k in m.get('features'):
                temp_model = SaveProcessRequestProcessFeatureConfigFeatures()
                self.features.append(temp_model.from_map(k))
        return self


class SaveProcessRequestTemplateConfig(TeaModel):
    def __init__(
        self,
        create_instance_mobile_url: str = None,
        create_instance_pc_url: str = None,
        disable_send_card: bool = None,
        hidden: bool = None,
        template_edit_url: str = None,
    ):
        self.create_instance_mobile_url = create_instance_mobile_url
        self.create_instance_pc_url = create_instance_pc_url
        self.disable_send_card = disable_send_card
        self.hidden = hidden
        self.template_edit_url = template_edit_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_instance_mobile_url is not None:
            result['createInstanceMobileUrl'] = self.create_instance_mobile_url
        if self.create_instance_pc_url is not None:
            result['createInstancePcUrl'] = self.create_instance_pc_url
        if self.disable_send_card is not None:
            result['disableSendCard'] = self.disable_send_card
        if self.hidden is not None:
            result['hidden'] = self.hidden
        if self.template_edit_url is not None:
            result['templateEditUrl'] = self.template_edit_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createInstanceMobileUrl') is not None:
            self.create_instance_mobile_url = m.get('createInstanceMobileUrl')
        if m.get('createInstancePcUrl') is not None:
            self.create_instance_pc_url = m.get('createInstancePcUrl')
        if m.get('disableSendCard') is not None:
            self.disable_send_card = m.get('disableSendCard')
        if m.get('hidden') is not None:
            self.hidden = m.get('hidden')
        if m.get('templateEditUrl') is not None:
            self.template_edit_url = m.get('templateEditUrl')
        return self


class SaveProcessRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        form_components: List[FormComponent] = None,
        name: str = None,
        process_code: str = None,
        process_feature_config: SaveProcessRequestProcessFeatureConfig = None,
        template_config: SaveProcessRequestTemplateConfig = None,
    ):
        self.description = description
        # This parameter is required.
        self.form_components = form_components
        # This parameter is required.
        self.name = name
        self.process_code = process_code
        self.process_feature_config = process_feature_config
        self.template_config = template_config

    def validate(self):
        if self.form_components:
            for k in self.form_components:
                if k:
                    k.validate()
        if self.process_feature_config:
            self.process_feature_config.validate()
        if self.template_config:
            self.template_config.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        result['formComponents'] = []
        if self.form_components is not None:
            for k in self.form_components:
                result['formComponents'].append(k.to_map() if k else None)
        if self.name is not None:
            result['name'] = self.name
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_feature_config is not None:
            result['processFeatureConfig'] = self.process_feature_config.to_map()
        if self.template_config is not None:
            result['templateConfig'] = self.template_config.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        self.form_components = []
        if m.get('formComponents') is not None:
            for k in m.get('formComponents'):
                temp_model = FormComponent()
                self.form_components.append(temp_model.from_map(k))
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processFeatureConfig') is not None:
            temp_model = SaveProcessRequestProcessFeatureConfig()
            self.process_feature_config = temp_model.from_map(m['processFeatureConfig'])
        if m.get('templateConfig') is not None:
            temp_model = SaveProcessRequestTemplateConfig()
            self.template_config = temp_model.from_map(m['templateConfig'])
        return self


class SaveProcessResponseBodyResult(TeaModel):
    def __init__(
        self,
        process_code: str = None,
    ):
        # This parameter is required.
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


class SaveProcessResponseBody(TeaModel):
    def __init__(
        self,
        result: SaveProcessResponseBodyResult = None,
    ):
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
            temp_model = SaveProcessResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SaveProcessResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SaveProcessResponseBody = None,
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
            temp_model = SaveProcessResponseBody()
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
        self.action_type = action_type
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


class StartProcessInstanceRequestFormComponentValuesDetailsDetails(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        component_type: str = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.component_type = component_type
        self.ext_value = ext_value
        self.id = id
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class StartProcessInstanceRequestFormComponentValuesDetails(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        details: List[StartProcessInstanceRequestFormComponentValuesDetailsDetails] = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.details = details
        self.ext_value = ext_value
        self.id = id
        self.name = name
        self.value = value

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
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        result['details'] = []
        if self.details is not None:
            for k in self.details:
                result['details'].append(k.to_map() if k else None)
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        self.details = []
        if m.get('details') is not None:
            for k in m.get('details'):
                temp_model = StartProcessInstanceRequestFormComponentValuesDetailsDetails()
                self.details.append(temp_model.from_map(k))
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class StartProcessInstanceRequestFormComponentValues(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        component_type: str = None,
        details: List[StartProcessInstanceRequestFormComponentValuesDetails] = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.component_type = component_type
        self.details = details
        self.ext_value = ext_value
        self.id = id
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.value = value

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
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        result['details'] = []
        if self.details is not None:
            for k in self.details:
                result['details'].append(k.to_map() if k else None)
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        self.details = []
        if m.get('details') is not None:
            for k in m.get('details'):
                temp_model = StartProcessInstanceRequestFormComponentValuesDetails()
                self.details.append(temp_model.from_map(k))
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class StartProcessInstanceRequestTargetSelectActioners(TeaModel):
    def __init__(
        self,
        actioner_key: str = None,
        actioner_user_ids: List[str] = None,
    ):
        self.actioner_key = actioner_key
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


class StartProcessInstanceRequest(TeaModel):
    def __init__(
        self,
        approvers: List[StartProcessInstanceRequestApprovers] = None,
        cc_list: List[str] = None,
        cc_position: str = None,
        dept_id: int = None,
        form_component_values: List[StartProcessInstanceRequestFormComponentValues] = None,
        microapp_agent_id: int = None,
        originator_user_id: str = None,
        process_code: str = None,
        target_select_actioners: List[StartProcessInstanceRequestTargetSelectActioners] = None,
    ):
        self.approvers = approvers
        self.cc_list = cc_list
        self.cc_position = cc_position
        self.dept_id = dept_id
        # This parameter is required.
        self.form_component_values = form_component_values
        self.microapp_agent_id = microapp_agent_id
        # This parameter is required.
        self.originator_user_id = originator_user_id
        # This parameter is required.
        self.process_code = process_code
        self.target_select_actioners = target_select_actioners

    def validate(self):
        if self.approvers:
            for k in self.approvers:
                if k:
                    k.validate()
        if self.form_component_values:
            for k in self.form_component_values:
                if k:
                    k.validate()
        if self.target_select_actioners:
            for k in self.target_select_actioners:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['approvers'] = []
        if self.approvers is not None:
            for k in self.approvers:
                result['approvers'].append(k.to_map() if k else None)
        if self.cc_list is not None:
            result['ccList'] = self.cc_list
        if self.cc_position is not None:
            result['ccPosition'] = self.cc_position
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        result['formComponentValues'] = []
        if self.form_component_values is not None:
            for k in self.form_component_values:
                result['formComponentValues'].append(k.to_map() if k else None)
        if self.microapp_agent_id is not None:
            result['microappAgentId'] = self.microapp_agent_id
        if self.originator_user_id is not None:
            result['originatorUserId'] = self.originator_user_id
        if self.process_code is not None:
            result['processCode'] = self.process_code
        result['targetSelectActioners'] = []
        if self.target_select_actioners is not None:
            for k in self.target_select_actioners:
                result['targetSelectActioners'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.approvers = []
        if m.get('approvers') is not None:
            for k in m.get('approvers'):
                temp_model = StartProcessInstanceRequestApprovers()
                self.approvers.append(temp_model.from_map(k))
        if m.get('ccList') is not None:
            self.cc_list = m.get('ccList')
        if m.get('ccPosition') is not None:
            self.cc_position = m.get('ccPosition')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        self.form_component_values = []
        if m.get('formComponentValues') is not None:
            for k in m.get('formComponentValues'):
                temp_model = StartProcessInstanceRequestFormComponentValues()
                self.form_component_values.append(temp_model.from_map(k))
        if m.get('microappAgentId') is not None:
            self.microapp_agent_id = m.get('microappAgentId')
        if m.get('originatorUserId') is not None:
            self.originator_user_id = m.get('originatorUserId')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        self.target_select_actioners = []
        if m.get('targetSelectActioners') is not None:
            for k in m.get('targetSelectActioners'):
                temp_model = StartProcessInstanceRequestTargetSelectActioners()
                self.target_select_actioners.append(temp_model.from_map(k))
        return self


class StartProcessInstanceResponseBody(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
    ):
        # This parameter is required.
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
        status_code: int = None,
        body: StartProcessInstanceResponseBody = None,
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
            temp_model = StartProcessInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TerminateProcessInstanceHeaders(TeaModel):
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


class TerminateProcessInstanceRequest(TeaModel):
    def __init__(
        self,
        is_system: bool = None,
        operating_user_id: str = None,
        process_instance_id: str = None,
        remark: str = None,
    ):
        self.is_system = is_system
        self.operating_user_id = operating_user_id
        # This parameter is required.
        self.process_instance_id = process_instance_id
        self.remark = remark

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_system is not None:
            result['isSystem'] = self.is_system
        if self.operating_user_id is not None:
            result['operatingUserId'] = self.operating_user_id
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.remark is not None:
            result['remark'] = self.remark
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isSystem') is not None:
            self.is_system = m.get('isSystem')
        if m.get('operatingUserId') is not None:
            self.operating_user_id = m.get('operatingUserId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        return self


class TerminateProcessInstanceResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class TerminateProcessInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TerminateProcessInstanceResponseBody = None,
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
            temp_model = TerminateProcessInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TodoTasksHeaders(TeaModel):
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


class TodoTasksRequest(TeaModel):
    def __init__(
        self,
        actioner_user_id: str = None,
        manager_user_id: str = None,
        max_results: int = None,
        next_token: int = None,
    ):
        # This parameter is required.
        self.actioner_user_id = actioner_user_id
        # This parameter is required.
        self.manager_user_id = manager_user_id
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actioner_user_id is not None:
            result['actionerUserId'] = self.actioner_user_id
        if self.manager_user_id is not None:
            result['managerUserId'] = self.manager_user_id
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionerUserId') is not None:
            self.actioner_user_id = m.get('actionerUserId')
        if m.get('managerUserId') is not None:
            self.manager_user_id = m.get('managerUserId')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class TodoTasksResponseBodyResultList(TeaModel):
    def __init__(
        self,
        business_id: str = None,
        can_redirect: bool = None,
        create_time: int = None,
        process_code: str = None,
        process_instance_id: str = None,
        task_id: int = None,
        title: str = None,
        user_id: str = None,
    ):
        self.business_id = business_id
        self.can_redirect = can_redirect
        self.create_time = create_time
        self.process_code = process_code
        self.process_instance_id = process_instance_id
        self.task_id = task_id
        self.title = title
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.business_id is not None:
            result['businessId'] = self.business_id
        if self.can_redirect is not None:
            result['canRedirect'] = self.can_redirect
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('businessId') is not None:
            self.business_id = m.get('businessId')
        if m.get('canRedirect') is not None:
            self.can_redirect = m.get('canRedirect')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class TodoTasksResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[TodoTasksResponseBodyResultList] = None,
    ):
        self.has_more = has_more
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = TodoTasksResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        return self


class TodoTasksResponseBody(TeaModel):
    def __init__(
        self,
        result: TodoTasksResponseBodyResult = None,
    ):
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
            temp_model = TodoTasksResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class TodoTasksResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TodoTasksResponseBody = None,
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
            temp_model = TodoTasksResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateIntegratedTaskHeaders(TeaModel):
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


class UpdateIntegratedTaskRequestTasks(TeaModel):
    def __init__(
        self,
        result: str = None,
        status: str = None,
        task_id: int = None,
    ):
        self.result = result
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class UpdateIntegratedTaskRequest(TeaModel):
    def __init__(
        self,
        process_instance_id: str = None,
        tasks: List[UpdateIntegratedTaskRequestTasks] = None,
    ):
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.tasks = tasks

    def validate(self):
        if self.tasks:
            for k in self.tasks:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        result['tasks'] = []
        if self.tasks is not None:
            for k in self.tasks:
                result['tasks'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        self.tasks = []
        if m.get('tasks') is not None:
            for k in m.get('tasks'):
                temp_model = UpdateIntegratedTaskRequestTasks()
                self.tasks.append(temp_model.from_map(k))
        return self


class UpdateIntegratedTaskResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
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


class UpdateIntegratedTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateIntegratedTaskResponseBody = None,
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
            temp_model = UpdateIntegratedTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateProcessInstanceHeaders(TeaModel):
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


class UpdateProcessInstanceRequestNotifiers(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateProcessInstanceRequest(TeaModel):
    def __init__(
        self,
        notifiers: List[UpdateProcessInstanceRequestNotifiers] = None,
        process_instance_id: str = None,
        result: str = None,
        status: str = None,
    ):
        self.notifiers = notifiers
        # This parameter is required.
        self.process_instance_id = process_instance_id
        self.result = result
        # This parameter is required.
        self.status = status

    def validate(self):
        if self.notifiers:
            for k in self.notifiers:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['notifiers'] = []
        if self.notifiers is not None:
            for k in self.notifiers:
                result['notifiers'].append(k.to_map() if k else None)
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.notifiers = []
        if m.get('notifiers') is not None:
            for k in m.get('notifiers'):
                temp_model = UpdateProcessInstanceRequestNotifiers()
                self.notifiers.append(temp_model.from_map(k))
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class UpdateProcessInstanceResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
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


class UpdateProcessInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateProcessInstanceResponseBody = None,
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
            temp_model = UpdateProcessInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


