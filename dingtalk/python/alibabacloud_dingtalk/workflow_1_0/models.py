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


class FormDataSourceTarget(TeaModel):
    def __init__(
        self,
        app_type: int = None,
        app_uuid: str = None,
        biz_type: str = None,
        form_code: str = None,
    ):
        # 表单类型，0流程表单
        self.app_type = app_type
        # 应用appUuid
        self.app_uuid = app_uuid
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
        # 关联表单信息
        self.target = target
        # 关联类型，form关联表单
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


class FormComponentPropsStatField(TeaModel):
    def __init__(
        self,
        component_id: str = None,
        label: str = None,
        upper: str = None,
    ):
        # 需要统计的明细控件内子控件id
        self.component_id = component_id
        # 子控件标题
        self.label = label
        # 金额控件是否需要大写，1不需要大写，其他需要大写
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
        print: str = None,
        required: bool = None,
        stat_field: List[FormComponentPropsStatField] = None,
        table_view_mode: str = None,
        unit: str = None,
        upper: str = None,
        vertical_print: bool = None,
    ):
        # 明细控件按钮显示文案
        self.action_name = action_name
        # 地址控件模式city省市,district省市区,street省市区街道
        self.address_model = address_model
        # 文字提示控件显示方式:top|middle|bottom
        self.align = align
        # 套件中控件是否可设置为分条件字段
        self.async_condition = async_condition
        # 关联审批单控件限定模板列表
        self.available_templates = available_templates
        # 业务别名
        self.biz_alias = biz_alias
        # 套件的业务标识
        self.biz_type = biz_type
        # 联系人控件是否支持多选，1多选，0单选
        self.choice = choice
        # 自定义控件渲染标识
        self.common_biz_type = common_biz_type
        # 控件表单内唯一id
        self.component_id = component_id
        # 说明文字控件内容
        self.content = content
        # 关联数据源配置
        self.data_source = data_source
        # 是否不可编辑
        self.disabled = disabled
        # 是否自动计算时长
        self.duration = duration
        # 时间格式
        self.format = format
        # 公式
        self.formula = formula
        # 是否隐藏字段
        self.invisible = invisible
        # 控件标题
        self.label = label
        # 评分控件上限
        self.limit = limit
        # 说明文字控件链接地址
        self.link = link
        # 文本控件支持的最大长度
        self.max_length = max_length
        # 电话控件支持的类型
        self.mode = mode
        # 部门控件是否可多选
        self.multiple = multiple
        # 单选多选控件选项列表
        self.options = options
        # 输入提示
        self.placeholder = placeholder
        # 字段是否可打印，1打印，0不打印，默认打印
        self.print = print
        # 是否必填
        self.required = required
        # 明细控件数据汇总统计
        self.stat_field = stat_field
        # 明细填写方式，table（表格）、list（列表）
        self.table_view_mode = table_view_mode
        # 时间单位（天、小时）
        self.unit = unit
        # 金额控件是否需要大写，1不需要大写，其他需要大写
        self.upper = upper
        # 明细打印方式false横向，true纵向
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
        # 子控件集合
        self.children = children
        # 控件类型
        self.component_type = component_type
        # 控件属性
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
        # 文件ID。
        self.file_id = file_id
        # 钉盘空间spaceId。
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
        # 授权的钉盘文件信息列表。支持批量授权，最大列表长度：10。
        self.file_infos = file_infos
        # 授权的用户userid。
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
        # 返回结果。
        self.result = result
        # 接口调用是否成功。
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
        body: AddApproveDentryAuthResponseBody = None,
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
        # 文件ID。
        self.file_id = file_id
        # 文件名称。
        self.file_name = file_name
        # 文件大小。
        self.file_size = file_size
        # 文件类型。
        self.file_type = file_type
        # 钉盘空间ID。
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
        # 附件列表。
        self.attachments = attachments
        # 图片URL地址。
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
        # 评论人的userid。
        self.comment_user_id = comment_user_id
        # 文件。
        self.file = file
        # 审批实例ID，可通过调用获取审批实例ID列表接口获取。
        self.process_instance_id = process_instance_id
        # 评论的内容。
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
        # 评论是否成功。
        self.result = result
        # 接口调用是否成功。
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
        body: AddProcessInstanceCommentResponseBody = None,
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
            temp_model = AddProcessInstanceCommentResponseBody()
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
        # 抄送接收人用户userId。
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
        # 抄送列表，注意最大抄送人数量不能超过30。
        self.notifiers = notifiers
        # 实例id
        self.process_instance_id = process_instance_id
        # 实例结果：
        # 实例状态是COMPLETED，必须设置代表以下含义。
        # agree：同意
        # refuse：拒绝
        # 实例状态为TERMINATED，必须设置代表含义，result取值agree和refuse均代表撤销审批流。
        self.result = result
        # 实例状态：
        # COMPLETED：结束审批流
        # TERMINATED：终止审批流
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
        # 实列列表。
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
        # 成功标识
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
        body: BatchUpdateProcessInstanceResponseBody = None,
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
        # 待办组ID，需要在调用创建待办接口时，主动设置该值。
        self.activity_id = activity_id
        # 待办组ID列表，用于批量取消。
        self.activity_ids = activity_ids
        # OA审批流程实例ID
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
        # 是否更新成功
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
        body: CancelIntegratedTaskResponseBody = None,
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
        # 企业的corpId。
        self.corp_id = corp_id
        # 模板唯一码。
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
        # 是否调用成功。
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
        body: CleanProcessDataResponseBody = None,
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
        # 默认为1
        # COPE_TYPE_DEFAULT = 1 默认会使用groupId进行隔离分组，审批首页不可见
        # COPE_TYPE_INCLUDE_FLOW = 2 使用dingtalk 2作为隔离分组，审批首页可见
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
        # 套件业务标识
        self.biz_type = biz_type
        # 模板名称
        self.name = name
        # 模板code
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
        # 复制选项
        self.copy_options = copy_options
        self.source_corp_id = source_corp_id
        # 源模版列表
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
        # 业务标识
        self.biz_type = biz_type
        # 模板名称
        self.name = name
        # 模板code
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
        body: CopyProcessResponseBody = None,
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


