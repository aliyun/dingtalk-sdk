// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  body: CampusAddRenterMemberResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusCreateCampusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusCreateCampusGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusCreateRenterResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusDelRenterMemberResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusDeleteCampusGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusGetCampusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusGetCampusGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusGetRenterResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusGetRenterMemberResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusListCampusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusListCampusGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusListRenterResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusListRenterMembersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusUpdateCampusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusUpdateCampusGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusUpdateRenterResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CampusUpdateRenterMemberResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CampusUpdateRenterMemberResponseBody,
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
  name?: string;
  rootDeptId?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
      rootDeptId: 'rootDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
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
  body: DigitalStoreContactInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DigitalStoreContactInfoResponseBody,
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
  body: DigitalStoreGroupInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: DigitalStoreGroupsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  id?: number;
  name?: string;
  parentId?: number;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      parentId: 'parentId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
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
  body: DigitalStoreNodeInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: DigitalStoreRightsInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: DigitalStoreRolesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DigitalStoreRolesResponseBody,
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
  body: DigitalStoreStoreInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: DigitalStoreSubNodesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DigitalStoreSubNodesResponseBody,
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
  scopeList?: number[];
  storeList?: number[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      scopeList: 'scopeList',
      storeList: 'storeList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
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
  body: DigitalStoreUserInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: DigitalStoreUsersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DigitalStoreUsersResponseBody,
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
  body: ExternalQueryExternalAppOrgsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: ExternalQueryExternalBelongMainOrgResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: ExternalQueryExternalOrgsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ExternalQueryExternalOrgsResponseBody,
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
  body: IndustryManufactureCommonEventResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: IndustryManufactureMesDispatchTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: IndustryManufactureMesMaterialResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: IndustryManufactureMesOutPlanResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: IndustryManufactureMesOutputResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: IndustryManufactureMesProcessResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: IndustryManufactureMesProductionPlanResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: IndustryManufactureMesSubCooperationTeamResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: IndustryManufactureMesTeamMgmtResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: PushDingMessageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryDepartmentExtendInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryUserCredentialsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  static names(): { [key: string]: string } {
    return {
      level: 'level',
      roleCode: 'roleCode',
      roleId: 'roleId',
      roleName: 'roleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      level: 'number',
      roleCode: 'string',
      roleId: 'number',
      roleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DigitalStoreSubNodesResponseBodyContent extends $tea.Model {
  id?: number;
  name?: string;
  parentId?: number;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      parentId: 'parentId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async campusAddRenterMember(request: CampusAddRenterMemberRequest): Promise<CampusAddRenterMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusAddRenterMemberHeaders({ });
    return await this.campusAddRenterMemberWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusAddRenterMemberResponse>(await this.doROARequest("CampusAddRenterMember", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/campuses/renters/members`, "json", req, runtime), new CampusAddRenterMemberResponse({}));
  }

  async campusCreateCampus(request: CampusCreateCampusRequest): Promise<CampusCreateCampusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusCreateCampusHeaders({ });
    return await this.campusCreateCampusWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusCreateCampusResponse>(await this.doROARequest("CampusCreateCampus", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/campuses/projects`, "json", req, runtime), new CampusCreateCampusResponse({}));
  }

  async campusCreateCampusGroup(request: CampusCreateCampusGroupRequest): Promise<CampusCreateCampusGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusCreateCampusGroupHeaders({ });
    return await this.campusCreateCampusGroupWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusCreateCampusGroupResponse>(await this.doROARequest("CampusCreateCampusGroup", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/campuses/projects/groups`, "json", req, runtime), new CampusCreateCampusGroupResponse({}));
  }

  async campusCreateRenter(request: CampusCreateRenterRequest): Promise<CampusCreateRenterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusCreateRenterHeaders({ });
    return await this.campusCreateRenterWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusCreateRenterResponse>(await this.doROARequest("CampusCreateRenter", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/campuses/renters`, "json", req, runtime), new CampusCreateRenterResponse({}));
  }

  async campusDelRenterMember(request: CampusDelRenterMemberRequest): Promise<CampusDelRenterMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusDelRenterMemberHeaders({ });
    return await this.campusDelRenterMemberWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusDelRenterMemberResponse>(await this.doROARequest("CampusDelRenterMember", "industry_1.0", "HTTP", "DELETE", "AK", `/v1.0/industry/campuses/renters/members`, "json", req, runtime), new CampusDelRenterMemberResponse({}));
  }

  async campusDeleteCampusGroup(request: CampusDeleteCampusGroupRequest): Promise<CampusDeleteCampusGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusDeleteCampusGroupHeaders({ });
    return await this.campusDeleteCampusGroupWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusDeleteCampusGroupResponse>(await this.doROARequest("CampusDeleteCampusGroup", "industry_1.0", "HTTP", "DELETE", "AK", `/v1.0/industry/campuses/projects/groups`, "json", req, runtime), new CampusDeleteCampusGroupResponse({}));
  }

  async campusDeleteRenter(request: CampusDeleteRenterRequest): Promise<CampusDeleteRenterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusDeleteRenterHeaders({ });
    return await this.campusDeleteRenterWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusDeleteRenterResponse>(await this.doROARequest("CampusDeleteRenter", "industry_1.0", "HTTP", "DELETE", "AK", `/v1.0/industry/campuses/renters`, "none", req, runtime), new CampusDeleteRenterResponse({}));
  }

  async campusGetCampus(request: CampusGetCampusRequest): Promise<CampusGetCampusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusGetCampusHeaders({ });
    return await this.campusGetCampusWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusGetCampusResponse>(await this.doROARequest("CampusGetCampus", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/campuses/projectInfos`, "json", req, runtime), new CampusGetCampusResponse({}));
  }

  async campusGetCampusGroup(request: CampusGetCampusGroupRequest): Promise<CampusGetCampusGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusGetCampusGroupHeaders({ });
    return await this.campusGetCampusGroupWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusGetCampusGroupResponse>(await this.doROARequest("CampusGetCampusGroup", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/campuses/projects/groupInfos`, "json", req, runtime), new CampusGetCampusGroupResponse({}));
  }

  async campusGetRenter(request: CampusGetRenterRequest): Promise<CampusGetRenterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusGetRenterHeaders({ });
    return await this.campusGetRenterWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusGetRenterResponse>(await this.doROARequest("CampusGetRenter", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/campuses/renterInfos`, "json", req, runtime), new CampusGetRenterResponse({}));
  }

  async campusGetRenterMember(request: CampusGetRenterMemberRequest): Promise<CampusGetRenterMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusGetRenterMemberHeaders({ });
    return await this.campusGetRenterMemberWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusGetRenterMemberResponse>(await this.doROARequest("CampusGetRenterMember", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/campuses/renters/memberInfos`, "json", req, runtime), new CampusGetRenterMemberResponse({}));
  }

  async campusListCampus(request: CampusListCampusRequest): Promise<CampusListCampusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusListCampusHeaders({ });
    return await this.campusListCampusWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusListCampusResponse>(await this.doROARequest("CampusListCampus", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/campuses/projects`, "json", req, runtime), new CampusListCampusResponse({}));
  }

  async campusListCampusGroup(): Promise<CampusListCampusGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusListCampusGroupHeaders({ });
    return await this.campusListCampusGroupWithOptions(headers, runtime);
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
    return $tea.cast<CampusListCampusGroupResponse>(await this.doROARequest("CampusListCampusGroup", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/campuses/projects/groups`, "json", req, runtime), new CampusListCampusGroupResponse({}));
  }

  async campusListRenter(): Promise<CampusListRenterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusListRenterHeaders({ });
    return await this.campusListRenterWithOptions(headers, runtime);
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
    return $tea.cast<CampusListRenterResponse>(await this.doROARequest("CampusListRenter", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/campuses/renters`, "json", req, runtime), new CampusListRenterResponse({}));
  }

  async campusListRenterMembers(request: CampusListRenterMembersRequest): Promise<CampusListRenterMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusListRenterMembersHeaders({ });
    return await this.campusListRenterMembersWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusListRenterMembersResponse>(await this.doROARequest("CampusListRenterMembers", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/campuses/renters/members`, "json", req, runtime), new CampusListRenterMembersResponse({}));
  }

  async campusUpdateCampus(request: CampusUpdateCampusRequest): Promise<CampusUpdateCampusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusUpdateCampusHeaders({ });
    return await this.campusUpdateCampusWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusUpdateCampusResponse>(await this.doROARequest("CampusUpdateCampus", "industry_1.0", "HTTP", "PUT", "AK", `/v1.0/industry/campuses/projects`, "json", req, runtime), new CampusUpdateCampusResponse({}));
  }

  async campusUpdateCampusGroup(request: CampusUpdateCampusGroupRequest): Promise<CampusUpdateCampusGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusUpdateCampusGroupHeaders({ });
    return await this.campusUpdateCampusGroupWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusUpdateCampusGroupResponse>(await this.doROARequest("CampusUpdateCampusGroup", "industry_1.0", "HTTP", "PUT", "AK", `/v1.0/industry/campuses/projects/groups`, "json", req, runtime), new CampusUpdateCampusGroupResponse({}));
  }

  async campusUpdateRenter(request: CampusUpdateRenterRequest): Promise<CampusUpdateRenterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusUpdateRenterHeaders({ });
    return await this.campusUpdateRenterWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusUpdateRenterResponse>(await this.doROARequest("CampusUpdateRenter", "industry_1.0", "HTTP", "PUT", "AK", `/v1.0/industry/campuses/renters`, "json", req, runtime), new CampusUpdateRenterResponse({}));
  }

  async campusUpdateRenterMember(request: CampusUpdateRenterMemberRequest): Promise<CampusUpdateRenterMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CampusUpdateRenterMemberHeaders({ });
    return await this.campusUpdateRenterMemberWithOptions(request, headers, runtime);
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
    return $tea.cast<CampusUpdateRenterMemberResponse>(await this.doROARequest("CampusUpdateRenterMember", "industry_1.0", "HTTP", "PUT", "AK", `/v1.0/industry/campuses/renters/members`, "json", req, runtime), new CampusUpdateRenterMemberResponse({}));
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

  async digitalStoreContactInfo(): Promise<DigitalStoreContactInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreContactInfoHeaders({ });
    return await this.digitalStoreContactInfoWithOptions(headers, runtime);
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
    return $tea.cast<DigitalStoreContactInfoResponse>(await this.doROARequest("DigitalStoreContactInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/digitalStores/contactInfos`, "json", req, runtime), new DigitalStoreContactInfoResponse({}));
  }

  async digitalStoreGroupInfo(request: DigitalStoreGroupInfoRequest): Promise<DigitalStoreGroupInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreGroupInfoHeaders({ });
    return await this.digitalStoreGroupInfoWithOptions(request, headers, runtime);
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
    return $tea.cast<DigitalStoreGroupInfoResponse>(await this.doROARequest("DigitalStoreGroupInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/digitalStores/groupInfos`, "json", req, runtime), new DigitalStoreGroupInfoResponse({}));
  }

  async digitalStoreGroups(): Promise<DigitalStoreGroupsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreGroupsHeaders({ });
    return await this.digitalStoreGroupsWithOptions(headers, runtime);
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
    return $tea.cast<DigitalStoreGroupsResponse>(await this.doROARequest("DigitalStoreGroups", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/digitalStores/groups`, "json", req, runtime), new DigitalStoreGroupsResponse({}));
  }

  async digitalStoreNodeInfo(request: DigitalStoreNodeInfoRequest): Promise<DigitalStoreNodeInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreNodeInfoHeaders({ });
    return await this.digitalStoreNodeInfoWithOptions(request, headers, runtime);
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
    return $tea.cast<DigitalStoreNodeInfoResponse>(await this.doROARequest("DigitalStoreNodeInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/digitalStores/nodeInfos`, "json", req, runtime), new DigitalStoreNodeInfoResponse({}));
  }

  async digitalStoreRightsInfo(): Promise<DigitalStoreRightsInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreRightsInfoHeaders({ });
    return await this.digitalStoreRightsInfoWithOptions(headers, runtime);
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
    return $tea.cast<DigitalStoreRightsInfoResponse>(await this.doROARequest("DigitalStoreRightsInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/digitalStores/rightsInfos`, "json", req, runtime), new DigitalStoreRightsInfoResponse({}));
  }

  async digitalStoreRoles(): Promise<DigitalStoreRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreRolesHeaders({ });
    return await this.digitalStoreRolesWithOptions(headers, runtime);
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
    return $tea.cast<DigitalStoreRolesResponse>(await this.doROARequest("DigitalStoreRoles", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/digitalStores/roles`, "json", req, runtime), new DigitalStoreRolesResponse({}));
  }

  async digitalStoreStoreInfo(request: DigitalStoreStoreInfoRequest): Promise<DigitalStoreStoreInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreStoreInfoHeaders({ });
    return await this.digitalStoreStoreInfoWithOptions(request, headers, runtime);
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
    return $tea.cast<DigitalStoreStoreInfoResponse>(await this.doROARequest("DigitalStoreStoreInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/digitalStores/storeInfos`, "json", req, runtime), new DigitalStoreStoreInfoResponse({}));
  }

  async digitalStoreSubNodes(request: DigitalStoreSubNodesRequest): Promise<DigitalStoreSubNodesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreSubNodesHeaders({ });
    return await this.digitalStoreSubNodesWithOptions(request, headers, runtime);
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
    return $tea.cast<DigitalStoreSubNodesResponse>(await this.doROARequest("DigitalStoreSubNodes", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/digitalStores/subsidiaryNodes`, "json", req, runtime), new DigitalStoreSubNodesResponse({}));
  }

  async digitalStoreUserInfo(request: DigitalStoreUserInfoRequest): Promise<DigitalStoreUserInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreUserInfoHeaders({ });
    return await this.digitalStoreUserInfoWithOptions(request, headers, runtime);
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
    return $tea.cast<DigitalStoreUserInfoResponse>(await this.doROARequest("DigitalStoreUserInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/digitalStores/userInfos`, "json", req, runtime), new DigitalStoreUserInfoResponse({}));
  }

  async digitalStoreUsers(request: DigitalStoreUsersRequest): Promise<DigitalStoreUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DigitalStoreUsersHeaders({ });
    return await this.digitalStoreUsersWithOptions(request, headers, runtime);
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
    return $tea.cast<DigitalStoreUsersResponse>(await this.doROARequest("DigitalStoreUsers", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/digitalStores/nodes/users`, "json", req, runtime), new DigitalStoreUsersResponse({}));
  }

  async externalQueryExternalAppOrgs(request: ExternalQueryExternalAppOrgsRequest): Promise<ExternalQueryExternalAppOrgsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExternalQueryExternalAppOrgsHeaders({ });
    return await this.externalQueryExternalAppOrgsWithOptions(request, headers, runtime);
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
    return $tea.cast<ExternalQueryExternalAppOrgsResponse>(await this.doROARequest("ExternalQueryExternalAppOrgs", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/externals/apps/organizations`, "json", req, runtime), new ExternalQueryExternalAppOrgsResponse({}));
  }

  async externalQueryExternalBelongMainOrg(request: ExternalQueryExternalBelongMainOrgRequest): Promise<ExternalQueryExternalBelongMainOrgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExternalQueryExternalBelongMainOrgHeaders({ });
    return await this.externalQueryExternalBelongMainOrgWithOptions(request, headers, runtime);
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
    return $tea.cast<ExternalQueryExternalBelongMainOrgResponse>(await this.doROARequest("ExternalQueryExternalBelongMainOrg", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/externals/attributions/masterOrganizations`, "json", req, runtime), new ExternalQueryExternalBelongMainOrgResponse({}));
  }

  async externalQueryExternalOrgs(request: ExternalQueryExternalOrgsRequest): Promise<ExternalQueryExternalOrgsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExternalQueryExternalOrgsHeaders({ });
    return await this.externalQueryExternalOrgsWithOptions(request, headers, runtime);
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
    return $tea.cast<ExternalQueryExternalOrgsResponse>(await this.doROARequest("ExternalQueryExternalOrgs", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/externals/organizations`, "json", req, runtime), new ExternalQueryExternalOrgsResponse({}));
  }

  async industryManufactureCommonEvent(request: IndustryManufactureCommonEventRequest): Promise<IndustryManufactureCommonEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureCommonEventHeaders({ });
    return await this.industryManufactureCommonEventWithOptions(request, headers, runtime);
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
    return $tea.cast<IndustryManufactureCommonEventResponse>(await this.doROARequest("IndustryManufactureCommonEvent", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufacturing/bases/commons/events`, "json", req, runtime), new IndustryManufactureCommonEventResponse({}));
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

  async industryManufactureMesDispatchTask(request: IndustryManufactureMesDispatchTaskRequest): Promise<IndustryManufactureMesDispatchTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMesDispatchTaskHeaders({ });
    return await this.industryManufactureMesDispatchTaskWithOptions(request, headers, runtime);
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
    return $tea.cast<IndustryManufactureMesDispatchTaskResponse>(await this.doROARequest("IndustryManufactureMesDispatchTask", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufacturings/dispatchTasks/manage`, "json", req, runtime), new IndustryManufactureMesDispatchTaskResponse({}));
  }

  async industryManufactureMesMaterial(request: IndustryManufactureMesMaterialRequest): Promise<IndustryManufactureMesMaterialResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMesMaterialHeaders({ });
    return await this.industryManufactureMesMaterialWithOptions(request, headers, runtime);
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
    return $tea.cast<IndustryManufactureMesMaterialResponse>(await this.doROARequest("IndustryManufactureMesMaterial", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufacturings/materials/manage`, "json", req, runtime), new IndustryManufactureMesMaterialResponse({}));
  }

  async industryManufactureMesOutPlan(request: IndustryManufactureMesOutPlanRequest): Promise<IndustryManufactureMesOutPlanResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMesOutPlanHeaders({ });
    return await this.industryManufactureMesOutPlanWithOptions(request, headers, runtime);
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
    return $tea.cast<IndustryManufactureMesOutPlanResponse>(await this.doROARequest("IndustryManufactureMesOutPlan", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufacturings/outPlans/manage`, "json", req, runtime), new IndustryManufactureMesOutPlanResponse({}));
  }

  async industryManufactureMesOutput(request: IndustryManufactureMesOutputRequest): Promise<IndustryManufactureMesOutputResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMesOutputHeaders({ });
    return await this.industryManufactureMesOutputWithOptions(request, headers, runtime);
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
    return $tea.cast<IndustryManufactureMesOutputResponse>(await this.doROARequest("IndustryManufactureMesOutput", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufacturings/outputs/manage`, "json", req, runtime), new IndustryManufactureMesOutputResponse({}));
  }

  async industryManufactureMesProcess(request: IndustryManufactureMesProcessRequest): Promise<IndustryManufactureMesProcessResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMesProcessHeaders({ });
    return await this.industryManufactureMesProcessWithOptions(request, headers, runtime);
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
    return $tea.cast<IndustryManufactureMesProcessResponse>(await this.doROARequest("IndustryManufactureMesProcess", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufacturings/processes/manage`, "json", req, runtime), new IndustryManufactureMesProcessResponse({}));
  }

  async industryManufactureMesProductionPlan(request: IndustryManufactureMesProductionPlanRequest): Promise<IndustryManufactureMesProductionPlanResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMesProductionPlanHeaders({ });
    return await this.industryManufactureMesProductionPlanWithOptions(request, headers, runtime);
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
    return $tea.cast<IndustryManufactureMesProductionPlanResponse>(await this.doROARequest("IndustryManufactureMesProductionPlan", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufacturings/productionPlans/manage`, "json", req, runtime), new IndustryManufactureMesProductionPlanResponse({}));
  }

  async industryManufactureMesSubCooperationTeam(request: IndustryManufactureMesSubCooperationTeamRequest): Promise<IndustryManufactureMesSubCooperationTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMesSubCooperationTeamHeaders({ });
    return await this.industryManufactureMesSubCooperationTeamWithOptions(request, headers, runtime);
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
    return $tea.cast<IndustryManufactureMesSubCooperationTeamResponse>(await this.doROARequest("IndustryManufactureMesSubCooperationTeam", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufacturings/outTeams/manage`, "json", req, runtime), new IndustryManufactureMesSubCooperationTeamResponse({}));
  }

  async industryManufactureMesTeamMgmt(request: IndustryManufactureMesTeamMgmtRequest): Promise<IndustryManufactureMesTeamMgmtResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMesTeamMgmtHeaders({ });
    return await this.industryManufactureMesTeamMgmtWithOptions(request, headers, runtime);
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
    return $tea.cast<IndustryManufactureMesTeamMgmtResponse>(await this.doROARequest("IndustryManufactureMesTeamMgmt", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufacturing/base/data/team`, "json", req, runtime), new IndustryManufactureMesTeamMgmtResponse({}));
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

  async pushDingMessage(request: PushDingMessageRequest): Promise<PushDingMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PushDingMessageHeaders({ });
    return await this.pushDingMessageWithOptions(request, headers, runtime);
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
    return $tea.cast<PushDingMessageResponse>(await this.doROARequest("PushDingMessage", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/works/notice`, "json", req, runtime), new PushDingMessageResponse({}));
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

  async queryDepartmentExtendInfo(request: QueryDepartmentExtendInfoRequest): Promise<QueryDepartmentExtendInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDepartmentExtendInfoHeaders({ });
    return await this.queryDepartmentExtendInfoWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryDepartmentExtendInfoResponse>(await this.doROARequest("QueryDepartmentExtendInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/departments/extensions/infos`, "json", req, runtime), new QueryDepartmentExtendInfoResponse({}));
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

  async queryUserCredentials(request: QueryUserCredentialsRequest): Promise<QueryUserCredentialsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserCredentialsHeaders({ });
    return await this.queryUserCredentialsWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryUserCredentialsResponse>(await this.doROARequest("QueryUserCredentials", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/medicals/users/credentials/query`, "json", req, runtime), new QueryUserCredentialsResponse({}));
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
