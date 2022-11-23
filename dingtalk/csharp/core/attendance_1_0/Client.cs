// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkattendance_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public AddLeaveTypeResponse AddLeaveType(AddLeaveTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddLeaveTypeHeaders headers = new AddLeaveTypeHeaders();
            return AddLeaveTypeWithOptions(request, headers, runtime);
        }

        public async Task<AddLeaveTypeResponse> AddLeaveTypeAsync(AddLeaveTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddLeaveTypeHeaders headers = new AddLeaveTypeHeaders();
            return await AddLeaveTypeWithOptionsAsync(request, headers, runtime);
        }

        public AddLeaveTypeResponse AddLeaveTypeWithOptions(AddLeaveTypeRequest request, AddLeaveTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extras))
            {
                body["extras"] = request.Extras;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoursInPerDay))
            {
                body["hoursInPerDay"] = request.HoursInPerDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCertificate))
            {
                body["leaveCertificate"] = request.LeaveCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveName))
            {
                body["leaveName"] = request.LeaveName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveViewUnit))
            {
                body["leaveViewUnit"] = request.LeaveViewUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NaturalDayLeave))
            {
                body["naturalDayLeave"] = request.NaturalDayLeave;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitTimeRule))
            {
                body["submitTimeRule"] = request.SubmitTimeRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibilityRules))
            {
                body["visibilityRules"] = request.VisibilityRules;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddLeaveTypeResponse>(DoROARequest("AddLeaveType", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/leaves/types", "json", req, runtime));
        }

        public async Task<AddLeaveTypeResponse> AddLeaveTypeWithOptionsAsync(AddLeaveTypeRequest request, AddLeaveTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extras))
            {
                body["extras"] = request.Extras;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoursInPerDay))
            {
                body["hoursInPerDay"] = request.HoursInPerDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCertificate))
            {
                body["leaveCertificate"] = request.LeaveCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveName))
            {
                body["leaveName"] = request.LeaveName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveViewUnit))
            {
                body["leaveViewUnit"] = request.LeaveViewUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NaturalDayLeave))
            {
                body["naturalDayLeave"] = request.NaturalDayLeave;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitTimeRule))
            {
                body["submitTimeRule"] = request.SubmitTimeRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibilityRules))
            {
                body["visibilityRules"] = request.VisibilityRules;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddLeaveTypeResponse>(await DoROARequestAsync("AddLeaveType", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/leaves/types", "json", req, runtime));
        }

        public AttendanceBleDevicesAddResponse AttendanceBleDevicesAdd(AttendanceBleDevicesAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AttendanceBleDevicesAddHeaders headers = new AttendanceBleDevicesAddHeaders();
            return AttendanceBleDevicesAddWithOptions(request, headers, runtime);
        }

        public async Task<AttendanceBleDevicesAddResponse> AttendanceBleDevicesAddAsync(AttendanceBleDevicesAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AttendanceBleDevicesAddHeaders headers = new AttendanceBleDevicesAddHeaders();
            return await AttendanceBleDevicesAddWithOptionsAsync(request, headers, runtime);
        }

        public AttendanceBleDevicesAddResponse AttendanceBleDevicesAddWithOptions(AttendanceBleDevicesAddRequest request, AttendanceBleDevicesAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIdList))
            {
                body["deviceIdList"] = request.DeviceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupKey))
            {
                body["groupKey"] = request.GroupKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AttendanceBleDevicesAddResponse>(DoROARequest("AttendanceBleDevicesAdd", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/group/bledevices", "json", req, runtime));
        }

        public async Task<AttendanceBleDevicesAddResponse> AttendanceBleDevicesAddWithOptionsAsync(AttendanceBleDevicesAddRequest request, AttendanceBleDevicesAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIdList))
            {
                body["deviceIdList"] = request.DeviceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupKey))
            {
                body["groupKey"] = request.GroupKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AttendanceBleDevicesAddResponse>(await DoROARequestAsync("AttendanceBleDevicesAdd", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/group/bledevices", "json", req, runtime));
        }

        public AttendanceBleDevicesQueryResponse AttendanceBleDevicesQuery(AttendanceBleDevicesQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AttendanceBleDevicesQueryHeaders headers = new AttendanceBleDevicesQueryHeaders();
            return AttendanceBleDevicesQueryWithOptions(request, headers, runtime);
        }

        public async Task<AttendanceBleDevicesQueryResponse> AttendanceBleDevicesQueryAsync(AttendanceBleDevicesQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AttendanceBleDevicesQueryHeaders headers = new AttendanceBleDevicesQueryHeaders();
            return await AttendanceBleDevicesQueryWithOptionsAsync(request, headers, runtime);
        }

        public AttendanceBleDevicesQueryResponse AttendanceBleDevicesQueryWithOptions(AttendanceBleDevicesQueryRequest request, AttendanceBleDevicesQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupKey))
            {
                body["groupKey"] = request.GroupKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AttendanceBleDevicesQueryResponse>(DoROARequestWithForm("AttendanceBleDevicesQuery", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/group/bledevices/query", "json", req, runtime));
        }

        public async Task<AttendanceBleDevicesQueryResponse> AttendanceBleDevicesQueryWithOptionsAsync(AttendanceBleDevicesQueryRequest request, AttendanceBleDevicesQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupKey))
            {
                body["groupKey"] = request.GroupKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AttendanceBleDevicesQueryResponse>(await DoROARequestWithFormAsync("AttendanceBleDevicesQuery", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/group/bledevices/query", "json", req, runtime));
        }

        public AttendanceBleDevicesRemoveResponse AttendanceBleDevicesRemove(AttendanceBleDevicesRemoveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AttendanceBleDevicesRemoveHeaders headers = new AttendanceBleDevicesRemoveHeaders();
            return AttendanceBleDevicesRemoveWithOptions(request, headers, runtime);
        }

        public async Task<AttendanceBleDevicesRemoveResponse> AttendanceBleDevicesRemoveAsync(AttendanceBleDevicesRemoveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AttendanceBleDevicesRemoveHeaders headers = new AttendanceBleDevicesRemoveHeaders();
            return await AttendanceBleDevicesRemoveWithOptionsAsync(request, headers, runtime);
        }

        public AttendanceBleDevicesRemoveResponse AttendanceBleDevicesRemoveWithOptions(AttendanceBleDevicesRemoveRequest request, AttendanceBleDevicesRemoveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIdList))
            {
                body["deviceIdList"] = request.DeviceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupKey))
            {
                body["groupKey"] = request.GroupKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AttendanceBleDevicesRemoveResponse>(DoROARequest("AttendanceBleDevicesRemove", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/group/bledevices/remove", "json", req, runtime));
        }

        public async Task<AttendanceBleDevicesRemoveResponse> AttendanceBleDevicesRemoveWithOptionsAsync(AttendanceBleDevicesRemoveRequest request, AttendanceBleDevicesRemoveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIdList))
            {
                body["deviceIdList"] = request.DeviceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupKey))
            {
                body["groupKey"] = request.GroupKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AttendanceBleDevicesRemoveResponse>(await DoROARequestAsync("AttendanceBleDevicesRemove", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/group/bledevices/remove", "json", req, runtime));
        }

        public CheckClosingAccountResponse CheckClosingAccount(CheckClosingAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckClosingAccountHeaders headers = new CheckClosingAccountHeaders();
            return CheckClosingAccountWithOptions(request, headers, runtime);
        }

        public async Task<CheckClosingAccountResponse> CheckClosingAccountAsync(CheckClosingAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckClosingAccountHeaders headers = new CheckClosingAccountHeaders();
            return await CheckClosingAccountWithOptionsAsync(request, headers, runtime);
        }

        public CheckClosingAccountResponse CheckClosingAccountWithOptions(CheckClosingAccountRequest request, CheckClosingAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                body["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTimeRange))
            {
                body["userTimeRange"] = request.UserTimeRange;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CheckClosingAccountResponse>(DoROARequest("CheckClosingAccount", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/closingAccounts/status/query", "json", req, runtime));
        }

        public async Task<CheckClosingAccountResponse> CheckClosingAccountWithOptionsAsync(CheckClosingAccountRequest request, CheckClosingAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                body["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTimeRange))
            {
                body["userTimeRange"] = request.UserTimeRange;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CheckClosingAccountResponse>(await DoROARequestAsync("CheckClosingAccount", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/closingAccounts/status/query", "json", req, runtime));
        }

        public CheckWritePermissionResponse CheckWritePermission(CheckWritePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckWritePermissionHeaders headers = new CheckWritePermissionHeaders();
            return CheckWritePermissionWithOptions(request, headers, runtime);
        }

        public async Task<CheckWritePermissionResponse> CheckWritePermissionAsync(CheckWritePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckWritePermissionHeaders headers = new CheckWritePermissionHeaders();
            return await CheckWritePermissionWithOptionsAsync(request, headers, runtime);
        }

        public CheckWritePermissionResponse CheckWritePermissionWithOptions(CheckWritePermissionRequest request, CheckWritePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityIds))
            {
                body["entityIds"] = request.EntityIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceKey))
            {
                body["resourceKey"] = request.ResourceKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CheckWritePermissionResponse>(DoROARequest("CheckWritePermission", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/writePermissions/query", "json", req, runtime));
        }

        public async Task<CheckWritePermissionResponse> CheckWritePermissionWithOptionsAsync(CheckWritePermissionRequest request, CheckWritePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityIds))
            {
                body["entityIds"] = request.EntityIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceKey))
            {
                body["resourceKey"] = request.ResourceKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CheckWritePermissionResponse>(await DoROARequestAsync("CheckWritePermission", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/writePermissions/query", "json", req, runtime));
        }

        public CreateApproveResponse CreateApprove(CreateApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateApproveHeaders headers = new CreateApproveHeaders();
            return CreateApproveWithOptions(request, headers, runtime);
        }

        public async Task<CreateApproveResponse> CreateApproveAsync(CreateApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateApproveHeaders headers = new CreateApproveHeaders();
            return await CreateApproveWithOptionsAsync(request, headers, runtime);
        }

        public CreateApproveResponse CreateApproveWithOptions(CreateApproveRequest request, CreateApproveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveId))
            {
                body["approveId"] = request.ApproveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserid))
            {
                body["opUserid"] = request.OpUserid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PunchParam))
            {
                body["punchParam"] = request.PunchParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubType))
            {
                body["subType"] = request.SubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                body["tagName"] = request.TagName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userid))
            {
                body["userid"] = request.Userid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateApproveResponse>(DoROARequest("CreateApprove", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/approves", "json", req, runtime));
        }

        public async Task<CreateApproveResponse> CreateApproveWithOptionsAsync(CreateApproveRequest request, CreateApproveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveId))
            {
                body["approveId"] = request.ApproveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserid))
            {
                body["opUserid"] = request.OpUserid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PunchParam))
            {
                body["punchParam"] = request.PunchParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubType))
            {
                body["subType"] = request.SubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                body["tagName"] = request.TagName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userid))
            {
                body["userid"] = request.Userid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateApproveResponse>(await DoROARequestAsync("CreateApprove", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/approves", "json", req, runtime));
        }

        public DeleteWaterMarkTemplateResponse DeleteWaterMarkTemplate(DeleteWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWaterMarkTemplateHeaders headers = new DeleteWaterMarkTemplateHeaders();
            return DeleteWaterMarkTemplateWithOptions(request, headers, runtime);
        }

        public async Task<DeleteWaterMarkTemplateResponse> DeleteWaterMarkTemplateAsync(DeleteWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWaterMarkTemplateHeaders headers = new DeleteWaterMarkTemplateHeaders();
            return await DeleteWaterMarkTemplateWithOptionsAsync(request, headers, runtime);
        }

        public DeleteWaterMarkTemplateResponse DeleteWaterMarkTemplateWithOptions(DeleteWaterMarkTemplateRequest request, DeleteWaterMarkTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                query["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormContent))
            {
                query["formContent"] = request.FormContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemTemplate))
            {
                query["systemTemplate"] = request.SystemTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteWaterMarkTemplateResponse>(DoROARequest("DeleteWaterMarkTemplate", "attendance_1.0", "HTTP", "DELETE", "AK", "/v1.0/attendance/watermarks/templates", "json", req, runtime));
        }

        public async Task<DeleteWaterMarkTemplateResponse> DeleteWaterMarkTemplateWithOptionsAsync(DeleteWaterMarkTemplateRequest request, DeleteWaterMarkTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                query["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormContent))
            {
                query["formContent"] = request.FormContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemTemplate))
            {
                query["systemTemplate"] = request.SystemTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteWaterMarkTemplateResponse>(await DoROARequestAsync("DeleteWaterMarkTemplate", "attendance_1.0", "HTTP", "DELETE", "AK", "/v1.0/attendance/watermarks/templates", "json", req, runtime));
        }

        public DingTalkSecurityCheckResponse DingTalkSecurityCheck(DingTalkSecurityCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DingTalkSecurityCheckHeaders headers = new DingTalkSecurityCheckHeaders();
            return DingTalkSecurityCheckWithOptions(request, headers, runtime);
        }

        public async Task<DingTalkSecurityCheckResponse> DingTalkSecurityCheckAsync(DingTalkSecurityCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DingTalkSecurityCheckHeaders headers = new DingTalkSecurityCheckHeaders();
            return await DingTalkSecurityCheckWithOptionsAsync(request, headers, runtime);
        }

        public DingTalkSecurityCheckResponse DingTalkSecurityCheckWithOptions(DingTalkSecurityCheckRequest request, DingTalkSecurityCheckHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVer))
            {
                body["clientVer"] = request.ClientVer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformVer))
            {
                body["platformVer"] = request.PlatformVer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sec))
            {
                body["sec"] = request.Sec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DingTalkSecurityCheckResponse>(DoROARequest("DingTalkSecurityCheck", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/securities/check", "json", req, runtime));
        }

        public async Task<DingTalkSecurityCheckResponse> DingTalkSecurityCheckWithOptionsAsync(DingTalkSecurityCheckRequest request, DingTalkSecurityCheckHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVer))
            {
                body["clientVer"] = request.ClientVer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformVer))
            {
                body["platformVer"] = request.PlatformVer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sec))
            {
                body["sec"] = request.Sec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DingTalkSecurityCheckResponse>(await DoROARequestAsync("DingTalkSecurityCheck", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/securities/check", "json", req, runtime));
        }

        public GetATManageScopeResponse GetATManageScope(GetATManageScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetATManageScopeHeaders headers = new GetATManageScopeHeaders();
            return GetATManageScopeWithOptions(request, headers, runtime);
        }

        public async Task<GetATManageScopeResponse> GetATManageScopeAsync(GetATManageScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetATManageScopeHeaders headers = new GetATManageScopeHeaders();
            return await GetATManageScopeWithOptionsAsync(request, headers, runtime);
        }

        public GetATManageScopeResponse GetATManageScopeWithOptions(GetATManageScopeRequest request, GetATManageScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetATManageScopeResponse>(DoROARequest("GetATManageScope", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/manageScopes", "json", req, runtime));
        }

        public async Task<GetATManageScopeResponse> GetATManageScopeWithOptionsAsync(GetATManageScopeRequest request, GetATManageScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetATManageScopeResponse>(await DoROARequestAsync("GetATManageScope", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/manageScopes", "json", req, runtime));
        }

        public GetAdjustmentsResponse GetAdjustments(GetAdjustmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAdjustmentsHeaders headers = new GetAdjustmentsHeaders();
            return GetAdjustmentsWithOptions(request, headers, runtime);
        }

        public async Task<GetAdjustmentsResponse> GetAdjustmentsAsync(GetAdjustmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAdjustmentsHeaders headers = new GetAdjustmentsHeaders();
            return await GetAdjustmentsWithOptionsAsync(request, headers, runtime);
        }

        public GetAdjustmentsResponse GetAdjustmentsWithOptions(GetAdjustmentsRequest request, GetAdjustmentsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetAdjustmentsResponse>(DoROARequest("GetAdjustments", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/adjustments", "json", req, runtime));
        }

        public async Task<GetAdjustmentsResponse> GetAdjustmentsWithOptionsAsync(GetAdjustmentsRequest request, GetAdjustmentsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetAdjustmentsResponse>(await DoROARequestAsync("GetAdjustments", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/adjustments", "json", req, runtime));
        }

        public GetCheckInSchemaTemplateResponse GetCheckInSchemaTemplate(GetCheckInSchemaTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCheckInSchemaTemplateHeaders headers = new GetCheckInSchemaTemplateHeaders();
            return GetCheckInSchemaTemplateWithOptions(request, headers, runtime);
        }

        public async Task<GetCheckInSchemaTemplateResponse> GetCheckInSchemaTemplateAsync(GetCheckInSchemaTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCheckInSchemaTemplateHeaders headers = new GetCheckInSchemaTemplateHeaders();
            return await GetCheckInSchemaTemplateWithOptionsAsync(request, headers, runtime);
        }

        public GetCheckInSchemaTemplateResponse GetCheckInSchemaTemplateWithOptions(GetCheckInSchemaTemplateRequest request, GetCheckInSchemaTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["sceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetCheckInSchemaTemplateResponse>(DoROARequest("GetCheckInSchemaTemplate", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/watermarks/templates", "json", req, runtime));
        }

        public async Task<GetCheckInSchemaTemplateResponse> GetCheckInSchemaTemplateWithOptionsAsync(GetCheckInSchemaTemplateRequest request, GetCheckInSchemaTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["sceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetCheckInSchemaTemplateResponse>(await DoROARequestAsync("GetCheckInSchemaTemplate", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/watermarks/templates", "json", req, runtime));
        }

        public GetClosingAccountsResponse GetClosingAccounts(GetClosingAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetClosingAccountsHeaders headers = new GetClosingAccountsHeaders();
            return GetClosingAccountsWithOptions(request, headers, runtime);
        }

        public async Task<GetClosingAccountsResponse> GetClosingAccountsAsync(GetClosingAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetClosingAccountsHeaders headers = new GetClosingAccountsHeaders();
            return await GetClosingAccountsWithOptionsAsync(request, headers, runtime);
        }

        public GetClosingAccountsResponse GetClosingAccountsWithOptions(GetClosingAccountsRequest request, GetClosingAccountsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetClosingAccountsResponse>(DoROARequest("GetClosingAccounts", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/closingAccounts/rules/query", "json", req, runtime));
        }

        public async Task<GetClosingAccountsResponse> GetClosingAccountsWithOptionsAsync(GetClosingAccountsRequest request, GetClosingAccountsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetClosingAccountsResponse>(await DoROARequestAsync("GetClosingAccounts", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/closingAccounts/rules/query", "json", req, runtime));
        }

        public GetLeaveTypeResponse GetLeaveType(GetLeaveTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLeaveTypeHeaders headers = new GetLeaveTypeHeaders();
            return GetLeaveTypeWithOptions(request, headers, runtime);
        }

        public async Task<GetLeaveTypeResponse> GetLeaveTypeAsync(GetLeaveTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLeaveTypeHeaders headers = new GetLeaveTypeHeaders();
            return await GetLeaveTypeWithOptionsAsync(request, headers, runtime);
        }

        public GetLeaveTypeResponse GetLeaveTypeWithOptions(GetLeaveTypeRequest request, GetLeaveTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VacationSource))
            {
                query["vacationSource"] = request.VacationSource;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetLeaveTypeResponse>(DoROARequest("GetLeaveType", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/leaves/types", "json", req, runtime));
        }

        public async Task<GetLeaveTypeResponse> GetLeaveTypeWithOptionsAsync(GetLeaveTypeRequest request, GetLeaveTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VacationSource))
            {
                query["vacationSource"] = request.VacationSource;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetLeaveTypeResponse>(await DoROARequestAsync("GetLeaveType", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/leaves/types", "json", req, runtime));
        }

        public GetMachineResponse GetMachine(string devId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMachineHeaders headers = new GetMachineHeaders();
            return GetMachineWithOptions(devId, headers, runtime);
        }

        public async Task<GetMachineResponse> GetMachineAsync(string devId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMachineHeaders headers = new GetMachineHeaders();
            return await GetMachineWithOptionsAsync(devId, headers, runtime);
        }

        public GetMachineResponse GetMachineWithOptions(string devId, GetMachineHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            devId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(devId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetMachineResponse>(DoROARequest("GetMachine", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/machines/" + devId, "json", req, runtime));
        }

        public async Task<GetMachineResponse> GetMachineWithOptionsAsync(string devId, GetMachineHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            devId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(devId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetMachineResponse>(await DoROARequestAsync("GetMachine", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/machines/" + devId, "json", req, runtime));
        }

        public GetMachineUserResponse GetMachineUser(string devId, GetMachineUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMachineUserHeaders headers = new GetMachineUserHeaders();
            return GetMachineUserWithOptions(devId, request, headers, runtime);
        }

        public async Task<GetMachineUserResponse> GetMachineUserAsync(string devId, GetMachineUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMachineUserHeaders headers = new GetMachineUserHeaders();
            return await GetMachineUserWithOptionsAsync(devId, request, headers, runtime);
        }

        public GetMachineUserResponse GetMachineUserWithOptions(string devId, GetMachineUserRequest request, GetMachineUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            devId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(devId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetMachineUserResponse>(DoROARequest("GetMachineUser", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/machines/getUser/" + devId, "json", req, runtime));
        }

        public async Task<GetMachineUserResponse> GetMachineUserWithOptionsAsync(string devId, GetMachineUserRequest request, GetMachineUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            devId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(devId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetMachineUserResponse>(await DoROARequestAsync("GetMachineUser", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/machines/getUser/" + devId, "json", req, runtime));
        }

        public GetOvertimeSettingResponse GetOvertimeSetting(GetOvertimeSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOvertimeSettingHeaders headers = new GetOvertimeSettingHeaders();
            return GetOvertimeSettingWithOptions(request, headers, runtime);
        }

        public async Task<GetOvertimeSettingResponse> GetOvertimeSettingAsync(GetOvertimeSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOvertimeSettingHeaders headers = new GetOvertimeSettingHeaders();
            return await GetOvertimeSettingWithOptionsAsync(request, headers, runtime);
        }

        public GetOvertimeSettingResponse GetOvertimeSettingWithOptions(GetOvertimeSettingRequest request, GetOvertimeSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OvertimeSettingIds))
            {
                body["overtimeSettingIds"] = request.OvertimeSettingIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetOvertimeSettingResponse>(DoROARequest("GetOvertimeSetting", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/overtimeSettings/query", "json", req, runtime));
        }

        public async Task<GetOvertimeSettingResponse> GetOvertimeSettingWithOptionsAsync(GetOvertimeSettingRequest request, GetOvertimeSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OvertimeSettingIds))
            {
                body["overtimeSettingIds"] = request.OvertimeSettingIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetOvertimeSettingResponse>(await DoROARequestAsync("GetOvertimeSetting", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/overtimeSettings/query", "json", req, runtime));
        }

        public GetSimpleOvertimeSettingResponse GetSimpleOvertimeSetting(GetSimpleOvertimeSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSimpleOvertimeSettingHeaders headers = new GetSimpleOvertimeSettingHeaders();
            return GetSimpleOvertimeSettingWithOptions(request, headers, runtime);
        }

        public async Task<GetSimpleOvertimeSettingResponse> GetSimpleOvertimeSettingAsync(GetSimpleOvertimeSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSimpleOvertimeSettingHeaders headers = new GetSimpleOvertimeSettingHeaders();
            return await GetSimpleOvertimeSettingWithOptionsAsync(request, headers, runtime);
        }

        public GetSimpleOvertimeSettingResponse GetSimpleOvertimeSettingWithOptions(GetSimpleOvertimeSettingRequest request, GetSimpleOvertimeSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetSimpleOvertimeSettingResponse>(DoROARequest("GetSimpleOvertimeSetting", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/overtimeSettings", "json", req, runtime));
        }

        public async Task<GetSimpleOvertimeSettingResponse> GetSimpleOvertimeSettingWithOptionsAsync(GetSimpleOvertimeSettingRequest request, GetSimpleOvertimeSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetSimpleOvertimeSettingResponse>(await DoROARequestAsync("GetSimpleOvertimeSetting", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/overtimeSettings", "json", req, runtime));
        }

        public GetUserHolidaysResponse GetUserHolidays(GetUserHolidaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHolidaysHeaders headers = new GetUserHolidaysHeaders();
            return GetUserHolidaysWithOptions(request, headers, runtime);
        }

        public async Task<GetUserHolidaysResponse> GetUserHolidaysAsync(GetUserHolidaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHolidaysHeaders headers = new GetUserHolidaysHeaders();
            return await GetUserHolidaysWithOptionsAsync(request, headers, runtime);
        }

        public GetUserHolidaysResponse GetUserHolidaysWithOptions(GetUserHolidaysRequest request, GetUserHolidaysHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkDateFrom))
            {
                body["workDateFrom"] = request.WorkDateFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkDateTo))
            {
                body["workDateTo"] = request.WorkDateTo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetUserHolidaysResponse>(DoROARequest("GetUserHolidays", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/holidays", "json", req, runtime));
        }

        public async Task<GetUserHolidaysResponse> GetUserHolidaysWithOptionsAsync(GetUserHolidaysRequest request, GetUserHolidaysHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkDateFrom))
            {
                body["workDateFrom"] = request.WorkDateFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkDateTo))
            {
                body["workDateTo"] = request.WorkDateTo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetUserHolidaysResponse>(await DoROARequestAsync("GetUserHolidays", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/holidays", "json", req, runtime));
        }

        public GroupAddResponse GroupAdd(GroupAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupAddHeaders headers = new GroupAddHeaders();
            return GroupAddWithOptions(request, headers, runtime);
        }

        public async Task<GroupAddResponse> GroupAddAsync(GroupAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupAddHeaders headers = new GroupAddHeaders();
            return await GroupAddWithOptionsAsync(request, headers, runtime);
        }

        public GroupAddResponse GroupAddWithOptions(GroupAddRequest request, GroupAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustmentSettingId))
            {
                body["adjustmentSettingId"] = request.AdjustmentSettingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BleDeviceList))
            {
                body["bleDeviceList"] = request.BleDeviceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckNeedHealthyCode))
            {
                body["checkNeedHealthyCode"] = request.CheckNeedHealthyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultClassId))
            {
                body["defaultClassId"] = request.DefaultClassId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableCheckWhenRest))
            {
                body["disableCheckWhenRest"] = request.DisableCheckWhenRest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableCheckWithoutSchedule))
            {
                body["disableCheckWithoutSchedule"] = request.DisableCheckWithoutSchedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCameraCheck))
            {
                body["enableCameraCheck"] = request.EnableCameraCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEmpSelectClass))
            {
                body["enableEmpSelectClass"] = request.EnableEmpSelectClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFaceCheck))
            {
                body["enableFaceCheck"] = request.EnableFaceCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFaceStrictMode))
            {
                body["enableFaceStrictMode"] = request.EnableFaceStrictMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableNextDay))
            {
                body["enableNextDay"] = request.EnableNextDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutSideUpdateNormalCheck))
            {
                body["enableOutSideUpdateNormalCheck"] = request.EnableOutSideUpdateNormalCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutsideApply))
            {
                body["enableOutsideApply"] = request.EnableOutsideApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutsideCameraCheck))
            {
                body["enableOutsideCameraCheck"] = request.EnableOutsideCameraCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutsideCheck))
            {
                body["enableOutsideCheck"] = request.EnableOutsideCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutsideRemark))
            {
                body["enableOutsideRemark"] = request.EnableOutsideRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePositionBle))
            {
                body["enablePositionBle"] = request.EnablePositionBle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTrimDistance))
            {
                body["enableTrimDistance"] = request.EnableTrimDistance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForbidHideOutSideAddress))
            {
                body["forbidHideOutSideAddress"] = request.ForbidHideOutSideAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeCheckSetting))
            {
                body["freeCheckSetting"] = request.FreeCheckSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeCheckTypeId))
            {
                body["freeCheckTypeId"] = request.FreeCheckTypeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreecheckDayStartMinOffset))
            {
                body["freecheckDayStartMinOffset"] = request.FreecheckDayStartMinOffset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreecheckWorkDays))
            {
                body["freecheckWorkDays"] = request.FreecheckWorkDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerList))
            {
                body["managerList"] = request.ManagerList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMember))
            {
                body["modifyMember"] = request.ModifyMember;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenFaceCheck))
            {
                body["openFaceCheck"] = request.OpenFaceCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutsideCheckApproveModeId))
            {
                body["outsideCheckApproveModeId"] = request.OutsideCheckApproveModeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OvertimeSettingId))
            {
                body["overtimeSettingId"] = request.OvertimeSettingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                body["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Positions))
            {
                body["positions"] = request.Positions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcePermissionMap))
            {
                body["resourcePermissionMap"] = request.ResourcePermissionMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShiftVOList))
            {
                body["shiftVOList"] = request.ShiftVOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipHolidays))
            {
                body["skipHolidays"] = request.SkipHolidays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecialDays))
            {
                body["specialDays"] = request.SpecialDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrimDistance))
            {
                body["trimDistance"] = request.TrimDistance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wifis))
            {
                body["wifis"] = request.Wifis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkdayClassList))
            {
                body["workdayClassList"] = request.WorkdayClassList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GroupAddResponse>(DoROARequest("GroupAdd", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/groups", "json", req, runtime));
        }

        public async Task<GroupAddResponse> GroupAddWithOptionsAsync(GroupAddRequest request, GroupAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustmentSettingId))
            {
                body["adjustmentSettingId"] = request.AdjustmentSettingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BleDeviceList))
            {
                body["bleDeviceList"] = request.BleDeviceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckNeedHealthyCode))
            {
                body["checkNeedHealthyCode"] = request.CheckNeedHealthyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultClassId))
            {
                body["defaultClassId"] = request.DefaultClassId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableCheckWhenRest))
            {
                body["disableCheckWhenRest"] = request.DisableCheckWhenRest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableCheckWithoutSchedule))
            {
                body["disableCheckWithoutSchedule"] = request.DisableCheckWithoutSchedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCameraCheck))
            {
                body["enableCameraCheck"] = request.EnableCameraCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEmpSelectClass))
            {
                body["enableEmpSelectClass"] = request.EnableEmpSelectClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFaceCheck))
            {
                body["enableFaceCheck"] = request.EnableFaceCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFaceStrictMode))
            {
                body["enableFaceStrictMode"] = request.EnableFaceStrictMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableNextDay))
            {
                body["enableNextDay"] = request.EnableNextDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutSideUpdateNormalCheck))
            {
                body["enableOutSideUpdateNormalCheck"] = request.EnableOutSideUpdateNormalCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutsideApply))
            {
                body["enableOutsideApply"] = request.EnableOutsideApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutsideCameraCheck))
            {
                body["enableOutsideCameraCheck"] = request.EnableOutsideCameraCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutsideCheck))
            {
                body["enableOutsideCheck"] = request.EnableOutsideCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutsideRemark))
            {
                body["enableOutsideRemark"] = request.EnableOutsideRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePositionBle))
            {
                body["enablePositionBle"] = request.EnablePositionBle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTrimDistance))
            {
                body["enableTrimDistance"] = request.EnableTrimDistance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForbidHideOutSideAddress))
            {
                body["forbidHideOutSideAddress"] = request.ForbidHideOutSideAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeCheckSetting))
            {
                body["freeCheckSetting"] = request.FreeCheckSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeCheckTypeId))
            {
                body["freeCheckTypeId"] = request.FreeCheckTypeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreecheckDayStartMinOffset))
            {
                body["freecheckDayStartMinOffset"] = request.FreecheckDayStartMinOffset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreecheckWorkDays))
            {
                body["freecheckWorkDays"] = request.FreecheckWorkDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerList))
            {
                body["managerList"] = request.ManagerList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMember))
            {
                body["modifyMember"] = request.ModifyMember;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenFaceCheck))
            {
                body["openFaceCheck"] = request.OpenFaceCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutsideCheckApproveModeId))
            {
                body["outsideCheckApproveModeId"] = request.OutsideCheckApproveModeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OvertimeSettingId))
            {
                body["overtimeSettingId"] = request.OvertimeSettingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                body["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Positions))
            {
                body["positions"] = request.Positions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcePermissionMap))
            {
                body["resourcePermissionMap"] = request.ResourcePermissionMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShiftVOList))
            {
                body["shiftVOList"] = request.ShiftVOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipHolidays))
            {
                body["skipHolidays"] = request.SkipHolidays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecialDays))
            {
                body["specialDays"] = request.SpecialDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrimDistance))
            {
                body["trimDistance"] = request.TrimDistance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wifis))
            {
                body["wifis"] = request.Wifis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkdayClassList))
            {
                body["workdayClassList"] = request.WorkdayClassList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GroupAddResponse>(await DoROARequestAsync("GroupAdd", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/groups", "json", req, runtime));
        }

        public GroupUpdateResponse GroupUpdate(GroupUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupUpdateHeaders headers = new GroupUpdateHeaders();
            return GroupUpdateWithOptions(request, headers, runtime);
        }

        public async Task<GroupUpdateResponse> GroupUpdateAsync(GroupUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupUpdateHeaders headers = new GroupUpdateHeaders();
            return await GroupUpdateWithOptionsAsync(request, headers, runtime);
        }

        public GroupUpdateResponse GroupUpdateWithOptions(GroupUpdateRequest request, GroupUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustmentSettingId))
            {
                body["adjustmentSettingId"] = request.AdjustmentSettingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableCheckWhenRest))
            {
                body["disableCheckWhenRest"] = request.DisableCheckWhenRest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableCheckWithoutSchedule))
            {
                body["disableCheckWithoutSchedule"] = request.DisableCheckWithoutSchedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCameraCheck))
            {
                body["enableCameraCheck"] = request.EnableCameraCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEmpSelectClass))
            {
                body["enableEmpSelectClass"] = request.EnableEmpSelectClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFaceCheck))
            {
                body["enableFaceCheck"] = request.EnableFaceCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFaceStrictMode))
            {
                body["enableFaceStrictMode"] = request.EnableFaceStrictMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutSideUpdateNormalCheck))
            {
                body["enableOutSideUpdateNormalCheck"] = request.EnableOutSideUpdateNormalCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutsideApply))
            {
                body["enableOutsideApply"] = request.EnableOutsideApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutsideCheck))
            {
                body["enableOutsideCheck"] = request.EnableOutsideCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutsideRemark))
            {
                body["enableOutsideRemark"] = request.EnableOutsideRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTrimDistance))
            {
                body["enableTrimDistance"] = request.EnableTrimDistance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForbidHideOutSideAddress))
            {
                body["forbidHideOutSideAddress"] = request.ForbidHideOutSideAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeCheckSetting))
            {
                body["freeCheckSetting"] = request.FreeCheckSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeCheckTypeId))
            {
                body["freeCheckTypeId"] = request.FreeCheckTypeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerList))
            {
                body["managerList"] = request.ManagerList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenFaceCheck))
            {
                body["openFaceCheck"] = request.OpenFaceCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutsideCheckApproveModeId))
            {
                body["outsideCheckApproveModeId"] = request.OutsideCheckApproveModeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OvertimeSettingId))
            {
                body["overtimeSettingId"] = request.OvertimeSettingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                body["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Positions))
            {
                body["positions"] = request.Positions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcePermissionMap))
            {
                body["resourcePermissionMap"] = request.ResourcePermissionMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShiftVOList))
            {
                body["shiftVOList"] = request.ShiftVOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipHolidays))
            {
                body["skipHolidays"] = request.SkipHolidays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrimDistance))
            {
                body["trimDistance"] = request.TrimDistance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkdayClassList))
            {
                body["workdayClassList"] = request.WorkdayClassList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GroupUpdateResponse>(DoROARequest("GroupUpdate", "attendance_1.0", "HTTP", "PUT", "AK", "/v1.0/attendance/groups", "json", req, runtime));
        }

        public async Task<GroupUpdateResponse> GroupUpdateWithOptionsAsync(GroupUpdateRequest request, GroupUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustmentSettingId))
            {
                body["adjustmentSettingId"] = request.AdjustmentSettingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableCheckWhenRest))
            {
                body["disableCheckWhenRest"] = request.DisableCheckWhenRest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableCheckWithoutSchedule))
            {
                body["disableCheckWithoutSchedule"] = request.DisableCheckWithoutSchedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCameraCheck))
            {
                body["enableCameraCheck"] = request.EnableCameraCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEmpSelectClass))
            {
                body["enableEmpSelectClass"] = request.EnableEmpSelectClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFaceCheck))
            {
                body["enableFaceCheck"] = request.EnableFaceCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFaceStrictMode))
            {
                body["enableFaceStrictMode"] = request.EnableFaceStrictMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutSideUpdateNormalCheck))
            {
                body["enableOutSideUpdateNormalCheck"] = request.EnableOutSideUpdateNormalCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutsideApply))
            {
                body["enableOutsideApply"] = request.EnableOutsideApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutsideCheck))
            {
                body["enableOutsideCheck"] = request.EnableOutsideCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutsideRemark))
            {
                body["enableOutsideRemark"] = request.EnableOutsideRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTrimDistance))
            {
                body["enableTrimDistance"] = request.EnableTrimDistance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForbidHideOutSideAddress))
            {
                body["forbidHideOutSideAddress"] = request.ForbidHideOutSideAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeCheckSetting))
            {
                body["freeCheckSetting"] = request.FreeCheckSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeCheckTypeId))
            {
                body["freeCheckTypeId"] = request.FreeCheckTypeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerList))
            {
                body["managerList"] = request.ManagerList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenFaceCheck))
            {
                body["openFaceCheck"] = request.OpenFaceCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutsideCheckApproveModeId))
            {
                body["outsideCheckApproveModeId"] = request.OutsideCheckApproveModeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OvertimeSettingId))
            {
                body["overtimeSettingId"] = request.OvertimeSettingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                body["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Positions))
            {
                body["positions"] = request.Positions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcePermissionMap))
            {
                body["resourcePermissionMap"] = request.ResourcePermissionMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShiftVOList))
            {
                body["shiftVOList"] = request.ShiftVOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipHolidays))
            {
                body["skipHolidays"] = request.SkipHolidays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrimDistance))
            {
                body["trimDistance"] = request.TrimDistance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkdayClassList))
            {
                body["workdayClassList"] = request.WorkdayClassList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GroupUpdateResponse>(await DoROARequestAsync("GroupUpdate", "attendance_1.0", "HTTP", "PUT", "AK", "/v1.0/attendance/groups", "json", req, runtime));
        }

        public InitAndGetLeaveALlocationQuotasResponse InitAndGetLeaveALlocationQuotas(InitAndGetLeaveALlocationQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InitAndGetLeaveALlocationQuotasHeaders headers = new InitAndGetLeaveALlocationQuotasHeaders();
            return InitAndGetLeaveALlocationQuotasWithOptions(request, headers, runtime);
        }

        public async Task<InitAndGetLeaveALlocationQuotasResponse> InitAndGetLeaveALlocationQuotasAsync(InitAndGetLeaveALlocationQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InitAndGetLeaveALlocationQuotasHeaders headers = new InitAndGetLeaveALlocationQuotasHeaders();
            return await InitAndGetLeaveALlocationQuotasWithOptionsAsync(request, headers, runtime);
        }

        public InitAndGetLeaveALlocationQuotasResponse InitAndGetLeaveALlocationQuotasWithOptions(InitAndGetLeaveALlocationQuotasRequest request, InitAndGetLeaveALlocationQuotasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCode))
            {
                query["leaveCode"] = request.LeaveCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InitAndGetLeaveALlocationQuotasResponse>(DoROARequest("InitAndGetLeaveALlocationQuotas", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/leaves/initializations/balances", "json", req, runtime));
        }

        public async Task<InitAndGetLeaveALlocationQuotasResponse> InitAndGetLeaveALlocationQuotasWithOptionsAsync(InitAndGetLeaveALlocationQuotasRequest request, InitAndGetLeaveALlocationQuotasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCode))
            {
                query["leaveCode"] = request.LeaveCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InitAndGetLeaveALlocationQuotasResponse>(await DoROARequestAsync("InitAndGetLeaveALlocationQuotas", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/leaves/initializations/balances", "json", req, runtime));
        }

        public ModifyWaterMarkTemplateResponse ModifyWaterMarkTemplate(ModifyWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyWaterMarkTemplateHeaders headers = new ModifyWaterMarkTemplateHeaders();
            return ModifyWaterMarkTemplateWithOptions(request, headers, runtime);
        }

        public async Task<ModifyWaterMarkTemplateResponse> ModifyWaterMarkTemplateAsync(ModifyWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyWaterMarkTemplateHeaders headers = new ModifyWaterMarkTemplateHeaders();
            return await ModifyWaterMarkTemplateWithOptionsAsync(request, headers, runtime);
        }

        public ModifyWaterMarkTemplateResponse ModifyWaterMarkTemplateWithOptions(ModifyWaterMarkTemplateRequest request, ModifyWaterMarkTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutDesignId))
            {
                body["layoutDesignId"] = request.LayoutDesignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaContent))
            {
                body["schemaContent"] = request.SchemaContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaterMarkId))
            {
                body["waterMarkId"] = request.WaterMarkId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ModifyWaterMarkTemplateResponse>(DoROARequest("ModifyWaterMarkTemplate", "attendance_1.0", "HTTP", "PUT", "AK", "/v1.0/attendance/watermarks/templates", "json", req, runtime));
        }

        public async Task<ModifyWaterMarkTemplateResponse> ModifyWaterMarkTemplateWithOptionsAsync(ModifyWaterMarkTemplateRequest request, ModifyWaterMarkTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutDesignId))
            {
                body["layoutDesignId"] = request.LayoutDesignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaContent))
            {
                body["schemaContent"] = request.SchemaContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaterMarkId))
            {
                body["waterMarkId"] = request.WaterMarkId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ModifyWaterMarkTemplateResponse>(await DoROARequestAsync("ModifyWaterMarkTemplate", "attendance_1.0", "HTTP", "PUT", "AK", "/v1.0/attendance/watermarks/templates", "json", req, runtime));
        }

        public ProcessApproveCreateResponse ProcessApproveCreate(ProcessApproveCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProcessApproveCreateHeaders headers = new ProcessApproveCreateHeaders();
            return ProcessApproveCreateWithOptions(request, headers, runtime);
        }

        public async Task<ProcessApproveCreateResponse> ProcessApproveCreateAsync(ProcessApproveCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProcessApproveCreateHeaders headers = new ProcessApproveCreateHeaders();
            return await ProcessApproveCreateWithOptionsAsync(request, headers, runtime);
        }

        public ProcessApproveCreateResponse ProcessApproveCreateWithOptions(ProcessApproveCreateRequest request, ProcessApproveCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveId))
            {
                body["approveId"] = request.ApproveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PunchParam))
            {
                body["punchParam"] = request.PunchParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubType))
            {
                body["subType"] = request.SubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                body["tagName"] = request.TagName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ProcessApproveCreateResponse>(DoROARequest("ProcessApproveCreate", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/workflows/checkInForms", "json", req, runtime));
        }

        public async Task<ProcessApproveCreateResponse> ProcessApproveCreateWithOptionsAsync(ProcessApproveCreateRequest request, ProcessApproveCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveId))
            {
                body["approveId"] = request.ApproveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PunchParam))
            {
                body["punchParam"] = request.PunchParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubType))
            {
                body["subType"] = request.SubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                body["tagName"] = request.TagName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ProcessApproveCreateResponse>(await DoROARequestAsync("ProcessApproveCreate", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/workflows/checkInForms", "json", req, runtime));
        }

        public SaveCustomWaterMarkTemplateResponse SaveCustomWaterMarkTemplate(SaveCustomWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveCustomWaterMarkTemplateHeaders headers = new SaveCustomWaterMarkTemplateHeaders();
            return SaveCustomWaterMarkTemplateWithOptions(request, headers, runtime);
        }

        public async Task<SaveCustomWaterMarkTemplateResponse> SaveCustomWaterMarkTemplateAsync(SaveCustomWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveCustomWaterMarkTemplateHeaders headers = new SaveCustomWaterMarkTemplateHeaders();
            return await SaveCustomWaterMarkTemplateWithOptionsAsync(request, headers, runtime);
        }

        public SaveCustomWaterMarkTemplateResponse SaveCustomWaterMarkTemplateWithOptions(SaveCustomWaterMarkTemplateRequest request, SaveCustomWaterMarkTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                body["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutDesignId))
            {
                body["layoutDesignId"] = request.LayoutDesignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                body["sceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaContent))
            {
                body["schemaContent"] = request.SchemaContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<SaveCustomWaterMarkTemplateResponse>(DoROARequest("SaveCustomWaterMarkTemplate", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/watermarks/templates", "json", req, runtime));
        }

        public async Task<SaveCustomWaterMarkTemplateResponse> SaveCustomWaterMarkTemplateWithOptionsAsync(SaveCustomWaterMarkTemplateRequest request, SaveCustomWaterMarkTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                body["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutDesignId))
            {
                body["layoutDesignId"] = request.LayoutDesignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                body["sceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaContent))
            {
                body["schemaContent"] = request.SchemaContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<SaveCustomWaterMarkTemplateResponse>(await DoROARequestAsync("SaveCustomWaterMarkTemplate", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/watermarks/templates", "json", req, runtime));
        }

        public SyncScheduleInfoResponse SyncScheduleInfo(SyncScheduleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncScheduleInfoHeaders headers = new SyncScheduleInfoHeaders();
            return SyncScheduleInfoWithOptions(request, headers, runtime);
        }

        public async Task<SyncScheduleInfoResponse> SyncScheduleInfoAsync(SyncScheduleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncScheduleInfoHeaders headers = new SyncScheduleInfoHeaders();
            return await SyncScheduleInfoWithOptionsAsync(request, headers, runtime);
        }

        public SyncScheduleInfoResponse SyncScheduleInfoWithOptions(SyncScheduleInfoRequest request, SyncScheduleInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleInfos))
            {
                body["scheduleInfos"] = request.ScheduleInfos;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<SyncScheduleInfoResponse>(DoROARequest("SyncScheduleInfo", "attendance_1.0", "HTTP", "PUT", "AK", "/v1.0/attendance/schedules/additionalInfo", "none", req, runtime));
        }

        public async Task<SyncScheduleInfoResponse> SyncScheduleInfoWithOptionsAsync(SyncScheduleInfoRequest request, SyncScheduleInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleInfos))
            {
                body["scheduleInfos"] = request.ScheduleInfos;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<SyncScheduleInfoResponse>(await DoROARequestAsync("SyncScheduleInfo", "attendance_1.0", "HTTP", "PUT", "AK", "/v1.0/attendance/schedules/additionalInfo", "none", req, runtime));
        }

        public UpdateLeaveTypeResponse UpdateLeaveType(UpdateLeaveTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateLeaveTypeHeaders headers = new UpdateLeaveTypeHeaders();
            return UpdateLeaveTypeWithOptions(request, headers, runtime);
        }

        public async Task<UpdateLeaveTypeResponse> UpdateLeaveTypeAsync(UpdateLeaveTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateLeaveTypeHeaders headers = new UpdateLeaveTypeHeaders();
            return await UpdateLeaveTypeWithOptionsAsync(request, headers, runtime);
        }

        public UpdateLeaveTypeResponse UpdateLeaveTypeWithOptions(UpdateLeaveTypeRequest request, UpdateLeaveTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extras))
            {
                body["extras"] = request.Extras;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoursInPerDay))
            {
                body["hoursInPerDay"] = request.HoursInPerDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCertificate))
            {
                body["leaveCertificate"] = request.LeaveCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCode))
            {
                body["leaveCode"] = request.LeaveCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveName))
            {
                body["leaveName"] = request.LeaveName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveViewUnit))
            {
                body["leaveViewUnit"] = request.LeaveViewUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NaturalDayLeave))
            {
                body["naturalDayLeave"] = request.NaturalDayLeave;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitTimeRule))
            {
                body["submitTimeRule"] = request.SubmitTimeRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibilityRules))
            {
                body["visibilityRules"] = request.VisibilityRules;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateLeaveTypeResponse>(DoROARequest("UpdateLeaveType", "attendance_1.0", "HTTP", "PUT", "AK", "/v1.0/attendance/leaves/types", "json", req, runtime));
        }

        public async Task<UpdateLeaveTypeResponse> UpdateLeaveTypeWithOptionsAsync(UpdateLeaveTypeRequest request, UpdateLeaveTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extras))
            {
                body["extras"] = request.Extras;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoursInPerDay))
            {
                body["hoursInPerDay"] = request.HoursInPerDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCertificate))
            {
                body["leaveCertificate"] = request.LeaveCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCode))
            {
                body["leaveCode"] = request.LeaveCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveName))
            {
                body["leaveName"] = request.LeaveName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveViewUnit))
            {
                body["leaveViewUnit"] = request.LeaveViewUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NaturalDayLeave))
            {
                body["naturalDayLeave"] = request.NaturalDayLeave;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitTimeRule))
            {
                body["submitTimeRule"] = request.SubmitTimeRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibilityRules))
            {
                body["visibilityRules"] = request.VisibilityRules;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateLeaveTypeResponse>(await DoROARequestAsync("UpdateLeaveType", "attendance_1.0", "HTTP", "PUT", "AK", "/v1.0/attendance/leaves/types", "json", req, runtime));
        }

    }
}