class CreateIntegratedTaskRequestTasks(TeaModel):
    def __init__(
        self,
        url: str = None,
        user_id: str = None,
    ):
        # 待办事项跳转URL。
        # 创建审批实例接口里的url，实现的是钉钉审批应用里的审批单跳转。这个接口里的url，实现的是钉钉待办页面，对应的待办卡片的跳转。两种跳转场景不同。需要注意的是，钉钉的待办页面，也同时支持移动端和PC端，所以这个接口里传的url参数，它所对应的页面也要适配好移动端和PC端。
        # 
        self.url = url
        # OA审批任务执行人的用户ID
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.url is not None:
            result['url'] = self.url
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateIntegratedTaskRequest(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        process_instance_id: str = None,
        tasks: List[CreateIntegratedTaskRequestTasks] = None,
    ):
        # 待办组ID，调用方提供自定义唯一分组标识
        self.activity_id = activity_id
        # OA审批实例ID，通过创建实例接口获取。
        # 
        self.process_instance_id = process_instance_id
        # 任务列表
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
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
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
        # OA审批任务ID
        self.task_id = task_id
        # OA审批任务执行人用户ID
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
        # 是否创建成功
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
        body: CreateIntegratedTaskResponseBody = None,
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
            temp_model = CreateIntegratedTaskResponseBody()
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
        # 是否清理正在运行的任务
        self.clean_running_task = clean_running_task
        # 模板code
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
        # 模板code
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
        body: DeleteProcessResponseBody = None,
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
        # 文件ID。
        self.file_id = file_id
        # 文件名称。
        self.file_name = file_name
        # 文件大小。
        self.file_size = file_size
        # 文件类型。
        self.file_type = file_type
        # 钉盘空间ID。
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
        # 附件列表。
        self.attachments = attachments
        # 图片URL地址。
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
        # 操作人userid，可通过调用获取审批实例详情接口获取。
        self.actioner_user_id = actioner_user_id
        # 文件。
        self.file = file
        # 审批实例ID，可通过调用获取审批实例ID列表接口获取。
        self.process_instance_id = process_instance_id
        # 审批意见，可为空。
        self.remark = remark
        # 审批操作，取值。
        # 
        # agree：同意
        # 
        # refuse：拒绝
        self.result = result
        # 任务节点id，可通过调用获取审批实例详情接口获取。
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
        # 同意或拒绝结果。
        self.result = result
        # 接口调用是否成功。
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
        body: ExecuteProcessInstanceResponseBody = None,
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
        # 更新后模板目录id
        self.dir_id = dir_id
        # 禁用模板删除按钮
        self.disable_delete_process = disable_delete_process
        # 禁用表单编辑
        self.disable_form_edit = disable_form_edit
        # 首页工作台是否可见
        self.disable_homepage = disable_homepage
        # 禁用再次提交
        self.disable_resubmit = disable_resubmit
        # 禁用停止按钮
        self.disable_stop_process_button = disable_stop_process_button
        # 审批场景内隐藏模板
        self.hidden = hidden
        # 源模板目录id
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
        # 表单模板描述
        self.description = description
        # 表单控件列表
        self.form_components = form_components
        # 表单模板名称
        self.name = name
        self.process_code = process_code
        # 模板配置信息
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
        # 应用的agentid。
        self.agent_id = agent_id
        # 用户的userid
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
        # 钉盘空间ID。
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
        # 返回结果。
        self.result = result
        # 接口调用是否成功。
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
        body: GetAttachmentSpaceResponseBody = None,
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
        # 应用ID (三方应用为AppID)，可在开发者管理后台后台的应用详情页面获取。
        self.agent_id = agent_id
        # 审批模板ID。
        # 
        # processCode需要OA管理后台，在编辑审批表单的URL中获取。
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
        # 表单ID。
        self.id = id
        # 表单名称。
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
        # 返回结果。
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
        body: GetConditionFormComponentResponseBody = None,
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
        # 模板code列表。
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
        body: GetCrmProcCodesResponseBody = None,
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
            temp_model = GetCrmProcCodesResponseBody()
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
        # 用户的userid。
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
        # 关联考勤类型，取值。
        # 
        # 0：无
        # 1：补卡申请
        # 2：请假
        self.attendance_type = attendance_type
        # 模版名称。
        self.flow_title = flow_title
        # 修改时间。
        self.gmt_modified = gmt_modified
        # 模板图标名。
        self.icon_name = icon_name
        # 图标URL地址。
        self.icon_url = icon_url
        # 是否新模版。
        self.new_process = new_process
        # 模版code。
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
        # 返回结果列表。
        self.result = result
        # 接口调用是否成功。
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
        body: GetManageProcessByStaffIdResponseBody = None,
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
        # 模板名称
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


