// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CustomizeContactCreateHeaders extends $tea.Model {
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

export class CustomizeContactCreateRequest extends $tea.Model {
  managerIdList?: string[];
  name?: string;
  order?: number;
  static names(): { [key: string]: string } {
    return {
      managerIdList: 'managerIdList',
      name: 'name',
      order: 'order',
    };
  }

  static types(): { [key: string]: any } {
    return {
      managerIdList: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      order: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactCreateResponseBody extends $tea.Model {
  content?: CustomizeContactCreateResponseBodyContent;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: CustomizeContactCreateResponseBodyContent,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactCreateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CustomizeContactCreateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CustomizeContactCreateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeleteHeaders extends $tea.Model {
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

export class CustomizeContactDeleteRequest extends $tea.Model {
  code?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeleteResponseBody extends $tea.Model {
  content?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeleteResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CustomizeContactDeleteResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CustomizeContactDeleteResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptCreateHeaders extends $tea.Model {
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

export class CustomizeContactDeptCreateRequest extends $tea.Model {
  code?: string;
  managerIdList?: string[];
  name?: string;
  order?: number;
  parentDeptId?: number;
  refId?: number;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      managerIdList: 'managerIdList',
      name: 'name',
      order: 'order',
      parentDeptId: 'parentDeptId',
      refId: 'refId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      managerIdList: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      order: 'number',
      parentDeptId: 'number',
      refId: 'number',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptCreateResponseBody extends $tea.Model {
  content?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptCreateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CustomizeContactDeptCreateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CustomizeContactDeptCreateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptDeleteHeaders extends $tea.Model {
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

export class CustomizeContactDeptDeleteRequest extends $tea.Model {
  code?: string;
  deptId?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      deptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptDeleteResponseBody extends $tea.Model {
  content?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptDeleteResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CustomizeContactDeptDeleteResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CustomizeContactDeptDeleteResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptInfoHeaders extends $tea.Model {
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

export class CustomizeContactDeptInfoRequest extends $tea.Model {
  code?: string;
  deptId?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      deptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptInfoResponseBody extends $tea.Model {
  content?: CustomizeContactDeptInfoResponseBodyContent;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: CustomizeContactDeptInfoResponseBodyContent,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CustomizeContactDeptInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CustomizeContactDeptInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptListHeaders extends $tea.Model {
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

export class CustomizeContactDeptListRequest extends $tea.Model {
  code?: string;
  deptId?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      deptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptListResponseBody extends $tea.Model {
  content?: CustomizeContactDeptListResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': CustomizeContactDeptListResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CustomizeContactDeptListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CustomizeContactDeptListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptUpdateHeaders extends $tea.Model {
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

export class CustomizeContactDeptUpdateRequest extends $tea.Model {
  code?: string;
  deptId?: number;
  managerIdList?: string[];
  name?: string;
  order?: number;
  parentDeptId?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      deptId: 'deptId',
      managerIdList: 'managerIdList',
      name: 'name',
      order: 'order',
      parentDeptId: 'parentDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      deptId: 'number',
      managerIdList: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      order: 'number',
      parentDeptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptUpdateResponseBody extends $tea.Model {
  content?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptUpdateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CustomizeContactDeptUpdateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CustomizeContactDeptUpdateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactEmpAddHeaders extends $tea.Model {
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

export class CustomizeContactEmpAddRequest extends $tea.Model {
  code?: string;
  deptId?: number;
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      deptId: 'deptId',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      deptId: 'number',
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactEmpAddResponseBody extends $tea.Model {
  content?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactEmpAddResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CustomizeContactEmpAddResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CustomizeContactEmpAddResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactEmpDeleteHeaders extends $tea.Model {
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

export class CustomizeContactEmpDeleteRequest extends $tea.Model {
  code?: string;
  deptId?: number;
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      deptId: 'deptId',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      deptId: 'number',
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactEmpDeleteResponseBody extends $tea.Model {
  content?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactEmpDeleteResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CustomizeContactEmpDeleteResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CustomizeContactEmpDeleteResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactEmpListHeaders extends $tea.Model {
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

export class CustomizeContactEmpListRequest extends $tea.Model {
  deptId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactEmpListResponseBody extends $tea.Model {
  content?: CustomizeContactEmpListResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': CustomizeContactEmpListResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactEmpListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CustomizeContactEmpListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CustomizeContactEmpListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactListHeaders extends $tea.Model {
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

export class CustomizeContactListResponseBody extends $tea.Model {
  content?: CustomizeContactListResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': CustomizeContactListResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CustomizeContactListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CustomizeContactListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactUpdateHeaders extends $tea.Model {
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

export class CustomizeContactUpdateRequest extends $tea.Model {
  code?: string;
  managerIdList?: string[];
  name?: string;
  order?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      managerIdList: 'managerIdList',
      name: 'name',
      order: 'order',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      managerIdList: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      order: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactUpdateResponseBody extends $tea.Model {
  content?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactUpdateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CustomizeContactUpdateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CustomizeContactUpdateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureCostRecordListGetHeaders extends $tea.Model {
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

export class IndustryManufactureCostRecordListGetRequest extends $tea.Model {
  appId?: number;
  appIds?: number[];
  appName?: string;
  corpId?: string;
  cursor?: number;
  endTime?: number;
  instanceId?: string;
  isvOrgId?: number;
  materialNo?: string;
  microappAgentId?: number;
  orderNo?: string;
  orgId?: number;
  pageNumber?: number;
  pageSize?: number;
  productionTaskNo?: string;
  startTime?: number;
  suiteKey?: string;
  tokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      appIds: 'appIds',
      appName: 'appName',
      corpId: 'corpId',
      cursor: 'cursor',
      endTime: 'endTime',
      instanceId: 'instanceId',
      isvOrgId: 'isvOrgId',
      materialNo: 'materialNo',
      microappAgentId: 'microappAgentId',
      orderNo: 'orderNo',
      orgId: 'orgId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      productionTaskNo: 'productionTaskNo',
      startTime: 'startTime',
      suiteKey: 'suiteKey',
      tokenGrantType: 'tokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'number',
      appIds: { 'type': 'array', 'itemType': 'number' },
      appName: 'string',
      corpId: 'string',
      cursor: 'number',
      endTime: 'number',
      instanceId: 'string',
      isvOrgId: 'number',
      materialNo: 'string',
      microappAgentId: 'number',
      orderNo: 'string',
      orgId: 'number',
      pageNumber: 'number',
      pageSize: 'number',
      productionTaskNo: 'string',
      startTime: 'number',
      suiteKey: 'string',
      tokenGrantType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureCostRecordListGetResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: IndustryManufactureCostRecordListGetResponseBodyList[];
  nextCursor?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextCursor: 'nextCursor',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': IndustryManufactureCostRecordListGetResponseBodyList },
      nextCursor: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureCostRecordListGetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: IndustryManufactureCostRecordListGetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: IndustryManufactureCostRecordListGetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureFeeListGetHeaders extends $tea.Model {
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

export class IndustryManufactureFeeListGetRequest extends $tea.Model {
  appId?: number;
  appIds?: number[];
  appName?: string;
  corpId?: string;
  cursor?: number;
  endTime?: number;
  isvOrgId?: number;
  materialNo?: string;
  microappAgentId?: number;
  orgId?: number;
  pageNumber?: number;
  pageSize?: number;
  productionTaskNo?: string;
  startTime?: number;
  suiteKey?: string;
  tokenGrantType?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      appIds: 'appIds',
      appName: 'appName',
      corpId: 'corpId',
      cursor: 'cursor',
      endTime: 'endTime',
      isvOrgId: 'isvOrgId',
      materialNo: 'materialNo',
      microappAgentId: 'microappAgentId',
      orgId: 'orgId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      productionTaskNo: 'productionTaskNo',
      startTime: 'startTime',
      suiteKey: 'suiteKey',
      tokenGrantType: 'tokenGrantType',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'number',
      appIds: { 'type': 'array', 'itemType': 'number' },
      appName: 'string',
      corpId: 'string',
      cursor: 'number',
      endTime: 'number',
      isvOrgId: 'number',
      materialNo: 'string',
      microappAgentId: 'number',
      orgId: 'number',
      pageNumber: 'number',
      pageSize: 'number',
      productionTaskNo: 'string',
      startTime: 'number',
      suiteKey: 'string',
      tokenGrantType: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureFeeListGetResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: IndustryManufactureFeeListGetResponseBodyList[];
  nextCursor?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextCursor: 'nextCursor',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': IndustryManufactureFeeListGetResponseBodyList },
      nextCursor: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureFeeListGetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: IndustryManufactureFeeListGetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: IndustryManufactureFeeListGetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureLabourCostHeaders extends $tea.Model {
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

export class IndustryManufactureLabourCostRequest extends $tea.Model {
  appId?: number;
  appIds?: number[];
  appName?: string;
  corpId?: string;
  cursor?: number;
  endTime?: number;
  isvOrgId?: string;
  materialNo?: string;
  microappAgentId?: number;
  orgId?: number;
  pageNumber?: number;
  pageSize?: number;
  processNo?: string;
  startTime?: number;
  suiteKey?: string;
  tokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      appIds: 'appIds',
      appName: 'appName',
      corpId: 'corpId',
      cursor: 'cursor',
      endTime: 'endTime',
      isvOrgId: 'isvOrgId',
      materialNo: 'materialNo',
      microappAgentId: 'microappAgentId',
      orgId: 'orgId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      processNo: 'processNo',
      startTime: 'startTime',
      suiteKey: 'suiteKey',
      tokenGrantType: 'tokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'number',
      appIds: { 'type': 'array', 'itemType': 'number' },
      appName: 'string',
      corpId: 'string',
      cursor: 'number',
      endTime: 'number',
      isvOrgId: 'string',
      materialNo: 'string',
      microappAgentId: 'number',
      orgId: 'number',
      pageNumber: 'number',
      pageSize: 'number',
      processNo: 'string',
      startTime: 'number',
      suiteKey: 'string',
      tokenGrantType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureLabourCostResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: IndustryManufactureLabourCostResponseBodyList[];
  nextCursor?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextCursor: 'nextCursor',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': IndustryManufactureLabourCostResponseBodyList },
      nextCursor: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureLabourCostResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: IndustryManufactureLabourCostResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: IndustryManufactureLabourCostResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMaterialListHeaders extends $tea.Model {
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

export class IndustryManufactureMaterialListRequest extends $tea.Model {
  appId?: number;
  appIds?: number[];
  appName?: string;
  corpId?: string;
  currentPage?: number;
  cursor?: number;
  endTime?: number;
  instanceId?: string;
  isvOrgId?: number;
  materialNo?: string;
  microappAgentId?: number;
  orgId?: number;
  pageSize?: number;
  startTime?: number;
  suiteKey?: string;
  tokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      appIds: 'appIds',
      appName: 'appName',
      corpId: 'corpId',
      currentPage: 'currentPage',
      cursor: 'cursor',
      endTime: 'endTime',
      instanceId: 'instanceId',
      isvOrgId: 'isvOrgId',
      materialNo: 'materialNo',
      microappAgentId: 'microappAgentId',
      orgId: 'orgId',
      pageSize: 'pageSize',
      startTime: 'startTime',
      suiteKey: 'suiteKey',
      tokenGrantType: 'tokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'number',
      appIds: { 'type': 'array', 'itemType': 'number' },
      appName: 'string',
      corpId: 'string',
      currentPage: 'number',
      cursor: 'number',
      endTime: 'number',
      instanceId: 'string',
      isvOrgId: 'number',
      materialNo: 'string',
      microappAgentId: 'number',
      orgId: 'number',
      pageSize: 'number',
      startTime: 'number',
      suiteKey: 'string',
      tokenGrantType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMaterialListResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: IndustryManufactureMaterialListResponseBodyList[];
  nextCursor?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextCursor: 'nextCursor',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': IndustryManufactureMaterialListResponseBodyList },
      nextCursor: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMaterialListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: IndustryManufactureMaterialListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: IndustryManufactureMaterialListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryMmanufactureMaterialCostGetHeaders extends $tea.Model {
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

export class IndustryMmanufactureMaterialCostGetRequest extends $tea.Model {
  appId?: number;
  appIds?: number[];
  appName?: string;
  corpId?: string;
  cursor?: number;
  endTime?: number;
  instanceId?: string;
  isvOrgId?: number;
  materialNo?: string;
  microappAgentId?: number;
  orgId?: number;
  pageNumber?: number;
  pageSize?: number;
  startTime?: number;
  suiteKey?: string;
  tokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      appIds: 'appIds',
      appName: 'appName',
      corpId: 'corpId',
      cursor: 'cursor',
      endTime: 'endTime',
      instanceId: 'instanceId',
      isvOrgId: 'isvOrgId',
      materialNo: 'materialNo',
      microappAgentId: 'microappAgentId',
      orgId: 'orgId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      startTime: 'startTime',
      suiteKey: 'suiteKey',
      tokenGrantType: 'tokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'number',
      appIds: { 'type': 'array', 'itemType': 'number' },
      appName: 'string',
      corpId: 'string',
      cursor: 'number',
      endTime: 'number',
      instanceId: 'string',
      isvOrgId: 'number',
      materialNo: 'string',
      microappAgentId: 'number',
      orgId: 'number',
      pageNumber: 'number',
      pageSize: 'number',
      startTime: 'number',
      suiteKey: 'string',
      tokenGrantType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryMmanufactureMaterialCostGetResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: IndustryMmanufactureMaterialCostGetResponseBodyList[];
  nextCursor?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextCursor: 'nextCursor',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': IndustryMmanufactureMaterialCostGetResponseBodyList },
      nextCursor: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryMmanufactureMaterialCostGetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: IndustryMmanufactureMaterialCostGetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: IndustryMmanufactureMaterialCostGetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentHeaders extends $tea.Model {
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

export class QueryAllDepartmentRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBody extends $tea.Model {
  content?: QueryAllDepartmentResponseBodyContent[];
  currentPage?: number;
  totalCount?: number;
  totalPages?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      currentPage: 'currentPage',
      totalCount: 'totalCount',
      totalPages: 'totalPages',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllDepartmentResponseBodyContent },
      currentPage: 'number',
      totalCount: 'number',
      totalPages: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllDepartmentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllDepartmentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDoctorsHeaders extends $tea.Model {
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

export class QueryAllDoctorsRequest extends $tea.Model {
  pageNum?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      pageNum: 'pageNum',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNum: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDoctorsResponseBody extends $tea.Model {
  content?: QueryAllDoctorsResponseBodyContent[];
  currentPage?: number;
  totalCount?: number;
  totalPages?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      currentPage: 'currentPage',
      totalCount: 'totalCount',
      totalPages: 'totalPages',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllDoctorsResponseBodyContent },
      currentPage: 'number',
      totalCount: 'number',
      totalPages: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDoctorsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllDoctorsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllDoctorsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupHeaders extends $tea.Model {
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

export class QueryAllGroupRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupResponseBody extends $tea.Model {
  content?: QueryAllGroupResponseBodyContent[];
  currentPage?: number;
  totalCount?: number;
  totalPages?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      currentPage: 'currentPage',
      totalCount: 'totalCount',
      totalPages: 'totalPages',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllGroupResponseBodyContent },
      currentPage: 'number',
      totalCount: 'number',
      totalPages: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupsInDeptHeaders extends $tea.Model {
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

export class QueryAllGroupsInDeptRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupsInDeptResponseBody extends $tea.Model {
  content?: QueryAllGroupsInDeptResponseBodyContent[];
  currentPage?: number;
  totalCount?: number;
  totalPages?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      currentPage: 'currentPage',
      totalCount: 'totalCount',
      totalPages: 'totalPages',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllGroupsInDeptResponseBodyContent },
      currentPage: 'number',
      totalCount: 'number',
      totalPages: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupsInDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllGroupsInDeptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllGroupsInDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByDeptHeaders extends $tea.Model {
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

export class QueryAllMemberByDeptRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByDeptResponseBody extends $tea.Model {
  content?: QueryAllMemberByDeptResponseBodyContent[];
  currentPage?: number;
  totalCount?: number;
  totalPages?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      currentPage: 'currentPage',
      totalCount: 'totalCount',
      totalPages: 'totalPages',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllMemberByDeptResponseBodyContent },
      currentPage: 'number',
      totalCount: 'number',
      totalPages: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllMemberByDeptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllMemberByDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByGroupHeaders extends $tea.Model {
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

export class QueryAllMemberByGroupRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByGroupResponseBody extends $tea.Model {
  content?: QueryAllMemberByGroupResponseBodyContent[];
  currentPage?: number;
  totalCount?: number;
  totalPages?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      currentPage: 'currentPage',
      totalCount: 'totalCount',
      totalPages: 'totalPages',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllMemberByGroupResponseBodyContent },
      currentPage: 'number',
      totalCount: 'number',
      totalPages: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllMemberByGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllMemberByGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBizOptLogHeaders extends $tea.Model {
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

export class QueryBizOptLogRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBizOptLogResponseBody extends $tea.Model {
  content?: QueryBizOptLogResponseBodyContent[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryBizOptLogResponseBodyContent },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBizOptLogResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryBizOptLogResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryBizOptLogResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoHeaders extends $tea.Model {
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

export class QueryDepartmentInfoResponseBody extends $tea.Model {
  content?: QueryDepartmentInfoResponseBodyContent;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: QueryDepartmentInfoResponseBodyContent,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryDepartmentInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryDepartmentInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoHeaders extends $tea.Model {
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

export class QueryGroupInfoResponseBody extends $tea.Model {
  content?: QueryGroupInfoResponseBodyContent;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: QueryGroupInfoResponseBodyContent,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryGroupInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryGroupInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalDistrictInfoHeaders extends $tea.Model {
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

export class QueryHospitalDistrictInfoRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalDistrictInfoResponseBody extends $tea.Model {
  content?: QueryHospitalDistrictInfoResponseBodyContent[];
  currentPage?: number;
  totalCount?: number;
  totalPages?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      currentPage: 'currentPage',
      totalCount: 'totalCount',
      totalPages: 'totalPages',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryHospitalDistrictInfoResponseBodyContent },
      currentPage: 'number',
      totalCount: 'number',
      totalPages: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalDistrictInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryHospitalDistrictInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryHospitalDistrictInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalRoleUserInfoHeaders extends $tea.Model {
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

export class QueryHospitalRoleUserInfoRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalRoleUserInfoResponseBody extends $tea.Model {
  content?: QueryHospitalRoleUserInfoResponseBodyContent[];
  currentPage?: number;
  totalCount?: number;
  totalPages?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      currentPage: 'currentPage',
      totalCount: 'totalCount',
      totalPages: 'totalPages',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryHospitalRoleUserInfoResponseBodyContent },
      currentPage: 'number',
      totalCount: 'number',
      totalPages: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalRoleUserInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryHospitalRoleUserInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryHospitalRoleUserInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalRolesHeaders extends $tea.Model {
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

export class QueryHospitalRolesResponseBody extends $tea.Model {
  content?: QueryHospitalRolesResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryHospitalRolesResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalRolesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryHospitalRolesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryHospitalRolesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobCodeDictionaryHeaders extends $tea.Model {
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

export class QueryJobCodeDictionaryResponseBody extends $tea.Model {
  content?: QueryJobCodeDictionaryResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryJobCodeDictionaryResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobCodeDictionaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryJobCodeDictionaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryJobCodeDictionaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobStatusCodeDictionaryHeaders extends $tea.Model {
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

export class QueryJobStatusCodeDictionaryResponseBody extends $tea.Model {
  content?: QueryJobStatusCodeDictionaryResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryJobStatusCodeDictionaryResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobStatusCodeDictionaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryJobStatusCodeDictionaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryJobStatusCodeDictionaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMedicalEventsHeaders extends $tea.Model {
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

export class QueryMedicalEventsResponseBody extends $tea.Model {
  content?: QueryMedicalEventsResponseBodyContent[];
  success?: boolean;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      success: 'success',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryMedicalEventsResponseBodyContent },
      success: 'boolean',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMedicalEventsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryMedicalEventsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryMedicalEventsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtInfoHeaders extends $tea.Model {
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

export class QueryUserExtInfoResponseBody extends $tea.Model {
  content?: QueryUserExtInfoResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryUserExtInfoResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUserExtInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUserExtInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtendValuesHeaders extends $tea.Model {
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

export class QueryUserExtendValuesRequest extends $tea.Model {
  userExtendKey?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      userExtendKey: 'userExtendKey',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userExtendKey: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtendValuesResponseBody extends $tea.Model {
  content?: QueryUserExtendValuesResponseBodyContent[];
  success?: boolean;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      success: 'success',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryUserExtendValuesResponseBodyContent },
      success: 'boolean',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtendValuesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUserExtendValuesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUserExtendValuesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoHeaders extends $tea.Model {
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

export class QueryUserInfoResponseBody extends $tea.Model {
  content?: QueryUserInfoResponseBodyContent;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: QueryUserInfoResponseBodyContent,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUserInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUserInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserProbCodeDictionaryHeaders extends $tea.Model {
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

export class QueryUserProbCodeDictionaryResponseBody extends $tea.Model {
  content?: QueryUserProbCodeDictionaryResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryUserProbCodeDictionaryResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserProbCodeDictionaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUserProbCodeDictionaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUserProbCodeDictionaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserRolesHeaders extends $tea.Model {
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

export class QueryUserRolesResponseBody extends $tea.Model {
  content?: QueryUserRolesResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryUserRolesResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserRolesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUserRolesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUserRolesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveUserExtendValuesHeaders extends $tea.Model {
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

export class SaveUserExtendValuesRequest extends $tea.Model {
  userDisplayName?: string;
  userExtendKey?: string;
  userExtendValue?: string;
  static names(): { [key: string]: string } {
    return {
      userDisplayName: 'userDisplayName',
      userExtendKey: 'userExtendKey',
      userExtendValue: 'userExtendValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userDisplayName: 'string',
      userExtendKey: 'string',
      userExtendValue: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveUserExtendValuesResponseBody extends $tea.Model {
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

export class SaveUserExtendValuesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SaveUserExtendValuesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SaveUserExtendValuesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUserExtendInfoHeaders extends $tea.Model {
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

export class UpdateUserExtendInfoRequest extends $tea.Model {
  comments?: string;
  jobCode?: string;
  jobStatusCode?: string[];
  userProbCode?: string;
  static names(): { [key: string]: string } {
    return {
      comments: 'comments',
      jobCode: 'jobCode',
      jobStatusCode: 'jobStatusCode',
      userProbCode: 'userProbCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      comments: 'string',
      jobCode: 'string',
      jobStatusCode: { 'type': 'array', 'itemType': 'string' },
      userProbCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUserExtendInfoResponse extends $tea.Model {
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

export class CustomizeContactCreateResponseBodyContent extends $tea.Model {
  code?: string;
  name?: string;
  order?: number;
  rootDeptId?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
      order: 'order',
      rootDeptId: 'rootDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
      order: 'number',
      rootDeptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptInfoResponseBodyContent extends $tea.Model {
  code?: string;
  id?: number;
  managerIdList?: string[];
  name?: string;
  order?: number;
  parentDeptId?: number;
  refId?: number;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      id: 'id',
      managerIdList: 'managerIdList',
      name: 'name',
      order: 'order',
      parentDeptId: 'parentDeptId',
      refId: 'refId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      id: 'number',
      managerIdList: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      order: 'number',
      parentDeptId: 'number',
      refId: 'number',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptListResponseBodyContent extends $tea.Model {
  code?: string;
  id?: number;
  managerIdList?: string[];
  name?: string;
  order?: number;
  parentDeptId?: number;
  refId?: number;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      id: 'id',
      managerIdList: 'managerIdList',
      name: 'name',
      order: 'order',
      parentDeptId: 'parentDeptId',
      refId: 'refId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      id: 'number',
      managerIdList: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      order: 'number',
      parentDeptId: 'number',
      refId: 'number',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactEmpListResponseBodyContent extends $tea.Model {
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactListResponseBodyContent extends $tea.Model {
  code?: string;
  name?: string;
  order?: number;
  rootDeptId?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
      order: 'order',
      rootDeptId: 'rootDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
      order: 'number',
      rootDeptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureCostRecordListGetResponseBodyList extends $tea.Model {
  corpId?: string;
  count?: number;
  ext?: string;
  gmtCreate?: number;
  gmtModified?: number;
  instanceId?: string;
  isDeleted?: string;
  materialCostRecordNo?: string;
  materialName?: string;
  materialNo?: string;
  memo?: string;
  orderNo?: string;
  price?: number;
  processCode?: string;
  productionTaskNo?: string;
  realCount?: number;
  realPrice?: number;
  type?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      count: 'count',
      ext: 'ext',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      instanceId: 'instanceId',
      isDeleted: 'isDeleted',
      materialCostRecordNo: 'materialCostRecordNo',
      materialName: 'materialName',
      materialNo: 'materialNo',
      memo: 'memo',
      orderNo: 'orderNo',
      price: 'price',
      processCode: 'processCode',
      productionTaskNo: 'productionTaskNo',
      realCount: 'realCount',
      realPrice: 'realPrice',
      type: 'type',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      count: 'number',
      ext: 'string',
      gmtCreate: 'number',
      gmtModified: 'number',
      instanceId: 'string',
      isDeleted: 'string',
      materialCostRecordNo: 'string',
      materialName: 'string',
      materialNo: 'string',
      memo: 'string',
      orderNo: 'string',
      price: 'number',
      processCode: 'string',
      productionTaskNo: 'string',
      realCount: 'number',
      realPrice: 'number',
      type: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureFeeListGetResponseBodyList extends $tea.Model {
  amount?: string;
  corpId?: string;
  count?: number;
  ext?: string;
  gmtCreate?: number;
  gmtModified?: number;
  id?: number;
  instanceId?: string;
  isDeleted?: string;
  materialName?: string;
  materialNo?: string;
  perAmount?: number;
  processCode?: string;
  productionTaskNo?: string;
  title?: string;
  type?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      corpId: 'corpId',
      count: 'count',
      ext: 'ext',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      id: 'id',
      instanceId: 'instanceId',
      isDeleted: 'isDeleted',
      materialName: 'materialName',
      materialNo: 'materialNo',
      perAmount: 'perAmount',
      processCode: 'processCode',
      productionTaskNo: 'productionTaskNo',
      title: 'title',
      type: 'type',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      corpId: 'string',
      count: 'number',
      ext: 'string',
      gmtCreate: 'number',
      gmtModified: 'number',
      id: 'number',
      instanceId: 'string',
      isDeleted: 'string',
      materialName: 'string',
      materialNo: 'string',
      perAmount: 'number',
      processCode: 'string',
      productionTaskNo: 'string',
      title: 'string',
      type: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureLabourCostResponseBodyList extends $tea.Model {
  corpId?: string;
  ext?: string;
  gmtCreate?: number;
  gmtModified?: number;
  instanceId?: string;
  labourCostName?: string;
  labourCostNo?: string;
  materialName?: string;
  materialNo?: string;
  processCode?: string;
  processName?: string;
  processNo?: string;
  qualifiedPrice?: number;
  unQualifiedInfo?: string;
  unQualifiedPrice1?: number;
  unQualifiedPrice2?: number;
  unQualifiedReason1?: string;
  unQualifiedReason2?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      ext: 'ext',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      instanceId: 'instanceId',
      labourCostName: 'labourCostName',
      labourCostNo: 'labourCostNo',
      materialName: 'materialName',
      materialNo: 'materialNo',
      processCode: 'processCode',
      processName: 'processName',
      processNo: 'processNo',
      qualifiedPrice: 'qualifiedPrice',
      unQualifiedInfo: 'unQualifiedInfo',
      unQualifiedPrice1: 'unQualifiedPrice1',
      unQualifiedPrice2: 'unQualifiedPrice2',
      unQualifiedReason1: 'unQualifiedReason1',
      unQualifiedReason2: 'unQualifiedReason2',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      ext: 'string',
      gmtCreate: 'number',
      gmtModified: 'number',
      instanceId: 'string',
      labourCostName: 'string',
      labourCostNo: 'string',
      materialName: 'string',
      materialNo: 'string',
      processCode: 'string',
      processName: 'string',
      processNo: 'string',
      qualifiedPrice: 'number',
      unQualifiedInfo: 'string',
      unQualifiedPrice1: 'number',
      unQualifiedPrice2: 'number',
      unQualifiedReason1: 'string',
      unQualifiedReason2: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMaterialListResponseBodyList extends $tea.Model {
  category?: string;
  corpId?: string;
  ext?: string;
  instanceId?: string;
  materialName?: string;
  materialNo?: string;
  processCode?: string;
  specification?: string;
  stockMaxWarn?: number;
  stockMinWarn?: number;
  type?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      corpId: 'corpId',
      ext: 'ext',
      instanceId: 'instanceId',
      materialName: 'materialName',
      materialNo: 'materialNo',
      processCode: 'processCode',
      specification: 'specification',
      stockMaxWarn: 'stockMaxWarn',
      stockMinWarn: 'stockMinWarn',
      type: 'type',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      corpId: 'string',
      ext: 'string',
      instanceId: 'string',
      materialName: 'string',
      materialNo: 'string',
      processCode: 'string',
      specification: 'string',
      stockMaxWarn: 'number',
      stockMinWarn: 'number',
      type: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryMmanufactureMaterialCostGetResponseBodyList extends $tea.Model {
  actPrice?: number;
  corpId?: string;
  count?: number;
  ext?: string;
  gmtCreate?: number;
  gmtModified?: number;
  instanceId?: string;
  materialCostNo?: string;
  materialName?: string;
  materialNo?: string;
  memo?: string;
  price?: number;
  processCode?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      actPrice: 'actPrice',
      corpId: 'corpId',
      count: 'count',
      ext: 'ext',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      instanceId: 'instanceId',
      materialCostNo: 'materialCostNo',
      materialName: 'materialName',
      materialNo: 'materialNo',
      memo: 'memo',
      price: 'price',
      processCode: 'processCode',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actPrice: 'number',
      corpId: 'string',
      count: 'number',
      ext: 'string',
      gmtCreate: 'number',
      gmtModified: 'number',
      instanceId: 'string',
      materialCostNo: 'string',
      materialName: 'string',
      materialNo: 'string',
      memo: 'string',
      price: 'number',
      processCode: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContentDeptAndExtDepartment extends $tea.Model {
  corpId?: string;
  deptCode?: string;
  deptName?: string;
  deptOrder?: number;
  deptStatus?: number;
  deptType?: number;
  gmtCreateStr?: string;
  gmtModifiedStr?: string;
  id?: number;
  name?: string;
  parentDeptCode?: string;
  remark?: string;
  wardIdList?: number[];
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      deptCode: 'deptCode',
      deptName: 'deptName',
      deptOrder: 'deptOrder',
      deptStatus: 'deptStatus',
      deptType: 'deptType',
      gmtCreateStr: 'gmtCreateStr',
      gmtModifiedStr: 'gmtModifiedStr',
      id: 'id',
      name: 'name',
      parentDeptCode: 'parentDeptCode',
      remark: 'remark',
      wardIdList: 'wardIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      deptCode: 'string',
      deptName: 'string',
      deptOrder: 'number',
      deptStatus: 'number',
      deptType: 'number',
      gmtCreateStr: 'string',
      gmtModifiedStr: 'string',
      id: 'number',
      name: 'string',
      parentDeptCode: 'string',
      remark: 'string',
      wardIdList: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos extends $tea.Model {
  corpId?: string;
  deptCode?: string;
  deptExtendDisplayName?: string;
  deptExtendKey?: string;
  deptExtendValue?: string;
  gmtCreateStr?: string;
  gmtModifiedStr?: string;
  id?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      deptCode: 'deptCode',
      deptExtendDisplayName: 'deptExtendDisplayName',
      deptExtendKey: 'deptExtendKey',
      deptExtendValue: 'deptExtendValue',
      gmtCreateStr: 'gmtCreateStr',
      gmtModifiedStr: 'gmtModifiedStr',
      id: 'id',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      deptCode: 'string',
      deptExtendDisplayName: 'string',
      deptExtendKey: 'string',
      deptExtendValue: 'string',
      gmtCreateStr: 'string',
      gmtModifiedStr: 'string',
      id: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContentDeptAndExt extends $tea.Model {
  department?: QueryAllDepartmentResponseBodyContentDeptAndExtDepartment;
  extendInfos?: QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos[];
  static names(): { [key: string]: string } {
    return {
      department: 'department',
      extendInfos: 'extendInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      department: QueryAllDepartmentResponseBodyContentDeptAndExtDepartment,
      extendInfos: { 'type': 'array', 'itemType': QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos extends $tea.Model {
  corpId?: string;
  deptCode?: string;
  deptExtendDisplayName?: string;
  deptExtendKey?: string;
  deptExtendValue?: string;
  gmtCreateStr?: string;
  gmtModifiedStr?: string;
  id?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      deptCode: 'deptCode',
      deptExtendDisplayName: 'deptExtendDisplayName',
      deptExtendKey: 'deptExtendKey',
      deptExtendValue: 'deptExtendValue',
      gmtCreateStr: 'gmtCreateStr',
      gmtModifiedStr: 'gmtModifiedStr',
      id: 'id',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      deptCode: 'string',
      deptExtendDisplayName: 'string',
      deptExtendKey: 'string',
      deptExtendValue: 'string',
      gmtCreateStr: 'string',
      gmtModifiedStr: 'string',
      id: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader extends $tea.Model {
  jobNumber?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      jobNumber: 'jobNumber',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobNumber: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContentGroupAndExtListGroup extends $tea.Model {
  corpId?: string;
  deptId?: number;
  deptStatus?: number;
  gmtCreateStr?: string;
  gmtModifiedStr?: string;
  id?: number;
  leader?: QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader;
  name?: string;
  parentDeptCode?: string;
  remark?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      deptId: 'deptId',
      deptStatus: 'deptStatus',
      gmtCreateStr: 'gmtCreateStr',
      gmtModifiedStr: 'gmtModifiedStr',
      id: 'id',
      leader: 'leader',
      name: 'name',
      parentDeptCode: 'parentDeptCode',
      remark: 'remark',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      deptId: 'number',
      deptStatus: 'number',
      gmtCreateStr: 'string',
      gmtModifiedStr: 'string',
      id: 'number',
      leader: QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader,
      name: 'string',
      parentDeptCode: 'string',
      remark: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContentGroupAndExtList extends $tea.Model {
  extendInfos?: QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos[];
  group?: QueryAllDepartmentResponseBodyContentGroupAndExtListGroup;
  static names(): { [key: string]: string } {
    return {
      extendInfos: 'extendInfos',
      group: 'group',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extendInfos: { 'type': 'array', 'itemType': QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos },
      group: QueryAllDepartmentResponseBodyContentGroupAndExtListGroup,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContent extends $tea.Model {
  deptAndExt?: QueryAllDepartmentResponseBodyContentDeptAndExt;
  groupAndExtList?: QueryAllDepartmentResponseBodyContentGroupAndExtList[];
  id?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      deptAndExt: 'deptAndExt',
      groupAndExtList: 'groupAndExtList',
      id: 'id',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptAndExt: QueryAllDepartmentResponseBodyContentDeptAndExt,
      groupAndExtList: { 'type': 'array', 'itemType': QueryAllDepartmentResponseBodyContentGroupAndExtList },
      id: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDoctorsResponseBodyContent extends $tea.Model {
  assessGroupId?: string;
  assessGroupName?: string;
  corpId?: string;
  deptCode?: string;
  deptType?: string;
  gmtCreateStr?: string;
  gmtModifiedStr?: string;
  id?: number;
  jobNum?: string;
  status?: number;
  uid?: string;
  userCode?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      assessGroupId: 'assessGroupId',
      assessGroupName: 'assessGroupName',
      corpId: 'corpId',
      deptCode: 'deptCode',
      deptType: 'deptType',
      gmtCreateStr: 'gmtCreateStr',
      gmtModifiedStr: 'gmtModifiedStr',
      id: 'id',
      jobNum: 'jobNum',
      status: 'status',
      uid: 'uid',
      userCode: 'userCode',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assessGroupId: 'string',
      assessGroupName: 'string',
      corpId: 'string',
      deptCode: 'string',
      deptType: 'string',
      gmtCreateStr: 'string',
      gmtModifiedStr: 'string',
      id: 'number',
      jobNum: 'string',
      status: 'number',
      uid: 'string',
      userCode: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupResponseBodyContent extends $tea.Model {
  deptId?: number;
  id?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      id: 'id',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      id: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupsInDeptResponseBodyContent extends $tea.Model {
  deptId?: number;
  id?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      id: 'id',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      id: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByDeptResponseBodyContent extends $tea.Model {
  jobNum?: string;
  uid?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      jobNum: 'jobNum',
      uid: 'uid',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobNum: 'string',
      uid: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByGroupResponseBodyContent extends $tea.Model {
  jobNum?: string;
  uid?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      jobNum: 'jobNum',
      uid: 'uid',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobNum: 'string',
      uid: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBizOptLogResponseBodyContent extends $tea.Model {
  bizType?: number;
  dataType?: number;
  id?: number;
  optAfterData?: string;
  optBeforeData?: string;
  optBizType?: number;
  optExtend?: string;
  optJobNumber?: string;
  optObjectCode?: string;
  optObjectName?: string;
  optObjectUserJobNo?: string;
  optSuccess?: number;
  optTime?: number;
  optType?: number;
  optUserCode?: string;
  optUserName?: string;
  remark?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      dataType: 'dataType',
      id: 'id',
      optAfterData: 'optAfterData',
      optBeforeData: 'optBeforeData',
      optBizType: 'optBizType',
      optExtend: 'optExtend',
      optJobNumber: 'optJobNumber',
      optObjectCode: 'optObjectCode',
      optObjectName: 'optObjectName',
      optObjectUserJobNo: 'optObjectUserJobNo',
      optSuccess: 'optSuccess',
      optTime: 'optTime',
      optType: 'optType',
      optUserCode: 'optUserCode',
      optUserName: 'optUserName',
      remark: 'remark',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'number',
      dataType: 'number',
      id: 'number',
      optAfterData: 'string',
      optBeforeData: 'string',
      optBizType: 'number',
      optExtend: 'string',
      optJobNumber: 'string',
      optObjectCode: 'string',
      optObjectName: 'string',
      optObjectUserJobNo: 'string',
      optSuccess: 'number',
      optTime: 'number',
      optType: 'number',
      optUserCode: 'string',
      optUserName: 'string',
      remark: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponseBodyContentLeaderJob extends $tea.Model {
  bizType?: string;
  category?: string;
  code?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      category: 'category',
      code: 'code',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      category: 'string',
      code: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponseBodyContentLeader extends $tea.Model {
  job?: QueryDepartmentInfoResponseBodyContentLeaderJob;
  jobNumber?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      job: 'job',
      jobNumber: 'jobNumber',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      job: QueryDepartmentInfoResponseBodyContentLeaderJob,
      jobNumber: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponseBodyContentResidentLeaderJob extends $tea.Model {
  bizType?: string;
  category?: string;
  code?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      category: 'category',
      code: 'code',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      category: 'string',
      code: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponseBodyContentResidentLeader extends $tea.Model {
  job?: QueryDepartmentInfoResponseBodyContentResidentLeaderJob;
  jobNumber?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      job: 'job',
      jobNumber: 'jobNumber',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      job: QueryDepartmentInfoResponseBodyContentResidentLeaderJob,
      jobNumber: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponseBodyContent extends $tea.Model {
  id?: number;
  leader?: QueryDepartmentInfoResponseBodyContentLeader;
  name?: string;
  residentLeader?: QueryDepartmentInfoResponseBodyContentResidentLeader;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      leader: 'leader',
      name: 'name',
      residentLeader: 'residentLeader',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      leader: QueryDepartmentInfoResponseBodyContentLeader,
      name: 'string',
      residentLeader: QueryDepartmentInfoResponseBodyContentResidentLeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoResponseBodyContentLeaderJob extends $tea.Model {
  bizType?: string;
  category?: string;
  code?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      category: 'category',
      code: 'code',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      category: 'string',
      code: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoResponseBodyContentLeader extends $tea.Model {
  job?: QueryGroupInfoResponseBodyContentLeaderJob;
  jobNumber?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      job: 'job',
      jobNumber: 'jobNumber',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      job: QueryGroupInfoResponseBodyContentLeaderJob,
      jobNumber: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoResponseBodyContent extends $tea.Model {
  deptId?: number;
  endTime?: number;
  id?: number;
  leader?: QueryGroupInfoResponseBodyContentLeader;
  name?: string;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      endTime: 'endTime',
      id: 'id',
      leader: 'leader',
      name: 'name',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      endTime: 'number',
      id: 'number',
      leader: QueryGroupInfoResponseBodyContentLeader,
      name: 'string',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalDistrictInfoResponseBodyContent extends $tea.Model {
  address?: string;
  deleted?: number;
  districtName?: string;
  districtType?: number;
  gmtCreate?: string;
  gmtModified?: string;
  id?: number;
  parentDistrictId?: number;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      deleted: 'deleted',
      districtName: 'districtName',
      districtType: 'districtType',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      id: 'id',
      parentDistrictId: 'parentDistrictId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      deleted: 'number',
      districtName: 'string',
      districtType: 'number',
      gmtCreate: 'string',
      gmtModified: 'string',
      id: 'number',
      parentDistrictId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalRoleUserInfoResponseBodyContent extends $tea.Model {
  gmtCreate?: string;
  gmtModified?: string;
  jobNumber?: string;
  roleCode?: string;
  roleName?: string;
  userCode?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      jobNumber: 'jobNumber',
      roleCode: 'roleCode',
      roleName: 'roleName',
      userCode: 'userCode',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'string',
      gmtModified: 'string',
      jobNumber: 'string',
      roleCode: 'string',
      roleName: 'string',
      userCode: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalRolesResponseBodyContent extends $tea.Model {
  gmtCreate?: string;
  id?: number;
  isDeleted?: number;
  readOnly?: number;
  remark?: string;
  roleCode?: string;
  roleName?: string;
  sort?: number;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      id: 'id',
      isDeleted: 'isDeleted',
      readOnly: 'readOnly',
      remark: 'remark',
      roleCode: 'roleCode',
      roleName: 'roleName',
      sort: 'sort',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'string',
      id: 'number',
      isDeleted: 'number',
      readOnly: 'number',
      remark: 'string',
      roleCode: 'string',
      roleName: 'string',
      sort: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobCodeDictionaryResponseBodyContent extends $tea.Model {
  category?: string;
  code?: string;
  displayName?: string;
  doctorType?: string;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      code: 'code',
      displayName: 'displayName',
      doctorType: 'doctorType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      code: 'string',
      displayName: 'string',
      doctorType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobStatusCodeDictionaryResponseBodyContent extends $tea.Model {
  category?: string;
  code?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      code: 'code',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      code: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMedicalEventsResponseBodyContent extends $tea.Model {
  code?: string;
  content?: string;
  eventId?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      content: 'content',
      eventId: 'eventId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      content: 'string',
      eventId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtInfoResponseBodyContent extends $tea.Model {
  gmtCreate?: string;
  gmtModified?: string;
  orgId?: string;
  status?: number;
  userCode?: string;
  userExtendDisplayName?: string;
  userExtendKey?: string;
  userExtendValue?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      orgId: 'orgId',
      status: 'status',
      userCode: 'userCode',
      userExtendDisplayName: 'userExtendDisplayName',
      userExtendKey: 'userExtendKey',
      userExtendValue: 'userExtendValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'string',
      gmtModified: 'string',
      orgId: 'string',
      status: 'number',
      userCode: 'string',
      userExtendDisplayName: 'string',
      userExtendKey: 'string',
      userExtendValue: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtendValuesResponseBodyContent extends $tea.Model {
  userCode?: string;
  userExtendDisplayName?: string;
  userExtendKey?: string;
  userExtendValue?: string;
  static names(): { [key: string]: string } {
    return {
      userCode: 'userCode',
      userExtendDisplayName: 'userExtendDisplayName',
      userExtendKey: 'userExtendKey',
      userExtendValue: 'userExtendValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userCode: 'string',
      userExtendDisplayName: 'string',
      userExtendKey: 'string',
      userExtendValue: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponseBodyContentDept extends $tea.Model {
  id?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponseBodyContentGroup extends $tea.Model {
  deptId?: number;
  deptName?: string;
  id?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      deptName: 'deptName',
      id: 'id',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      deptName: 'string',
      id: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponseBodyContentJob extends $tea.Model {
  bizType?: string;
  category?: string;
  code?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      category: 'category',
      code: 'code',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      category: 'string',
      code: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponseBodyContentJobStatus extends $tea.Model {
  bizType?: string;
  category?: string;
  code?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      category: 'category',
      code: 'code',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      category: 'string',
      code: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponseBodyContentJobStatusList extends $tea.Model {
  bizType?: string;
  category?: string;
  code?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      category: 'category',
      code: 'code',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      category: 'string',
      code: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponseBodyContentUserProb extends $tea.Model {
  bizType?: string;
  category?: string;
  code?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      category: 'category',
      code: 'code',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      category: 'string',
      code: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponseBodyContent extends $tea.Model {
  comments?: string;
  dept?: QueryUserInfoResponseBodyContentDept[];
  group?: QueryUserInfoResponseBodyContentGroup[];
  job?: QueryUserInfoResponseBodyContentJob;
  jobNum?: string;
  jobStatus?: QueryUserInfoResponseBodyContentJobStatus;
  jobStatusList?: QueryUserInfoResponseBodyContentJobStatusList[];
  uid?: string;
  userName?: string;
  userProb?: QueryUserInfoResponseBodyContentUserProb;
  static names(): { [key: string]: string } {
    return {
      comments: 'comments',
      dept: 'dept',
      group: 'group',
      job: 'job',
      jobNum: 'jobNum',
      jobStatus: 'jobStatus',
      jobStatusList: 'jobStatusList',
      uid: 'uid',
      userName: 'userName',
      userProb: 'userProb',
    };
  }

  static types(): { [key: string]: any } {
    return {
      comments: 'string',
      dept: { 'type': 'array', 'itemType': QueryUserInfoResponseBodyContentDept },
      group: { 'type': 'array', 'itemType': QueryUserInfoResponseBodyContentGroup },
      job: QueryUserInfoResponseBodyContentJob,
      jobNum: 'string',
      jobStatus: QueryUserInfoResponseBodyContentJobStatus,
      jobStatusList: { 'type': 'array', 'itemType': QueryUserInfoResponseBodyContentJobStatusList },
      uid: 'string',
      userName: 'string',
      userProb: QueryUserInfoResponseBodyContentUserProb,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserProbCodeDictionaryResponseBodyContent extends $tea.Model {
  category?: string;
  code?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      code: 'code',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      code: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserRolesResponseBodyContent extends $tea.Model {
  roleCode?: string;
  roleName?: string;
  static names(): { [key: string]: string } {
    return {
      roleCode: 'roleCode',
      roleName: 'roleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleCode: 'string',
      roleName: 'string',
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


  async customizeContactCreate(request: CustomizeContactCreateRequest): Promise<CustomizeContactCreateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactCreateHeaders({ });
    return await this.customizeContactCreateWithOptions(request, headers, runtime);
  }

  async customizeContactCreateWithOptions(request: CustomizeContactCreateRequest, headers: CustomizeContactCreateHeaders, runtime: $Util.RuntimeOptions): Promise<CustomizeContactCreateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.managerIdList)) {
      body["managerIdList"] = request.managerIdList;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.order)) {
      body["order"] = request.order;
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
    return $tea.cast<CustomizeContactCreateResponse>(await this.doROARequest("CustomizeContactCreate", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/customizations/contacts`, "json", req, runtime), new CustomizeContactCreateResponse({}));
  }

  async customizeContactDelete(request: CustomizeContactDeleteRequest): Promise<CustomizeContactDeleteResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactDeleteHeaders({ });
    return await this.customizeContactDeleteWithOptions(request, headers, runtime);
  }

  async customizeContactDeleteWithOptions(request: CustomizeContactDeleteRequest, headers: CustomizeContactDeleteHeaders, runtime: $Util.RuntimeOptions): Promise<CustomizeContactDeleteResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
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
    return $tea.cast<CustomizeContactDeleteResponse>(await this.doROARequest("CustomizeContactDelete", "industry_1.0", "HTTP", "DELETE", "AK", `/v1.0/industry/customizations/contacts`, "json", req, runtime), new CustomizeContactDeleteResponse({}));
  }

  async customizeContactDeptCreate(request: CustomizeContactDeptCreateRequest): Promise<CustomizeContactDeptCreateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactDeptCreateHeaders({ });
    return await this.customizeContactDeptCreateWithOptions(request, headers, runtime);
  }

  async customizeContactDeptCreateWithOptions(request: CustomizeContactDeptCreateRequest, headers: CustomizeContactDeptCreateHeaders, runtime: $Util.RuntimeOptions): Promise<CustomizeContactDeptCreateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      body["code"] = request.code;
    }

    if (!Util.isUnset(request.managerIdList)) {
      body["managerIdList"] = request.managerIdList;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.order)) {
      body["order"] = request.order;
    }

    if (!Util.isUnset(request.parentDeptId)) {
      body["parentDeptId"] = request.parentDeptId;
    }

    if (!Util.isUnset(request.refId)) {
      body["refId"] = request.refId;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
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
    return $tea.cast<CustomizeContactDeptCreateResponse>(await this.doROARequest("CustomizeContactDeptCreate", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/customizations/departments`, "json", req, runtime), new CustomizeContactDeptCreateResponse({}));
  }

  async customizeContactDeptDelete(request: CustomizeContactDeptDeleteRequest): Promise<CustomizeContactDeptDeleteResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactDeptDeleteHeaders({ });
    return await this.customizeContactDeptDeleteWithOptions(request, headers, runtime);
  }

  async customizeContactDeptDeleteWithOptions(request: CustomizeContactDeptDeleteRequest, headers: CustomizeContactDeptDeleteHeaders, runtime: $Util.RuntimeOptions): Promise<CustomizeContactDeptDeleteResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
    }

    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
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
    return $tea.cast<CustomizeContactDeptDeleteResponse>(await this.doROARequest("CustomizeContactDeptDelete", "industry_1.0", "HTTP", "DELETE", "AK", `/v1.0/industry/customizations/departments`, "json", req, runtime), new CustomizeContactDeptDeleteResponse({}));
  }

  async customizeContactDeptInfo(request: CustomizeContactDeptInfoRequest): Promise<CustomizeContactDeptInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactDeptInfoHeaders({ });
    return await this.customizeContactDeptInfoWithOptions(request, headers, runtime);
  }

  async customizeContactDeptInfoWithOptions(request: CustomizeContactDeptInfoRequest, headers: CustomizeContactDeptInfoHeaders, runtime: $Util.RuntimeOptions): Promise<CustomizeContactDeptInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
    }

    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
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
    return $tea.cast<CustomizeContactDeptInfoResponse>(await this.doROARequest("CustomizeContactDeptInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/customizations/departments`, "json", req, runtime), new CustomizeContactDeptInfoResponse({}));
  }

  async customizeContactDeptList(request: CustomizeContactDeptListRequest): Promise<CustomizeContactDeptListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactDeptListHeaders({ });
    return await this.customizeContactDeptListWithOptions(request, headers, runtime);
  }

  async customizeContactDeptListWithOptions(request: CustomizeContactDeptListRequest, headers: CustomizeContactDeptListHeaders, runtime: $Util.RuntimeOptions): Promise<CustomizeContactDeptListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
    }

    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
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
    return $tea.cast<CustomizeContactDeptListResponse>(await this.doROARequest("CustomizeContactDeptList", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/customizations/subsidiaryDepartments`, "json", req, runtime), new CustomizeContactDeptListResponse({}));
  }

  async customizeContactDeptUpdate(request: CustomizeContactDeptUpdateRequest): Promise<CustomizeContactDeptUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactDeptUpdateHeaders({ });
    return await this.customizeContactDeptUpdateWithOptions(request, headers, runtime);
  }

  async customizeContactDeptUpdateWithOptions(request: CustomizeContactDeptUpdateRequest, headers: CustomizeContactDeptUpdateHeaders, runtime: $Util.RuntimeOptions): Promise<CustomizeContactDeptUpdateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      body["code"] = request.code;
    }

    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.managerIdList)) {
      body["managerIdList"] = request.managerIdList;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.order)) {
      body["order"] = request.order;
    }

    if (!Util.isUnset(request.parentDeptId)) {
      body["parentDeptId"] = request.parentDeptId;
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
    return $tea.cast<CustomizeContactDeptUpdateResponse>(await this.doROARequest("CustomizeContactDeptUpdate", "industry_1.0", "HTTP", "PUT", "AK", `/v1.0/industry/customizations/departments`, "json", req, runtime), new CustomizeContactDeptUpdateResponse({}));
  }

  async customizeContactEmpAdd(request: CustomizeContactEmpAddRequest): Promise<CustomizeContactEmpAddResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactEmpAddHeaders({ });
    return await this.customizeContactEmpAddWithOptions(request, headers, runtime);
  }

  async customizeContactEmpAddWithOptions(request: CustomizeContactEmpAddRequest, headers: CustomizeContactEmpAddHeaders, runtime: $Util.RuntimeOptions): Promise<CustomizeContactEmpAddResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      body["code"] = request.code;
    }

    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
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
    return $tea.cast<CustomizeContactEmpAddResponse>(await this.doROARequest("CustomizeContactEmpAdd", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/customizations/users`, "json", req, runtime), new CustomizeContactEmpAddResponse({}));
  }

  async customizeContactEmpDelete(request: CustomizeContactEmpDeleteRequest): Promise<CustomizeContactEmpDeleteResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactEmpDeleteHeaders({ });
    return await this.customizeContactEmpDeleteWithOptions(request, headers, runtime);
  }

  async customizeContactEmpDeleteWithOptions(request: CustomizeContactEmpDeleteRequest, headers: CustomizeContactEmpDeleteHeaders, runtime: $Util.RuntimeOptions): Promise<CustomizeContactEmpDeleteResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      body["code"] = request.code;
    }

    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
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
    return $tea.cast<CustomizeContactEmpDeleteResponse>(await this.doROARequest("CustomizeContactEmpDelete", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/customizations/users/remove`, "json", req, runtime), new CustomizeContactEmpDeleteResponse({}));
  }

  async customizeContactEmpList(request: CustomizeContactEmpListRequest): Promise<CustomizeContactEmpListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactEmpListHeaders({ });
    return await this.customizeContactEmpListWithOptions(request, headers, runtime);
  }

  async customizeContactEmpListWithOptions(request: CustomizeContactEmpListRequest, headers: CustomizeContactEmpListHeaders, runtime: $Util.RuntimeOptions): Promise<CustomizeContactEmpListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
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
    return $tea.cast<CustomizeContactEmpListResponse>(await this.doROARequest("CustomizeContactEmpList", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/customizations/users`, "json", req, runtime), new CustomizeContactEmpListResponse({}));
  }

  async customizeContactList(): Promise<CustomizeContactListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactListHeaders({ });
    return await this.customizeContactListWithOptions(headers, runtime);
  }

  async customizeContactListWithOptions(headers: CustomizeContactListHeaders, runtime: $Util.RuntimeOptions): Promise<CustomizeContactListResponse> {
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
    return $tea.cast<CustomizeContactListResponse>(await this.doROARequest("CustomizeContactList", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/customizations/contacts`, "json", req, runtime), new CustomizeContactListResponse({}));
  }

  async customizeContactUpdate(request: CustomizeContactUpdateRequest): Promise<CustomizeContactUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactUpdateHeaders({ });
    return await this.customizeContactUpdateWithOptions(request, headers, runtime);
  }

  async customizeContactUpdateWithOptions(request: CustomizeContactUpdateRequest, headers: CustomizeContactUpdateHeaders, runtime: $Util.RuntimeOptions): Promise<CustomizeContactUpdateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      body["code"] = request.code;
    }

    if (!Util.isUnset(request.managerIdList)) {
      body["managerIdList"] = request.managerIdList;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.order)) {
      body["order"] = request.order;
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
    return $tea.cast<CustomizeContactUpdateResponse>(await this.doROARequest("CustomizeContactUpdate", "industry_1.0", "HTTP", "PUT", "AK", `/v1.0/industry/customizations/contacts`, "json", req, runtime), new CustomizeContactUpdateResponse({}));
  }

  async industryManufactureCostRecordListGet(request: IndustryManufactureCostRecordListGetRequest): Promise<IndustryManufactureCostRecordListGetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureCostRecordListGetHeaders({ });
    return await this.industryManufactureCostRecordListGetWithOptions(request, headers, runtime);
  }

  async industryManufactureCostRecordListGetWithOptions(request: IndustryManufactureCostRecordListGetRequest, headers: IndustryManufactureCostRecordListGetHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureCostRecordListGetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.appIds)) {
      body["appIds"] = request.appIds;
    }

    if (!Util.isUnset(request.appName)) {
      body["appName"] = request.appName;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.cursor)) {
      body["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.isvOrgId)) {
      body["isvOrgId"] = request.isvOrgId;
    }

    if (!Util.isUnset(request.materialNo)) {
      body["materialNo"] = request.materialNo;
    }

    if (!Util.isUnset(request.microappAgentId)) {
      body["microappAgentId"] = request.microappAgentId;
    }

    if (!Util.isUnset(request.orderNo)) {
      body["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.orgId)) {
      body["orgId"] = request.orgId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.productionTaskNo)) {
      body["productionTaskNo"] = request.productionTaskNo;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.suiteKey)) {
      body["suiteKey"] = request.suiteKey;
    }

    if (!Util.isUnset(request.tokenGrantType)) {
      body["tokenGrantType"] = request.tokenGrantType;
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
    return $tea.cast<IndustryManufactureCostRecordListGetResponse>(await this.doROARequest("IndustryManufactureCostRecordListGet", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufactures/materialCostRecords/query`, "json", req, runtime), new IndustryManufactureCostRecordListGetResponse({}));
  }

  async industryManufactureFeeListGet(request: IndustryManufactureFeeListGetRequest): Promise<IndustryManufactureFeeListGetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureFeeListGetHeaders({ });
    return await this.industryManufactureFeeListGetWithOptions(request, headers, runtime);
  }

  async industryManufactureFeeListGetWithOptions(request: IndustryManufactureFeeListGetRequest, headers: IndustryManufactureFeeListGetHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureFeeListGetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.appIds)) {
      body["appIds"] = request.appIds;
    }

    if (!Util.isUnset(request.appName)) {
      body["appName"] = request.appName;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.cursor)) {
      body["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.isvOrgId)) {
      body["isvOrgId"] = request.isvOrgId;
    }

    if (!Util.isUnset(request.materialNo)) {
      body["materialNo"] = request.materialNo;
    }

    if (!Util.isUnset(request.microappAgentId)) {
      body["microappAgentId"] = request.microappAgentId;
    }

    if (!Util.isUnset(request.orgId)) {
      body["orgId"] = request.orgId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.productionTaskNo)) {
      body["productionTaskNo"] = request.productionTaskNo;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.suiteKey)) {
      body["suiteKey"] = request.suiteKey;
    }

    if (!Util.isUnset(request.tokenGrantType)) {
      body["tokenGrantType"] = request.tokenGrantType;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
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
    return $tea.cast<IndustryManufactureFeeListGetResponse>(await this.doROARequest("IndustryManufactureFeeListGet", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufactures/fees/query`, "json", req, runtime), new IndustryManufactureFeeListGetResponse({}));
  }

  async industryManufactureLabourCost(request: IndustryManufactureLabourCostRequest): Promise<IndustryManufactureLabourCostResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureLabourCostHeaders({ });
    return await this.industryManufactureLabourCostWithOptions(request, headers, runtime);
  }

  async industryManufactureLabourCostWithOptions(request: IndustryManufactureLabourCostRequest, headers: IndustryManufactureLabourCostHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureLabourCostResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.appIds)) {
      body["appIds"] = request.appIds;
    }

    if (!Util.isUnset(request.appName)) {
      body["appName"] = request.appName;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.cursor)) {
      body["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.isvOrgId)) {
      body["isvOrgId"] = request.isvOrgId;
    }

    if (!Util.isUnset(request.materialNo)) {
      body["materialNo"] = request.materialNo;
    }

    if (!Util.isUnset(request.microappAgentId)) {
      body["microappAgentId"] = request.microappAgentId;
    }

    if (!Util.isUnset(request.orgId)) {
      body["orgId"] = request.orgId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.processNo)) {
      body["processNo"] = request.processNo;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.suiteKey)) {
      body["suiteKey"] = request.suiteKey;
    }

    if (!Util.isUnset(request.tokenGrantType)) {
      body["tokenGrantType"] = request.tokenGrantType;
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
    return $tea.cast<IndustryManufactureLabourCostResponse>(await this.doROARequest("IndustryManufactureLabourCost", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufactures/labourCosts/query`, "json", req, runtime), new IndustryManufactureLabourCostResponse({}));
  }

  async industryManufactureMaterialList(request: IndustryManufactureMaterialListRequest): Promise<IndustryManufactureMaterialListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMaterialListHeaders({ });
    return await this.industryManufactureMaterialListWithOptions(request, headers, runtime);
  }

  async industryManufactureMaterialListWithOptions(request: IndustryManufactureMaterialListRequest, headers: IndustryManufactureMaterialListHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureMaterialListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.appIds)) {
      body["appIds"] = request.appIds;
    }

    if (!Util.isUnset(request.appName)) {
      body["appName"] = request.appName;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.currentPage)) {
      body["currentPage"] = request.currentPage;
    }

    if (!Util.isUnset(request.cursor)) {
      body["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.isvOrgId)) {
      body["isvOrgId"] = request.isvOrgId;
    }

    if (!Util.isUnset(request.materialNo)) {
      body["materialNo"] = request.materialNo;
    }

    if (!Util.isUnset(request.microappAgentId)) {
      body["microappAgentId"] = request.microappAgentId;
    }

    if (!Util.isUnset(request.orgId)) {
      body["orgId"] = request.orgId;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.suiteKey)) {
      body["suiteKey"] = request.suiteKey;
    }

    if (!Util.isUnset(request.tokenGrantType)) {
      body["tokenGrantType"] = request.tokenGrantType;
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
    return $tea.cast<IndustryManufactureMaterialListResponse>(await this.doROARequest("IndustryManufactureMaterialList", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufactures/materials/query`, "json", req, runtime), new IndustryManufactureMaterialListResponse({}));
  }

  async industryMmanufactureMaterialCostGet(request: IndustryMmanufactureMaterialCostGetRequest): Promise<IndustryMmanufactureMaterialCostGetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryMmanufactureMaterialCostGetHeaders({ });
    return await this.industryMmanufactureMaterialCostGetWithOptions(request, headers, runtime);
  }

  async industryMmanufactureMaterialCostGetWithOptions(request: IndustryMmanufactureMaterialCostGetRequest, headers: IndustryMmanufactureMaterialCostGetHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryMmanufactureMaterialCostGetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.appIds)) {
      body["appIds"] = request.appIds;
    }

    if (!Util.isUnset(request.appName)) {
      body["appName"] = request.appName;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.cursor)) {
      body["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.isvOrgId)) {
      body["isvOrgId"] = request.isvOrgId;
    }

    if (!Util.isUnset(request.materialNo)) {
      body["materialNo"] = request.materialNo;
    }

    if (!Util.isUnset(request.microappAgentId)) {
      body["microappAgentId"] = request.microappAgentId;
    }

    if (!Util.isUnset(request.orgId)) {
      body["orgId"] = request.orgId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.suiteKey)) {
      body["suiteKey"] = request.suiteKey;
    }

    if (!Util.isUnset(request.tokenGrantType)) {
      body["tokenGrantType"] = request.tokenGrantType;
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
    return $tea.cast<IndustryMmanufactureMaterialCostGetResponse>(await this.doROARequest("IndustryMmanufactureMaterialCostGet", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufactures/base/materialCosts/query`, "json", req, runtime), new IndustryMmanufactureMaterialCostGetResponse({}));
  }

  async queryAllDepartment(request: QueryAllDepartmentRequest): Promise<QueryAllDepartmentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllDepartmentHeaders({ });
    return await this.queryAllDepartmentWithOptions(request, headers, runtime);
  }

  async queryAllDepartmentWithOptions(request: QueryAllDepartmentRequest, headers: QueryAllDepartmentHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllDepartmentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
    return $tea.cast<QueryAllDepartmentResponse>(await this.doROARequest("QueryAllDepartment", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/departments`, "json", req, runtime), new QueryAllDepartmentResponse({}));
  }

  async queryAllDoctors(request: QueryAllDoctorsRequest): Promise<QueryAllDoctorsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllDoctorsHeaders({ });
    return await this.queryAllDoctorsWithOptions(request, headers, runtime);
  }

  async queryAllDoctorsWithOptions(request: QueryAllDoctorsRequest, headers: QueryAllDoctorsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllDoctorsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNum)) {
      query["pageNum"] = request.pageNum;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
    return $tea.cast<QueryAllDoctorsResponse>(await this.doROARequest("QueryAllDoctors", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/doctors`, "json", req, runtime), new QueryAllDoctorsResponse({}));
  }

  async queryAllGroup(request: QueryAllGroupRequest): Promise<QueryAllGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllGroupHeaders({ });
    return await this.queryAllGroupWithOptions(request, headers, runtime);
  }

  async queryAllGroupWithOptions(request: QueryAllGroupRequest, headers: QueryAllGroupHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
    return $tea.cast<QueryAllGroupResponse>(await this.doROARequest("QueryAllGroup", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/groups`, "json", req, runtime), new QueryAllGroupResponse({}));
  }

  async queryAllGroupsInDept(deptId: string, request: QueryAllGroupsInDeptRequest): Promise<QueryAllGroupsInDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllGroupsInDeptHeaders({ });
    return await this.queryAllGroupsInDeptWithOptions(deptId, request, headers, runtime);
  }

  async queryAllGroupsInDeptWithOptions(deptId: string, request: QueryAllGroupsInDeptRequest, headers: QueryAllGroupsInDeptHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllGroupsInDeptResponse> {
    Util.validateModel(request);
    deptId = OpenApiUtil.getEncodeParam(deptId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
    return $tea.cast<QueryAllGroupsInDeptResponse>(await this.doROARequest("QueryAllGroupsInDept", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/departments/${deptId}/groups`, "json", req, runtime), new QueryAllGroupsInDeptResponse({}));
  }

  async queryAllMemberByDept(deptId: string, request: QueryAllMemberByDeptRequest): Promise<QueryAllMemberByDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllMemberByDeptHeaders({ });
    return await this.queryAllMemberByDeptWithOptions(deptId, request, headers, runtime);
  }

  async queryAllMemberByDeptWithOptions(deptId: string, request: QueryAllMemberByDeptRequest, headers: QueryAllMemberByDeptHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllMemberByDeptResponse> {
    Util.validateModel(request);
    deptId = OpenApiUtil.getEncodeParam(deptId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
    return $tea.cast<QueryAllMemberByDeptResponse>(await this.doROARequest("QueryAllMemberByDept", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/departments/${deptId}/members`, "json", req, runtime), new QueryAllMemberByDeptResponse({}));
  }

  async queryAllMemberByGroup(groupId: string, request: QueryAllMemberByGroupRequest): Promise<QueryAllMemberByGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllMemberByGroupHeaders({ });
    return await this.queryAllMemberByGroupWithOptions(groupId, request, headers, runtime);
  }

  async queryAllMemberByGroupWithOptions(groupId: string, request: QueryAllMemberByGroupRequest, headers: QueryAllMemberByGroupHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllMemberByGroupResponse> {
    Util.validateModel(request);
    groupId = OpenApiUtil.getEncodeParam(groupId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
    return $tea.cast<QueryAllMemberByGroupResponse>(await this.doROARequest("QueryAllMemberByGroup", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/groups/${groupId}/members`, "json", req, runtime), new QueryAllMemberByGroupResponse({}));
  }

  async queryBizOptLog(request: QueryBizOptLogRequest): Promise<QueryBizOptLogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBizOptLogHeaders({ });
    return await this.queryBizOptLogWithOptions(request, headers, runtime);
  }

  async queryBizOptLogWithOptions(request: QueryBizOptLogRequest, headers: QueryBizOptLogHeaders, runtime: $Util.RuntimeOptions): Promise<QueryBizOptLogResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
    return $tea.cast<QueryBizOptLogResponse>(await this.doROARequest("QueryBizOptLog", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/bizOptLogs`, "json", req, runtime), new QueryBizOptLogResponse({}));
  }

  async queryDepartmentInfo(deptId: string): Promise<QueryDepartmentInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDepartmentInfoHeaders({ });
    return await this.queryDepartmentInfoWithOptions(deptId, headers, runtime);
  }

  async queryDepartmentInfoWithOptions(deptId: string, headers: QueryDepartmentInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDepartmentInfoResponse> {
    deptId = OpenApiUtil.getEncodeParam(deptId);
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
    return $tea.cast<QueryDepartmentInfoResponse>(await this.doROARequest("QueryDepartmentInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/departments/${deptId}`, "json", req, runtime), new QueryDepartmentInfoResponse({}));
  }

  async queryGroupInfo(groupId: string): Promise<QueryGroupInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupInfoHeaders({ });
    return await this.queryGroupInfoWithOptions(groupId, headers, runtime);
  }

  async queryGroupInfoWithOptions(groupId: string, headers: QueryGroupInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupInfoResponse> {
    groupId = OpenApiUtil.getEncodeParam(groupId);
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
    return $tea.cast<QueryGroupInfoResponse>(await this.doROARequest("QueryGroupInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/groups/${groupId}`, "json", req, runtime), new QueryGroupInfoResponse({}));
  }

  async queryHospitalDistrictInfo(request: QueryHospitalDistrictInfoRequest): Promise<QueryHospitalDistrictInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHospitalDistrictInfoHeaders({ });
    return await this.queryHospitalDistrictInfoWithOptions(request, headers, runtime);
  }

  async queryHospitalDistrictInfoWithOptions(request: QueryHospitalDistrictInfoRequest, headers: QueryHospitalDistrictInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryHospitalDistrictInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
    return $tea.cast<QueryHospitalDistrictInfoResponse>(await this.doROARequest("QueryHospitalDistrictInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/districts`, "json", req, runtime), new QueryHospitalDistrictInfoResponse({}));
  }

  async queryHospitalRoleUserInfo(request: QueryHospitalRoleUserInfoRequest): Promise<QueryHospitalRoleUserInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHospitalRoleUserInfoHeaders({ });
    return await this.queryHospitalRoleUserInfoWithOptions(request, headers, runtime);
  }

  async queryHospitalRoleUserInfoWithOptions(request: QueryHospitalRoleUserInfoRequest, headers: QueryHospitalRoleUserInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryHospitalRoleUserInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
    return $tea.cast<QueryHospitalRoleUserInfoResponse>(await this.doROARequest("QueryHospitalRoleUserInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/roles/userInfos`, "json", req, runtime), new QueryHospitalRoleUserInfoResponse({}));
  }

  async queryHospitalRoles(): Promise<QueryHospitalRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHospitalRolesHeaders({ });
    return await this.queryHospitalRolesWithOptions(headers, runtime);
  }

  async queryHospitalRolesWithOptions(headers: QueryHospitalRolesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryHospitalRolesResponse> {
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
    return $tea.cast<QueryHospitalRolesResponse>(await this.doROARequest("QueryHospitalRoles", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/roles`, "json", req, runtime), new QueryHospitalRolesResponse({}));
  }

  async queryJobCodeDictionary(): Promise<QueryJobCodeDictionaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryJobCodeDictionaryHeaders({ });
    return await this.queryJobCodeDictionaryWithOptions(headers, runtime);
  }

  async queryJobCodeDictionaryWithOptions(headers: QueryJobCodeDictionaryHeaders, runtime: $Util.RuntimeOptions): Promise<QueryJobCodeDictionaryResponse> {
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
    return $tea.cast<QueryJobCodeDictionaryResponse>(await this.doROARequest("QueryJobCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/jobCodes`, "json", req, runtime), new QueryJobCodeDictionaryResponse({}));
  }

  async queryJobStatusCodeDictionary(): Promise<QueryJobStatusCodeDictionaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryJobStatusCodeDictionaryHeaders({ });
    return await this.queryJobStatusCodeDictionaryWithOptions(headers, runtime);
  }

  async queryJobStatusCodeDictionaryWithOptions(headers: QueryJobStatusCodeDictionaryHeaders, runtime: $Util.RuntimeOptions): Promise<QueryJobStatusCodeDictionaryResponse> {
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
    return $tea.cast<QueryJobStatusCodeDictionaryResponse>(await this.doROARequest("QueryJobStatusCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/jobStatusCodes`, "json", req, runtime), new QueryJobStatusCodeDictionaryResponse({}));
  }

  async queryMedicalEvents(): Promise<QueryMedicalEventsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMedicalEventsHeaders({ });
    return await this.queryMedicalEventsWithOptions(headers, runtime);
  }

  async queryMedicalEventsWithOptions(headers: QueryMedicalEventsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMedicalEventsResponse> {
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
    return $tea.cast<QueryMedicalEventsResponse>(await this.doROARequest("QueryMedicalEvents", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/events`, "json", req, runtime), new QueryMedicalEventsResponse({}));
  }

  async queryUserExtInfo(userId: string): Promise<QueryUserExtInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserExtInfoHeaders({ });
    return await this.queryUserExtInfoWithOptions(userId, headers, runtime);
  }

  async queryUserExtInfoWithOptions(userId: string, headers: QueryUserExtInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserExtInfoResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
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
    return $tea.cast<QueryUserExtInfoResponse>(await this.doROARequest("QueryUserExtInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/users/${userId}/extInfos`, "json", req, runtime), new QueryUserExtInfoResponse({}));
  }

  async queryUserExtendValues(request: QueryUserExtendValuesRequest): Promise<QueryUserExtendValuesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserExtendValuesHeaders({ });
    return await this.queryUserExtendValuesWithOptions(request, headers, runtime);
  }

  async queryUserExtendValuesWithOptions(request: QueryUserExtendValuesRequest, headers: QueryUserExtendValuesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserExtendValuesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userExtendKey)) {
      body["userExtendKey"] = request.userExtendKey;
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
    return $tea.cast<QueryUserExtendValuesResponse>(await this.doROARequest("QueryUserExtendValues", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/medicals/users/extends/query`, "json", req, runtime), new QueryUserExtendValuesResponse({}));
  }

  async queryUserInfo(userId: string): Promise<QueryUserInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserInfoHeaders({ });
    return await this.queryUserInfoWithOptions(userId, headers, runtime);
  }

  async queryUserInfoWithOptions(userId: string, headers: QueryUserInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserInfoResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
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
    return $tea.cast<QueryUserInfoResponse>(await this.doROARequest("QueryUserInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/users/${userId}`, "json", req, runtime), new QueryUserInfoResponse({}));
  }

  async queryUserProbCodeDictionary(): Promise<QueryUserProbCodeDictionaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserProbCodeDictionaryHeaders({ });
    return await this.queryUserProbCodeDictionaryWithOptions(headers, runtime);
  }

  async queryUserProbCodeDictionaryWithOptions(headers: QueryUserProbCodeDictionaryHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserProbCodeDictionaryResponse> {
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
    return $tea.cast<QueryUserProbCodeDictionaryResponse>(await this.doROARequest("QueryUserProbCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/userProbCodes`, "json", req, runtime), new QueryUserProbCodeDictionaryResponse({}));
  }

  async queryUserRoles(userId: string): Promise<QueryUserRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserRolesHeaders({ });
    return await this.queryUserRolesWithOptions(userId, headers, runtime);
  }

  async queryUserRolesWithOptions(userId: string, headers: QueryUserRolesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserRolesResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
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
    return $tea.cast<QueryUserRolesResponse>(await this.doROARequest("QueryUserRoles", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/users/${userId}/roles`, "json", req, runtime), new QueryUserRolesResponse({}));
  }

  async saveUserExtendValues(userId: string, request: SaveUserExtendValuesRequest): Promise<SaveUserExtendValuesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveUserExtendValuesHeaders({ });
    return await this.saveUserExtendValuesWithOptions(userId, request, headers, runtime);
  }

  async saveUserExtendValuesWithOptions(userId: string, request: SaveUserExtendValuesRequest, headers: SaveUserExtendValuesHeaders, runtime: $Util.RuntimeOptions): Promise<SaveUserExtendValuesResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userDisplayName)) {
      query["userDisplayName"] = request.userDisplayName;
    }

    if (!Util.isUnset(request.userExtendKey)) {
      query["userExtendKey"] = request.userExtendKey;
    }

    if (!Util.isUnset(request.userExtendValue)) {
      query["userExtendValue"] = request.userExtendValue;
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
    return $tea.cast<SaveUserExtendValuesResponse>(await this.doROARequest("SaveUserExtendValues", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/medicals/users/${userId}/extends`, "json", req, runtime), new SaveUserExtendValuesResponse({}));
  }

  async updateUserExtendInfo(userId: string, request: UpdateUserExtendInfoRequest): Promise<UpdateUserExtendInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateUserExtendInfoHeaders({ });
    return await this.updateUserExtendInfoWithOptions(userId, request, headers, runtime);
  }

  async updateUserExtendInfoWithOptions(userId: string, request: UpdateUserExtendInfoRequest, headers: UpdateUserExtendInfoHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateUserExtendInfoResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.comments)) {
      body["comments"] = request.comments;
    }

    if (!Util.isUnset(request.jobCode)) {
      body["jobCode"] = request.jobCode;
    }

    if (!Util.isUnset(request.jobStatusCode)) {
      body["jobStatusCode"] = request.jobStatusCode;
    }

    if (!Util.isUnset(request.userProbCode)) {
      body["userProbCode"] = request.userProbCode;
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
    return $tea.cast<UpdateUserExtendInfoResponse>(await this.doROARequest("UpdateUserExtendInfo", "industry_1.0", "HTTP", "PUT", "AK", `/v1.0/industry/medicals/users/${userId}/extInfos`, "none", req, runtime), new UpdateUserExtendInfoResponse({}));
  }

}
