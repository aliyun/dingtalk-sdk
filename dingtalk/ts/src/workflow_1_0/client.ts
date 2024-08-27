// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AvaliableTemplate extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 出差申请
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-abcd
   */
  processCode?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      processCode: 'processCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      processCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FormComponent extends $tea.Model {
  children?: FormComponent[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField
   */
  componentType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  props?: FormComponentProps;
  static names(): { [key: string]: string } {
    return {
      children: 'children',
      componentType: 'componentType',
      props: 'props',
    };
  }

  static types(): { [key: string]: any } {
    return {
      children: { 'type': 'array', 'itemType': FormComponent },
      componentType: 'string',
      props: FormComponentProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FormComponentProps extends $tea.Model {
  /**
   * @example
   * 增加明细
   */
  actionName?: string;
  addressModel?: string;
  /**
   * @example
   * top
   */
  align?: string;
  /**
   * @example
   * true
   */
  asyncCondition?: boolean;
  availableTemplates?: AvaliableTemplate[];
  /**
   * @example
   * finance_name
   */
  bizAlias?: string;
  /**
   * @example
   * attendance.leave
   */
  bizType?: string;
  /**
   * @example
   * 0
   * 
   * **if can be null:**
   * true
   */
  choice?: string;
  /**
   * @example
   * custom_view
   */
  commonBizType?: string;
  /**
   * @example
   * TextField-abcd
   */
  componentId?: string;
  /**
   * @example
   * 我是说明文字控件
   */
  content?: string;
  dataSource?: FormDataSource;
  /**
   * @example
   * true
   */
  disabled?: boolean;
  /**
   * @example
   * true
   */
  duration?: boolean;
  /**
   * @example
   * 时长
   */
  durationLabel?: string;
  /**
   * @example
   * yyyy-MM-dd
   */
  format?: string;
  formula?: string;
  /**
   * @example
   * true
   */
  invisible?: boolean;
  /**
   * @example
   * 姓名
   */
  label?: string;
  /**
   * @example
   * 5
   */
  limit?: number;
  /**
   * @example
   * http://www.
   */
  link?: string;
  /**
   * @example
   * 20
   */
  maxLength?: number;
  /**
   * @example
   * phone_tel
   */
  mode?: string;
  /**
   * @example
   * true
   */
  multiple?: boolean;
  options?: SelectOption[];
  /**
   * @example
   * 请输入
   */
  placeholder?: string;
  /**
   * @example
   * 2
   * 
   * **if can be null:**
   * true
   */
  precision?: number;
  /**
   * @example
   * 1
   * 
   * **if can be null:**
   * true
   */
  print?: string;
  /**
   * @example
   * true
   */
  required?: boolean;
  statField?: FormComponentPropsStatField[];
  /**
   * @example
   * table
   */
  tableViewMode?: string;
  /**
   * @example
   * 天
   */
  unit?: string;
  /**
   * @example
   * 1
   * 
   * **if can be null:**
   * true
   */
  upper?: string;
  /**
   * @example
   * true
   */
  verticalPrint?: boolean;
  static names(): { [key: string]: string } {
    return {
      actionName: 'actionName',
      addressModel: 'addressModel',
      align: 'align',
      asyncCondition: 'asyncCondition',
      availableTemplates: 'availableTemplates',
      bizAlias: 'bizAlias',
      bizType: 'bizType',
      choice: 'choice',
      commonBizType: 'commonBizType',
      componentId: 'componentId',
      content: 'content',
      dataSource: 'dataSource',
      disabled: 'disabled',
      duration: 'duration',
      durationLabel: 'durationLabel',
      format: 'format',
      formula: 'formula',
      invisible: 'invisible',
      label: 'label',
      limit: 'limit',
      link: 'link',
      maxLength: 'maxLength',
      mode: 'mode',
      multiple: 'multiple',
      options: 'options',
      placeholder: 'placeholder',
      precision: 'precision',
      print: 'print',
      required: 'required',
      statField: 'statField',
      tableViewMode: 'tableViewMode',
      unit: 'unit',
      upper: 'upper',
      verticalPrint: 'verticalPrint',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionName: 'string',
      addressModel: 'string',
      align: 'string',
      asyncCondition: 'boolean',
      availableTemplates: { 'type': 'array', 'itemType': AvaliableTemplate },
      bizAlias: 'string',
      bizType: 'string',
      choice: 'string',
      commonBizType: 'string',
      componentId: 'string',
      content: 'string',
      dataSource: FormDataSource,
      disabled: 'boolean',
      duration: 'boolean',
      durationLabel: 'string',
      format: 'string',
      formula: 'string',
      invisible: 'boolean',
      label: 'string',
      limit: 'number',
      link: 'string',
      maxLength: 'number',
      mode: 'string',
      multiple: 'boolean',
      options: { 'type': 'array', 'itemType': SelectOption },
      placeholder: 'string',
      precision: 'number',
      print: 'string',
      required: 'boolean',
      statField: { 'type': 'array', 'itemType': FormComponentPropsStatField },
      tableViewMode: 'string',
      unit: 'string',
      upper: 'string',
      verticalPrint: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FormDataSource extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  target?: FormDataSourceTarget;
  /**
   * @example
   * form
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      target: 'target',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      target: FormDataSourceTarget,
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SelectOption extends $tea.Model {
  /**
   * @example
   * finance
   */
  key?: string;
  /**
   * @example
   * 财务
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ResultValue extends $tea.Model {
  result?: boolean;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddApproveDentryAuthHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddApproveDentryAuthRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fileInfos?: AddApproveDentryAuthRequestFileInfos[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user123
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      fileInfos: 'fileInfos',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileInfos: { 'type': 'array', 'itemType': AddApproveDentryAuthRequestFileInfos },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddApproveDentryAuthResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  result?: boolean;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddApproveDentryAuthResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddApproveDentryAuthResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: AddApproveDentryAuthResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddProcessInstanceCommentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddProcessInstanceCommentRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user123
   */
  commentUserId?: string;
  file?: AddProcessInstanceCommentRequestFile;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * a171de6c-8bxxxx
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 同意。
   */
  text?: string;
  static names(): { [key: string]: string } {
    return {
      commentUserId: 'commentUserId',
      file: 'file',
      processInstanceId: 'processInstanceId',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commentUserId: 'string',
      file: AddProcessInstanceCommentRequestFile,
      processInstanceId: 'string',
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddProcessInstanceCommentResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  result?: boolean;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddProcessInstanceCommentResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddProcessInstanceCommentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: AddProcessInstanceCommentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchExecuteProcessInstancesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchExecuteProcessInstancesRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 67583405630
   */
  actionerUserId?: string;
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * agree
   */
  result?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  taskInfoList?: BatchExecuteProcessInstancesRequestTaskInfoList[];
  static names(): { [key: string]: string } {
    return {
      actionerUserId: 'actionerUserId',
      remark: 'remark',
      result: 'result',
      taskInfoList: 'taskInfoList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionerUserId: 'string',
      remark: 'string',
      result: 'string',
      taskInfoList: { 'type': 'array', 'itemType': BatchExecuteProcessInstancesRequestTaskInfoList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchExecuteProcessInstancesResponseBody extends $tea.Model {
  result?: { [key: string]: ResultValue };
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'map', 'keyType': 'string', 'valueType': ResultValue },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchExecuteProcessInstancesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchExecuteProcessInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BatchExecuteProcessInstancesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchTasksRedirectHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchTasksRedirectRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * staffId-B
   */
  handoverUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager-12
   */
  managerUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * **if can be null:**
   * false
   */
  taskIds?: number[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * staffId-A
   */
  transfereeUserId?: string;
  static names(): { [key: string]: string } {
    return {
      handoverUserId: 'handoverUserId',
      managerUserId: 'managerUserId',
      taskIds: 'taskIds',
      transfereeUserId: 'transfereeUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      handoverUserId: 'string',
      managerUserId: 'string',
      taskIds: { 'type': 'array', 'itemType': 'number' },
      transfereeUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchTasksRedirectResponseBody extends $tea.Model {
  result?: BatchTasksRedirectResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: BatchTasksRedirectResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchTasksRedirectResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchTasksRedirectResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BatchTasksRedirectResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateProcessInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateProcessInstanceRequest extends $tea.Model {
  updateProcessInstanceRequests?: BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests[];
  static names(): { [key: string]: string } {
    return {
      updateProcessInstanceRequests: 'updateProcessInstanceRequests',
    };
  }

  static types(): { [key: string]: any } {
    return {
      updateProcessInstanceRequests: { 'type': 'array', 'itemType': BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateProcessInstanceResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateProcessInstanceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchUpdateProcessInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BatchUpdateProcessInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelIntegratedTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelIntegratedTaskRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * act_xxxx
   */
  activityId?: string;
  /**
   * **if can be null:**
   * true
   */
  activityIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * tPr_FB_mT_xxxxxxxxx2hQ05201655306463
   * 
   * **if can be null:**
   * false
   */
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      activityIds: 'activityIds',
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      activityIds: { 'type': 'array', 'itemType': 'string' },
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelIntegratedTaskResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelIntegratedTaskResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CancelIntegratedTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CancelIntegratedTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CleanProcessDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CleanProcessDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding1234
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-EF6YJL35
   */
  processCode?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      processCode: 'processCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      processCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CleanProcessDataResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CleanProcessDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CleanProcessDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CleanProcessDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyProcessHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyProcessRequest extends $tea.Model {
  copyOptions?: CopyProcessRequestCopyOptions;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingabc
   */
  sourceCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  sourceProcessVOList?: CopyProcessRequestSourceProcessVOList[];
  static names(): { [key: string]: string } {
    return {
      copyOptions: 'copyOptions',
      sourceCorpId: 'sourceCorpId',
      sourceProcessVOList: 'sourceProcessVOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      copyOptions: CopyProcessRequestCopyOptions,
      sourceCorpId: 'string',
      sourceProcessVOList: { 'type': 'array', 'itemType': CopyProcessRequestSourceProcessVOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyProcessResponseBody extends $tea.Model {
  result?: CopyProcessResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': CopyProcessResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyProcessResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CopyProcessResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CopyProcessResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateIntegratedTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateIntegratedTaskRequest extends $tea.Model {
  /**
   * @example
   * act_xxxx
   */
  activityId?: string;
  featureConfig?: CreateIntegratedTaskRequestFeatureConfig;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * tPr_FB_mT_xxxxxxxxx2hQ05201655306463
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  tasks?: CreateIntegratedTaskRequestTasks[];
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      featureConfig: 'featureConfig',
      processInstanceId: 'processInstanceId',
      tasks: 'tasks',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      featureConfig: CreateIntegratedTaskRequestFeatureConfig,
      processInstanceId: 'string',
      tasks: { 'type': 'array', 'itemType': CreateIntegratedTaskRequestTasks },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateIntegratedTaskResponseBody extends $tea.Model {
  result?: CreateIntegratedTaskResponseBodyResult[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': CreateIntegratedTaskResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateIntegratedTaskResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateIntegratedTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateIntegratedTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDirHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDirRequest extends $tea.Model {
  /**
   * @example
   * oaDirIdxxx
   */
  dirId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user001
   */
  operateUserId?: string;
  static names(): { [key: string]: string } {
    return {
      dirId: 'dirId',
      operateUserId: 'operateUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dirId: 'string',
      operateUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDirResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDirResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteDirResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeleteDirResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteProcessHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteProcessRequest extends $tea.Model {
  cleanRunningTask?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * proc-abc
   */
  processCode?: string;
  static names(): { [key: string]: string } {
    return {
      cleanRunningTask: 'cleanRunningTask',
      processCode: 'processCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cleanRunningTask: 'boolean',
      processCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteProcessResponseBody extends $tea.Model {
  result?: DeleteProcessResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: DeleteProcessResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteProcessResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteProcessResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeleteProcessResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteProcessInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteProcessInstanceRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 133743186427339452
   */
  actionerUserId?: string;
  file?: ExecuteProcessInstanceRequestFile;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * a171de6c-8bxxxx
   */
  processInstanceId?: string;
  /**
   * @example
   * 同意。
   */
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * agree
   */
  result?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 67583405630
   */
  taskId?: number;
  static names(): { [key: string]: string } {
    return {
      actionerUserId: 'actionerUserId',
      file: 'file',
      processInstanceId: 'processInstanceId',
      remark: 'remark',
      result: 'result',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionerUserId: 'string',
      file: ExecuteProcessInstanceRequestFile,
      processInstanceId: 'string',
      remark: 'string',
      result: 'string',
      taskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteProcessInstanceResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  result?: boolean;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteProcessInstanceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ExecuteProcessInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ExecuteProcessInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FormCreateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FormCreateRequest extends $tea.Model {
  /**
   * @example
   * 用于员工差旅费用报销使用
   */
  description?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formComponents?: FormComponent[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 出差报销审批
   */
  name?: string;
  processCode?: string;
  templateConfig?: FormCreateRequestTemplateConfig;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      formComponents: 'formComponents',
      name: 'name',
      processCode: 'processCode',
      templateConfig: 'templateConfig',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      formComponents: { 'type': 'array', 'itemType': FormComponent },
      name: 'string',
      processCode: 'string',
      templateConfig: FormCreateRequestTemplateConfig,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FormCreateResponseBody extends $tea.Model {
  result?: FormCreateResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: FormCreateResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FormCreateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: FormCreateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: FormCreateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAttachmentSpaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAttachmentSpaceRequest extends $tea.Model {
  /**
   * @example
   * 8345000
   */
  agentId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user123
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAttachmentSpaceResponseBody extends $tea.Model {
  result?: GetAttachmentSpaceResponseBodyResult;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetAttachmentSpaceResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAttachmentSpaceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAttachmentSpaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetAttachmentSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConditionFormComponentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConditionFormComponentRequest extends $tea.Model {
  /**
   * @example
   * 10
   */
  agentId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-xxx
   */
  processCode?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      processCode: 'processCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      processCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConditionFormComponentResponseBody extends $tea.Model {
  result?: GetConditionFormComponentResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetConditionFormComponentResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConditionFormComponentResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetConditionFormComponentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetConditionFormComponentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmProcCodesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmProcCodesResponseBody extends $tea.Model {
  result?: string[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmProcCodesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCrmProcCodesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetCrmProcCodesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFieldModifiedHistoryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFieldModifiedHistoryRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField-abcd
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * proc-FF6Y2xxxx
   */
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFieldModifiedHistoryResponseBody extends $tea.Model {
  result?: GetFieldModifiedHistoryResponseBodyResult[];
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetFieldModifiedHistoryResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFieldModifiedHistoryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFieldModifiedHistoryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetFieldModifiedHistoryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHandSignDownloadUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHandSignDownloadUrlRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * AzBltRlvKukX3Wxxxx
   */
  handSignToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ag187wewxxxx
   */
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      handSignToken: 'handSignToken',
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      handSignToken: 'string',
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHandSignDownloadUrlResponseBody extends $tea.Model {
  result?: GetHandSignDownloadUrlResponseBodyResult;
  success?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetHandSignDownloadUrlResponseBodyResult,
      success: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHandSignDownloadUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetHandSignDownloadUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetHandSignDownloadUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetManageProcessByStaffIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetManageProcessByStaffIdRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager7078
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetManageProcessByStaffIdResponseBody extends $tea.Model {
  result?: GetManageProcessByStaffIdResponseBodyResult[];
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetManageProcessByStaffIdResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetManageProcessByStaffIdResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetManageProcessByStaffIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetManageProcessByStaffIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessCodeByNameHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessCodeByNameRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc
   */
  name?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessCodeByNameResponseBody extends $tea.Model {
  result?: GetProcessCodeByNameResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetProcessCodeByNameResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessCodeByNameResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetProcessCodeByNameResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetProcessCodeByNameResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessConfigHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessConfigRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-BEFC22B7-EA64-4336-86EB-AB773AA2EB12
   */
  procCode?: string;
  static names(): { [key: string]: string } {
    return {
      procCode: 'procCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      procCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessConfigResponseBody extends $tea.Model {
  result?: GetProcessConfigResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetProcessConfigResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessConfigResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetProcessConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetProcessConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * a171de6c-8bxxxx
   */
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceResponseBody extends $tea.Model {
  result?: GetProcessInstanceResponseBodyResult;
  /**
   * @example
   * true
   */
  success?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetProcessInstanceResponseBodyResult,
      success: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetProcessInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetProcessInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceWithExtraHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceWithExtraRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * a171de6c-8bxxxx
   */
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceWithExtraResponseBody extends $tea.Model {
  result?: GetProcessInstanceWithExtraResponseBodyResult;
  /**
   * @example
   * true
   */
  success?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetProcessInstanceWithExtraResponseBodyResult,
      success: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceWithExtraResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetProcessInstanceWithExtraResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetProcessInstanceWithExtraResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSchemaAndProcessconfigBatchllyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSchemaAndProcessconfigBatchllyRequest extends $tea.Model {
  processCodes?: string[];
  static names(): { [key: string]: string } {
    return {
      processCodes: 'processCodes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processCodes: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSchemaAndProcessconfigBatchllyShrinkRequest extends $tea.Model {
  processCodesShrink?: string;
  static names(): { [key: string]: string } {
    return {
      processCodesShrink: 'processCodes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processCodesShrink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSchemaAndProcessconfigBatchllyResponseBody extends $tea.Model {
  result?: GetSchemaAndProcessconfigBatchllyResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetSchemaAndProcessconfigBatchllyResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSchemaAndProcessconfigBatchllyResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSchemaAndProcessconfigBatchllyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetSchemaAndProcessconfigBatchllyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceWithDownloadAuthHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceWithDownloadAuthRequest extends $tea.Model {
  /**
   * @example
   * 8345000
   */
  agentId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 111
   */
  fileId?: string;
  fileIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * a17444d1-075b-4a4d-xxxx
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user123
   */
  userId?: string;
  /**
   * **if can be null:**
   * true
   */
  withCommentAttatchment?: boolean;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      fileId: 'fileId',
      fileIdList: 'fileIdList',
      processInstanceId: 'processInstanceId',
      userId: 'userId',
      withCommentAttatchment: 'withCommentAttatchment',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      fileId: 'string',
      fileIdList: { 'type': 'array', 'itemType': 'string' },
      processInstanceId: 'string',
      userId: 'string',
      withCommentAttatchment: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceWithDownloadAuthResponseBody extends $tea.Model {
  result?: GetSpaceWithDownloadAuthResponseBodyResult;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetSpaceWithDownloadAuthResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceWithDownloadAuthResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSpaceWithDownloadAuthResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetSpaceWithDownloadAuthResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserTodoTaskSumHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserTodoTaskSumRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager123
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserTodoTaskSumResponseBody extends $tea.Model {
  /**
   * @example
   * 10
   */
  result?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserTodoTaskSumResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserTodoTaskSumResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetUserTodoTaskSumResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantCspaceAuthorizationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantCspaceAuthorizationRequest extends $tea.Model {
  /**
   * @example
   * 3600
   */
  durationSeconds?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 163xxxx658
   */
  spaceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * add
   */
  type?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 26652461xxxx5992
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      durationSeconds: 'durationSeconds',
      spaceId: 'spaceId',
      type: 'type',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      durationSeconds: 'number',
      spaceId: 'string',
      type: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantCspaceAuthorizationResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantProcessInstanceForDownloadFileHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantProcessInstanceForDownloadFileRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 111
   */
  fileId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * a17444d1-075b-4a4d-xxxx
   */
  processInstanceId?: string;
  /**
   * **if can be null:**
   * true
   */
  withCommentAttatchment?: boolean;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      processInstanceId: 'processInstanceId',
      withCommentAttatchment: 'withCommentAttatchment',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      processInstanceId: 'string',
      withCommentAttatchment: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantProcessInstanceForDownloadFileResponseBody extends $tea.Model {
  result?: GrantProcessInstanceForDownloadFileResponseBodyResult;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GrantProcessInstanceForDownloadFileResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantProcessInstanceForDownloadFileResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GrantProcessInstanceForDownloadFileResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GrantProcessInstanceForDownloadFileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertOrUpdateDirHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertOrUpdateDirRequest extends $tea.Model {
  /**
   * @example
   * administeration
   */
  bizGroup?: string;
  /**
   * @example
   * 分组描述信息
   */
  description?: string;
  /**
   * @example
   * 行政管理
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {\"en_US\":\"test\",\"ja_JP\":\"test\",\"vi_VN\":\"test\",\"zh_CN\":\"测试\",\"zh_HK\":\"测试\",\"zh_TW\":\"测试\"}
   */
  name18n?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user001
   */
  operateUserId?: string;
  static names(): { [key: string]: string } {
    return {
      bizGroup: 'bizGroup',
      description: 'description',
      name: 'name',
      name18n: 'name18n',
      operateUserId: 'operateUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizGroup: 'string',
      description: 'string',
      name: 'string',
      name18n: 'string',
      operateUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertOrUpdateDirResponseBody extends $tea.Model {
  result?: InsertOrUpdateDirResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: InsertOrUpdateDirResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertOrUpdateDirResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: InsertOrUpdateDirResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: InsertOrUpdateDirResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallAppHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallAppRequest extends $tea.Model {
  bizGroup?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  installOption?: InstallAppRequestInstallOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * finance
   */
  sourceDirName?: string;
  static names(): { [key: string]: string } {
    return {
      bizGroup: 'bizGroup',
      installOption: 'installOption',
      sourceDirName: 'sourceDirName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizGroup: 'string',
      installOption: InstallAppRequestInstallOption,
      sourceDirName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallAppResponseBody extends $tea.Model {
  result?: InstallAppResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': InstallAppResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallAppResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: InstallAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: InstallAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListProcessInstanceIdsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListProcessInstanceIdsRequest extends $tea.Model {
  /**
   * @example
   * 1496678400000
   */
  endTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  nextToken?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-FF6Y2xxxx
   */
  processCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1496678400000
   */
  startTime?: number;
  statuses?: string[];
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      processCode: 'processCode',
      startTime: 'startTime',
      statuses: 'statuses',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      maxResults: 'number',
      nextToken: 'number',
      processCode: 'string',
      startTime: 'number',
      statuses: { 'type': 'array', 'itemType': 'string' },
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListProcessInstanceIdsResponseBody extends $tea.Model {
  result?: ListProcessInstanceIdsResponseBodyResult;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ListProcessInstanceIdsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListProcessInstanceIdsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListProcessInstanceIdsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListProcessInstanceIdsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTodoWorkRecordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTodoWorkRecordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  nextToken?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  status?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager001
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      status: 'status',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
      status: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTodoWorkRecordsResponseBody extends $tea.Model {
  result?: ListTodoWorkRecordsResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ListTodoWorkRecordsResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTodoWorkRecordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListTodoWorkRecordsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListTodoWorkRecordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserVisibleBpmsProcessesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserVisibleBpmsProcessesRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  nextToken?: number;
  /**
   * @example
   * manager7078
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserVisibleBpmsProcessesResponseBody extends $tea.Model {
  result?: ListUserVisibleBpmsProcessesResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ListUserVisibleBpmsProcessesResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserVisibleBpmsProcessesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListUserVisibleBpmsProcessesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListUserVisibleBpmsProcessesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PagesExportInstancesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PagesExportInstancesRequest extends $tea.Model {
  endTimeInMills?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  nextToken?: string;
  orderBy?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  processCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  startTimeInMills?: number;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      endTimeInMills: 'endTimeInMills',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      orderBy: 'orderBy',
      processCode: 'processCode',
      startTimeInMills: 'startTimeInMills',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTimeInMills: 'number',
      maxResults: 'number',
      nextToken: 'string',
      orderBy: 'string',
      processCode: 'string',
      startTimeInMills: 'number',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PagesExportInstancesResponseBody extends $tea.Model {
  result?: PagesExportInstancesResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PagesExportInstancesResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PagesExportInstancesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PagesExportInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PagesExportInstancesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumBatchExecuteProcessInstancesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumBatchExecuteProcessInstancesRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 67583405630
   */
  actionerUserId?: string;
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * agree
   */
  result?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  taskInfoList?: PremiumBatchExecuteProcessInstancesRequestTaskInfoList[];
  static names(): { [key: string]: string } {
    return {
      actionerUserId: 'actionerUserId',
      remark: 'remark',
      result: 'result',
      taskInfoList: 'taskInfoList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionerUserId: 'string',
      remark: 'string',
      result: 'string',
      taskInfoList: { 'type': 'array', 'itemType': PremiumBatchExecuteProcessInstancesRequestTaskInfoList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumBatchExecuteProcessInstancesResponseBody extends $tea.Model {
  result?: { [key: string]: ResultValue };
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'map', 'keyType': 'string', 'valueType': ResultValue },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumBatchExecuteProcessInstancesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PremiumBatchExecuteProcessInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PremiumBatchExecuteProcessInstancesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumDelDirHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumDelDirRequest extends $tea.Model {
  /**
   * @example
   * oaDirIdxxx
   */
  dirId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user001
   */
  operateUserId?: string;
  static names(): { [key: string]: string } {
    return {
      dirId: 'dirId',
      operateUserId: 'operateUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dirId: 'string',
      operateUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumDelDirResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumDelDirResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PremiumDelDirResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PremiumDelDirResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetDoneTasksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetDoneTasksRequest extends $tea.Model {
  dingClientId?: string;
  keyword?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager001
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dingClientId: 'dingClientId',
      keyword: 'keyword',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingClientId: 'string',
      keyword: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetDoneTasksResponseBody extends $tea.Model {
  result?: PremiumGetDoneTasksResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PremiumGetDoneTasksResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetDoneTasksResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PremiumGetDoneTasksResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PremiumGetDoneTasksResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetFieldModifiedHistoryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetFieldModifiedHistoryRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField-abcd
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * proc-FF6Y2xxxx
   */
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetFieldModifiedHistoryResponseBody extends $tea.Model {
  result?: PremiumGetFieldModifiedHistoryResponseBodyResult[];
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': PremiumGetFieldModifiedHistoryResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetFieldModifiedHistoryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PremiumGetFieldModifiedHistoryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PremiumGetFieldModifiedHistoryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetNoticedInstancesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetNoticedInstancesRequest extends $tea.Model {
  dingClientId?: string;
  keyword?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager001
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dingClientId: 'dingClientId',
      keyword: 'keyword',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingClientId: 'string',
      keyword: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetNoticedInstancesResponseBody extends $tea.Model {
  result?: PremiumGetNoticedInstancesResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PremiumGetNoticedInstancesResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetNoticedInstancesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PremiumGetNoticedInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PremiumGetNoticedInstancesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetProcessInstancesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetProcessInstancesRequest extends $tea.Model {
  /**
   * @example
   * SWAPP-4C2F4B-example
   */
  appUuid?: string;
  /**
   * @example
   * 1633795200000
   */
  endTimeInMills?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @example
   * 1
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-C53-example
   */
  processCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1631289600000
   */
  startTimeInMills?: number;
  static names(): { [key: string]: string } {
    return {
      appUuid: 'appUuid',
      endTimeInMills: 'endTimeInMills',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      processCode: 'processCode',
      startTimeInMills: 'startTimeInMills',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUuid: 'string',
      endTimeInMills: 'number',
      maxResults: 'number',
      nextToken: 'string',
      processCode: 'string',
      startTimeInMills: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetProcessInstancesResponseBody extends $tea.Model {
  result?: PremiumGetProcessInstancesResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PremiumGetProcessInstancesResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetProcessInstancesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PremiumGetProcessInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PremiumGetProcessInstancesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetSubmittedInstancesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetSubmittedInstancesRequest extends $tea.Model {
  dingClientId?: string;
  keyword?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager001
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dingClientId: 'dingClientId',
      keyword: 'keyword',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingClientId: 'string',
      keyword: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetSubmittedInstancesResponseBody extends $tea.Model {
  result?: PremiumGetSubmittedInstancesResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PremiumGetSubmittedInstancesResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetSubmittedInstancesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PremiumGetSubmittedInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PremiumGetSubmittedInstancesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetTodoTasksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetTodoTasksRequest extends $tea.Model {
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  createBefore?: string;
  keyword?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager001
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      createBefore: 'createBefore',
      keyword: 'keyword',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createBefore: 'string',
      keyword: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetTodoTasksResponseBody extends $tea.Model {
  result?: PremiumGetTodoTasksResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PremiumGetTodoTasksResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetTodoTasksResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PremiumGetTodoTasksResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PremiumGetTodoTasksResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumInsertOrUpdateDirHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumInsertOrUpdateDirRequest extends $tea.Model {
  /**
   * @example
   * administeration
   */
  bizGroup?: string;
  /**
   * @example
   * 分组描述信息
   */
  description?: string;
  /**
   * @example
   * 行政管理
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {\"en_US\":\"test\",\"ja_JP\":\"test\",\"vi_VN\":\"test\",\"zh_CN\":\"测试\",\"zh_HK\":\"测试\",\"zh_TW\":\"测试\"}
   */
  name18n?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user001
   */
  operateUserId?: string;
  static names(): { [key: string]: string } {
    return {
      bizGroup: 'bizGroup',
      description: 'description',
      name: 'name',
      name18n: 'name18n',
      operateUserId: 'operateUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizGroup: 'string',
      description: 'string',
      name: 'string',
      name18n: 'string',
      operateUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumInsertOrUpdateDirResponseBody extends $tea.Model {
  result?: PremiumInsertOrUpdateDirResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PremiumInsertOrUpdateDirResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumInsertOrUpdateDirResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PremiumInsertOrUpdateDirResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PremiumInsertOrUpdateDirResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumQueryTodoTasksByManagerHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumQueryTodoTasksByManagerRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * staffId123
   */
  actionerUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager123
   */
  managerUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      actionerUserId: 'actionerUserId',
      managerUserId: 'managerUserId',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionerUserId: 'string',
      managerUserId: 'string',
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumQueryTodoTasksByManagerResponseBody extends $tea.Model {
  result?: PremiumQueryTodoTasksByManagerResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PremiumQueryTodoTasksByManagerResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumQueryTodoTasksByManagerResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PremiumQueryTodoTasksByManagerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PremiumQueryTodoTasksByManagerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumRedirectTasksByManagerHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumRedirectTasksByManagerRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * staffId-B
   */
  handoverUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager-12
   */
  managerUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * **if can be null:**
   * false
   */
  taskIds?: number[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * staffId-A
   */
  transfereeUserId?: string;
  static names(): { [key: string]: string } {
    return {
      handoverUserId: 'handoverUserId',
      managerUserId: 'managerUserId',
      taskIds: 'taskIds',
      transfereeUserId: 'transfereeUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      handoverUserId: 'string',
      managerUserId: 'string',
      taskIds: { 'type': 'array', 'itemType': 'number' },
      transfereeUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumRedirectTasksByManagerResponseBody extends $tea.Model {
  result?: PremiumRedirectTasksByManagerResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PremiumRedirectTasksByManagerResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumRedirectTasksByManagerResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PremiumRedirectTasksByManagerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PremiumRedirectTasksByManagerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedProcessHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedProcessRequest extends $tea.Model {
  /**
   * @example
   * 用于员工差旅费用报销使用
   */
  description?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formComponents?: FormComponent[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 出差报销审批
   */
  name?: string;
  /**
   * @example
   * proc-abc
   */
  processCode?: string;
  processFeatureConfig?: PremiumSaveIntegratedProcessRequestProcessFeatureConfig;
  /**
   * **if can be null:**
   * true
   * 
   * @deprecated
   */
  templateConfig?: PremiumSaveIntegratedProcessRequestTemplateConfig;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      formComponents: 'formComponents',
      name: 'name',
      processCode: 'processCode',
      processFeatureConfig: 'processFeatureConfig',
      templateConfig: 'templateConfig',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      formComponents: { 'type': 'array', 'itemType': FormComponent },
      name: 'string',
      processCode: 'string',
      processFeatureConfig: PremiumSaveIntegratedProcessRequestProcessFeatureConfig,
      templateConfig: PremiumSaveIntegratedProcessRequestTemplateConfig,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedProcessResponseBody extends $tea.Model {
  result?: PremiumSaveIntegratedProcessResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PremiumSaveIntegratedProcessResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedProcessResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PremiumSaveIntegratedProcessResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PremiumSaveIntegratedProcessResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedProcessInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedProcessInstanceRequest extends $tea.Model {
  /**
   * @example
   * "{\"mykey\": \"myData\"}"
   */
  bizData?: string;
  formComponentValueList?: PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList[];
  notifiers?: PremiumSaveIntegratedProcessInstanceRequestNotifiers[];
  /**
   * @remarks
   * This parameter is required.
   */
  originatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  processCode?: string;
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://www.dingtalk.com/
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      bizData: 'bizData',
      formComponentValueList: 'formComponentValueList',
      notifiers: 'notifiers',
      originatorUserId: 'originatorUserId',
      processCode: 'processCode',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizData: 'string',
      formComponentValueList: { 'type': 'array', 'itemType': PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList },
      notifiers: { 'type': 'array', 'itemType': PremiumSaveIntegratedProcessInstanceRequestNotifiers },
      originatorUserId: 'string',
      processCode: 'string',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedProcessInstanceResponseBody extends $tea.Model {
  result?: PremiumSaveIntegratedProcessInstanceResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PremiumSaveIntegratedProcessInstanceResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedProcessInstanceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PremiumSaveIntegratedProcessInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PremiumSaveIntegratedProcessInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedTaskRequest extends $tea.Model {
  /**
   * @example
   * act_xxxx
   */
  activityId?: string;
  featureConfig?: PremiumSaveIntegratedTaskRequestFeatureConfig;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * tPr_FB_mT_xxxxxxxxx2hQ05201655306463
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  tasks?: PremiumSaveIntegratedTaskRequestTasks[];
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      featureConfig: 'featureConfig',
      processInstanceId: 'processInstanceId',
      tasks: 'tasks',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      featureConfig: PremiumSaveIntegratedTaskRequestFeatureConfig,
      processInstanceId: 'string',
      tasks: { 'type': 'array', 'itemType': PremiumSaveIntegratedTaskRequestTasks },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedTaskResponseBody extends $tea.Model {
  result?: PremiumSaveIntegratedTaskResponseBodyResult[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': PremiumSaveIntegratedTaskResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedTaskResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PremiumSaveIntegratedTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PremiumSaveIntegratedTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessForecastHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessForecastRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  deptId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  formComponentValues?: ProcessForecastRequestFormComponentValues[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-EF6YJL35P2-SCKICSB7P750S0YISYKV3-xxxx-1
   */
  processCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager432
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      formComponentValues: 'formComponentValues',
      processCode: 'processCode',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      formComponentValues: { 'type': 'array', 'itemType': ProcessForecastRequestFormComponentValues },
      processCode: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessForecastResponseBody extends $tea.Model {
  result?: ProcessForecastResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ProcessForecastResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessForecastResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ProcessForecastResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ProcessForecastResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllFormInstancesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllFormInstancesRequest extends $tea.Model {
  /**
   * @example
   * SWAPP-dacdsa-example
   */
  appUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-daccea-example
   */
  formCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
  maxResults?: number;
  /**
   * @example
   * 100010
   */
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      appUuid: 'appUuid',
      formCode: 'formCode',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUuid: 'string',
      formCode: 'string',
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllFormInstancesResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  result?: QueryAllFormInstancesResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryAllFormInstancesResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllFormInstancesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryAllFormInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryAllFormInstancesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllProcessInstancesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllProcessInstancesRequest extends $tea.Model {
  /**
   * @example
   * SWAPP-4C2F4B-example
   */
  appUuid?: string;
  /**
   * @example
   * 1633795200000
   */
  endTimeInMills?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @example
   * 1
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-C53-example
   */
  processCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1631289600000
   */
  startTimeInMills?: number;
  static names(): { [key: string]: string } {
    return {
      appUuid: 'appUuid',
      endTimeInMills: 'endTimeInMills',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      processCode: 'processCode',
      startTimeInMills: 'startTimeInMills',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUuid: 'string',
      endTimeInMills: 'number',
      maxResults: 'number',
      nextToken: 'string',
      processCode: 'string',
      startTimeInMills: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllProcessInstancesResponseBody extends $tea.Model {
  result?: QueryAllProcessInstancesResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryAllProcessInstancesResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllProcessInstancesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryAllProcessInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryAllProcessInstancesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormByBizTypeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormByBizTypeRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SWAPP-abcdef-example
   */
  appUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizTypes?: string[];
  static names(): { [key: string]: string } {
    return {
      appUuid: 'appUuid',
      bizTypes: 'bizTypes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUuid: 'string',
      bizTypes: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormByBizTypeResponseBody extends $tea.Model {
  result?: QueryFormByBizTypeResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryFormByBizTypeResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormByBizTypeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryFormByBizTypeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryFormByBizTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormInstanceRequest extends $tea.Model {
  /**
   * @example
   * SWAPP-dfeacds-example
   */
  appUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-abcdef-example
   */
  formCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 951a8-8828-430c-b3e-example
   */
  formInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      appUuid: 'appUuid',
      formCode: 'formCode',
      formInstanceId: 'formInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUuid: 'string',
      formCode: 'string',
      formInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormInstanceResponseBody extends $tea.Model {
  /**
   * @example
   * SWAPP-dfeacds-example
   */
  appUuid?: string;
  attributes?: { [key: string]: any };
  /**
   * @example
   * 1631870043000
   */
  createTimestamp?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 00003
   */
  creator?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-abcdef-example
   */
  formCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formInstDataList?: QueryFormInstanceResponseBodyFormInstDataList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 951a8-8828-430c-b3e-example
   */
  formInstanceId?: string;
  /**
   * @example
   * 000025
   */
  modifier?: string;
  /**
   * @example
   * 1631870043000
   */
  modifyTimestamp?: number;
  /**
   * @example
   * PROC-abcdef-example
   */
  outBizCode?: string;
  /**
   * @example
   * 951a8-8828-430c-b3e-example
   */
  outInstanceId?: string;
  /**
   * @example
   * xxx提交的表单数据
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      appUuid: 'appUuid',
      attributes: 'attributes',
      createTimestamp: 'createTimestamp',
      creator: 'creator',
      formCode: 'formCode',
      formInstDataList: 'formInstDataList',
      formInstanceId: 'formInstanceId',
      modifier: 'modifier',
      modifyTimestamp: 'modifyTimestamp',
      outBizCode: 'outBizCode',
      outInstanceId: 'outInstanceId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUuid: 'string',
      attributes: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      createTimestamp: 'number',
      creator: 'string',
      formCode: 'string',
      formInstDataList: { 'type': 'array', 'itemType': QueryFormInstanceResponseBodyFormInstDataList },
      formInstanceId: 'string',
      modifier: 'string',
      modifyTimestamp: 'number',
      outBizCode: 'string',
      outInstanceId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormInstanceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryFormInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryFormInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryIntegratedTodoTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryIntegratedTodoTaskRequest extends $tea.Model {
  /**
   * @example
   * 1660036833411
   */
  createBefore?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager001
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      createBefore: 'createBefore',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createBefore: 'number',
      pageNumber: 'number',
      pageSize: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryIntegratedTodoTaskResponseBody extends $tea.Model {
  result?: QueryIntegratedTodoTaskResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryIntegratedTodoTaskResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryIntegratedTodoTaskResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryIntegratedTodoTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryIntegratedTodoTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessByBizCategoryIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessByBizCategoryIdRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc
   */
  bizType?: string;
  /**
   * @example
   * manager123
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessByBizCategoryIdResponseBody extends $tea.Model {
  result?: QueryProcessByBizCategoryIdResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryProcessByBizCategoryIdResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessByBizCategoryIdResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryProcessByBizCategoryIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryProcessByBizCategoryIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaAndProcessHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaAndProcessRequest extends $tea.Model {
  appUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-17428B8C-6C60-xxxx-924C-64F1037AE067
   */
  processCode?: string;
  static names(): { [key: string]: string } {
    return {
      appUuid: 'appUuid',
      processCode: 'processCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUuid: 'string',
      processCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaAndProcessResponseBody extends $tea.Model {
  result?: QuerySchemaAndProcessResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QuerySchemaAndProcessResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaAndProcessResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QuerySchemaAndProcessResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QuerySchemaAndProcessResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaByProcessCodeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaByProcessCodeRequest extends $tea.Model {
  appUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-17428B8C-6C60-xxxx-924C-64F1037AE067
   */
  processCode?: string;
  static names(): { [key: string]: string } {
    return {
      appUuid: 'appUuid',
      processCode: 'processCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUuid: 'string',
      processCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaByProcessCodeResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  result?: QuerySchemaByProcessCodeResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QuerySchemaByProcessCodeResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaByProcessCodeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QuerySchemaByProcessCodeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QuerySchemaByProcessCodeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RedirectWorkflowTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RedirectWorkflowTaskRequest extends $tea.Model {
  /**
   * @example
   * test
   */
  actionName?: string;
  file?: RedirectWorkflowTaskRequestFile;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager001
   */
  operateUserId?: string;
  /**
   * @example
   * 请XX帮忙审批一下
   */
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234567
   */
  taskId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager001
   */
  toUserId?: string;
  static names(): { [key: string]: string } {
    return {
      actionName: 'actionName',
      file: 'file',
      operateUserId: 'operateUserId',
      remark: 'remark',
      taskId: 'taskId',
      toUserId: 'toUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionName: 'string',
      file: RedirectWorkflowTaskRequestFile,
      operateUserId: 'string',
      remark: 'string',
      taskId: 'number',
      toUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RedirectWorkflowTaskResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RedirectWorkflowTaskResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RedirectWorkflowTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: RedirectWorkflowTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveIntegratedInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveIntegratedInstanceRequest extends $tea.Model {
  /**
   * @example
   * "{\"mykey\": \"myData\"}"
   */
  bizData?: string;
  featureConfig?: SaveIntegratedInstanceRequestFeatureConfig;
  formComponentValueList?: SaveIntegratedInstanceRequestFormComponentValueList[];
  notifiers?: SaveIntegratedInstanceRequestNotifiers[];
  /**
   * @remarks
   * This parameter is required.
   */
  originatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  processCode?: string;
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://www.dingtalk.com/
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      bizData: 'bizData',
      featureConfig: 'featureConfig',
      formComponentValueList: 'formComponentValueList',
      notifiers: 'notifiers',
      originatorUserId: 'originatorUserId',
      processCode: 'processCode',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizData: 'string',
      featureConfig: SaveIntegratedInstanceRequestFeatureConfig,
      formComponentValueList: { 'type': 'array', 'itemType': SaveIntegratedInstanceRequestFormComponentValueList },
      notifiers: { 'type': 'array', 'itemType': SaveIntegratedInstanceRequestNotifiers },
      originatorUserId: 'string',
      processCode: 'string',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveIntegratedInstanceResponseBody extends $tea.Model {
  result?: SaveIntegratedInstanceResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SaveIntegratedInstanceResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveIntegratedInstanceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SaveIntegratedInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SaveIntegratedInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveProcessHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveProcessRequest extends $tea.Model {
  /**
   * @example
   * 用于员工差旅费用报销使用
   */
  description?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formComponents?: FormComponent[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 出差报销审批
   */
  name?: string;
  /**
   * @example
   * proc-abc
   */
  processCode?: string;
  processFeatureConfig?: SaveProcessRequestProcessFeatureConfig;
  /**
   * **if can be null:**
   * true
   * 
   * @deprecated
   */
  templateConfig?: SaveProcessRequestTemplateConfig;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      formComponents: 'formComponents',
      name: 'name',
      processCode: 'processCode',
      processFeatureConfig: 'processFeatureConfig',
      templateConfig: 'templateConfig',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      formComponents: { 'type': 'array', 'itemType': FormComponent },
      name: 'string',
      processCode: 'string',
      processFeatureConfig: SaveProcessRequestProcessFeatureConfig,
      templateConfig: SaveProcessRequestTemplateConfig,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveProcessResponseBody extends $tea.Model {
  result?: SaveProcessResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SaveProcessResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveProcessResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SaveProcessResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SaveProcessResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartProcessInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartProcessInstanceRequest extends $tea.Model {
  approvers?: StartProcessInstanceRequestApprovers[];
  ccList?: string[];
  /**
   * @example
   * START、FINISH、START_FINISH
   */
  ccPosition?: string;
  /**
   * @example
   * 1
   */
  deptId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  formComponentValues?: StartProcessInstanceRequestFormComponentValues[];
  /**
   * @example
   * 41605932
   */
  microappAgentId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager432
   */
  originatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-EF6YJL35P2-SCKICSB7P750S0YISYKV3-xxxx-1
   */
  processCode?: string;
  targetSelectActioners?: StartProcessInstanceRequestTargetSelectActioners[];
  static names(): { [key: string]: string } {
    return {
      approvers: 'approvers',
      ccList: 'ccList',
      ccPosition: 'ccPosition',
      deptId: 'deptId',
      formComponentValues: 'formComponentValues',
      microappAgentId: 'microappAgentId',
      originatorUserId: 'originatorUserId',
      processCode: 'processCode',
      targetSelectActioners: 'targetSelectActioners',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approvers: { 'type': 'array', 'itemType': StartProcessInstanceRequestApprovers },
      ccList: { 'type': 'array', 'itemType': 'string' },
      ccPosition: 'string',
      deptId: 'number',
      formComponentValues: { 'type': 'array', 'itemType': StartProcessInstanceRequestFormComponentValues },
      microappAgentId: 'number',
      originatorUserId: 'string',
      processCode: 'string',
      targetSelectActioners: { 'type': 'array', 'itemType': StartProcessInstanceRequestTargetSelectActioners },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartProcessInstanceResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 91ef1076-c3ed-4a78-a7a5-fa29ef2d6252
   */
  instanceId?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartProcessInstanceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: StartProcessInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: StartProcessInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateProcessInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateProcessInstanceRequest extends $tea.Model {
  isSystem?: boolean;
  /**
   * @example
   * 133743186427339452
   */
  operatingUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * a171de6c-8bxxxx
   */
  processInstanceId?: string;
  /**
   * @example
   * 终止说明。
   */
  remark?: string;
  static names(): { [key: string]: string } {
    return {
      isSystem: 'isSystem',
      operatingUserId: 'operatingUserId',
      processInstanceId: 'processInstanceId',
      remark: 'remark',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isSystem: 'boolean',
      operatingUserId: 'string',
      processInstanceId: 'string',
      remark: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateProcessInstanceResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  result?: boolean;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateProcessInstanceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TerminateProcessInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: TerminateProcessInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TodoTasksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TodoTasksRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * staffId123
   */
  actionerUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager123
   */
  managerUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      actionerUserId: 'actionerUserId',
      managerUserId: 'managerUserId',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionerUserId: 'string',
      managerUserId: 'string',
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TodoTasksResponseBody extends $tea.Model {
  result?: TodoTasksResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: TodoTasksResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TodoTasksResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TodoTasksResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: TodoTasksResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateIntegratedTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateIntegratedTaskRequest extends $tea.Model {
  /**
   * @example
   * tPr_FB_mT_xxxxxxxxx2hQ05201655306463
   * 
   * **if can be null:**
   * false
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  tasks?: UpdateIntegratedTaskRequestTasks[];
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
      tasks: 'tasks',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
      tasks: { 'type': 'array', 'itemType': UpdateIntegratedTaskRequestTasks },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateIntegratedTaskResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateIntegratedTaskResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateIntegratedTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateIntegratedTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateProcessInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateProcessInstanceRequest extends $tea.Model {
  notifiers?: UpdateProcessInstanceRequestNotifiers[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc
   */
  processInstanceId?: string;
  /**
   * @example
   * agree
   */
  result?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * COMPLETED
   */
  status?: string;
  static names(): { [key: string]: string } {
    return {
      notifiers: 'notifiers',
      processInstanceId: 'processInstanceId',
      result: 'result',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      notifiers: { 'type': 'array', 'itemType': UpdateProcessInstanceRequestNotifiers },
      processInstanceId: 'string',
      result: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateProcessInstanceResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateProcessInstanceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateProcessInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateProcessInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FormComponentPropsStatField extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * NumberField-abcd
   */
  componentId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 金额
   */
  label?: string;
  /**
   * @example
   * 1
   * 
   * **if can be null:**
   * true
   */
  upper?: string;
  static names(): { [key: string]: string } {
    return {
      componentId: 'componentId',
      label: 'label',
      upper: 'upper',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentId: 'string',
      label: 'string',
      upper: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FormDataSourceTarget extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  appType?: number;
  /**
   * @example
   * SWAPP-abcd
   */
  appUuid?: string;
  bizType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formCode?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      appUuid: 'appUuid',
      bizType: 'bizType',
      formCode: 'formCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'number',
      appUuid: 'string',
      bizType: 'string',
      formCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddApproveDentryAuthRequestFileInfos extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * B1oQixxxx
   */
  fileId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 111
   */
  spaceId?: number;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      spaceId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddProcessInstanceCommentRequestFileAttachments extends $tea.Model {
  /**
   * @example
   * B1oQixxxx
   */
  fileId?: string;
  /**
   * @example
   * 文件名称。
   */
  fileName?: string;
  /**
   * @example
   * 1024
   */
  fileSize?: string;
  /**
   * @example
   * file
   */
  fileType?: string;
  /**
   * @example
   * 123
   */
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      fileName: 'fileName',
      fileSize: 'fileSize',
      fileType: 'fileType',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      fileName: 'string',
      fileSize: 'string',
      fileType: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddProcessInstanceCommentRequestFile extends $tea.Model {
  attachments?: AddProcessInstanceCommentRequestFileAttachments[];
  photos?: string[];
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      photos: 'photos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': AddProcessInstanceCommentRequestFileAttachments },
      photos: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchExecuteProcessInstancesRequestTaskInfoList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * a171de6c-8bxxxx
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  taskId?: number;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
      taskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchTasksRedirectResponseBodyResultRedirectResults extends $tea.Model {
  /**
   * @example
   * 外部流程不允许转交
   */
  errorMsg?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * success
   */
  success?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234567
   */
  taskId?: number;
  static names(): { [key: string]: string } {
    return {
      errorMsg: 'errorMsg',
      success: 'success',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorMsg: 'string',
      success: 'boolean',
      taskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchTasksRedirectResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  failCount?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  redirectResults?: BatchTasksRedirectResponseBodyResultRedirectResults[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      failCount: 'failCount',
      redirectResults: 'redirectResults',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failCount: 'number',
      redirectResults: { 'type': 'array', 'itemType': BatchTasksRedirectResponseBodyResultRedirectResults },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager001
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests extends $tea.Model {
  notifiers?: BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc
   */
  processInstanceId?: string;
  /**
   * @example
   * agree
   */
  result?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * COMPLETED
   */
  status?: string;
  static names(): { [key: string]: string } {
    return {
      notifiers: 'notifiers',
      processInstanceId: 'processInstanceId',
      result: 'result',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      notifiers: { 'type': 'array', 'itemType': BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers },
      processInstanceId: 'string',
      result: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyProcessRequestCopyOptions extends $tea.Model {
  /**
   * @example
   * 1
   */
  copyType?: number;
  static names(): { [key: string]: string } {
    return {
      copyType: 'copyType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      copyType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyProcessRequestSourceProcessVOList extends $tea.Model {
  /**
   * @example
   * abc
   */
  bizType?: string;
  /**
   * @example
   * abc
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * proc-abc
   */
  processCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      name: 'name',
      processCode: 'processCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      name: 'string',
      processCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyProcessResponseBodyResult extends $tea.Model {
  /**
   * @example
   * abc
   */
  bizType?: string;
  /**
   * @example
   * abc
   */
  name?: string;
  /**
   * @example
   * proc-abc
   */
  processCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      name: 'name',
      processCode: 'processCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      name: 'string',
      processCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateIntegratedTaskRequestFeatureConfigFeaturesCallback extends $tea.Model {
  /**
   * @example
   * abc
   */
  apiKey?: string;
  /**
   * @example
   * abc
   */
  appUuid?: string;
  /**
   * @example
   * 1
   */
  version?: string;
  static names(): { [key: string]: string } {
    return {
      apiKey: 'apiKey',
      appUuid: 'appUuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiKey: 'string',
      appUuid: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateIntegratedTaskRequestFeatureConfigFeatures extends $tea.Model {
  callback?: CreateIntegratedTaskRequestFeatureConfigFeaturesCallback;
  /**
   * **if can be null:**
   * true
   */
  config?: string;
  /**
   * @example
   * www.dingtalk.com
   */
  mobileUrl?: string;
  /**
   * @example
   * abc
   */
  name?: string;
  /**
   * @example
   * www.dingtalk.com
   */
  pcUrl?: string;
  /**
   * @example
   * ORIGIN
   */
  runType?: string;
  static names(): { [key: string]: string } {
    return {
      callback: 'callback',
      config: 'config',
      mobileUrl: 'mobileUrl',
      name: 'name',
      pcUrl: 'pcUrl',
      runType: 'runType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callback: CreateIntegratedTaskRequestFeatureConfigFeaturesCallback,
      config: 'string',
      mobileUrl: 'string',
      name: 'string',
      pcUrl: 'string',
      runType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateIntegratedTaskRequestFeatureConfig extends $tea.Model {
  features?: CreateIntegratedTaskRequestFeatureConfigFeatures[];
  static names(): { [key: string]: string } {
    return {
      features: 'features',
    };
  }

  static types(): { [key: string]: any } {
    return {
      features: { 'type': 'array', 'itemType': CreateIntegratedTaskRequestFeatureConfigFeatures },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateIntegratedTaskRequestTasks extends $tea.Model {
  /**
   * @example
   * {\"id\":\"12345\"}
   */
  customData?: string;
  /**
   * @example
   * https://www.dingtalk.com
   */
  url?: string;
  /**
   * @example
   * manager001
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      customData: 'customData',
      url: 'url',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customData: 'string',
      url: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateIntegratedTaskResponseBodyResult extends $tea.Model {
  taskId?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteProcessResponseBodyResult extends $tea.Model {
  /**
   * @example
   * proc-abc
   */
  processCode?: string;
  static names(): { [key: string]: string } {
    return {
      processCode: 'processCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteProcessInstanceRequestFileAttachments extends $tea.Model {
  /**
   * @example
   * B1oQixxxx
   */
  fileId?: string;
  /**
   * @example
   * 文件名称。
   */
  fileName?: string;
  /**
   * @example
   * 1024
   */
  fileSize?: string;
  /**
   * @example
   * file
   */
  fileType?: string;
  /**
   * @example
   * 123
   */
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      fileName: 'fileName',
      fileSize: 'fileSize',
      fileType: 'fileType',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      fileName: 'string',
      fileSize: 'string',
      fileType: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteProcessInstanceRequestFile extends $tea.Model {
  attachments?: ExecuteProcessInstanceRequestFileAttachments[];
  photos?: string[];
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      photos: 'photos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': ExecuteProcessInstanceRequestFileAttachments },
      photos: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FormCreateRequestTemplateConfig extends $tea.Model {
  /**
   * @example
   * abcd
   */
  dirId?: string;
  /**
   * @example
   * true
   */
  disableDeleteProcess?: boolean;
  /**
   * @example
   * true
   */
  disableFormEdit?: boolean;
  /**
   * @example
   * true
   */
  disableHomepage?: boolean;
  /**
   * @example
   * true
   */
  disableResubmit?: boolean;
  /**
   * @example
   * true
   */
  disableStopProcessButton?: boolean;
  /**
   * @example
   * true
   */
  hidden?: boolean;
  /**
   * @example
   * efgh
   */
  originDirId?: string;
  static names(): { [key: string]: string } {
    return {
      dirId: 'dirId',
      disableDeleteProcess: 'disableDeleteProcess',
      disableFormEdit: 'disableFormEdit',
      disableHomepage: 'disableHomepage',
      disableResubmit: 'disableResubmit',
      disableStopProcessButton: 'disableStopProcessButton',
      hidden: 'hidden',
      originDirId: 'originDirId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dirId: 'string',
      disableDeleteProcess: 'boolean',
      disableFormEdit: 'boolean',
      disableHomepage: 'boolean',
      disableResubmit: 'boolean',
      disableStopProcessButton: 'boolean',
      hidden: 'boolean',
      originDirId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FormCreateResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-abcdef-example
   */
  processCode?: string;
  static names(): { [key: string]: string } {
    return {
      processCode: 'processCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAttachmentSpaceResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 3996960664
   */
  spaceId?: number;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConditionFormComponentResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 输入框
   */
  label?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      label: 'label',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      label: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFieldModifiedHistoryResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2024-04-02T11:52Z
   */
  createTime?: string;
  /**
   * @example
   * TextField-abcd
   */
  fieldId?: string;
  /**
   * @example
   * 钉钉1
   */
  name?: string;
  /**
   * @example
   * userId1
   */
  userId?: string;
  /**
   * @example
   * 从 111 修改到 222
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      fieldId: 'fieldId',
      name: 'name',
      userId: 'userId',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      fieldId: 'string',
      name: 'string',
      userId: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHandSignDownloadUrlResponseBodyResult extends $tea.Model {
  /**
   * @example
   * https://dingding-file-zjk.oss-cn-zhangjiakouxxxx
   */
  downloadUrl?: string;
  expireIn?: number;
  static names(): { [key: string]: string } {
    return {
      downloadUrl: 'downloadUrl',
      expireIn: 'expireIn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      downloadUrl: 'string',
      expireIn: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetManageProcessByStaffIdResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 0
   */
  attendanceType?: number;
  /**
   * @example
   * 通用审批
   */
  flowTitle?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2020-07-14 14:24:59
   */
  gmtModified?: string;
  /**
   * @example
   * common
   */
  iconName?: string;
  /**
   * @example
   * https://gw.alicdn.com/tfs/xxxx-112-112.png
   */
  iconUrl?: string;
  /**
   * @example
   * true
   */
  newProcess?: boolean;
  /**
   * @example
   * PROC-44E84FC1-16E2-4A69-BB3C-xxxx
   */
  processCode?: string;
  static names(): { [key: string]: string } {
    return {
      attendanceType: 'attendanceType',
      flowTitle: 'flowTitle',
      gmtModified: 'gmtModified',
      iconName: 'iconName',
      iconUrl: 'iconUrl',
      newProcess: 'newProcess',
      processCode: 'processCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendanceType: 'number',
      flowTitle: 'string',
      gmtModified: 'string',
      iconName: 'string',
      iconUrl: 'string',
      newProcess: 'boolean',
      processCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessCodeByNameResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2024-03-22T11:50Z
   */
  gmtModified?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-abcdef-example
   */
  processCode?: string;
  static names(): { [key: string]: string } {
    return {
      gmtModified: 'gmtModified',
      processCode: 'processCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtModified: 'string',
      processCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessConfigResponseBodyResultCommentConf extends $tea.Model {
  /**
   * @example
   * 评论描述
   */
  commentDescription?: string;
  commentHiddenForProposer?: boolean;
  commentRequired?: boolean;
  static names(): { [key: string]: string } {
    return {
      commentDescription: 'commentDescription',
      commentHiddenForProposer: 'commentHiddenForProposer',
      commentRequired: 'commentRequired',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commentDescription: 'string',
      commentHiddenForProposer: 'boolean',
      commentRequired: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessConfigResponseBodyResultHandSignConf extends $tea.Model {
  handSignEnable?: boolean;
  resignEnable?: boolean;
  static names(): { [key: string]: string } {
    return {
      handSignEnable: 'handSignEnable',
      resignEnable: 'resignEnable',
    };
  }

  static types(): { [key: string]: any } {
    return {
      handSignEnable: 'boolean',
      resignEnable: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList extends $tea.Model {
  /**
   * @example
   * 钉三多
   */
  name?: string;
  /**
   * @example
   * approval
   */
  type?: string;
  /**
   * @example
   * manager1234
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      type: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessConfigResponseBodyResultSubstituteSubmitConf extends $tea.Model {
  enable?: boolean;
  submitterList?: GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList[];
  static names(): { [key: string]: string } {
    return {
      enable: 'enable',
      submitterList: 'submitterList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enable: 'boolean',
      submitterList: { 'type': 'array', 'itemType': GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessConfigResponseBodyResultTitleGenRule extends $tea.Model {
  /**
   * @example
   * #{originator}#{formName}#{createTime}
   */
  express?: string;
  /**
   * @example
   * 2
   */
  type?: number;
  static names(): { [key: string]: string } {
    return {
      express: 'express',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      express: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessConfigResponseBodyResultVisibility extends $tea.Model {
  /**
   * @example
   * 1
   */
  type?: number;
  /**
   * @example
   * manager345
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'number',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessConfigResponseBodyResult extends $tea.Model {
  abstractGenRule?: string[];
  /**
   * @example
   * {"sid_instStart":[{"fieldId":"TextField-K2AD4O5B","fieldBehavior":"HIDDEN","componentName":"TextField","disableBehaviors":[]}],"1918_5cd3":[{"fieldId":"TextField-K2AD4O5B","fieldBehavior":"HIDDEN","componentName":"TextField","disableBehaviors":[]}],"d01c_a677":[{"fieldId":"TextField-K2AD4O5B","fieldBehavior":"NORMAL","componentName":"TextField","disableBehaviors":[]}]}
   */
  activityAuth?: string;
  allowRevoke?: boolean;
  appendEnable?: boolean;
  autoExecuteOriginatorTasks?: boolean;
  /**
   * @example
   * alitrip.business
   */
  bizCategoryId?: string;
  /**
   * @example
   * crm_customer
   */
  bizType?: string;
  commentConf?: GetProcessConfigResponseBodyResultCommentConf;
  /**
   * @example
   * continuousFirst
   */
  duplicateRemoval?: string;
  /**
   * @example
   * {"items":[]}
   */
  formSchema?: string;
  handSignConf?: GetProcessConfigResponseBodyResultHandSignConf;
  managers?: string[];
  /**
   * @example
   * 模板名称
   */
  name?: string;
  processAppType?: boolean;
  /**
   * @example
   * {"type":"","properties":{},"childNode":{}}
   */
  processConfig?: string;
  staticProc?: boolean;
  substituteSubmitConf?: GetProcessConfigResponseBodyResultSubstituteSubmitConf;
  titleGenRule?: GetProcessConfigResponseBodyResultTitleGenRule;
  visibility?: GetProcessConfigResponseBodyResultVisibility[];
  static names(): { [key: string]: string } {
    return {
      abstractGenRule: 'abstractGenRule',
      activityAuth: 'activityAuth',
      allowRevoke: 'allowRevoke',
      appendEnable: 'appendEnable',
      autoExecuteOriginatorTasks: 'autoExecuteOriginatorTasks',
      bizCategoryId: 'bizCategoryId',
      bizType: 'bizType',
      commentConf: 'commentConf',
      duplicateRemoval: 'duplicateRemoval',
      formSchema: 'formSchema',
      handSignConf: 'handSignConf',
      managers: 'managers',
      name: 'name',
      processAppType: 'processAppType',
      processConfig: 'processConfig',
      staticProc: 'staticProc',
      substituteSubmitConf: 'substituteSubmitConf',
      titleGenRule: 'titleGenRule',
      visibility: 'visibility',
    };
  }

  static types(): { [key: string]: any } {
    return {
      abstractGenRule: { 'type': 'array', 'itemType': 'string' },
      activityAuth: 'string',
      allowRevoke: 'boolean',
      appendEnable: 'boolean',
      autoExecuteOriginatorTasks: 'boolean',
      bizCategoryId: 'string',
      bizType: 'string',
      commentConf: GetProcessConfigResponseBodyResultCommentConf,
      duplicateRemoval: 'string',
      formSchema: 'string',
      handSignConf: GetProcessConfigResponseBodyResultHandSignConf,
      managers: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      processAppType: 'boolean',
      processConfig: 'string',
      staticProc: 'boolean',
      substituteSubmitConf: GetProcessConfigResponseBodyResultSubstituteSubmitConf,
      titleGenRule: GetProcessConfigResponseBodyResultTitleGenRule,
      visibility: { 'type': 'array', 'itemType': GetProcessConfigResponseBodyResultVisibility },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceResponseBodyResultFormComponentValues extends $tea.Model {
  /**
   * @example
   * TextField-bizAlias
   */
  bizAlias?: string;
  /**
   * @example
   * DDSelectField
   */
  componentType?: string;
  /**
   * @example
   * 示例值
   */
  extValue?: string;
  /**
   * @example
   * DDHolidayField-J2Bxxxx
   */
  id?: string;
  /**
   * @example
   * 组件1
   */
  name?: string;
  /**
   * @example
   * 示例值
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      componentType: 'componentType',
      extValue: 'extValue',
      id: 'id',
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      componentType: 'string',
      extValue: 'string',
      id: 'string',
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceResponseBodyResultOperationRecordsAttachments extends $tea.Model {
  /**
   * @example
   * 111
   */
  fileId?: string;
  /**
   * @example
   * 学历证明
   */
  fileName?: string;
  /**
   * @example
   * 1024
   */
  fileSize?: string;
  /**
   * @example
   * pdf
   */
  fileType?: string;
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      fileName: 'fileName',
      fileSize: 'fileSize',
      fileType: 'fileType',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      fileName: 'string',
      fileSize: 'string',
      fileType: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceResponseBodyResultOperationRecords extends $tea.Model {
  activityId?: string;
  attachments?: GetProcessInstanceResponseBodyResultOperationRecordsAttachments[];
  ccUserIds?: string[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2022-08-31T11:52Z
   */
  date?: string;
  images?: string[];
  /**
   * @example
   * 评论
   */
  remark?: string;
  /**
   * @example
   * AGREE
   */
  result?: string;
  showName?: string;
  /**
   * @example
   * EXECUTE_TASK_NORMAL
   */
  type?: string;
  /**
   * @example
   * manager1
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      attachments: 'attachments',
      ccUserIds: 'ccUserIds',
      date: 'date',
      images: 'images',
      remark: 'remark',
      result: 'result',
      showName: 'showName',
      type: 'type',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      attachments: { 'type': 'array', 'itemType': GetProcessInstanceResponseBodyResultOperationRecordsAttachments },
      ccUserIds: { 'type': 'array', 'itemType': 'string' },
      date: 'string',
      images: { 'type': 'array', 'itemType': 'string' },
      remark: 'string',
      result: 'string',
      showName: 'string',
      type: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceResponseBodyResultTasks extends $tea.Model {
  /**
   * @example
   * 111
   */
  activityId?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2022-08-31T11:52Z
   */
  createTime?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2022-08-31T11:52Z
   */
  finishTime?: string;
  /**
   * @example
   * https://www.xxxx.com
   */
  mobileUrl?: string;
  /**
   * @example
   * https://www.xxxx.com
   */
  pcUrl?: string;
  /**
   * @example
   * 111
   */
  processInstanceId?: string;
  /**
   * @example
   * REDIRECTED
   */
  result?: string;
  /**
   * @example
   * NEW
   */
  status?: string;
  /**
   * @example
   * 111
   */
  taskId?: number;
  /**
   * @example
   * manager1
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      createTime: 'createTime',
      finishTime: 'finishTime',
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
      processInstanceId: 'processInstanceId',
      result: 'result',
      status: 'status',
      taskId: 'taskId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      createTime: 'string',
      finishTime: 'string',
      mobileUrl: 'string',
      pcUrl: 'string',
      processInstanceId: 'string',
      result: 'string',
      status: 'string',
      taskId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceResponseBodyResult extends $tea.Model {
  approverUserIds?: string[];
  /**
   * @example
   * ["instance1","instance2"]
   */
  attachedProcessInstanceIds?: string[];
  /**
   * @example
   * MODIFY
   */
  bizAction?: string;
  /**
   * @example
   * {"mykey": "myData"}
   */
  bizData?: string;
  /**
   * @example
   * 111
   */
  businessId?: string;
  ccUserIds?: string[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2022-08-31T11:52Z
   */
  createTime?: string;
  /**
   * @example
   * 2022-08-31T11:52Z
   */
  finishTime?: string;
  formComponentValues?: GetProcessInstanceResponseBodyResultFormComponentValues[];
  /**
   * @example
   * AG3U12xWRFex63h6bCPUWw10221698052827
   */
  mainProcessInstanceId?: string;
  operationRecords?: GetProcessInstanceResponseBodyResultOperationRecords[];
  /**
   * @example
   * -1
   */
  originatorDeptId?: string;
  /**
   * @example
   * 测试
   */
  originatorDeptName?: string;
  /**
   * @example
   * manager1
   */
  originatorUserId?: string;
  /**
   * @example
   * agree
   */
  result?: string;
  /**
   * @example
   * NEW
   */
  status?: string;
  tasks?: GetProcessInstanceResponseBodyResultTasks[];
  /**
   * @example
   * xx提交的请假申请
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      approverUserIds: 'approverUserIds',
      attachedProcessInstanceIds: 'attachedProcessInstanceIds',
      bizAction: 'bizAction',
      bizData: 'bizData',
      businessId: 'businessId',
      ccUserIds: 'ccUserIds',
      createTime: 'createTime',
      finishTime: 'finishTime',
      formComponentValues: 'formComponentValues',
      mainProcessInstanceId: 'mainProcessInstanceId',
      operationRecords: 'operationRecords',
      originatorDeptId: 'originatorDeptId',
      originatorDeptName: 'originatorDeptName',
      originatorUserId: 'originatorUserId',
      result: 'result',
      status: 'status',
      tasks: 'tasks',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approverUserIds: { 'type': 'array', 'itemType': 'string' },
      attachedProcessInstanceIds: { 'type': 'array', 'itemType': 'string' },
      bizAction: 'string',
      bizData: 'string',
      businessId: 'string',
      ccUserIds: { 'type': 'array', 'itemType': 'string' },
      createTime: 'string',
      finishTime: 'string',
      formComponentValues: { 'type': 'array', 'itemType': GetProcessInstanceResponseBodyResultFormComponentValues },
      mainProcessInstanceId: 'string',
      operationRecords: { 'type': 'array', 'itemType': GetProcessInstanceResponseBodyResultOperationRecords },
      originatorDeptId: 'string',
      originatorDeptName: 'string',
      originatorUserId: 'string',
      result: 'string',
      status: 'string',
      tasks: { 'type': 'array', 'itemType': GetProcessInstanceResponseBodyResultTasks },
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceWithExtraResponseBodyResultFormComponentValues extends $tea.Model {
  bizAlias?: string;
  componentType?: string;
  extValue?: string;
  /**
   * @example
   * DDHolidayField-J2Bxxxx
   */
  id?: string;
  /**
   * @example
   * 组件1
   */
  name?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      componentType: 'componentType',
      extValue: 'extValue',
      id: 'id',
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      componentType: 'string',
      extValue: 'string',
      id: 'string',
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments extends $tea.Model {
  /**
   * @example
   * 12345
   */
  fileId?: string;
  /**
   * @example
   * 学历证明
   */
  fileName?: string;
  /**
   * @example
   * 50000
   */
  fileSize?: string;
  /**
   * @example
   * .pdf
   */
  fileType?: string;
  /**
   * @example
   * 158469
   */
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      fileName: 'fileName',
      fileSize: 'fileSize',
      fileType: 'fileType',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      fileName: 'string',
      fileSize: 'string',
      fileType: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceWithExtraResponseBodyResultOperationRecords extends $tea.Model {
  /**
   * @example
   * aacc_ddee
   */
  activityId?: string;
  attachments?: GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments[];
  ccUserIds?: string[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2022-08-31T11:52Z
   */
  date?: string;
  /**
   * @example
   * AzBltRlvKukX3WsbLxpDnTZskRNK5GtVfuDlDQ_Qxsp
   */
  handSignToken?: string;
  images?: string[];
  remark?: string;
  /**
   * @example
   * AGREE
   */
  result?: string;
  /**
   * @example
   * 审批人节点
   */
  showName?: string;
  /**
   * @example
   * EXECUTE_TASK_NORMAL
   */
  type?: string;
  /**
   * @example
   * manager123
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      attachments: 'attachments',
      ccUserIds: 'ccUserIds',
      date: 'date',
      handSignToken: 'handSignToken',
      images: 'images',
      remark: 'remark',
      result: 'result',
      showName: 'showName',
      type: 'type',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      attachments: { 'type': 'array', 'itemType': GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments },
      ccUserIds: { 'type': 'array', 'itemType': 'string' },
      date: 'string',
      handSignToken: 'string',
      images: { 'type': 'array', 'itemType': 'string' },
      remark: 'string',
      result: 'string',
      showName: 'string',
      type: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceWithExtraResponseBodyResultTasks extends $tea.Model {
  /**
   * @example
   * aabb_ccdd
   */
  activityId?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2024-06-12T14:17Z
   */
  createTime?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2024-06-12T14:17Z
   */
  finishTime?: string;
  /**
   * @example
   * aflow.dingtalk.com?procInsId=lTGxxx
   */
  mobileUrl?: string;
  /**
   * @example
   * aflow.dingtalk.com?procInsId=lTGxxx
   */
  pcUrl?: string;
  /**
   * @example
   * fewferxxxx
   */
  processInstanceId?: string;
  /**
   * @example
   * REDIRECTED
   */
  result?: string;
  /**
   * @example
   * CANCELED
   */
  status?: string;
  taskId?: number;
  /**
   * @example
   * manager123
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      createTime: 'createTime',
      finishTime: 'finishTime',
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
      processInstanceId: 'processInstanceId',
      result: 'result',
      status: 'status',
      taskId: 'taskId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      createTime: 'string',
      finishTime: 'string',
      mobileUrl: 'string',
      pcUrl: 'string',
      processInstanceId: 'string',
      result: 'string',
      status: 'string',
      taskId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessInstanceWithExtraResponseBodyResult extends $tea.Model {
  approverUserIds?: string[];
  attachedProcessInstanceIds?: string[];
  /**
   * @example
   * MODIFY
   */
  bizAction?: string;
  bizData?: string;
  /**
   * @example
   * 20240505xxxx
   */
  businessId?: string;
  ccUserIds?: string[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2022-08-31T11:52Z
   */
  createTime?: string;
  /**
   * @example
   * 2022-08-31T11:52Z
   */
  finishTime?: string;
  formComponentValues?: GetProcessInstanceWithExtraResponseBodyResultFormComponentValues[];
  /**
   * @example
   * fvdsfxxxxxx
   */
  mainProcessInstanceId?: string;
  operationRecords?: GetProcessInstanceWithExtraResponseBodyResultOperationRecords[];
  /**
   * @example
   * 25489
   */
  originatorDeptId?: string;
  /**
   * @example
   * 测试部门
   */
  originatorDeptName?: string;
  /**
   * @example
   * manager1
   */
  originatorUserId?: string;
  /**
   * @example
   * agree
   */
  result?: string;
  status?: string;
  tasks?: GetProcessInstanceWithExtraResponseBodyResultTasks[];
  /**
   * @example
   * xx提交的请假申请
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      approverUserIds: 'approverUserIds',
      attachedProcessInstanceIds: 'attachedProcessInstanceIds',
      bizAction: 'bizAction',
      bizData: 'bizData',
      businessId: 'businessId',
      ccUserIds: 'ccUserIds',
      createTime: 'createTime',
      finishTime: 'finishTime',
      formComponentValues: 'formComponentValues',
      mainProcessInstanceId: 'mainProcessInstanceId',
      operationRecords: 'operationRecords',
      originatorDeptId: 'originatorDeptId',
      originatorDeptName: 'originatorDeptName',
      originatorUserId: 'originatorUserId',
      result: 'result',
      status: 'status',
      tasks: 'tasks',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approverUserIds: { 'type': 'array', 'itemType': 'string' },
      attachedProcessInstanceIds: { 'type': 'array', 'itemType': 'string' },
      bizAction: 'string',
      bizData: 'string',
      businessId: 'string',
      ccUserIds: { 'type': 'array', 'itemType': 'string' },
      createTime: 'string',
      finishTime: 'string',
      formComponentValues: { 'type': 'array', 'itemType': GetProcessInstanceWithExtraResponseBodyResultFormComponentValues },
      mainProcessInstanceId: 'string',
      operationRecords: { 'type': 'array', 'itemType': GetProcessInstanceWithExtraResponseBodyResultOperationRecords },
      originatorDeptId: 'string',
      originatorDeptName: 'string',
      originatorUserId: 'string',
      result: 'string',
      status: 'string',
      tasks: { 'type': 'array', 'itemType': GetProcessInstanceWithExtraResponseBodyResultTasks },
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSchemaAndProcessconfigBatchllyResponseBodyResult extends $tea.Model {
  appUuid?: string;
  bizCategoryId?: string;
  createTime?: string;
  creatorUserId?: string;
  formUuid?: string;
  managerList?: string;
  memo?: string;
  name?: string;
  processCode?: string;
  processConfig?: string;
  processId?: number;
  properties?: string;
  schemaContent?: string;
  visibleScope?: string;
  static names(): { [key: string]: string } {
    return {
      appUuid: 'appUuid',
      bizCategoryId: 'bizCategoryId',
      createTime: 'createTime',
      creatorUserId: 'creatorUserId',
      formUuid: 'formUuid',
      managerList: 'managerList',
      memo: 'memo',
      name: 'name',
      processCode: 'processCode',
      processConfig: 'processConfig',
      processId: 'processId',
      properties: 'properties',
      schemaContent: 'schemaContent',
      visibleScope: 'visibleScope',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUuid: 'string',
      bizCategoryId: 'string',
      createTime: 'string',
      creatorUserId: 'string',
      formUuid: 'string',
      managerList: 'string',
      memo: 'string',
      name: 'string',
      processCode: 'string',
      processConfig: 'string',
      processId: 'number',
      properties: 'string',
      schemaContent: 'string',
      visibleScope: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceWithDownloadAuthResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 3996960664
   */
  spaceId?: number;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantProcessInstanceForDownloadFileResponseBodyResult extends $tea.Model {
  /**
   * @example
   * http://lippi-space-zjk.oss-cn-zhangjiakou.aliyuncs.com/xxxxx
   */
  downloadUri?: string;
  /**
   * @example
   * 26748422566
   */
  fileId?: string;
  /**
   * @example
   * 3996960664
   */
  spaceId?: number;
  static names(): { [key: string]: string } {
    return {
      downloadUri: 'downloadUri',
      fileId: 'fileId',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      downloadUri: 'string',
      fileId: 'string',
      spaceId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertOrUpdateDirResponseBodyResult extends $tea.Model {
  /**
   * @example
   * {应用appId}_administeration
   */
  bizGroup?: string;
  /**
   * @example
   * oaDirIdxxx
   */
  dirId?: string;
  static names(): { [key: string]: string } {
    return {
      bizGroup: 'bizGroup',
      dirId: 'dirId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizGroup: 'string',
      dirId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallAppRequestInstallOption extends $tea.Model {
  isSync?: boolean;
  static names(): { [key: string]: string } {
    return {
      isSync: 'isSync',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isSync: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallAppResponseBodyResult extends $tea.Model {
  /**
   * @example
   * abc
   */
  bizType?: string;
  /**
   * @example
   * abc
   */
  name?: string;
  /**
   * @example
   * PROC-ABC
   */
  processCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      name: 'name',
      processCode: 'processCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      name: 'string',
      processCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListProcessInstanceIdsResponseBodyResult extends $tea.Model {
  list?: string[];
  /**
   * @example
   * 10
   */
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': 'string' },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTodoWorkRecordsResponseBodyResultListForms extends $tea.Model {
  /**
   * @example
   * 钉三多
   */
  content?: string;
  /**
   * @example
   * 入职员工姓名
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTodoWorkRecordsResponseBodyResultList extends $tea.Model {
  forms?: ListTodoWorkRecordsResponseBodyResultListForms[];
  /**
   * @example
   * Siw2WNVZS4KiUt3tTmaNKg04*****809950
   */
  instanceId?: string;
  /**
   * @example
   * 1234567
   */
  taskId?: number;
  /**
   * @example
   * xxx提交的入职审批
   */
  title?: string;
  /**
   * @example
   * https://www.dingtalk.com
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      forms: 'forms',
      instanceId: 'instanceId',
      taskId: 'taskId',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      forms: { 'type': 'array', 'itemType': ListTodoWorkRecordsResponseBodyResultListForms },
      instanceId: 'string',
      taskId: 'number',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTodoWorkRecordsResponseBodyResult extends $tea.Model {
  list?: ListTodoWorkRecordsResponseBodyResultList[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': ListTodoWorkRecordsResponseBodyResultList },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserVisibleBpmsProcessesResponseBodyResultProcessList extends $tea.Model {
  /**
   * @example
   * 12347899
   */
  dirId?: string;
  /**
   * @example
   * 财务管理
   */
  dirName?: string;
  /**
   * @example
   * https://gw.xxxx/T-102-102.png
   */
  iconUrl?: string;
  /**
   * @example
   * 物品领用
   */
  name?: string;
  /**
   * @example
   * PROC-YMLA1-xxxx-11WFJ-1
   */
  processCode?: string;
  /**
   * @example
   * https://aflow.dingtalk.com/dingtalk/mobile/homepage.htm?xxxx
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      dirId: 'dirId',
      dirName: 'dirName',
      iconUrl: 'iconUrl',
      name: 'name',
      processCode: 'processCode',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dirId: 'string',
      dirName: 'string',
      iconUrl: 'string',
      name: 'string',
      processCode: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserVisibleBpmsProcessesResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 10
   */
  nextToken?: number;
  processList?: ListUserVisibleBpmsProcessesResponseBodyResultProcessList[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      processList: 'processList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'number',
      processList: { 'type': 'array', 'itemType': ListUserVisibleBpmsProcessesResponseBodyResultProcessList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PagesExportInstancesResponseBodyResultListFormComponentValues extends $tea.Model {
  componentName?: string;
  /**
   * @example
   * {"staffId":"abcd"}
   */
  extValue?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField-a32bcdef
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 姓名
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 张三
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      extValue: 'extValue',
      id: 'id',
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      extValue: 'string',
      id: 'string',
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PagesExportInstancesResponseBodyResultListOperationRecordsAttachments extends $tea.Model {
  /**
   * @example
   * 1234567
   */
  fileId?: string;
  /**
   * @example
   * 附件
   */
  fileName?: string;
  /**
   * @example
   * 123
   */
  fileSize?: string;
  /**
   * @example
   * pdf
   */
  fileType?: string;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      fileName: 'fileName',
      fileSize: 'fileSize',
      fileType: 'fileType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      fileName: 'string',
      fileSize: 'string',
      fileType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PagesExportInstancesResponseBodyResultListOperationRecords extends $tea.Model {
  /**
   * @example
   * 1234_abcd
   */
  activityId?: string;
  attachments?: PagesExportInstancesResponseBodyResultListOperationRecordsAttachments[];
  /**
   * @example
   * []
   */
  images?: string[];
  /**
   * @example
   * EXECUTE_TASK_NORMAL（正常执行任务），EXECUTE_TASK_AGENT（代理人执行任务），APPEND_TASK_BEFORE（前加签任务），APPEND_TASK_AFTER（后加签任务），REDIRECT_TASK（转交任务），START_PROCESS_INSTANCE（发起流程实例），TERMINATE_PROCESS_INSTANCE（终止(撤销)流程实例），FINISH_PROCESS_INSTANCE（结束流程实例），ADD_REMARK（添加评论）
   */
  operationType?: string;
  /**
   * @example
   * 同意
   */
  remark?: string;
  /**
   * @example
   * AGREE（同意），REFUSE（拒绝），NONE（未知）
   */
  result?: string;
  /**
   * @example
   * 12345
   */
  taskId?: number;
  /**
   * @example
   * 1657522271000
   */
  timestamp?: number;
  /**
   * @example
   * manager1
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      attachments: 'attachments',
      images: 'images',
      operationType: 'operationType',
      remark: 'remark',
      result: 'result',
      taskId: 'taskId',
      timestamp: 'timestamp',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      attachments: { 'type': 'array', 'itemType': PagesExportInstancesResponseBodyResultListOperationRecordsAttachments },
      images: { 'type': 'array', 'itemType': 'string' },
      operationType: 'string',
      remark: 'string',
      result: 'string',
      taskId: 'number',
      timestamp: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PagesExportInstancesResponseBodyResultListTasks extends $tea.Model {
  /**
   * @example
   * 1234_abcd
   */
  activityId?: string;
  /**
   * @example
   * 1657522271000
   */
  createTimestamp?: number;
  /**
   * @example
   * 1657522271000
   */
  finishTimestamp?: number;
  /**
   * @example
   * 分为AGREE（同意），REFUSE（拒绝），REDIRECTED（转交）
   */
  result?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * NEW（未启动），RUNNING（处理中），PAUSED（暂停），CANCELED（取消），COMPLETED（完成），TERMINATED（终止）
   */
  status?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
  taskId?: number;
  /**
   * @example
   * staff1234
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      createTimestamp: 'createTimestamp',
      finishTimestamp: 'finishTimestamp',
      result: 'result',
      status: 'status',
      taskId: 'taskId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      createTimestamp: 'number',
      finishTimestamp: 'number',
      result: 'string',
      status: 'string',
      taskId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PagesExportInstancesResponseBodyResultList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cdef-dae2fd2-example
   */
  attachedProcessInstanceIds?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202110111558000355024
   */
  businessId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1635165470201
   */
  createTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1633795200000
   */
  finishTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  formComponentValues?: PagesExportInstancesResponseBodyResultListFormComponentValues[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dcdse-dae2fd2-example
   */
  mainProcessInstanceId?: string;
  operationRecords?: PagesExportInstancesResponseBodyResultListOperationRecords[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 默认-1，企业根部门
   */
  originatorDeptId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * staff1234
   */
  originatorUserid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcdse-dse-example
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * AGREE同意，REFUSE拒绝
   */
  result?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * RUNNING审批中、TERMINATED撤销、COMPLETED审批完成、CANCELED取消
   */
  status?: string;
  tasks?: PagesExportInstancesResponseBodyResultListTasks[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 员工A提交的小肖审批单
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      attachedProcessInstanceIds: 'attachedProcessInstanceIds',
      businessId: 'businessId',
      createTime: 'createTime',
      finishTime: 'finishTime',
      formComponentValues: 'formComponentValues',
      mainProcessInstanceId: 'mainProcessInstanceId',
      operationRecords: 'operationRecords',
      originatorDeptId: 'originatorDeptId',
      originatorUserid: 'originatorUserid',
      processInstanceId: 'processInstanceId',
      result: 'result',
      status: 'status',
      tasks: 'tasks',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachedProcessInstanceIds: 'string',
      businessId: 'string',
      createTime: 'number',
      finishTime: 'number',
      formComponentValues: { 'type': 'array', 'itemType': PagesExportInstancesResponseBodyResultListFormComponentValues },
      mainProcessInstanceId: 'string',
      operationRecords: { 'type': 'array', 'itemType': PagesExportInstancesResponseBodyResultListOperationRecords },
      originatorDeptId: 'string',
      originatorUserid: 'string',
      processInstanceId: 'string',
      result: 'string',
      status: 'string',
      tasks: { 'type': 'array', 'itemType': PagesExportInstancesResponseBodyResultListTasks },
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PagesExportInstancesResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  hasMore?: boolean;
  list?: PagesExportInstancesResponseBodyResultList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': PagesExportInstancesResponseBodyResultList },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumBatchExecuteProcessInstancesRequestTaskInfoList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * a171de6c-8bxxxx
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  taskId?: number;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
      taskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetDoneTasksResponseBodyResultList extends $tea.Model {
  activityId?: string;
  formMassage?: string;
  originatorId?: string;
  originatorName?: string;
  originatorPhoto?: string;
  pcUrl?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  processCreateTime?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  processEndTime?: string;
  processInstanceId?: string;
  processType?: number;
  /**
   * @example
   * agree
   */
  result?: string;
  /**
   * @example
   * RUNNING
   */
  status?: string;
  taskId?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      formMassage: 'formMassage',
      originatorId: 'originatorId',
      originatorName: 'originatorName',
      originatorPhoto: 'originatorPhoto',
      pcUrl: 'pcUrl',
      processCreateTime: 'processCreateTime',
      processEndTime: 'processEndTime',
      processInstanceId: 'processInstanceId',
      processType: 'processType',
      result: 'result',
      status: 'status',
      taskId: 'taskId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      formMassage: 'string',
      originatorId: 'string',
      originatorName: 'string',
      originatorPhoto: 'string',
      pcUrl: 'string',
      processCreateTime: 'string',
      processEndTime: 'string',
      processInstanceId: 'string',
      processType: 'number',
      result: 'string',
      status: 'string',
      taskId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetDoneTasksResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  list?: PremiumGetDoneTasksResponseBodyResultList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': PremiumGetDoneTasksResponseBodyResultList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetFieldModifiedHistoryResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2024-04-02T11:52Z
   */
  createTime?: string;
  /**
   * @example
   * TextField-abcd
   */
  fieldId?: string;
  /**
   * @example
   * 钉钉1
   */
  name?: string;
  /**
   * @example
   * userId1
   */
  userId?: string;
  /**
   * @example
   * 从 111 修改到 222
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      fieldId: 'fieldId',
      name: 'name',
      userId: 'userId',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      fieldId: 'string',
      name: 'string',
      userId: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetNoticedInstancesResponseBodyResultList extends $tea.Model {
  formMassage?: string;
  originatorId?: string;
  originatorName?: string;
  originatorPhoto?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  processCreateTime?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  processEndTime?: string;
  processInstanceId?: string;
  processType?: number;
  /**
   * @example
   * agree
   */
  result?: string;
  /**
   * @example
   * RUNNING
   */
  status?: string;
  title?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      formMassage: 'formMassage',
      originatorId: 'originatorId',
      originatorName: 'originatorName',
      originatorPhoto: 'originatorPhoto',
      processCreateTime: 'processCreateTime',
      processEndTime: 'processEndTime',
      processInstanceId: 'processInstanceId',
      processType: 'processType',
      result: 'result',
      status: 'status',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formMassage: 'string',
      originatorId: 'string',
      originatorName: 'string',
      originatorPhoto: 'string',
      processCreateTime: 'string',
      processEndTime: 'string',
      processInstanceId: 'string',
      processType: 'number',
      result: 'string',
      status: 'string',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetNoticedInstancesResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  list?: PremiumGetNoticedInstancesResponseBodyResultList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': PremiumGetNoticedInstancesResponseBodyResultList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetProcessInstancesResponseBodyResultListFormComponentValues extends $tea.Model {
  /**
   * @example
   * {"staffId":"abcd"}
   */
  extValue?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField-a32bcdef
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 姓名
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 张三
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      extValue: 'extValue',
      id: 'id',
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extValue: 'string',
      id: 'string',
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetProcessInstancesResponseBodyResultListOperationRecordsAttachments extends $tea.Model {
  /**
   * @example
   * 1234567
   */
  fileId?: string;
  /**
   * @example
   * 附件
   */
  fileName?: string;
  /**
   * @example
   * 123
   */
  fileSize?: string;
  /**
   * @example
   * pdf
   */
  fileType?: string;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      fileName: 'fileName',
      fileSize: 'fileSize',
      fileType: 'fileType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      fileName: 'string',
      fileSize: 'string',
      fileType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetProcessInstancesResponseBodyResultListOperationRecords extends $tea.Model {
  attachments?: PremiumGetProcessInstancesResponseBodyResultListOperationRecordsAttachments[];
  /**
   * @example
   * EXECUTE_TASK_NORMAL（正常执行任务），EXECUTE_TASK_AGENT（代理人执行任务），APPEND_TASK_BEFORE（前加签任务），APPEND_TASK_AFTER（后加签任务），REDIRECT_TASK（转交任务），START_PROCESS_INSTANCE（发起流程实例），TERMINATE_PROCESS_INSTANCE（终止(撤销)流程实例），FINISH_PROCESS_INSTANCE（结束流程实例），ADD_REMARK（添加评论）
   */
  operationType?: string;
  /**
   * @example
   * 同意
   */
  remark?: string;
  /**
   * @example
   * AGREE（同意），REFUSE（拒绝），NONE（未知）
   */
  result?: string;
  /**
   * @example
   * 1657522271000
   */
  timestamp?: number;
  /**
   * @example
   * manager1
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      operationType: 'operationType',
      remark: 'remark',
      result: 'result',
      timestamp: 'timestamp',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': PremiumGetProcessInstancesResponseBodyResultListOperationRecordsAttachments },
      operationType: 'string',
      remark: 'string',
      result: 'string',
      timestamp: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetProcessInstancesResponseBodyResultListTasks extends $tea.Model {
  /**
   * @example
   * 1234_abcd
   */
  activityId?: string;
  /**
   * @example
   * 1657522271000
   */
  createTimestamp?: number;
  /**
   * @example
   * 1657522271000
   */
  finishTimestamp?: number;
  /**
   * @example
   * 分为AGREE（同意），REFUSE（拒绝），REDIRECTED（转交）
   */
  result?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * NEW（未启动），RUNNING（处理中），PAUSED（暂停），CANCELED（取消），COMPLETED（完成），TERMINATED（终止）
   */
  status?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
  taskId?: number;
  /**
   * @example
   * staff1234
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      createTimestamp: 'createTimestamp',
      finishTimestamp: 'finishTimestamp',
      result: 'result',
      status: 'status',
      taskId: 'taskId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      createTimestamp: 'number',
      finishTimestamp: 'number',
      result: 'string',
      status: 'string',
      taskId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetProcessInstancesResponseBodyResultList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cdef-dae2fd2-example
   */
  attachedProcessInstanceIds?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202110111558000355024
   */
  businessId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1635165470201
   */
  createTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1633795200000
   */
  finishTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  formComponentValues?: PremiumGetProcessInstancesResponseBodyResultListFormComponentValues[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dcdse-dae2fd2-example
   */
  mainProcessInstanceId?: string;
  operationRecords?: PremiumGetProcessInstancesResponseBodyResultListOperationRecords[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 默认-1，企业根部门
   */
  originatorDeptId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * staff1234
   */
  originatorUserid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcdse-dse-example
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * AGREE同意，REFUSE拒绝
   */
  result?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * RUNNING审批中、TERMINATED撤销、COMPLETED审批完成、CANCELED取消
   */
  status?: string;
  tasks?: PremiumGetProcessInstancesResponseBodyResultListTasks[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 员工A提交的小肖审批单
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      attachedProcessInstanceIds: 'attachedProcessInstanceIds',
      businessId: 'businessId',
      createTime: 'createTime',
      finishTime: 'finishTime',
      formComponentValues: 'formComponentValues',
      mainProcessInstanceId: 'mainProcessInstanceId',
      operationRecords: 'operationRecords',
      originatorDeptId: 'originatorDeptId',
      originatorUserid: 'originatorUserid',
      processInstanceId: 'processInstanceId',
      result: 'result',
      status: 'status',
      tasks: 'tasks',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachedProcessInstanceIds: 'string',
      businessId: 'string',
      createTime: 'number',
      finishTime: 'number',
      formComponentValues: { 'type': 'array', 'itemType': PremiumGetProcessInstancesResponseBodyResultListFormComponentValues },
      mainProcessInstanceId: 'string',
      operationRecords: { 'type': 'array', 'itemType': PremiumGetProcessInstancesResponseBodyResultListOperationRecords },
      originatorDeptId: 'string',
      originatorUserid: 'string',
      processInstanceId: 'string',
      result: 'string',
      status: 'string',
      tasks: { 'type': 'array', 'itemType': PremiumGetProcessInstancesResponseBodyResultListTasks },
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetProcessInstancesResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  hasMore?: boolean;
  list?: PremiumGetProcessInstancesResponseBodyResultList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': PremiumGetProcessInstancesResponseBodyResultList },
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetSubmittedInstancesResponseBodyResultList extends $tea.Model {
  appType?: number;
  formMassage?: string;
  originatorId?: string;
  originatorName?: string;
  originatorPhoto?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  processCreateTime?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  processEndTime?: string;
  processInstanceId?: string;
  processType?: number;
  /**
   * @example
   * agree
   */
  result?: string;
  /**
   * @example
   * RUNNING
   */
  status?: string;
  title?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      formMassage: 'formMassage',
      originatorId: 'originatorId',
      originatorName: 'originatorName',
      originatorPhoto: 'originatorPhoto',
      processCreateTime: 'processCreateTime',
      processEndTime: 'processEndTime',
      processInstanceId: 'processInstanceId',
      processType: 'processType',
      result: 'result',
      status: 'status',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'number',
      formMassage: 'string',
      originatorId: 'string',
      originatorName: 'string',
      originatorPhoto: 'string',
      processCreateTime: 'string',
      processEndTime: 'string',
      processInstanceId: 'string',
      processType: 'number',
      result: 'string',
      status: 'string',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetSubmittedInstancesResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  list?: PremiumGetSubmittedInstancesResponseBodyResultList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': PremiumGetSubmittedInstancesResponseBodyResultList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetTodoTasksResponseBodyResultList extends $tea.Model {
  activityId?: string;
  appType?: number;
  formMassage?: string;
  originatorId?: string;
  originatorName?: string;
  originatorPhoto?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  processCreateTime?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  processEndTime?: string;
  processInstanceId?: string;
  processType?: number;
  /**
   * @example
   * agree
   */
  result?: string;
  /**
   * @example
   * RUNNING
   */
  status?: string;
  taskId?: string;
  title?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      appType: 'appType',
      formMassage: 'formMassage',
      originatorId: 'originatorId',
      originatorName: 'originatorName',
      originatorPhoto: 'originatorPhoto',
      processCreateTime: 'processCreateTime',
      processEndTime: 'processEndTime',
      processInstanceId: 'processInstanceId',
      processType: 'processType',
      result: 'result',
      status: 'status',
      taskId: 'taskId',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      appType: 'number',
      formMassage: 'string',
      originatorId: 'string',
      originatorName: 'string',
      originatorPhoto: 'string',
      processCreateTime: 'string',
      processEndTime: 'string',
      processInstanceId: 'string',
      processType: 'number',
      result: 'string',
      status: 'string',
      taskId: 'string',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumGetTodoTasksResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  list?: PremiumGetTodoTasksResponseBodyResultList[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': PremiumGetTodoTasksResponseBodyResultList },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumInsertOrUpdateDirResponseBodyResult extends $tea.Model {
  /**
   * @example
   * {应用appId}_administeration
   */
  bizGroup?: string;
  /**
   * @example
   * oaDirIdxxx
   */
  dirId?: string;
  static names(): { [key: string]: string } {
    return {
      bizGroup: 'bizGroup',
      dirId: 'dirId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizGroup: 'string',
      dirId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumQueryTodoTasksByManagerResponseBodyResultList extends $tea.Model {
  /**
   * @example
   * RUNNING
   */
  businessId?: string;
  canRedirect?: boolean;
  createTime?: number;
  /**
   * @example
   * act_0001
   */
  processCode?: string;
  /**
   * @example
   * Siw2WNVZS4KiUt3tTmaNKg04*****809950
   */
  processInstanceId?: string;
  /**
   * @example
   * 1234567
   */
  taskId?: number;
  /**
   * @example
   * manager001
   */
  title?: string;
  /**
   * @example
   * 2022-10-17T15:12Z
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      businessId: 'businessId',
      canRedirect: 'canRedirect',
      createTime: 'createTime',
      processCode: 'processCode',
      processInstanceId: 'processInstanceId',
      taskId: 'taskId',
      title: 'title',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      businessId: 'string',
      canRedirect: 'boolean',
      createTime: 'number',
      processCode: 'string',
      processInstanceId: 'string',
      taskId: 'number',
      title: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumQueryTodoTasksByManagerResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  list?: PremiumQueryTodoTasksByManagerResponseBodyResultList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': PremiumQueryTodoTasksByManagerResponseBodyResultList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumRedirectTasksByManagerResponseBodyResultRedirectResults extends $tea.Model {
  /**
   * @example
   * 外部流程不允许转交
   */
  errorMsg?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * success
   */
  success?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234567
   */
  taskId?: number;
  static names(): { [key: string]: string } {
    return {
      errorMsg: 'errorMsg',
      success: 'success',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorMsg: 'string',
      success: 'boolean',
      taskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumRedirectTasksByManagerResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  failCount?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  redirectResults?: PremiumRedirectTasksByManagerResponseBodyResultRedirectResults[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      failCount: 'failCount',
      redirectResults: 'redirectResults',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failCount: 'number',
      redirectResults: { 'type': 'array', 'itemType': PremiumRedirectTasksByManagerResponseBodyResultRedirectResults },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback extends $tea.Model {
  /**
   * @example
   * abc
   */
  apiKey?: string;
  /**
   * @example
   * abc
   */
  appUuid?: string;
  /**
   * @example
   * 1
   */
  version?: string;
  static names(): { [key: string]: string } {
    return {
      apiKey: 'apiKey',
      appUuid: 'appUuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiKey: 'string',
      appUuid: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures extends $tea.Model {
  callback?: PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback;
  /**
   * @example
   * www.dingtalk.com
   */
  mobileUrl?: string;
  /**
   * @example
   * abc
   */
  name?: string;
  /**
   * @example
   * www.dingtalk.com
   */
  pcUrl?: string;
  /**
   * @example
   * ORIGIN
   */
  runType?: string;
  static names(): { [key: string]: string } {
    return {
      callback: 'callback',
      mobileUrl: 'mobileUrl',
      name: 'name',
      pcUrl: 'pcUrl',
      runType: 'runType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callback: PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback,
      mobileUrl: 'string',
      name: 'string',
      pcUrl: 'string',
      runType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedProcessRequestProcessFeatureConfig extends $tea.Model {
  features?: PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures[];
  static names(): { [key: string]: string } {
    return {
      features: 'features',
    };
  }

  static types(): { [key: string]: any } {
    return {
      features: { 'type': 'array', 'itemType': PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedProcessRequestTemplateConfig extends $tea.Model {
  /**
   * @example
   * https://open.dingtalk.com/
   * 
   * @deprecated
   */
  createInstanceMobileUrl?: string;
  /**
   * @example
   * https://open.dingtalk.com/
   * 
   * @deprecated
   */
  createInstancePcUrl?: string;
  /**
   * **if can be null:**
   * true
   */
  disableSendCard?: boolean;
  /**
   * @example
   * true
   */
  hidden?: boolean;
  /**
   * @example
   * https://open.dingtalk.com/
   * 
   * **if can be null:**
   * true
   * 
   * @deprecated
   */
  templateEditUrl?: string;
  static names(): { [key: string]: string } {
    return {
      createInstanceMobileUrl: 'createInstanceMobileUrl',
      createInstancePcUrl: 'createInstancePcUrl',
      disableSendCard: 'disableSendCard',
      hidden: 'hidden',
      templateEditUrl: 'templateEditUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createInstanceMobileUrl: 'string',
      createInstancePcUrl: 'string',
      disableSendCard: 'boolean',
      hidden: 'boolean',
      templateEditUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedProcessResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-abcdef-example
   */
  processCode?: string;
  static names(): { [key: string]: string } {
    return {
      processCode: 'processCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList extends $tea.Model {
  bizAlias?: string;
  componentType?: string;
  extValue?: string;
  id?: string;
  name?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      componentType: 'componentType',
      extValue: 'extValue',
      id: 'id',
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      componentType: 'string',
      extValue: 'string',
      id: 'string',
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedProcessInstanceRequestNotifiers extends $tea.Model {
  /**
   * @example
   * start
   */
  position?: string;
  /**
   * @example
   * manager001
   */
  userid?: string;
  static names(): { [key: string]: string } {
    return {
      position: 'position',
      userid: 'userid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      position: 'string',
      userid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedProcessInstanceResponseBodyResult extends $tea.Model {
  /**
   * @example
   * proc-abc
   */
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback extends $tea.Model {
  /**
   * @example
   * abc
   */
  apiKey?: string;
  /**
   * @example
   * abc
   */
  appUuid?: string;
  /**
   * @example
   * 1
   */
  version?: string;
  static names(): { [key: string]: string } {
    return {
      apiKey: 'apiKey',
      appUuid: 'appUuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiKey: 'string',
      appUuid: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedTaskRequestFeatureConfigFeatures extends $tea.Model {
  callback?: PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback;
  /**
   * **if can be null:**
   * true
   */
  config?: string;
  /**
   * @example
   * www.dingtalk.com
   */
  mobileUrl?: string;
  /**
   * @example
   * abc
   */
  name?: string;
  /**
   * @example
   * www.dingtalk.com
   */
  pcUrl?: string;
  /**
   * @example
   * ORIGIN
   */
  runType?: string;
  static names(): { [key: string]: string } {
    return {
      callback: 'callback',
      config: 'config',
      mobileUrl: 'mobileUrl',
      name: 'name',
      pcUrl: 'pcUrl',
      runType: 'runType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callback: PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback,
      config: 'string',
      mobileUrl: 'string',
      name: 'string',
      pcUrl: 'string',
      runType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedTaskRequestFeatureConfig extends $tea.Model {
  features?: PremiumSaveIntegratedTaskRequestFeatureConfigFeatures[];
  static names(): { [key: string]: string } {
    return {
      features: 'features',
    };
  }

  static types(): { [key: string]: any } {
    return {
      features: { 'type': 'array', 'itemType': PremiumSaveIntegratedTaskRequestFeatureConfigFeatures },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedTaskRequestTasks extends $tea.Model {
  /**
   * @example
   * {\"id\":\"12345\"}
   */
  customData?: string;
  /**
   * @example
   * https://www.dingtalk.com
   */
  url?: string;
  /**
   * @example
   * manager001
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      customData: 'customData',
      url: 'url',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customData: 'string',
      url: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PremiumSaveIntegratedTaskResponseBodyResult extends $tea.Model {
  taskId?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessForecastRequestFormComponentValuesDetailsDetails extends $tea.Model {
  /**
   * @example
   * Phone
   */
  bizAlias?: string;
  componentType?: string;
  /**
   * @example
   * 总个数:1
   */
  extValue?: string;
  /**
   * @example
   * PhoneField_IZI2LP8QF6O0
   */
  id?: string;
  /**
   * @example
   * PhoneField
   */
  name?: string;
  /**
   * @example
   * 123xxxxxxxx
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      componentType: 'componentType',
      extValue: 'extValue',
      id: 'id',
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      componentType: 'string',
      extValue: 'string',
      id: 'string',
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessForecastRequestFormComponentValuesDetails extends $tea.Model {
  /**
   * @example
   * Phone
   */
  bizAlias?: string;
  details?: ProcessForecastRequestFormComponentValuesDetailsDetails[];
  /**
   * @example
   * 总个数:1
   */
  extValue?: string;
  /**
   * @example
   * PhoneField_IZI2LP8QF6O0
   */
  id?: string;
  /**
   * @example
   * PhoneField
   */
  name?: string;
  /**
   * @example
   * 123xxxxxxxx
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      details: 'details',
      extValue: 'extValue',
      id: 'id',
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      details: { 'type': 'array', 'itemType': ProcessForecastRequestFormComponentValuesDetailsDetails },
      extValue: 'string',
      id: 'string',
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessForecastRequestFormComponentValues extends $tea.Model {
  /**
   * @example
   * Phone
   */
  bizAlias?: string;
  componentType?: string;
  details?: ProcessForecastRequestFormComponentValuesDetails[];
  /**
   * @example
   * 总个数:1
   */
  extValue?: string;
  /**
   * @example
   * PhoneField_IZI2LP8QF6O0
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PhoneField
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123xxxxxxxx
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      componentType: 'componentType',
      details: 'details',
      extValue: 'extValue',
      id: 'id',
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      componentType: 'string',
      details: { 'type': 'array', 'itemType': ProcessForecastRequestFormComponentValuesDetails },
      extValue: 'string',
      id: 'string',
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals extends $tea.Model {
  userName?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      userName: 'userName',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userName: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels extends $tea.Model {
  labelNames?: string;
  labels?: string;
  static names(): { [key: string]: string } {
    return {
      labelNames: 'labelNames',
      labels: 'labels',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelNames: 'string',
      labels: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange extends $tea.Model {
  approvals?: ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals[];
  labels?: ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels[];
  static names(): { [key: string]: string } {
    return {
      approvals: 'approvals',
      labels: 'labels',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approvals: { 'type': 'array', 'itemType': ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals },
      labels: { 'type': 'array', 'itemType': ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor extends $tea.Model {
  /**
   * @example
   * ALL:并行，ONE_BY_ONE:串行
   */
  actorActivateType?: string;
  /**
   * @example
   * manual_e203_14a3_895a_45ad
   */
  actorKey?: string;
  actorSelectionRange?: ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange;
  /**
   * @example
   * allStaff：全公司，approvals：指定成员，labels：角色
   */
  actorSelectionType?: string;
  /**
   * @example
   * approver:审批人，notifier:抄送人，audit：办理人
   */
  actorType?: string;
  /**
   * @example
   * true
   */
  allowedMulti?: boolean;
  /**
   * @example
   * ONE_BY_ONE：依次审批，AND：会签审批，OR：或签审批
   */
  approvalMethod?: string;
  /**
   * @example
   * MANUAL:人工审批，AUTO_AGREE:自动通过，AUTO_REFUSE:自动拒绝
   */
  approvalType?: string;
  /**
   * @example
   * true
   */
  required?: boolean;
  static names(): { [key: string]: string } {
    return {
      actorActivateType: 'actorActivateType',
      actorKey: 'actorKey',
      actorSelectionRange: 'actorSelectionRange',
      actorSelectionType: 'actorSelectionType',
      actorType: 'actorType',
      allowedMulti: 'allowedMulti',
      approvalMethod: 'approvalMethod',
      approvalType: 'approvalType',
      required: 'required',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actorActivateType: 'string',
      actorKey: 'string',
      actorSelectionRange: ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange,
      actorSelectionType: 'string',
      actorType: 'string',
      allowedMulti: 'boolean',
      approvalMethod: 'string',
      approvalType: 'string',
      required: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessForecastResponseBodyResultWorkflowActivityRules extends $tea.Model {
  /**
   * @example
   * 1918_5cd3
   */
  activityId?: string;
  /**
   * @example
   * 审批人
   */
  activityName?: string;
  /**
   * @example
   * 包括 target_select、target_approval 等
   */
  activityType?: string;
  /**
   * @example
   * true
   */
  isTargetSelect?: boolean;
  /**
   * @example
   * 1918_5cd3
   */
  prevActivityId?: string;
  workflowActor?: ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      activityName: 'activityName',
      activityType: 'activityType',
      isTargetSelect: 'isTargetSelect',
      prevActivityId: 'prevActivityId',
      workflowActor: 'workflowActor',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      activityName: 'string',
      activityType: 'string',
      isTargetSelect: 'boolean',
      prevActivityId: 'string',
      workflowActor: ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessForecastResponseBodyResultWorkflowForecastNodes extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1cc3_959a
   */
  activityId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * line-random-1cc3_959a-831a_607b
   */
  outId?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      outId: 'outId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      outId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessForecastResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  isForecastSuccess?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  isStaticWorkflow?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-2B60E506-D6CB-43F3-B661-359B27F90947
   */
  processCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 63657309999
   */
  processId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2665246100805992
   */
  userId?: string;
  workflowActivityRules?: ProcessForecastResponseBodyResultWorkflowActivityRules[];
  /**
   * @remarks
   * This parameter is required.
   */
  workflowForecastNodes?: ProcessForecastResponseBodyResultWorkflowForecastNodes[];
  static names(): { [key: string]: string } {
    return {
      isForecastSuccess: 'isForecastSuccess',
      isStaticWorkflow: 'isStaticWorkflow',
      processCode: 'processCode',
      processId: 'processId',
      userId: 'userId',
      workflowActivityRules: 'workflowActivityRules',
      workflowForecastNodes: 'workflowForecastNodes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isForecastSuccess: 'boolean',
      isStaticWorkflow: 'boolean',
      processCode: 'string',
      processId: 'number',
      userId: 'string',
      workflowActivityRules: { 'type': 'array', 'itemType': ProcessForecastResponseBodyResultWorkflowActivityRules },
      workflowForecastNodes: { 'type': 'array', 'itemType': ProcessForecastResponseBodyResultWorkflowForecastNodes },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllFormInstancesResponseBodyResultValuesFormInstDataList extends $tea.Model {
  /**
   * @example
   * staff_name
   */
  bizAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 具体参见审批控件列表
   */
  componentType?: string;
  /**
   * @example
   * {"key":"value}
   */
  extendValue?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField-abcdefg
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 员工姓名
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 张三
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      componentType: 'componentType',
      extendValue: 'extendValue',
      key: 'key',
      label: 'label',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      componentType: 'string',
      extendValue: 'string',
      key: 'string',
      label: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllFormInstancesResponseBodyResultValues extends $tea.Model {
  /**
   * @example
   * SWAPP-abcd-example
   */
  appUuid?: string;
  attributes?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1635151039000
   */
  createTimestamp?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 30314512
   */
  creator?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-abcd-example
   */
  formCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formInstDataList?: QueryAllFormInstancesResponseBodyResultValuesFormInstDataList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd-eaf-acde12f
   */
  formInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 032142312
   */
  modifier?: string;
  /**
   * @example
   * 1635151039000
   */
  modifyTimestamp?: number;
  /**
   * @example
   * abcd
   */
  outBizCode?: string;
  /**
   * @example
   * 323
   */
  outInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx提交的数据
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      appUuid: 'appUuid',
      attributes: 'attributes',
      createTimestamp: 'createTimestamp',
      creator: 'creator',
      formCode: 'formCode',
      formInstDataList: 'formInstDataList',
      formInstanceId: 'formInstanceId',
      modifier: 'modifier',
      modifyTimestamp: 'modifyTimestamp',
      outBizCode: 'outBizCode',
      outInstanceId: 'outInstanceId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUuid: 'string',
      attributes: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      createTimestamp: 'number',
      creator: 'string',
      formCode: 'string',
      formInstDataList: { 'type': 'array', 'itemType': QueryAllFormInstancesResponseBodyResultValuesFormInstDataList },
      formInstanceId: 'string',
      modifier: 'string',
      modifyTimestamp: 'number',
      outBizCode: 'string',
      outInstanceId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllFormInstancesResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  values?: QueryAllFormInstancesResponseBodyResultValues[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      values: 'values',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      maxResults: 'number',
      nextToken: 'string',
      values: { 'type': 'array', 'itemType': QueryAllFormInstancesResponseBodyResultValues },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllProcessInstancesResponseBodyResultListFormComponentValues extends $tea.Model {
  /**
   * @example
   * {"staffId":"abcd"}
   */
  extValue?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField-a32bcdef
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 姓名
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 张三
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      extValue: 'extValue',
      id: 'id',
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extValue: 'string',
      id: 'string',
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments extends $tea.Model {
  /**
   * @example
   * 1234567
   */
  fileId?: string;
  /**
   * @example
   * 附件
   */
  fileName?: string;
  /**
   * @example
   * 123
   */
  fileSize?: string;
  /**
   * @example
   * pdf
   */
  fileType?: string;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      fileName: 'fileName',
      fileSize: 'fileSize',
      fileType: 'fileType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      fileName: 'string',
      fileSize: 'string',
      fileType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllProcessInstancesResponseBodyResultListOperationRecords extends $tea.Model {
  attachments?: QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments[];
  /**
   * @example
   * EXECUTE_TASK_NORMAL（正常执行任务），EXECUTE_TASK_AGENT（代理人执行任务），APPEND_TASK_BEFORE（前加签任务），APPEND_TASK_AFTER（后加签任务），REDIRECT_TASK（转交任务），START_PROCESS_INSTANCE（发起流程实例），TERMINATE_PROCESS_INSTANCE（终止(撤销)流程实例），FINISH_PROCESS_INSTANCE（结束流程实例），ADD_REMARK（添加评论）
   */
  operationType?: string;
  /**
   * @example
   * 同意
   */
  remark?: string;
  /**
   * @example
   * AGREE（同意），REFUSE（拒绝），NONE（未知）
   */
  result?: string;
  /**
   * @example
   * 1657522271000
   */
  timestamp?: number;
  /**
   * @example
   * manager1
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      operationType: 'operationType',
      remark: 'remark',
      result: 'result',
      timestamp: 'timestamp',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments },
      operationType: 'string',
      remark: 'string',
      result: 'string',
      timestamp: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllProcessInstancesResponseBodyResultListTasks extends $tea.Model {
  /**
   * @example
   * 1234_abcd
   */
  activityId?: string;
  /**
   * @example
   * 1657522271000
   */
  createTimestamp?: number;
  /**
   * @example
   * 1657522271000
   */
  finishTimestamp?: number;
  /**
   * @example
   * 分为AGREE（同意），REFUSE（拒绝），REDIRECTED（转交）
   */
  result?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * NEW（未启动），RUNNING（处理中），PAUSED（暂停），CANCELED（取消），COMPLETED（完成），TERMINATED（终止）
   */
  status?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
  taskId?: number;
  /**
   * @example
   * staff1234
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      createTimestamp: 'createTimestamp',
      finishTimestamp: 'finishTimestamp',
      result: 'result',
      status: 'status',
      taskId: 'taskId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      createTimestamp: 'number',
      finishTimestamp: 'number',
      result: 'string',
      status: 'string',
      taskId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllProcessInstancesResponseBodyResultList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cdef-dae2fd2-example
   */
  attachedProcessInstanceIds?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202110111558000355024
   */
  businessId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1635165470201
   */
  createTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1633795200000
   */
  finishTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  formComponentValues?: QueryAllProcessInstancesResponseBodyResultListFormComponentValues[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dcdse-dae2fd2-example
   */
  mainProcessInstanceId?: string;
  operationRecords?: QueryAllProcessInstancesResponseBodyResultListOperationRecords[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 默认-1，企业根部门
   */
  originatorDeptId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * staff1234
   */
  originatorUserid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcdse-dse-example
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * AGREE同意，REFUSE拒绝
   */
  result?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * RUNNING审批中、TERMINATED撤销、COMPLETED审批完成、CANCELED取消
   */
  status?: string;
  tasks?: QueryAllProcessInstancesResponseBodyResultListTasks[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 员工A提交的小肖审批单
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      attachedProcessInstanceIds: 'attachedProcessInstanceIds',
      businessId: 'businessId',
      createTime: 'createTime',
      finishTime: 'finishTime',
      formComponentValues: 'formComponentValues',
      mainProcessInstanceId: 'mainProcessInstanceId',
      operationRecords: 'operationRecords',
      originatorDeptId: 'originatorDeptId',
      originatorUserid: 'originatorUserid',
      processInstanceId: 'processInstanceId',
      result: 'result',
      status: 'status',
      tasks: 'tasks',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachedProcessInstanceIds: 'string',
      businessId: 'string',
      createTime: 'number',
      finishTime: 'number',
      formComponentValues: { 'type': 'array', 'itemType': QueryAllProcessInstancesResponseBodyResultListFormComponentValues },
      mainProcessInstanceId: 'string',
      operationRecords: { 'type': 'array', 'itemType': QueryAllProcessInstancesResponseBodyResultListOperationRecords },
      originatorDeptId: 'string',
      originatorUserid: 'string',
      processInstanceId: 'string',
      result: 'string',
      status: 'string',
      tasks: { 'type': 'array', 'itemType': QueryAllProcessInstancesResponseBodyResultListTasks },
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllProcessInstancesResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  hasMore?: boolean;
  list?: QueryAllProcessInstancesResponseBodyResultList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryAllProcessInstancesResponseBodyResultList },
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormByBizTypeResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 应用类型
   */
  appType?: number;
  /**
   * @example
   * SWAPP-abcdef-example
   */
  appUuid?: string;
  /**
   * @example
   * 表单业务标识
   */
  bizType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  /**
   * @example
   * 1635151039000
   */
  createTime?: number;
  /**
   * @example
   * 02501234567890
   */
  creator?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-abcdef-example
   */
  formCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-example
   */
  formUuid?: string;
  /**
   * @example
   * 用于收集休假信息
   */
  memo?: string;
  /**
   * @example
   * 1635151039000
   */
  modifedTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 休假申请
   */
  name?: string;
  /**
   * @example
   * 02501234567890
   */
  ownerId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PUBLISHED(启用), INVALID(停用), SAVED(草稿)
   */
  status?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      appUuid: 'appUuid',
      bizType: 'bizType',
      content: 'content',
      createTime: 'createTime',
      creator: 'creator',
      formCode: 'formCode',
      formUuid: 'formUuid',
      memo: 'memo',
      modifedTime: 'modifedTime',
      name: 'name',
      ownerId: 'ownerId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'number',
      appUuid: 'string',
      bizType: 'string',
      content: 'string',
      createTime: 'number',
      creator: 'string',
      formCode: 'string',
      formUuid: 'string',
      memo: 'string',
      modifedTime: 'number',
      name: 'string',
      ownerId: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormInstanceResponseBodyFormInstDataList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bizAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  componentType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  extendValue?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      componentType: 'componentType',
      extendValue: 'extendValue',
      key: 'key',
      label: 'label',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      componentType: 'string',
      extendValue: 'string',
      key: 'string',
      label: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryIntegratedTodoTaskResponseBodyResultList extends $tea.Model {
  /**
   * @example
   * act_0001
   */
  activityId?: string;
  /**
   * @example
   * 2022-10-17T15:12Z
   */
  createTime?: string;
  /**
   * @example
   * 2022-10-17T15:12Z
   */
  finishTime?: string;
  /**
   * @example
   * Siw2WNVZS4KiUt3tTmaNKg04*****809950
   */
  processInstanceId?: string;
  /**
   * @example
   * agree
   */
  result?: string;
  /**
   * @example
   * RUNNING
   */
  status?: string;
  /**
   * @example
   * 1234567
   */
  taskId?: number;
  /**
   * @example
   * manager001
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      createTime: 'createTime',
      finishTime: 'finishTime',
      processInstanceId: 'processInstanceId',
      result: 'result',
      status: 'status',
      taskId: 'taskId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      createTime: 'string',
      finishTime: 'string',
      processInstanceId: 'string',
      result: 'string',
      status: 'string',
      taskId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryIntegratedTodoTaskResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  list?: QueryIntegratedTodoTaskResponseBodyResultList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryIntegratedTodoTaskResponseBodyResultList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessByBizCategoryIdResponseBodyResult extends $tea.Model {
  description?: string;
  name?: string;
  processCode?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      name: 'name',
      processCode: 'processCode',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      name: 'string',
      processCode: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaAndProcessResponseBodyResult extends $tea.Model {
  appType?: number;
  content?: string;
  handSignEnable?: string;
  iconUrl?: string;
  name?: string;
  processConfig?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      content: 'content',
      handSignEnable: 'handSignEnable',
      iconUrl: 'iconUrl',
      name: 'name',
      processConfig: 'processConfig',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'number',
      content: 'string',
      handSignEnable: 'string',
      iconUrl: 'string',
      name: 'string',
      processConfig: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps extends $tea.Model {
  bizAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  id?: string;
  label?: string;
  options?: string[];
  required?: boolean;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      id: 'id',
      label: 'label',
      options: 'options',
      required: 'required',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      id: 'string',
      label: 'string',
      options: { 'type': 'array', 'itemType': 'string' },
      required: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  props?: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      props: 'props',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      props: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets extends $tea.Model {
  /**
   * @example
   * xxxx
   */
  behavior?: string;
  /**
   * @example
   * TextField-K2AD4O5B
   */
  fieldId?: string;
  static names(): { [key: string]: string } {
    return {
      behavior: 'behavior',
      fieldId: 'fieldId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      behavior: 'string',
      fieldId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage extends $tea.Model {
  targets?: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets[];
  /**
   * @example
   * xxxx
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      targets: 'targets',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targets: { 'type': 'array', 'itemType': QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets },
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions extends $tea.Model {
  value?: string;
  static names(): { [key: string]: string } {
    return {
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush extends $tea.Model {
  /**
   * @example
   * 1
   */
  attendanceRule?: number;
  /**
   * @example
   * 1
   */
  pushSwitch?: number;
  /**
   * @example
   * xxxx
   */
  pushTag?: string;
  static names(): { [key: string]: string } {
    return {
      attendanceRule: 'attendanceRule',
      pushSwitch: 'pushSwitch',
      pushTag: 'pushTag',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendanceRule: 'number',
      pushSwitch: 'number',
      pushTag: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField extends $tea.Model {
  /**
   * @example
   * TextField-K2AD4O5B
   */
  id?: string;
  /**
   * @example
   * 单行输入框
   */
  label?: string;
  /**
   * @example
   * xxxx
   */
  unit?: string;
  /**
   * @example
   * true
   */
  upper?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      label: 'label',
      unit: 'unit',
      upper: 'upper',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      label: 'string',
      unit: 'string',
      upper: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps extends $tea.Model {
  /**
   * @example
   * 添加
   */
  actionName?: string;
  /**
   * @example
   * top
   */
  align?: string;
  /**
   * @example
   * 1234567
   */
  appId?: number;
  /**
   * @example
   * true
   */
  asyncCondition?: boolean;
  /**
   * @example
   * 请假
   */
  attendTypeLabel?: string;
  behaviorLinkage?: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage[];
  /**
   * @example
   * 我的单行输入框
   */
  bizAlias?: string;
  /**
   * @example
   * hrm.xxxx
   */
  bizType?: string;
  childFieldVisible?: { [key: string]: boolean };
  /**
   * @example
   * 1
   */
  choice?: number;
  /**
   * @example
   * xxxx
   */
  commonBizType?: string;
  /**
   * @example
   * true
   */
  disabled?: boolean;
  /**
   * @example
   * true
   */
  duration?: boolean;
  /**
   * @example
   * xxxx
   */
  durationLabel?: string;
  /**
   * @example
   * true
   */
  eSign?: boolean;
  /**
   * @example
   * true
   */
  extract?: boolean;
  /**
   * @example
   * xxxx
   */
  fieldsInfo?: string;
  /**
   * @example
   * yyyy-MM-dd
   */
  format?: string;
  /**
   * @example
   * xxxx
   */
  formula?: string;
  /**
   * @example
   * true
   */
  hidden?: boolean;
  /**
   * @example
   * true
   */
  hiddenInApprovalDetail?: boolean;
  /**
   * @example
   * true
   */
  hideLabel?: boolean;
  /**
   * @example
   * "[{\"name\":\"\open"}]"
   */
  holidayOptions?: { [key: string]: string }[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField-K2AD4O5B
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 单行输入框
   */
  label?: string;
  /**
   * @example
   * true
   */
  labelEditableFreeze?: boolean;
  /**
   * @example
   * xxxx
   */
  link?: string;
  /**
   * @example
   * xxxx
   */
  mainTitle?: string;
  /**
   * @example
   * 1
   */
  notPrint?: string;
  /**
   * @example
   * 1
   */
  notUpper?: string;
  objOptions?: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions[];
  options?: string[];
  /**
   * @example
   * true
   */
  payEnable?: boolean;
  /**
   * @example
   * 请输入文字
   */
  placeholder?: string;
  push?: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush;
  /**
   * @example
   * true
   */
  pushToAttendance?: boolean;
  /**
   * @example
   * 1
   */
  pushToCalendar?: number;
  /**
   * @example
   * true
   */
  required?: boolean;
  /**
   * @example
   * true
   */
  requiredEditableFreeze?: boolean;
  /**
   * @example
   * true
   */
  showAttendOptions?: boolean;
  /**
   * @example
   * true
   */
  staffStatusEnabled?: boolean;
  statField?: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField[];
  /**
   * @example
   * list
   */
  tableViewMode?: string;
  /**
   * @example
   * 天
   */
  unit?: string;
  /**
   * @example
   * true
   */
  useCalendar?: boolean;
  /**
   * @example
   * true
   */
  verticalPrint?: boolean;
  static names(): { [key: string]: string } {
    return {
      actionName: 'actionName',
      align: 'align',
      appId: 'appId',
      asyncCondition: 'asyncCondition',
      attendTypeLabel: 'attendTypeLabel',
      behaviorLinkage: 'behaviorLinkage',
      bizAlias: 'bizAlias',
      bizType: 'bizType',
      childFieldVisible: 'childFieldVisible',
      choice: 'choice',
      commonBizType: 'commonBizType',
      disabled: 'disabled',
      duration: 'duration',
      durationLabel: 'durationLabel',
      eSign: 'eSign',
      extract: 'extract',
      fieldsInfo: 'fieldsInfo',
      format: 'format',
      formula: 'formula',
      hidden: 'hidden',
      hiddenInApprovalDetail: 'hiddenInApprovalDetail',
      hideLabel: 'hideLabel',
      holidayOptions: 'holidayOptions',
      id: 'id',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      link: 'link',
      mainTitle: 'mainTitle',
      notPrint: 'notPrint',
      notUpper: 'notUpper',
      objOptions: 'objOptions',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      push: 'push',
      pushToAttendance: 'pushToAttendance',
      pushToCalendar: 'pushToCalendar',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      showAttendOptions: 'showAttendOptions',
      staffStatusEnabled: 'staffStatusEnabled',
      statField: 'statField',
      tableViewMode: 'tableViewMode',
      unit: 'unit',
      useCalendar: 'useCalendar',
      verticalPrint: 'verticalPrint',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionName: 'string',
      align: 'string',
      appId: 'number',
      asyncCondition: 'boolean',
      attendTypeLabel: 'string',
      behaviorLinkage: { 'type': 'array', 'itemType': QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage },
      bizAlias: 'string',
      bizType: 'string',
      childFieldVisible: { 'type': 'map', 'keyType': 'string', 'valueType': 'boolean' },
      choice: 'number',
      commonBizType: 'string',
      disabled: 'boolean',
      duration: 'boolean',
      durationLabel: 'string',
      eSign: 'boolean',
      extract: 'boolean',
      fieldsInfo: 'string',
      format: 'string',
      formula: 'string',
      hidden: 'boolean',
      hiddenInApprovalDetail: 'boolean',
      hideLabel: 'boolean',
      holidayOptions: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'string' } },
      id: 'string',
      label: 'string',
      labelEditableFreeze: 'boolean',
      link: 'string',
      mainTitle: 'string',
      notPrint: 'string',
      notUpper: 'string',
      objOptions: { 'type': 'array', 'itemType': QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions },
      options: { 'type': 'array', 'itemType': 'string' },
      payEnable: 'boolean',
      placeholder: 'string',
      push: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush,
      pushToAttendance: 'boolean',
      pushToCalendar: 'number',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      showAttendOptions: 'boolean',
      staffStatusEnabled: 'boolean',
      statField: { 'type': 'array', 'itemType': QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField },
      tableViewMode: 'string',
      unit: 'string',
      useCalendar: 'boolean',
      verticalPrint: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems extends $tea.Model {
  children?: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  props?: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps;
  static names(): { [key: string]: string } {
    return {
      children: 'children',
      componentName: 'componentName',
      props: 'props',
    };
  }

  static types(): { [key: string]: any } {
    return {
      children: { 'type': 'array', 'itemType': QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren },
      componentName: 'string',
      props: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaByProcessCodeResponseBodyResultSchemaContent extends $tea.Model {
  /**
   * @example
   * common
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  items?: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 示例模板
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      items: 'items',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      items: { 'type': 'array', 'itemType': QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems },
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaByProcessCodeResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  appType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxx
   */
  appUuid?: string;
  /**
   * @example
   * hrm.xxxx
   */
  bizType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 26652461xxxx5992
   */
  creatorUserId?: string;
  /**
   * @example
   * null
   */
  customSetting?: string;
  /**
   * @example
   * 0
   */
  engineType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-17428B8C-6C60-470E-xxxx-64F1037AE067
   */
  formCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-28215C3E-00E3-4118-xxxx-4091F828AF2F
   */
  formUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-12-01T10:49Z
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-12-01T10:49Z
   */
  gmtModified?: string;
  /**
   * @example
   * null
   */
  icon?: string;
  /**
   * @example
   * 1
   */
  listOrder?: number;
  /**
   * @example
   * xxxx
   */
  memo?: string;
  /**
   * @example
   * 示例模板
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 25xxxx01
   */
  ownerIdType?: string;
  /**
   * @example
   * inner
   */
  procType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  schemaContent?: QuerySchemaByProcessCodeResponseBodyResultSchemaContent;
  /**
   * @example
   * PUBLISHED
   */
  status?: string;
  /**
   * @example
   * PRIVATE
   */
  visibleRange?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      appUuid: 'appUuid',
      bizType: 'bizType',
      creatorUserId: 'creatorUserId',
      customSetting: 'customSetting',
      engineType: 'engineType',
      formCode: 'formCode',
      formUuid: 'formUuid',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      icon: 'icon',
      listOrder: 'listOrder',
      memo: 'memo',
      name: 'name',
      ownerIdType: 'ownerIdType',
      procType: 'procType',
      schemaContent: 'schemaContent',
      status: 'status',
      visibleRange: 'visibleRange',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'number',
      appUuid: 'string',
      bizType: 'string',
      creatorUserId: 'string',
      customSetting: 'string',
      engineType: 'number',
      formCode: 'string',
      formUuid: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
      icon: 'string',
      listOrder: 'number',
      memo: 'string',
      name: 'string',
      ownerIdType: 'string',
      procType: 'string',
      schemaContent: QuerySchemaByProcessCodeResponseBodyResultSchemaContent,
      status: 'string',
      visibleRange: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RedirectWorkflowTaskRequestFileAttachments extends $tea.Model {
  /**
   * @example
   * B1oQixxxx
   */
  fileId?: string;
  /**
   * @example
   * 文件名称。
   */
  fileName?: string;
  /**
   * @example
   * 1024
   */
  fileSize?: string;
  /**
   * @example
   * file
   */
  fileType?: string;
  /**
   * @example
   * 123
   */
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      fileName: 'fileName',
      fileSize: 'fileSize',
      fileType: 'fileType',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      fileName: 'string',
      fileSize: 'string',
      fileType: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RedirectWorkflowTaskRequestFile extends $tea.Model {
  attachments?: RedirectWorkflowTaskRequestFileAttachments[];
  photos?: string[];
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      photos: 'photos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': RedirectWorkflowTaskRequestFileAttachments },
      photos: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback extends $tea.Model {
  /**
   * @example
   * abc
   */
  apiKey?: string;
  /**
   * @example
   * abc
   */
  appUuid?: string;
  /**
   * @example
   * 1
   */
  version?: string;
  static names(): { [key: string]: string } {
    return {
      apiKey: 'apiKey',
      appUuid: 'appUuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiKey: 'string',
      appUuid: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveIntegratedInstanceRequestFeatureConfigFeatures extends $tea.Model {
  callback?: SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback;
  /**
   * **if can be null:**
   * true
   */
  config?: string;
  /**
   * @example
   * www.dingtalk.com
   */
  mobileUrl?: string;
  /**
   * @example
   * abc
   */
  name?: string;
  /**
   * @example
   * www.dingtalk.com
   */
  pcUrl?: string;
  /**
   * @example
   * ORIGIN
   */
  runType?: string;
  static names(): { [key: string]: string } {
    return {
      callback: 'callback',
      config: 'config',
      mobileUrl: 'mobileUrl',
      name: 'name',
      pcUrl: 'pcUrl',
      runType: 'runType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callback: SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback,
      config: 'string',
      mobileUrl: 'string',
      name: 'string',
      pcUrl: 'string',
      runType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveIntegratedInstanceRequestFeatureConfig extends $tea.Model {
  features?: SaveIntegratedInstanceRequestFeatureConfigFeatures[];
  static names(): { [key: string]: string } {
    return {
      features: 'features',
    };
  }

  static types(): { [key: string]: any } {
    return {
      features: { 'type': 'array', 'itemType': SaveIntegratedInstanceRequestFeatureConfigFeatures },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveIntegratedInstanceRequestFormComponentValueList extends $tea.Model {
  bizAlias?: string;
  componentType?: string;
  extValue?: string;
  id?: string;
  name?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      componentType: 'componentType',
      extValue: 'extValue',
      id: 'id',
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      componentType: 'string',
      extValue: 'string',
      id: 'string',
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveIntegratedInstanceRequestNotifiers extends $tea.Model {
  /**
   * @example
   * start
   */
  position?: string;
  /**
   * @example
   * manager001
   */
  userid?: string;
  static names(): { [key: string]: string } {
    return {
      position: 'position',
      userid: 'userid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      position: 'string',
      userid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveIntegratedInstanceResponseBodyResult extends $tea.Model {
  /**
   * @example
   * proc-abc
   */
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveProcessRequestProcessFeatureConfigFeaturesCallback extends $tea.Model {
  /**
   * @example
   * abc
   */
  apiKey?: string;
  /**
   * @example
   * abc
   */
  appUuid?: string;
  /**
   * @example
   * 1
   */
  version?: string;
  static names(): { [key: string]: string } {
    return {
      apiKey: 'apiKey',
      appUuid: 'appUuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiKey: 'string',
      appUuid: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveProcessRequestProcessFeatureConfigFeatures extends $tea.Model {
  callback?: SaveProcessRequestProcessFeatureConfigFeaturesCallback;
  /**
   * **if can be null:**
   * true
   */
  config?: string;
  /**
   * @example
   * www.dingtalk.com
   */
  mobileUrl?: string;
  /**
   * @example
   * abc
   */
  name?: string;
  /**
   * @example
   * www.dingtalk.com
   */
  pcUrl?: string;
  /**
   * @example
   * ORIGIN
   */
  runType?: string;
  static names(): { [key: string]: string } {
    return {
      callback: 'callback',
      config: 'config',
      mobileUrl: 'mobileUrl',
      name: 'name',
      pcUrl: 'pcUrl',
      runType: 'runType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callback: SaveProcessRequestProcessFeatureConfigFeaturesCallback,
      config: 'string',
      mobileUrl: 'string',
      name: 'string',
      pcUrl: 'string',
      runType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveProcessRequestProcessFeatureConfig extends $tea.Model {
  features?: SaveProcessRequestProcessFeatureConfigFeatures[];
  static names(): { [key: string]: string } {
    return {
      features: 'features',
    };
  }

  static types(): { [key: string]: any } {
    return {
      features: { 'type': 'array', 'itemType': SaveProcessRequestProcessFeatureConfigFeatures },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveProcessRequestTemplateConfig extends $tea.Model {
  /**
   * @example
   * https://open.dingtalk.com/
   * 
   * @deprecated
   */
  createInstanceMobileUrl?: string;
  /**
   * @example
   * https://open.dingtalk.com/
   * 
   * @deprecated
   */
  createInstancePcUrl?: string;
  /**
   * **if can be null:**
   * true
   */
  disableSendCard?: boolean;
  /**
   * @example
   * true
   */
  hidden?: boolean;
  /**
   * @example
   * https://open.dingtalk.com/
   * 
   * **if can be null:**
   * true
   * 
   * @deprecated
   */
  templateEditUrl?: string;
  static names(): { [key: string]: string } {
    return {
      createInstanceMobileUrl: 'createInstanceMobileUrl',
      createInstancePcUrl: 'createInstancePcUrl',
      disableSendCard: 'disableSendCard',
      hidden: 'hidden',
      templateEditUrl: 'templateEditUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createInstanceMobileUrl: 'string',
      createInstancePcUrl: 'string',
      disableSendCard: 'boolean',
      hidden: 'boolean',
      templateEditUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveProcessResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-abcdef-example
   */
  processCode?: string;
  static names(): { [key: string]: string } {
    return {
      processCode: 'processCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartProcessInstanceRequestApprovers extends $tea.Model {
  /**
   * @example
   * 会签：AND；或签：OR；单人：NONE
   */
  actionType?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      actionType: 'actionType',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionType: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartProcessInstanceRequestFormComponentValuesDetailsDetails extends $tea.Model {
  /**
   * @example
   * Phone
   */
  bizAlias?: string;
  componentType?: string;
  /**
   * @example
   * 总个数:1
   */
  extValue?: string;
  /**
   * @example
   * PhoneField_IZI2LP8QF6O0
   */
  id?: string;
  /**
   * @example
   * PhoneField
   */
  name?: string;
  /**
   * @example
   * 123xxxxxxxx
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      componentType: 'componentType',
      extValue: 'extValue',
      id: 'id',
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      componentType: 'string',
      extValue: 'string',
      id: 'string',
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartProcessInstanceRequestFormComponentValuesDetails extends $tea.Model {
  /**
   * @example
   * Phone
   */
  bizAlias?: string;
  details?: StartProcessInstanceRequestFormComponentValuesDetailsDetails[];
  /**
   * @example
   * 总个数:1
   */
  extValue?: string;
  /**
   * @example
   * PhoneField_IZI2LP8QF6O0
   */
  id?: string;
  /**
   * @example
   * PhoneField
   */
  name?: string;
  /**
   * @example
   * 123xxxxxxxx
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      details: 'details',
      extValue: 'extValue',
      id: 'id',
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      details: { 'type': 'array', 'itemType': StartProcessInstanceRequestFormComponentValuesDetailsDetails },
      extValue: 'string',
      id: 'string',
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartProcessInstanceRequestFormComponentValues extends $tea.Model {
  /**
   * @example
   * Phone
   */
  bizAlias?: string;
  componentType?: string;
  details?: StartProcessInstanceRequestFormComponentValuesDetails[];
  /**
   * @example
   * 总个数:1
   */
  extValue?: string;
  /**
   * @example
   * PhoneField_IZI2LP8QF6O0
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PhoneField
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123xxxxxxxx
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      componentType: 'componentType',
      details: 'details',
      extValue: 'extValue',
      id: 'id',
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      componentType: 'string',
      details: { 'type': 'array', 'itemType': StartProcessInstanceRequestFormComponentValuesDetails },
      extValue: 'string',
      id: 'string',
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartProcessInstanceRequestTargetSelectActioners extends $tea.Model {
  /**
   * @example
   * manual_1918_5cd3_5e19_6a98
   */
  actionerKey?: string;
  actionerUserIds?: string[];
  static names(): { [key: string]: string } {
    return {
      actionerKey: 'actionerKey',
      actionerUserIds: 'actionerUserIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionerKey: 'string',
      actionerUserIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TodoTasksResponseBodyResultList extends $tea.Model {
  /**
   * @example
   * RUNNING
   */
  businessId?: string;
  canRedirect?: boolean;
  createTime?: number;
  /**
   * @example
   * act_0001
   */
  processCode?: string;
  /**
   * @example
   * Siw2WNVZS4KiUt3tTmaNKg04*****809950
   */
  processInstanceId?: string;
  /**
   * @example
   * 1234567
   */
  taskId?: number;
  /**
   * @example
   * manager001
   */
  title?: string;
  /**
   * @example
   * 2022-10-17T15:12Z
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      businessId: 'businessId',
      canRedirect: 'canRedirect',
      createTime: 'createTime',
      processCode: 'processCode',
      processInstanceId: 'processInstanceId',
      taskId: 'taskId',
      title: 'title',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      businessId: 'string',
      canRedirect: 'boolean',
      createTime: 'number',
      processCode: 'string',
      processInstanceId: 'string',
      taskId: 'number',
      title: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TodoTasksResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  list?: TodoTasksResponseBodyResultList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': TodoTasksResponseBodyResultList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateIntegratedTaskRequestTasks extends $tea.Model {
  /**
   * @example
   * AGREE
   */
  result?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * COMPLETED
   */
  status?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * **if can be null:**
   * true
   */
  taskId?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      status: 'status',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      status: 'string',
      taskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateProcessInstanceRequestNotifiers extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager001
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    let gatewayClient = new GatewayClient();
    this._spi = gatewayClient;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * 授权下载审批钉盘文件
   * 
   * @param request - AddApproveDentryAuthRequest
   * @param headers - AddApproveDentryAuthHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddApproveDentryAuthResponse
   */
  async addApproveDentryAuthWithOptions(request: AddApproveDentryAuthRequest, headers: AddApproveDentryAuthHeaders, runtime: $Util.RuntimeOptions): Promise<AddApproveDentryAuthResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fileInfos)) {
      body["fileInfos"] = request.fileInfos;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "AddApproveDentryAuth",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processInstances/spaces/files/authDownload`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddApproveDentryAuthResponse>(await this.execute(params, req, runtime), new AddApproveDentryAuthResponse({}));
  }

  /**
   * 授权下载审批钉盘文件
   * 
   * @param request - AddApproveDentryAuthRequest
   * @returns AddApproveDentryAuthResponse
   */
  async addApproveDentryAuth(request: AddApproveDentryAuthRequest): Promise<AddApproveDentryAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddApproveDentryAuthHeaders({ });
    return await this.addApproveDentryAuthWithOptions(request, headers, runtime);
  }

  /**
   * 添加审批评论
   * 
   * @param request - AddProcessInstanceCommentRequest
   * @param headers - AddProcessInstanceCommentHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddProcessInstanceCommentResponse
   */
  async addProcessInstanceCommentWithOptions(request: AddProcessInstanceCommentRequest, headers: AddProcessInstanceCommentHeaders, runtime: $Util.RuntimeOptions): Promise<AddProcessInstanceCommentResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.commentUserId)) {
      body["commentUserId"] = request.commentUserId;
    }

    if (!Util.isUnset(request.file)) {
      body["file"] = request.file;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.text)) {
      body["text"] = request.text;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "AddProcessInstanceComment",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processInstances/comments`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddProcessInstanceCommentResponse>(await this.execute(params, req, runtime), new AddProcessInstanceCommentResponse({}));
  }

  /**
   * 添加审批评论
   * 
   * @param request - AddProcessInstanceCommentRequest
   * @returns AddProcessInstanceCommentResponse
   */
  async addProcessInstanceComment(request: AddProcessInstanceCommentRequest): Promise<AddProcessInstanceCommentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddProcessInstanceCommentHeaders({ });
    return await this.addProcessInstanceCommentWithOptions(request, headers, runtime);
  }

  /**
   * 批量同意或拒绝审批任务
   * 
   * @param request - BatchExecuteProcessInstancesRequest
   * @param headers - BatchExecuteProcessInstancesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchExecuteProcessInstancesResponse
   */
  async batchExecuteProcessInstancesWithOptions(request: BatchExecuteProcessInstancesRequest, headers: BatchExecuteProcessInstancesHeaders, runtime: $Util.RuntimeOptions): Promise<BatchExecuteProcessInstancesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionerUserId)) {
      body["actionerUserId"] = request.actionerUserId;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.result)) {
      body["result"] = request.result;
    }

    if (!Util.isUnset(request.taskInfoList)) {
      body["taskInfoList"] = request.taskInfoList;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "BatchExecuteProcessInstances",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processInstances/batchExecute`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchExecuteProcessInstancesResponse>(await this.execute(params, req, runtime), new BatchExecuteProcessInstancesResponse({}));
  }

  /**
   * 批量同意或拒绝审批任务
   * 
   * @param request - BatchExecuteProcessInstancesRequest
   * @returns BatchExecuteProcessInstancesResponse
   */
  async batchExecuteProcessInstances(request: BatchExecuteProcessInstancesRequest): Promise<BatchExecuteProcessInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchExecuteProcessInstancesHeaders({ });
    return await this.batchExecuteProcessInstancesWithOptions(request, headers, runtime);
  }

  /**
   * 批量流程审批任务转交
   * 
   * @param request - BatchTasksRedirectRequest
   * @param headers - BatchTasksRedirectHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchTasksRedirectResponse
   */
  async batchTasksRedirectWithOptions(request: BatchTasksRedirectRequest, headers: BatchTasksRedirectHeaders, runtime: $Util.RuntimeOptions): Promise<BatchTasksRedirectResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.handoverUserId)) {
      body["handoverUserId"] = request.handoverUserId;
    }

    if (!Util.isUnset(request.managerUserId)) {
      body["managerUserId"] = request.managerUserId;
    }

    if (!Util.isUnset(request.taskIds)) {
      body["taskIds"] = request.taskIds;
    }

    if (!Util.isUnset(request.transfereeUserId)) {
      body["transfereeUserId"] = request.transfereeUserId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "BatchTasksRedirect",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/tasks/batchRedirect`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchTasksRedirectResponse>(await this.execute(params, req, runtime), new BatchTasksRedirectResponse({}));
  }

  /**
   * 批量流程审批任务转交
   * 
   * @param request - BatchTasksRedirectRequest
   * @returns BatchTasksRedirectResponse
   */
  async batchTasksRedirect(request: BatchTasksRedirectRequest): Promise<BatchTasksRedirectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchTasksRedirectHeaders({ });
    return await this.batchTasksRedirectWithOptions(request, headers, runtime);
  }

  /**
   * 批量更新实例状态
   * 
   * @param request - BatchUpdateProcessInstanceRequest
   * @param headers - BatchUpdateProcessInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchUpdateProcessInstanceResponse
   */
  async batchUpdateProcessInstanceWithOptions(request: BatchUpdateProcessInstanceRequest, headers: BatchUpdateProcessInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<BatchUpdateProcessInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.updateProcessInstanceRequests)) {
      body["updateProcessInstanceRequests"] = request.updateProcessInstanceRequests;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "BatchUpdateProcessInstance",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processCentres/instances/batch`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchUpdateProcessInstanceResponse>(await this.execute(params, req, runtime), new BatchUpdateProcessInstanceResponse({}));
  }

  /**
   * 批量更新实例状态
   * 
   * @param request - BatchUpdateProcessInstanceRequest
   * @returns BatchUpdateProcessInstanceResponse
   */
  async batchUpdateProcessInstance(request: BatchUpdateProcessInstanceRequest): Promise<BatchUpdateProcessInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchUpdateProcessInstanceHeaders({ });
    return await this.batchUpdateProcessInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 批量取消流程中心待处理任务
   * 
   * @param request - CancelIntegratedTaskRequest
   * @param headers - CancelIntegratedTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CancelIntegratedTaskResponse
   */
  async cancelIntegratedTaskWithOptions(request: CancelIntegratedTaskRequest, headers: CancelIntegratedTaskHeaders, runtime: $Util.RuntimeOptions): Promise<CancelIntegratedTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.activityId)) {
      body["activityId"] = request.activityId;
    }

    if (!Util.isUnset(request.activityIds)) {
      body["activityIds"] = request.activityIds;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CancelIntegratedTask",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processCentres/tasks/cancel`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CancelIntegratedTaskResponse>(await this.execute(params, req, runtime), new CancelIntegratedTaskResponse({}));
  }

  /**
   * 批量取消流程中心待处理任务
   * 
   * @param request - CancelIntegratedTaskRequest
   * @returns CancelIntegratedTaskResponse
   */
  async cancelIntegratedTask(request: CancelIntegratedTaskRequest): Promise<CancelIntegratedTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CancelIntegratedTaskHeaders({ });
    return await this.cancelIntegratedTaskWithOptions(request, headers, runtime);
  }

  /**
   * 清理审批数据
   * 
   * @param request - CleanProcessDataRequest
   * @param headers - CleanProcessDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CleanProcessDataResponse
   */
  async cleanProcessDataWithOptions(request: CleanProcessDataRequest, headers: CleanProcessDataHeaders, runtime: $Util.RuntimeOptions): Promise<CleanProcessDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.processCode)) {
      body["processCode"] = request.processCode;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CleanProcessData",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processes/clean`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CleanProcessDataResponse>(await this.execute(params, req, runtime), new CleanProcessDataResponse({}));
  }

  /**
   * 清理审批数据
   * 
   * @param request - CleanProcessDataRequest
   * @returns CleanProcessDataResponse
   */
  async cleanProcessData(request: CleanProcessDataRequest): Promise<CleanProcessDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CleanProcessDataHeaders({ });
    return await this.cleanProcessDataWithOptions(request, headers, runtime);
  }

  /**
   * 复制审批流
   * 
   * @param request - CopyProcessRequest
   * @param headers - CopyProcessHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CopyProcessResponse
   */
  async copyProcessWithOptions(request: CopyProcessRequest, headers: CopyProcessHeaders, runtime: $Util.RuntimeOptions): Promise<CopyProcessResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.copyOptions)) {
      body["copyOptions"] = request.copyOptions;
    }

    if (!Util.isUnset(request.sourceCorpId)) {
      body["sourceCorpId"] = request.sourceCorpId;
    }

    if (!Util.isUnset(request.sourceProcessVOList)) {
      body["sourceProcessVOList"] = request.sourceProcessVOList;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CopyProcess",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processes/copy`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CopyProcessResponse>(await this.execute(params, req, runtime), new CopyProcessResponse({}));
  }

  /**
   * 复制审批流
   * 
   * @param request - CopyProcessRequest
   * @returns CopyProcessResponse
   */
  async copyProcess(request: CopyProcessRequest): Promise<CopyProcessResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CopyProcessHeaders({ });
    return await this.copyProcessWithOptions(request, headers, runtime);
  }

  /**
   * 创建流程中心待处理任务
   * 
   * @param request - CreateIntegratedTaskRequest
   * @param headers - CreateIntegratedTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateIntegratedTaskResponse
   */
  async createIntegratedTaskWithOptions(request: CreateIntegratedTaskRequest, headers: CreateIntegratedTaskHeaders, runtime: $Util.RuntimeOptions): Promise<CreateIntegratedTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.activityId)) {
      body["activityId"] = request.activityId;
    }

    if (!Util.isUnset(request.featureConfig)) {
      body["featureConfig"] = request.featureConfig;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.tasks)) {
      body["tasks"] = request.tasks;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateIntegratedTask",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processCentres/tasks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateIntegratedTaskResponse>(await this.execute(params, req, runtime), new CreateIntegratedTaskResponse({}));
  }

  /**
   * 创建流程中心待处理任务
   * 
   * @param request - CreateIntegratedTaskRequest
   * @returns CreateIntegratedTaskResponse
   */
  async createIntegratedTask(request: CreateIntegratedTaskRequest): Promise<CreateIntegratedTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateIntegratedTaskHeaders({ });
    return await this.createIntegratedTaskWithOptions(request, headers, runtime);
  }

  /**
   * 删除分组
   * 
   * @param request - DeleteDirRequest
   * @param headers - DeleteDirHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteDirResponse
   */
  async deleteDirWithOptions(request: DeleteDirRequest, headers: DeleteDirHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteDirResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dirId)) {
      query["dirId"] = request.dirId;
    }

    if (!Util.isUnset(request.operateUserId)) {
      query["operateUserId"] = request.operateUserId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "DeleteDir",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processCentres/directories`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteDirResponse>(await this.execute(params, req, runtime), new DeleteDirResponse({}));
  }

  /**
   * 删除分组
   * 
   * @param request - DeleteDirRequest
   * @returns DeleteDirResponse
   */
  async deleteDir(request: DeleteDirRequest): Promise<DeleteDirResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteDirHeaders({ });
    return await this.deleteDirWithOptions(request, headers, runtime);
  }

  /**
   * 删除模板
   * 
   * @param request - DeleteProcessRequest
   * @param headers - DeleteProcessHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteProcessResponse
   */
  async deleteProcessWithOptions(request: DeleteProcessRequest, headers: DeleteProcessHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteProcessResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cleanRunningTask)) {
      query["cleanRunningTask"] = request.cleanRunningTask;
    }

    if (!Util.isUnset(request.processCode)) {
      query["processCode"] = request.processCode;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "DeleteProcess",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processCentres/schemas`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteProcessResponse>(await this.execute(params, req, runtime), new DeleteProcessResponse({}));
  }

  /**
   * 删除模板
   * 
   * @param request - DeleteProcessRequest
   * @returns DeleteProcessResponse
   */
  async deleteProcess(request: DeleteProcessRequest): Promise<DeleteProcessResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteProcessHeaders({ });
    return await this.deleteProcessWithOptions(request, headers, runtime);
  }

  /**
   * 同意或拒绝审批任务
   * 
   * @param request - ExecuteProcessInstanceRequest
   * @param headers - ExecuteProcessInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ExecuteProcessInstanceResponse
   */
  async executeProcessInstanceWithOptions(request: ExecuteProcessInstanceRequest, headers: ExecuteProcessInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<ExecuteProcessInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionerUserId)) {
      body["actionerUserId"] = request.actionerUserId;
    }

    if (!Util.isUnset(request.file)) {
      body["file"] = request.file;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.result)) {
      body["result"] = request.result;
    }

    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "ExecuteProcessInstance",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processInstances/execute`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ExecuteProcessInstanceResponse>(await this.execute(params, req, runtime), new ExecuteProcessInstanceResponse({}));
  }

  /**
   * 同意或拒绝审批任务
   * 
   * @param request - ExecuteProcessInstanceRequest
   * @returns ExecuteProcessInstanceResponse
   */
  async executeProcessInstance(request: ExecuteProcessInstanceRequest): Promise<ExecuteProcessInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecuteProcessInstanceHeaders({ });
    return await this.executeProcessInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 创建或更新审批表单模板
   * 
   * @param request - FormCreateRequest
   * @param headers - FormCreateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns FormCreateResponse
   */
  async formCreateWithOptions(request: FormCreateRequest, headers: FormCreateHeaders, runtime: $Util.RuntimeOptions): Promise<FormCreateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.formComponents)) {
      body["formComponents"] = request.formComponents;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.processCode)) {
      body["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.templateConfig)) {
      body["templateConfig"] = request.templateConfig;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "FormCreate",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/forms`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<FormCreateResponse>(await this.execute(params, req, runtime), new FormCreateResponse({}));
  }

  /**
   * 创建或更新审批表单模板
   * 
   * @param request - FormCreateRequest
   * @returns FormCreateResponse
   */
  async formCreate(request: FormCreateRequest): Promise<FormCreateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FormCreateHeaders({ });
    return await this.formCreateWithOptions(request, headers, runtime);
  }

  /**
   * 获取审批钉盘空间信息
   * 
   * @param request - GetAttachmentSpaceRequest
   * @param headers - GetAttachmentSpaceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAttachmentSpaceResponse
   */
  async getAttachmentSpaceWithOptions(request: GetAttachmentSpaceRequest, headers: GetAttachmentSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<GetAttachmentSpaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentId)) {
      body["agentId"] = request.agentId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetAttachmentSpace",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processInstances/spaces/infos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAttachmentSpaceResponse>(await this.execute(params, req, runtime), new GetAttachmentSpaceResponse({}));
  }

  /**
   * 获取审批钉盘空间信息
   * 
   * @param request - GetAttachmentSpaceRequest
   * @returns GetAttachmentSpaceResponse
   */
  async getAttachmentSpace(request: GetAttachmentSpaceRequest): Promise<GetAttachmentSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAttachmentSpaceHeaders({ });
    return await this.getAttachmentSpaceWithOptions(request, headers, runtime);
  }

  /**
   * 查询已设置为条件的表单组件
   * 
   * @param request - GetConditionFormComponentRequest
   * @param headers - GetConditionFormComponentHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetConditionFormComponentResponse
   */
  async getConditionFormComponentWithOptions(request: GetConditionFormComponentRequest, headers: GetConditionFormComponentHeaders, runtime: $Util.RuntimeOptions): Promise<GetConditionFormComponentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentId)) {
      query["agentId"] = request.agentId;
    }

    if (!Util.isUnset(request.processCode)) {
      query["processCode"] = request.processCode;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetConditionFormComponent",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processes/conditions/components`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetConditionFormComponentResponse>(await this.execute(params, req, runtime), new GetConditionFormComponentResponse({}));
  }

  /**
   * 查询已设置为条件的表单组件
   * 
   * @param request - GetConditionFormComponentRequest
   * @returns GetConditionFormComponentResponse
   */
  async getConditionFormComponent(request: GetConditionFormComponentRequest): Promise<GetConditionFormComponentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConditionFormComponentHeaders({ });
    return await this.getConditionFormComponentWithOptions(request, headers, runtime);
  }

  /**
   * 获取CRM所有流程code
   * 
   * @param headers - GetCrmProcCodesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCrmProcCodesResponse
   */
  async getCrmProcCodesWithOptions(headers: GetCrmProcCodesHeaders, runtime: $Util.RuntimeOptions): Promise<GetCrmProcCodesResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetCrmProcCodes",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/crm/processes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCrmProcCodesResponse>(await this.execute(params, req, runtime), new GetCrmProcCodesResponse({}));
  }

  /**
   * 获取CRM所有流程code
   * @returns GetCrmProcCodesResponse
   */
  async getCrmProcCodes(): Promise<GetCrmProcCodesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCrmProcCodesHeaders({ });
    return await this.getCrmProcCodesWithOptions(headers, runtime);
  }

  /**
   * 获取表单字段修改历史
   * 
   * @param request - GetFieldModifiedHistoryRequest
   * @param headers - GetFieldModifiedHistoryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFieldModifiedHistoryResponse
   */
  async getFieldModifiedHistoryWithOptions(request: GetFieldModifiedHistoryRequest, headers: GetFieldModifiedHistoryHeaders, runtime: $Util.RuntimeOptions): Promise<GetFieldModifiedHistoryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fieldId)) {
      body["fieldId"] = request.fieldId;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetFieldModifiedHistory",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processes/fields/modifiedRecords/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFieldModifiedHistoryResponse>(await this.execute(params, req, runtime), new GetFieldModifiedHistoryResponse({}));
  }

  /**
   * 获取表单字段修改历史
   * 
   * @param request - GetFieldModifiedHistoryRequest
   * @returns GetFieldModifiedHistoryResponse
   */
  async getFieldModifiedHistory(request: GetFieldModifiedHistoryRequest): Promise<GetFieldModifiedHistoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFieldModifiedHistoryHeaders({ });
    return await this.getFieldModifiedHistoryWithOptions(request, headers, runtime);
  }

  /**
   * 获取手写签名的下载链接
   * 
   * @param request - GetHandSignDownloadUrlRequest
   * @param headers - GetHandSignDownloadUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetHandSignDownloadUrlResponse
   */
  async getHandSignDownloadUrlWithOptions(request: GetHandSignDownloadUrlRequest, headers: GetHandSignDownloadUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetHandSignDownloadUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.handSignToken)) {
      body["handSignToken"] = request.handSignToken;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetHandSignDownloadUrl",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/premium/processInstances/handSigns/downloadUrls/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetHandSignDownloadUrlResponse>(await this.execute(params, req, runtime), new GetHandSignDownloadUrlResponse({}));
  }

  /**
   * 获取手写签名的下载链接
   * 
   * @param request - GetHandSignDownloadUrlRequest
   * @returns GetHandSignDownloadUrlResponse
   */
  async getHandSignDownloadUrl(request: GetHandSignDownloadUrlRequest): Promise<GetHandSignDownloadUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetHandSignDownloadUrlHeaders({ });
    return await this.getHandSignDownloadUrlWithOptions(request, headers, runtime);
  }

  /**
   * 获取当前企业所有可管理的表单
   * 
   * @param request - GetManageProcessByStaffIdRequest
   * @param headers - GetManageProcessByStaffIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetManageProcessByStaffIdResponse
   */
  async getManageProcessByStaffIdWithOptions(request: GetManageProcessByStaffIdRequest, headers: GetManageProcessByStaffIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetManageProcessByStaffIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetManageProcessByStaffId",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processes/managements/templates`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetManageProcessByStaffIdResponse>(await this.execute(params, req, runtime), new GetManageProcessByStaffIdResponse({}));
  }

  /**
   * 获取当前企业所有可管理的表单
   * 
   * @param request - GetManageProcessByStaffIdRequest
   * @returns GetManageProcessByStaffIdResponse
   */
  async getManageProcessByStaffId(request: GetManageProcessByStaffIdRequest): Promise<GetManageProcessByStaffIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetManageProcessByStaffIdHeaders({ });
    return await this.getManageProcessByStaffIdWithOptions(request, headers, runtime);
  }

  /**
   * 获取模板code
   * 
   * @param request - GetProcessCodeByNameRequest
   * @param headers - GetProcessCodeByNameHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetProcessCodeByNameResponse
   */
  async getProcessCodeByNameWithOptions(request: GetProcessCodeByNameRequest, headers: GetProcessCodeByNameHeaders, runtime: $Util.RuntimeOptions): Promise<GetProcessCodeByNameResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      query["name"] = request.name;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetProcessCodeByName",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processCentres/schemaNames/processCodes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetProcessCodeByNameResponse>(await this.execute(params, req, runtime), new GetProcessCodeByNameResponse({}));
  }

  /**
   * 获取模板code
   * 
   * @param request - GetProcessCodeByNameRequest
   * @returns GetProcessCodeByNameResponse
   */
  async getProcessCodeByName(request: GetProcessCodeByNameRequest): Promise<GetProcessCodeByNameResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProcessCodeByNameHeaders({ });
    return await this.getProcessCodeByNameWithOptions(request, headers, runtime);
  }

  /**
   * 获取流程配置
   * 
   * @param request - GetProcessConfigRequest
   * @param headers - GetProcessConfigHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetProcessConfigResponse
   */
  async getProcessConfigWithOptions(request: GetProcessConfigRequest, headers: GetProcessConfigHeaders, runtime: $Util.RuntimeOptions): Promise<GetProcessConfigResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.procCode)) {
      query["procCode"] = request.procCode;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetProcessConfig",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/crm/processes/configurations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetProcessConfigResponse>(await this.execute(params, req, runtime), new GetProcessConfigResponse({}));
  }

  /**
   * 获取流程配置
   * 
   * @param request - GetProcessConfigRequest
   * @returns GetProcessConfigResponse
   */
  async getProcessConfig(request: GetProcessConfigRequest): Promise<GetProcessConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProcessConfigHeaders({ });
    return await this.getProcessConfigWithOptions(request, headers, runtime);
  }

  /**
   * 获取单个审批实例详情
   * 
   * @param request - GetProcessInstanceRequest
   * @param headers - GetProcessInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetProcessInstanceResponse
   */
  async getProcessInstanceWithOptions(request: GetProcessInstanceRequest, headers: GetProcessInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<GetProcessInstanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetProcessInstance",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processInstances`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetProcessInstanceResponse>(await this.execute(params, req, runtime), new GetProcessInstanceResponse({}));
  }

  /**
   * 获取单个审批实例详情
   * 
   * @param request - GetProcessInstanceRequest
   * @returns GetProcessInstanceResponse
   */
  async getProcessInstance(request: GetProcessInstanceRequest): Promise<GetProcessInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProcessInstanceHeaders({ });
    return await this.getProcessInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 获取审批单详情高级接口，可以返回审批流程中的手写签名密码消息
   * 
   * @param request - GetProcessInstanceWithExtraRequest
   * @param headers - GetProcessInstanceWithExtraHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetProcessInstanceWithExtraResponse
   */
  async getProcessInstanceWithExtraWithOptions(request: GetProcessInstanceWithExtraRequest, headers: GetProcessInstanceWithExtraHeaders, runtime: $Util.RuntimeOptions): Promise<GetProcessInstanceWithExtraResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetProcessInstanceWithExtra",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/premium/processInstances`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetProcessInstanceWithExtraResponse>(await this.execute(params, req, runtime), new GetProcessInstanceWithExtraResponse({}));
  }

  /**
   * 获取审批单详情高级接口，可以返回审批流程中的手写签名密码消息
   * 
   * @param request - GetProcessInstanceWithExtraRequest
   * @returns GetProcessInstanceWithExtraResponse
   */
  async getProcessInstanceWithExtra(request: GetProcessInstanceWithExtraRequest): Promise<GetProcessInstanceWithExtraResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProcessInstanceWithExtraHeaders({ });
    return await this.getProcessInstanceWithExtraWithOptions(request, headers, runtime);
  }

  /**
   * 根据模版code列表批量查询模板最新表单和流程配置
   * 
   * @param tmpReq - GetSchemaAndProcessconfigBatchllyRequest
   * @param headers - GetSchemaAndProcessconfigBatchllyHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSchemaAndProcessconfigBatchllyResponse
   */
  async getSchemaAndProcessconfigBatchllyWithOptions(tmpReq: GetSchemaAndProcessconfigBatchllyRequest, headers: GetSchemaAndProcessconfigBatchllyHeaders, runtime: $Util.RuntimeOptions): Promise<GetSchemaAndProcessconfigBatchllyResponse> {
    Util.validateModel(tmpReq);
    let request = new GetSchemaAndProcessconfigBatchllyShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.processCodes)) {
      request.processCodesShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.processCodes, "processCodes", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processCodesShrink)) {
      query["processCodes"] = request.processCodesShrink;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetSchemaAndProcessconfigBatchlly",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processes/templates/batchQuery`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSchemaAndProcessconfigBatchllyResponse>(await this.execute(params, req, runtime), new GetSchemaAndProcessconfigBatchllyResponse({}));
  }

  /**
   * 根据模版code列表批量查询模板最新表单和流程配置
   * 
   * @param request - GetSchemaAndProcessconfigBatchllyRequest
   * @returns GetSchemaAndProcessconfigBatchllyResponse
   */
  async getSchemaAndProcessconfigBatchlly(request: GetSchemaAndProcessconfigBatchllyRequest): Promise<GetSchemaAndProcessconfigBatchllyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSchemaAndProcessconfigBatchllyHeaders({ });
    return await this.getSchemaAndProcessconfigBatchllyWithOptions(request, headers, runtime);
  }

  /**
   * 授权预览审批附件
   * 
   * @param request - GetSpaceWithDownloadAuthRequest
   * @param headers - GetSpaceWithDownloadAuthHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSpaceWithDownloadAuthResponse
   */
  async getSpaceWithDownloadAuthWithOptions(request: GetSpaceWithDownloadAuthRequest, headers: GetSpaceWithDownloadAuthHeaders, runtime: $Util.RuntimeOptions): Promise<GetSpaceWithDownloadAuthResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentId)) {
      body["agentId"] = request.agentId;
    }

    if (!Util.isUnset(request.fileId)) {
      body["fileId"] = request.fileId;
    }

    if (!Util.isUnset(request.fileIdList)) {
      body["fileIdList"] = request.fileIdList;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.withCommentAttatchment)) {
      body["withCommentAttatchment"] = request.withCommentAttatchment;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetSpaceWithDownloadAuth",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processInstances/spaces/authPreview`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSpaceWithDownloadAuthResponse>(await this.execute(params, req, runtime), new GetSpaceWithDownloadAuthResponse({}));
  }

  /**
   * 授权预览审批附件
   * 
   * @param request - GetSpaceWithDownloadAuthRequest
   * @returns GetSpaceWithDownloadAuthResponse
   */
  async getSpaceWithDownloadAuth(request: GetSpaceWithDownloadAuthRequest): Promise<GetSpaceWithDownloadAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSpaceWithDownloadAuthHeaders({ });
    return await this.getSpaceWithDownloadAuthWithOptions(request, headers, runtime);
  }

  /**
   * 获取用户待审批数量
   * 
   * @param request - GetUserTodoTaskSumRequest
   * @param headers - GetUserTodoTaskSumHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserTodoTaskSumResponse
   */
  async getUserTodoTaskSumWithOptions(request: GetUserTodoTaskSumRequest, headers: GetUserTodoTaskSumHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserTodoTaskSumResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetUserTodoTaskSum",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processes/todoTasks/numbers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUserTodoTaskSumResponse>(await this.execute(params, req, runtime), new GetUserTodoTaskSumResponse({}));
  }

  /**
   * 获取用户待审批数量
   * 
   * @param request - GetUserTodoTaskSumRequest
   * @returns GetUserTodoTaskSumResponse
   */
  async getUserTodoTaskSum(request: GetUserTodoTaskSumRequest): Promise<GetUserTodoTaskSumResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserTodoTaskSumHeaders({ });
    return await this.getUserTodoTaskSumWithOptions(request, headers, runtime);
  }

  /**
   * 授权用户钉盘空间权限
   * 
   * @param request - GrantCspaceAuthorizationRequest
   * @param headers - GrantCspaceAuthorizationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GrantCspaceAuthorizationResponse
   */
  async grantCspaceAuthorizationWithOptions(request: GrantCspaceAuthorizationRequest, headers: GrantCspaceAuthorizationHeaders, runtime: $Util.RuntimeOptions): Promise<GrantCspaceAuthorizationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.durationSeconds)) {
      body["durationSeconds"] = request.durationSeconds;
    }

    if (!Util.isUnset(request.spaceId)) {
      body["spaceId"] = request.spaceId;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GrantCspaceAuthorization",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/spaces/authorize`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<GrantCspaceAuthorizationResponse>(await this.execute(params, req, runtime), new GrantCspaceAuthorizationResponse({}));
  }

  /**
   * 授权用户钉盘空间权限
   * 
   * @param request - GrantCspaceAuthorizationRequest
   * @returns GrantCspaceAuthorizationResponse
   */
  async grantCspaceAuthorization(request: GrantCspaceAuthorizationRequest): Promise<GrantCspaceAuthorizationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GrantCspaceAuthorizationHeaders({ });
    return await this.grantCspaceAuthorizationWithOptions(request, headers, runtime);
  }

  /**
   * 下载审批附件
   * 
   * @param request - GrantProcessInstanceForDownloadFileRequest
   * @param headers - GrantProcessInstanceForDownloadFileHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GrantProcessInstanceForDownloadFileResponse
   */
  async grantProcessInstanceForDownloadFileWithOptions(request: GrantProcessInstanceForDownloadFileRequest, headers: GrantProcessInstanceForDownloadFileHeaders, runtime: $Util.RuntimeOptions): Promise<GrantProcessInstanceForDownloadFileResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fileId)) {
      body["fileId"] = request.fileId;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.withCommentAttatchment)) {
      body["withCommentAttatchment"] = request.withCommentAttatchment;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GrantProcessInstanceForDownloadFile",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processInstances/spaces/files/urls/download`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GrantProcessInstanceForDownloadFileResponse>(await this.execute(params, req, runtime), new GrantProcessInstanceForDownloadFileResponse({}));
  }

  /**
   * 下载审批附件
   * 
   * @param request - GrantProcessInstanceForDownloadFileRequest
   * @returns GrantProcessInstanceForDownloadFileResponse
   */
  async grantProcessInstanceForDownloadFile(request: GrantProcessInstanceForDownloadFileRequest): Promise<GrantProcessInstanceForDownloadFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GrantProcessInstanceForDownloadFileHeaders({ });
    return await this.grantProcessInstanceForDownloadFileWithOptions(request, headers, runtime);
  }

  /**
   * 创建或更新分组
   * 
   * @param request - InsertOrUpdateDirRequest
   * @param headers - InsertOrUpdateDirHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns InsertOrUpdateDirResponse
   */
  async insertOrUpdateDirWithOptions(request: InsertOrUpdateDirRequest, headers: InsertOrUpdateDirHeaders, runtime: $Util.RuntimeOptions): Promise<InsertOrUpdateDirResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizGroup)) {
      body["bizGroup"] = request.bizGroup;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.name18n)) {
      body["name18n"] = request.name18n;
    }

    if (!Util.isUnset(request.operateUserId)) {
      body["operateUserId"] = request.operateUserId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "InsertOrUpdateDir",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processCentres/directories`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InsertOrUpdateDirResponse>(await this.execute(params, req, runtime), new InsertOrUpdateDirResponse({}));
  }

  /**
   * 创建或更新分组
   * 
   * @param request - InsertOrUpdateDirRequest
   * @returns InsertOrUpdateDirResponse
   */
  async insertOrUpdateDir(request: InsertOrUpdateDirRequest): Promise<InsertOrUpdateDirResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InsertOrUpdateDirHeaders({ });
    return await this.insertOrUpdateDirWithOptions(request, headers, runtime);
  }

  /**
   * 应用安装
   * 
   * @param request - InstallAppRequest
   * @param headers - InstallAppHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns InstallAppResponse
   */
  async installAppWithOptions(request: InstallAppRequest, headers: InstallAppHeaders, runtime: $Util.RuntimeOptions): Promise<InstallAppResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizGroup)) {
      body["bizGroup"] = request.bizGroup;
    }

    if (!Util.isUnset(request.installOption)) {
      body["installOption"] = request.installOption;
    }

    if (!Util.isUnset(request.sourceDirName)) {
      body["sourceDirName"] = request.sourceDirName;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "InstallApp",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processes/apps/install`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InstallAppResponse>(await this.execute(params, req, runtime), new InstallAppResponse({}));
  }

  /**
   * 应用安装
   * 
   * @param request - InstallAppRequest
   * @returns InstallAppResponse
   */
  async installApp(request: InstallAppRequest): Promise<InstallAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InstallAppHeaders({ });
    return await this.installAppWithOptions(request, headers, runtime);
  }

  /**
   * 获取审批实例ID列表
   * 
   * @param request - ListProcessInstanceIdsRequest
   * @param headers - ListProcessInstanceIdsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListProcessInstanceIdsResponse
   */
  async listProcessInstanceIdsWithOptions(request: ListProcessInstanceIdsRequest, headers: ListProcessInstanceIdsHeaders, runtime: $Util.RuntimeOptions): Promise<ListProcessInstanceIdsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.processCode)) {
      body["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.statuses)) {
      body["statuses"] = request.statuses;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "ListProcessInstanceIds",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processes/instanceIds/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListProcessInstanceIdsResponse>(await this.execute(params, req, runtime), new ListProcessInstanceIdsResponse({}));
  }

  /**
   * 获取审批实例ID列表
   * 
   * @param request - ListProcessInstanceIdsRequest
   * @returns ListProcessInstanceIdsResponse
   */
  async listProcessInstanceIds(request: ListProcessInstanceIdsRequest): Promise<ListProcessInstanceIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListProcessInstanceIdsHeaders({ });
    return await this.listProcessInstanceIdsWithOptions(request, headers, runtime);
  }

  /**
   * 查询用户待办事项
   * 
   * @param request - ListTodoWorkRecordsRequest
   * @param headers - ListTodoWorkRecordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListTodoWorkRecordsResponse
   */
  async listTodoWorkRecordsWithOptions(request: ListTodoWorkRecordsRequest, headers: ListTodoWorkRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<ListTodoWorkRecordsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.status)) {
      query["status"] = request.status;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ListTodoWorkRecords",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/workRecords/todoTasks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListTodoWorkRecordsResponse>(await this.execute(params, req, runtime), new ListTodoWorkRecordsResponse({}));
  }

  /**
   * 查询用户待办事项
   * 
   * @param request - ListTodoWorkRecordsRequest
   * @returns ListTodoWorkRecordsResponse
   */
  async listTodoWorkRecords(request: ListTodoWorkRecordsRequest): Promise<ListTodoWorkRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListTodoWorkRecordsHeaders({ });
    return await this.listTodoWorkRecordsWithOptions(request, headers, runtime);
  }

  /**
   * 获取指定用户可见的审批表单列表
   * 
   * @param request - ListUserVisibleBpmsProcessesRequest
   * @param headers - ListUserVisibleBpmsProcessesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListUserVisibleBpmsProcessesResponse
   */
  async listUserVisibleBpmsProcessesWithOptions(request: ListUserVisibleBpmsProcessesRequest, headers: ListUserVisibleBpmsProcessesHeaders, runtime: $Util.RuntimeOptions): Promise<ListUserVisibleBpmsProcessesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ListUserVisibleBpmsProcesses",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processes/userVisibilities/templates`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListUserVisibleBpmsProcessesResponse>(await this.execute(params, req, runtime), new ListUserVisibleBpmsProcessesResponse({}));
  }

  /**
   * 获取指定用户可见的审批表单列表
   * 
   * @param request - ListUserVisibleBpmsProcessesRequest
   * @returns ListUserVisibleBpmsProcessesResponse
   */
  async listUserVisibleBpmsProcesses(request: ListUserVisibleBpmsProcessesRequest): Promise<ListUserVisibleBpmsProcessesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListUserVisibleBpmsProcessesHeaders({ });
    return await this.listUserVisibleBpmsProcessesWithOptions(request, headers, runtime);
  }

  /**
   * 分页查询实例数据
   * 
   * @param request - PagesExportInstancesRequest
   * @param headers - PagesExportInstancesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PagesExportInstancesResponse
   */
  async pagesExportInstancesWithOptions(request: PagesExportInstancesRequest, headers: PagesExportInstancesHeaders, runtime: $Util.RuntimeOptions): Promise<PagesExportInstancesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTimeInMills)) {
      query["endTimeInMills"] = request.endTimeInMills;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.orderBy)) {
      query["orderBy"] = request.orderBy;
    }

    if (!Util.isUnset(request.processCode)) {
      query["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.startTimeInMills)) {
      query["startTimeInMills"] = request.startTimeInMills;
    }

    if (!Util.isUnset(request.status)) {
      query["status"] = request.status;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "PagesExportInstances",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/instances/datas`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PagesExportInstancesResponse>(await this.execute(params, req, runtime), new PagesExportInstancesResponse({}));
  }

  /**
   * 分页查询实例数据
   * 
   * @param request - PagesExportInstancesRequest
   * @returns PagesExportInstancesResponse
   */
  async pagesExportInstances(request: PagesExportInstancesRequest): Promise<PagesExportInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PagesExportInstancesHeaders({ });
    return await this.pagesExportInstancesWithOptions(request, headers, runtime);
  }

  /**
   * 批量同意或拒绝审批任务(OA高级版专享接口)
   * 
   * @param request - PremiumBatchExecuteProcessInstancesRequest
   * @param headers - PremiumBatchExecuteProcessInstancesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PremiumBatchExecuteProcessInstancesResponse
   */
  async premiumBatchExecuteProcessInstancesWithOptions(request: PremiumBatchExecuteProcessInstancesRequest, headers: PremiumBatchExecuteProcessInstancesHeaders, runtime: $Util.RuntimeOptions): Promise<PremiumBatchExecuteProcessInstancesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionerUserId)) {
      body["actionerUserId"] = request.actionerUserId;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.result)) {
      body["result"] = request.result;
    }

    if (!Util.isUnset(request.taskInfoList)) {
      body["taskInfoList"] = request.taskInfoList;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "PremiumBatchExecuteProcessInstances",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/premium/processInstances/batchExecute`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PremiumBatchExecuteProcessInstancesResponse>(await this.execute(params, req, runtime), new PremiumBatchExecuteProcessInstancesResponse({}));
  }

  /**
   * 批量同意或拒绝审批任务(OA高级版专享接口)
   * 
   * @param request - PremiumBatchExecuteProcessInstancesRequest
   * @returns PremiumBatchExecuteProcessInstancesResponse
   */
  async premiumBatchExecuteProcessInstances(request: PremiumBatchExecuteProcessInstancesRequest): Promise<PremiumBatchExecuteProcessInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PremiumBatchExecuteProcessInstancesHeaders({ });
    return await this.premiumBatchExecuteProcessInstancesWithOptions(request, headers, runtime);
  }

  /**
   * 删除业务分组(高级版专享接口)
   * 
   * @param request - PremiumDelDirRequest
   * @param headers - PremiumDelDirHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PremiumDelDirResponse
   */
  async premiumDelDirWithOptions(request: PremiumDelDirRequest, headers: PremiumDelDirHeaders, runtime: $Util.RuntimeOptions): Promise<PremiumDelDirResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dirId)) {
      query["dirId"] = request.dirId;
    }

    if (!Util.isUnset(request.operateUserId)) {
      query["operateUserId"] = request.operateUserId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "PremiumDelDir",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/premium/processCentres/directories`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PremiumDelDirResponse>(await this.execute(params, req, runtime), new PremiumDelDirResponse({}));
  }

  /**
   * 删除业务分组(高级版专享接口)
   * 
   * @param request - PremiumDelDirRequest
   * @returns PremiumDelDirResponse
   */
  async premiumDelDir(request: PremiumDelDirRequest): Promise<PremiumDelDirResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PremiumDelDirHeaders({ });
    return await this.premiumDelDirWithOptions(request, headers, runtime);
  }

  /**
   * 查询审批中心已处理任务列表(OA高级版专享接口)
   * 
   * @param request - PremiumGetDoneTasksRequest
   * @param headers - PremiumGetDoneTasksHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PremiumGetDoneTasksResponse
   */
  async premiumGetDoneTasksWithOptions(request: PremiumGetDoneTasksRequest, headers: PremiumGetDoneTasksHeaders, runtime: $Util.RuntimeOptions): Promise<PremiumGetDoneTasksResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingClientId)) {
      query["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "PremiumGetDoneTasks",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/premium/processCentres/doneTasks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PremiumGetDoneTasksResponse>(await this.execute(params, req, runtime), new PremiumGetDoneTasksResponse({}));
  }

  /**
   * 查询审批中心已处理任务列表(OA高级版专享接口)
   * 
   * @param request - PremiumGetDoneTasksRequest
   * @returns PremiumGetDoneTasksResponse
   */
  async premiumGetDoneTasks(request: PremiumGetDoneTasksRequest): Promise<PremiumGetDoneTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PremiumGetDoneTasksHeaders({ });
    return await this.premiumGetDoneTasksWithOptions(request, headers, runtime);
  }

  /**
   * 获取字段修改历史(高级版专享接口)
   * 
   * @param request - PremiumGetFieldModifiedHistoryRequest
   * @param headers - PremiumGetFieldModifiedHistoryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PremiumGetFieldModifiedHistoryResponse
   */
  async premiumGetFieldModifiedHistoryWithOptions(request: PremiumGetFieldModifiedHistoryRequest, headers: PremiumGetFieldModifiedHistoryHeaders, runtime: $Util.RuntimeOptions): Promise<PremiumGetFieldModifiedHistoryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fieldId)) {
      body["fieldId"] = request.fieldId;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "PremiumGetFieldModifiedHistory",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/premium/processes/fields/modifiedRecords/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PremiumGetFieldModifiedHistoryResponse>(await this.execute(params, req, runtime), new PremiumGetFieldModifiedHistoryResponse({}));
  }

  /**
   * 获取字段修改历史(高级版专享接口)
   * 
   * @param request - PremiumGetFieldModifiedHistoryRequest
   * @returns PremiumGetFieldModifiedHistoryResponse
   */
  async premiumGetFieldModifiedHistory(request: PremiumGetFieldModifiedHistoryRequest): Promise<PremiumGetFieldModifiedHistoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PremiumGetFieldModifiedHistoryHeaders({ });
    return await this.premiumGetFieldModifiedHistoryWithOptions(request, headers, runtime);
  }

  /**
   * 查询审批中心我收到的实例列表(OA高级版专享接口)
   * 
   * @param request - PremiumGetNoticedInstancesRequest
   * @param headers - PremiumGetNoticedInstancesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PremiumGetNoticedInstancesResponse
   */
  async premiumGetNoticedInstancesWithOptions(request: PremiumGetNoticedInstancesRequest, headers: PremiumGetNoticedInstancesHeaders, runtime: $Util.RuntimeOptions): Promise<PremiumGetNoticedInstancesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingClientId)) {
      query["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "PremiumGetNoticedInstances",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/premium/processCentres/noticedInstances`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PremiumGetNoticedInstancesResponse>(await this.execute(params, req, runtime), new PremiumGetNoticedInstancesResponse({}));
  }

  /**
   * 查询审批中心我收到的实例列表(OA高级版专享接口)
   * 
   * @param request - PremiumGetNoticedInstancesRequest
   * @returns PremiumGetNoticedInstancesResponse
   */
  async premiumGetNoticedInstances(request: PremiumGetNoticedInstancesRequest): Promise<PremiumGetNoticedInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PremiumGetNoticedInstancesHeaders({ });
    return await this.premiumGetNoticedInstancesWithOptions(request, headers, runtime);
  }

  /**
   * 根据processCode分页获取审批流程数据(高级版专享接口)
   * 
   * @param request - PremiumGetProcessInstancesRequest
   * @param headers - PremiumGetProcessInstancesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PremiumGetProcessInstancesResponse
   */
  async premiumGetProcessInstancesWithOptions(request: PremiumGetProcessInstancesRequest, headers: PremiumGetProcessInstancesHeaders, runtime: $Util.RuntimeOptions): Promise<PremiumGetProcessInstancesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUuid)) {
      query["appUuid"] = request.appUuid;
    }

    if (!Util.isUnset(request.endTimeInMills)) {
      query["endTimeInMills"] = request.endTimeInMills;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.processCode)) {
      query["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.startTimeInMills)) {
      query["startTimeInMills"] = request.startTimeInMills;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "PremiumGetProcessInstances",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/premium/processes/pages/instances`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PremiumGetProcessInstancesResponse>(await this.execute(params, req, runtime), new PremiumGetProcessInstancesResponse({}));
  }

  /**
   * 根据processCode分页获取审批流程数据(高级版专享接口)
   * 
   * @param request - PremiumGetProcessInstancesRequest
   * @returns PremiumGetProcessInstancesResponse
   */
  async premiumGetProcessInstances(request: PremiumGetProcessInstancesRequest): Promise<PremiumGetProcessInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PremiumGetProcessInstancesHeaders({ });
    return await this.premiumGetProcessInstancesWithOptions(request, headers, runtime);
  }

  /**
   * 查询审批中心已发起实例列表(OA高级版专享接口)
   * 
   * @param request - PremiumGetSubmittedInstancesRequest
   * @param headers - PremiumGetSubmittedInstancesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PremiumGetSubmittedInstancesResponse
   */
  async premiumGetSubmittedInstancesWithOptions(request: PremiumGetSubmittedInstancesRequest, headers: PremiumGetSubmittedInstancesHeaders, runtime: $Util.RuntimeOptions): Promise<PremiumGetSubmittedInstancesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingClientId)) {
      query["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "PremiumGetSubmittedInstances",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/premium/processCentres/submittedInstances`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PremiumGetSubmittedInstancesResponse>(await this.execute(params, req, runtime), new PremiumGetSubmittedInstancesResponse({}));
  }

  /**
   * 查询审批中心已发起实例列表(OA高级版专享接口)
   * 
   * @param request - PremiumGetSubmittedInstancesRequest
   * @returns PremiumGetSubmittedInstancesResponse
   */
  async premiumGetSubmittedInstances(request: PremiumGetSubmittedInstancesRequest): Promise<PremiumGetSubmittedInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PremiumGetSubmittedInstancesHeaders({ });
    return await this.premiumGetSubmittedInstancesWithOptions(request, headers, runtime);
  }

  /**
   * 查询审批中心待处理任务列表(OA高级版专享接口)
   * 
   * @param request - PremiumGetTodoTasksRequest
   * @param headers - PremiumGetTodoTasksHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PremiumGetTodoTasksResponse
   */
  async premiumGetTodoTasksWithOptions(request: PremiumGetTodoTasksRequest, headers: PremiumGetTodoTasksHeaders, runtime: $Util.RuntimeOptions): Promise<PremiumGetTodoTasksResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.createBefore)) {
      query["createBefore"] = request.createBefore;
    }

    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "PremiumGetTodoTasks",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/premium/processCentres/todoTasks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PremiumGetTodoTasksResponse>(await this.execute(params, req, runtime), new PremiumGetTodoTasksResponse({}));
  }

  /**
   * 查询审批中心待处理任务列表(OA高级版专享接口)
   * 
   * @param request - PremiumGetTodoTasksRequest
   * @returns PremiumGetTodoTasksResponse
   */
  async premiumGetTodoTasks(request: PremiumGetTodoTasksRequest): Promise<PremiumGetTodoTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PremiumGetTodoTasksHeaders({ });
    return await this.premiumGetTodoTasksWithOptions(request, headers, runtime);
  }

  /**
   * 创建或更新分组(高级版专享接口)
   * 
   * @param request - PremiumInsertOrUpdateDirRequest
   * @param headers - PremiumInsertOrUpdateDirHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PremiumInsertOrUpdateDirResponse
   */
  async premiumInsertOrUpdateDirWithOptions(request: PremiumInsertOrUpdateDirRequest, headers: PremiumInsertOrUpdateDirHeaders, runtime: $Util.RuntimeOptions): Promise<PremiumInsertOrUpdateDirResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizGroup)) {
      body["bizGroup"] = request.bizGroup;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.name18n)) {
      body["name18n"] = request.name18n;
    }

    if (!Util.isUnset(request.operateUserId)) {
      body["operateUserId"] = request.operateUserId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "PremiumInsertOrUpdateDir",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/premium/processCentres/directories`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PremiumInsertOrUpdateDirResponse>(await this.execute(params, req, runtime), new PremiumInsertOrUpdateDirResponse({}));
  }

  /**
   * 创建或更新分组(高级版专享接口)
   * 
   * @param request - PremiumInsertOrUpdateDirRequest
   * @returns PremiumInsertOrUpdateDirResponse
   */
  async premiumInsertOrUpdateDir(request: PremiumInsertOrUpdateDirRequest): Promise<PremiumInsertOrUpdateDirResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PremiumInsertOrUpdateDirHeaders({ });
    return await this.premiumInsertOrUpdateDirWithOptions(request, headers, runtime);
  }

  /**
   * 流程转交待处理任务查询(高级版专享接口)
   * 
   * @param request - PremiumQueryTodoTasksByManagerRequest
   * @param headers - PremiumQueryTodoTasksByManagerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PremiumQueryTodoTasksByManagerResponse
   */
  async premiumQueryTodoTasksByManagerWithOptions(request: PremiumQueryTodoTasksByManagerRequest, headers: PremiumQueryTodoTasksByManagerHeaders, runtime: $Util.RuntimeOptions): Promise<PremiumQueryTodoTasksByManagerResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionerUserId)) {
      query["actionerUserId"] = request.actionerUserId;
    }

    if (!Util.isUnset(request.managerUserId)) {
      query["managerUserId"] = request.managerUserId;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "PremiumQueryTodoTasksByManager",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/premium/tasks/todoTasks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PremiumQueryTodoTasksByManagerResponse>(await this.execute(params, req, runtime), new PremiumQueryTodoTasksByManagerResponse({}));
  }

  /**
   * 流程转交待处理任务查询(高级版专享接口)
   * 
   * @param request - PremiumQueryTodoTasksByManagerRequest
   * @returns PremiumQueryTodoTasksByManagerResponse
   */
  async premiumQueryTodoTasksByManager(request: PremiumQueryTodoTasksByManagerRequest): Promise<PremiumQueryTodoTasksByManagerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PremiumQueryTodoTasksByManagerHeaders({ });
    return await this.premiumQueryTodoTasksByManagerWithOptions(request, headers, runtime);
  }

  /**
   * 批量流程审批任务转交(高级版专享接口)
   * 
   * @param request - PremiumRedirectTasksByManagerRequest
   * @param headers - PremiumRedirectTasksByManagerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PremiumRedirectTasksByManagerResponse
   */
  async premiumRedirectTasksByManagerWithOptions(request: PremiumRedirectTasksByManagerRequest, headers: PremiumRedirectTasksByManagerHeaders, runtime: $Util.RuntimeOptions): Promise<PremiumRedirectTasksByManagerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.handoverUserId)) {
      body["handoverUserId"] = request.handoverUserId;
    }

    if (!Util.isUnset(request.managerUserId)) {
      body["managerUserId"] = request.managerUserId;
    }

    if (!Util.isUnset(request.taskIds)) {
      body["taskIds"] = request.taskIds;
    }

    if (!Util.isUnset(request.transfereeUserId)) {
      body["transfereeUserId"] = request.transfereeUserId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "PremiumRedirectTasksByManager",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/premium/tasks/batchRedirect`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PremiumRedirectTasksByManagerResponse>(await this.execute(params, req, runtime), new PremiumRedirectTasksByManagerResponse({}));
  }

  /**
   * 批量流程审批任务转交(高级版专享接口)
   * 
   * @param request - PremiumRedirectTasksByManagerRequest
   * @returns PremiumRedirectTasksByManagerResponse
   */
  async premiumRedirectTasksByManager(request: PremiumRedirectTasksByManagerRequest): Promise<PremiumRedirectTasksByManagerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PremiumRedirectTasksByManagerHeaders({ });
    return await this.premiumRedirectTasksByManagerWithOptions(request, headers, runtime);
  }

  /**
   * 创建或更新流程中心外部集成模板(高级版专享接口)
   * 
   * @param request - PremiumSaveIntegratedProcessRequest
   * @param headers - PremiumSaveIntegratedProcessHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PremiumSaveIntegratedProcessResponse
   */
  async premiumSaveIntegratedProcessWithOptions(request: PremiumSaveIntegratedProcessRequest, headers: PremiumSaveIntegratedProcessHeaders, runtime: $Util.RuntimeOptions): Promise<PremiumSaveIntegratedProcessResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.formComponents)) {
      body["formComponents"] = request.formComponents;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.processCode)) {
      body["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.processFeatureConfig)) {
      body["processFeatureConfig"] = request.processFeatureConfig;
    }

    if (!Util.isUnset(request.templateConfig)) {
      body["templateConfig"] = request.templateConfig;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "PremiumSaveIntegratedProcess",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/premium/processCentres/schemas`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PremiumSaveIntegratedProcessResponse>(await this.execute(params, req, runtime), new PremiumSaveIntegratedProcessResponse({}));
  }

  /**
   * 创建或更新流程中心外部集成模板(高级版专享接口)
   * 
   * @param request - PremiumSaveIntegratedProcessRequest
   * @returns PremiumSaveIntegratedProcessResponse
   */
  async premiumSaveIntegratedProcess(request: PremiumSaveIntegratedProcessRequest): Promise<PremiumSaveIntegratedProcessResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PremiumSaveIntegratedProcessHeaders({ });
    return await this.premiumSaveIntegratedProcessWithOptions(request, headers, runtime);
  }

  /**
   * 创建流程中心外部集成实例(高级版专享接口)
   * 
   * @param request - PremiumSaveIntegratedProcessInstanceRequest
   * @param headers - PremiumSaveIntegratedProcessInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PremiumSaveIntegratedProcessInstanceResponse
   */
  async premiumSaveIntegratedProcessInstanceWithOptions(request: PremiumSaveIntegratedProcessInstanceRequest, headers: PremiumSaveIntegratedProcessInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<PremiumSaveIntegratedProcessInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizData)) {
      body["bizData"] = request.bizData;
    }

    if (!Util.isUnset(request.formComponentValueList)) {
      body["formComponentValueList"] = request.formComponentValueList;
    }

    if (!Util.isUnset(request.notifiers)) {
      body["notifiers"] = request.notifiers;
    }

    if (!Util.isUnset(request.originatorUserId)) {
      body["originatorUserId"] = request.originatorUserId;
    }

    if (!Util.isUnset(request.processCode)) {
      body["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.url)) {
      body["url"] = request.url;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "PremiumSaveIntegratedProcessInstance",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/premium/processCentres/instances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PremiumSaveIntegratedProcessInstanceResponse>(await this.execute(params, req, runtime), new PremiumSaveIntegratedProcessInstanceResponse({}));
  }

  /**
   * 创建流程中心外部集成实例(高级版专享接口)
   * 
   * @param request - PremiumSaveIntegratedProcessInstanceRequest
   * @returns PremiumSaveIntegratedProcessInstanceResponse
   */
  async premiumSaveIntegratedProcessInstance(request: PremiumSaveIntegratedProcessInstanceRequest): Promise<PremiumSaveIntegratedProcessInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PremiumSaveIntegratedProcessInstanceHeaders({ });
    return await this.premiumSaveIntegratedProcessInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 创建流程中心外部集成待处理任务(高级版专享接口)
   * 
   * @param request - PremiumSaveIntegratedTaskRequest
   * @param headers - PremiumSaveIntegratedTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PremiumSaveIntegratedTaskResponse
   */
  async premiumSaveIntegratedTaskWithOptions(request: PremiumSaveIntegratedTaskRequest, headers: PremiumSaveIntegratedTaskHeaders, runtime: $Util.RuntimeOptions): Promise<PremiumSaveIntegratedTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.activityId)) {
      body["activityId"] = request.activityId;
    }

    if (!Util.isUnset(request.featureConfig)) {
      body["featureConfig"] = request.featureConfig;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.tasks)) {
      body["tasks"] = request.tasks;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "PremiumSaveIntegratedTask",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/premium/processCentres/tasks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PremiumSaveIntegratedTaskResponse>(await this.execute(params, req, runtime), new PremiumSaveIntegratedTaskResponse({}));
  }

  /**
   * 创建流程中心外部集成待处理任务(高级版专享接口)
   * 
   * @param request - PremiumSaveIntegratedTaskRequest
   * @returns PremiumSaveIntegratedTaskResponse
   */
  async premiumSaveIntegratedTask(request: PremiumSaveIntegratedTaskRequest): Promise<PremiumSaveIntegratedTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PremiumSaveIntegratedTaskHeaders({ });
    return await this.premiumSaveIntegratedTaskWithOptions(request, headers, runtime);
  }

  /**
   * 审批流程预测
   * 
   * @param request - ProcessForecastRequest
   * @param headers - ProcessForecastHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ProcessForecastResponse
   */
  async processForecastWithOptions(request: ProcessForecastRequest, headers: ProcessForecastHeaders, runtime: $Util.RuntimeOptions): Promise<ProcessForecastResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.formComponentValues)) {
      body["formComponentValues"] = request.formComponentValues;
    }

    if (!Util.isUnset(request.processCode)) {
      body["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "ProcessForecast",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processes/forecast`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ProcessForecastResponse>(await this.execute(params, req, runtime), new ProcessForecastResponse({}));
  }

  /**
   * 审批流程预测
   * 
   * @param request - ProcessForecastRequest
   * @returns ProcessForecastResponse
   */
  async processForecast(request: ProcessForecastRequest): Promise<ProcessForecastResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ProcessForecastHeaders({ });
    return await this.processForecastWithOptions(request, headers, runtime);
  }

  /**
   * 根据processCode分页获取表单数据
   * 
   * @param request - QueryAllFormInstancesRequest
   * @param headers - QueryAllFormInstancesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryAllFormInstancesResponse
   */
  async queryAllFormInstancesWithOptions(request: QueryAllFormInstancesRequest, headers: QueryAllFormInstancesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllFormInstancesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUuid)) {
      query["appUuid"] = request.appUuid;
    }

    if (!Util.isUnset(request.formCode)) {
      query["formCode"] = request.formCode;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "QueryAllFormInstances",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/forms/pages/instances`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAllFormInstancesResponse>(await this.execute(params, req, runtime), new QueryAllFormInstancesResponse({}));
  }

  /**
   * 根据processCode分页获取表单数据
   * 
   * @param request - QueryAllFormInstancesRequest
   * @returns QueryAllFormInstancesResponse
   */
  async queryAllFormInstances(request: QueryAllFormInstancesRequest): Promise<QueryAllFormInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllFormInstancesHeaders({ });
    return await this.queryAllFormInstancesWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询审批流程实例
   * 
   * @param request - QueryAllProcessInstancesRequest
   * @param headers - QueryAllProcessInstancesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryAllProcessInstancesResponse
   */
  async queryAllProcessInstancesWithOptions(request: QueryAllProcessInstancesRequest, headers: QueryAllProcessInstancesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllProcessInstancesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUuid)) {
      query["appUuid"] = request.appUuid;
    }

    if (!Util.isUnset(request.endTimeInMills)) {
      query["endTimeInMills"] = request.endTimeInMills;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.processCode)) {
      query["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.startTimeInMills)) {
      query["startTimeInMills"] = request.startTimeInMills;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "QueryAllProcessInstances",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processes/pages/instances`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAllProcessInstancesResponse>(await this.execute(params, req, runtime), new QueryAllProcessInstancesResponse({}));
  }

  /**
   * 批量查询审批流程实例
   * 
   * @param request - QueryAllProcessInstancesRequest
   * @returns QueryAllProcessInstancesResponse
   */
  async queryAllProcessInstances(request: QueryAllProcessInstancesRequest): Promise<QueryAllProcessInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllProcessInstancesHeaders({ });
    return await this.queryAllProcessInstancesWithOptions(request, headers, runtime);
  }

  /**
   * 根据业务标识查询表单描述信息
   * 
   * @param request - QueryFormByBizTypeRequest
   * @param headers - QueryFormByBizTypeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryFormByBizTypeResponse
   */
  async queryFormByBizTypeWithOptions(request: QueryFormByBizTypeRequest, headers: QueryFormByBizTypeHeaders, runtime: $Util.RuntimeOptions): Promise<QueryFormByBizTypeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUuid)) {
      body["appUuid"] = request.appUuid;
    }

    if (!Util.isUnset(request.bizTypes)) {
      body["bizTypes"] = request.bizTypes;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "QueryFormByBizType",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/forms/forminfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryFormByBizTypeResponse>(await this.execute(params, req, runtime), new QueryFormByBizTypeResponse({}));
  }

  /**
   * 根据业务标识查询表单描述信息
   * 
   * @param request - QueryFormByBizTypeRequest
   * @returns QueryFormByBizTypeResponse
   */
  async queryFormByBizType(request: QueryFormByBizTypeRequest): Promise<QueryFormByBizTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryFormByBizTypeHeaders({ });
    return await this.queryFormByBizTypeWithOptions(request, headers, runtime);
  }

  /**
   * 查询数据表单
   * 
   * @param request - QueryFormInstanceRequest
   * @param headers - QueryFormInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryFormInstanceResponse
   */
  async queryFormInstanceWithOptions(request: QueryFormInstanceRequest, headers: QueryFormInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryFormInstanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUuid)) {
      query["appUuid"] = request.appUuid;
    }

    if (!Util.isUnset(request.formCode)) {
      query["formCode"] = request.formCode;
    }

    if (!Util.isUnset(request.formInstanceId)) {
      query["formInstanceId"] = request.formInstanceId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "QueryFormInstance",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/forms/instances`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryFormInstanceResponse>(await this.execute(params, req, runtime), new QueryFormInstanceResponse({}));
  }

  /**
   * 查询数据表单
   * 
   * @param request - QueryFormInstanceRequest
   * @returns QueryFormInstanceResponse
   */
  async queryFormInstance(request: QueryFormInstanceRequest): Promise<QueryFormInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryFormInstanceHeaders({ });
    return await this.queryFormInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 查询通过流程中心集成的OA审批任务
   * 
   * @param request - QueryIntegratedTodoTaskRequest
   * @param headers - QueryIntegratedTodoTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryIntegratedTodoTaskResponse
   */
  async queryIntegratedTodoTaskWithOptions(request: QueryIntegratedTodoTaskRequest, headers: QueryIntegratedTodoTaskHeaders, runtime: $Util.RuntimeOptions): Promise<QueryIntegratedTodoTaskResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.createBefore)) {
      query["createBefore"] = request.createBefore;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "QueryIntegratedTodoTask",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processCentres/todoTasks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryIntegratedTodoTaskResponse>(await this.execute(params, req, runtime), new QueryIntegratedTodoTaskResponse({}));
  }

  /**
   * 查询通过流程中心集成的OA审批任务
   * 
   * @param request - QueryIntegratedTodoTaskRequest
   * @returns QueryIntegratedTodoTaskResponse
   */
  async queryIntegratedTodoTask(request: QueryIntegratedTodoTaskRequest): Promise<QueryIntegratedTodoTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryIntegratedTodoTaskHeaders({ });
    return await this.queryIntegratedTodoTaskWithOptions(request, headers, runtime);
  }

  /**
   * 根据业务标识查询模板
   * 
   * @param request - QueryProcessByBizCategoryIdRequest
   * @param headers - QueryProcessByBizCategoryIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryProcessByBizCategoryIdResponse
   */
  async queryProcessByBizCategoryIdWithOptions(request: QueryProcessByBizCategoryIdRequest, headers: QueryProcessByBizCategoryIdHeaders, runtime: $Util.RuntimeOptions): Promise<QueryProcessByBizCategoryIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      query["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "QueryProcessByBizCategoryId",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processes/categories/templates`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryProcessByBizCategoryIdResponse>(await this.execute(params, req, runtime), new QueryProcessByBizCategoryIdResponse({}));
  }

  /**
   * 根据业务标识查询模板
   * 
   * @param request - QueryProcessByBizCategoryIdRequest
   * @returns QueryProcessByBizCategoryIdResponse
   */
  async queryProcessByBizCategoryId(request: QueryProcessByBizCategoryIdRequest): Promise<QueryProcessByBizCategoryIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryProcessByBizCategoryIdHeaders({ });
    return await this.queryProcessByBizCategoryIdWithOptions(request, headers, runtime);
  }

  /**
   * 蓝凌获取schema和流程信息
   * 
   * @param request - QuerySchemaAndProcessRequest
   * @param headers - QuerySchemaAndProcessHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QuerySchemaAndProcessResponse
   */
  async querySchemaAndProcessWithOptions(request: QuerySchemaAndProcessRequest, headers: QuerySchemaAndProcessHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySchemaAndProcessResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUuid)) {
      query["appUuid"] = request.appUuid;
    }

    if (!Util.isUnset(request.processCode)) {
      query["processCode"] = request.processCode;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "QuerySchemaAndProcess",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/forms/schemaAndProcess`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QuerySchemaAndProcessResponse>(await this.execute(params, req, runtime), new QuerySchemaAndProcessResponse({}));
  }

  /**
   * 蓝凌获取schema和流程信息
   * 
   * @param request - QuerySchemaAndProcessRequest
   * @returns QuerySchemaAndProcessResponse
   */
  async querySchemaAndProcess(request: QuerySchemaAndProcessRequest): Promise<QuerySchemaAndProcessResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySchemaAndProcessHeaders({ });
    return await this.querySchemaAndProcessWithOptions(request, headers, runtime);
  }

  /**
   * 通过 processCode 获取表单 schema 信息
   * 
   * @param request - QuerySchemaByProcessCodeRequest
   * @param headers - QuerySchemaByProcessCodeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QuerySchemaByProcessCodeResponse
   */
  async querySchemaByProcessCodeWithOptions(request: QuerySchemaByProcessCodeRequest, headers: QuerySchemaByProcessCodeHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySchemaByProcessCodeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUuid)) {
      query["appUuid"] = request.appUuid;
    }

    if (!Util.isUnset(request.processCode)) {
      query["processCode"] = request.processCode;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "QuerySchemaByProcessCode",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/forms/schemas/processCodes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QuerySchemaByProcessCodeResponse>(await this.execute(params, req, runtime), new QuerySchemaByProcessCodeResponse({}));
  }

  /**
   * 通过 processCode 获取表单 schema 信息
   * 
   * @param request - QuerySchemaByProcessCodeRequest
   * @returns QuerySchemaByProcessCodeResponse
   */
  async querySchemaByProcessCode(request: QuerySchemaByProcessCodeRequest): Promise<QuerySchemaByProcessCodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySchemaByProcessCodeHeaders({ });
    return await this.querySchemaByProcessCodeWithOptions(request, headers, runtime);
  }

  /**
   * 转交OA审批任务
   * 
   * @param request - RedirectWorkflowTaskRequest
   * @param headers - RedirectWorkflowTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RedirectWorkflowTaskResponse
   */
  async redirectWorkflowTaskWithOptions(request: RedirectWorkflowTaskRequest, headers: RedirectWorkflowTaskHeaders, runtime: $Util.RuntimeOptions): Promise<RedirectWorkflowTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionName)) {
      body["actionName"] = request.actionName;
    }

    if (!Util.isUnset(request.file)) {
      body["file"] = request.file;
    }

    if (!Util.isUnset(request.operateUserId)) {
      body["operateUserId"] = request.operateUserId;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
    }

    if (!Util.isUnset(request.toUserId)) {
      body["toUserId"] = request.toUserId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "RedirectWorkflowTask",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/tasks/redirect`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RedirectWorkflowTaskResponse>(await this.execute(params, req, runtime), new RedirectWorkflowTaskResponse({}));
  }

  /**
   * 转交OA审批任务
   * 
   * @param request - RedirectWorkflowTaskRequest
   * @returns RedirectWorkflowTaskResponse
   */
  async redirectWorkflowTask(request: RedirectWorkflowTaskRequest): Promise<RedirectWorkflowTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RedirectWorkflowTaskHeaders({ });
    return await this.redirectWorkflowTaskWithOptions(request, headers, runtime);
  }

  /**
   * 创建实例
   * 
   * @param request - SaveIntegratedInstanceRequest
   * @param headers - SaveIntegratedInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SaveIntegratedInstanceResponse
   */
  async saveIntegratedInstanceWithOptions(request: SaveIntegratedInstanceRequest, headers: SaveIntegratedInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<SaveIntegratedInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizData)) {
      body["bizData"] = request.bizData;
    }

    if (!Util.isUnset(request.featureConfig)) {
      body["featureConfig"] = request.featureConfig;
    }

    if (!Util.isUnset(request.formComponentValueList)) {
      body["formComponentValueList"] = request.formComponentValueList;
    }

    if (!Util.isUnset(request.notifiers)) {
      body["notifiers"] = request.notifiers;
    }

    if (!Util.isUnset(request.originatorUserId)) {
      body["originatorUserId"] = request.originatorUserId;
    }

    if (!Util.isUnset(request.processCode)) {
      body["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.url)) {
      body["url"] = request.url;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "SaveIntegratedInstance",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processCentres/instances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveIntegratedInstanceResponse>(await this.execute(params, req, runtime), new SaveIntegratedInstanceResponse({}));
  }

  /**
   * 创建实例
   * 
   * @param request - SaveIntegratedInstanceRequest
   * @returns SaveIntegratedInstanceResponse
   */
  async saveIntegratedInstance(request: SaveIntegratedInstanceRequest): Promise<SaveIntegratedInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveIntegratedInstanceHeaders({ });
    return await this.saveIntegratedInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 创建或更新审批模板
   * 
   * @param request - SaveProcessRequest
   * @param headers - SaveProcessHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SaveProcessResponse
   */
  async saveProcessWithOptions(request: SaveProcessRequest, headers: SaveProcessHeaders, runtime: $Util.RuntimeOptions): Promise<SaveProcessResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.formComponents)) {
      body["formComponents"] = request.formComponents;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.processCode)) {
      body["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.processFeatureConfig)) {
      body["processFeatureConfig"] = request.processFeatureConfig;
    }

    if (!Util.isUnset(request.templateConfig)) {
      body["templateConfig"] = request.templateConfig;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "SaveProcess",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processCentres/schemas`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveProcessResponse>(await this.execute(params, req, runtime), new SaveProcessResponse({}));
  }

  /**
   * 创建或更新审批模板
   * 
   * @param request - SaveProcessRequest
   * @returns SaveProcessResponse
   */
  async saveProcess(request: SaveProcessRequest): Promise<SaveProcessResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveProcessHeaders({ });
    return await this.saveProcessWithOptions(request, headers, runtime);
  }

  /**
   * 创建审批实例
   * 
   * @param request - StartProcessInstanceRequest
   * @param headers - StartProcessInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns StartProcessInstanceResponse
   */
  async startProcessInstanceWithOptions(request: StartProcessInstanceRequest, headers: StartProcessInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<StartProcessInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.approvers)) {
      body["approvers"] = request.approvers;
    }

    if (!Util.isUnset(request.ccList)) {
      body["ccList"] = request.ccList;
    }

    if (!Util.isUnset(request.ccPosition)) {
      body["ccPosition"] = request.ccPosition;
    }

    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.formComponentValues)) {
      body["formComponentValues"] = request.formComponentValues;
    }

    if (!Util.isUnset(request.microappAgentId)) {
      body["microappAgentId"] = request.microappAgentId;
    }

    if (!Util.isUnset(request.originatorUserId)) {
      body["originatorUserId"] = request.originatorUserId;
    }

    if (!Util.isUnset(request.processCode)) {
      body["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.targetSelectActioners)) {
      body["targetSelectActioners"] = request.targetSelectActioners;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "StartProcessInstance",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processInstances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<StartProcessInstanceResponse>(await this.execute(params, req, runtime), new StartProcessInstanceResponse({}));
  }

  /**
   * 创建审批实例
   * 
   * @param request - StartProcessInstanceRequest
   * @returns StartProcessInstanceResponse
   */
  async startProcessInstance(request: StartProcessInstanceRequest): Promise<StartProcessInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartProcessInstanceHeaders({ });
    return await this.startProcessInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 撤销审批实例
   * 
   * @param request - TerminateProcessInstanceRequest
   * @param headers - TerminateProcessInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TerminateProcessInstanceResponse
   */
  async terminateProcessInstanceWithOptions(request: TerminateProcessInstanceRequest, headers: TerminateProcessInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<TerminateProcessInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isSystem)) {
      body["isSystem"] = request.isSystem;
    }

    if (!Util.isUnset(request.operatingUserId)) {
      body["operatingUserId"] = request.operatingUserId;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "TerminateProcessInstance",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processInstances/terminate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<TerminateProcessInstanceResponse>(await this.execute(params, req, runtime), new TerminateProcessInstanceResponse({}));
  }

  /**
   * 撤销审批实例
   * 
   * @param request - TerminateProcessInstanceRequest
   * @returns TerminateProcessInstanceResponse
   */
  async terminateProcessInstance(request: TerminateProcessInstanceRequest): Promise<TerminateProcessInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TerminateProcessInstanceHeaders({ });
    return await this.terminateProcessInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 流程转交待处理任务查询
   * 
   * @param request - TodoTasksRequest
   * @param headers - TodoTasksHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TodoTasksResponse
   */
  async todoTasksWithOptions(request: TodoTasksRequest, headers: TodoTasksHeaders, runtime: $Util.RuntimeOptions): Promise<TodoTasksResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionerUserId)) {
      query["actionerUserId"] = request.actionerUserId;
    }

    if (!Util.isUnset(request.managerUserId)) {
      query["managerUserId"] = request.managerUserId;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "TodoTasks",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/tasks/todoTasks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<TodoTasksResponse>(await this.execute(params, req, runtime), new TodoTasksResponse({}));
  }

  /**
   * 流程转交待处理任务查询
   * 
   * @param request - TodoTasksRequest
   * @returns TodoTasksResponse
   */
  async todoTasks(request: TodoTasksRequest): Promise<TodoTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TodoTasksHeaders({ });
    return await this.todoTasksWithOptions(request, headers, runtime);
  }

  /**
   * 更新流程中心任务状态
   * 
   * @param request - UpdateIntegratedTaskRequest
   * @param headers - UpdateIntegratedTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateIntegratedTaskResponse
   */
  async updateIntegratedTaskWithOptions(request: UpdateIntegratedTaskRequest, headers: UpdateIntegratedTaskHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateIntegratedTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.tasks)) {
      body["tasks"] = request.tasks;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateIntegratedTask",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processCentres/tasks`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateIntegratedTaskResponse>(await this.execute(params, req, runtime), new UpdateIntegratedTaskResponse({}));
  }

  /**
   * 更新流程中心任务状态
   * 
   * @param request - UpdateIntegratedTaskRequest
   * @returns UpdateIntegratedTaskResponse
   */
  async updateIntegratedTask(request: UpdateIntegratedTaskRequest): Promise<UpdateIntegratedTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateIntegratedTaskHeaders({ });
    return await this.updateIntegratedTaskWithOptions(request, headers, runtime);
  }

  /**
   * 更新实例状态
   * 
   * @param request - UpdateProcessInstanceRequest
   * @param headers - UpdateProcessInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateProcessInstanceResponse
   */
  async updateProcessInstanceWithOptions(request: UpdateProcessInstanceRequest, headers: UpdateProcessInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateProcessInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.notifiers)) {
      body["notifiers"] = request.notifiers;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.result)) {
      body["result"] = request.result;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateProcessInstance",
      version: "workflow_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workflow/processCentres/instances`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateProcessInstanceResponse>(await this.execute(params, req, runtime), new UpdateProcessInstanceResponse({}));
  }

  /**
   * 更新实例状态
   * 
   * @param request - UpdateProcessInstanceRequest
   * @returns UpdateProcessInstanceResponse
   */
  async updateProcessInstance(request: UpdateProcessInstanceRequest): Promise<UpdateProcessInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateProcessInstanceHeaders({ });
    return await this.updateProcessInstanceWithOptions(request, headers, runtime);
  }

}