class GetProcessCodeByNameResponseBody(TeaModel):
    def __init__(
        self,
        result: GetProcessCodeByNameResponseBodyResult = None,
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
            temp_model = GetProcessCodeByNameResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetProcessCodeByNameResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetProcessCodeByNameResponseBody = None,
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
        # 模板code
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
        # 提示内容
        self.comment_description = comment_description
        # 评论对发起人不可见
        self.comment_hidden_for_proposer = comment_hidden_for_proposer
        # 评论必填
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
        # 开启手写签名
        self.hand_sign_enable = hand_sign_enable
        # 是否使用上次签名
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
        # 名称
        self.name = name
        # 类型
        self.type = type
        # 员工staffId/部门id
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
        # 是否允许代提交
        self.enable = enable
        # 代提交人
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
        # 规则表达式
        self.express = express
        # 规则类型
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
        # 类型
        self.type = type
        # 员工staffId/部门id
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
        # 自定义摘要信息
        self.abstract_gen_rule = abstract_gen_rule
        # 表单节点权限
        self.activity_auth = activity_auth
        # 是否允许撤销
        self.allow_revoke = allow_revoke
        # 是否允许加签
        self.append_enable = append_enable
        # 如果审批人和发起人是同一个人，则去重
        self.auto_execute_originator_tasks = auto_execute_originator_tasks
        # 流程表单业务标识
        self.biz_category_id = biz_category_id
        # 纯表单业务标识
        self.biz_type = biz_type
        # 评论配置
        self.comment_conf = comment_conf
        # 审批人自动去重
        self.duplicate_removal = duplicate_removal
        # 表单配置
        self.form_schema = form_schema
        # 手写签名配置
        self.hand_sign_conf = hand_sign_conf
        # 表单管理员
        self.managers = managers
        # 表单名称
        self.name = name
        # 是否流程表单
        self.process_app_type = process_app_type
        # 流程配置
        self.process_config = process_config
        # 是否静态流程
        self.static_proc = static_proc
        # 代提交配置
        self.substitute_submit_conf = substitute_submit_conf
        # 自定义标题规则
        self.title_gen_rule = title_gen_rule
        # 模板可见性
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
        body: GetProcessConfigResponseBody = None,
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
        # 审批实例ID企业内部应用可通过获取审批实例ID列表接口获取。钉钉三方企业应用可以通过推送的审批事件中获取，参考biz_type=22。
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
        # 组件别名。
        self.biz_alias = biz_alias
        # 组件类型。
        self.component_type = component_type
        # 标签扩展值。
        self.ext_value = ext_value
        # 组件ID。
        self.id = id
        # 组件名称。
        self.name = name
        # 标签值。
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
    ):
        # 附件ID。
        self.file_id = file_id
        # 附件名称。
        self.file_name = file_name
        # 附件大小。
        self.file_size = file_size
        # 附件类型。
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


class GetProcessInstanceResponseBodyResultOperationRecords(TeaModel):
    def __init__(
        self,
        attachments: List[GetProcessInstanceResponseBodyResultOperationRecordsAttachments] = None,
        date: str = None,
        remark: str = None,
        result: str = None,
        type: str = None,
        user_id: str = None,
    ):
        # 评论附件列表。
        self.attachments = attachments
        # 操作时间。
        self.date = date
        # 评论内容。  审批操作附带评论时才返回该字段。
        self.remark = remark
        # 操作结果：  AGREE：同意  REFUSE：拒绝  NONE
        self.result = result
        # 操作类型：  EXECUTE_TASK_NORMAL：正常执行任务  EXECUTE_TASK_AGENT：代理人执行任务  APPEND_TASK_BEFORE：前加签任务  APPEND_TASK_AFTER：后加签任务  REDIRECT_TASK：转交任务  START_PROCESS_INSTANCE：发起流程实例  TERMINATE_PROCESS_INSTANCE：终止(撤销)流程实例  FINISH_PROCESS_INSTANCE：结束流程实例  ADD_REMARK：添加评论  REDIRECT_PROCESS：审批退回  PROCESS_CC：抄送
        self.type = type
        # 操作人userid。
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
        if self.date is not None:
            result['date'] = self.date
        if self.remark is not None:
            result['remark'] = self.remark
        if self.result is not None:
            result['result'] = self.result
        if self.type is not None:
            result['type'] = self.type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = GetProcessInstanceResponseBodyResultOperationRecordsAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('result') is not None:
            self.result = m.get('result')
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
        # 任务节点ID。
        self.activity_id = activity_id
        # 开始时间。
        self.create_time = create_time
        # 结束时间。
        self.finish_time = finish_time
        # 移动端任务URL。
        self.mobile_url = mobile_url
        # PC端任务URL。
        self.pc_url = pc_url
        # 实例ID。
        self.process_instance_id = process_instance_id
        # 结果：  AGREE：同意  REFUSE：拒绝  REDIRECTED：转交
        self.result = result
        # 任务状态：  NEW：未启动  RUNNING：处理中  PAUSED：暂停  CANCELED：取消  COMPLETED：完成  TERMINATED：终止
        self.status = status
        # 任务ID。
        self.task_id = task_id
        # 任务处理人。
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
        # 审批人userid列表。
        self.approver_user_ids = approver_user_ids
        # 审批附属实例列表，当已经通过的审批实例被修改或撤销，会生成一个新的实例，作为原有审批实例的附属。  如果想知道当前已经通过的审批实例的状态，可以依次遍历它的附属列表，查询里面每个实例的biz_action。
        self.attached_process_instance_ids = attached_process_instance_ids
        # 审批实例业务动作：  MODIFY：表示该审批实例是基于原来的实例修改而来  REVOKE：表示该审批实例是由原来的实例撤销后重新发起的  NONE表示正常发起
        self.biz_action = biz_action
        # 审批实例业务编号。
        self.business_id = business_id
        # 抄送人userid列表。
        self.cc_user_ids = cc_user_ids
        # 创建时间。
        self.create_time = create_time
        # 结束时间。
        self.finish_time = finish_time
        # 表单详情列表。
        self.form_component_values = form_component_values
        # 主流程实例标识。
        self.main_process_instance_id = main_process_instance_id
        # 操作记录列表。
        self.operation_records = operation_records
        # 发起人的部门。-1表示根部门。
        self.originator_dept_id = originator_dept_id
        # 发起人的部门名。
        self.originator_dept_name = originator_dept_name
        # 发起人的userid。
        self.originator_user_id = originator_user_id
        # 审批结果：  agree：同意  refuse：拒绝。 说明 status为COMPLETED且result为同意时，表示审批单完结并审批通过。
        self.result = result
        # 审批状态：  NEW：新创建  RUNNING：审批中  TERMINATED：被终止  COMPLETED：完成  CANCELED：取消
        self.status = status
        # 任务列表。
        self.tasks = tasks
        # 审批实例标题。
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
        # 返回结果。
        self.result = result
        # 调用是否成功。
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
        body: GetProcessInstanceResponseBody = None,
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
            temp_model = GetProcessInstanceResponseBody()
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
    ):
        # 应用的agentid。
        self.agent_id = agent_id
        # 审批附件ID。
        self.file_id = file_id
        # 附件ID列表，支持批量授权，最大列表长度：20。
        self.file_id_list = file_id_list
        # 实例ID。
        # 
        # 企业内部应用
        # 
        # 可通过获取审批实例ID列表接口获取。
        # 
        # 第三方企业应用
        # 
        # 可以通过推送的审批事件中获取，参考biz_type=22。
        self.process_instance_id = process_instance_id
        # 授权允许预览附件的用户userid。
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
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_id_list is not None:
            result['fileIdList'] = self.file_id_list
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.user_id is not None:
            result['userId'] = self.user_id
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
        return self


