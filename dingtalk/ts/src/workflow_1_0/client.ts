// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AvaliableTemplate extends $tea.Model {
  name?: string;
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
  componentType?: string;
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
  addressModel?: string;
  align?: string;
  asyncCondition?: boolean;
  availableTemplates?: AvaliableTemplate[];
  bizAlias?: string;
  bizType?: string;
  choice?: string;
  commonBizType?: string;
  componentId?: string;
  content?: string;
  dataSource?: FormDataSource;
  disabled?: boolean;
  duration?: boolean;
  format?: string;
  formula?: string;
  invisible?: boolean;
  label?: string;
  limit?: number;
  link?: string;
  mode?: string;
  multiple?: boolean;
  options?: SelectOption[];
  placeholder?: string;
  print?: string;
  required?: boolean;
  statField?: FormComponentPropsStatField[];
  tableViewMode?: string;
  unit?: string;
  upper?: string;
  verticalPrint?: boolean;
  static names(): { [key: string]: string } {
    return {
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
      format: 'format',
      formula: 'formula',
      invisible: 'invisible',
      label: 'label',
      limit: 'limit',
      link: 'link',
      mode: 'mode',
      multiple: 'multiple',
      options: 'options',
      placeholder: 'placeholder',
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
      format: 'string',
      formula: 'string',
      invisible: 'boolean',
      label: 'string',
      limit: 'number',
      link: 'string',
      mode: 'string',
      multiple: 'boolean',
      options: { 'type': 'array', 'itemType': SelectOption },
      placeholder: 'string',
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
  target?: FormDataSourceTarget;
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
  key?: string;
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
  description?: string;
  formComponents?: FormComponent[];
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
  headers: { [key: string]: string };
  body: FormCreateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: FormCreateResponseBody,
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
  headers: { [key: string]: string };
  body: GetCrmProcCodesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCrmProcCodesResponseBody,
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
  headers: { [key: string]: string };
  body: GetProcessConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetProcessConfigResponseBody,
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
  durationSeconds?: number;
  spaceId?: string;
  type?: string;
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
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  deptId?: number;
  formComponentValues?: ProcessForecastRequestFormComponentValues[];
  processCode?: string;
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
  headers: { [key: string]: string };
  body: ProcessForecastResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  appUuid?: string;
  formCode?: string;
  maxResults?: number;
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
  headers: { [key: string]: string };
  body: QueryAllFormInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  appUuid?: string;
  endTimeInMills?: number;
  maxResults?: number;
  nextToken?: string;
  processCode?: string;
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
  headers: { [key: string]: string };
  body: QueryAllProcessInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  appUuid?: string;
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
  headers: { [key: string]: string };
  body: QueryFormByBizTypeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  appUuid?: string;
  formCode?: string;
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
  appUuid?: string;
  attributes?: { [key: string]: any };
  createTimestamp?: number;
  creator?: string;
  formCode?: string;
  formInstDataList?: QueryFormInstanceResponseBodyFormInstDataList[];
  formInstanceId?: string;
  modifier?: string;
  modifyTimestamp?: number;
  outBizCode?: string;
  outInstanceId?: string;
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
  headers: { [key: string]: string };
  body: QueryFormInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryFormInstanceResponseBody,
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
  headers: { [key: string]: string };
  body: QuerySchemaByProcessCodeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QuerySchemaByProcessCodeResponseBody,
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
  ccPosition?: string;
  deptId?: number;
  formComponentValues?: StartProcessInstanceRequestFormComponentValues[];
  microappAgentId?: number;
  originatorUserId?: string;
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
  headers: { [key: string]: string };
  body: StartProcessInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: StartProcessInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FormComponentPropsStatField extends $tea.Model {
  componentId?: string;
  label?: string;
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
  appType?: number;
  appUuid?: string;
  bizType?: string;
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

export class FormCreateRequestTemplateConfig extends $tea.Model {
  dirId?: string;
  disableDeleteProcess?: boolean;
  disableFormEdit?: boolean;
  disableHomepage?: boolean;
  disableResubmit?: boolean;
  disableStopProcessButton?: boolean;
  hidden?: boolean;
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

export class GetProcessConfigResponseBodyResultCommentConf extends $tea.Model {
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
  name?: string;
  type?: string;
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
  express?: string;
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
  type?: number;
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
  activityAuth?: string;
  allowRevoke?: boolean;
  appendEnable?: boolean;
  autoExecuteOriginatorTasks?: boolean;
  bizCategoryId?: string;
  bizType?: string;
  commentConf?: GetProcessConfigResponseBodyResultCommentConf;
  duplicateRemoval?: string;
  formSchema?: string;
  handSignConf?: GetProcessConfigResponseBodyResultHandSignConf;
  managers?: string[];
  name?: string;
  processAppType?: boolean;
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

export class ProcessForecastRequestFormComponentValuesDetailsDetails extends $tea.Model {
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

export class ProcessForecastRequestFormComponentValuesDetails extends $tea.Model {
  bizAlias?: string;
  details?: ProcessForecastRequestFormComponentValuesDetailsDetails[];
  extValue?: string;
  id?: string;
  name?: string;
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
  bizAlias?: string;
  componentType?: string;
  details?: ProcessForecastRequestFormComponentValuesDetails[];
  extValue?: string;
  id?: string;
  name?: string;
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
  actorActivateType?: string;
  actorKey?: string;
  actorSelectionRange?: ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange;
  actorSelectionType?: string;
  actorType?: string;
  allowedMulti?: boolean;
  approvalMethod?: string;
  approvalType?: string;
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
  activityId?: string;
  activityName?: string;
  activityType?: string;
  isTargetSelect?: boolean;
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
  activityId?: string;
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
  isForecastSuccess?: boolean;
  isStaticWorkflow?: boolean;
  processCode?: string;
  processId?: number;
  userId?: string;
  workflowActivityRules?: ProcessForecastResponseBodyResultWorkflowActivityRules[];
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
  bizAlias?: string;
  componentType?: string;
  extendValue?: string;
  key?: string;
  label?: string;
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
  appUuid?: string;
  attributes?: { [key: string]: any };
  createTimestamp?: number;
  creator?: string;
  formCode?: string;
  formInstDataList?: QueryAllFormInstancesResponseBodyResultValuesFormInstDataList[];
  formInstanceId?: string;
  modifier?: string;
  modifyTimestamp?: number;
  outBizCode?: string;
  outInstanceId?: string;
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
  hasMore?: boolean;
  maxResults?: number;
  nextToken?: string;
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
  extValue?: string;
  id?: string;
  name?: string;
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
  fileId?: string;
  fileName?: string;
  fileSize?: string;
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
  operationType?: string;
  remark?: string;
  result?: string;
  timestamp?: number;
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
  activityId?: string;
  createTimestamp?: number;
  finishTimestamp?: number;
  result?: string;
  status?: string;
  taskId?: number;
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
  attachedProcessInstanceIds?: string;
  businessId?: string;
  createTime?: number;
  finishTime?: number;
  formComponentValues?: QueryAllProcessInstancesResponseBodyResultListFormComponentValues[];
  mainProcessInstanceId?: string;
  operationRecords?: QueryAllProcessInstancesResponseBodyResultListOperationRecords[];
  originatorDeptId?: string;
  originatorUserid?: string;
  processInstanceId?: string;
  result?: string;
  status?: string;
  tasks?: QueryAllProcessInstancesResponseBodyResultListTasks[];
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
  hasMore?: boolean;
  list?: QueryAllProcessInstancesResponseBodyResultList[];
  maxResults?: number;
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
  appType?: number;
  appUuid?: string;
  bizType?: string;
  content?: string;
  createTime?: number;
  creator?: string;
  formCode?: string;
  formUuid?: string;
  memo?: string;
  modifedTime?: number;
  name?: string;
  ownerId?: string;
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
  bizAlias?: string;
  componentType?: string;
  extendValue?: string;
  key?: string;
  label?: string;
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

export class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps extends $tea.Model {
  bizAlias?: string;
  id?: string;
  label?: string;
  required?: boolean;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      id: 'id',
      label: 'label',
      required: 'required',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      id: 'string',
      label: 'string',
      required: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren extends $tea.Model {
  componentName?: string;
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
  behavior?: string;
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
  attendanceRule?: number;
  pushSwitch?: number;
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
  id?: string;
  label?: string;
  unit?: string;
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
  actionName?: string;
  align?: string;
  appId?: number;
  asyncCondition?: boolean;
  attendTypeLabel?: string;
  behaviorLinkage?: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage[];
  bizAlias?: string;
  bizType?: string;
  childFieldVisible?: boolean;
  choice?: number;
  commonBizType?: string;
  disabled?: boolean;
  duration?: boolean;
  durationLabel?: string;
  eSign?: boolean;
  extract?: boolean;
  fieldsInfo?: string;
  format?: string;
  formula?: string;
  hidden?: boolean;
  hiddenInApprovalDetail?: boolean;
  hideLabel?: boolean;
  holidayOptions?: { [key: string]: string }[];
  id?: string;
  label?: string;
  labelEditableFreeze?: boolean;
  link?: string;
  mainTitle?: string;
  notPrint?: string;
  notUpper?: string;
  objOptions?: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions[];
  options?: string[];
  payEnable?: boolean;
  placeholder?: string;
  push?: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush;
  pushToAttendance?: boolean;
  pushToCalendar?: number;
  required?: boolean;
  requiredEditableFreeze?: boolean;
  showAttendOptions?: boolean;
  staffStatusEnabled?: boolean;
  statField?: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField[];
  unit?: string;
  useCalendar?: boolean;
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
      childFieldVisible: 'boolean',
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
  componentName?: string;
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
  icon?: string;
  items?: QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems[];
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
  appType?: number;
  appUuid?: string;
  bizType?: string;
  creatorUid?: number;
  creatorUserId?: string;
  customSetting?: string;
  engineType?: number;
  formCode?: string;
  formUuid?: string;
  gmtCreate?: string;
  gmtModified?: string;
  icon?: string;
  listOrder?: number;
  memo?: string;
  name?: string;
  ownerId?: string;
  ownerIdType?: string;
  procType?: string;
  schemaContent?: QuerySchemaByProcessCodeResponseBodyResultSchemaContent;
  status?: string;
  visibleRange?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      appUuid: 'appUuid',
      bizType: 'bizType',
      creatorUid: 'creatorUid',
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
      ownerId: 'ownerId',
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
      creatorUid: 'number',
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
      ownerId: 'string',
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

export class StartProcessInstanceRequestApprovers extends $tea.Model {
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

export class StartProcessInstanceRequestFormComponentValuesDetails extends $tea.Model {
  bizAlias?: string;
  details?: StartProcessInstanceRequestFormComponentValuesDetailsDetails[];
  extValue?: string;
  id?: string;
  name?: string;
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
  bizAlias?: string;
  componentType?: string;
  details?: StartProcessInstanceRequestFormComponentValuesDetails[];
  extValue?: string;
  id?: string;
  name?: string;
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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async formCreate(request: FormCreateRequest): Promise<FormCreateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FormCreateHeaders({ });
    return await this.formCreateWithOptions(request, headers, runtime);
  }

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

    if (!Util.isUnset($tea.toMap(request.templateConfig))) {
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
    return $tea.cast<FormCreateResponse>(await this.doROARequest("FormCreate", "workflow_1.0", "HTTP", "POST", "AK", `/v1.0/workflow/forms`, "json", req, runtime), new FormCreateResponse({}));
  }

  async getCrmProcCodes(): Promise<GetCrmProcCodesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCrmProcCodesHeaders({ });
    return await this.getCrmProcCodesWithOptions(headers, runtime);
  }

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
    return $tea.cast<GetCrmProcCodesResponse>(await this.doROARequest("GetCrmProcCodes", "workflow_1.0", "HTTP", "GET", "AK", `/v1.0/workflow/crm/processes`, "json", req, runtime), new GetCrmProcCodesResponse({}));
  }

  async getProcessConfig(request: GetProcessConfigRequest): Promise<GetProcessConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProcessConfigHeaders({ });
    return await this.getProcessConfigWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<GetProcessConfigResponse>(await this.doROARequest("GetProcessConfig", "workflow_1.0", "HTTP", "GET", "AK", `/v1.0/workflow/crm/processes/configurations`, "json", req, runtime), new GetProcessConfigResponse({}));
  }

  async grantCspaceAuthorization(request: GrantCspaceAuthorizationRequest): Promise<GrantCspaceAuthorizationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GrantCspaceAuthorizationHeaders({ });
    return await this.grantCspaceAuthorizationWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<GrantCspaceAuthorizationResponse>(await this.doROARequest("GrantCspaceAuthorization", "workflow_1.0", "HTTP", "POST", "AK", `/v1.0/workflow/spaces/authorize`, "none", req, runtime), new GrantCspaceAuthorizationResponse({}));
  }

  async processForecast(request: ProcessForecastRequest): Promise<ProcessForecastResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ProcessForecastHeaders({ });
    return await this.processForecastWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<ProcessForecastResponse>(await this.doROARequest("ProcessForecast", "workflow_1.0", "HTTP", "POST", "AK", `/v1.0/workflow/processes/forecast`, "json", req, runtime), new ProcessForecastResponse({}));
  }

  async queryAllFormInstances(request: QueryAllFormInstancesRequest): Promise<QueryAllFormInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllFormInstancesHeaders({ });
    return await this.queryAllFormInstancesWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QueryAllFormInstancesResponse>(await this.doROARequest("QueryAllFormInstances", "workflow_1.0", "HTTP", "GET", "AK", `/v1.0/workflow/forms/pages/instances`, "json", req, runtime), new QueryAllFormInstancesResponse({}));
  }

  async queryAllProcessInstances(request: QueryAllProcessInstancesRequest): Promise<QueryAllProcessInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllProcessInstancesHeaders({ });
    return await this.queryAllProcessInstancesWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QueryAllProcessInstancesResponse>(await this.doROARequest("QueryAllProcessInstances", "workflow_1.0", "HTTP", "GET", "AK", `/v1.0/workflow/processes/pages/instances`, "json", req, runtime), new QueryAllProcessInstancesResponse({}));
  }

  async queryFormByBizType(request: QueryFormByBizTypeRequest): Promise<QueryFormByBizTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryFormByBizTypeHeaders({ });
    return await this.queryFormByBizTypeWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QueryFormByBizTypeResponse>(await this.doROARequest("QueryFormByBizType", "workflow_1.0", "HTTP", "POST", "AK", `/v1.0/workflow/forms/forminfos/query`, "json", req, runtime), new QueryFormByBizTypeResponse({}));
  }

  async queryFormInstance(request: QueryFormInstanceRequest): Promise<QueryFormInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryFormInstanceHeaders({ });
    return await this.queryFormInstanceWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QueryFormInstanceResponse>(await this.doROARequest("QueryFormInstance", "workflow_1.0", "HTTP", "GET", "AK", `/v1.0/workflow/forms/instances`, "json", req, runtime), new QueryFormInstanceResponse({}));
  }

  async querySchemaByProcessCode(request: QuerySchemaByProcessCodeRequest): Promise<QuerySchemaByProcessCodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySchemaByProcessCodeHeaders({ });
    return await this.querySchemaByProcessCodeWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QuerySchemaByProcessCodeResponse>(await this.doROARequest("QuerySchemaByProcessCode", "workflow_1.0", "HTTP", "GET", "AK", `/v1.0/workflow/forms/schemas/processCodes`, "json", req, runtime), new QuerySchemaByProcessCodeResponse({}));
  }

  async startProcessInstance(request: StartProcessInstanceRequest): Promise<StartProcessInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartProcessInstanceHeaders({ });
    return await this.startProcessInstanceWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<StartProcessInstanceResponse>(await this.doROARequest("StartProcessInstance", "workflow_1.0", "HTTP", "POST", "AK", `/v1.0/workflow/processInstances`, "json", req, runtime), new StartProcessInstanceResponse({}));
  }

}
