// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import SPI from '@alicloud/gateway-spi';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CampusAddRenterMemberHeaders extends $tea.Model {
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

export class CampusAddRenterMemberRequest extends $tea.Model {
  extend?: string;
  mobile?: string;
  name?: string;
  renterId?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      extend: 'extend',
      mobile: 'mobile',
      name: 'name',
      renterId: 'renterId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extend: 'string',
      mobile: 'string',
      name: 'string',
      renterId: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusAddRenterMemberResponseBody extends $tea.Model {
  unionId?: string;
  userId?: string;
  userState?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      userId: 'userId',
      userState: 'userState',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      userId: 'string',
      userState: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusAddRenterMemberResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusAddRenterMemberResponseBody;
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
      body: CampusAddRenterMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusCreateCampusHeaders extends $tea.Model {
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

export class CampusCreateCampusRequest extends $tea.Model {
  address?: string;
  area?: number;
  belongProjectGroupId?: number;
  campusName?: string;
  capacity?: number;
  cityId?: number;
  country?: string;
  countyId?: number;
  creatorUnionId?: string;
  description?: string;
  extend?: string;
  location?: string;
  orderEndTime?: number;
  orderInfo?: string;
  orderStartTime?: number;
  provId?: number;
  telephone?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      area: 'area',
      belongProjectGroupId: 'belongProjectGroupId',
      campusName: 'campusName',
      capacity: 'capacity',
      cityId: 'cityId',
      country: 'country',
      countyId: 'countyId',
      creatorUnionId: 'creatorUnionId',
      description: 'description',
      extend: 'extend',
      location: 'location',
      orderEndTime: 'orderEndTime',
      orderInfo: 'orderInfo',
      orderStartTime: 'orderStartTime',
      provId: 'provId',
      telephone: 'telephone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      area: 'number',
      belongProjectGroupId: 'number',
      campusName: 'string',
      capacity: 'number',
      cityId: 'number',
      country: 'string',
      countyId: 'number',
      creatorUnionId: 'string',
      description: 'string',
      extend: 'string',
      location: 'string',
      orderEndTime: 'number',
      orderInfo: 'string',
      orderStartTime: 'number',
      provId: 'number',
      telephone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusCreateCampusResponseBody extends $tea.Model {
  campusCorpId?: string;
  campusDeptId?: string;
  static names(): { [key: string]: string } {
    return {
      campusCorpId: 'campusCorpId',
      campusDeptId: 'campusDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      campusCorpId: 'string',
      campusDeptId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusCreateCampusResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusCreateCampusResponseBody;
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
      body: CampusCreateCampusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusCreateCampusGroupHeaders extends $tea.Model {
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

export class CampusCreateCampusGroupRequest extends $tea.Model {
  extend?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      extend: 'extend',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extend: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusCreateCampusGroupResponseBody extends $tea.Model {
  groupId?: number;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusCreateCampusGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusCreateCampusGroupResponseBody;
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
      body: CampusCreateCampusGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusCreateRenterHeaders extends $tea.Model {
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

export class CampusCreateRenterRequest extends $tea.Model {
  creditCode?: string;
  endTime?: number;
  extend?: string;
  name?: string;
  startTime?: number;
  state?: number;
  static names(): { [key: string]: string } {
    return {
      creditCode: 'creditCode',
      endTime: 'endTime',
      extend: 'extend',
      name: 'name',
      startTime: 'startTime',
      state: 'state',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creditCode: 'string',
      endTime: 'number',
      extend: 'string',
      name: 'string',
      startTime: 'number',
      state: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusCreateRenterResponseBody extends $tea.Model {
  renterId?: string;
  static names(): { [key: string]: string } {
    return {
      renterId: 'renterId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      renterId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusCreateRenterResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusCreateRenterResponseBody;
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
      body: CampusCreateRenterResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusDelRenterMemberHeaders extends $tea.Model {
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

export class CampusDelRenterMemberRequest extends $tea.Model {
  renterId?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      renterId: 'renterId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      renterId: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusDelRenterMemberResponseBody extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusDelRenterMemberResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusDelRenterMemberResponseBody;
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
      body: CampusDelRenterMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusDeleteCampusGroupHeaders extends $tea.Model {
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

export class CampusDeleteCampusGroupRequest extends $tea.Model {
  campusProjectGroupId?: number;
  static names(): { [key: string]: string } {
    return {
      campusProjectGroupId: 'campusProjectGroupId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      campusProjectGroupId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusDeleteCampusGroupResponseBody extends $tea.Model {
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

export class CampusDeleteCampusGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusDeleteCampusGroupResponseBody;
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
      body: CampusDeleteCampusGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusDeleteRenterHeaders extends $tea.Model {
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

export class CampusDeleteRenterRequest extends $tea.Model {
  renterId?: number;
  static names(): { [key: string]: string } {
    return {
      renterId: 'renterId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      renterId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusDeleteRenterResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
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

export class CampusGetCampusHeaders extends $tea.Model {
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

export class CampusGetCampusRequest extends $tea.Model {
  campusDeptId?: number;
  static names(): { [key: string]: string } {
    return {
      campusDeptId: 'campusDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      campusDeptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusGetCampusResponseBody extends $tea.Model {
  address?: string;
  area?: number;
  belongProjectGroupId?: string;
  campusCorpId?: string;
  campusDeptId?: number;
  campusName?: string;
  capacity?: string;
  cityId?: number;
  country?: string;
  countyId?: number;
  description?: string;
  extend?: string;
  location?: string;
  orderEndTime?: number;
  orderInfo?: string;
  orderStartTime?: number;
  provId?: number;
  telephone?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      area: 'area',
      belongProjectGroupId: 'belongProjectGroupId',
      campusCorpId: 'campusCorpId',
      campusDeptId: 'campusDeptId',
      campusName: 'campusName',
      capacity: 'capacity',
      cityId: 'cityId',
      country: 'country',
      countyId: 'countyId',
      description: 'description',
      extend: 'extend',
      location: 'location',
      orderEndTime: 'orderEndTime',
      orderInfo: 'orderInfo',
      orderStartTime: 'orderStartTime',
      provId: 'provId',
      telephone: 'telephone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      area: 'number',
      belongProjectGroupId: 'string',
      campusCorpId: 'string',
      campusDeptId: 'number',
      campusName: 'string',
      capacity: 'string',
      cityId: 'number',
      country: 'string',
      countyId: 'number',
      description: 'string',
      extend: 'string',
      location: 'string',
      orderEndTime: 'number',
      orderInfo: 'string',
      orderStartTime: 'number',
      provId: 'number',
      telephone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusGetCampusResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusGetCampusResponseBody;
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
      body: CampusGetCampusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusGetCampusGroupHeaders extends $tea.Model {
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

export class CampusGetCampusGroupRequest extends $tea.Model {
  groupId?: number;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusGetCampusGroupResponseBody extends $tea.Model {
  extend?: string;
  projectGroupName?: string;
  static names(): { [key: string]: string } {
    return {
      extend: 'extend',
      projectGroupName: 'projectGroupName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extend: 'string',
      projectGroupName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusGetCampusGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusGetCampusGroupResponseBody;
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
      body: CampusGetCampusGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusGetRenterHeaders extends $tea.Model {
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

export class CampusGetRenterRequest extends $tea.Model {
  renterId?: number;
  static names(): { [key: string]: string } {
    return {
      renterId: 'renterId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      renterId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusGetRenterResponseBody extends $tea.Model {
  bindRenterCorpId?: string;
  bindTime?: number;
  creditCode?: string;
  endTime?: number;
  extend?: string;
  name?: string;
  renterDeptId?: number;
  startTime?: number;
  state?: number;
  static names(): { [key: string]: string } {
    return {
      bindRenterCorpId: 'bindRenterCorpId',
      bindTime: 'bindTime',
      creditCode: 'creditCode',
      endTime: 'endTime',
      extend: 'extend',
      name: 'name',
      renterDeptId: 'renterDeptId',
      startTime: 'startTime',
      state: 'state',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bindRenterCorpId: 'string',
      bindTime: 'number',
      creditCode: 'string',
      endTime: 'number',
      extend: 'string',
      name: 'string',
      renterDeptId: 'number',
      startTime: 'number',
      state: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusGetRenterResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusGetRenterResponseBody;
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
      body: CampusGetRenterResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusGetRenterMemberHeaders extends $tea.Model {
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

export class CampusGetRenterMemberRequest extends $tea.Model {
  renterId?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      renterId: 'renterId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      renterId: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusGetRenterMemberResponseBody extends $tea.Model {
  extend?: string;
  inviteState?: number;
  name?: string;
  state?: string;
  type?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      extend: 'extend',
      inviteState: 'inviteState',
      name: 'name',
      state: 'state',
      type: 'type',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extend: 'string',
      inviteState: 'number',
      name: 'string',
      state: 'string',
      type: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusGetRenterMemberResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusGetRenterMemberResponseBody;
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
      body: CampusGetRenterMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusListCampusHeaders extends $tea.Model {
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

export class CampusListCampusRequest extends $tea.Model {
  groupDeptId?: number;
  static names(): { [key: string]: string } {
    return {
      groupDeptId: 'groupDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupDeptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusListCampusResponseBody extends $tea.Model {
  result?: CampusListCampusResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': CampusListCampusResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusListCampusResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusListCampusResponseBody;
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
      body: CampusListCampusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusListCampusGroupHeaders extends $tea.Model {
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

export class CampusListCampusGroupResponseBody extends $tea.Model {
  result?: CampusListCampusGroupResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': CampusListCampusGroupResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusListCampusGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusListCampusGroupResponseBody;
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
      body: CampusListCampusGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusListRenterHeaders extends $tea.Model {
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

export class CampusListRenterResponseBody extends $tea.Model {
  result?: CampusListRenterResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': CampusListRenterResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusListRenterResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusListRenterResponseBody;
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
      body: CampusListRenterResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusListRenterMembersHeaders extends $tea.Model {
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

export class CampusListRenterMembersRequest extends $tea.Model {
  renterId?: number;
  static names(): { [key: string]: string } {
    return {
      renterId: 'renterId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      renterId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusListRenterMembersResponseBody extends $tea.Model {
  result?: CampusListRenterMembersResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': CampusListRenterMembersResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusListRenterMembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusListRenterMembersResponseBody;
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
      body: CampusListRenterMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusUpdateCampusHeaders extends $tea.Model {
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

export class CampusUpdateCampusRequest extends $tea.Model {
  address?: string;
  area?: number;
  belongProjectGroupId?: number;
  campusDeptId?: number;
  campusName?: string;
  capacity?: number;
  cityId?: number;
  country?: string;
  countyId?: number;
  description?: string;
  extend?: string;
  orderEndTime?: number;
  orderInfo?: number;
  orderStartTime?: number;
  provId?: number;
  telephone?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      area: 'area',
      belongProjectGroupId: 'belongProjectGroupId',
      campusDeptId: 'campusDeptId',
      campusName: 'campusName',
      capacity: 'capacity',
      cityId: 'cityId',
      country: 'country',
      countyId: 'countyId',
      description: 'description',
      extend: 'extend',
      orderEndTime: 'orderEndTime',
      orderInfo: 'orderInfo',
      orderStartTime: 'orderStartTime',
      provId: 'provId',
      telephone: 'telephone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      area: 'number',
      belongProjectGroupId: 'number',
      campusDeptId: 'number',
      campusName: 'string',
      capacity: 'number',
      cityId: 'number',
      country: 'string',
      countyId: 'number',
      description: 'string',
      extend: 'string',
      orderEndTime: 'number',
      orderInfo: 'number',
      orderStartTime: 'number',
      provId: 'number',
      telephone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusUpdateCampusResponseBody extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusUpdateCampusResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusUpdateCampusResponseBody;
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
      body: CampusUpdateCampusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusUpdateCampusGroupHeaders extends $tea.Model {
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

export class CampusUpdateCampusGroupRequest extends $tea.Model {
  campusProjectGroupId?: number;
  extend?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      campusProjectGroupId: 'campusProjectGroupId',
      extend: 'extend',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      campusProjectGroupId: 'number',
      extend: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusUpdateCampusGroupResponseBody extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusUpdateCampusGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusUpdateCampusGroupResponseBody;
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
      body: CampusUpdateCampusGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusUpdateRenterHeaders extends $tea.Model {
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

export class CampusUpdateRenterRequest extends $tea.Model {
  creditCode?: string;
  endTime?: number;
  extend?: string;
  name?: string;
  renterId?: number;
  startTime?: number;
  state?: number;
  static names(): { [key: string]: string } {
    return {
      creditCode: 'creditCode',
      endTime: 'endTime',
      extend: 'extend',
      name: 'name',
      renterId: 'renterId',
      startTime: 'startTime',
      state: 'state',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creditCode: 'string',
      endTime: 'number',
      extend: 'string',
      name: 'string',
      renterId: 'number',
      startTime: 'number',
      state: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusUpdateRenterResponseBody extends $tea.Model {
  renterId?: string;
  static names(): { [key: string]: string } {
    return {
      renterId: 'renterId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      renterId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusUpdateRenterResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusUpdateRenterResponseBody;
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
      body: CampusUpdateRenterResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusUpdateRenterMemberHeaders extends $tea.Model {
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

export class CampusUpdateRenterMemberRequest extends $tea.Model {
  extend?: string;
  name?: string;
  renterId?: number;
  type?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      extend: 'extend',
      name: 'name',
      renterId: 'renterId',
      type: 'type',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extend: 'string',
      name: 'string',
      renterId: 'number',
      type: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusUpdateRenterMemberResponseBody extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusUpdateRenterMemberResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CampusUpdateRenterMemberResponseBody;
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
      body: CampusUpdateRenterMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeActiveCollegeDeptGroupHeaders extends $tea.Model {
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

export class CollegeActiveCollegeDeptGroupRequest extends $tea.Model {
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

export class CollegeActiveCollegeDeptGroupResponseBody extends $tea.Model {
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeActiveCollegeDeptGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeActiveCollegeDeptGroupResponseBody;
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
      body: CollegeActiveCollegeDeptGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeAddCollegeDeptHeaders extends $tea.Model {
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

export class CollegeAddCollegeDeptRequest extends $tea.Model {
  deptName?: string;
  deptType?: string;
  sortFactor?: number;
  superId?: number;
  static names(): { [key: string]: string } {
    return {
      deptName: 'deptName',
      deptType: 'deptType',
      sortFactor: 'sortFactor',
      superId: 'superId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptName: 'string',
      deptType: 'string',
      sortFactor: 'number',
      superId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeAddCollegeDeptResponseBody extends $tea.Model {
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

export class CollegeAddCollegeDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeAddCollegeDeptResponseBody;
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
      body: CollegeAddCollegeDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeAddManagerHeaders extends $tea.Model {
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

export class CollegeAddManagerRequest extends $tea.Model {
  deptId?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeAddManagerResponseBody extends $tea.Model {
  isSuccessful?: boolean;
  static names(): { [key: string]: string } {
    return {
      isSuccessful: 'isSuccessful',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isSuccessful: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeAddManagerResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeAddManagerResponseBody;
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
      body: CollegeAddManagerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeAddStudentHeaders extends $tea.Model {
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

export class CollegeAddStudentRequest extends $tea.Model {
  deptId?: number;
  empExtension?: { [key: string]: string };
  gender?: string;
  identifyId?: string;
  mobile?: string;
  startYear?: string;
  studentName?: string;
  studentNumber?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      empExtension: 'empExtension',
      gender: 'gender',
      identifyId: 'identifyId',
      mobile: 'mobile',
      startYear: 'startYear',
      studentName: 'studentName',
      studentNumber: 'studentNumber',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      empExtension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      gender: 'string',
      identifyId: 'string',
      mobile: 'string',
      startYear: 'string',
      studentName: 'string',
      studentNumber: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeAddStudentResponseBody extends $tea.Model {
  dingMemberStatus?: string;
  isActive?: boolean;
  studentId?: number;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dingMemberStatus: 'dingMemberStatus',
      isActive: 'isActive',
      studentId: 'studentId',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingMemberStatus: 'string',
      isActive: 'boolean',
      studentId: 'number',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeAddStudentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeAddStudentResponseBody;
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
      body: CollegeAddStudentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeChangeStudentDeptHeaders extends $tea.Model {
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

export class CollegeChangeStudentDeptRequest extends $tea.Model {
  deptId?: number;
  newDeptId?: number;
  studentId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      newDeptId: 'newDeptId',
      studentId: 'studentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      newDeptId: 'number',
      studentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeChangeStudentDeptResponseBody extends $tea.Model {
  isSuccessful?: boolean;
  static names(): { [key: string]: string } {
    return {
      isSuccessful: 'isSuccessful',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isSuccessful: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeChangeStudentDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeChangeStudentDeptResponseBody;
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
      body: CollegeChangeStudentDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeDeleteCollegeDeptHeaders extends $tea.Model {
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

export class CollegeDeleteCollegeDeptRequest extends $tea.Model {
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

export class CollegeDeleteCollegeDeptResponseBody extends $tea.Model {
  isSuccessful?: boolean;
  static names(): { [key: string]: string } {
    return {
      isSuccessful: 'isSuccessful',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isSuccessful: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeDeleteCollegeDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeDeleteCollegeDeptResponseBody;
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
      body: CollegeDeleteCollegeDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeListCollegeSubDeptHeaders extends $tea.Model {
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

export class CollegeListCollegeSubDeptRequest extends $tea.Model {
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

export class CollegeListCollegeSubDeptResponseBody extends $tea.Model {
  collegeDeptInfoSimpleList?: CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList[];
  static names(): { [key: string]: string } {
    return {
      collegeDeptInfoSimpleList: 'collegeDeptInfoSimpleList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      collegeDeptInfoSimpleList: { 'type': 'array', 'itemType': CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeListCollegeSubDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeListCollegeSubDeptResponseBody;
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
      body: CollegeListCollegeSubDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeListDeptManagerHeaders extends $tea.Model {
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

export class CollegeListDeptManagerRequest extends $tea.Model {
  deptId?: number;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeListDeptManagerResponseBody extends $tea.Model {
  managerInfoSimpleList?: CollegeListDeptManagerResponseBodyManagerInfoSimpleList[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      managerInfoSimpleList: 'managerInfoSimpleList',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      managerInfoSimpleList: { 'type': 'array', 'itemType': CollegeListDeptManagerResponseBodyManagerInfoSimpleList },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeListDeptManagerResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeListDeptManagerResponseBody;
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
      body: CollegeListDeptManagerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeListStudentInfoHeaders extends $tea.Model {
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

export class CollegeListStudentInfoRequest extends $tea.Model {
  deptId?: number;
  dingStudentStatus?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      dingStudentStatus: 'dingStudentStatus',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      dingStudentStatus: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeListStudentInfoResponseBody extends $tea.Model {
  studentInfoSimpleList?: CollegeListStudentInfoResponseBodyStudentInfoSimpleList[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      studentInfoSimpleList: 'studentInfoSimpleList',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      studentInfoSimpleList: { 'type': 'array', 'itemType': CollegeListStudentInfoResponseBodyStudentInfoSimpleList },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeListStudentInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeListStudentInfoResponseBody;
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
      body: CollegeListStudentInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeListUncheckedStudentHeaders extends $tea.Model {
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

export class CollegeListUncheckedStudentRequest extends $tea.Model {
  deptId?: number;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeListUncheckedStudentResponseBody extends $tea.Model {
  studentInfoSimpleList?: CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      studentInfoSimpleList: 'studentInfoSimpleList',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      studentInfoSimpleList: { 'type': 'array', 'itemType': CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeListUncheckedStudentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeListUncheckedStudentResponseBody;
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
      body: CollegeListUncheckedStudentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeQueryCollegeDeptGroupInfoHeaders extends $tea.Model {
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

export class CollegeQueryCollegeDeptGroupInfoRequest extends $tea.Model {
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

export class CollegeQueryCollegeDeptGroupInfoResponseBody extends $tea.Model {
  groupName?: string;
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      groupName: 'groupName',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupName: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeQueryCollegeDeptGroupInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeQueryCollegeDeptGroupInfoResponseBody;
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
      body: CollegeQueryCollegeDeptGroupInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeQueryCollegeDeptInfoHeaders extends $tea.Model {
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

export class CollegeQueryCollegeDeptInfoRequest extends $tea.Model {
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

export class CollegeQueryCollegeDeptInfoResponseBody extends $tea.Model {
  deptId?: number;
  deptName?: string;
  deptType?: string;
  sortFactor?: number;
  superId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      deptName: 'deptName',
      deptType: 'deptType',
      sortFactor: 'sortFactor',
      superId: 'superId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      deptName: 'string',
      deptType: 'string',
      sortFactor: 'number',
      superId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeQueryCollegeDeptInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeQueryCollegeDeptInfoResponseBody;
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
      body: CollegeQueryCollegeDeptInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeQueryStudentInfoByDeptHeaders extends $tea.Model {
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

export class CollegeQueryStudentInfoByDeptRequest extends $tea.Model {
  deptId?: number;
  studentId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      studentId: 'studentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      studentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeQueryStudentInfoByDeptResponseBody extends $tea.Model {
  deptId?: number;
  dingMemberStatus?: string;
  empExtension?: { [key: string]: any };
  gender?: string;
  identifyId?: string;
  isActive?: boolean;
  startYear?: string;
  studentId?: number;
  studentName?: string;
  studentNumber?: string;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      dingMemberStatus: 'dingMemberStatus',
      empExtension: 'empExtension',
      gender: 'gender',
      identifyId: 'identifyId',
      isActive: 'isActive',
      startYear: 'startYear',
      studentId: 'studentId',
      studentName: 'studentName',
      studentNumber: 'studentNumber',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      dingMemberStatus: 'string',
      empExtension: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      gender: 'string',
      identifyId: 'string',
      isActive: 'boolean',
      startYear: 'string',
      studentId: 'number',
      studentName: 'string',
      studentNumber: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeQueryStudentInfoByDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeQueryStudentInfoByDeptResponseBody;
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
      body: CollegeQueryStudentInfoByDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeQueryStudentInfoByMobileHeaders extends $tea.Model {
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

export class CollegeQueryStudentInfoByMobileRequest extends $tea.Model {
  mobile?: string;
  static names(): { [key: string]: string } {
    return {
      mobile: 'mobile',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobile: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeQueryStudentInfoByMobileResponseBody extends $tea.Model {
  deptStudentInfoList?: CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList[];
  dingMemberStatus?: string;
  empExtension?: { [key: string]: any };
  gender?: string;
  identifyId?: string;
  isActive?: boolean;
  startYear?: string;
  studentId?: number;
  studentName?: string;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptStudentInfoList: 'deptStudentInfoList',
      dingMemberStatus: 'dingMemberStatus',
      empExtension: 'empExtension',
      gender: 'gender',
      identifyId: 'identifyId',
      isActive: 'isActive',
      startYear: 'startYear',
      studentId: 'studentId',
      studentName: 'studentName',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptStudentInfoList: { 'type': 'array', 'itemType': CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList },
      dingMemberStatus: 'string',
      empExtension: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      gender: 'string',
      identifyId: 'string',
      isActive: 'boolean',
      startYear: 'string',
      studentId: 'number',
      studentName: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeQueryStudentInfoByMobileResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeQueryStudentInfoByMobileResponseBody;
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
      body: CollegeQueryStudentInfoByMobileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeQueryStudentInfoByStudentIdHeaders extends $tea.Model {
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

export class CollegeQueryStudentInfoByStudentIdRequest extends $tea.Model {
  studentId?: number;
  static names(): { [key: string]: string } {
    return {
      studentId: 'studentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      studentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeQueryStudentInfoByStudentIdResponseBody extends $tea.Model {
  deptStudentInfoList?: CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList[];
  dingMemberStatus?: string;
  empExtension?: { [key: string]: any };
  gender?: string;
  identifyId?: string;
  isActive?: boolean;
  startYear?: string;
  studentId?: number;
  studentName?: string;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptStudentInfoList: 'deptStudentInfoList',
      dingMemberStatus: 'dingMemberStatus',
      empExtension: 'empExtension',
      gender: 'gender',
      identifyId: 'identifyId',
      isActive: 'isActive',
      startYear: 'startYear',
      studentId: 'studentId',
      studentName: 'studentName',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptStudentInfoList: { 'type': 'array', 'itemType': CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList },
      dingMemberStatus: 'string',
      empExtension: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      gender: 'string',
      identifyId: 'string',
      isActive: 'boolean',
      startYear: 'string',
      studentId: 'number',
      studentName: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeQueryStudentInfoByStudentIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeQueryStudentInfoByStudentIdResponseBody;
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
      body: CollegeQueryStudentInfoByStudentIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeRemoveManagerHeaders extends $tea.Model {
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

export class CollegeRemoveManagerRequest extends $tea.Model {
  deptId?: number;
  isForce?: boolean;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      isForce: 'isForce',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      isForce: 'boolean',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeRemoveManagerResponseBody extends $tea.Model {
  isSuccessful?: boolean;
  static names(): { [key: string]: string } {
    return {
      isSuccessful: 'isSuccessful',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isSuccessful: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeRemoveManagerResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeRemoveManagerResponseBody;
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
      body: CollegeRemoveManagerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeRemoveStudentHeaders extends $tea.Model {
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

export class CollegeRemoveStudentRequest extends $tea.Model {
  deptId?: number;
  studentId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      studentId: 'studentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      studentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeRemoveStudentResponseBody extends $tea.Model {
  isSuccessful?: boolean;
  static names(): { [key: string]: string } {
    return {
      isSuccessful: 'isSuccessful',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isSuccessful: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeRemoveStudentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeRemoveStudentResponseBody;
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
      body: CollegeRemoveStudentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeUpdateCollegeDeptHeaders extends $tea.Model {
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

export class CollegeUpdateCollegeDeptRequest extends $tea.Model {
  deptId?: number;
  deptName?: string;
  sortFactor?: number;
  superId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      deptName: 'deptName',
      sortFactor: 'sortFactor',
      superId: 'superId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      deptName: 'string',
      sortFactor: 'number',
      superId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeUpdateCollegeDeptResponseBody extends $tea.Model {
  isSuccessful?: boolean;
  static names(): { [key: string]: string } {
    return {
      isSuccessful: 'isSuccessful',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isSuccessful: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeUpdateCollegeDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeUpdateCollegeDeptResponseBody;
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
      body: CollegeUpdateCollegeDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeUpdateStudentDeptInfoHeaders extends $tea.Model {
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

export class CollegeUpdateStudentDeptInfoRequest extends $tea.Model {
  deptId?: number;
  studentId?: number;
  studentNumber?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      studentId: 'studentId',
      studentNumber: 'studentNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      studentId: 'number',
      studentNumber: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeUpdateStudentDeptInfoResponseBody extends $tea.Model {
  isSuccessful?: boolean;
  static names(): { [key: string]: string } {
    return {
      isSuccessful: 'isSuccessful',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isSuccessful: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeUpdateStudentDeptInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeUpdateStudentDeptInfoResponseBody;
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
      body: CollegeUpdateStudentDeptInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeUpdateStudentInfoHeaders extends $tea.Model {
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

export class CollegeUpdateStudentInfoRequest extends $tea.Model {
  empExtension?: { [key: string]: string };
  gender?: string;
  identifyId?: string;
  startYear?: string;
  studentId?: number;
  studentName?: string;
  static names(): { [key: string]: string } {
    return {
      empExtension: 'empExtension',
      gender: 'gender',
      identifyId: 'identifyId',
      startYear: 'startYear',
      studentId: 'studentId',
      studentName: 'studentName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      empExtension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      gender: 'string',
      identifyId: 'string',
      startYear: 'string',
      studentId: 'number',
      studentName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeUpdateStudentInfoResponseBody extends $tea.Model {
  isSuccessful?: boolean;
  static names(): { [key: string]: string } {
    return {
      isSuccessful: 'isSuccessful',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isSuccessful: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeUpdateStudentInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeUpdateStudentInfoResponseBody;
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
      body: CollegeUpdateStudentInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeUpdateStudentMoblieHeaders extends $tea.Model {
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

export class CollegeUpdateStudentMoblieRequest extends $tea.Model {
  isForce?: boolean;
  newMobile?: string;
  studentId?: number;
  static names(): { [key: string]: string } {
    return {
      isForce: 'isForce',
      newMobile: 'newMobile',
      studentId: 'studentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isForce: 'boolean',
      newMobile: 'string',
      studentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeUpdateStudentMoblieResponseBody extends $tea.Model {
  updateResult?: string;
  static names(): { [key: string]: string } {
    return {
      updateResult: 'updateResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      updateResult: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeUpdateStudentMoblieResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollegeUpdateStudentMoblieResponseBody;
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
      body: CollegeUpdateStudentMoblieResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  statusCode: number;
  body: CustomizeContactCreateResponseBody;
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
  statusCode: number;
  body: CustomizeContactDeleteResponseBody;
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
  statusCode: number;
  body: CustomizeContactDeptCreateResponseBody;
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
  statusCode: number;
  body: CustomizeContactDeptDeleteResponseBody;
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
      body: CustomizeContactDeptDeleteResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptGroupCreateHeaders extends $tea.Model {
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

export class CustomizeContactDeptGroupCreateRequest extends $tea.Model {
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

export class CustomizeContactDeptGroupCreateResponseBody extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomizeContactDeptGroupCreateResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CustomizeContactDeptGroupCreateResponseBody;
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
      body: CustomizeContactDeptGroupCreateResponseBody,
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
  statusCode: number;
  body: CustomizeContactDeptInfoResponseBody;
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
  statusCode: number;
  body: CustomizeContactDeptListResponseBody;
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
  statusCode: number;
  body: CustomizeContactDeptUpdateResponseBody;
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
  statusCode: number;
  body: CustomizeContactEmpAddResponseBody;
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
  statusCode: number;
  body: CustomizeContactEmpDeleteResponseBody;
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
  statusCode: number;
  body: CustomizeContactEmpListResponseBody;
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
  statusCode: number;
  body: CustomizeContactListResponseBody;
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
  statusCode: number;
  body: CustomizeContactUpdateResponseBody;
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
      body: CustomizeContactUpdateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DIgitalStoreMessagePushHeaders extends $tea.Model {
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

export class DIgitalStoreMessagePushRequest extends $tea.Model {
  messageDataList?: DIgitalStoreMessagePushRequestMessageDataList[];
  static names(): { [key: string]: string } {
    return {
      messageDataList: 'messageDataList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageDataList: { 'type': 'array', 'itemType': DIgitalStoreMessagePushRequestMessageDataList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DIgitalStoreMessagePushShrinkRequest extends $tea.Model {
  messageDataListShrink?: string;
  static names(): { [key: string]: string } {
    return {
      messageDataListShrink: 'messageDataList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageDataListShrink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DIgitalStoreMessagePushResponseBody extends $tea.Model {
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

export class DIgitalStoreMessagePushResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DIgitalStoreMessagePushResponseBody;
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
      body: DIgitalStoreMessagePushResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreCardRecordHeaders extends $tea.Model {
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

export class DigitalStoreCardRecordRequest extends $tea.Model {
  beginTime?: number;
  endTime?: number;
  ids?: number[];
  pageNumber?: number;
  pageSize?: number;
  sceneCardName?: string;
  static names(): { [key: string]: string } {
    return {
      beginTime: 'beginTime',
      endTime: 'endTime',
      ids: 'ids',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      sceneCardName: 'sceneCardName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      beginTime: 'number',
      endTime: 'number',
      ids: { 'type': 'array', 'itemType': 'number' },
      pageNumber: 'number',
      pageSize: 'number',
      sceneCardName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreCardRecordResponseBody extends $tea.Model {
  content?: DigitalStoreCardRecordResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': DigitalStoreCardRecordResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreCardRecordResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStoreCardRecordResponseBody;
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
      body: DigitalStoreCardRecordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreContactInfoHeaders extends $tea.Model {
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

export class DigitalStoreContactInfoResponseBody extends $tea.Model {
  code?: string;
  dingDeptId?: number;
  name?: string;
  rootDeptId?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      dingDeptId: 'dingDeptId',
      name: 'name',
      rootDeptId: 'rootDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      dingDeptId: 'number',
      name: 'string',
      rootDeptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreContactInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStoreContactInfoResponseBody;
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
      body: DigitalStoreContactInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreConversationsHeaders extends $tea.Model {
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

export class DigitalStoreConversationsRequest extends $tea.Model {
  conversationTitle?: string;
  conversationType?: string;
  static names(): { [key: string]: string } {
    return {
      conversationTitle: 'conversationTitle',
      conversationType: 'conversationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationTitle: 'string',
      conversationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreConversationsResponseBody extends $tea.Model {
  content?: DigitalStoreConversationsResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': DigitalStoreConversationsResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreConversationsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStoreConversationsResponseBody;
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
      body: DigitalStoreConversationsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreExportCardRecordHeaders extends $tea.Model {
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

export class DigitalStoreExportCardRecordRequest extends $tea.Model {
  beginTime?: number;
  endTime?: number;
  ids?: number[];
  sceneCardName?: string;
  static names(): { [key: string]: string } {
    return {
      beginTime: 'beginTime',
      endTime: 'endTime',
      ids: 'ids',
      sceneCardName: 'sceneCardName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      beginTime: 'number',
      endTime: 'number',
      ids: { 'type': 'array', 'itemType': 'number' },
      sceneCardName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreExportCardRecordResponseBody extends $tea.Model {
  fileName?: string;
  fileType?: string;
  fileUrl?: string;
  id?: string;
  isImport?: string;
  remark?: string;
  status?: string;
  successNum?: string;
  totalNum?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      fileType: 'fileType',
      fileUrl: 'fileUrl',
      id: 'id',
      isImport: 'isImport',
      remark: 'remark',
      status: 'status',
      successNum: 'successNum',
      totalNum: 'totalNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      fileType: 'string',
      fileUrl: 'string',
      id: 'string',
      isImport: 'string',
      remark: 'string',
      status: 'string',
      successNum: 'string',
      totalNum: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreExportCardRecordResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStoreExportCardRecordResponseBody;
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
      body: DigitalStoreExportCardRecordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreExportCardRecordDetailHeaders extends $tea.Model {
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

export class DigitalStoreExportCardRecordDetailRequest extends $tea.Model {
  beginTime?: number;
  endTime?: number;
  ids?: number[];
  sceneCardName?: string;
  static names(): { [key: string]: string } {
    return {
      beginTime: 'beginTime',
      endTime: 'endTime',
      ids: 'ids',
      sceneCardName: 'sceneCardName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      beginTime: 'number',
      endTime: 'number',
      ids: { 'type': 'array', 'itemType': 'number' },
      sceneCardName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreExportCardRecordDetailResponseBody extends $tea.Model {
  fileName?: string;
  fileType?: string;
  fileUrl?: string;
  id?: string;
  isImport?: string;
  remark?: string;
  status?: string;
  successNum?: string;
  totalNum?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      fileType: 'fileType',
      fileUrl: 'fileUrl',
      id: 'id',
      isImport: 'isImport',
      remark: 'remark',
      status: 'status',
      successNum: 'successNum',
      totalNum: 'totalNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      fileType: 'string',
      fileUrl: 'string',
      id: 'string',
      isImport: 'string',
      remark: 'string',
      status: 'string',
      successNum: 'string',
      totalNum: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreExportCardRecordDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStoreExportCardRecordDetailResponseBody;
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
      body: DigitalStoreExportCardRecordDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreGroupInfoHeaders extends $tea.Model {
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

export class DigitalStoreGroupInfoRequest extends $tea.Model {
  groupId?: number;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreGroupInfoResponseBody extends $tea.Model {
  groupId?: number;
  groupName?: string;
  storeIdList?: number[];
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      groupName: 'groupName',
      storeIdList: 'storeIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
      groupName: 'string',
      storeIdList: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreGroupInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStoreGroupInfoResponseBody;
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
      body: DigitalStoreGroupInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreGroupsHeaders extends $tea.Model {
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

export class DigitalStoreGroupsResponseBody extends $tea.Model {
  content?: DigitalStoreGroupsResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': DigitalStoreGroupsResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreGroupsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStoreGroupsResponseBody;
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
      body: DigitalStoreGroupsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreNodeInfoHeaders extends $tea.Model {
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

export class DigitalStoreNodeInfoRequest extends $tea.Model {
  code?: string;
  nodeId?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      nodeId: 'nodeId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      nodeId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreNodeInfoResponseBody extends $tea.Model {
  dingDeptId?: number;
  id?: number;
  name?: string;
  parentId?: number;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      dingDeptId: 'dingDeptId',
      id: 'id',
      name: 'name',
      parentId: 'parentId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingDeptId: 'number',
      id: 'number',
      name: 'string',
      parentId: 'number',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreNodeInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStoreNodeInfoResponseBody;
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
      body: DigitalStoreNodeInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreRightsInfoHeaders extends $tea.Model {
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

export class DigitalStoreRightsInfoResponseBody extends $tea.Model {
  endTime?: number;
  quantity?: number;
  rightsCode?: string;
  rightsName?: string;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      quantity: 'quantity',
      rightsCode: 'rightsCode',
      rightsName: 'rightsName',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      quantity: 'number',
      rightsCode: 'string',
      rightsName: 'string',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreRightsInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStoreRightsInfoResponseBody;
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
      body: DigitalStoreRightsInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreRolesHeaders extends $tea.Model {
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

export class DigitalStoreRolesResponseBody extends $tea.Model {
  content?: DigitalStoreRolesResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': DigitalStoreRolesResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreRolesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStoreRolesResponseBody;
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
      body: DigitalStoreRolesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreSceneScopeHeaders extends $tea.Model {
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

export class DigitalStoreSceneScopeRequest extends $tea.Model {
  openConversationId?: string;
  sceneCode?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      sceneCode: 'sceneCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      sceneCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreSceneScopeResponseBody extends $tea.Model {
  groupConversationType?: string;
  scopeId?: number;
  static names(): { [key: string]: string } {
    return {
      groupConversationType: 'groupConversationType',
      scopeId: 'scopeId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupConversationType: 'string',
      scopeId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreSceneScopeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStoreSceneScopeResponseBody;
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
      body: DigitalStoreSceneScopeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreStoreInfoHeaders extends $tea.Model {
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

export class DigitalStoreStoreInfoRequest extends $tea.Model {
  code?: string;
  storeId?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      storeId: 'storeId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      storeId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreStoreInfoResponseBody extends $tea.Model {
  address?: string;
  businessHours?: string;
  dingDeptId?: number;
  latitude?: string;
  locationAddress?: string;
  longitude?: string;
  name?: string;
  parentId?: number;
  status?: string;
  storeAcreage?: string;
  storeBandwidth?: string;
  storeCode?: string;
  storeId?: number;
  telephone?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      businessHours: 'businessHours',
      dingDeptId: 'dingDeptId',
      latitude: 'latitude',
      locationAddress: 'locationAddress',
      longitude: 'longitude',
      name: 'name',
      parentId: 'parentId',
      status: 'status',
      storeAcreage: 'storeAcreage',
      storeBandwidth: 'storeBandwidth',
      storeCode: 'storeCode',
      storeId: 'storeId',
      telephone: 'telephone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      businessHours: 'string',
      dingDeptId: 'number',
      latitude: 'string',
      locationAddress: 'string',
      longitude: 'string',
      name: 'string',
      parentId: 'number',
      status: 'string',
      storeAcreage: 'string',
      storeBandwidth: 'string',
      storeCode: 'string',
      storeId: 'number',
      telephone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreStoreInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStoreStoreInfoResponseBody;
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
      body: DigitalStoreStoreInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreSubNodesHeaders extends $tea.Model {
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

export class DigitalStoreSubNodesRequest extends $tea.Model {
  code?: string;
  nodeId?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      nodeId: 'nodeId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      nodeId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreSubNodesResponseBody extends $tea.Model {
  content?: DigitalStoreSubNodesResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': DigitalStoreSubNodesResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreSubNodesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStoreSubNodesResponseBody;
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
      body: DigitalStoreSubNodesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreUpdateAuthInfoHeaders extends $tea.Model {
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

export class DigitalStoreUpdateAuthInfoRequest extends $tea.Model {
  updateUserList?: DigitalStoreUpdateAuthInfoRequestUpdateUserList[];
  static names(): { [key: string]: string } {
    return {
      updateUserList: 'updateUserList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      updateUserList: { 'type': 'array', 'itemType': DigitalStoreUpdateAuthInfoRequestUpdateUserList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreUpdateAuthInfoResponseBody extends $tea.Model {
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

export class DigitalStoreUpdateAuthInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStoreUpdateAuthInfoResponseBody;
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
      body: DigitalStoreUpdateAuthInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreUserInfoHeaders extends $tea.Model {
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

export class DigitalStoreUserInfoRequest extends $tea.Model {
  code?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreUserInfoResponseBody extends $tea.Model {
  name?: string;
  roleIdList?: number[];
  scopeList?: number[];
  storeList?: number[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      roleIdList: 'roleIdList',
      scopeList: 'scopeList',
      storeList: 'storeList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      roleIdList: { 'type': 'array', 'itemType': 'number' },
      scopeList: { 'type': 'array', 'itemType': 'number' },
      storeList: { 'type': 'array', 'itemType': 'number' },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreUserInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStoreUserInfoResponseBody;
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
      body: DigitalStoreUserInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreUsersHeaders extends $tea.Model {
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

export class DigitalStoreUsersRequest extends $tea.Model {
  code?: string;
  nodeId?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      nodeId: 'nodeId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      nodeId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreUsersResponseBody extends $tea.Model {
  content?: DigitalStoreUsersResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': DigitalStoreUsersResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStoreUsersResponseBody;
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
      body: DigitalStoreUsersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStorelistExportTaskRecordHeaders extends $tea.Model {
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

export class DigitalStorelistExportTaskRecordRequest extends $tea.Model {
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

export class DigitalStorelistExportTaskRecordResponseBody extends $tea.Model {
  content?: DigitalStorelistExportTaskRecordResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': DigitalStorelistExportTaskRecordResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStorelistExportTaskRecordResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DigitalStorelistExportTaskRecordResponseBody;
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
      body: DigitalStorelistExportTaskRecordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExternalQueryExternalAppOrgsHeaders extends $tea.Model {
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

export class ExternalQueryExternalAppOrgsRequest extends $tea.Model {
  externalType?: string;
  static names(): { [key: string]: string } {
    return {
      externalType: 'externalType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      externalType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExternalQueryExternalAppOrgsResponseBody extends $tea.Model {
  result?: ExternalQueryExternalAppOrgsResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ExternalQueryExternalAppOrgsResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExternalQueryExternalAppOrgsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ExternalQueryExternalAppOrgsResponseBody;
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
      body: ExternalQueryExternalAppOrgsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExternalQueryExternalBelongMainOrgHeaders extends $tea.Model {
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

export class ExternalQueryExternalBelongMainOrgRequest extends $tea.Model {
  externalType?: string;
  static names(): { [key: string]: string } {
    return {
      externalType: 'externalType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      externalType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExternalQueryExternalBelongMainOrgResponseBody extends $tea.Model {
  corpId?: string;
  corpName?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      corpName: 'corpName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      corpName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExternalQueryExternalBelongMainOrgResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ExternalQueryExternalBelongMainOrgResponseBody;
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
      body: ExternalQueryExternalBelongMainOrgResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExternalQueryExternalOrgsHeaders extends $tea.Model {
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

export class ExternalQueryExternalOrgsRequest extends $tea.Model {
  externalType?: string;
  static names(): { [key: string]: string } {
    return {
      externalType: 'externalType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      externalType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExternalQueryExternalOrgsResponseBody extends $tea.Model {
  result?: ExternalQueryExternalOrgsResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ExternalQueryExternalOrgsResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExternalQueryExternalOrgsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ExternalQueryExternalOrgsResponseBody;
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
      body: ExternalQueryExternalOrgsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HospitalDataCheckHeaders extends $tea.Model {
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

export class HospitalDataCheckRequest extends $tea.Model {
  allDeptCount?: number;
  allDeptUserCount?: number;
  allGroupCount?: number;
  allGroupUserCount?: number;
  deptCount?: number;
  deptUserCount?: number;
  groupCount?: number;
  groupUserCount?: number;
  static names(): { [key: string]: string } {
    return {
      allDeptCount: 'allDeptCount',
      allDeptUserCount: 'allDeptUserCount',
      allGroupCount: 'allGroupCount',
      allGroupUserCount: 'allGroupUserCount',
      deptCount: 'deptCount',
      deptUserCount: 'deptUserCount',
      groupCount: 'groupCount',
      groupUserCount: 'groupUserCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      allDeptCount: 'number',
      allDeptUserCount: 'number',
      allGroupCount: 'number',
      allGroupUserCount: 'number',
      deptCount: 'number',
      deptUserCount: 'number',
      groupCount: 'number',
      groupUserCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HospitalDataCheckResponseBody extends $tea.Model {
  allDeptCount?: number;
  allDeptUserCount?: number;
  allGroupCount?: number;
  allGroupUserCount?: number;
  deptCount?: number;
  deptUserCount?: number;
  groupCount?: number;
  groupUserCount?: number;
  match?: boolean;
  static names(): { [key: string]: string } {
    return {
      allDeptCount: 'allDeptCount',
      allDeptUserCount: 'allDeptUserCount',
      allGroupCount: 'allGroupCount',
      allGroupUserCount: 'allGroupUserCount',
      deptCount: 'deptCount',
      deptUserCount: 'deptUserCount',
      groupCount: 'groupCount',
      groupUserCount: 'groupUserCount',
      match: 'match',
    };
  }

  static types(): { [key: string]: any } {
    return {
      allDeptCount: 'number',
      allDeptUserCount: 'number',
      allGroupCount: 'number',
      allGroupUserCount: 'number',
      deptCount: 'number',
      deptUserCount: 'number',
      groupCount: 'number',
      groupUserCount: 'number',
      match: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HospitalDataCheckResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: HospitalDataCheckResponseBody;
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
      body: HospitalDataCheckResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureCommonEventHeaders extends $tea.Model {
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

export class IndustryManufactureCommonEventRequest extends $tea.Model {
  action?: string;
  appKey?: string;
  bizData?: { [key: string]: any };
  eventType?: string[];
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      appKey: 'appKey',
      bizData: 'bizData',
      eventType: 'eventType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      appKey: 'string',
      bizData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      eventType: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureCommonEventResponseBody extends $tea.Model {
  errorMsg?: string;
  requestId?: string;
  result?: IndustryManufactureCommonEventResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      errorMsg: 'errorMsg',
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorMsg: 'string',
      requestId: 'string',
      result: IndustryManufactureCommonEventResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureCommonEventResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: IndustryManufactureCommonEventResponseBody;
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
      body: IndustryManufactureCommonEventResponseBody,
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
  statusCode: number;
  body: IndustryManufactureCostRecordListGetResponseBody;
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
  statusCode: number;
  body: IndustryManufactureFeeListGetResponseBody;
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
  statusCode: number;
  body: IndustryManufactureLabourCostResponseBody;
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
  statusCode: number;
  body: IndustryManufactureMaterialListResponseBody;
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
      body: IndustryManufactureMaterialListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesDispatchTaskHeaders extends $tea.Model {
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

export class IndustryManufactureMesDispatchTaskRequest extends $tea.Model {
  action?: string;
  appKey?: string;
  baseDataName?: string;
  defectsAmount?: string;
  dispatchStaffName?: string;
  dispatchStaffNo?: string;
  fineAmount?: string;
  overdue?: number;
  planQuantity?: number;
  priority?: number;
  processName?: string;
  processUuid?: string;
  productCode?: string;
  productName?: string;
  productSpecification?: string;
  projectCode?: string;
  projectId?: string;
  projectStatus?: string;
  taskOperators?: string;
  taskPlanEndTime?: string;
  taskPlanStartTime?: string;
  taskStatus?: string;
  taskType?: string;
  teamId?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      appKey: 'appKey',
      baseDataName: 'baseDataName',
      defectsAmount: 'defectsAmount',
      dispatchStaffName: 'dispatchStaffName',
      dispatchStaffNo: 'dispatchStaffNo',
      fineAmount: 'fineAmount',
      overdue: 'overdue',
      planQuantity: 'planQuantity',
      priority: 'priority',
      processName: 'processName',
      processUuid: 'processUuid',
      productCode: 'productCode',
      productName: 'productName',
      productSpecification: 'productSpecification',
      projectCode: 'projectCode',
      projectId: 'projectId',
      projectStatus: 'projectStatus',
      taskOperators: 'taskOperators',
      taskPlanEndTime: 'taskPlanEndTime',
      taskPlanStartTime: 'taskPlanStartTime',
      taskStatus: 'taskStatus',
      taskType: 'taskType',
      teamId: 'teamId',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      appKey: 'string',
      baseDataName: 'string',
      defectsAmount: 'string',
      dispatchStaffName: 'string',
      dispatchStaffNo: 'string',
      fineAmount: 'string',
      overdue: 'number',
      planQuantity: 'number',
      priority: 'number',
      processName: 'string',
      processUuid: 'string',
      productCode: 'string',
      productName: 'string',
      productSpecification: 'string',
      projectCode: 'string',
      projectId: 'string',
      projectStatus: 'string',
      taskOperators: 'string',
      taskPlanEndTime: 'string',
      taskPlanStartTime: 'string',
      taskStatus: 'string',
      taskType: 'string',
      teamId: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesDispatchTaskResponseBody extends $tea.Model {
  result?: IndustryManufactureMesDispatchTaskResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: IndustryManufactureMesDispatchTaskResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesDispatchTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: IndustryManufactureMesDispatchTaskResponseBody;
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
      body: IndustryManufactureMesDispatchTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesMaterialHeaders extends $tea.Model {
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

export class IndustryManufactureMesMaterialRequest extends $tea.Model {
  action?: string;
  appKey?: string;
  baseDataName?: string;
  category?: string;
  extendData?: IndustryManufactureMesMaterialRequestExtendData[];
  productCode?: string;
  productName?: string;
  productSpecification?: string;
  prop?: string;
  unit?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      appKey: 'appKey',
      baseDataName: 'baseDataName',
      category: 'category',
      extendData: 'extendData',
      productCode: 'productCode',
      productName: 'productName',
      productSpecification: 'productSpecification',
      prop: 'prop',
      unit: 'unit',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      appKey: 'string',
      baseDataName: 'string',
      category: 'string',
      extendData: { 'type': 'array', 'itemType': IndustryManufactureMesMaterialRequestExtendData },
      productCode: 'string',
      productName: 'string',
      productSpecification: 'string',
      prop: 'string',
      unit: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesMaterialResponseBody extends $tea.Model {
  result?: IndustryManufactureMesMaterialResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: IndustryManufactureMesMaterialResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesMaterialResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: IndustryManufactureMesMaterialResponseBody;
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
      body: IndustryManufactureMesMaterialResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesOutPlanHeaders extends $tea.Model {
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

export class IndustryManufactureMesOutPlanRequest extends $tea.Model {
  approvalStatus?: string;
  approver?: string;
  baseDataName?: string;
  outSourceProjectCode?: string;
  outSourceTeamId?: string;
  price?: string;
  processIdentificationCode?: string;
  processUuids?: string;
  productCode?: string;
  productName?: string;
  productSpecification?: string;
  projectCode?: string;
  projectId?: string;
  sendPlanQuantity?: string;
  supplierCode?: string;
  supplierName?: string;
  totalWage?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      approvalStatus: 'approvalStatus',
      approver: 'approver',
      baseDataName: 'baseDataName',
      outSourceProjectCode: 'outSourceProjectCode',
      outSourceTeamId: 'outSourceTeamId',
      price: 'price',
      processIdentificationCode: 'processIdentificationCode',
      processUuids: 'processUuids',
      productCode: 'productCode',
      productName: 'productName',
      productSpecification: 'productSpecification',
      projectCode: 'projectCode',
      projectId: 'projectId',
      sendPlanQuantity: 'sendPlanQuantity',
      supplierCode: 'supplierCode',
      supplierName: 'supplierName',
      totalWage: 'totalWage',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approvalStatus: 'string',
      approver: 'string',
      baseDataName: 'string',
      outSourceProjectCode: 'string',
      outSourceTeamId: 'string',
      price: 'string',
      processIdentificationCode: 'string',
      processUuids: 'string',
      productCode: 'string',
      productName: 'string',
      productSpecification: 'string',
      projectCode: 'string',
      projectId: 'string',
      sendPlanQuantity: 'string',
      supplierCode: 'string',
      supplierName: 'string',
      totalWage: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesOutPlanResponseBody extends $tea.Model {
  result?: IndustryManufactureMesOutPlanResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: IndustryManufactureMesOutPlanResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesOutPlanResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: IndustryManufactureMesOutPlanResponseBody;
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
      body: IndustryManufactureMesOutPlanResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesOutputHeaders extends $tea.Model {
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

export class IndustryManufactureMesOutputRequest extends $tea.Model {
  action?: string;
  appKey?: string;
  approveStatus?: string;
  baseDataName?: string;
  defectsAmount?: string;
  defectsReason?: string;
  fineAmount?: string;
  hasQualityTest?: string;
  overdue?: number;
  planQuantity?: number;
  priority?: number;
  processName?: string;
  processUuid?: string;
  productCode?: string;
  productName?: string;
  productSpecification?: string;
  projectCode?: string;
  projectId?: string;
  projectStatus?: string;
  qualityTestStatus?: string;
  taskPlanEndTime?: string;
  taskPlanStartTime?: string;
  taskStatus?: string;
  taskType?: string;
  taskUuid?: string;
  teamId?: string;
  userId?: string;
  userName?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      appKey: 'appKey',
      approveStatus: 'approveStatus',
      baseDataName: 'baseDataName',
      defectsAmount: 'defectsAmount',
      defectsReason: 'defectsReason',
      fineAmount: 'fineAmount',
      hasQualityTest: 'hasQualityTest',
      overdue: 'overdue',
      planQuantity: 'planQuantity',
      priority: 'priority',
      processName: 'processName',
      processUuid: 'processUuid',
      productCode: 'productCode',
      productName: 'productName',
      productSpecification: 'productSpecification',
      projectCode: 'projectCode',
      projectId: 'projectId',
      projectStatus: 'projectStatus',
      qualityTestStatus: 'qualityTestStatus',
      taskPlanEndTime: 'taskPlanEndTime',
      taskPlanStartTime: 'taskPlanStartTime',
      taskStatus: 'taskStatus',
      taskType: 'taskType',
      taskUuid: 'taskUuid',
      teamId: 'teamId',
      userId: 'userId',
      userName: 'userName',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      appKey: 'string',
      approveStatus: 'string',
      baseDataName: 'string',
      defectsAmount: 'string',
      defectsReason: 'string',
      fineAmount: 'string',
      hasQualityTest: 'string',
      overdue: 'number',
      planQuantity: 'number',
      priority: 'number',
      processName: 'string',
      processUuid: 'string',
      productCode: 'string',
      productName: 'string',
      productSpecification: 'string',
      projectCode: 'string',
      projectId: 'string',
      projectStatus: 'string',
      qualityTestStatus: 'string',
      taskPlanEndTime: 'string',
      taskPlanStartTime: 'string',
      taskStatus: 'string',
      taskType: 'string',
      taskUuid: 'string',
      teamId: 'string',
      userId: 'string',
      userName: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesOutputResponseBody extends $tea.Model {
  result?: IndustryManufactureMesOutputResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: IndustryManufactureMesOutputResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesOutputResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: IndustryManufactureMesOutputResponseBody;
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
      body: IndustryManufactureMesOutputResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesProcessHeaders extends $tea.Model {
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

export class IndustryManufactureMesProcessRequest extends $tea.Model {
  action?: string;
  appKey?: string;
  baseDataName?: string;
  extendData?: IndustryManufactureMesProcessRequestExtendData[];
  name?: string;
  needDispatch?: string;
  needQualityTest?: string;
  no?: string;
  price?: string;
  prop?: string;
  remark?: string;
  sop?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      appKey: 'appKey',
      baseDataName: 'baseDataName',
      extendData: 'extendData',
      name: 'name',
      needDispatch: 'needDispatch',
      needQualityTest: 'needQualityTest',
      no: 'no',
      price: 'price',
      prop: 'prop',
      remark: 'remark',
      sop: 'sop',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      appKey: 'string',
      baseDataName: 'string',
      extendData: { 'type': 'array', 'itemType': IndustryManufactureMesProcessRequestExtendData },
      name: 'string',
      needDispatch: 'string',
      needQualityTest: 'string',
      no: 'string',
      price: 'string',
      prop: 'string',
      remark: 'string',
      sop: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesProcessResponseBody extends $tea.Model {
  result?: IndustryManufactureMesProcessResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: IndustryManufactureMesProcessResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesProcessResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: IndustryManufactureMesProcessResponseBody;
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
      body: IndustryManufactureMesProcessResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesProductionPlanHeaders extends $tea.Model {
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

export class IndustryManufactureMesProductionPlanRequest extends $tea.Model {
  action?: string;
  actualEndTime?: string;
  actualStartTime?: string;
  appKey?: string;
  baseDataName?: string;
  bomUuid?: string;
  events?: string[];
  extendData?: IndustryManufactureMesProductionPlanRequestExtendData[];
  no?: string;
  overdue?: string;
  planEndTime?: string;
  planQuantity?: string;
  planStartTime?: string;
  processUuids?: string;
  productCode?: string;
  productName?: string;
  productSpecification?: string;
  qualifiedQuantity?: string;
  sellOrderNo?: string;
  status?: string;
  teamList?: string;
  title?: string;
  type?: string;
  unit?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      actualEndTime: 'actualEndTime',
      actualStartTime: 'actualStartTime',
      appKey: 'appKey',
      baseDataName: 'baseDataName',
      bomUuid: 'bomUuid',
      events: 'events',
      extendData: 'extendData',
      no: 'no',
      overdue: 'overdue',
      planEndTime: 'planEndTime',
      planQuantity: 'planQuantity',
      planStartTime: 'planStartTime',
      processUuids: 'processUuids',
      productCode: 'productCode',
      productName: 'productName',
      productSpecification: 'productSpecification',
      qualifiedQuantity: 'qualifiedQuantity',
      sellOrderNo: 'sellOrderNo',
      status: 'status',
      teamList: 'teamList',
      title: 'title',
      type: 'type',
      unit: 'unit',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      actualEndTime: 'string',
      actualStartTime: 'string',
      appKey: 'string',
      baseDataName: 'string',
      bomUuid: 'string',
      events: { 'type': 'array', 'itemType': 'string' },
      extendData: { 'type': 'array', 'itemType': IndustryManufactureMesProductionPlanRequestExtendData },
      no: 'string',
      overdue: 'string',
      planEndTime: 'string',
      planQuantity: 'string',
      planStartTime: 'string',
      processUuids: 'string',
      productCode: 'string',
      productName: 'string',
      productSpecification: 'string',
      qualifiedQuantity: 'string',
      sellOrderNo: 'string',
      status: 'string',
      teamList: 'string',
      title: 'string',
      type: 'string',
      unit: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesProductionPlanResponseBody extends $tea.Model {
  result?: IndustryManufactureMesProductionPlanResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: IndustryManufactureMesProductionPlanResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesProductionPlanResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: IndustryManufactureMesProductionPlanResponseBody;
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
      body: IndustryManufactureMesProductionPlanResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesSubCooperationTeamHeaders extends $tea.Model {
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

export class IndustryManufactureMesSubCooperationTeamRequest extends $tea.Model {
  action?: string;
  appKey?: string;
  baseDataName?: string;
  events?: string[];
  extendData?: IndustryManufactureMesSubCooperationTeamRequestExtendData[];
  groupPlugins?: IndustryManufactureMesSubCooperationTeamRequestGroupPlugins[];
  groupType?: string;
  leaders?: IndustryManufactureMesSubCooperationTeamRequestLeaders[];
  members?: IndustryManufactureMesSubCooperationTeamRequestMembers[];
  name?: string;
  outCorpId?: string;
  processIds?: string[];
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      appKey: 'appKey',
      baseDataName: 'baseDataName',
      events: 'events',
      extendData: 'extendData',
      groupPlugins: 'groupPlugins',
      groupType: 'groupType',
      leaders: 'leaders',
      members: 'members',
      name: 'name',
      outCorpId: 'outCorpId',
      processIds: 'processIds',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      appKey: 'string',
      baseDataName: 'string',
      events: { 'type': 'array', 'itemType': 'string' },
      extendData: { 'type': 'array', 'itemType': IndustryManufactureMesSubCooperationTeamRequestExtendData },
      groupPlugins: { 'type': 'array', 'itemType': IndustryManufactureMesSubCooperationTeamRequestGroupPlugins },
      groupType: 'string',
      leaders: { 'type': 'array', 'itemType': IndustryManufactureMesSubCooperationTeamRequestLeaders },
      members: { 'type': 'array', 'itemType': IndustryManufactureMesSubCooperationTeamRequestMembers },
      name: 'string',
      outCorpId: 'string',
      processIds: { 'type': 'array', 'itemType': 'string' },
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesSubCooperationTeamResponseBody extends $tea.Model {
  result?: IndustryManufactureMesSubCooperationTeamResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: IndustryManufactureMesSubCooperationTeamResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesSubCooperationTeamResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: IndustryManufactureMesSubCooperationTeamResponseBody;
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
      body: IndustryManufactureMesSubCooperationTeamResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesTeamMgmtHeaders extends $tea.Model {
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

export class IndustryManufactureMesTeamMgmtRequest extends $tea.Model {
  action?: string;
  appKey?: string;
  baseDataName?: string;
  events?: string[];
  extendData?: IndustryManufactureMesTeamMgmtRequestExtendData[];
  groupConfig?: { [key: string]: any };
  groupPlugins?: IndustryManufactureMesTeamMgmtRequestGroupPlugins[];
  groupType?: string;
  id?: string;
  leaders?: IndustryManufactureMesTeamMgmtRequestLeaders[];
  members?: IndustryManufactureMesTeamMgmtRequestMembers[];
  name?: string;
  processIds?: string[];
  tagKey?: string;
  tagValues?: string[];
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      appKey: 'appKey',
      baseDataName: 'baseDataName',
      events: 'events',
      extendData: 'extendData',
      groupConfig: 'groupConfig',
      groupPlugins: 'groupPlugins',
      groupType: 'groupType',
      id: 'id',
      leaders: 'leaders',
      members: 'members',
      name: 'name',
      processIds: 'processIds',
      tagKey: 'tagKey',
      tagValues: 'tagValues',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      appKey: 'string',
      baseDataName: 'string',
      events: { 'type': 'array', 'itemType': 'string' },
      extendData: { 'type': 'array', 'itemType': IndustryManufactureMesTeamMgmtRequestExtendData },
      groupConfig: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      groupPlugins: { 'type': 'array', 'itemType': IndustryManufactureMesTeamMgmtRequestGroupPlugins },
      groupType: 'string',
      id: 'string',
      leaders: { 'type': 'array', 'itemType': IndustryManufactureMesTeamMgmtRequestLeaders },
      members: { 'type': 'array', 'itemType': IndustryManufactureMesTeamMgmtRequestMembers },
      name: 'string',
      processIds: { 'type': 'array', 'itemType': 'string' },
      tagKey: 'string',
      tagValues: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesTeamMgmtResponseBody extends $tea.Model {
  dingOpenErrcode?: number;
  errorMsg?: string;
  result?: IndustryManufactureMesTeamMgmtResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      dingOpenErrcode: 'dingOpenErrcode',
      errorMsg: 'errorMsg',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingOpenErrcode: 'number',
      errorMsg: 'string',
      result: IndustryManufactureMesTeamMgmtResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesTeamMgmtResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: IndustryManufactureMesTeamMgmtResponseBody;
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
      body: IndustryManufactureMesTeamMgmtResponseBody,
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
  statusCode: number;
  body: IndustryMmanufactureMaterialCostGetResponseBody;
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
      body: IndustryMmanufactureMaterialCostGetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushDingMessageHeaders extends $tea.Model {
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

export class PushDingMessageRequest extends $tea.Model {
  appId?: number;
  content?: string;
  messageType?: string;
  messageUrl?: string;
  pictureUrl?: string;
  singleTitle?: string;
  singleUrl?: string;
  title?: string;
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      content: 'content',
      messageType: 'messageType',
      messageUrl: 'messageUrl',
      pictureUrl: 'pictureUrl',
      singleTitle: 'singleTitle',
      singleUrl: 'singleUrl',
      title: 'title',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'number',
      content: 'string',
      messageType: 'string',
      messageUrl: 'string',
      pictureUrl: 'string',
      singleTitle: 'string',
      singleUrl: 'string',
      title: 'string',
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushDingMessageResponseBody extends $tea.Model {
  content?: number;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'number',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushDingMessageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PushDingMessageResponseBody;
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
      body: PushDingMessageResponseBody,
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
  statusCode: number;
  body: QueryAllDepartmentResponseBody;
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
  monthMark?: string;
  pageNum?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      monthMark: 'monthMark',
      pageNum: 'pageNum',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      monthMark: 'string',
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
  statusCode: number;
  body: QueryAllDoctorsResponseBody;
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
  statusCode: number;
  body: QueryAllGroupResponseBody;
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
  statusCode: number;
  body: QueryAllGroupsInDeptResponseBody;
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
  monthMark?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      monthMark: 'monthMark',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      monthMark: 'string',
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
  statusCode: number;
  body: QueryAllMemberByDeptResponseBody;
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
  monthMark?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      monthMark: 'monthMark',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      monthMark: 'string',
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
  statusCode: number;
  body: QueryAllMemberByGroupResponseBody;
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
  statusCode: number;
  body: QueryBizOptLogResponseBody;
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
      body: QueryBizOptLogResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentExtendInfoHeaders extends $tea.Model {
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

export class QueryDepartmentExtendInfoRequest extends $tea.Model {
  deptCode?: number;
  propCode?: string;
  static names(): { [key: string]: string } {
    return {
      deptCode: 'deptCode',
      propCode: 'propCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptCode: 'number',
      propCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentExtendInfoResponseBody extends $tea.Model {
  content?: QueryDepartmentExtendInfoResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryDepartmentExtendInfoResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentExtendInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryDepartmentExtendInfoResponseBody;
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
      body: QueryDepartmentExtendInfoResponseBody,
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
  statusCode: number;
  body: QueryDepartmentInfoResponseBody;
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
      body: QueryDepartmentInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDoctorDetailsByJobNumberHeaders extends $tea.Model {
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

export class QueryDoctorDetailsByJobNumberRequest extends $tea.Model {
  monthMark?: string;
  static names(): { [key: string]: string } {
    return {
      monthMark: 'monthMark',
    };
  }

  static types(): { [key: string]: any } {
    return {
      monthMark: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDoctorDetailsByJobNumberResponseBody extends $tea.Model {
  content?: QueryDoctorDetailsByJobNumberResponseBodyContent;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: QueryDoctorDetailsByJobNumberResponseBodyContent,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDoctorDetailsByJobNumberResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryDoctorDetailsByJobNumberResponseBody;
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
      body: QueryDoctorDetailsByJobNumberResponseBody,
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
  statusCode: number;
  body: QueryGroupInfoResponseBody;
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
  statusCode: number;
  body: QueryHospitalDistrictInfoResponseBody;
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
  statusCode: number;
  body: QueryHospitalRoleUserInfoResponseBody;
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
  statusCode: number;
  body: QueryHospitalRolesResponseBody;
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
  statusCode: number;
  body: QueryJobCodeDictionaryResponseBody;
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
  statusCode: number;
  body: QueryJobStatusCodeDictionaryResponseBody;
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
  statusCode: number;
  body: QueryMedicalEventsResponseBody;
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
      body: QueryMedicalEventsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserCredentialsHeaders extends $tea.Model {
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

export class QueryUserCredentialsRequest extends $tea.Model {
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserCredentialsResponseBody extends $tea.Model {
  content?: QueryUserCredentialsResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryUserCredentialsResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserCredentialsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryUserCredentialsResponseBody;
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
      body: QueryUserCredentialsResponseBody,
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
  statusCode: number;
  body: QueryUserExtInfoResponseBody;
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
  statusCode: number;
  body: QueryUserExtendValuesResponseBody;
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

export class QueryUserInfoRequest extends $tea.Model {
  monthMark?: string;
  static names(): { [key: string]: string } {
    return {
      monthMark: 'monthMark',
    };
  }

  static types(): { [key: string]: any } {
    return {
      monthMark: 'string',
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
  statusCode: number;
  body: QueryUserInfoResponseBody;
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
  statusCode: number;
  body: QueryUserProbCodeDictionaryResponseBody;
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
  statusCode: number;
  body: QueryUserRolesResponseBody;
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
  statusCode: number;
  body: SaveUserExtendValuesResponseBody;
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
      body: SaveUserExtendValuesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplAddRoleHeaders extends $tea.Model {
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

export class SupplAddRoleRequest extends $tea.Model {
  parentRoleGroupId?: string;
  roleName?: string;
  static names(): { [key: string]: string } {
    return {
      parentRoleGroupId: 'parentRoleGroupId',
      roleName: 'roleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      parentRoleGroupId: 'string',
      roleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplAddRoleResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplAddRoleResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplAddRoleResponseBody;
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
      body: SupplAddRoleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyAddDeptHeaders extends $tea.Model {
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

export class SupplyAddDeptRequest extends $tea.Model {
  deptName?: string;
  partnerNumber?: string;
  superDeptId?: number;
  supplyDeptType?: string;
  static names(): { [key: string]: string } {
    return {
      deptName: 'deptName',
      partnerNumber: 'partnerNumber',
      superDeptId: 'superDeptId',
      supplyDeptType: 'supplyDeptType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptName: 'string',
      partnerNumber: 'string',
      superDeptId: 'number',
      supplyDeptType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyAddDeptResponseBody extends $tea.Model {
  result?: SupplyAddDeptResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SupplyAddDeptResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyAddDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyAddDeptResponseBody;
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
      body: SupplyAddDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyAddMemberHeaders extends $tea.Model {
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

export class SupplyAddMemberRequest extends $tea.Model {
  isPartnerManager?: boolean;
  memberMobile?: string;
  memberName?: string;
  memberTitle?: string;
  memberWorkNumber?: string;
  supplyDeptId?: number;
  static names(): { [key: string]: string } {
    return {
      isPartnerManager: 'isPartnerManager',
      memberMobile: 'memberMobile',
      memberName: 'memberName',
      memberTitle: 'memberTitle',
      memberWorkNumber: 'memberWorkNumber',
      supplyDeptId: 'supplyDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isPartnerManager: 'boolean',
      memberMobile: 'string',
      memberName: 'string',
      memberTitle: 'string',
      memberWorkNumber: 'string',
      supplyDeptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyAddMemberResponseBody extends $tea.Model {
  result?: SupplyAddMemberResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SupplyAddMemberResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyAddMemberResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyAddMemberResponseBody;
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
      body: SupplyAddMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyAddPartnerAdminsHeaders extends $tea.Model {
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

export class SupplyAddPartnerAdminsRequest extends $tea.Model {
  deptId?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyAddPartnerAdminsResponseBody extends $tea.Model {
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

export class SupplyAddPartnerAdminsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyAddPartnerAdminsResponseBody;
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
      body: SupplyAddPartnerAdminsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyAddPartnerManagersHeaders extends $tea.Model {
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

export class SupplyAddPartnerManagersRequest extends $tea.Model {
  deptId?: number;
  interfaceId?: string;
  interfaceType?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      interfaceId: 'interfaceId',
      interfaceType: 'interfaceType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      interfaceId: 'string',
      interfaceType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyAddPartnerManagersResponseBody extends $tea.Model {
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

export class SupplyAddPartnerManagersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyAddPartnerManagersResponseBody;
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
      body: SupplyAddPartnerManagersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyAddPartnerTypeHeaders extends $tea.Model {
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

export class SupplyAddPartnerTypeRequest extends $tea.Model {
  name?: string;
  superId?: number;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      superId: 'superId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      superId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyAddPartnerTypeResponseBody extends $tea.Model {
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

export class SupplyAddPartnerTypeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyAddPartnerTypeResponseBody;
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
      body: SupplyAddPartnerTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyChainDeleteDeptHeaders extends $tea.Model {
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

export class SupplyChainDeleteDeptRequest extends $tea.Model {
  supplyDeptId?: number;
  static names(): { [key: string]: string } {
    return {
      supplyDeptId: 'supplyDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      supplyDeptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyChainDeleteDeptResponseBody extends $tea.Model {
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

export class SupplyChainDeleteDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyChainDeleteDeptResponseBody;
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
      body: SupplyChainDeleteDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyChainQueryDeptInfoHeaders extends $tea.Model {
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

export class SupplyChainQueryDeptInfoRequest extends $tea.Model {
  supplyDeptId?: number;
  static names(): { [key: string]: string } {
    return {
      supplyDeptId: 'supplyDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      supplyDeptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyChainQueryDeptInfoResponseBody extends $tea.Model {
  result?: SupplyChainQueryDeptInfoResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SupplyChainQueryDeptInfoResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyChainQueryDeptInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyChainQueryDeptInfoResponseBody;
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
      body: SupplyChainQueryDeptInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyChainUpdateDeptInfoHeaders extends $tea.Model {
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

export class SupplyChainUpdateDeptInfoRequest extends $tea.Model {
  name?: string;
  partnerNumber?: string;
  partnerTypeList?: number[];
  superId?: number;
  supplyDeptId?: number;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      partnerNumber: 'partnerNumber',
      partnerTypeList: 'partnerTypeList',
      superId: 'superId',
      supplyDeptId: 'supplyDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      partnerNumber: 'string',
      partnerTypeList: { 'type': 'array', 'itemType': 'number' },
      superId: 'number',
      supplyDeptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyChainUpdateDeptInfoResponseBody extends $tea.Model {
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

export class SupplyChainUpdateDeptInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyChainUpdateDeptInfoResponseBody;
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
      body: SupplyChainUpdateDeptInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyDeleteMemberHeaders extends $tea.Model {
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

export class SupplyDeleteMemberRequest extends $tea.Model {
  deptId?: number;
  mobile?: string;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      mobile: 'mobile',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      mobile: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyDeleteMemberResponseBody extends $tea.Model {
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

export class SupplyDeleteMemberResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyDeleteMemberResponseBody;
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
      body: SupplyDeleteMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyDeletePartnerAdminsHeaders extends $tea.Model {
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

export class SupplyDeletePartnerAdminsRequest extends $tea.Model {
  deptId?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyDeletePartnerAdminsResponseBody extends $tea.Model {
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

export class SupplyDeletePartnerAdminsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyDeletePartnerAdminsResponseBody;
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
      body: SupplyDeletePartnerAdminsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyDeletePartnerManagersHeaders extends $tea.Model {
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

export class SupplyDeletePartnerManagersRequest extends $tea.Model {
  deptId?: number;
  interfaceId?: string;
  interfaceType?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      interfaceId: 'interfaceId',
      interfaceType: 'interfaceType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      interfaceId: 'string',
      interfaceType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyDeletePartnerManagersResponseBody extends $tea.Model {
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

export class SupplyDeletePartnerManagersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyDeletePartnerManagersResponseBody;
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
      body: SupplyDeletePartnerManagersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyDeletePartnerTypeHeaders extends $tea.Model {
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

export class SupplyDeletePartnerTypeRequest extends $tea.Model {
  labelId?: number;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyDeletePartnerTypeResponseBody extends $tea.Model {
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

export class SupplyDeletePartnerTypeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyDeletePartnerTypeResponseBody;
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
      body: SupplyDeletePartnerTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyDeleteRoleHeaders extends $tea.Model {
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

export class SupplyDeleteRoleRequest extends $tea.Model {
  isRoleGroup?: boolean;
  roleId?: string;
  static names(): { [key: string]: string } {
    return {
      isRoleGroup: 'isRoleGroup',
      roleId: 'roleId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isRoleGroup: 'boolean',
      roleId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyDeleteRoleResponseBody extends $tea.Model {
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

export class SupplyDeleteRoleResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyDeleteRoleResponseBody;
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
      body: SupplyDeleteRoleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyGetMemberHeaders extends $tea.Model {
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

export class SupplyGetMemberRequest extends $tea.Model {
  mobile?: string;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      mobile: 'mobile',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobile: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyGetMemberResponseBody extends $tea.Model {
  result?: SupplyGetMemberResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SupplyGetMemberResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyGetMemberResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyGetMemberResponseBody;
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
      body: SupplyGetMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListDeptMembersHeaders extends $tea.Model {
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

export class SupplyListDeptMembersRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  supplyDeptId?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      supplyDeptId: 'supplyDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      supplyDeptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListDeptMembersResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: SupplyListDeptMembersResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': SupplyListDeptMembersResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListDeptMembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyListDeptMembersResponseBody;
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
      body: SupplyListDeptMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListPartnerAdminsHeaders extends $tea.Model {
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

export class SupplyListPartnerAdminsRequest extends $tea.Model {
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

export class SupplyListPartnerAdminsResponseBody extends $tea.Model {
  result?: SupplyListPartnerAdminsResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': SupplyListPartnerAdminsResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListPartnerAdminsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyListPartnerAdminsResponseBody;
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
      body: SupplyListPartnerAdminsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListPartnerManagersHeaders extends $tea.Model {
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

export class SupplyListPartnerManagersRequest extends $tea.Model {
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

export class SupplyListPartnerManagersResponseBody extends $tea.Model {
  result?: SupplyListPartnerManagersResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': SupplyListPartnerManagersResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListPartnerManagersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyListPartnerManagersResponseBody;
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
      body: SupplyListPartnerManagersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListPartnerTypeHeaders extends $tea.Model {
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

export class SupplyListPartnerTypeRequest extends $tea.Model {
  labelId?: number;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListPartnerTypeResponseBody extends $tea.Model {
  result?: SupplyListPartnerTypeResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': SupplyListPartnerTypeResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListPartnerTypeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyListPartnerTypeResponseBody;
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
      body: SupplyListPartnerTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListRoleHeaders extends $tea.Model {
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

export class SupplyListRoleRequest extends $tea.Model {
  parentRoleId?: string;
  static names(): { [key: string]: string } {
    return {
      parentRoleId: 'parentRoleId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      parentRoleId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListRoleResponseBody extends $tea.Model {
  result?: SupplyListRoleResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': SupplyListRoleResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListRoleResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyListRoleResponseBody;
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
      body: SupplyListRoleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListSubDeptHeaders extends $tea.Model {
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

export class SupplyListSubDeptRequest extends $tea.Model {
  supplyDeptId?: number;
  static names(): { [key: string]: string } {
    return {
      supplyDeptId: 'supplyDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      supplyDeptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListSubDeptResponseBody extends $tea.Model {
  result?: SupplyListSubDeptResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': SupplyListSubDeptResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListSubDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyListSubDeptResponseBody;
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
      body: SupplyListSubDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyQueryPartnerTypeHeaders extends $tea.Model {
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

export class SupplyQueryPartnerTypeRequest extends $tea.Model {
  labelId?: number;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyQueryPartnerTypeResponseBody extends $tea.Model {
  result?: SupplyQueryPartnerTypeResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SupplyQueryPartnerTypeResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyQueryPartnerTypeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyQueryPartnerTypeResponseBody;
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
      body: SupplyQueryPartnerTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyUpdateMemberHeaders extends $tea.Model {
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

export class SupplyUpdateMemberRequest extends $tea.Model {
  isCopyDept?: boolean;
  memberTitle?: string;
  memberWorkNumber?: string;
  mobile?: string;
  newDeptId?: number;
  oldDeptId?: number;
  roleIdList?: string[];
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      isCopyDept: 'isCopyDept',
      memberTitle: 'memberTitle',
      memberWorkNumber: 'memberWorkNumber',
      mobile: 'mobile',
      newDeptId: 'newDeptId',
      oldDeptId: 'oldDeptId',
      roleIdList: 'roleIdList',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isCopyDept: 'boolean',
      memberTitle: 'string',
      memberWorkNumber: 'string',
      mobile: 'string',
      newDeptId: 'number',
      oldDeptId: 'number',
      roleIdList: { 'type': 'array', 'itemType': 'string' },
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyUpdateMemberResponseBody extends $tea.Model {
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

export class SupplyUpdateMemberResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyUpdateMemberResponseBody;
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
      body: SupplyUpdateMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyUpdatePartnerTypeHeaders extends $tea.Model {
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

export class SupplyUpdatePartnerTypeRequest extends $tea.Model {
  labelId?: number;
  name?: string;
  superId?: number;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
      name: 'name',
      superId: 'superId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'number',
      name: 'string',
      superId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyUpdatePartnerTypeResponseBody extends $tea.Model {
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

export class SupplyUpdatePartnerTypeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyUpdatePartnerTypeResponseBody;
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
      body: SupplyUpdatePartnerTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyUpdateRoleHeaders extends $tea.Model {
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

export class SupplyUpdateRoleRequest extends $tea.Model {
  isRoleGroup?: boolean;
  roleId?: string;
  roleName?: string;
  static names(): { [key: string]: string } {
    return {
      isRoleGroup: 'isRoleGroup',
      roleId: 'roleId',
      roleName: 'roleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isRoleGroup: 'boolean',
      roleId: 'string',
      roleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyUpdateRoleResponseBody extends $tea.Model {
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

export class SupplyUpdateRoleResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SupplyUpdateRoleResponseBody;
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
      body: SupplyUpdateRoleResponseBody,
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
  statusCode: number;
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

export class CampusListCampusResponseBodyResult extends $tea.Model {
  address?: string;
  area?: number;
  belongProjectGroupId?: number;
  campusCorpId?: string;
  campusDeptId?: number;
  campusName?: string;
  cityId?: number;
  country?: string;
  countyId?: number;
  description?: string;
  extend?: string;
  location?: string;
  orderEndTime?: number;
  orderInfo?: string;
  orderStartTime?: number;
  provId?: number;
  telephone?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      area: 'area',
      belongProjectGroupId: 'belongProjectGroupId',
      campusCorpId: 'campusCorpId',
      campusDeptId: 'campusDeptId',
      campusName: 'campusName',
      cityId: 'cityId',
      country: 'country',
      countyId: 'countyId',
      description: 'description',
      extend: 'extend',
      location: 'location',
      orderEndTime: 'orderEndTime',
      orderInfo: 'orderInfo',
      orderStartTime: 'orderStartTime',
      provId: 'provId',
      telephone: 'telephone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      area: 'number',
      belongProjectGroupId: 'number',
      campusCorpId: 'string',
      campusDeptId: 'number',
      campusName: 'string',
      cityId: 'number',
      country: 'string',
      countyId: 'number',
      description: 'string',
      extend: 'string',
      location: 'string',
      orderEndTime: 'number',
      orderInfo: 'string',
      orderStartTime: 'number',
      provId: 'number',
      telephone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusListCampusGroupResponseBodyResult extends $tea.Model {
  extend?: string;
  groupDeptId?: number;
  groupName?: string;
  static names(): { [key: string]: string } {
    return {
      extend: 'extend',
      groupDeptId: 'groupDeptId',
      groupName: 'groupName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extend: 'string',
      groupDeptId: 'number',
      groupName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusListRenterResponseBodyResult extends $tea.Model {
  bindRenterCorpId?: string;
  bindTime?: number;
  creditCode?: string;
  endTime?: number;
  extend?: string;
  name?: string;
  renterDeptId?: number;
  startTime?: number;
  state?: number;
  static names(): { [key: string]: string } {
    return {
      bindRenterCorpId: 'bindRenterCorpId',
      bindTime: 'bindTime',
      creditCode: 'creditCode',
      endTime: 'endTime',
      extend: 'extend',
      name: 'name',
      renterDeptId: 'renterDeptId',
      startTime: 'startTime',
      state: 'state',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bindRenterCorpId: 'string',
      bindTime: 'number',
      creditCode: 'string',
      endTime: 'number',
      extend: 'string',
      name: 'string',
      renterDeptId: 'number',
      startTime: 'number',
      state: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CampusListRenterMembersResponseBodyResult extends $tea.Model {
  extend?: string;
  inviteState?: string;
  name?: string;
  state?: string;
  type?: string;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      extend: 'extend',
      inviteState: 'inviteState',
      name: 'name',
      state: 'state',
      type: 'type',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extend: 'string',
      inviteState: 'string',
      name: 'string',
      state: 'string',
      type: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList extends $tea.Model {
  deptId?: number;
  deptName?: string;
  deptType?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      deptName: 'deptName',
      deptType: 'deptType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      deptName: 'string',
      deptType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeListDeptManagerResponseBodyManagerInfoSimpleList extends $tea.Model {
  isActive?: boolean;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      isActive: 'isActive',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isActive: 'boolean',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeListStudentInfoResponseBodyStudentInfoSimpleList extends $tea.Model {
  dingMemberStatus?: string;
  isActive?: boolean;
  studentId?: number;
  studentName?: string;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dingMemberStatus: 'dingMemberStatus',
      isActive: 'isActive',
      studentId: 'studentId',
      studentName: 'studentName',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingMemberStatus: 'string',
      isActive: 'boolean',
      studentId: 'number',
      studentName: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList extends $tea.Model {
  dingMemberStatus?: string;
  isActive?: boolean;
  studentId?: number;
  studentName?: string;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dingMemberStatus: 'dingMemberStatus',
      isActive: 'isActive',
      studentId: 'studentId',
      studentName: 'studentName',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingMemberStatus: 'string',
      isActive: 'boolean',
      studentId: 'number',
      studentName: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList extends $tea.Model {
  deptId?: number;
  memberType?: string;
  studentNumber?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      memberType: 'memberType',
      studentNumber: 'studentNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      memberType: 'string',
      studentNumber: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList extends $tea.Model {
  deptId?: number;
  memberType?: string;
  studentNumber?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      memberType: 'memberType',
      studentNumber: 'studentNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      memberType: 'string',
      studentNumber: 'string',
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

export class DIgitalStoreMessagePushRequestMessageDataList extends $tea.Model {
  callbackKey?: string;
  content?: string;
  newCard?: boolean;
  outTraceId?: string;
  sceneCardCode?: string;
  sceneScope?: number;
  sendNow?: boolean;
  static names(): { [key: string]: string } {
    return {
      callbackKey: 'callbackKey',
      content: 'content',
      newCard: 'newCard',
      outTraceId: 'outTraceId',
      sceneCardCode: 'sceneCardCode',
      sceneScope: 'sceneScope',
      sendNow: 'sendNow',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callbackKey: 'string',
      content: 'string',
      newCard: 'boolean',
      outTraceId: 'string',
      sceneCardCode: 'string',
      sceneScope: 'number',
      sendNow: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreCardRecordResponseBodyContentDetailList extends $tea.Model {
  deptName?: string;
  readStatusStr?: string;
  readTime?: number;
  roleName?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      deptName: 'deptName',
      readStatusStr: 'readStatusStr',
      readTime: 'readTime',
      roleName: 'roleName',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptName: 'string',
      readStatusStr: 'string',
      readTime: 'number',
      roleName: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreCardRecordResponseBodyContent extends $tea.Model {
  conversationTitle?: string;
  detailList?: DigitalStoreCardRecordResponseBodyContentDetailList[];
  id?: number;
  memberNum?: number;
  readNum?: number;
  readPercent?: string;
  receiveNum?: number;
  sceneCardName?: string;
  sendStatus?: string;
  sendTime?: number;
  static names(): { [key: string]: string } {
    return {
      conversationTitle: 'conversationTitle',
      detailList: 'detailList',
      id: 'id',
      memberNum: 'memberNum',
      readNum: 'readNum',
      readPercent: 'readPercent',
      receiveNum: 'receiveNum',
      sceneCardName: 'sceneCardName',
      sendStatus: 'sendStatus',
      sendTime: 'sendTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationTitle: 'string',
      detailList: { 'type': 'array', 'itemType': DigitalStoreCardRecordResponseBodyContentDetailList },
      id: 'number',
      memberNum: 'number',
      readNum: 'number',
      readPercent: 'string',
      receiveNum: 'number',
      sceneCardName: 'string',
      sendStatus: 'string',
      sendTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreConversationsResponseBodyContent extends $tea.Model {
  conversationTitle?: string;
  conversationType?: string;
  id?: number;
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      conversationTitle: 'conversationTitle',
      conversationType: 'conversationType',
      id: 'id',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationTitle: 'string',
      conversationType: 'string',
      id: 'number',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreGroupsResponseBodyContent extends $tea.Model {
  groupId?: number;
  groupName?: string;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      groupName: 'groupName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
      groupName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreRolesResponseBodyContent extends $tea.Model {
  level?: number;
  roleCode?: string;
  roleId?: number;
  roleName?: string;
  source?: string;
  static names(): { [key: string]: string } {
    return {
      level: 'level',
      roleCode: 'roleCode',
      roleId: 'roleId',
      roleName: 'roleName',
      source: 'source',
    };
  }

  static types(): { [key: string]: any } {
    return {
      level: 'number',
      roleCode: 'string',
      roleId: 'number',
      roleName: 'string',
      source: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreSubNodesResponseBodyContent extends $tea.Model {
  dingDeptId?: number;
  id?: number;
  name?: string;
  parentId?: number;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      dingDeptId: 'dingDeptId',
      id: 'id',
      name: 'name',
      parentId: 'parentId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingDeptId: 'number',
      id: 'number',
      name: 'string',
      parentId: 'number',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList extends $tea.Model {
  roleName?: string;
  sourceRoleId?: string;
  static names(): { [key: string]: string } {
    return {
      roleName: 'roleName',
      sourceRoleId: 'sourceRoleId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleName: 'string',
      sourceRoleId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList extends $tea.Model {
  dingDeptId?: string;
  sourceDeptId?: string;
  static names(): { [key: string]: string } {
    return {
      dingDeptId: 'dingDeptId',
      sourceDeptId: 'sourceDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingDeptId: 'string',
      sourceDeptId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreUpdateAuthInfoRequestUpdateUserList extends $tea.Model {
  roleList?: DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList[];
  userAuthList?: DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      roleList: 'roleList',
      userAuthList: 'userAuthList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleList: { 'type': 'array', 'itemType': DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList },
      userAuthList: { 'type': 'array', 'itemType': DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreUsersResponseBodyContent extends $tea.Model {
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

export class DigitalStorelistExportTaskRecordResponseBodyContent extends $tea.Model {
  fileName?: string;
  fileType?: string;
  fileUrl?: string;
  id?: string;
  isImport?: string;
  remark?: string;
  status?: string;
  successNum?: string;
  totalNum?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      fileType: 'fileType',
      fileUrl: 'fileUrl',
      id: 'id',
      isImport: 'isImport',
      remark: 'remark',
      status: 'status',
      successNum: 'successNum',
      totalNum: 'totalNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      fileType: 'string',
      fileUrl: 'string',
      id: 'string',
      isImport: 'string',
      remark: 'string',
      status: 'string',
      successNum: 'string',
      totalNum: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExternalQueryExternalAppOrgsResponseBodyResult extends $tea.Model {
  corpId?: string;
  corpName?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      corpName: 'corpName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      corpName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExternalQueryExternalOrgsResponseBodyResult extends $tea.Model {
  corpId?: string;
  corpName?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      corpName: 'corpName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      corpName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureCommonEventResponseBodyResult extends $tea.Model {
  content?: string;
  httpCode?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      httpCode: 'httpCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      httpCode: 'string',
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

export class IndustryManufactureMesDispatchTaskResponseBodyResult extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesMaterialRequestExtendData extends $tea.Model {
  code?: string;
  name?: string;
  value?: string;
  valueType?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
      value: 'value',
      valueType: 'valueType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
      value: 'string',
      valueType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesMaterialResponseBodyResult extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesOutPlanResponseBodyResult extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesOutputResponseBodyResult extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesProcessRequestExtendData extends $tea.Model {
  code?: string;
  name?: string;
  value?: string;
  valueType?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
      value: 'value',
      valueType: 'valueType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
      value: 'string',
      valueType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesProcessResponseBodyResult extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesProductionPlanRequestExtendData extends $tea.Model {
  code?: string;
  name?: string;
  value?: string;
  valueType?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
      value: 'value',
      valueType: 'valueType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
      value: 'string',
      valueType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesProductionPlanResponseBodyResult extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesSubCooperationTeamRequestExtendData extends $tea.Model {
  code?: string;
  name?: string;
  value?: string;
  valueType?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
      value: 'value',
      valueType: 'valueType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
      value: 'string',
      valueType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesSubCooperationTeamRequestGroupPlugins extends $tea.Model {
  label?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      label: 'label',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      label: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesSubCooperationTeamRequestLeaders extends $tea.Model {
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

export class IndustryManufactureMesSubCooperationTeamRequestMembers extends $tea.Model {
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

export class IndustryManufactureMesSubCooperationTeamResponseBodyResult extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesTeamMgmtRequestExtendData extends $tea.Model {
  code?: string;
  name?: string;
  value?: string;
  valueType?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
      value: 'value',
      valueType: 'valueType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
      value: 'string',
      valueType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesTeamMgmtRequestGroupPlugins extends $tea.Model {
  label?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      label: 'label',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      label: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMesTeamMgmtRequestLeaders extends $tea.Model {
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

export class IndustryManufactureMesTeamMgmtRequestMembers extends $tea.Model {
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

export class IndustryManufactureMesTeamMgmtResponseBodyResult extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
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

export class QueryDepartmentExtendInfoResponseBodyContent extends $tea.Model {
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

export class QueryDepartmentInfoResponseBodyContentDepartment extends $tea.Model {
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

export class QueryDepartmentInfoResponseBodyContentExtendInfos extends $tea.Model {
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

export class QueryDepartmentInfoResponseBodyContent extends $tea.Model {
  department?: QueryDepartmentInfoResponseBodyContentDepartment;
  extendInfos?: QueryDepartmentInfoResponseBodyContentExtendInfos[];
  static names(): { [key: string]: string } {
    return {
      department: 'department',
      extendInfos: 'extendInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      department: QueryDepartmentInfoResponseBodyContentDepartment,
      extendInfos: { 'type': 'array', 'itemType': QueryDepartmentInfoResponseBodyContentExtendInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDoctorDetailsByJobNumberResponseBodyContentDeptList extends $tea.Model {
  categoryName?: string;
  deptId?: number;
  deptName?: string;
  gmtCreate?: string;
  gmtModified?: string;
  relationId?: number;
  static names(): { [key: string]: string } {
    return {
      categoryName: 'categoryName',
      deptId: 'deptId',
      deptName: 'deptName',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      relationId: 'relationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryName: 'string',
      deptId: 'number',
      deptName: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
      relationId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDoctorDetailsByJobNumberResponseBodyContentGroupList extends $tea.Model {
  deptId?: number;
  deptName?: string;
  groupId?: number;
  groupName?: string;
  isAssessGroup?: string;
  isLeader?: boolean;
  relationId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      deptName: 'deptName',
      groupId: 'groupId',
      groupName: 'groupName',
      isAssessGroup: 'isAssessGroup',
      isLeader: 'isLeader',
      relationId: 'relationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      deptName: 'string',
      groupId: 'number',
      groupName: 'string',
      isAssessGroup: 'string',
      isLeader: 'boolean',
      relationId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus extends $tea.Model {
  code?: string;
  statusName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      statusName: 'statusName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      statusName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle extends $tea.Model {
  code?: string;
  professionalTitleCategory?: string;
  professionalTitleDetail?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      professionalTitleCategory: 'professionalTitleCategory',
      professionalTitleDetail: 'professionalTitleDetail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      professionalTitleCategory: 'string',
      professionalTitleDetail: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList extends $tea.Model {
  code?: string;
  userPropertyName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      userPropertyName: 'userPropertyName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      userPropertyName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDoctorDetailsByJobNumberResponseBodyContent extends $tea.Model {
  deptList?: QueryDoctorDetailsByJobNumberResponseBodyContentDeptList[];
  groupList?: QueryDoctorDetailsByJobNumberResponseBodyContentGroupList[];
  jobNumber?: string;
  jobStatus?: QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus[];
  professionalTitle?: QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle;
  userId?: string;
  userName?: string;
  userProbList?: QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList[];
  static names(): { [key: string]: string } {
    return {
      deptList: 'deptList',
      groupList: 'groupList',
      jobNumber: 'jobNumber',
      jobStatus: 'jobStatus',
      professionalTitle: 'professionalTitle',
      userId: 'userId',
      userName: 'userName',
      userProbList: 'userProbList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptList: { 'type': 'array', 'itemType': QueryDoctorDetailsByJobNumberResponseBodyContentDeptList },
      groupList: { 'type': 'array', 'itemType': QueryDoctorDetailsByJobNumberResponseBodyContentGroupList },
      jobNumber: 'string',
      jobStatus: { 'type': 'array', 'itemType': QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus },
      professionalTitle: QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle,
      userId: 'string',
      userName: 'string',
      userProbList: { 'type': 'array', 'itemType': QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoResponseBodyContentExtendInfos extends $tea.Model {
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

export class QueryGroupInfoResponseBodyContentGroupLeader extends $tea.Model {
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

export class QueryGroupInfoResponseBodyContentGroup extends $tea.Model {
  deptId?: number;
  deptStatus?: number;
  gmtCreateStr?: string;
  gmtModifiedStr?: string;
  id?: number;
  leader?: QueryGroupInfoResponseBodyContentGroupLeader;
  name?: string;
  parentDeptCode?: string;
  remark?: string;
  static names(): { [key: string]: string } {
    return {
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
      deptId: 'number',
      deptStatus: 'number',
      gmtCreateStr: 'string',
      gmtModifiedStr: 'string',
      id: 'number',
      leader: QueryGroupInfoResponseBodyContentGroupLeader,
      name: 'string',
      parentDeptCode: 'string',
      remark: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoResponseBodyContent extends $tea.Model {
  extendInfos?: QueryGroupInfoResponseBodyContentExtendInfos[];
  group?: QueryGroupInfoResponseBodyContentGroup;
  static names(): { [key: string]: string } {
    return {
      extendInfos: 'extendInfos',
      group: 'group',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extendInfos: { 'type': 'array', 'itemType': QueryGroupInfoResponseBodyContentExtendInfos },
      group: QueryGroupInfoResponseBodyContentGroup,
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
  status?: number;
  userCode?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      jobNumber: 'jobNumber',
      roleCode: 'roleCode',
      roleName: 'roleName',
      status: 'status',
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
      status: 'number',
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

export class QueryUserCredentialsResponseBodyContentCredentialList extends $tea.Model {
  credentialName?: string;
  credentialType?: number;
  termOfValidity?: string;
  static names(): { [key: string]: string } {
    return {
      credentialName: 'credentialName',
      credentialType: 'credentialType',
      termOfValidity: 'termOfValidity',
    };
  }

  static types(): { [key: string]: any } {
    return {
      credentialName: 'string',
      credentialType: 'number',
      termOfValidity: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserCredentialsResponseBodyContent extends $tea.Model {
  credentialList?: QueryUserCredentialsResponseBodyContentCredentialList[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      credentialList: 'credentialList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      credentialList: { 'type': 'array', 'itemType': QueryUserCredentialsResponseBodyContentCredentialList },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtInfoResponseBodyContent extends $tea.Model {
  gmtCreate?: string;
  gmtModified?: string;
  status?: number;
  userCode?: string;
  userExtendDisplayName?: string;
  userExtendKey?: string;
  userExtendValue?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
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
  gmtCreateStr?: string;
  gmtModifiedStr?: string;
  id?: number;
  name?: string;
  relId?: number;
  static names(): { [key: string]: string } {
    return {
      gmtCreateStr: 'gmtCreateStr',
      gmtModifiedStr: 'gmtModifiedStr',
      id: 'id',
      name: 'name',
      relId: 'relId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreateStr: 'string',
      gmtModifiedStr: 'string',
      id: 'number',
      name: 'string',
      relId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponseBodyContentGroup extends $tea.Model {
  deptId?: number;
  deptName?: string;
  gmtCreateStr?: string;
  gmtModifiedStr?: string;
  id?: number;
  name?: string;
  relId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      deptName: 'deptName',
      gmtCreateStr: 'gmtCreateStr',
      gmtModifiedStr: 'gmtModifiedStr',
      id: 'id',
      name: 'name',
      relId: 'relId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      deptName: 'string',
      gmtCreateStr: 'string',
      gmtModifiedStr: 'string',
      id: 'number',
      name: 'string',
      relId: 'number',
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

export class SupplyAddDeptResponseBodyResult extends $tea.Model {
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

export class SupplyAddMemberResponseBodyResult extends $tea.Model {
  dingMemberStatus?: string;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dingMemberStatus: 'dingMemberStatus',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingMemberStatus: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList extends $tea.Model {
  id?: number;
  name?: string;
  superId?: number;
  superName?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      superId: 'superId',
      superName: 'superName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      superId: 'number',
      superName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyChainQueryDeptInfoResponseBodyResult extends $tea.Model {
  deptId?: number;
  deptType?: string;
  hasSubDept?: boolean;
  name?: string;
  partnerNumber?: string;
  partnerTypeInfoList?: SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList[];
  superId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      deptType: 'deptType',
      hasSubDept: 'hasSubDept',
      name: 'name',
      partnerNumber: 'partnerNumber',
      partnerTypeInfoList: 'partnerTypeInfoList',
      superId: 'superId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      deptType: 'string',
      hasSubDept: 'boolean',
      name: 'string',
      partnerNumber: 'string',
      partnerTypeInfoList: { 'type': 'array', 'itemType': SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList },
      superId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyGetMemberResponseBodyResultRoleInfoList extends $tea.Model {
  roleId?: string;
  roleName?: string;
  static names(): { [key: string]: string } {
    return {
      roleId: 'roleId',
      roleName: 'roleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleId: 'string',
      roleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyGetMemberResponseBodyResult extends $tea.Model {
  deptIdList?: number[];
  dingMemberStatus?: string;
  isActive?: boolean;
  memberName?: string;
  memberTitle?: string;
  memberWorkNumber?: string;
  roleInfoList?: SupplyGetMemberResponseBodyResultRoleInfoList[];
  supplyNodeList?: number[];
  static names(): { [key: string]: string } {
    return {
      deptIdList: 'deptIdList',
      dingMemberStatus: 'dingMemberStatus',
      isActive: 'isActive',
      memberName: 'memberName',
      memberTitle: 'memberTitle',
      memberWorkNumber: 'memberWorkNumber',
      roleInfoList: 'roleInfoList',
      supplyNodeList: 'supplyNodeList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIdList: { 'type': 'array', 'itemType': 'number' },
      dingMemberStatus: 'string',
      isActive: 'boolean',
      memberName: 'string',
      memberTitle: 'string',
      memberWorkNumber: 'string',
      roleInfoList: { 'type': 'array', 'itemType': SupplyGetMemberResponseBodyResultRoleInfoList },
      supplyNodeList: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListDeptMembersResponseBodyList extends $tea.Model {
  dingMemberStatus?: string;
  isActive?: boolean;
  memberName?: string;
  memberTitle?: string;
  memberWorkNumber?: string;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dingMemberStatus: 'dingMemberStatus',
      isActive: 'isActive',
      memberName: 'memberName',
      memberTitle: 'memberTitle',
      memberWorkNumber: 'memberWorkNumber',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingMemberStatus: 'string',
      isActive: 'boolean',
      memberName: 'string',
      memberTitle: 'string',
      memberWorkNumber: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListPartnerAdminsResponseBodyResult extends $tea.Model {
  name?: string;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListPartnerManagersResponseBodyResult extends $tea.Model {
  deptId?: string;
  deptName?: string;
  interfaceType?: string;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      deptName: 'deptName',
      interfaceType: 'interfaceType',
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
      deptName: 'string',
      interfaceType: 'string',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListPartnerTypeResponseBodyResult extends $tea.Model {
  labelId?: number;
  name?: string;
  superId?: number;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
      name: 'name',
      superId: 'superId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'number',
      name: 'string',
      superId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListRoleResponseBodyResult extends $tea.Model {
  isRoleGroup?: boolean;
  roleId?: string;
  roleName?: string;
  static names(): { [key: string]: string } {
    return {
      isRoleGroup: 'isRoleGroup',
      roleId: 'roleId',
      roleName: 'roleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isRoleGroup: 'boolean',
      roleId: 'string',
      roleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListSubDeptResponseBodyResultPartnerTypeInfoList extends $tea.Model {
  id?: number;
  name?: string;
  superId?: number;
  superName?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      superId: 'superId',
      superName: 'superName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      superId: 'number',
      superName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyListSubDeptResponseBodyResult extends $tea.Model {
  deptId?: number;
  deptType?: string;
  hasSubDept?: boolean;
  name?: string;
  partnerNumber?: string;
  partnerTypeInfoList?: SupplyListSubDeptResponseBodyResultPartnerTypeInfoList[];
  superId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      deptType: 'deptType',
      hasSubDept: 'hasSubDept',
      name: 'name',
      partnerNumber: 'partnerNumber',
      partnerTypeInfoList: 'partnerTypeInfoList',
      superId: 'superId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      deptType: 'string',
      hasSubDept: 'boolean',
      name: 'string',
      partnerNumber: 'string',
      partnerTypeInfoList: { 'type': 'array', 'itemType': SupplyListSubDeptResponseBodyResultPartnerTypeInfoList },
      superId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SupplyQueryPartnerTypeResponseBodyResult extends $tea.Model {
  labelId?: number;
  name?: string;
  superId?: number;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
      name: 'name',
      superId: 'superId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'number',
      name: 'string',
      superId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends OpenApi {
  _client: SPI;

  constructor(config: $OpenApi.Config) {
    super(config);
    this._client = new GatewayClient();
    this._spi = this._client;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async campusAddRenterMemberWithOptions(request: CampusAddRenterMemberRequest, headers: CampusAddRenterMemberHeaders, runtime: $Util.RuntimeOptions): Promise<CampusAddRenterMemberResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.extend)) {
      body["extend"] = request.extend;
    }

    if (!Util.isUnset(request.mobile)) {
      body["mobile"] = request.mobile;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.renterId)) {
      body["renterId"] = request.renterId;
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
    let params = new $OpenApi.Params({
      action: "CampusAddRenterMember",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/renters/members`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusAddRenterMemberResponse>(await this.execute(params, req, runtime), new CampusAddRenterMemberResponse({}));
  }

  async campusAddRenterMember(request: CampusAddRenterMemberRequest): Promise<CampusAddRenterMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusAddRenterMemberHeaders({ });
    return await this.campusAddRenterMemberWithOptions(request, headers, runtime);
  }

  async campusCreateCampusWithOptions(request: CampusCreateCampusRequest, headers: CampusCreateCampusHeaders, runtime: $Util.RuntimeOptions): Promise<CampusCreateCampusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.address)) {
      body["address"] = request.address;
    }

    if (!Util.isUnset(request.area)) {
      body["area"] = request.area;
    }

    if (!Util.isUnset(request.belongProjectGroupId)) {
      body["belongProjectGroupId"] = request.belongProjectGroupId;
    }

    if (!Util.isUnset(request.campusName)) {
      body["campusName"] = request.campusName;
    }

    if (!Util.isUnset(request.capacity)) {
      body["capacity"] = request.capacity;
    }

    if (!Util.isUnset(request.cityId)) {
      body["cityId"] = request.cityId;
    }

    if (!Util.isUnset(request.country)) {
      body["country"] = request.country;
    }

    if (!Util.isUnset(request.countyId)) {
      body["countyId"] = request.countyId;
    }

    if (!Util.isUnset(request.creatorUnionId)) {
      body["creatorUnionId"] = request.creatorUnionId;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.extend)) {
      body["extend"] = request.extend;
    }

    if (!Util.isUnset(request.location)) {
      body["location"] = request.location;
    }

    if (!Util.isUnset(request.orderEndTime)) {
      body["orderEndTime"] = request.orderEndTime;
    }

    if (!Util.isUnset(request.orderInfo)) {
      body["orderInfo"] = request.orderInfo;
    }

    if (!Util.isUnset(request.orderStartTime)) {
      body["orderStartTime"] = request.orderStartTime;
    }

    if (!Util.isUnset(request.provId)) {
      body["provId"] = request.provId;
    }

    if (!Util.isUnset(request.telephone)) {
      body["telephone"] = request.telephone;
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
      action: "CampusCreateCampus",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/projects`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusCreateCampusResponse>(await this.execute(params, req, runtime), new CampusCreateCampusResponse({}));
  }

  async campusCreateCampus(request: CampusCreateCampusRequest): Promise<CampusCreateCampusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusCreateCampusHeaders({ });
    return await this.campusCreateCampusWithOptions(request, headers, runtime);
  }

  async campusCreateCampusGroupWithOptions(request: CampusCreateCampusGroupRequest, headers: CampusCreateCampusGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CampusCreateCampusGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.extend)) {
      body["extend"] = request.extend;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
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
      action: "CampusCreateCampusGroup",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/projects/groups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusCreateCampusGroupResponse>(await this.execute(params, req, runtime), new CampusCreateCampusGroupResponse({}));
  }

  async campusCreateCampusGroup(request: CampusCreateCampusGroupRequest): Promise<CampusCreateCampusGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusCreateCampusGroupHeaders({ });
    return await this.campusCreateCampusGroupWithOptions(request, headers, runtime);
  }

  async campusCreateRenterWithOptions(request: CampusCreateRenterRequest, headers: CampusCreateRenterHeaders, runtime: $Util.RuntimeOptions): Promise<CampusCreateRenterResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creditCode)) {
      body["creditCode"] = request.creditCode;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.extend)) {
      body["extend"] = request.extend;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.state)) {
      body["state"] = request.state;
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
      action: "CampusCreateRenter",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/renters`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusCreateRenterResponse>(await this.execute(params, req, runtime), new CampusCreateRenterResponse({}));
  }

  async campusCreateRenter(request: CampusCreateRenterRequest): Promise<CampusCreateRenterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusCreateRenterHeaders({ });
    return await this.campusCreateRenterWithOptions(request, headers, runtime);
  }

  async campusDelRenterMemberWithOptions(request: CampusDelRenterMemberRequest, headers: CampusDelRenterMemberHeaders, runtime: $Util.RuntimeOptions): Promise<CampusDelRenterMemberResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.renterId)) {
      query["renterId"] = request.renterId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "CampusDelRenterMember",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/renters/members`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusDelRenterMemberResponse>(await this.execute(params, req, runtime), new CampusDelRenterMemberResponse({}));
  }

  async campusDelRenterMember(request: CampusDelRenterMemberRequest): Promise<CampusDelRenterMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusDelRenterMemberHeaders({ });
    return await this.campusDelRenterMemberWithOptions(request, headers, runtime);
  }

  async campusDeleteCampusGroupWithOptions(request: CampusDeleteCampusGroupRequest, headers: CampusDeleteCampusGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CampusDeleteCampusGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.campusProjectGroupId)) {
      query["campusProjectGroupId"] = request.campusProjectGroupId;
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
      action: "CampusDeleteCampusGroup",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/projects/groups`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusDeleteCampusGroupResponse>(await this.execute(params, req, runtime), new CampusDeleteCampusGroupResponse({}));
  }

  async campusDeleteCampusGroup(request: CampusDeleteCampusGroupRequest): Promise<CampusDeleteCampusGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusDeleteCampusGroupHeaders({ });
    return await this.campusDeleteCampusGroupWithOptions(request, headers, runtime);
  }

  async campusDeleteRenterWithOptions(request: CampusDeleteRenterRequest, headers: CampusDeleteRenterHeaders, runtime: $Util.RuntimeOptions): Promise<CampusDeleteRenterResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.renterId)) {
      query["renterId"] = request.renterId;
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
      action: "CampusDeleteRenter",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/renters`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<CampusDeleteRenterResponse>(await this.execute(params, req, runtime), new CampusDeleteRenterResponse({}));
  }

  async campusDeleteRenter(request: CampusDeleteRenterRequest): Promise<CampusDeleteRenterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusDeleteRenterHeaders({ });
    return await this.campusDeleteRenterWithOptions(request, headers, runtime);
  }

  async campusGetCampusWithOptions(request: CampusGetCampusRequest, headers: CampusGetCampusHeaders, runtime: $Util.RuntimeOptions): Promise<CampusGetCampusResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.campusDeptId)) {
      query["campusDeptId"] = request.campusDeptId;
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
      action: "CampusGetCampus",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/projectInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusGetCampusResponse>(await this.execute(params, req, runtime), new CampusGetCampusResponse({}));
  }

  async campusGetCampus(request: CampusGetCampusRequest): Promise<CampusGetCampusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusGetCampusHeaders({ });
    return await this.campusGetCampusWithOptions(request, headers, runtime);
  }

  async campusGetCampusGroupWithOptions(request: CampusGetCampusGroupRequest, headers: CampusGetCampusGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CampusGetCampusGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupId)) {
      query["groupId"] = request.groupId;
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
      action: "CampusGetCampusGroup",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/projects/groupInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusGetCampusGroupResponse>(await this.execute(params, req, runtime), new CampusGetCampusGroupResponse({}));
  }

  async campusGetCampusGroup(request: CampusGetCampusGroupRequest): Promise<CampusGetCampusGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusGetCampusGroupHeaders({ });
    return await this.campusGetCampusGroupWithOptions(request, headers, runtime);
  }

  async campusGetRenterWithOptions(request: CampusGetRenterRequest, headers: CampusGetRenterHeaders, runtime: $Util.RuntimeOptions): Promise<CampusGetRenterResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.renterId)) {
      query["renterId"] = request.renterId;
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
      action: "CampusGetRenter",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/renterInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusGetRenterResponse>(await this.execute(params, req, runtime), new CampusGetRenterResponse({}));
  }

  async campusGetRenter(request: CampusGetRenterRequest): Promise<CampusGetRenterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusGetRenterHeaders({ });
    return await this.campusGetRenterWithOptions(request, headers, runtime);
  }

  async campusGetRenterMemberWithOptions(request: CampusGetRenterMemberRequest, headers: CampusGetRenterMemberHeaders, runtime: $Util.RuntimeOptions): Promise<CampusGetRenterMemberResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.renterId)) {
      query["renterId"] = request.renterId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "CampusGetRenterMember",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/renters/memberInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusGetRenterMemberResponse>(await this.execute(params, req, runtime), new CampusGetRenterMemberResponse({}));
  }

  async campusGetRenterMember(request: CampusGetRenterMemberRequest): Promise<CampusGetRenterMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusGetRenterMemberHeaders({ });
    return await this.campusGetRenterMemberWithOptions(request, headers, runtime);
  }

  async campusListCampusWithOptions(request: CampusListCampusRequest, headers: CampusListCampusHeaders, runtime: $Util.RuntimeOptions): Promise<CampusListCampusResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupDeptId)) {
      query["groupDeptId"] = request.groupDeptId;
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
      action: "CampusListCampus",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/projects`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusListCampusResponse>(await this.execute(params, req, runtime), new CampusListCampusResponse({}));
  }

  async campusListCampus(request: CampusListCampusRequest): Promise<CampusListCampusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusListCampusHeaders({ });
    return await this.campusListCampusWithOptions(request, headers, runtime);
  }

  async campusListCampusGroupWithOptions(headers: CampusListCampusGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CampusListCampusGroupResponse> {
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
      action: "CampusListCampusGroup",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/projects/groups`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusListCampusGroupResponse>(await this.execute(params, req, runtime), new CampusListCampusGroupResponse({}));
  }

  async campusListCampusGroup(): Promise<CampusListCampusGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusListCampusGroupHeaders({ });
    return await this.campusListCampusGroupWithOptions(headers, runtime);
  }

  async campusListRenterWithOptions(headers: CampusListRenterHeaders, runtime: $Util.RuntimeOptions): Promise<CampusListRenterResponse> {
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
      action: "CampusListRenter",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/renters`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusListRenterResponse>(await this.execute(params, req, runtime), new CampusListRenterResponse({}));
  }

  async campusListRenter(): Promise<CampusListRenterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusListRenterHeaders({ });
    return await this.campusListRenterWithOptions(headers, runtime);
  }

  async campusListRenterMembersWithOptions(request: CampusListRenterMembersRequest, headers: CampusListRenterMembersHeaders, runtime: $Util.RuntimeOptions): Promise<CampusListRenterMembersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.renterId)) {
      query["renterId"] = request.renterId;
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
      action: "CampusListRenterMembers",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/renters/members`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusListRenterMembersResponse>(await this.execute(params, req, runtime), new CampusListRenterMembersResponse({}));
  }

  async campusListRenterMembers(request: CampusListRenterMembersRequest): Promise<CampusListRenterMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusListRenterMembersHeaders({ });
    return await this.campusListRenterMembersWithOptions(request, headers, runtime);
  }

  async campusUpdateCampusWithOptions(request: CampusUpdateCampusRequest, headers: CampusUpdateCampusHeaders, runtime: $Util.RuntimeOptions): Promise<CampusUpdateCampusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.address)) {
      body["address"] = request.address;
    }

    if (!Util.isUnset(request.area)) {
      body["area"] = request.area;
    }

    if (!Util.isUnset(request.belongProjectGroupId)) {
      body["belongProjectGroupId"] = request.belongProjectGroupId;
    }

    if (!Util.isUnset(request.campusDeptId)) {
      body["campusDeptId"] = request.campusDeptId;
    }

    if (!Util.isUnset(request.campusName)) {
      body["campusName"] = request.campusName;
    }

    if (!Util.isUnset(request.capacity)) {
      body["capacity"] = request.capacity;
    }

    if (!Util.isUnset(request.cityId)) {
      body["cityId"] = request.cityId;
    }

    if (!Util.isUnset(request.country)) {
      body["country"] = request.country;
    }

    if (!Util.isUnset(request.countyId)) {
      body["countyId"] = request.countyId;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.extend)) {
      body["extend"] = request.extend;
    }

    if (!Util.isUnset(request.orderEndTime)) {
      body["orderEndTime"] = request.orderEndTime;
    }

    if (!Util.isUnset(request.orderInfo)) {
      body["orderInfo"] = request.orderInfo;
    }

    if (!Util.isUnset(request.orderStartTime)) {
      body["orderStartTime"] = request.orderStartTime;
    }

    if (!Util.isUnset(request.provId)) {
      body["provId"] = request.provId;
    }

    if (!Util.isUnset(request.telephone)) {
      body["telephone"] = request.telephone;
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
      action: "CampusUpdateCampus",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/projects`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusUpdateCampusResponse>(await this.execute(params, req, runtime), new CampusUpdateCampusResponse({}));
  }

  async campusUpdateCampus(request: CampusUpdateCampusRequest): Promise<CampusUpdateCampusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusUpdateCampusHeaders({ });
    return await this.campusUpdateCampusWithOptions(request, headers, runtime);
  }

  async campusUpdateCampusGroupWithOptions(request: CampusUpdateCampusGroupRequest, headers: CampusUpdateCampusGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CampusUpdateCampusGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.campusProjectGroupId)) {
      body["campusProjectGroupId"] = request.campusProjectGroupId;
    }

    if (!Util.isUnset(request.extend)) {
      body["extend"] = request.extend;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
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
      action: "CampusUpdateCampusGroup",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/projects/groups`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusUpdateCampusGroupResponse>(await this.execute(params, req, runtime), new CampusUpdateCampusGroupResponse({}));
  }

  async campusUpdateCampusGroup(request: CampusUpdateCampusGroupRequest): Promise<CampusUpdateCampusGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusUpdateCampusGroupHeaders({ });
    return await this.campusUpdateCampusGroupWithOptions(request, headers, runtime);
  }

  async campusUpdateRenterWithOptions(request: CampusUpdateRenterRequest, headers: CampusUpdateRenterHeaders, runtime: $Util.RuntimeOptions): Promise<CampusUpdateRenterResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creditCode)) {
      body["creditCode"] = request.creditCode;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.extend)) {
      body["extend"] = request.extend;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.renterId)) {
      body["renterId"] = request.renterId;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.state)) {
      body["state"] = request.state;
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
      action: "CampusUpdateRenter",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/renters`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusUpdateRenterResponse>(await this.execute(params, req, runtime), new CampusUpdateRenterResponse({}));
  }

  async campusUpdateRenter(request: CampusUpdateRenterRequest): Promise<CampusUpdateRenterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusUpdateRenterHeaders({ });
    return await this.campusUpdateRenterWithOptions(request, headers, runtime);
  }

  async campusUpdateRenterMemberWithOptions(request: CampusUpdateRenterMemberRequest, headers: CampusUpdateRenterMemberHeaders, runtime: $Util.RuntimeOptions): Promise<CampusUpdateRenterMemberResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.extend)) {
      body["extend"] = request.extend;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.renterId)) {
      body["renterId"] = request.renterId;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "CampusUpdateRenterMember",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/campuses/renters/members`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CampusUpdateRenterMemberResponse>(await this.execute(params, req, runtime), new CampusUpdateRenterMemberResponse({}));
  }

  async campusUpdateRenterMember(request: CampusUpdateRenterMemberRequest): Promise<CampusUpdateRenterMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusUpdateRenterMemberHeaders({ });
    return await this.campusUpdateRenterMemberWithOptions(request, headers, runtime);
  }

  async collegeActiveCollegeDeptGroupWithOptions(request: CollegeActiveCollegeDeptGroupRequest, headers: CollegeActiveCollegeDeptGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeActiveCollegeDeptGroupResponse> {
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
    let params = new $OpenApi.Params({
      action: "CollegeActiveCollegeDeptGroup",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/depts/groups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeActiveCollegeDeptGroupResponse>(await this.execute(params, req, runtime), new CollegeActiveCollegeDeptGroupResponse({}));
  }

  async collegeActiveCollegeDeptGroup(request: CollegeActiveCollegeDeptGroupRequest): Promise<CollegeActiveCollegeDeptGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeActiveCollegeDeptGroupHeaders({ });
    return await this.collegeActiveCollegeDeptGroupWithOptions(request, headers, runtime);
  }

  async collegeAddCollegeDeptWithOptions(request: CollegeAddCollegeDeptRequest, headers: CollegeAddCollegeDeptHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeAddCollegeDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptName)) {
      query["deptName"] = request.deptName;
    }

    if (!Util.isUnset(request.deptType)) {
      query["deptType"] = request.deptType;
    }

    if (!Util.isUnset(request.sortFactor)) {
      query["sortFactor"] = request.sortFactor;
    }

    if (!Util.isUnset(request.superId)) {
      query["superId"] = request.superId;
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
      action: "CollegeAddCollegeDept",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/depts`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeAddCollegeDeptResponse>(await this.execute(params, req, runtime), new CollegeAddCollegeDeptResponse({}));
  }

  async collegeAddCollegeDept(request: CollegeAddCollegeDeptRequest): Promise<CollegeAddCollegeDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeAddCollegeDeptHeaders({ });
    return await this.collegeAddCollegeDeptWithOptions(request, headers, runtime);
  }

  async collegeAddManagerWithOptions(request: CollegeAddManagerRequest, headers: CollegeAddManagerHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeAddManagerResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
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
      action: "CollegeAddManager",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/members/depts/managers`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeAddManagerResponse>(await this.execute(params, req, runtime), new CollegeAddManagerResponse({}));
  }

  async collegeAddManager(request: CollegeAddManagerRequest): Promise<CollegeAddManagerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeAddManagerHeaders({ });
    return await this.collegeAddManagerWithOptions(request, headers, runtime);
  }

  async collegeAddStudentWithOptions(request: CollegeAddStudentRequest, headers: CollegeAddStudentHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeAddStudentResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.empExtension)) {
      body["empExtension"] = request.empExtension;
    }

    if (!Util.isUnset(request.gender)) {
      body["gender"] = request.gender;
    }

    if (!Util.isUnset(request.identifyId)) {
      body["identifyId"] = request.identifyId;
    }

    if (!Util.isUnset(request.mobile)) {
      body["mobile"] = request.mobile;
    }

    if (!Util.isUnset(request.startYear)) {
      body["startYear"] = request.startYear;
    }

    if (!Util.isUnset(request.studentName)) {
      body["studentName"] = request.studentName;
    }

    if (!Util.isUnset(request.studentNumber)) {
      body["studentNumber"] = request.studentNumber;
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
      action: "CollegeAddStudent",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/members/depts/students`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeAddStudentResponse>(await this.execute(params, req, runtime), new CollegeAddStudentResponse({}));
  }

  async collegeAddStudent(request: CollegeAddStudentRequest): Promise<CollegeAddStudentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeAddStudentHeaders({ });
    return await this.collegeAddStudentWithOptions(request, headers, runtime);
  }

  async collegeChangeStudentDeptWithOptions(request: CollegeChangeStudentDeptRequest, headers: CollegeChangeStudentDeptHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeChangeStudentDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.newDeptId)) {
      query["newDeptId"] = request.newDeptId;
    }

    if (!Util.isUnset(request.studentId)) {
      query["studentId"] = request.studentId;
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
      action: "CollegeChangeStudentDept",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/members/depts/students/move`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeChangeStudentDeptResponse>(await this.execute(params, req, runtime), new CollegeChangeStudentDeptResponse({}));
  }

  async collegeChangeStudentDept(request: CollegeChangeStudentDeptRequest): Promise<CollegeChangeStudentDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeChangeStudentDeptHeaders({ });
    return await this.collegeChangeStudentDeptWithOptions(request, headers, runtime);
  }

  async collegeDeleteCollegeDeptWithOptions(request: CollegeDeleteCollegeDeptRequest, headers: CollegeDeleteCollegeDeptHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeDeleteCollegeDeptResponse> {
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
    let params = new $OpenApi.Params({
      action: "CollegeDeleteCollegeDept",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/depts`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeDeleteCollegeDeptResponse>(await this.execute(params, req, runtime), new CollegeDeleteCollegeDeptResponse({}));
  }

  async collegeDeleteCollegeDept(request: CollegeDeleteCollegeDeptRequest): Promise<CollegeDeleteCollegeDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeDeleteCollegeDeptHeaders({ });
    return await this.collegeDeleteCollegeDeptWithOptions(request, headers, runtime);
  }

  async collegeListCollegeSubDeptWithOptions(request: CollegeListCollegeSubDeptRequest, headers: CollegeListCollegeSubDeptHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeListCollegeSubDeptResponse> {
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
    let params = new $OpenApi.Params({
      action: "CollegeListCollegeSubDept",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/subDepts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeListCollegeSubDeptResponse>(await this.execute(params, req, runtime), new CollegeListCollegeSubDeptResponse({}));
  }

  async collegeListCollegeSubDept(request: CollegeListCollegeSubDeptRequest): Promise<CollegeListCollegeSubDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeListCollegeSubDeptHeaders({ });
    return await this.collegeListCollegeSubDeptWithOptions(request, headers, runtime);
  }

  async collegeListDeptManagerWithOptions(request: CollegeListDeptManagerRequest, headers: CollegeListDeptManagerHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeListDeptManagerResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

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
    let params = new $OpenApi.Params({
      action: "CollegeListDeptManager",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/members/depts/managers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeListDeptManagerResponse>(await this.execute(params, req, runtime), new CollegeListDeptManagerResponse({}));
  }

  async collegeListDeptManager(request: CollegeListDeptManagerRequest): Promise<CollegeListDeptManagerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeListDeptManagerHeaders({ });
    return await this.collegeListDeptManagerWithOptions(request, headers, runtime);
  }

  async collegeListStudentInfoWithOptions(request: CollegeListStudentInfoRequest, headers: CollegeListStudentInfoHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeListStudentInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.dingStudentStatus)) {
      query["dingStudentStatus"] = request.dingStudentStatus;
    }

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
    let params = new $OpenApi.Params({
      action: "CollegeListStudentInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/members/depts/students`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeListStudentInfoResponse>(await this.execute(params, req, runtime), new CollegeListStudentInfoResponse({}));
  }

  async collegeListStudentInfo(request: CollegeListStudentInfoRequest): Promise<CollegeListStudentInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeListStudentInfoHeaders({ });
    return await this.collegeListStudentInfoWithOptions(request, headers, runtime);
  }

  async collegeListUncheckedStudentWithOptions(request: CollegeListUncheckedStudentRequest, headers: CollegeListUncheckedStudentHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeListUncheckedStudentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

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
    let params = new $OpenApi.Params({
      action: "CollegeListUncheckedStudent",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/members/organizations/unjoinedStudents`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeListUncheckedStudentResponse>(await this.execute(params, req, runtime), new CollegeListUncheckedStudentResponse({}));
  }

  async collegeListUncheckedStudent(request: CollegeListUncheckedStudentRequest): Promise<CollegeListUncheckedStudentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeListUncheckedStudentHeaders({ });
    return await this.collegeListUncheckedStudentWithOptions(request, headers, runtime);
  }

  async collegeQueryCollegeDeptGroupInfoWithOptions(request: CollegeQueryCollegeDeptGroupInfoRequest, headers: CollegeQueryCollegeDeptGroupInfoHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeQueryCollegeDeptGroupInfoResponse> {
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
    let params = new $OpenApi.Params({
      action: "CollegeQueryCollegeDeptGroupInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/depts/groupInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeQueryCollegeDeptGroupInfoResponse>(await this.execute(params, req, runtime), new CollegeQueryCollegeDeptGroupInfoResponse({}));
  }

  async collegeQueryCollegeDeptGroupInfo(request: CollegeQueryCollegeDeptGroupInfoRequest): Promise<CollegeQueryCollegeDeptGroupInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeQueryCollegeDeptGroupInfoHeaders({ });
    return await this.collegeQueryCollegeDeptGroupInfoWithOptions(request, headers, runtime);
  }

  async collegeQueryCollegeDeptInfoWithOptions(request: CollegeQueryCollegeDeptInfoRequest, headers: CollegeQueryCollegeDeptInfoHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeQueryCollegeDeptInfoResponse> {
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
    let params = new $OpenApi.Params({
      action: "CollegeQueryCollegeDeptInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/deptInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeQueryCollegeDeptInfoResponse>(await this.execute(params, req, runtime), new CollegeQueryCollegeDeptInfoResponse({}));
  }

  async collegeQueryCollegeDeptInfo(request: CollegeQueryCollegeDeptInfoRequest): Promise<CollegeQueryCollegeDeptInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeQueryCollegeDeptInfoHeaders({ });
    return await this.collegeQueryCollegeDeptInfoWithOptions(request, headers, runtime);
  }

  async collegeQueryStudentInfoByDeptWithOptions(request: CollegeQueryStudentInfoByDeptRequest, headers: CollegeQueryStudentInfoByDeptHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeQueryStudentInfoByDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.studentId)) {
      query["studentId"] = request.studentId;
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
      action: "CollegeQueryStudentInfoByDept",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/members/depts/studentinfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeQueryStudentInfoByDeptResponse>(await this.execute(params, req, runtime), new CollegeQueryStudentInfoByDeptResponse({}));
  }

  async collegeQueryStudentInfoByDept(request: CollegeQueryStudentInfoByDeptRequest): Promise<CollegeQueryStudentInfoByDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeQueryStudentInfoByDeptHeaders({ });
    return await this.collegeQueryStudentInfoByDeptWithOptions(request, headers, runtime);
  }

  async collegeQueryStudentInfoByMobileWithOptions(request: CollegeQueryStudentInfoByMobileRequest, headers: CollegeQueryStudentInfoByMobileHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeQueryStudentInfoByMobileResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mobile)) {
      query["mobile"] = request.mobile;
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
      action: "CollegeQueryStudentInfoByMobile",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/members/students/mobiles`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeQueryStudentInfoByMobileResponse>(await this.execute(params, req, runtime), new CollegeQueryStudentInfoByMobileResponse({}));
  }

  async collegeQueryStudentInfoByMobile(request: CollegeQueryStudentInfoByMobileRequest): Promise<CollegeQueryStudentInfoByMobileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeQueryStudentInfoByMobileHeaders({ });
    return await this.collegeQueryStudentInfoByMobileWithOptions(request, headers, runtime);
  }

  async collegeQueryStudentInfoByStudentIdWithOptions(request: CollegeQueryStudentInfoByStudentIdRequest, headers: CollegeQueryStudentInfoByStudentIdHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeQueryStudentInfoByStudentIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.studentId)) {
      query["studentId"] = request.studentId;
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
      action: "CollegeQueryStudentInfoByStudentId",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/members/students`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeQueryStudentInfoByStudentIdResponse>(await this.execute(params, req, runtime), new CollegeQueryStudentInfoByStudentIdResponse({}));
  }

  async collegeQueryStudentInfoByStudentId(request: CollegeQueryStudentInfoByStudentIdRequest): Promise<CollegeQueryStudentInfoByStudentIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeQueryStudentInfoByStudentIdHeaders({ });
    return await this.collegeQueryStudentInfoByStudentIdWithOptions(request, headers, runtime);
  }

  async collegeRemoveManagerWithOptions(request: CollegeRemoveManagerRequest, headers: CollegeRemoveManagerHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeRemoveManagerResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.isForce)) {
      query["isForce"] = request.isForce;
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
      action: "CollegeRemoveManager",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/members/managers`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeRemoveManagerResponse>(await this.execute(params, req, runtime), new CollegeRemoveManagerResponse({}));
  }

  async collegeRemoveManager(request: CollegeRemoveManagerRequest): Promise<CollegeRemoveManagerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeRemoveManagerHeaders({ });
    return await this.collegeRemoveManagerWithOptions(request, headers, runtime);
  }

  async collegeRemoveStudentWithOptions(request: CollegeRemoveStudentRequest, headers: CollegeRemoveStudentHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeRemoveStudentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.studentId)) {
      query["studentId"] = request.studentId;
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
      action: "CollegeRemoveStudent",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/members/depts/students`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeRemoveStudentResponse>(await this.execute(params, req, runtime), new CollegeRemoveStudentResponse({}));
  }

  async collegeRemoveStudent(request: CollegeRemoveStudentRequest): Promise<CollegeRemoveStudentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeRemoveStudentHeaders({ });
    return await this.collegeRemoveStudentWithOptions(request, headers, runtime);
  }

  async collegeUpdateCollegeDeptWithOptions(request: CollegeUpdateCollegeDeptRequest, headers: CollegeUpdateCollegeDeptHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeUpdateCollegeDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.deptName)) {
      query["deptName"] = request.deptName;
    }

    if (!Util.isUnset(request.sortFactor)) {
      query["sortFactor"] = request.sortFactor;
    }

    if (!Util.isUnset(request.superId)) {
      query["superId"] = request.superId;
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
      action: "CollegeUpdateCollegeDept",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/depts`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeUpdateCollegeDeptResponse>(await this.execute(params, req, runtime), new CollegeUpdateCollegeDeptResponse({}));
  }

  async collegeUpdateCollegeDept(request: CollegeUpdateCollegeDeptRequest): Promise<CollegeUpdateCollegeDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeUpdateCollegeDeptHeaders({ });
    return await this.collegeUpdateCollegeDeptWithOptions(request, headers, runtime);
  }

  async collegeUpdateStudentDeptInfoWithOptions(request: CollegeUpdateStudentDeptInfoRequest, headers: CollegeUpdateStudentDeptInfoHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeUpdateStudentDeptInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.studentId)) {
      query["studentId"] = request.studentId;
    }

    if (!Util.isUnset(request.studentNumber)) {
      query["studentNumber"] = request.studentNumber;
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
      action: "CollegeUpdateStudentDeptInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/members/deptInfos`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeUpdateStudentDeptInfoResponse>(await this.execute(params, req, runtime), new CollegeUpdateStudentDeptInfoResponse({}));
  }

  async collegeUpdateStudentDeptInfo(request: CollegeUpdateStudentDeptInfoRequest): Promise<CollegeUpdateStudentDeptInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeUpdateStudentDeptInfoHeaders({ });
    return await this.collegeUpdateStudentDeptInfoWithOptions(request, headers, runtime);
  }

  async collegeUpdateStudentInfoWithOptions(request: CollegeUpdateStudentInfoRequest, headers: CollegeUpdateStudentInfoHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeUpdateStudentInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.empExtension)) {
      body["empExtension"] = request.empExtension;
    }

    if (!Util.isUnset(request.gender)) {
      body["gender"] = request.gender;
    }

    if (!Util.isUnset(request.identifyId)) {
      body["identifyId"] = request.identifyId;
    }

    if (!Util.isUnset(request.startYear)) {
      body["startYear"] = request.startYear;
    }

    if (!Util.isUnset(request.studentId)) {
      body["studentId"] = request.studentId;
    }

    if (!Util.isUnset(request.studentName)) {
      body["studentName"] = request.studentName;
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
      action: "CollegeUpdateStudentInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/members/depts/students`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeUpdateStudentInfoResponse>(await this.execute(params, req, runtime), new CollegeUpdateStudentInfoResponse({}));
  }

  async collegeUpdateStudentInfo(request: CollegeUpdateStudentInfoRequest): Promise<CollegeUpdateStudentInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeUpdateStudentInfoHeaders({ });
    return await this.collegeUpdateStudentInfoWithOptions(request, headers, runtime);
  }

  async collegeUpdateStudentMoblieWithOptions(request: CollegeUpdateStudentMoblieRequest, headers: CollegeUpdateStudentMoblieHeaders, runtime: $Util.RuntimeOptions): Promise<CollegeUpdateStudentMoblieResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isForce)) {
      query["isForce"] = request.isForce;
    }

    if (!Util.isUnset(request.newMobile)) {
      query["newMobile"] = request.newMobile;
    }

    if (!Util.isUnset(request.studentId)) {
      query["studentId"] = request.studentId;
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
      action: "CollegeUpdateStudentMoblie",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/colleges/members/students/mobiles`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollegeUpdateStudentMoblieResponse>(await this.execute(params, req, runtime), new CollegeUpdateStudentMoblieResponse({}));
  }

  async collegeUpdateStudentMoblie(request: CollegeUpdateStudentMoblieRequest): Promise<CollegeUpdateStudentMoblieResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollegeUpdateStudentMoblieHeaders({ });
    return await this.collegeUpdateStudentMoblieWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CustomizeContactCreate",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/customizations/contacts`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CustomizeContactCreateResponse>(await this.execute(params, req, runtime), new CustomizeContactCreateResponse({}));
  }

  async customizeContactCreate(request: CustomizeContactCreateRequest): Promise<CustomizeContactCreateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactCreateHeaders({ });
    return await this.customizeContactCreateWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CustomizeContactDelete",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/customizations/contacts`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CustomizeContactDeleteResponse>(await this.execute(params, req, runtime), new CustomizeContactDeleteResponse({}));
  }

  async customizeContactDelete(request: CustomizeContactDeleteRequest): Promise<CustomizeContactDeleteResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactDeleteHeaders({ });
    return await this.customizeContactDeleteWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CustomizeContactDeptCreate",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/customizations/departments`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CustomizeContactDeptCreateResponse>(await this.execute(params, req, runtime), new CustomizeContactDeptCreateResponse({}));
  }

  async customizeContactDeptCreate(request: CustomizeContactDeptCreateRequest): Promise<CustomizeContactDeptCreateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactDeptCreateHeaders({ });
    return await this.customizeContactDeptCreateWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CustomizeContactDeptDelete",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/customizations/departments`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CustomizeContactDeptDeleteResponse>(await this.execute(params, req, runtime), new CustomizeContactDeptDeleteResponse({}));
  }

  async customizeContactDeptDelete(request: CustomizeContactDeptDeleteRequest): Promise<CustomizeContactDeptDeleteResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactDeptDeleteHeaders({ });
    return await this.customizeContactDeptDeleteWithOptions(request, headers, runtime);
  }

  async customizeContactDeptGroupCreateWithOptions(request: CustomizeContactDeptGroupCreateRequest, headers: CustomizeContactDeptGroupCreateHeaders, runtime: $Util.RuntimeOptions): Promise<CustomizeContactDeptGroupCreateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      body["code"] = request.code;
    }

    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
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
      action: "CustomizeContactDeptGroupCreate",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/customizations/departmentGroups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CustomizeContactDeptGroupCreateResponse>(await this.execute(params, req, runtime), new CustomizeContactDeptGroupCreateResponse({}));
  }

  async customizeContactDeptGroupCreate(request: CustomizeContactDeptGroupCreateRequest): Promise<CustomizeContactDeptGroupCreateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactDeptGroupCreateHeaders({ });
    return await this.customizeContactDeptGroupCreateWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CustomizeContactDeptInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/customizations/departments`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CustomizeContactDeptInfoResponse>(await this.execute(params, req, runtime), new CustomizeContactDeptInfoResponse({}));
  }

  async customizeContactDeptInfo(request: CustomizeContactDeptInfoRequest): Promise<CustomizeContactDeptInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactDeptInfoHeaders({ });
    return await this.customizeContactDeptInfoWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CustomizeContactDeptList",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/customizations/subsidiaryDepartments`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CustomizeContactDeptListResponse>(await this.execute(params, req, runtime), new CustomizeContactDeptListResponse({}));
  }

  async customizeContactDeptList(request: CustomizeContactDeptListRequest): Promise<CustomizeContactDeptListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactDeptListHeaders({ });
    return await this.customizeContactDeptListWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CustomizeContactDeptUpdate",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/customizations/departments`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CustomizeContactDeptUpdateResponse>(await this.execute(params, req, runtime), new CustomizeContactDeptUpdateResponse({}));
  }

  async customizeContactDeptUpdate(request: CustomizeContactDeptUpdateRequest): Promise<CustomizeContactDeptUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactDeptUpdateHeaders({ });
    return await this.customizeContactDeptUpdateWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CustomizeContactEmpAdd",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/customizations/users`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CustomizeContactEmpAddResponse>(await this.execute(params, req, runtime), new CustomizeContactEmpAddResponse({}));
  }

  async customizeContactEmpAdd(request: CustomizeContactEmpAddRequest): Promise<CustomizeContactEmpAddResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactEmpAddHeaders({ });
    return await this.customizeContactEmpAddWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CustomizeContactEmpDelete",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/customizations/users/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CustomizeContactEmpDeleteResponse>(await this.execute(params, req, runtime), new CustomizeContactEmpDeleteResponse({}));
  }

  async customizeContactEmpDelete(request: CustomizeContactEmpDeleteRequest): Promise<CustomizeContactEmpDeleteResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactEmpDeleteHeaders({ });
    return await this.customizeContactEmpDeleteWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CustomizeContactEmpList",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/customizations/users`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CustomizeContactEmpListResponse>(await this.execute(params, req, runtime), new CustomizeContactEmpListResponse({}));
  }

  async customizeContactEmpList(request: CustomizeContactEmpListRequest): Promise<CustomizeContactEmpListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactEmpListHeaders({ });
    return await this.customizeContactEmpListWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CustomizeContactList",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/customizations/contacts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CustomizeContactListResponse>(await this.execute(params, req, runtime), new CustomizeContactListResponse({}));
  }

  async customizeContactList(): Promise<CustomizeContactListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactListHeaders({ });
    return await this.customizeContactListWithOptions(headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CustomizeContactUpdate",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/customizations/contacts`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CustomizeContactUpdateResponse>(await this.execute(params, req, runtime), new CustomizeContactUpdateResponse({}));
  }

  async customizeContactUpdate(request: CustomizeContactUpdateRequest): Promise<CustomizeContactUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomizeContactUpdateHeaders({ });
    return await this.customizeContactUpdateWithOptions(request, headers, runtime);
  }

  async dIgitalStoreMessagePushWithOptions(tmpReq: DIgitalStoreMessagePushRequest, headers: DIgitalStoreMessagePushHeaders, runtime: $Util.RuntimeOptions): Promise<DIgitalStoreMessagePushResponse> {
    Util.validateModel(tmpReq);
    let request = new DIgitalStoreMessagePushShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.messageDataList)) {
      request.messageDataListShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.messageDataList, "messageDataList", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.messageDataListShrink)) {
      query["messageDataList"] = request.messageDataListShrink;
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
      action: "DIgitalStoreMessagePush",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/messages/push`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DIgitalStoreMessagePushResponse>(await this.execute(params, req, runtime), new DIgitalStoreMessagePushResponse({}));
  }

  async dIgitalStoreMessagePush(request: DIgitalStoreMessagePushRequest): Promise<DIgitalStoreMessagePushResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DIgitalStoreMessagePushHeaders({ });
    return await this.dIgitalStoreMessagePushWithOptions(request, headers, runtime);
  }

  async digitalStoreCardRecordWithOptions(request: DigitalStoreCardRecordRequest, headers: DigitalStoreCardRecordHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStoreCardRecordResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.beginTime)) {
      body["beginTime"] = request.beginTime;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.ids)) {
      body["ids"] = request.ids;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.sceneCardName)) {
      body["sceneCardName"] = request.sceneCardName;
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
      action: "DigitalStoreCardRecord",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/cardSendRecords/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStoreCardRecordResponse>(await this.execute(params, req, runtime), new DigitalStoreCardRecordResponse({}));
  }

  async digitalStoreCardRecord(request: DigitalStoreCardRecordRequest): Promise<DigitalStoreCardRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreCardRecordHeaders({ });
    return await this.digitalStoreCardRecordWithOptions(request, headers, runtime);
  }

  async digitalStoreContactInfoWithOptions(headers: DigitalStoreContactInfoHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStoreContactInfoResponse> {
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
      action: "DigitalStoreContactInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/contactInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStoreContactInfoResponse>(await this.execute(params, req, runtime), new DigitalStoreContactInfoResponse({}));
  }

  async digitalStoreContactInfo(): Promise<DigitalStoreContactInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreContactInfoHeaders({ });
    return await this.digitalStoreContactInfoWithOptions(headers, runtime);
  }

  async digitalStoreConversationsWithOptions(request: DigitalStoreConversationsRequest, headers: DigitalStoreConversationsHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStoreConversationsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationTitle)) {
      query["conversationTitle"] = request.conversationTitle;
    }

    if (!Util.isUnset(request.conversationType)) {
      query["conversationType"] = request.conversationType;
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
      action: "DigitalStoreConversations",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/conversations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStoreConversationsResponse>(await this.execute(params, req, runtime), new DigitalStoreConversationsResponse({}));
  }

  async digitalStoreConversations(request: DigitalStoreConversationsRequest): Promise<DigitalStoreConversationsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreConversationsHeaders({ });
    return await this.digitalStoreConversationsWithOptions(request, headers, runtime);
  }

  async digitalStoreExportCardRecordWithOptions(request: DigitalStoreExportCardRecordRequest, headers: DigitalStoreExportCardRecordHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStoreExportCardRecordResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.beginTime)) {
      body["beginTime"] = request.beginTime;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.ids)) {
      body["ids"] = request.ids;
    }

    if (!Util.isUnset(request.sceneCardName)) {
      body["sceneCardName"] = request.sceneCardName;
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
      action: "DigitalStoreExportCardRecord",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/cardRecords/export`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStoreExportCardRecordResponse>(await this.execute(params, req, runtime), new DigitalStoreExportCardRecordResponse({}));
  }

  async digitalStoreExportCardRecord(request: DigitalStoreExportCardRecordRequest): Promise<DigitalStoreExportCardRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreExportCardRecordHeaders({ });
    return await this.digitalStoreExportCardRecordWithOptions(request, headers, runtime);
  }

  async digitalStoreExportCardRecordDetailWithOptions(request: DigitalStoreExportCardRecordDetailRequest, headers: DigitalStoreExportCardRecordDetailHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStoreExportCardRecordDetailResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.beginTime)) {
      body["beginTime"] = request.beginTime;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.ids)) {
      body["ids"] = request.ids;
    }

    if (!Util.isUnset(request.sceneCardName)) {
      body["sceneCardName"] = request.sceneCardName;
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
      action: "DigitalStoreExportCardRecordDetail",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/cardRecordDetails/export`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStoreExportCardRecordDetailResponse>(await this.execute(params, req, runtime), new DigitalStoreExportCardRecordDetailResponse({}));
  }

  async digitalStoreExportCardRecordDetail(request: DigitalStoreExportCardRecordDetailRequest): Promise<DigitalStoreExportCardRecordDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreExportCardRecordDetailHeaders({ });
    return await this.digitalStoreExportCardRecordDetailWithOptions(request, headers, runtime);
  }

  async digitalStoreGroupInfoWithOptions(request: DigitalStoreGroupInfoRequest, headers: DigitalStoreGroupInfoHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStoreGroupInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupId)) {
      query["groupId"] = request.groupId;
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
      action: "DigitalStoreGroupInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/groupInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStoreGroupInfoResponse>(await this.execute(params, req, runtime), new DigitalStoreGroupInfoResponse({}));
  }

  async digitalStoreGroupInfo(request: DigitalStoreGroupInfoRequest): Promise<DigitalStoreGroupInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreGroupInfoHeaders({ });
    return await this.digitalStoreGroupInfoWithOptions(request, headers, runtime);
  }

  async digitalStoreGroupsWithOptions(headers: DigitalStoreGroupsHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStoreGroupsResponse> {
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
      action: "DigitalStoreGroups",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/groups`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStoreGroupsResponse>(await this.execute(params, req, runtime), new DigitalStoreGroupsResponse({}));
  }

  async digitalStoreGroups(): Promise<DigitalStoreGroupsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreGroupsHeaders({ });
    return await this.digitalStoreGroupsWithOptions(headers, runtime);
  }

  async digitalStoreNodeInfoWithOptions(request: DigitalStoreNodeInfoRequest, headers: DigitalStoreNodeInfoHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStoreNodeInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
    }

    if (!Util.isUnset(request.nodeId)) {
      query["nodeId"] = request.nodeId;
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
      action: "DigitalStoreNodeInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/nodeInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStoreNodeInfoResponse>(await this.execute(params, req, runtime), new DigitalStoreNodeInfoResponse({}));
  }

  async digitalStoreNodeInfo(request: DigitalStoreNodeInfoRequest): Promise<DigitalStoreNodeInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreNodeInfoHeaders({ });
    return await this.digitalStoreNodeInfoWithOptions(request, headers, runtime);
  }

  async digitalStoreRightsInfoWithOptions(headers: DigitalStoreRightsInfoHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStoreRightsInfoResponse> {
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
      action: "DigitalStoreRightsInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/rightsInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStoreRightsInfoResponse>(await this.execute(params, req, runtime), new DigitalStoreRightsInfoResponse({}));
  }

  async digitalStoreRightsInfo(): Promise<DigitalStoreRightsInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreRightsInfoHeaders({ });
    return await this.digitalStoreRightsInfoWithOptions(headers, runtime);
  }

  async digitalStoreRolesWithOptions(headers: DigitalStoreRolesHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStoreRolesResponse> {
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
      action: "DigitalStoreRoles",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/roles`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStoreRolesResponse>(await this.execute(params, req, runtime), new DigitalStoreRolesResponse({}));
  }

  async digitalStoreRoles(): Promise<DigitalStoreRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreRolesHeaders({ });
    return await this.digitalStoreRolesWithOptions(headers, runtime);
  }

  async digitalStoreSceneScopeWithOptions(request: DigitalStoreSceneScopeRequest, headers: DigitalStoreSceneScopeHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStoreSceneScopeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      query["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.sceneCode)) {
      query["sceneCode"] = request.sceneCode;
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
      action: "DigitalStoreSceneScope",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/sceneScopes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStoreSceneScopeResponse>(await this.execute(params, req, runtime), new DigitalStoreSceneScopeResponse({}));
  }

  async digitalStoreSceneScope(request: DigitalStoreSceneScopeRequest): Promise<DigitalStoreSceneScopeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreSceneScopeHeaders({ });
    return await this.digitalStoreSceneScopeWithOptions(request, headers, runtime);
  }

  async digitalStoreStoreInfoWithOptions(request: DigitalStoreStoreInfoRequest, headers: DigitalStoreStoreInfoHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStoreStoreInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
    }

    if (!Util.isUnset(request.storeId)) {
      query["storeId"] = request.storeId;
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
      action: "DigitalStoreStoreInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/storeInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStoreStoreInfoResponse>(await this.execute(params, req, runtime), new DigitalStoreStoreInfoResponse({}));
  }

  async digitalStoreStoreInfo(request: DigitalStoreStoreInfoRequest): Promise<DigitalStoreStoreInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreStoreInfoHeaders({ });
    return await this.digitalStoreStoreInfoWithOptions(request, headers, runtime);
  }

  async digitalStoreSubNodesWithOptions(request: DigitalStoreSubNodesRequest, headers: DigitalStoreSubNodesHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStoreSubNodesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
    }

    if (!Util.isUnset(request.nodeId)) {
      query["nodeId"] = request.nodeId;
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
      action: "DigitalStoreSubNodes",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/subsidiaryNodes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStoreSubNodesResponse>(await this.execute(params, req, runtime), new DigitalStoreSubNodesResponse({}));
  }

  async digitalStoreSubNodes(request: DigitalStoreSubNodesRequest): Promise<DigitalStoreSubNodesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreSubNodesHeaders({ });
    return await this.digitalStoreSubNodesWithOptions(request, headers, runtime);
  }

  async digitalStoreUpdateAuthInfoWithOptions(request: DigitalStoreUpdateAuthInfoRequest, headers: DigitalStoreUpdateAuthInfoHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStoreUpdateAuthInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.updateUserList)) {
      body["updateUserList"] = request.updateUserList;
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
      action: "DigitalStoreUpdateAuthInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/authInfos`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStoreUpdateAuthInfoResponse>(await this.execute(params, req, runtime), new DigitalStoreUpdateAuthInfoResponse({}));
  }

  async digitalStoreUpdateAuthInfo(request: DigitalStoreUpdateAuthInfoRequest): Promise<DigitalStoreUpdateAuthInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreUpdateAuthInfoHeaders({ });
    return await this.digitalStoreUpdateAuthInfoWithOptions(request, headers, runtime);
  }

  async digitalStoreUserInfoWithOptions(request: DigitalStoreUserInfoRequest, headers: DigitalStoreUserInfoHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStoreUserInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
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
      action: "DigitalStoreUserInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/userInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStoreUserInfoResponse>(await this.execute(params, req, runtime), new DigitalStoreUserInfoResponse({}));
  }

  async digitalStoreUserInfo(request: DigitalStoreUserInfoRequest): Promise<DigitalStoreUserInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreUserInfoHeaders({ });
    return await this.digitalStoreUserInfoWithOptions(request, headers, runtime);
  }

  async digitalStoreUsersWithOptions(request: DigitalStoreUsersRequest, headers: DigitalStoreUsersHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStoreUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
    }

    if (!Util.isUnset(request.nodeId)) {
      query["nodeId"] = request.nodeId;
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
      action: "DigitalStoreUsers",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/nodes/users`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStoreUsersResponse>(await this.execute(params, req, runtime), new DigitalStoreUsersResponse({}));
  }

  async digitalStoreUsers(request: DigitalStoreUsersRequest): Promise<DigitalStoreUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreUsersHeaders({ });
    return await this.digitalStoreUsersWithOptions(request, headers, runtime);
  }

  async digitalStorelistExportTaskRecordWithOptions(request: DigitalStorelistExportTaskRecordRequest, headers: DigitalStorelistExportTaskRecordHeaders, runtime: $Util.RuntimeOptions): Promise<DigitalStorelistExportTaskRecordResponse> {
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
    let params = new $OpenApi.Params({
      action: "DigitalStorelistExportTaskRecord",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/digitalStores/exportTaskRecords`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DigitalStorelistExportTaskRecordResponse>(await this.execute(params, req, runtime), new DigitalStorelistExportTaskRecordResponse({}));
  }

  async digitalStorelistExportTaskRecord(request: DigitalStorelistExportTaskRecordRequest): Promise<DigitalStorelistExportTaskRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStorelistExportTaskRecordHeaders({ });
    return await this.digitalStorelistExportTaskRecordWithOptions(request, headers, runtime);
  }

  async externalQueryExternalAppOrgsWithOptions(request: ExternalQueryExternalAppOrgsRequest, headers: ExternalQueryExternalAppOrgsHeaders, runtime: $Util.RuntimeOptions): Promise<ExternalQueryExternalAppOrgsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.externalType)) {
      query["externalType"] = request.externalType;
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
      action: "ExternalQueryExternalAppOrgs",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/externals/apps/organizations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ExternalQueryExternalAppOrgsResponse>(await this.execute(params, req, runtime), new ExternalQueryExternalAppOrgsResponse({}));
  }

  async externalQueryExternalAppOrgs(request: ExternalQueryExternalAppOrgsRequest): Promise<ExternalQueryExternalAppOrgsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExternalQueryExternalAppOrgsHeaders({ });
    return await this.externalQueryExternalAppOrgsWithOptions(request, headers, runtime);
  }

  async externalQueryExternalBelongMainOrgWithOptions(request: ExternalQueryExternalBelongMainOrgRequest, headers: ExternalQueryExternalBelongMainOrgHeaders, runtime: $Util.RuntimeOptions): Promise<ExternalQueryExternalBelongMainOrgResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.externalType)) {
      query["externalType"] = request.externalType;
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
      action: "ExternalQueryExternalBelongMainOrg",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/externals/attributions/masterOrganizations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ExternalQueryExternalBelongMainOrgResponse>(await this.execute(params, req, runtime), new ExternalQueryExternalBelongMainOrgResponse({}));
  }

  async externalQueryExternalBelongMainOrg(request: ExternalQueryExternalBelongMainOrgRequest): Promise<ExternalQueryExternalBelongMainOrgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExternalQueryExternalBelongMainOrgHeaders({ });
    return await this.externalQueryExternalBelongMainOrgWithOptions(request, headers, runtime);
  }

  async externalQueryExternalOrgsWithOptions(request: ExternalQueryExternalOrgsRequest, headers: ExternalQueryExternalOrgsHeaders, runtime: $Util.RuntimeOptions): Promise<ExternalQueryExternalOrgsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.externalType)) {
      query["externalType"] = request.externalType;
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
      action: "ExternalQueryExternalOrgs",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/externals/organizations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ExternalQueryExternalOrgsResponse>(await this.execute(params, req, runtime), new ExternalQueryExternalOrgsResponse({}));
  }

  async externalQueryExternalOrgs(request: ExternalQueryExternalOrgsRequest): Promise<ExternalQueryExternalOrgsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExternalQueryExternalOrgsHeaders({ });
    return await this.externalQueryExternalOrgsWithOptions(request, headers, runtime);
  }

  async hospitalDataCheckWithOptions(request: HospitalDataCheckRequest, headers: HospitalDataCheckHeaders, runtime: $Util.RuntimeOptions): Promise<HospitalDataCheckResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.allDeptCount)) {
      body["allDeptCount"] = request.allDeptCount;
    }

    if (!Util.isUnset(request.allDeptUserCount)) {
      body["allDeptUserCount"] = request.allDeptUserCount;
    }

    if (!Util.isUnset(request.allGroupCount)) {
      body["allGroupCount"] = request.allGroupCount;
    }

    if (!Util.isUnset(request.allGroupUserCount)) {
      body["allGroupUserCount"] = request.allGroupUserCount;
    }

    if (!Util.isUnset(request.deptCount)) {
      body["deptCount"] = request.deptCount;
    }

    if (!Util.isUnset(request.deptUserCount)) {
      body["deptUserCount"] = request.deptUserCount;
    }

    if (!Util.isUnset(request.groupCount)) {
      body["groupCount"] = request.groupCount;
    }

    if (!Util.isUnset(request.groupUserCount)) {
      body["groupUserCount"] = request.groupUserCount;
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
      action: "HospitalDataCheck",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/datas/check`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HospitalDataCheckResponse>(await this.execute(params, req, runtime), new HospitalDataCheckResponse({}));
  }

  async hospitalDataCheck(request: HospitalDataCheckRequest): Promise<HospitalDataCheckResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HospitalDataCheckHeaders({ });
    return await this.hospitalDataCheckWithOptions(request, headers, runtime);
  }

  async industryManufactureCommonEventWithOptions(request: IndustryManufactureCommonEventRequest, headers: IndustryManufactureCommonEventHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureCommonEventResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.appKey)) {
      body["appKey"] = request.appKey;
    }

    if (!Util.isUnset(request.bizData)) {
      body["bizData"] = request.bizData;
    }

    if (!Util.isUnset(request.eventType)) {
      body["eventType"] = request.eventType;
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
      action: "IndustryManufactureCommonEvent",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/manufacturing/bases/commons/events`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IndustryManufactureCommonEventResponse>(await this.execute(params, req, runtime), new IndustryManufactureCommonEventResponse({}));
  }

  async industryManufactureCommonEvent(request: IndustryManufactureCommonEventRequest): Promise<IndustryManufactureCommonEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureCommonEventHeaders({ });
    return await this.industryManufactureCommonEventWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "IndustryManufactureCostRecordListGet",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/manufactures/materialCostRecords/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IndustryManufactureCostRecordListGetResponse>(await this.execute(params, req, runtime), new IndustryManufactureCostRecordListGetResponse({}));
  }

  async industryManufactureCostRecordListGet(request: IndustryManufactureCostRecordListGetRequest): Promise<IndustryManufactureCostRecordListGetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureCostRecordListGetHeaders({ });
    return await this.industryManufactureCostRecordListGetWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "IndustryManufactureFeeListGet",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/manufactures/fees/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IndustryManufactureFeeListGetResponse>(await this.execute(params, req, runtime), new IndustryManufactureFeeListGetResponse({}));
  }

  async industryManufactureFeeListGet(request: IndustryManufactureFeeListGetRequest): Promise<IndustryManufactureFeeListGetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureFeeListGetHeaders({ });
    return await this.industryManufactureFeeListGetWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "IndustryManufactureLabourCost",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/manufactures/labourCosts/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IndustryManufactureLabourCostResponse>(await this.execute(params, req, runtime), new IndustryManufactureLabourCostResponse({}));
  }

  async industryManufactureLabourCost(request: IndustryManufactureLabourCostRequest): Promise<IndustryManufactureLabourCostResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureLabourCostHeaders({ });
    return await this.industryManufactureLabourCostWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "IndustryManufactureMaterialList",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/manufactures/materials/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IndustryManufactureMaterialListResponse>(await this.execute(params, req, runtime), new IndustryManufactureMaterialListResponse({}));
  }

  async industryManufactureMaterialList(request: IndustryManufactureMaterialListRequest): Promise<IndustryManufactureMaterialListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMaterialListHeaders({ });
    return await this.industryManufactureMaterialListWithOptions(request, headers, runtime);
  }

  async industryManufactureMesDispatchTaskWithOptions(request: IndustryManufactureMesDispatchTaskRequest, headers: IndustryManufactureMesDispatchTaskHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureMesDispatchTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.appKey)) {
      body["appKey"] = request.appKey;
    }

    if (!Util.isUnset(request.baseDataName)) {
      body["baseDataName"] = request.baseDataName;
    }

    if (!Util.isUnset(request.defectsAmount)) {
      body["defectsAmount"] = request.defectsAmount;
    }

    if (!Util.isUnset(request.dispatchStaffName)) {
      body["dispatchStaffName"] = request.dispatchStaffName;
    }

    if (!Util.isUnset(request.dispatchStaffNo)) {
      body["dispatchStaffNo"] = request.dispatchStaffNo;
    }

    if (!Util.isUnset(request.fineAmount)) {
      body["fineAmount"] = request.fineAmount;
    }

    if (!Util.isUnset(request.overdue)) {
      body["overdue"] = request.overdue;
    }

    if (!Util.isUnset(request.planQuantity)) {
      body["planQuantity"] = request.planQuantity;
    }

    if (!Util.isUnset(request.priority)) {
      body["priority"] = request.priority;
    }

    if (!Util.isUnset(request.processName)) {
      body["processName"] = request.processName;
    }

    if (!Util.isUnset(request.processUuid)) {
      body["processUuid"] = request.processUuid;
    }

    if (!Util.isUnset(request.productCode)) {
      body["productCode"] = request.productCode;
    }

    if (!Util.isUnset(request.productName)) {
      body["productName"] = request.productName;
    }

    if (!Util.isUnset(request.productSpecification)) {
      body["productSpecification"] = request.productSpecification;
    }

    if (!Util.isUnset(request.projectCode)) {
      body["projectCode"] = request.projectCode;
    }

    if (!Util.isUnset(request.projectId)) {
      body["projectId"] = request.projectId;
    }

    if (!Util.isUnset(request.projectStatus)) {
      body["projectStatus"] = request.projectStatus;
    }

    if (!Util.isUnset(request.taskOperators)) {
      body["taskOperators"] = request.taskOperators;
    }

    if (!Util.isUnset(request.taskPlanEndTime)) {
      body["taskPlanEndTime"] = request.taskPlanEndTime;
    }

    if (!Util.isUnset(request.taskPlanStartTime)) {
      body["taskPlanStartTime"] = request.taskPlanStartTime;
    }

    if (!Util.isUnset(request.taskStatus)) {
      body["taskStatus"] = request.taskStatus;
    }

    if (!Util.isUnset(request.taskType)) {
      body["taskType"] = request.taskType;
    }

    if (!Util.isUnset(request.teamId)) {
      body["teamId"] = request.teamId;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
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
      action: "IndustryManufactureMesDispatchTask",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/manufacturings/dispatchTasks/manage`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IndustryManufactureMesDispatchTaskResponse>(await this.execute(params, req, runtime), new IndustryManufactureMesDispatchTaskResponse({}));
  }

  async industryManufactureMesDispatchTask(request: IndustryManufactureMesDispatchTaskRequest): Promise<IndustryManufactureMesDispatchTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMesDispatchTaskHeaders({ });
    return await this.industryManufactureMesDispatchTaskWithOptions(request, headers, runtime);
  }

  async industryManufactureMesMaterialWithOptions(request: IndustryManufactureMesMaterialRequest, headers: IndustryManufactureMesMaterialHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureMesMaterialResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.appKey)) {
      body["appKey"] = request.appKey;
    }

    if (!Util.isUnset(request.baseDataName)) {
      body["baseDataName"] = request.baseDataName;
    }

    if (!Util.isUnset(request.category)) {
      body["category"] = request.category;
    }

    if (!Util.isUnset(request.extendData)) {
      body["extendData"] = request.extendData;
    }

    if (!Util.isUnset(request.productCode)) {
      body["productCode"] = request.productCode;
    }

    if (!Util.isUnset(request.productName)) {
      body["productName"] = request.productName;
    }

    if (!Util.isUnset(request.productSpecification)) {
      body["productSpecification"] = request.productSpecification;
    }

    if (!Util.isUnset(request.prop)) {
      body["prop"] = request.prop;
    }

    if (!Util.isUnset(request.unit)) {
      body["unit"] = request.unit;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
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
      action: "IndustryManufactureMesMaterial",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/manufacturings/materials/manage`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IndustryManufactureMesMaterialResponse>(await this.execute(params, req, runtime), new IndustryManufactureMesMaterialResponse({}));
  }

  async industryManufactureMesMaterial(request: IndustryManufactureMesMaterialRequest): Promise<IndustryManufactureMesMaterialResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMesMaterialHeaders({ });
    return await this.industryManufactureMesMaterialWithOptions(request, headers, runtime);
  }

  async industryManufactureMesOutPlanWithOptions(request: IndustryManufactureMesOutPlanRequest, headers: IndustryManufactureMesOutPlanHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureMesOutPlanResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.approvalStatus)) {
      body["approvalStatus"] = request.approvalStatus;
    }

    if (!Util.isUnset(request.approver)) {
      body["approver"] = request.approver;
    }

    if (!Util.isUnset(request.baseDataName)) {
      body["baseDataName"] = request.baseDataName;
    }

    if (!Util.isUnset(request.outSourceProjectCode)) {
      body["outSourceProjectCode"] = request.outSourceProjectCode;
    }

    if (!Util.isUnset(request.outSourceTeamId)) {
      body["outSourceTeamId"] = request.outSourceTeamId;
    }

    if (!Util.isUnset(request.price)) {
      body["price"] = request.price;
    }

    if (!Util.isUnset(request.processIdentificationCode)) {
      body["processIdentificationCode"] = request.processIdentificationCode;
    }

    if (!Util.isUnset(request.processUuids)) {
      body["processUuids"] = request.processUuids;
    }

    if (!Util.isUnset(request.productCode)) {
      body["productCode"] = request.productCode;
    }

    if (!Util.isUnset(request.productName)) {
      body["productName"] = request.productName;
    }

    if (!Util.isUnset(request.productSpecification)) {
      body["productSpecification"] = request.productSpecification;
    }

    if (!Util.isUnset(request.projectCode)) {
      body["projectCode"] = request.projectCode;
    }

    if (!Util.isUnset(request.projectId)) {
      body["projectId"] = request.projectId;
    }

    if (!Util.isUnset(request.sendPlanQuantity)) {
      body["sendPlanQuantity"] = request.sendPlanQuantity;
    }

    if (!Util.isUnset(request.supplierCode)) {
      body["supplierCode"] = request.supplierCode;
    }

    if (!Util.isUnset(request.supplierName)) {
      body["supplierName"] = request.supplierName;
    }

    if (!Util.isUnset(request.totalWage)) {
      body["totalWage"] = request.totalWage;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
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
      action: "IndustryManufactureMesOutPlan",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/manufacturings/outPlans/manage`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IndustryManufactureMesOutPlanResponse>(await this.execute(params, req, runtime), new IndustryManufactureMesOutPlanResponse({}));
  }

  async industryManufactureMesOutPlan(request: IndustryManufactureMesOutPlanRequest): Promise<IndustryManufactureMesOutPlanResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMesOutPlanHeaders({ });
    return await this.industryManufactureMesOutPlanWithOptions(request, headers, runtime);
  }

  async industryManufactureMesOutputWithOptions(request: IndustryManufactureMesOutputRequest, headers: IndustryManufactureMesOutputHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureMesOutputResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.appKey)) {
      body["appKey"] = request.appKey;
    }

    if (!Util.isUnset(request.approveStatus)) {
      body["approveStatus"] = request.approveStatus;
    }

    if (!Util.isUnset(request.baseDataName)) {
      body["baseDataName"] = request.baseDataName;
    }

    if (!Util.isUnset(request.defectsAmount)) {
      body["defectsAmount"] = request.defectsAmount;
    }

    if (!Util.isUnset(request.defectsReason)) {
      body["defectsReason"] = request.defectsReason;
    }

    if (!Util.isUnset(request.fineAmount)) {
      body["fineAmount"] = request.fineAmount;
    }

    if (!Util.isUnset(request.hasQualityTest)) {
      body["hasQualityTest"] = request.hasQualityTest;
    }

    if (!Util.isUnset(request.overdue)) {
      body["overdue"] = request.overdue;
    }

    if (!Util.isUnset(request.planQuantity)) {
      body["planQuantity"] = request.planQuantity;
    }

    if (!Util.isUnset(request.priority)) {
      body["priority"] = request.priority;
    }

    if (!Util.isUnset(request.processName)) {
      body["processName"] = request.processName;
    }

    if (!Util.isUnset(request.processUuid)) {
      body["processUuid"] = request.processUuid;
    }

    if (!Util.isUnset(request.productCode)) {
      body["productCode"] = request.productCode;
    }

    if (!Util.isUnset(request.productName)) {
      body["productName"] = request.productName;
    }

    if (!Util.isUnset(request.productSpecification)) {
      body["productSpecification"] = request.productSpecification;
    }

    if (!Util.isUnset(request.projectCode)) {
      body["projectCode"] = request.projectCode;
    }

    if (!Util.isUnset(request.projectId)) {
      body["projectId"] = request.projectId;
    }

    if (!Util.isUnset(request.projectStatus)) {
      body["projectStatus"] = request.projectStatus;
    }

    if (!Util.isUnset(request.qualityTestStatus)) {
      body["qualityTestStatus"] = request.qualityTestStatus;
    }

    if (!Util.isUnset(request.taskPlanEndTime)) {
      body["taskPlanEndTime"] = request.taskPlanEndTime;
    }

    if (!Util.isUnset(request.taskPlanStartTime)) {
      body["taskPlanStartTime"] = request.taskPlanStartTime;
    }

    if (!Util.isUnset(request.taskStatus)) {
      body["taskStatus"] = request.taskStatus;
    }

    if (!Util.isUnset(request.taskType)) {
      body["taskType"] = request.taskType;
    }

    if (!Util.isUnset(request.taskUuid)) {
      body["taskUuid"] = request.taskUuid;
    }

    if (!Util.isUnset(request.teamId)) {
      body["teamId"] = request.teamId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.userName)) {
      body["userName"] = request.userName;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
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
      action: "IndustryManufactureMesOutput",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/manufacturings/outputs/manage`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IndustryManufactureMesOutputResponse>(await this.execute(params, req, runtime), new IndustryManufactureMesOutputResponse({}));
  }

  async industryManufactureMesOutput(request: IndustryManufactureMesOutputRequest): Promise<IndustryManufactureMesOutputResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMesOutputHeaders({ });
    return await this.industryManufactureMesOutputWithOptions(request, headers, runtime);
  }

  async industryManufactureMesProcessWithOptions(request: IndustryManufactureMesProcessRequest, headers: IndustryManufactureMesProcessHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureMesProcessResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.appKey)) {
      body["appKey"] = request.appKey;
    }

    if (!Util.isUnset(request.baseDataName)) {
      body["baseDataName"] = request.baseDataName;
    }

    if (!Util.isUnset(request.extendData)) {
      body["extendData"] = request.extendData;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.needDispatch)) {
      body["needDispatch"] = request.needDispatch;
    }

    if (!Util.isUnset(request.needQualityTest)) {
      body["needQualityTest"] = request.needQualityTest;
    }

    if (!Util.isUnset(request.no)) {
      body["no"] = request.no;
    }

    if (!Util.isUnset(request.price)) {
      body["price"] = request.price;
    }

    if (!Util.isUnset(request.prop)) {
      body["prop"] = request.prop;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.sop)) {
      body["sop"] = request.sop;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
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
      action: "IndustryManufactureMesProcess",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/manufacturings/processes/manage`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IndustryManufactureMesProcessResponse>(await this.execute(params, req, runtime), new IndustryManufactureMesProcessResponse({}));
  }

  async industryManufactureMesProcess(request: IndustryManufactureMesProcessRequest): Promise<IndustryManufactureMesProcessResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMesProcessHeaders({ });
    return await this.industryManufactureMesProcessWithOptions(request, headers, runtime);
  }

  async industryManufactureMesProductionPlanWithOptions(request: IndustryManufactureMesProductionPlanRequest, headers: IndustryManufactureMesProductionPlanHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureMesProductionPlanResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.actualEndTime)) {
      body["actualEndTime"] = request.actualEndTime;
    }

    if (!Util.isUnset(request.actualStartTime)) {
      body["actualStartTime"] = request.actualStartTime;
    }

    if (!Util.isUnset(request.appKey)) {
      body["appKey"] = request.appKey;
    }

    if (!Util.isUnset(request.baseDataName)) {
      body["baseDataName"] = request.baseDataName;
    }

    if (!Util.isUnset(request.bomUuid)) {
      body["bomUuid"] = request.bomUuid;
    }

    if (!Util.isUnset(request.events)) {
      body["events"] = request.events;
    }

    if (!Util.isUnset(request.extendData)) {
      body["extendData"] = request.extendData;
    }

    if (!Util.isUnset(request.no)) {
      body["no"] = request.no;
    }

    if (!Util.isUnset(request.overdue)) {
      body["overdue"] = request.overdue;
    }

    if (!Util.isUnset(request.planEndTime)) {
      body["planEndTime"] = request.planEndTime;
    }

    if (!Util.isUnset(request.planQuantity)) {
      body["planQuantity"] = request.planQuantity;
    }

    if (!Util.isUnset(request.planStartTime)) {
      body["planStartTime"] = request.planStartTime;
    }

    if (!Util.isUnset(request.processUuids)) {
      body["processUuids"] = request.processUuids;
    }

    if (!Util.isUnset(request.productCode)) {
      body["productCode"] = request.productCode;
    }

    if (!Util.isUnset(request.productName)) {
      body["productName"] = request.productName;
    }

    if (!Util.isUnset(request.productSpecification)) {
      body["productSpecification"] = request.productSpecification;
    }

    if (!Util.isUnset(request.qualifiedQuantity)) {
      body["qualifiedQuantity"] = request.qualifiedQuantity;
    }

    if (!Util.isUnset(request.sellOrderNo)) {
      body["sellOrderNo"] = request.sellOrderNo;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.teamList)) {
      body["teamList"] = request.teamList;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    if (!Util.isUnset(request.unit)) {
      body["unit"] = request.unit;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
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
      action: "IndustryManufactureMesProductionPlan",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/manufacturings/productionPlans/manage`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IndustryManufactureMesProductionPlanResponse>(await this.execute(params, req, runtime), new IndustryManufactureMesProductionPlanResponse({}));
  }

  async industryManufactureMesProductionPlan(request: IndustryManufactureMesProductionPlanRequest): Promise<IndustryManufactureMesProductionPlanResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMesProductionPlanHeaders({ });
    return await this.industryManufactureMesProductionPlanWithOptions(request, headers, runtime);
  }

  async industryManufactureMesSubCooperationTeamWithOptions(request: IndustryManufactureMesSubCooperationTeamRequest, headers: IndustryManufactureMesSubCooperationTeamHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureMesSubCooperationTeamResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.appKey)) {
      body["appKey"] = request.appKey;
    }

    if (!Util.isUnset(request.baseDataName)) {
      body["baseDataName"] = request.baseDataName;
    }

    if (!Util.isUnset(request.events)) {
      body["events"] = request.events;
    }

    if (!Util.isUnset(request.extendData)) {
      body["extendData"] = request.extendData;
    }

    if (!Util.isUnset(request.groupPlugins)) {
      body["groupPlugins"] = request.groupPlugins;
    }

    if (!Util.isUnset(request.groupType)) {
      body["groupType"] = request.groupType;
    }

    if (!Util.isUnset(request.leaders)) {
      body["leaders"] = request.leaders;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.outCorpId)) {
      body["outCorpId"] = request.outCorpId;
    }

    if (!Util.isUnset(request.processIds)) {
      body["processIds"] = request.processIds;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
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
      action: "IndustryManufactureMesSubCooperationTeam",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/manufacturings/outTeams/manage`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IndustryManufactureMesSubCooperationTeamResponse>(await this.execute(params, req, runtime), new IndustryManufactureMesSubCooperationTeamResponse({}));
  }

  async industryManufactureMesSubCooperationTeam(request: IndustryManufactureMesSubCooperationTeamRequest): Promise<IndustryManufactureMesSubCooperationTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMesSubCooperationTeamHeaders({ });
    return await this.industryManufactureMesSubCooperationTeamWithOptions(request, headers, runtime);
  }

  async industryManufactureMesTeamMgmtWithOptions(request: IndustryManufactureMesTeamMgmtRequest, headers: IndustryManufactureMesTeamMgmtHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureMesTeamMgmtResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.appKey)) {
      body["appKey"] = request.appKey;
    }

    if (!Util.isUnset(request.baseDataName)) {
      body["baseDataName"] = request.baseDataName;
    }

    if (!Util.isUnset(request.events)) {
      body["events"] = request.events;
    }

    if (!Util.isUnset(request.extendData)) {
      body["extendData"] = request.extendData;
    }

    if (!Util.isUnset(request.groupConfig)) {
      body["groupConfig"] = request.groupConfig;
    }

    if (!Util.isUnset(request.groupPlugins)) {
      body["groupPlugins"] = request.groupPlugins;
    }

    if (!Util.isUnset(request.groupType)) {
      body["groupType"] = request.groupType;
    }

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
    }

    if (!Util.isUnset(request.leaders)) {
      body["leaders"] = request.leaders;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.processIds)) {
      body["processIds"] = request.processIds;
    }

    if (!Util.isUnset(request.tagKey)) {
      body["tagKey"] = request.tagKey;
    }

    if (!Util.isUnset(request.tagValues)) {
      body["tagValues"] = request.tagValues;
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
      action: "IndustryManufactureMesTeamMgmt",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/manufacturing/base/data/team`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IndustryManufactureMesTeamMgmtResponse>(await this.execute(params, req, runtime), new IndustryManufactureMesTeamMgmtResponse({}));
  }

  async industryManufactureMesTeamMgmt(request: IndustryManufactureMesTeamMgmtRequest): Promise<IndustryManufactureMesTeamMgmtResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMesTeamMgmtHeaders({ });
    return await this.industryManufactureMesTeamMgmtWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "IndustryMmanufactureMaterialCostGet",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/manufactures/base/materialCosts/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IndustryMmanufactureMaterialCostGetResponse>(await this.execute(params, req, runtime), new IndustryMmanufactureMaterialCostGetResponse({}));
  }

  async industryMmanufactureMaterialCostGet(request: IndustryMmanufactureMaterialCostGetRequest): Promise<IndustryMmanufactureMaterialCostGetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryMmanufactureMaterialCostGetHeaders({ });
    return await this.industryMmanufactureMaterialCostGetWithOptions(request, headers, runtime);
  }

  async pushDingMessageWithOptions(request: PushDingMessageRequest, headers: PushDingMessageHeaders, runtime: $Util.RuntimeOptions): Promise<PushDingMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.messageType)) {
      body["messageType"] = request.messageType;
    }

    if (!Util.isUnset(request.messageUrl)) {
      body["messageUrl"] = request.messageUrl;
    }

    if (!Util.isUnset(request.pictureUrl)) {
      body["pictureUrl"] = request.pictureUrl;
    }

    if (!Util.isUnset(request.singleTitle)) {
      body["singleTitle"] = request.singleTitle;
    }

    if (!Util.isUnset(request.singleUrl)) {
      body["singleUrl"] = request.singleUrl;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
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
    let params = new $OpenApi.Params({
      action: "PushDingMessage",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/works/notice`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PushDingMessageResponse>(await this.execute(params, req, runtime), new PushDingMessageResponse({}));
  }

  async pushDingMessage(request: PushDingMessageRequest): Promise<PushDingMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PushDingMessageHeaders({ });
    return await this.pushDingMessageWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "QueryAllDepartment",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/departments`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAllDepartmentResponse>(await this.execute(params, req, runtime), new QueryAllDepartmentResponse({}));
  }

  async queryAllDepartment(request: QueryAllDepartmentRequest): Promise<QueryAllDepartmentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllDepartmentHeaders({ });
    return await this.queryAllDepartmentWithOptions(request, headers, runtime);
  }

  async queryAllDoctorsWithOptions(request: QueryAllDoctorsRequest, headers: QueryAllDoctorsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllDoctorsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.monthMark)) {
      query["monthMark"] = request.monthMark;
    }

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
    let params = new $OpenApi.Params({
      action: "QueryAllDoctors",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/doctors`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAllDoctorsResponse>(await this.execute(params, req, runtime), new QueryAllDoctorsResponse({}));
  }

  async queryAllDoctors(request: QueryAllDoctorsRequest): Promise<QueryAllDoctorsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllDoctorsHeaders({ });
    return await this.queryAllDoctorsWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "QueryAllGroup",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/groups`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAllGroupResponse>(await this.execute(params, req, runtime), new QueryAllGroupResponse({}));
  }

  async queryAllGroup(request: QueryAllGroupRequest): Promise<QueryAllGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllGroupHeaders({ });
    return await this.queryAllGroupWithOptions(request, headers, runtime);
  }

  async queryAllGroupsInDeptWithOptions(deptId: string, request: QueryAllGroupsInDeptRequest, headers: QueryAllGroupsInDeptHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllGroupsInDeptResponse> {
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
    let params = new $OpenApi.Params({
      action: "QueryAllGroupsInDept",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/departments/${deptId}/groups`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAllGroupsInDeptResponse>(await this.execute(params, req, runtime), new QueryAllGroupsInDeptResponse({}));
  }

  async queryAllGroupsInDept(deptId: string, request: QueryAllGroupsInDeptRequest): Promise<QueryAllGroupsInDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllGroupsInDeptHeaders({ });
    return await this.queryAllGroupsInDeptWithOptions(deptId, request, headers, runtime);
  }

  async queryAllMemberByDeptWithOptions(deptId: string, request: QueryAllMemberByDeptRequest, headers: QueryAllMemberByDeptHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllMemberByDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.monthMark)) {
      query["monthMark"] = request.monthMark;
    }

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
    let params = new $OpenApi.Params({
      action: "QueryAllMemberByDept",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/departments/${deptId}/members`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAllMemberByDeptResponse>(await this.execute(params, req, runtime), new QueryAllMemberByDeptResponse({}));
  }

  async queryAllMemberByDept(deptId: string, request: QueryAllMemberByDeptRequest): Promise<QueryAllMemberByDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllMemberByDeptHeaders({ });
    return await this.queryAllMemberByDeptWithOptions(deptId, request, headers, runtime);
  }

  async queryAllMemberByGroupWithOptions(groupId: string, request: QueryAllMemberByGroupRequest, headers: QueryAllMemberByGroupHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllMemberByGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.monthMark)) {
      query["monthMark"] = request.monthMark;
    }

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
    let params = new $OpenApi.Params({
      action: "QueryAllMemberByGroup",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/groups/${groupId}/members`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAllMemberByGroupResponse>(await this.execute(params, req, runtime), new QueryAllMemberByGroupResponse({}));
  }

  async queryAllMemberByGroup(groupId: string, request: QueryAllMemberByGroupRequest): Promise<QueryAllMemberByGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllMemberByGroupHeaders({ });
    return await this.queryAllMemberByGroupWithOptions(groupId, request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "QueryBizOptLog",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/bizOptLogs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryBizOptLogResponse>(await this.execute(params, req, runtime), new QueryBizOptLogResponse({}));
  }

  async queryBizOptLog(request: QueryBizOptLogRequest): Promise<QueryBizOptLogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBizOptLogHeaders({ });
    return await this.queryBizOptLogWithOptions(request, headers, runtime);
  }

  async queryDepartmentExtendInfoWithOptions(request: QueryDepartmentExtendInfoRequest, headers: QueryDepartmentExtendInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDepartmentExtendInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptCode)) {
      query["deptCode"] = request.deptCode;
    }

    if (!Util.isUnset(request.propCode)) {
      query["propCode"] = request.propCode;
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
      action: "QueryDepartmentExtendInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/departments/extensions/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDepartmentExtendInfoResponse>(await this.execute(params, req, runtime), new QueryDepartmentExtendInfoResponse({}));
  }

  async queryDepartmentExtendInfo(request: QueryDepartmentExtendInfoRequest): Promise<QueryDepartmentExtendInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDepartmentExtendInfoHeaders({ });
    return await this.queryDepartmentExtendInfoWithOptions(request, headers, runtime);
  }

  async queryDepartmentInfoWithOptions(deptId: string, headers: QueryDepartmentInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDepartmentInfoResponse> {
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
      action: "QueryDepartmentInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/departments/${deptId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDepartmentInfoResponse>(await this.execute(params, req, runtime), new QueryDepartmentInfoResponse({}));
  }

  async queryDepartmentInfo(deptId: string): Promise<QueryDepartmentInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDepartmentInfoHeaders({ });
    return await this.queryDepartmentInfoWithOptions(deptId, headers, runtime);
  }

  async queryDoctorDetailsByJobNumberWithOptions(jobNumber: string, request: QueryDoctorDetailsByJobNumberRequest, headers: QueryDoctorDetailsByJobNumberHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDoctorDetailsByJobNumberResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.monthMark)) {
      query["monthMark"] = request.monthMark;
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
      action: "QueryDoctorDetailsByJobNumber",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/doctors/${jobNumber}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDoctorDetailsByJobNumberResponse>(await this.execute(params, req, runtime), new QueryDoctorDetailsByJobNumberResponse({}));
  }

  async queryDoctorDetailsByJobNumber(jobNumber: string, request: QueryDoctorDetailsByJobNumberRequest): Promise<QueryDoctorDetailsByJobNumberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDoctorDetailsByJobNumberHeaders({ });
    return await this.queryDoctorDetailsByJobNumberWithOptions(jobNumber, request, headers, runtime);
  }

  async queryGroupInfoWithOptions(groupId: string, headers: QueryGroupInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupInfoResponse> {
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
      action: "QueryGroupInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/groups/${groupId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryGroupInfoResponse>(await this.execute(params, req, runtime), new QueryGroupInfoResponse({}));
  }

  async queryGroupInfo(groupId: string): Promise<QueryGroupInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupInfoHeaders({ });
    return await this.queryGroupInfoWithOptions(groupId, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "QueryHospitalDistrictInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/districts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryHospitalDistrictInfoResponse>(await this.execute(params, req, runtime), new QueryHospitalDistrictInfoResponse({}));
  }

  async queryHospitalDistrictInfo(request: QueryHospitalDistrictInfoRequest): Promise<QueryHospitalDistrictInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHospitalDistrictInfoHeaders({ });
    return await this.queryHospitalDistrictInfoWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "QueryHospitalRoleUserInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/roles/userInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryHospitalRoleUserInfoResponse>(await this.execute(params, req, runtime), new QueryHospitalRoleUserInfoResponse({}));
  }

  async queryHospitalRoleUserInfo(request: QueryHospitalRoleUserInfoRequest): Promise<QueryHospitalRoleUserInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHospitalRoleUserInfoHeaders({ });
    return await this.queryHospitalRoleUserInfoWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "QueryHospitalRoles",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/roles`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryHospitalRolesResponse>(await this.execute(params, req, runtime), new QueryHospitalRolesResponse({}));
  }

  async queryHospitalRoles(): Promise<QueryHospitalRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHospitalRolesHeaders({ });
    return await this.queryHospitalRolesWithOptions(headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "QueryJobCodeDictionary",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/jobCodes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryJobCodeDictionaryResponse>(await this.execute(params, req, runtime), new QueryJobCodeDictionaryResponse({}));
  }

  async queryJobCodeDictionary(): Promise<QueryJobCodeDictionaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryJobCodeDictionaryHeaders({ });
    return await this.queryJobCodeDictionaryWithOptions(headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "QueryJobStatusCodeDictionary",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/jobStatusCodes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryJobStatusCodeDictionaryResponse>(await this.execute(params, req, runtime), new QueryJobStatusCodeDictionaryResponse({}));
  }

  async queryJobStatusCodeDictionary(): Promise<QueryJobStatusCodeDictionaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryJobStatusCodeDictionaryHeaders({ });
    return await this.queryJobStatusCodeDictionaryWithOptions(headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "QueryMedicalEvents",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/events`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMedicalEventsResponse>(await this.execute(params, req, runtime), new QueryMedicalEventsResponse({}));
  }

  async queryMedicalEvents(): Promise<QueryMedicalEventsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMedicalEventsHeaders({ });
    return await this.queryMedicalEventsWithOptions(headers, runtime);
  }

  async queryUserCredentialsWithOptions(request: QueryUserCredentialsRequest, headers: QueryUserCredentialsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserCredentialsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
      action: "QueryUserCredentials",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/users/credentials/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUserCredentialsResponse>(await this.execute(params, req, runtime), new QueryUserCredentialsResponse({}));
  }

  async queryUserCredentials(request: QueryUserCredentialsRequest): Promise<QueryUserCredentialsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserCredentialsHeaders({ });
    return await this.queryUserCredentialsWithOptions(request, headers, runtime);
  }

  async queryUserExtInfoWithOptions(userId: string, headers: QueryUserExtInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserExtInfoResponse> {
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
      action: "QueryUserExtInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/users/${userId}/extInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUserExtInfoResponse>(await this.execute(params, req, runtime), new QueryUserExtInfoResponse({}));
  }

  async queryUserExtInfo(userId: string): Promise<QueryUserExtInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserExtInfoHeaders({ });
    return await this.queryUserExtInfoWithOptions(userId, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "QueryUserExtendValues",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/users/extends/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUserExtendValuesResponse>(await this.execute(params, req, runtime), new QueryUserExtendValuesResponse({}));
  }

  async queryUserExtendValues(request: QueryUserExtendValuesRequest): Promise<QueryUserExtendValuesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserExtendValuesHeaders({ });
    return await this.queryUserExtendValuesWithOptions(request, headers, runtime);
  }

  async queryUserInfoWithOptions(userId: string, request: QueryUserInfoRequest, headers: QueryUserInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.monthMark)) {
      query["monthMark"] = request.monthMark;
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
      action: "QueryUserInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/users/${userId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUserInfoResponse>(await this.execute(params, req, runtime), new QueryUserInfoResponse({}));
  }

  async queryUserInfo(userId: string, request: QueryUserInfoRequest): Promise<QueryUserInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserInfoHeaders({ });
    return await this.queryUserInfoWithOptions(userId, request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "QueryUserProbCodeDictionary",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/userProbCodes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryUserProbCodeDictionaryResponse>(await this.execute(params, req, runtime), new QueryUserProbCodeDictionaryResponse({}));
  }

  async queryUserProbCodeDictionary(): Promise<QueryUserProbCodeDictionaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserProbCodeDictionaryHeaders({ });
    return await this.queryUserProbCodeDictionaryWithOptions(headers, runtime);
  }

  async queryUserRolesWithOptions(userId: string, headers: QueryUserRolesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserRolesResponse> {
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
      action: "QueryUserRoles",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/users/${userId}/roles`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryUserRolesResponse>(await this.execute(params, req, runtime), new QueryUserRolesResponse({}));
  }

  async queryUserRoles(userId: string): Promise<QueryUserRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserRolesHeaders({ });
    return await this.queryUserRolesWithOptions(userId, headers, runtime);
  }

  async saveUserExtendValuesWithOptions(userId: string, request: SaveUserExtendValuesRequest, headers: SaveUserExtendValuesHeaders, runtime: $Util.RuntimeOptions): Promise<SaveUserExtendValuesResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "SaveUserExtendValues",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/users/${userId}/extends`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveUserExtendValuesResponse>(await this.execute(params, req, runtime), new SaveUserExtendValuesResponse({}));
  }

  async saveUserExtendValues(userId: string, request: SaveUserExtendValuesRequest): Promise<SaveUserExtendValuesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveUserExtendValuesHeaders({ });
    return await this.saveUserExtendValuesWithOptions(userId, request, headers, runtime);
  }

  async supplAddRoleWithOptions(request: SupplAddRoleRequest, headers: SupplAddRoleHeaders, runtime: $Util.RuntimeOptions): Promise<SupplAddRoleResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.parentRoleGroupId)) {
      query["parentRoleGroupId"] = request.parentRoleGroupId;
    }

    if (!Util.isUnset(request.roleName)) {
      query["roleName"] = request.roleName;
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
      action: "SupplAddRole",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/roles`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplAddRoleResponse>(await this.execute(params, req, runtime), new SupplAddRoleResponse({}));
  }

  async supplAddRole(request: SupplAddRoleRequest): Promise<SupplAddRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplAddRoleHeaders({ });
    return await this.supplAddRoleWithOptions(request, headers, runtime);
  }

  async supplyAddDeptWithOptions(request: SupplyAddDeptRequest, headers: SupplyAddDeptHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyAddDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptName)) {
      query["deptName"] = request.deptName;
    }

    if (!Util.isUnset(request.partnerNumber)) {
      query["partnerNumber"] = request.partnerNumber;
    }

    if (!Util.isUnset(request.superDeptId)) {
      query["superDeptId"] = request.superDeptId;
    }

    if (!Util.isUnset(request.supplyDeptType)) {
      query["supplyDeptType"] = request.supplyDeptType;
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
      action: "SupplyAddDept",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/departments`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyAddDeptResponse>(await this.execute(params, req, runtime), new SupplyAddDeptResponse({}));
  }

  async supplyAddDept(request: SupplyAddDeptRequest): Promise<SupplyAddDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyAddDeptHeaders({ });
    return await this.supplyAddDeptWithOptions(request, headers, runtime);
  }

  async supplyAddMemberWithOptions(request: SupplyAddMemberRequest, headers: SupplyAddMemberHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyAddMemberResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isPartnerManager)) {
      query["isPartnerManager"] = request.isPartnerManager;
    }

    if (!Util.isUnset(request.memberMobile)) {
      query["memberMobile"] = request.memberMobile;
    }

    if (!Util.isUnset(request.memberName)) {
      query["memberName"] = request.memberName;
    }

    if (!Util.isUnset(request.memberTitle)) {
      query["memberTitle"] = request.memberTitle;
    }

    if (!Util.isUnset(request.memberWorkNumber)) {
      query["memberWorkNumber"] = request.memberWorkNumber;
    }

    if (!Util.isUnset(request.supplyDeptId)) {
      query["supplyDeptId"] = request.supplyDeptId;
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
      action: "SupplyAddMember",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/members`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyAddMemberResponse>(await this.execute(params, req, runtime), new SupplyAddMemberResponse({}));
  }

  async supplyAddMember(request: SupplyAddMemberRequest): Promise<SupplyAddMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyAddMemberHeaders({ });
    return await this.supplyAddMemberWithOptions(request, headers, runtime);
  }

  async supplyAddPartnerAdminsWithOptions(request: SupplyAddPartnerAdminsRequest, headers: SupplyAddPartnerAdminsHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyAddPartnerAdminsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
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
      action: "SupplyAddPartnerAdmins",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/partnerAdministrators`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyAddPartnerAdminsResponse>(await this.execute(params, req, runtime), new SupplyAddPartnerAdminsResponse({}));
  }

  async supplyAddPartnerAdmins(request: SupplyAddPartnerAdminsRequest): Promise<SupplyAddPartnerAdminsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyAddPartnerAdminsHeaders({ });
    return await this.supplyAddPartnerAdminsWithOptions(request, headers, runtime);
  }

  async supplyAddPartnerManagersWithOptions(request: SupplyAddPartnerManagersRequest, headers: SupplyAddPartnerManagersHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyAddPartnerManagersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.interfaceId)) {
      query["interfaceId"] = request.interfaceId;
    }

    if (!Util.isUnset(request.interfaceType)) {
      query["interfaceType"] = request.interfaceType;
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
      action: "SupplyAddPartnerManagers",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/partnerInterfaces`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyAddPartnerManagersResponse>(await this.execute(params, req, runtime), new SupplyAddPartnerManagersResponse({}));
  }

  async supplyAddPartnerManagers(request: SupplyAddPartnerManagersRequest): Promise<SupplyAddPartnerManagersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyAddPartnerManagersHeaders({ });
    return await this.supplyAddPartnerManagersWithOptions(request, headers, runtime);
  }

  async supplyAddPartnerTypeWithOptions(request: SupplyAddPartnerTypeRequest, headers: SupplyAddPartnerTypeHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyAddPartnerTypeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      query["name"] = request.name;
    }

    if (!Util.isUnset(request.superId)) {
      query["superId"] = request.superId;
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
      action: "SupplyAddPartnerType",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/partnerLabels`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyAddPartnerTypeResponse>(await this.execute(params, req, runtime), new SupplyAddPartnerTypeResponse({}));
  }

  async supplyAddPartnerType(request: SupplyAddPartnerTypeRequest): Promise<SupplyAddPartnerTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyAddPartnerTypeHeaders({ });
    return await this.supplyAddPartnerTypeWithOptions(request, headers, runtime);
  }

  async supplyChainDeleteDeptWithOptions(request: SupplyChainDeleteDeptRequest, headers: SupplyChainDeleteDeptHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyChainDeleteDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.supplyDeptId)) {
      query["supplyDeptId"] = request.supplyDeptId;
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
      action: "SupplyChainDeleteDept",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/departments`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyChainDeleteDeptResponse>(await this.execute(params, req, runtime), new SupplyChainDeleteDeptResponse({}));
  }

  async supplyChainDeleteDept(request: SupplyChainDeleteDeptRequest): Promise<SupplyChainDeleteDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyChainDeleteDeptHeaders({ });
    return await this.supplyChainDeleteDeptWithOptions(request, headers, runtime);
  }

  async supplyChainQueryDeptInfoWithOptions(request: SupplyChainQueryDeptInfoRequest, headers: SupplyChainQueryDeptInfoHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyChainQueryDeptInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.supplyDeptId)) {
      query["supplyDeptId"] = request.supplyDeptId;
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
      action: "SupplyChainQueryDeptInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/departments`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyChainQueryDeptInfoResponse>(await this.execute(params, req, runtime), new SupplyChainQueryDeptInfoResponse({}));
  }

  async supplyChainQueryDeptInfo(request: SupplyChainQueryDeptInfoRequest): Promise<SupplyChainQueryDeptInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyChainQueryDeptInfoHeaders({ });
    return await this.supplyChainQueryDeptInfoWithOptions(request, headers, runtime);
  }

  async supplyChainUpdateDeptInfoWithOptions(request: SupplyChainUpdateDeptInfoRequest, headers: SupplyChainUpdateDeptInfoHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyChainUpdateDeptInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.partnerNumber)) {
      body["partnerNumber"] = request.partnerNumber;
    }

    if (!Util.isUnset(request.partnerTypeList)) {
      body["partnerTypeList"] = request.partnerTypeList;
    }

    if (!Util.isUnset(request.superId)) {
      body["superId"] = request.superId;
    }

    if (!Util.isUnset(request.supplyDeptId)) {
      body["supplyDeptId"] = request.supplyDeptId;
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
      action: "SupplyChainUpdateDeptInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/departments`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyChainUpdateDeptInfoResponse>(await this.execute(params, req, runtime), new SupplyChainUpdateDeptInfoResponse({}));
  }

  async supplyChainUpdateDeptInfo(request: SupplyChainUpdateDeptInfoRequest): Promise<SupplyChainUpdateDeptInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyChainUpdateDeptInfoHeaders({ });
    return await this.supplyChainUpdateDeptInfoWithOptions(request, headers, runtime);
  }

  async supplyDeleteMemberWithOptions(request: SupplyDeleteMemberRequest, headers: SupplyDeleteMemberHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyDeleteMemberResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.mobile)) {
      query["mobile"] = request.mobile;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "SupplyDeleteMember",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/members`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyDeleteMemberResponse>(await this.execute(params, req, runtime), new SupplyDeleteMemberResponse({}));
  }

  async supplyDeleteMember(request: SupplyDeleteMemberRequest): Promise<SupplyDeleteMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyDeleteMemberHeaders({ });
    return await this.supplyDeleteMemberWithOptions(request, headers, runtime);
  }

  async supplyDeletePartnerAdminsWithOptions(request: SupplyDeletePartnerAdminsRequest, headers: SupplyDeletePartnerAdminsHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyDeletePartnerAdminsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
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
      action: "SupplyDeletePartnerAdmins",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/partnerAdministrators`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyDeletePartnerAdminsResponse>(await this.execute(params, req, runtime), new SupplyDeletePartnerAdminsResponse({}));
  }

  async supplyDeletePartnerAdmins(request: SupplyDeletePartnerAdminsRequest): Promise<SupplyDeletePartnerAdminsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyDeletePartnerAdminsHeaders({ });
    return await this.supplyDeletePartnerAdminsWithOptions(request, headers, runtime);
  }

  async supplyDeletePartnerManagersWithOptions(request: SupplyDeletePartnerManagersRequest, headers: SupplyDeletePartnerManagersHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyDeletePartnerManagersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.interfaceId)) {
      query["interfaceId"] = request.interfaceId;
    }

    if (!Util.isUnset(request.interfaceType)) {
      query["interfaceType"] = request.interfaceType;
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
      action: "SupplyDeletePartnerManagers",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/partnerInterfaces`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyDeletePartnerManagersResponse>(await this.execute(params, req, runtime), new SupplyDeletePartnerManagersResponse({}));
  }

  async supplyDeletePartnerManagers(request: SupplyDeletePartnerManagersRequest): Promise<SupplyDeletePartnerManagersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyDeletePartnerManagersHeaders({ });
    return await this.supplyDeletePartnerManagersWithOptions(request, headers, runtime);
  }

  async supplyDeletePartnerTypeWithOptions(request: SupplyDeletePartnerTypeRequest, headers: SupplyDeletePartnerTypeHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyDeletePartnerTypeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.labelId)) {
      query["labelId"] = request.labelId;
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
      action: "SupplyDeletePartnerType",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/partnerLabels`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyDeletePartnerTypeResponse>(await this.execute(params, req, runtime), new SupplyDeletePartnerTypeResponse({}));
  }

  async supplyDeletePartnerType(request: SupplyDeletePartnerTypeRequest): Promise<SupplyDeletePartnerTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyDeletePartnerTypeHeaders({ });
    return await this.supplyDeletePartnerTypeWithOptions(request, headers, runtime);
  }

  async supplyDeleteRoleWithOptions(request: SupplyDeleteRoleRequest, headers: SupplyDeleteRoleHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyDeleteRoleResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isRoleGroup)) {
      query["isRoleGroup"] = request.isRoleGroup;
    }

    if (!Util.isUnset(request.roleId)) {
      query["roleId"] = request.roleId;
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
      action: "SupplyDeleteRole",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/roles`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyDeleteRoleResponse>(await this.execute(params, req, runtime), new SupplyDeleteRoleResponse({}));
  }

  async supplyDeleteRole(request: SupplyDeleteRoleRequest): Promise<SupplyDeleteRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyDeleteRoleHeaders({ });
    return await this.supplyDeleteRoleWithOptions(request, headers, runtime);
  }

  async supplyGetMemberWithOptions(request: SupplyGetMemberRequest, headers: SupplyGetMemberHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyGetMemberResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mobile)) {
      query["mobile"] = request.mobile;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "SupplyGetMember",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/members`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyGetMemberResponse>(await this.execute(params, req, runtime), new SupplyGetMemberResponse({}));
  }

  async supplyGetMember(request: SupplyGetMemberRequest): Promise<SupplyGetMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyGetMemberHeaders({ });
    return await this.supplyGetMemberWithOptions(request, headers, runtime);
  }

  async supplyListDeptMembersWithOptions(request: SupplyListDeptMembersRequest, headers: SupplyListDeptMembersHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyListDeptMembersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.supplyDeptId)) {
      query["supplyDeptId"] = request.supplyDeptId;
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
      action: "SupplyListDeptMembers",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/departments/members`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyListDeptMembersResponse>(await this.execute(params, req, runtime), new SupplyListDeptMembersResponse({}));
  }

  async supplyListDeptMembers(request: SupplyListDeptMembersRequest): Promise<SupplyListDeptMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyListDeptMembersHeaders({ });
    return await this.supplyListDeptMembersWithOptions(request, headers, runtime);
  }

  async supplyListPartnerAdminsWithOptions(request: SupplyListPartnerAdminsRequest, headers: SupplyListPartnerAdminsHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyListPartnerAdminsResponse> {
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
    let params = new $OpenApi.Params({
      action: "SupplyListPartnerAdmins",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/partnerAdministrators`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyListPartnerAdminsResponse>(await this.execute(params, req, runtime), new SupplyListPartnerAdminsResponse({}));
  }

  async supplyListPartnerAdmins(request: SupplyListPartnerAdminsRequest): Promise<SupplyListPartnerAdminsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyListPartnerAdminsHeaders({ });
    return await this.supplyListPartnerAdminsWithOptions(request, headers, runtime);
  }

  async supplyListPartnerManagersWithOptions(request: SupplyListPartnerManagersRequest, headers: SupplyListPartnerManagersHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyListPartnerManagersResponse> {
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
    let params = new $OpenApi.Params({
      action: "SupplyListPartnerManagers",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/partnerInterfaces`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyListPartnerManagersResponse>(await this.execute(params, req, runtime), new SupplyListPartnerManagersResponse({}));
  }

  async supplyListPartnerManagers(request: SupplyListPartnerManagersRequest): Promise<SupplyListPartnerManagersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyListPartnerManagersHeaders({ });
    return await this.supplyListPartnerManagersWithOptions(request, headers, runtime);
  }

  async supplyListPartnerTypeWithOptions(request: SupplyListPartnerTypeRequest, headers: SupplyListPartnerTypeHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyListPartnerTypeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.labelId)) {
      query["labelId"] = request.labelId;
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
      action: "SupplyListPartnerType",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/partnerLabels/subLabels`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyListPartnerTypeResponse>(await this.execute(params, req, runtime), new SupplyListPartnerTypeResponse({}));
  }

  async supplyListPartnerType(request: SupplyListPartnerTypeRequest): Promise<SupplyListPartnerTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyListPartnerTypeHeaders({ });
    return await this.supplyListPartnerTypeWithOptions(request, headers, runtime);
  }

  async supplyListRoleWithOptions(request: SupplyListRoleRequest, headers: SupplyListRoleHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyListRoleResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.parentRoleId)) {
      query["parentRoleId"] = request.parentRoleId;
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
      action: "SupplyListRole",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/roles`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyListRoleResponse>(await this.execute(params, req, runtime), new SupplyListRoleResponse({}));
  }

  async supplyListRole(request: SupplyListRoleRequest): Promise<SupplyListRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyListRoleHeaders({ });
    return await this.supplyListRoleWithOptions(request, headers, runtime);
  }

  async supplyListSubDeptWithOptions(request: SupplyListSubDeptRequest, headers: SupplyListSubDeptHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyListSubDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.supplyDeptId)) {
      query["supplyDeptId"] = request.supplyDeptId;
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
      action: "SupplyListSubDept",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/subDepartments`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyListSubDeptResponse>(await this.execute(params, req, runtime), new SupplyListSubDeptResponse({}));
  }

  async supplyListSubDept(request: SupplyListSubDeptRequest): Promise<SupplyListSubDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyListSubDeptHeaders({ });
    return await this.supplyListSubDeptWithOptions(request, headers, runtime);
  }

  async supplyQueryPartnerTypeWithOptions(request: SupplyQueryPartnerTypeRequest, headers: SupplyQueryPartnerTypeHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyQueryPartnerTypeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.labelId)) {
      query["labelId"] = request.labelId;
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
      action: "SupplyQueryPartnerType",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/partnerLabels`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyQueryPartnerTypeResponse>(await this.execute(params, req, runtime), new SupplyQueryPartnerTypeResponse({}));
  }

  async supplyQueryPartnerType(request: SupplyQueryPartnerTypeRequest): Promise<SupplyQueryPartnerTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyQueryPartnerTypeHeaders({ });
    return await this.supplyQueryPartnerTypeWithOptions(request, headers, runtime);
  }

  async supplyUpdateMemberWithOptions(request: SupplyUpdateMemberRequest, headers: SupplyUpdateMemberHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyUpdateMemberResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isCopyDept)) {
      body["isCopyDept"] = request.isCopyDept;
    }

    if (!Util.isUnset(request.memberTitle)) {
      body["memberTitle"] = request.memberTitle;
    }

    if (!Util.isUnset(request.memberWorkNumber)) {
      body["memberWorkNumber"] = request.memberWorkNumber;
    }

    if (!Util.isUnset(request.mobile)) {
      body["mobile"] = request.mobile;
    }

    if (!Util.isUnset(request.newDeptId)) {
      body["newDeptId"] = request.newDeptId;
    }

    if (!Util.isUnset(request.oldDeptId)) {
      body["oldDeptId"] = request.oldDeptId;
    }

    if (!Util.isUnset(request.roleIdList)) {
      body["roleIdList"] = request.roleIdList;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "SupplyUpdateMember",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/members`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyUpdateMemberResponse>(await this.execute(params, req, runtime), new SupplyUpdateMemberResponse({}));
  }

  async supplyUpdateMember(request: SupplyUpdateMemberRequest): Promise<SupplyUpdateMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyUpdateMemberHeaders({ });
    return await this.supplyUpdateMemberWithOptions(request, headers, runtime);
  }

  async supplyUpdatePartnerTypeWithOptions(request: SupplyUpdatePartnerTypeRequest, headers: SupplyUpdatePartnerTypeHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyUpdatePartnerTypeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.labelId)) {
      query["labelId"] = request.labelId;
    }

    if (!Util.isUnset(request.name)) {
      query["name"] = request.name;
    }

    if (!Util.isUnset(request.superId)) {
      query["superId"] = request.superId;
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
      action: "SupplyUpdatePartnerType",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/partnerLabels`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyUpdatePartnerTypeResponse>(await this.execute(params, req, runtime), new SupplyUpdatePartnerTypeResponse({}));
  }

  async supplyUpdatePartnerType(request: SupplyUpdatePartnerTypeRequest): Promise<SupplyUpdatePartnerTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyUpdatePartnerTypeHeaders({ });
    return await this.supplyUpdatePartnerTypeWithOptions(request, headers, runtime);
  }

  async supplyUpdateRoleWithOptions(request: SupplyUpdateRoleRequest, headers: SupplyUpdateRoleHeaders, runtime: $Util.RuntimeOptions): Promise<SupplyUpdateRoleResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isRoleGroup)) {
      query["isRoleGroup"] = request.isRoleGroup;
    }

    if (!Util.isUnset(request.roleId)) {
      query["roleId"] = request.roleId;
    }

    if (!Util.isUnset(request.roleName)) {
      query["roleName"] = request.roleName;
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
      action: "SupplyUpdateRole",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/supplyChains/roles`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SupplyUpdateRoleResponse>(await this.execute(params, req, runtime), new SupplyUpdateRoleResponse({}));
  }

  async supplyUpdateRole(request: SupplyUpdateRoleRequest): Promise<SupplyUpdateRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SupplyUpdateRoleHeaders({ });
    return await this.supplyUpdateRoleWithOptions(request, headers, runtime);
  }

  async updateUserExtendInfoWithOptions(userId: string, request: UpdateUserExtendInfoRequest, headers: UpdateUserExtendInfoHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateUserExtendInfoResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "UpdateUserExtendInfo",
      version: "industry_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/industry/medicals/users/${userId}/extInfos`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateUserExtendInfoResponse>(await this.execute(params, req, runtime), new UpdateUserExtendInfoResponse({}));
  }

  async updateUserExtendInfo(userId: string, request: UpdateUserExtendInfoRequest): Promise<UpdateUserExtendInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateUserExtendInfoHeaders({ });
    return await this.updateUserExtendInfoWithOptions(userId, request, headers, runtime);
  }

}