class GetSpaceWithDownloadAuthResponseBodyResult(TeaModel):
    def __init__(
        self,
        space_id: int = None,
    ):
        # 钉盘空间ID。
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
        # 返回结果。
        self.result = result
        # 接口调用是否成功。
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
        body: GetSpaceWithDownloadAuthResponseBody = None,
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
        # 要查询的用户userid。
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
        # 待处理的审批数量。
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
        body: GetUserTodoTaskSumResponseBody = None,
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
        # 权限有效时间，单位为秒。
        self.duration_seconds = duration_seconds
        # 审批控件 id。
        self.space_id = space_id
        # 权限类型。
        self.type = type
        # 用户 id。
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
    ):
        # 文件id，调用获取审批实例详情接口获取。
        self.file_id = file_id
        # 实例ID。
        # 
        # 调用获取审批实例详情接口获取。
        self.process_instance_id = process_instance_id

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        return self


class GrantProcessInstanceForDownloadFileResponseBodyResult(TeaModel):
    def __init__(
        self,
        download_uri: str = None,
        file_id: str = None,
        space_id: int = None,
    ):
        # 文件下载地址。
        self.download_uri = download_uri
        # 文件ID。
        self.file_id = file_id
        # 钉盘空间ID。
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
        # 返回结果。
        self.result = result
        # 接口调用是否成功。
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
        body: GrantProcessInstanceForDownloadFileResponseBody = None,
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
            temp_model = GrantProcessInstanceForDownloadFileResponseBody()
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
        # 是否同步，目前只有同步
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
        install_option: InstallAppRequestInstallOption = None,
        source_dir_name: str = None,
    ):
        # 安装选项
        # 
        self.install_option = install_option
        # 安装的目录名称
        self.source_dir_name = source_dir_name

    def validate(self):
        if self.install_option:
            self.install_option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.install_option is not None:
            result['installOption'] = self.install_option.to_map()
        if self.source_dir_name is not None:
            result['sourceDirName'] = self.source_dir_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
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
        # 套件业务类型
        self.biz_type = biz_type
        # 模版名称
        self.name = name
        # 模版processcode
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
        # 返回对象列表
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
        body: InstallAppResponseBody = None,
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
        user_ids: List[str] = None,
    ):
        # 审批实例结束时间，Unix时间戳，单位毫秒。  例如：获取审批单发起时间在2020.4.10-2020.4.14之间审批单，该值传2020.4.14 23:59:59对应的时间戳1586879999000。
        self.end_time = end_time
        # 分页参数，每页大小，最多传20。
        self.max_results = max_results
        # 分页查询的游标，最开始传0，后续传返回参数中的nextToken值。
        self.next_token = next_token
        # 审批流的唯一码。
        # 
        # processCode在审批模板编辑页面的URL中获取。
        self.process_code = process_code
        # 审批实例开始时间。Unix时间戳，单位毫秒。
        # 
        # 例如：获取审批单发起时间在2020.4.10-2020.4.14之间审批单，该值传2020.4.10 00:00:00对应的时间戳1586448000000。
        self.start_time = start_time
        # 发起userid列表，最大列表长度为10。
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
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class ListProcessInstanceIdsResponseBodyResult(TeaModel):
    def __init__(
        self,
        list: List[str] = None,
        next_token: str = None,
    ):
        # 审批实例ID列表。
        self.list = list
        # 表示下次查询的游标，当返回结果没有该字段时表示没有更多数据了。
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
        # 返回结果。
        self.result = result
        # 接口请求是否成功。
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
        body: ListProcessInstanceIdsResponseBody = None,
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
        # 分页大小，最大值50。
        self.max_results = max_results
        # 分页游标。
        # 
        # 如果是首次调用，该参数传0。
        # 如果是非首次调用，该参数传上次调用时返回的nextToken。
        # 
        self.next_token = next_token
        # 待办事项的状态：
        # 
        # 0：待处理
        # 
        # -1：已经移除
        # 
        self.status = status
        # 要查询的执行人userid。
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
        # 表单内容。
        self.content = content
        # 表单标题。
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
        # 表单列表。
        self.forms = forms
        # 实例ID。
        self.instance_id = instance_id
        # 待办任务ID。
        self.task_id = task_id
        # 待办标题。
        self.title = title
        # 待办跳转链接。
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
        # 待办事项列表。
        self.list = list
        # 分页游标。不为空表示有数据。
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
        # 查询结果。
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
        body: ListTodoWorkRecordsResponseBody = None,
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
        # 分页大小，最大可设置成100。
        self.max_results = max_results
        # 分页游标，从0开始。根据返回结果里的nextToken是否为空来判断是否还有下一页，且再次调用时设置成nextToken的最新值。
        self.next_token = next_token
        # 要查询的员工的userid。不传表示查询企业下所有审批表单。
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
        icon_url: str = None,
        name: str = None,
        process_code: str = None,
        url: str = None,
    ):
        # 图标URL。
        self.icon_url = icon_url
        # 表单名称。
        self.name = name
        # 表单唯一标识。
        self.process_code = process_code
        # 表单URL。
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
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
        # 下一次分页调用的值，当返回结果里没有nextToken时，表示分页结束。
        self.next_token = next_token
        # 可见表单列表。
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
        # 返回结果。
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
        body: ListUserVisibleBpmsProcessesResponseBody = None,
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
            temp_model = ListUserVisibleBpmsProcessesResponseBody()
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
        # 控件别名
        self.biz_alias = biz_alias
        self.component_type = component_type
        # 控件扩展值
        self.ext_value = ext_value
        # 控件id
        self.id = id
        # 控件名称
        self.name = name
        # 控件值
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
        # 控件别名
        self.biz_alias = biz_alias
        self.details = details
        # 控件扩展值
        self.ext_value = ext_value
        # 控件id
        self.id = id
        # 控件名称
        self.name = name
        # 控件值
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
        # 控件别名
        self.biz_alias = biz_alias
        # 控件类型
        self.component_type = component_type
        self.details = details
        # 控件扩展值
        self.ext_value = ext_value
        # 控件id
        self.id = id
        # 控件名称
        self.name = name
        # 控件值
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
        # 部门ID
        self.dept_id = dept_id
        # 表单数据内容，控件列表
        self.form_component_values = form_component_values
        # 审批流的唯一码
        self.process_code = process_code
        # 审批发起人的userId
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
        # 员工姓名
        self.user_name = user_name
        # 员工 userId
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
        # 角色名字
        self.label_names = label_names
        # 角色 id
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
        # 节点激活类型
        self.actor_activate_type = actor_activate_type
        # 节点操作人 key
        self.actor_key = actor_key
        # 节点操作人选择范围
        self.actor_selection_range = actor_selection_range
        # 节点操作人选择范围类型
        self.actor_selection_type = actor_selection_type
        # 节点操作人类型
        self.actor_type = actor_type
        # 是否允许多选，还是仅允许选一人
        self.allowed_multi = allowed_multi
        # 节点审批方式
        self.approval_method = approval_method
        # 节点审批类型
        self.approval_type = approval_type
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
        # 节点 id
        self.activity_id = activity_id
        # 节点名称
        self.activity_name = activity_name
        # 规则类型
        self.activity_type = activity_type
        # 是否自选审批节点
        self.is_target_select = is_target_select
        # 流程中前一个节点的 id
        self.prev_activity_id = prev_activity_id
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
        is_static_workflow: bool = None,
        process_code: str = None,
        process_id: int = None,
        user_id: str = None,
        workflow_activity_rules: List[ProcessForecastResponseBodyResultWorkflowActivityRules] = None,
        workflow_forecast_nodes: List[ProcessForecastResponseBodyResultWorkflowForecastNodes] = None,
    ):
        # 是否预测成功
        self.is_forecast_success = is_forecast_success
        # 是否静态流程
        self.is_static_workflow = is_static_workflow
        # 流程 code
        self.process_code = process_code
        # 流程 id
        self.process_id = process_id
        # 用户 id
        self.user_id = user_id
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
        # 应用搭建id
        self.app_uuid = app_uuid
        # 表单模板id
        self.form_code = form_code
        # 翻页size
        self.max_results = max_results
        # 分页游标，第一次调用传空或者null
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
        # 控件别名
        self.biz_alias = biz_alias
        # 控件类型
        self.component_type = component_type
        # 表单控件扩展数据
        self.extend_value = extend_value
        # 控件唯一id
        self.key = key
        # 控件名称
        self.label = label
        # 控件填写的数据
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
        # 应用搭建id
        self.app_uuid = app_uuid
        # 扩展信息
        self.attributes = attributes
        # 创建时间
        self.create_timestamp = create_timestamp
        # 创建人
        self.creator = creator
        # 表单模板code
        self.form_code = form_code
        # 表单实例数据
        self.form_inst_data_list = form_inst_data_list
        # 表单实例id
        self.form_instance_id = form_instance_id
        # 修改人
        self.modifier = modifier
        # 修改时间
        self.modify_timestamp = modify_timestamp
        # 外部业务编码
        self.out_biz_code = out_biz_code
        # 外部实例编码
        self.out_instance_id = out_instance_id
        # 标题
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
        # 是否有更多数据
        self.has_more = has_more
        # 分页大小
        self.max_results = max_results
        # 下一页的游标
        self.next_token = next_token
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
        # 应用编码
        self.app_uuid = app_uuid
        # 结束时间
        self.end_time_in_mills = end_time_in_mills
        # 分页大小
        self.max_results = max_results
        # 分页起始值
        self.next_token = next_token
        # 模板编码
        self.process_code = process_code
        # 开始时间
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
        # 控件扩展数据
        self.ext_value = ext_value
        # 控件id
        self.id = id
        # 控件名称
        self.name = name
        # 控件数据
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
        # 附件钉盘id
        self.file_id = file_id
        # 附件名称
        self.file_name = file_name
        # 文件大小
        self.file_size = file_size
        # 文件类型
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
        # 评论附件
        self.attachments = attachments
        # 操作类型
        self.operation_type = operation_type
        # 评论
        self.remark = remark
        # 操作结果
        self.result = result
        # 操作时间戳
        self.timestamp = timestamp
        # 操作人staffId
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
        # 节点id
        self.activity_id = activity_id
        # 任务创建时间戳
        self.create_timestamp = create_timestamp
        # 任务结束时间戳
        self.finish_timestamp = finish_timestamp
        # 任务结果
        self.result = result
        # 任务状态
        self.status = status
        # 任务Id
        self.task_id = task_id
        # 任务处理人
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
        # 附属单信息
        self.attached_process_instance_ids = attached_process_instance_ids
        # 审批单编号
        self.business_id = business_id
        # 审批单创建时间
        self.create_time = create_time
        # 审批结束时间
        self.finish_time = finish_time
        self.form_component_values = form_component_values
        # 主单实例Id
        self.main_process_instance_id = main_process_instance_id
        # 审批单操作记录
        self.operation_records = operation_records
        # 发起人部门id
        self.originator_dept_id = originator_dept_id
        # 发起者userId
        self.originator_userid = originator_userid
        # 流程实例ID
        self.process_instance_id = process_instance_id
        # 审批结果
        self.result = result
        # 审批单状态
        self.status = status
        # 任务列表
        self.tasks = tasks
        # 审批单标题
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
        # 是否有更多数据
        self.has_more = has_more
        self.list = list
        # 总数
        self.max_results = max_results
        # 下次获取数据的游标
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
        # 表单类型，0为流程表单，1为数据表单
        self.app_type = app_type
        # 应用搭建id
        self.app_uuid = app_uuid
        # 业务标识
        self.biz_type = biz_type
        # 表单控件描述
        self.content = content
        # 创建时间
        self.create_time = create_time
        # 创建人
        self.creator = creator
        # 模板code
        self.form_code = form_code
        # 表单uuid
        self.form_uuid = form_uuid
        # 模板描述
        self.memo = memo
        # 修改时间
        self.modifed_time = modifed_time
        # 模板名称
        self.name = name
        # 数据归属id
        self.owner_id = owner_id
        # 模板状态
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
        # 应用搭建id
        self.app_uuid = app_uuid
        # 表单模板Code
        self.form_code = form_code
        # 表单实例id
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
        self.biz_alias = biz_alias
        self.component_type = component_type
        self.extend_value = extend_value
        self.key = key
        self.label = label
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
        # 应用搭建id
        self.app_uuid = app_uuid
        # 扩展信息
        self.attributes = attributes
        # 实例创建时间戳
        self.create_timestamp = create_timestamp
        # 创建人
        self.creator = creator
        # 表单模板id
        self.form_code = form_code
        # 表单数据
        self.form_inst_data_list = form_inst_data_list
        # 实例id
        self.form_instance_id = form_instance_id
        # 修改人
        self.modifier = modifier
        # 实例最近修改时间戳
        self.modify_timestamp = modify_timestamp
        # 外联业务code
        self.out_biz_code = out_biz_code
        # 外联业务实例id
        self.out_instance_id = out_instance_id
        # 表单标题
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
        # 在此时间戳之前创建的
        self.create_before = create_before
        # 第几页，取值范围为 1 ≤ page ≤ 1000
        self.page_number = page_number
        # 分页大小，取值范围为 1 ≤ pageSize ≤ 40
        self.page_size = page_size
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


class QueryIntegratedTodoTaskResponseBodyTaskPageList(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        create_time: int = None,
        finish_time: str = None,
        process_instance_id: str = None,
        result: str = None,
        status: str = None,
        task_id: int = None,
        user_id: str = None,
    ):
        # 待办组ID，需要在调用创建流程中心集成任务接口时，主动设置该值。
        self.activity_id = activity_id
        # OA审批任务创建时间
        self.create_time = create_time
        # OA审批任务完成时间
        self.finish_time = finish_time
        # 流程实例ID
        self.process_instance_id = process_instance_id
        # 任务处理结果：agree 或 refuse
        self.result = result
        # 任务状态
        self.status = status
        # OA审批任务ID
        self.task_id = task_id
        # OA审批任务执行人的用户ID
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


class QueryIntegratedTodoTaskResponseBodyTaskPage(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryIntegratedTodoTaskResponseBodyTaskPageList] = None,
    ):
        # 是否还有下一页
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
                temp_model = QueryIntegratedTodoTaskResponseBodyTaskPageList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryIntegratedTodoTaskResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        task_page: QueryIntegratedTodoTaskResponseBodyTaskPage = None,
    ):
        self.request_id = request_id
        self.task_page = task_page

    def validate(self):
        if self.task_page:
            self.task_page.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.task_page is not None:
            result['taskPage'] = self.task_page.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('taskPage') is not None:
            temp_model = QueryIntegratedTodoTaskResponseBodyTaskPage()
            self.task_page = temp_model.from_map(m['taskPage'])
        return self


class QueryIntegratedTodoTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryIntegratedTodoTaskResponseBody = None,
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
        # 业务标识
        self.biz_type = biz_type
        # 用户id
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
        # 模板描述
        self.description = description
        # 模板名称
        self.name = name
        # 模板code
        self.process_code = process_code
        # 模版发布状态。
        # 
        # - PUBLISHED：已启用
        # 
        # - INVALID：停用
        # 
        # - SAVED：已保存
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
        body: QueryProcessByBizCategoryIdResponseBody = None,
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
            temp_model = QueryProcessByBizCategoryIdResponseBody()
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
        # 应用搭建隔离信息
        self.app_uuid = app_uuid
        # 表单的唯一码
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
        required: bool = None,
    ):
        # 控件业务别名
        self.biz_alias = biz_alias
        # 控件id
        self.id = id
        # 控件名称
        self.label = label
        # 是否必填
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
        if m.get('required') is not None:
            self.required = m.get('required')
        return self


class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren(TeaModel):
    def __init__(
        self,
        component_name: str = None,
        props: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps = None,
    ):
        # 控件类型
        self.component_name = component_name
        # 子控件属性
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
        # 行为。
        self.behavior = behavior
        # 字段 id。
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
        # 关联控件列表。
        self.targets = targets
        # 控件值。
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
        # 考勤类型(1表示请假, 2表示出差, 3表示加班, 4表示外出)
        self.attendance_rule = attendance_rule
        # 开启状态(1表示开启, 0表示关闭)
        self.push_switch = push_switch
        # 状态显示名称
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
        # id 值。
        self.id = id
        # 名称。
        self.label = label
        # 单位。
        self.unit = unit
        # 大写。
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
        unit: str = None,
        use_calendar: bool = None,
        vertical_print: bool = None,
    ):
        # 加班套件4.0新增 加班明细名称。
        self.action_name = action_name
        # textnote的样式，top|middle|bottom。
        self.align = align
        # ISV 微应用 appId，用于ISV身份权限识别，ISV可获得相应数据。
        self.app_id = app_id
        # 套件是否开启异步获取分条件规则，true：开启；false：不开启。
        self.async_condition = async_condition
        # 请假、出差、外出、加班类型标签。
        self.attend_type_label = attend_type_label
        # 表单关联控件列表。
        self.behavior_linkage = behavior_linkage
        # 控件业务自定义别名。
        self.biz_alias = biz_alias
        # 业务套件类型。
        self.biz_type = biz_type
        # 套件内子组件可见性
        self.child_field_visible = child_field_visible
        # 内部联系人choice，1表示多选，0表示单选。
        self.choice = choice
        # common field的commonBizType。
        self.common_biz_type = common_biz_type
        # 是否可编辑。
        self.disabled = disabled
        # 是否自动计算时长。
        self.duration = duration
        # 兼容字段。
        self.duration_label = duration_label
        # e签宝专用标识。
        self.e_sign = e_sign
        # 套件值是否打平
        self.extract = extract
        # 关联表单中的fields存储
        self.fields_info = fields_info
        # 时间格式(DDDateField和DDDateRangeField)。
        self.format = format
        # 公式。
        self.formula = formula
        # 加班套件4.0新增 加班明细是否隐藏。
        self.hidden = hidden
        # textnote在详情页是否隐藏，true隐藏， false不隐藏
        self.hidden_in_approval_detail = hidden_in_approval_detail
        # 加班套件4.0新增 加班明细是否隐藏标签。
        self.hide_label = hide_label
        # 兼容出勤套件类型。
        self.holiday_options = holiday_options
        # 控件 id。
        self.id = id
        # 控件名称。
        self.label = label
        # label是否可修改 true：不可修改。
        self.label_editable_freeze = label_editable_freeze
        # 说明文案的链接地址。
        self.link = link
        # 加班套件4.0新增 加班明细描述。
        self.main_title = main_title
        # 是否参与打印(1表示不打印, 0表示打印)。
        self.not_print = not_print
        # 是否需要大写 默认是需要; 1:不需要大写, 空或者0:需要大写。
        self.not_upper = not_upper
        # 选项内容列表，提供给业务方更多的选择器操作。
        self.obj_options = obj_options
        # 单选框选项列表。
        self.options = options
        # 是否有支付属性。
        self.pay_enable = pay_enable
        # 占位符。
        self.placeholder = placeholder
        # 同步到考勤, 表示是否设置为员工状态。
        self.push = push
        # 推送到考勤, 子类型(DDSelectField)。
        self.push_to_attendance = push_to_attendance
        # 是否推送管理日历(DDDateRangeField, 1表示推送, 0表示不推送, 该属性为兼容保留)。
        self.push_to_calendar = push_to_calendar
        # 是否必填。
        self.required = required
        # 必填是否可修改 true：不可修改。
        self.required_editable_freeze = required_editable_freeze
        # 兼容出勤套件类型。
        self.show_attend_options = show_attend_options
        # 是否开启员工状态。
        self.staff_status_enabled = staff_status_enabled
        # 需要计算总和的明细组件
        self.stat_field = stat_field
        # 数字组件/日期区间组件单位属性。
        self.unit = unit
        # 是否使用考勤日历。
        self.use_calendar = use_calendar
        # 明细打印排版方式 false：横向 true：纵向。
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
        # 子控件列表
        self.children = children
        # 控件类型，取值：
        self.component_name = component_name
        # 控件属性。
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
        # 图标
        self.icon = icon
        # 控件列表
        self.items = items
        # 表单名称。
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
        # 表单类型。
        self.app_type = app_type
        # 表单应用 uuid 或者 corpId。
        self.app_uuid = app_uuid
        # 代表表单业务含义的类型。
        self.biz_type = biz_type
        # 创建人 userId。
        self.creator_user_id = creator_user_id
        # 业务自定义设置数据。
        self.custom_setting = custom_setting
        # 引擎类型，表单：0，页面：1
        self.engine_type = engine_type
        # 表单的唯一码。
        self.form_code = form_code
        # 表单 uuid。
        self.form_uuid = form_uuid
        # 创建时间的时间戳。
        self.gmt_create = gmt_create
        # 修改时间的时间戳。
        self.gmt_modified = gmt_modified
        # 图标。
        self.icon = icon
        # 排序 id。
        self.list_order = list_order
        # 说明文案。
        self.memo = memo
        # 表单名称。
        self.name = name
        # 数据归属者的 id 类型。企业(orgId), 群(cid), 人(uid)。
        self.owner_id_type = owner_id_type
        # 目标类型: inner, outer, customer。
        self.proc_type = proc_type
        # 表单 schema 详情。
        self.schema_content = schema_content
        # 状态, PUBLISHED(启用), INVALID(停用), SAVED(草稿)
        self.status = status
        # 可见范围类型。
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
        # 返回结果详情。
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
        body: QuerySchemaByProcessCodeResponseBody = None,
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


class RedirectWorkflowTaskRequest(TeaModel):
    def __init__(
        self,
        action_name: str = None,
        operate_user_id: str = None,
        remark: str = None,
        task_id: int = None,
        to_user_id: str = None,
    ):
        # 操作节点名
        self.action_name = action_name
        # 操作人的用户ID，需要跟任务的当前执行人保持一致，否则无法通过校验
        self.operate_user_id = operate_user_id
        # 转交备注信息
        self.remark = remark
        # OA审批任务ID
        self.task_id = task_id
        # OA审批任务被转交对象的用户ID
        self.to_user_id = to_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_name is not None:
            result['actionName'] = self.action_name
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
        # 是否转交成功
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
        body: RedirectWorkflowTaskResponseBody = None,
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
        # 控件别名
        self.biz_alias = biz_alias
        # 控件类型，取值：
        # 
        # TextField：单行输入框
        # 
        # TextareaField：多行输入框
        # 
        # NumberField：数字输入框
        # 
        # DDSelectField：单选框
        # 
        # DDMultiSelectField：多选框
        # 
        # DDDateField：日期控件
        # 
        # DDDateRangeField：时间区间控件
        # 
        # TextNote：文字说明控件
        # 
        # PhoneField：电话控件
        # 
        # DDPhotoField：图片控件
        # 
        # MoneyField：金额控件
        # 
        # TableField：明细控件
        # 
        # DDAttachment：附件
        # 
        # InnerContactField：联系人控件
        # 
        # RelateField：关联审批单
        # 
        # FormRelateField：关联控件
        # 
        # AddressField：省市区控件
        # 
        # StarRatingField：评分控件
        # 
        # DepartmentField：部门控件
        self.component_type = component_type
        # 表单扩展值
        self.ext_value = ext_value
        # 控件id
        self.id = id
        # 表单名称
        self.name = name
        # 表单值
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
        # 抄送位置，可以值有：
        # start - 审批发起时，通知抄送人
        # finish - 审批通过后，通知抄送人
        # start_finish - 审批发起时和审批通过后，都通知抄送人
        self.position = position
        # 抄送接收人用户ID
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
        form_component_value_list: List[SaveIntegratedInstanceRequestFormComponentValueList] = None,
        notifiers: List[SaveIntegratedInstanceRequestNotifiers] = None,
        originator_user_id: str = None,
        process_code: str = None,
        title: str = None,
        url: str = None,
    ):
        self.form_component_value_list = form_component_value_list
        self.notifiers = notifiers
        # 审批实例接收人的userId。
        self.originator_user_id = originator_user_id
        # 审批模板唯一码
        self.process_code = process_code
        # 实例标题
        self.title = title
        # 三方审批系统中审批单的详情页地址
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
        # 实例id
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
        body: SaveIntegratedInstanceResponseBody = None,
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
        # 网关接口标识
        self.api_key = api_key
        # 网关接口对应应用的uuid
        self.app_uuid = app_uuid
        # 网关接口版本
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
        mobile_url: str = None,
        name: str = None,
        pc_url: str = None,
        run_type: str = None,
    ):
        self.callback = callback
        # 手机端链接
        self.mobile_url = mobile_url
        # 名称
        self.name = name
        # pc端链接
        self.pc_url = pc_url
        # 运行方式：
        # ORIGIN：原生运行，即在官方审批内运行对应功能；
        # REDIRECT：外部跳转运行，需要跳转到三方地址运行对应功能
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
            temp_model = SaveProcessRequestProcessFeatureConfigFeaturesCallback()
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


class SaveProcessRequestProcessFeatureConfig(TeaModel):
    def __init__(
        self,
        features: List[SaveProcessRequestProcessFeatureConfigFeatures] = None,
    ):
        # 配置列表
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


class SaveProcessRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        form_components: List[FormComponent] = None,
        name: str = None,
        process_code: str = None,
        process_feature_config: SaveProcessRequestProcessFeatureConfig = None,
    ):
        # 表单模板描述
        self.description = description
        # 表单控件列表
        self.form_components = form_components
        # 表单模板名称
        self.name = name
        # 模板code
        self.process_code = process_code
        # 流程中心集成配置
        self.process_feature_config = process_feature_config

    def validate(self):
        if self.form_components:
            for k in self.form_components:
                if k:
                    k.validate()
        if self.process_feature_config:
            self.process_feature_config.validate()

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
        return self


class SaveProcessResponseBodyResult(TeaModel):
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


class SaveProcessResponseBody(TeaModel):
    def __init__(
        self,
        result: SaveProcessResponseBodyResult = None,
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
            temp_model = SaveProcessResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SaveProcessResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SaveProcessResponseBody = None,
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
        # 控件别名
        self.biz_alias = biz_alias
        # 控件类型
        self.component_type = component_type
        # 控件扩展值
        self.ext_value = ext_value
        # 控件id
        self.id = id
        # 控件名称
        self.name = name
        # 控件值
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
        # 控件别名
        self.biz_alias = biz_alias
        self.details = details
        # 控件扩展值
        self.ext_value = ext_value
        # 控件id
        self.id = id
        # 控件名称
        self.name = name
        # 控件值
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
        # 控件别名
        self.biz_alias = biz_alias
        # 控件类型
        self.component_type = component_type
        self.details = details
        # 控件扩展值
        self.ext_value = ext_value
        # 控件id
        self.id = id
        # 控件名称
        self.name = name
        # 控件值
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
        # 不使用审批流模板时，直接指定审批人列表
        self.approvers = approvers
        # 抄送人userId列表
        self.cc_list = cc_list
        # 抄送时间
        self.cc_position = cc_position
        # 部门ID
        self.dept_id = dept_id
        # 表单数据内容，控件列表
        self.form_component_values = form_component_values
        # 企业微应用标识
        self.microapp_agent_id = microapp_agent_id
        # 审批发起人的userId
        self.originator_user_id = originator_user_id
        # 审批流的唯一码
        self.process_code = process_code
        # 使用审批流模板时，模板上的自选操作人列表
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
        # 是否通过系统操作：
        # 
        # true：由系统直接终止
        # 
        # false：由指定的操作者终止
        self.is_system = is_system
        # 操作人的userid。
        # 
        # 当is_system为false时，该参数必传。
        self.operating_user_id = operating_user_id
        # 审批实例ID，可通过调用获取审批实例ID列表接口获取。
        self.process_instance_id = process_instance_id
        # 终止说明。
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
        # 撤销结果。
        self.result = result
        # 接口调用是否成功。
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
        body: TerminateProcessInstanceResponseBody = None,
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
            temp_model = TerminateProcessInstanceResponseBody()
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
        # 当status为COMPLETED时，必须指定任务结果：
        # AGREE：同意
        # REFUSE：拒绝
        # 
        # 说明 当status为CANCELED时，不需要传result。
        self.result = result
        # 更新为目标任务状态，可选值 CANCELED、COMPLETED
        self.status = status
        # OA审批任务ID
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
        # OA审批流程实例ID，过创建实例接口获取
        self.process_instance_id = process_instance_id
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
        # 是否更新成功
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
        body: UpdateIntegratedTaskResponseBody = None,
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
        # 抄送接收人用户userId。
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
        # 抄送列表，注意最大抄送人数量不能超过30。
        self.notifiers = notifiers
        # 审批实例ID。
        self.process_instance_id = process_instance_id
        # 实例结果：
        # 实例状态是COMPLETED，必须设置代表以下含义。
        # agree：同意
        # refuse：拒绝
        # 实例状态为TERMINATED，必须设置代表含义，result取值agree和refuse均代表撤销审批流。
        self.result = result
        # 实例状态：
        # COMPLETED：结束审批流
        # TERMINATED：终止审批流
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
        body: UpdateProcessInstanceResponseBody = None,
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
            temp_model = UpdateProcessInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


