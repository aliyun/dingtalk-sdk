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
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = _client;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 添加假期规则
         *
         * @param request AddLeaveTypeRequest
         * @param headers AddLeaveTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddLeaveTypeResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreedomLeave))
            {
                body["freedomLeave"] = request.FreedomLeave;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoursInPerDay))
            {
                body["hoursInPerDay"] = request.HoursInPerDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCertificate))
            {
                body["leaveCertificate"] = request.LeaveCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveHourCeil))
            {
                body["leaveHourCeil"] = request.LeaveHourCeil;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveName))
            {
                body["leaveName"] = request.LeaveName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveTimeCeil))
            {
                body["leaveTimeCeil"] = request.LeaveTimeCeil;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveTimeCeilMinUnit))
            {
                body["leaveTimeCeilMinUnit"] = request.LeaveTimeCeilMinUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveViewUnit))
            {
                body["leaveViewUnit"] = request.LeaveViewUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxLeaveTime))
            {
                body["maxLeaveTime"] = request.MaxLeaveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinLeaveHour))
            {
                body["minLeaveHour"] = request.MinLeaveHour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NaturalDayLeave))
            {
                body["naturalDayLeave"] = request.NaturalDayLeave;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidLeave))
            {
                body["paidLeave"] = request.PaidLeave;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitTimeRule))
            {
                body["submitTimeRule"] = request.SubmitTimeRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibilityRules))
            {
                body["visibilityRules"] = request.VisibilityRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhenCanLeave))
            {
                body["whenCanLeave"] = request.WhenCanLeave;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddLeaveType",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/leaves/types",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddLeaveTypeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 添加假期规则
         *
         * @param request AddLeaveTypeRequest
         * @param headers AddLeaveTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddLeaveTypeResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreedomLeave))
            {
                body["freedomLeave"] = request.FreedomLeave;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoursInPerDay))
            {
                body["hoursInPerDay"] = request.HoursInPerDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCertificate))
            {
                body["leaveCertificate"] = request.LeaveCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveHourCeil))
            {
                body["leaveHourCeil"] = request.LeaveHourCeil;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveName))
            {
                body["leaveName"] = request.LeaveName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveTimeCeil))
            {
                body["leaveTimeCeil"] = request.LeaveTimeCeil;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveTimeCeilMinUnit))
            {
                body["leaveTimeCeilMinUnit"] = request.LeaveTimeCeilMinUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveViewUnit))
            {
                body["leaveViewUnit"] = request.LeaveViewUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxLeaveTime))
            {
                body["maxLeaveTime"] = request.MaxLeaveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinLeaveHour))
            {
                body["minLeaveHour"] = request.MinLeaveHour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NaturalDayLeave))
            {
                body["naturalDayLeave"] = request.NaturalDayLeave;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidLeave))
            {
                body["paidLeave"] = request.PaidLeave;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitTimeRule))
            {
                body["submitTimeRule"] = request.SubmitTimeRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibilityRules))
            {
                body["visibilityRules"] = request.VisibilityRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhenCanLeave))
            {
                body["whenCanLeave"] = request.WhenCanLeave;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddLeaveType",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/leaves/types",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddLeaveTypeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 添加假期规则
         *
         * @param request AddLeaveTypeRequest
         * @return AddLeaveTypeResponse
         */
        public AddLeaveTypeResponse AddLeaveType(AddLeaveTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddLeaveTypeHeaders headers = new AddLeaveTypeHeaders();
            return AddLeaveTypeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加假期规则
         *
         * @param request AddLeaveTypeRequest
         * @return AddLeaveTypeResponse
         */
        public async Task<AddLeaveTypeResponse> AddLeaveTypeAsync(AddLeaveTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddLeaveTypeHeaders headers = new AddLeaveTypeHeaders();
            return await AddLeaveTypeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量给考勤组添加蓝牙设备
         *
         * @param request AttendanceBleDevicesAddRequest
         * @param headers AttendanceBleDevicesAddHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttendanceBleDevicesAddResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttendanceBleDevicesAdd",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/group/bledevices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttendanceBleDevicesAddResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量给考勤组添加蓝牙设备
         *
         * @param request AttendanceBleDevicesAddRequest
         * @param headers AttendanceBleDevicesAddHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttendanceBleDevicesAddResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttendanceBleDevicesAdd",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/group/bledevices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttendanceBleDevicesAddResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量给考勤组添加蓝牙设备
         *
         * @param request AttendanceBleDevicesAddRequest
         * @return AttendanceBleDevicesAddResponse
         */
        public AttendanceBleDevicesAddResponse AttendanceBleDevicesAdd(AttendanceBleDevicesAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AttendanceBleDevicesAddHeaders headers = new AttendanceBleDevicesAddHeaders();
            return AttendanceBleDevicesAddWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量给考勤组添加蓝牙设备
         *
         * @param request AttendanceBleDevicesAddRequest
         * @return AttendanceBleDevicesAddResponse
         */
        public async Task<AttendanceBleDevicesAddResponse> AttendanceBleDevicesAddAsync(AttendanceBleDevicesAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AttendanceBleDevicesAddHeaders headers = new AttendanceBleDevicesAddHeaders();
            return await AttendanceBleDevicesAddWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询蓝牙设备
         *
         * @param request AttendanceBleDevicesQueryRequest
         * @param headers AttendanceBleDevicesQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttendanceBleDevicesQueryResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttendanceBleDevicesQuery",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/group/bledevices/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttendanceBleDevicesQueryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量查询蓝牙设备
         *
         * @param request AttendanceBleDevicesQueryRequest
         * @param headers AttendanceBleDevicesQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttendanceBleDevicesQueryResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttendanceBleDevicesQuery",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/group/bledevices/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttendanceBleDevicesQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询蓝牙设备
         *
         * @param request AttendanceBleDevicesQueryRequest
         * @return AttendanceBleDevicesQueryResponse
         */
        public AttendanceBleDevicesQueryResponse AttendanceBleDevicesQuery(AttendanceBleDevicesQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AttendanceBleDevicesQueryHeaders headers = new AttendanceBleDevicesQueryHeaders();
            return AttendanceBleDevicesQueryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询蓝牙设备
         *
         * @param request AttendanceBleDevicesQueryRequest
         * @return AttendanceBleDevicesQueryResponse
         */
        public async Task<AttendanceBleDevicesQueryResponse> AttendanceBleDevicesQueryAsync(AttendanceBleDevicesQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AttendanceBleDevicesQueryHeaders headers = new AttendanceBleDevicesQueryHeaders();
            return await AttendanceBleDevicesQueryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量删除考勤组的蓝牙设备
         *
         * @param request AttendanceBleDevicesRemoveRequest
         * @param headers AttendanceBleDevicesRemoveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttendanceBleDevicesRemoveResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttendanceBleDevicesRemove",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/group/bledevices/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttendanceBleDevicesRemoveResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量删除考勤组的蓝牙设备
         *
         * @param request AttendanceBleDevicesRemoveRequest
         * @param headers AttendanceBleDevicesRemoveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttendanceBleDevicesRemoveResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttendanceBleDevicesRemove",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/group/bledevices/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttendanceBleDevicesRemoveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量删除考勤组的蓝牙设备
         *
         * @param request AttendanceBleDevicesRemoveRequest
         * @return AttendanceBleDevicesRemoveResponse
         */
        public AttendanceBleDevicesRemoveResponse AttendanceBleDevicesRemove(AttendanceBleDevicesRemoveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AttendanceBleDevicesRemoveHeaders headers = new AttendanceBleDevicesRemoveHeaders();
            return AttendanceBleDevicesRemoveWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量删除考勤组的蓝牙设备
         *
         * @param request AttendanceBleDevicesRemoveRequest
         * @return AttendanceBleDevicesRemoveResponse
         */
        public async Task<AttendanceBleDevicesRemoveResponse> AttendanceBleDevicesRemoveAsync(AttendanceBleDevicesRemoveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AttendanceBleDevicesRemoveHeaders headers = new AttendanceBleDevicesRemoveHeaders();
            return await AttendanceBleDevicesRemoveWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量修改考勤结果
         *
         * @param request BatchBossCheckRequest
         * @param headers BatchBossCheckHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchBossCheckResponse
         */
        public BatchBossCheckResponse BatchBossCheckWithOptions(BatchBossCheckRequest request, BatchBossCheckHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Models))
            {
                body["models"] = request.Models;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchBossCheck",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/results/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchBossCheckResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量修改考勤结果
         *
         * @param request BatchBossCheckRequest
         * @param headers BatchBossCheckHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchBossCheckResponse
         */
        public async Task<BatchBossCheckResponse> BatchBossCheckWithOptionsAsync(BatchBossCheckRequest request, BatchBossCheckHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Models))
            {
                body["models"] = request.Models;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchBossCheck",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/results/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchBossCheckResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量修改考勤结果
         *
         * @param request BatchBossCheckRequest
         * @return BatchBossCheckResponse
         */
        public BatchBossCheckResponse BatchBossCheck(BatchBossCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchBossCheckHeaders headers = new BatchBossCheckHeaders();
            return BatchBossCheckWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量修改考勤结果
         *
         * @param request BatchBossCheckRequest
         * @return BatchBossCheckResponse
         */
        public async Task<BatchBossCheckResponse> BatchBossCheckAsync(BatchBossCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchBossCheckHeaders headers = new BatchBossCheckHeaders();
            return await BatchBossCheckWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 预计算时长
         *
         * @param request CalculateDurationRequest
         * @param headers CalculateDurationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CalculateDurationResponse
         */
        public CalculateDurationResponse CalculateDurationWithOptions(CalculateDurationRequest request, CalculateDurationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalculateModel))
            {
                body["calculateModel"] = request.CalculateModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationUnit))
            {
                body["durationUnit"] = request.DurationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTime))
            {
                body["fromTime"] = request.FromTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCode))
            {
                body["leaveCode"] = request.LeaveCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTime))
            {
                body["toTime"] = request.ToTime;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CalculateDuration",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/approvals/durations/calculate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CalculateDurationResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 预计算时长
         *
         * @param request CalculateDurationRequest
         * @param headers CalculateDurationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CalculateDurationResponse
         */
        public async Task<CalculateDurationResponse> CalculateDurationWithOptionsAsync(CalculateDurationRequest request, CalculateDurationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalculateModel))
            {
                body["calculateModel"] = request.CalculateModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationUnit))
            {
                body["durationUnit"] = request.DurationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTime))
            {
                body["fromTime"] = request.FromTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCode))
            {
                body["leaveCode"] = request.LeaveCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTime))
            {
                body["toTime"] = request.ToTime;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CalculateDuration",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/approvals/durations/calculate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CalculateDurationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 预计算时长
         *
         * @param request CalculateDurationRequest
         * @return CalculateDurationResponse
         */
        public CalculateDurationResponse CalculateDuration(CalculateDurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CalculateDurationHeaders headers = new CalculateDurationHeaders();
            return CalculateDurationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 预计算时长
         *
         * @param request CalculateDurationRequest
         * @return CalculateDurationResponse
         */
        public async Task<CalculateDurationResponse> CalculateDurationAsync(CalculateDurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CalculateDurationHeaders headers = new CalculateDurationHeaders();
            return await CalculateDurationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 针对某些员工某段时间内封账状态的查询
         *
         * @param request CheckClosingAccountRequest
         * @param headers CheckClosingAccountHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckClosingAccountResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckClosingAccount",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/closingAccounts/status/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckClosingAccountResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 针对某些员工某段时间内封账状态的查询
         *
         * @param request CheckClosingAccountRequest
         * @param headers CheckClosingAccountHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckClosingAccountResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckClosingAccount",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/closingAccounts/status/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckClosingAccountResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 针对某些员工某段时间内封账状态的查询
         *
         * @param request CheckClosingAccountRequest
         * @return CheckClosingAccountResponse
         */
        public CheckClosingAccountResponse CheckClosingAccount(CheckClosingAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckClosingAccountHeaders headers = new CheckClosingAccountHeaders();
            return CheckClosingAccountWithOptions(request, headers, runtime);
        }

        /**
         * @summary 针对某些员工某段时间内封账状态的查询
         *
         * @param request CheckClosingAccountRequest
         * @return CheckClosingAccountResponse
         */
        public async Task<CheckClosingAccountResponse> CheckClosingAccountAsync(CheckClosingAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckClosingAccountHeaders headers = new CheckClosingAccountHeaders();
            return await CheckClosingAccountWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 考勤资源的写权限查询
         *
         * @param request CheckWritePermissionRequest
         * @param headers CheckWritePermissionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckWritePermissionResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckWritePermission",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/writePermissions/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckWritePermissionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 考勤资源的写权限查询
         *
         * @param request CheckWritePermissionRequest
         * @param headers CheckWritePermissionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckWritePermissionResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckWritePermission",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/writePermissions/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckWritePermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 考勤资源的写权限查询
         *
         * @param request CheckWritePermissionRequest
         * @return CheckWritePermissionResponse
         */
        public CheckWritePermissionResponse CheckWritePermission(CheckWritePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckWritePermissionHeaders headers = new CheckWritePermissionHeaders();
            return CheckWritePermissionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 考勤资源的写权限查询
         *
         * @param request CheckWritePermissionRequest
         * @return CheckWritePermissionResponse
         */
        public async Task<CheckWritePermissionResponse> CheckWritePermissionAsync(CheckWritePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckWritePermissionHeaders headers = new CheckWritePermissionHeaders();
            return await CheckWritePermissionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建考勤打卡审批单
         *
         * @param request CreateApproveRequest
         * @param headers CreateApproveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateApproveResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApprove",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/approves",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApproveResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建考勤打卡审批单
         *
         * @param request CreateApproveRequest
         * @param headers CreateApproveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateApproveResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApprove",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/approves",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApproveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建考勤打卡审批单
         *
         * @param request CreateApproveRequest
         * @return CreateApproveResponse
         */
        public CreateApproveResponse CreateApprove(CreateApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateApproveHeaders headers = new CreateApproveHeaders();
            return CreateApproveWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建考勤打卡审批单
         *
         * @param request CreateApproveRequest
         * @return CreateApproveResponse
         */
        public async Task<CreateApproveResponse> CreateApproveAsync(CreateApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateApproveHeaders headers = new CreateApproveHeaders();
            return await CreateApproveWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 撤销请假
         *
         * @param request DeleteLeaveRequestRequest
         * @param headers DeleteLeaveRequestHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLeaveRequestResponse
         */
        public DeleteLeaveRequestResponse DeleteLeaveRequestWithOptions(string unionId, DeleteLeaveRequestRequest request, DeleteLeaveRequestHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                body["outerId"] = request.OuterId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLeaveRequest",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/users/" + unionId + "/vacations/records/revoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLeaveRequestResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 撤销请假
         *
         * @param request DeleteLeaveRequestRequest
         * @param headers DeleteLeaveRequestHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLeaveRequestResponse
         */
        public async Task<DeleteLeaveRequestResponse> DeleteLeaveRequestWithOptionsAsync(string unionId, DeleteLeaveRequestRequest request, DeleteLeaveRequestHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                body["outerId"] = request.OuterId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLeaveRequest",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/users/" + unionId + "/vacations/records/revoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLeaveRequestResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 撤销请假
         *
         * @param request DeleteLeaveRequestRequest
         * @return DeleteLeaveRequestResponse
         */
        public DeleteLeaveRequestResponse DeleteLeaveRequest(string unionId, DeleteLeaveRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteLeaveRequestHeaders headers = new DeleteLeaveRequestHeaders();
            return DeleteLeaveRequestWithOptions(unionId, request, headers, runtime);
        }

        /**
         * @summary 撤销请假
         *
         * @param request DeleteLeaveRequestRequest
         * @return DeleteLeaveRequestResponse
         */
        public async Task<DeleteLeaveRequestResponse> DeleteLeaveRequestAsync(string unionId, DeleteLeaveRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteLeaveRequestHeaders headers = new DeleteLeaveRequestHeaders();
            return await DeleteLeaveRequestWithOptionsAsync(unionId, request, headers, runtime);
        }

        /**
         * @summary 删除水印模板
         *
         * @param request DeleteWaterMarkTemplateRequest
         * @param headers DeleteWaterMarkTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWaterMarkTemplateResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWaterMarkTemplate",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/watermarks/templates",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWaterMarkTemplateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除水印模板
         *
         * @param request DeleteWaterMarkTemplateRequest
         * @param headers DeleteWaterMarkTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWaterMarkTemplateResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWaterMarkTemplate",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/watermarks/templates",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWaterMarkTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除水印模板
         *
         * @param request DeleteWaterMarkTemplateRequest
         * @return DeleteWaterMarkTemplateResponse
         */
        public DeleteWaterMarkTemplateResponse DeleteWaterMarkTemplate(DeleteWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWaterMarkTemplateHeaders headers = new DeleteWaterMarkTemplateHeaders();
            return DeleteWaterMarkTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除水印模板
         *
         * @param request DeleteWaterMarkTemplateRequest
         * @return DeleteWaterMarkTemplateResponse
         */
        public async Task<DeleteWaterMarkTemplateResponse> DeleteWaterMarkTemplateAsync(DeleteWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWaterMarkTemplateHeaders headers = new DeleteWaterMarkTemplateHeaders();
            return await DeleteWaterMarkTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 钉钉安全检查
         *
         * @param request DingTalkSecurityCheckRequest
         * @param headers DingTalkSecurityCheckHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DingTalkSecurityCheckResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DingTalkSecurityCheck",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/securities/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DingTalkSecurityCheckResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 钉钉安全检查
         *
         * @param request DingTalkSecurityCheckRequest
         * @param headers DingTalkSecurityCheckHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DingTalkSecurityCheckResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DingTalkSecurityCheck",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/securities/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DingTalkSecurityCheckResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 钉钉安全检查
         *
         * @param request DingTalkSecurityCheckRequest
         * @return DingTalkSecurityCheckResponse
         */
        public DingTalkSecurityCheckResponse DingTalkSecurityCheck(DingTalkSecurityCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DingTalkSecurityCheckHeaders headers = new DingTalkSecurityCheckHeaders();
            return DingTalkSecurityCheckWithOptions(request, headers, runtime);
        }

        /**
         * @summary 钉钉安全检查
         *
         * @param request DingTalkSecurityCheckRequest
         * @return DingTalkSecurityCheckResponse
         */
        public async Task<DingTalkSecurityCheckResponse> DingTalkSecurityCheckAsync(DingTalkSecurityCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DingTalkSecurityCheckHeaders headers = new DingTalkSecurityCheckHeaders();
            return await DingTalkSecurityCheckWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询管理员管理范围下的userid
         *
         * @param request GetATManageScopeRequest
         * @param headers GetATManageScopeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetATManageScopeResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetATManageScope",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/manageScopes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetATManageScopeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询管理员管理范围下的userid
         *
         * @param request GetATManageScopeRequest
         * @param headers GetATManageScopeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetATManageScopeResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetATManageScope",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/manageScopes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetATManageScopeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询管理员管理范围下的userid
         *
         * @param request GetATManageScopeRequest
         * @return GetATManageScopeResponse
         */
        public GetATManageScopeResponse GetATManageScope(GetATManageScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetATManageScopeHeaders headers = new GetATManageScopeHeaders();
            return GetATManageScopeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询管理员管理范围下的userid
         *
         * @param request GetATManageScopeRequest
         * @return GetATManageScopeResponse
         */
        public async Task<GetATManageScopeResponse> GetATManageScopeAsync(GetATManageScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetATManageScopeHeaders headers = new GetATManageScopeHeaders();
            return await GetATManageScopeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取补卡规则列表
         *
         * @param request GetAdjustmentsRequest
         * @param headers GetAdjustmentsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAdjustmentsResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdjustments",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/adjustments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdjustmentsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取补卡规则列表
         *
         * @param request GetAdjustmentsRequest
         * @param headers GetAdjustmentsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAdjustmentsResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdjustments",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/adjustments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdjustmentsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取补卡规则列表
         *
         * @param request GetAdjustmentsRequest
         * @return GetAdjustmentsResponse
         */
        public GetAdjustmentsResponse GetAdjustments(GetAdjustmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAdjustmentsHeaders headers = new GetAdjustmentsHeaders();
            return GetAdjustmentsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取补卡规则列表
         *
         * @param request GetAdjustmentsRequest
         * @return GetAdjustmentsResponse
         */
        public async Task<GetAdjustmentsResponse> GetAdjustmentsAsync(GetAdjustmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAdjustmentsHeaders headers = new GetAdjustmentsHeaders();
            return await GetAdjustmentsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取水印打卡模板
         *
         * @param request GetCheckInSchemaTemplateRequest
         * @param headers GetCheckInSchemaTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCheckInSchemaTemplateResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCheckInSchemaTemplate",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/watermarks/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCheckInSchemaTemplateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取水印打卡模板
         *
         * @param request GetCheckInSchemaTemplateRequest
         * @param headers GetCheckInSchemaTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCheckInSchemaTemplateResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCheckInSchemaTemplate",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/watermarks/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCheckInSchemaTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取水印打卡模板
         *
         * @param request GetCheckInSchemaTemplateRequest
         * @return GetCheckInSchemaTemplateResponse
         */
        public GetCheckInSchemaTemplateResponse GetCheckInSchemaTemplate(GetCheckInSchemaTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCheckInSchemaTemplateHeaders headers = new GetCheckInSchemaTemplateHeaders();
            return GetCheckInSchemaTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取水印打卡模板
         *
         * @param request GetCheckInSchemaTemplateRequest
         * @return GetCheckInSchemaTemplateResponse
         */
        public async Task<GetCheckInSchemaTemplateResponse> GetCheckInSchemaTemplateAsync(GetCheckInSchemaTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCheckInSchemaTemplateHeaders headers = new GetCheckInSchemaTemplateHeaders();
            return await GetCheckInSchemaTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 调用本接口，获取用户签到记录。
         *
         * @param request GetCheckinRecordByUserRequest
         * @param headers GetCheckinRecordByUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCheckinRecordByUserResponse
         */
        public GetCheckinRecordByUserResponse GetCheckinRecordByUserWithOptions(GetCheckinRecordByUserRequest request, GetCheckinRecordByUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCheckinRecordByUser",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/checkin/records/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCheckinRecordByUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 调用本接口，获取用户签到记录。
         *
         * @param request GetCheckinRecordByUserRequest
         * @param headers GetCheckinRecordByUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCheckinRecordByUserResponse
         */
        public async Task<GetCheckinRecordByUserResponse> GetCheckinRecordByUserWithOptionsAsync(GetCheckinRecordByUserRequest request, GetCheckinRecordByUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCheckinRecordByUser",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/checkin/records/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCheckinRecordByUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 调用本接口，获取用户签到记录。
         *
         * @param request GetCheckinRecordByUserRequest
         * @return GetCheckinRecordByUserResponse
         */
        public GetCheckinRecordByUserResponse GetCheckinRecordByUser(GetCheckinRecordByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCheckinRecordByUserHeaders headers = new GetCheckinRecordByUserHeaders();
            return GetCheckinRecordByUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 调用本接口，获取用户签到记录。
         *
         * @param request GetCheckinRecordByUserRequest
         * @return GetCheckinRecordByUserResponse
         */
        public async Task<GetCheckinRecordByUserResponse> GetCheckinRecordByUserAsync(GetCheckinRecordByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCheckinRecordByUserHeaders headers = new GetCheckinRecordByUserHeaders();
            return await GetCheckinRecordByUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 班次查询（包含已删除班次）
         *
         * @param headers GetClassWithDeletedHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClassWithDeletedResponse
         */
        public GetClassWithDeletedResponse GetClassWithDeletedWithOptions(string classId, GetClassWithDeletedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClassWithDeleted",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/classWithDeleted/" + classId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClassWithDeletedResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 班次查询（包含已删除班次）
         *
         * @param headers GetClassWithDeletedHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClassWithDeletedResponse
         */
        public async Task<GetClassWithDeletedResponse> GetClassWithDeletedWithOptionsAsync(string classId, GetClassWithDeletedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClassWithDeleted",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/classWithDeleted/" + classId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClassWithDeletedResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 班次查询（包含已删除班次）
         *
         * @return GetClassWithDeletedResponse
         */
        public GetClassWithDeletedResponse GetClassWithDeleted(string classId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetClassWithDeletedHeaders headers = new GetClassWithDeletedHeaders();
            return GetClassWithDeletedWithOptions(classId, headers, runtime);
        }

        /**
         * @summary 班次查询（包含已删除班次）
         *
         * @return GetClassWithDeletedResponse
         */
        public async Task<GetClassWithDeletedResponse> GetClassWithDeletedAsync(string classId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetClassWithDeletedHeaders headers = new GetClassWithDeletedHeaders();
            return await GetClassWithDeletedWithOptionsAsync(classId, headers, runtime);
        }

        /**
         * @summary 查询指定用户的封账规则
         *
         * @param request GetClosingAccountsRequest
         * @param headers GetClosingAccountsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClosingAccountsResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClosingAccounts",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/closingAccounts/rules/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClosingAccountsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询指定用户的封账规则
         *
         * @param request GetClosingAccountsRequest
         * @param headers GetClosingAccountsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClosingAccountsResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClosingAccounts",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/closingAccounts/rules/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClosingAccountsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询指定用户的封账规则
         *
         * @param request GetClosingAccountsRequest
         * @return GetClosingAccountsResponse
         */
        public GetClosingAccountsResponse GetClosingAccounts(GetClosingAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetClosingAccountsHeaders headers = new GetClosingAccountsHeaders();
            return GetClosingAccountsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询指定用户的封账规则
         *
         * @param request GetClosingAccountsRequest
         * @return GetClosingAccountsResponse
         */
        public async Task<GetClosingAccountsResponse> GetClosingAccountsAsync(GetClosingAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetClosingAccountsHeaders headers = new GetClosingAccountsHeaders();
            return await GetClosingAccountsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取多个用户的智能考勤报表的列值
         *
         * @param request GetColumnvalsRequest
         * @param headers GetColumnvalsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetColumnvalsResponse
         */
        public GetColumnvalsResponse GetColumnvalsWithOptions(GetColumnvalsRequest request, GetColumnvalsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnIdList))
            {
                body["columnIdList"] = request.ColumnIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDate))
            {
                body["fromDate"] = request.FromDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDate))
            {
                body["toDate"] = request.ToDate;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetColumnvals",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/columnValues/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetColumnvalsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取多个用户的智能考勤报表的列值
         *
         * @param request GetColumnvalsRequest
         * @param headers GetColumnvalsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetColumnvalsResponse
         */
        public async Task<GetColumnvalsResponse> GetColumnvalsWithOptionsAsync(GetColumnvalsRequest request, GetColumnvalsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnIdList))
            {
                body["columnIdList"] = request.ColumnIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDate))
            {
                body["fromDate"] = request.FromDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDate))
            {
                body["toDate"] = request.ToDate;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetColumnvals",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/columnValues/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetColumnvalsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取多个用户的智能考勤报表的列值
         *
         * @param request GetColumnvalsRequest
         * @return GetColumnvalsResponse
         */
        public GetColumnvalsResponse GetColumnvals(GetColumnvalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetColumnvalsHeaders headers = new GetColumnvalsHeaders();
            return GetColumnvalsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取多个用户的智能考勤报表的列值
         *
         * @param request GetColumnvalsRequest
         * @return GetColumnvalsResponse
         */
        public async Task<GetColumnvalsResponse> GetColumnvalsAsync(GetColumnvalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetColumnvalsHeaders headers = new GetColumnvalsHeaders();
            return await GetColumnvalsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询员工假期余额变更记录
         *
         * @param request GetLeaveRecordsRequest
         * @param headers GetLeaveRecordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLeaveRecordsResponse
         */
        public GetLeaveRecordsResponse GetLeaveRecordsWithOptions(GetLeaveRecordsRequest request, GetLeaveRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCode))
            {
                body["leaveCode"] = request.LeaveCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLeaveRecords",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/vacations/records/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLeaveRecordsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量查询员工假期余额变更记录
         *
         * @param request GetLeaveRecordsRequest
         * @param headers GetLeaveRecordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLeaveRecordsResponse
         */
        public async Task<GetLeaveRecordsResponse> GetLeaveRecordsWithOptionsAsync(GetLeaveRecordsRequest request, GetLeaveRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCode))
            {
                body["leaveCode"] = request.LeaveCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLeaveRecords",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/vacations/records/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLeaveRecordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询员工假期余额变更记录
         *
         * @param request GetLeaveRecordsRequest
         * @return GetLeaveRecordsResponse
         */
        public GetLeaveRecordsResponse GetLeaveRecords(GetLeaveRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLeaveRecordsHeaders headers = new GetLeaveRecordsHeaders();
            return GetLeaveRecordsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询员工假期余额变更记录
         *
         * @param request GetLeaveRecordsRequest
         * @return GetLeaveRecordsResponse
         */
        public async Task<GetLeaveRecordsResponse> GetLeaveRecordsAsync(GetLeaveRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLeaveRecordsHeaders headers = new GetLeaveRecordsHeaders();
            return await GetLeaveRecordsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询假期规则列表
         *
         * @param request GetLeaveTypeRequest
         * @param headers GetLeaveTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLeaveTypeResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLeaveType",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/leaves/types",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLeaveTypeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询假期规则列表
         *
         * @param request GetLeaveTypeRequest
         * @param headers GetLeaveTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLeaveTypeResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLeaveType",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/leaves/types",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLeaveTypeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询假期规则列表
         *
         * @param request GetLeaveTypeRequest
         * @return GetLeaveTypeResponse
         */
        public GetLeaveTypeResponse GetLeaveType(GetLeaveTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLeaveTypeHeaders headers = new GetLeaveTypeHeaders();
            return GetLeaveTypeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询假期规则列表
         *
         * @param request GetLeaveTypeRequest
         * @return GetLeaveTypeResponse
         */
        public async Task<GetLeaveTypeResponse> GetLeaveTypeAsync(GetLeaveTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLeaveTypeHeaders headers = new GetLeaveTypeHeaders();
            return await GetLeaveTypeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据设备id获取考勤机信息
         *
         * @param headers GetMachineHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMachineResponse
         */
        public GetMachineResponse GetMachineWithOptions(string devId, GetMachineHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMachine",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/machines/" + devId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMachineResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据设备id获取考勤机信息
         *
         * @param headers GetMachineHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMachineResponse
         */
        public async Task<GetMachineResponse> GetMachineWithOptionsAsync(string devId, GetMachineHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMachine",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/machines/" + devId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMachineResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据设备id获取考勤机信息
         *
         * @return GetMachineResponse
         */
        public GetMachineResponse GetMachine(string devId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMachineHeaders headers = new GetMachineHeaders();
            return GetMachineWithOptions(devId, headers, runtime);
        }

        /**
         * @summary 根据设备id获取考勤机信息
         *
         * @return GetMachineResponse
         */
        public async Task<GetMachineResponse> GetMachineAsync(string devId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMachineHeaders headers = new GetMachineHeaders();
            return await GetMachineWithOptionsAsync(devId, headers, runtime);
        }

        /**
         * @summary 根据设备id获取员工信息
         *
         * @param request GetMachineUserRequest
         * @param headers GetMachineUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMachineUserResponse
         */
        public GetMachineUserResponse GetMachineUserWithOptions(string devId, GetMachineUserRequest request, GetMachineUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMachineUser",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/machines/getUser/" + devId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMachineUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据设备id获取员工信息
         *
         * @param request GetMachineUserRequest
         * @param headers GetMachineUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMachineUserResponse
         */
        public async Task<GetMachineUserResponse> GetMachineUserWithOptionsAsync(string devId, GetMachineUserRequest request, GetMachineUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMachineUser",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/machines/getUser/" + devId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMachineUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据设备id获取员工信息
         *
         * @param request GetMachineUserRequest
         * @return GetMachineUserResponse
         */
        public GetMachineUserResponse GetMachineUser(string devId, GetMachineUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMachineUserHeaders headers = new GetMachineUserHeaders();
            return GetMachineUserWithOptions(devId, request, headers, runtime);
        }

        /**
         * @summary 根据设备id获取员工信息
         *
         * @param request GetMachineUserRequest
         * @return GetMachineUserResponse
         */
        public async Task<GetMachineUserResponse> GetMachineUserAsync(string devId, GetMachineUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMachineUserHeaders headers = new GetMachineUserHeaders();
            return await GetMachineUserWithOptionsAsync(devId, request, headers, runtime);
        }

        /**
         * @summary 批量获取加班规则设置
         *
         * @param request GetOvertimeSettingRequest
         * @param headers GetOvertimeSettingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOvertimeSettingResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOvertimeSetting",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/overtimeSettings/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOvertimeSettingResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量获取加班规则设置
         *
         * @param request GetOvertimeSettingRequest
         * @param headers GetOvertimeSettingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOvertimeSettingResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOvertimeSetting",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/overtimeSettings/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOvertimeSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量获取加班规则设置
         *
         * @param request GetOvertimeSettingRequest
         * @return GetOvertimeSettingResponse
         */
        public GetOvertimeSettingResponse GetOvertimeSetting(GetOvertimeSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOvertimeSettingHeaders headers = new GetOvertimeSettingHeaders();
            return GetOvertimeSettingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量获取加班规则设置
         *
         * @param request GetOvertimeSettingRequest
         * @return GetOvertimeSettingResponse
         */
        public async Task<GetOvertimeSettingResponse> GetOvertimeSettingAsync(GetOvertimeSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOvertimeSettingHeaders headers = new GetOvertimeSettingHeaders();
            return await GetOvertimeSettingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 班次详情
         *
         * @param request GetShiftRequest
         * @param headers GetShiftHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetShiftResponse
         */
        public GetShiftResponse GetShiftWithOptions(GetShiftRequest request, GetShiftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShiftId))
            {
                query["shiftId"] = request.ShiftId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShift",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/shifts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShiftResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 班次详情
         *
         * @param request GetShiftRequest
         * @param headers GetShiftHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetShiftResponse
         */
        public async Task<GetShiftResponse> GetShiftWithOptionsAsync(GetShiftRequest request, GetShiftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShiftId))
            {
                query["shiftId"] = request.ShiftId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShift",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/shifts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShiftResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 班次详情
         *
         * @param request GetShiftRequest
         * @return GetShiftResponse
         */
        public GetShiftResponse GetShift(GetShiftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetShiftHeaders headers = new GetShiftHeaders();
            return GetShiftWithOptions(request, headers, runtime);
        }

        /**
         * @summary 班次详情
         *
         * @param request GetShiftRequest
         * @return GetShiftResponse
         */
        public async Task<GetShiftResponse> GetShiftAsync(GetShiftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetShiftHeaders headers = new GetShiftHeaders();
            return await GetShiftWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取考勤组列表详情
         *
         * @param request GetSimpleGroupsRequest
         * @param headers GetSimpleGroupsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSimpleGroupsResponse
         */
        public GetSimpleGroupsResponse GetSimpleGroupsWithOptions(GetSimpleGroupsRequest request, GetSimpleGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSimpleGroups",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/groupDetails",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSimpleGroupsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取考勤组列表详情
         *
         * @param request GetSimpleGroupsRequest
         * @param headers GetSimpleGroupsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSimpleGroupsResponse
         */
        public async Task<GetSimpleGroupsResponse> GetSimpleGroupsWithOptionsAsync(GetSimpleGroupsRequest request, GetSimpleGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSimpleGroups",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/groupDetails",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSimpleGroupsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取考勤组列表详情
         *
         * @param request GetSimpleGroupsRequest
         * @return GetSimpleGroupsResponse
         */
        public GetSimpleGroupsResponse GetSimpleGroups(GetSimpleGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSimpleGroupsHeaders headers = new GetSimpleGroupsHeaders();
            return GetSimpleGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取考勤组列表详情
         *
         * @param request GetSimpleGroupsRequest
         * @return GetSimpleGroupsResponse
         */
        public async Task<GetSimpleGroupsResponse> GetSimpleGroupsAsync(GetSimpleGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSimpleGroupsHeaders headers = new GetSimpleGroupsHeaders();
            return await GetSimpleGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 加班规则列表
         *
         * @param request GetSimpleOvertimeSettingRequest
         * @param headers GetSimpleOvertimeSettingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSimpleOvertimeSettingResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSimpleOvertimeSetting",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/overtimeSettings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSimpleOvertimeSettingResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 加班规则列表
         *
         * @param request GetSimpleOvertimeSettingRequest
         * @param headers GetSimpleOvertimeSettingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSimpleOvertimeSettingResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSimpleOvertimeSetting",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/overtimeSettings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSimpleOvertimeSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 加班规则列表
         *
         * @param request GetSimpleOvertimeSettingRequest
         * @return GetSimpleOvertimeSettingResponse
         */
        public GetSimpleOvertimeSettingResponse GetSimpleOvertimeSetting(GetSimpleOvertimeSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSimpleOvertimeSettingHeaders headers = new GetSimpleOvertimeSettingHeaders();
            return GetSimpleOvertimeSettingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 加班规则列表
         *
         * @param request GetSimpleOvertimeSettingRequest
         * @return GetSimpleOvertimeSettingResponse
         */
        public async Task<GetSimpleOvertimeSettingResponse> GetSimpleOvertimeSettingAsync(GetSimpleOvertimeSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSimpleOvertimeSettingHeaders headers = new GetSimpleOvertimeSettingHeaders();
            return await GetSimpleOvertimeSettingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询员工某段时间的假期
         *
         * @param request GetUserHolidaysRequest
         * @param headers GetUserHolidaysHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserHolidaysResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserHolidays",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/holidays",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserHolidaysResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询员工某段时间的假期
         *
         * @param request GetUserHolidaysRequest
         * @param headers GetUserHolidaysHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserHolidaysResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserHolidays",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/holidays",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserHolidaysResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询员工某段时间的假期
         *
         * @param request GetUserHolidaysRequest
         * @return GetUserHolidaysResponse
         */
        public GetUserHolidaysResponse GetUserHolidays(GetUserHolidaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHolidaysHeaders headers = new GetUserHolidaysHeaders();
            return GetUserHolidaysWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询员工某段时间的假期
         *
         * @param request GetUserHolidaysRequest
         * @return GetUserHolidaysResponse
         */
        public async Task<GetUserHolidaysResponse> GetUserHolidaysAsync(GetUserHolidaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHolidaysHeaders headers = new GetUserHolidaysHeaders();
            return await GetUserHolidaysWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建考勤组
         *
         * @param request GroupAddRequest
         * @param headers GroupAddHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupAddResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenCameraCheck))
            {
                body["openCameraCheck"] = request.OpenCameraCheck;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GroupAdd",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupAddResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建考勤组
         *
         * @param request GroupAddRequest
         * @param headers GroupAddHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupAddResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenCameraCheck))
            {
                body["openCameraCheck"] = request.OpenCameraCheck;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GroupAdd",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupAddResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建考勤组
         *
         * @param request GroupAddRequest
         * @return GroupAddResponse
         */
        public GroupAddResponse GroupAdd(GroupAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupAddHeaders headers = new GroupAddHeaders();
            return GroupAddWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建考勤组
         *
         * @param request GroupAddRequest
         * @return GroupAddResponse
         */
        public async Task<GroupAddResponse> GroupAddAsync(GroupAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupAddHeaders headers = new GroupAddHeaders();
            return await GroupAddWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 修改考勤组
         *
         * @param request GroupUpdateRequest
         * @param headers GroupUpdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupUpdateResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenCameraCheck))
            {
                body["openCameraCheck"] = request.OpenCameraCheck;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GroupUpdate",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/groups",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupUpdateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 修改考勤组
         *
         * @param request GroupUpdateRequest
         * @param headers GroupUpdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupUpdateResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenCameraCheck))
            {
                body["openCameraCheck"] = request.OpenCameraCheck;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GroupUpdate",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/groups",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 修改考勤组
         *
         * @param request GroupUpdateRequest
         * @return GroupUpdateResponse
         */
        public GroupUpdateResponse GroupUpdate(GroupUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupUpdateHeaders headers = new GroupUpdateHeaders();
            return GroupUpdateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 修改考勤组
         *
         * @param request GroupUpdateRequest
         * @return GroupUpdateResponse
         */
        public async Task<GroupUpdateResponse> GroupUpdateAsync(GroupUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupUpdateHeaders headers = new GroupUpdateHeaders();
            return await GroupUpdateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 生态系统假期初始化查询余额接口
         *
         * @param request InitAndGetLeaveALlocationQuotasRequest
         * @param headers InitAndGetLeaveALlocationQuotasHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InitAndGetLeaveALlocationQuotasResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitAndGetLeaveALlocationQuotas",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/leaves/initializations/balances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitAndGetLeaveALlocationQuotasResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 生态系统假期初始化查询余额接口
         *
         * @param request InitAndGetLeaveALlocationQuotasRequest
         * @param headers InitAndGetLeaveALlocationQuotasHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InitAndGetLeaveALlocationQuotasResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitAndGetLeaveALlocationQuotas",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/leaves/initializations/balances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitAndGetLeaveALlocationQuotasResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 生态系统假期初始化查询余额接口
         *
         * @param request InitAndGetLeaveALlocationQuotasRequest
         * @return InitAndGetLeaveALlocationQuotasResponse
         */
        public InitAndGetLeaveALlocationQuotasResponse InitAndGetLeaveALlocationQuotas(InitAndGetLeaveALlocationQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InitAndGetLeaveALlocationQuotasHeaders headers = new InitAndGetLeaveALlocationQuotasHeaders();
            return InitAndGetLeaveALlocationQuotasWithOptions(request, headers, runtime);
        }

        /**
         * @summary 生态系统假期初始化查询余额接口
         *
         * @param request InitAndGetLeaveALlocationQuotasRequest
         * @return InitAndGetLeaveALlocationQuotasResponse
         */
        public async Task<InitAndGetLeaveALlocationQuotasResponse> InitAndGetLeaveALlocationQuotasAsync(InitAndGetLeaveALlocationQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InitAndGetLeaveALlocationQuotasHeaders headers = new InitAndGetLeaveALlocationQuotasHeaders();
            return await InitAndGetLeaveALlocationQuotasWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取用户某段时间内同步到考勤的审批单信息
         *
         * @param request ListApproveByUsersRequest
         * @param headers ListApproveByUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApproveByUsersResponse
         */
        public ListApproveByUsersResponse ListApproveByUsersWithOptions(ListApproveByUsersRequest request, ListApproveByUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTypes))
            {
                body["bizTypes"] = request.BizTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDateTime))
            {
                body["fromDateTime"] = request.FromDateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDateTime))
            {
                body["toDateTime"] = request.ToDateTime;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApproveByUsers",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/approvals/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApproveByUsersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取用户某段时间内同步到考勤的审批单信息
         *
         * @param request ListApproveByUsersRequest
         * @param headers ListApproveByUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApproveByUsersResponse
         */
        public async Task<ListApproveByUsersResponse> ListApproveByUsersWithOptionsAsync(ListApproveByUsersRequest request, ListApproveByUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTypes))
            {
                body["bizTypes"] = request.BizTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDateTime))
            {
                body["fromDateTime"] = request.FromDateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDateTime))
            {
                body["toDateTime"] = request.ToDateTime;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApproveByUsers",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/approvals/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApproveByUsersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户某段时间内同步到考勤的审批单信息
         *
         * @param request ListApproveByUsersRequest
         * @return ListApproveByUsersResponse
         */
        public ListApproveByUsersResponse ListApproveByUsers(ListApproveByUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListApproveByUsersHeaders headers = new ListApproveByUsersHeaders();
            return ListApproveByUsersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取用户某段时间内同步到考勤的审批单信息
         *
         * @param request ListApproveByUsersRequest
         * @return ListApproveByUsersResponse
         */
        public async Task<ListApproveByUsersResponse> ListApproveByUsersAsync(ListApproveByUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListApproveByUsersHeaders headers = new ListApproveByUsersHeaders();
            return await ListApproveByUsersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 修改水印模板
         *
         * @param request ModifyWaterMarkTemplateRequest
         * @param headers ModifyWaterMarkTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyWaterMarkTemplateResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyWaterMarkTemplate",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/watermarks/templates",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyWaterMarkTemplateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 修改水印模板
         *
         * @param request ModifyWaterMarkTemplateRequest
         * @param headers ModifyWaterMarkTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyWaterMarkTemplateResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyWaterMarkTemplate",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/watermarks/templates",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyWaterMarkTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 修改水印模板
         *
         * @param request ModifyWaterMarkTemplateRequest
         * @return ModifyWaterMarkTemplateResponse
         */
        public ModifyWaterMarkTemplateResponse ModifyWaterMarkTemplate(ModifyWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyWaterMarkTemplateHeaders headers = new ModifyWaterMarkTemplateHeaders();
            return ModifyWaterMarkTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 修改水印模板
         *
         * @param request ModifyWaterMarkTemplateRequest
         * @return ModifyWaterMarkTemplateResponse
         */
        public async Task<ModifyWaterMarkTemplateResponse> ModifyWaterMarkTemplateAsync(ModifyWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyWaterMarkTemplateHeaders headers = new ModifyWaterMarkTemplateHeaders();
            return await ModifyWaterMarkTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建考勤打卡审批单
         *
         * @param request ProcessApproveCreateRequest
         * @param headers ProcessApproveCreateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ProcessApproveCreateResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProcessApproveCreate",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/workflows/checkInForms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProcessApproveCreateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建考勤打卡审批单
         *
         * @param request ProcessApproveCreateRequest
         * @param headers ProcessApproveCreateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ProcessApproveCreateResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProcessApproveCreate",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/workflows/checkInForms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProcessApproveCreateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建考勤打卡审批单
         *
         * @param request ProcessApproveCreateRequest
         * @return ProcessApproveCreateResponse
         */
        public ProcessApproveCreateResponse ProcessApproveCreate(ProcessApproveCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProcessApproveCreateHeaders headers = new ProcessApproveCreateHeaders();
            return ProcessApproveCreateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建考勤打卡审批单
         *
         * @param request ProcessApproveCreateRequest
         * @return ProcessApproveCreateResponse
         */
        public async Task<ProcessApproveCreateResponse> ProcessApproveCreateAsync(ProcessApproveCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProcessApproveCreateHeaders headers = new ProcessApproveCreateHeaders();
            return await ProcessApproveCreateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通知审批通过
         *
         * @param request ProcessApproveFinishRequest
         * @param headers ProcessApproveFinishHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ProcessApproveFinishResponse
         */
        public ProcessApproveFinishResponse ProcessApproveFinishWithOptions(ProcessApproveFinishRequest request, ProcessApproveFinishHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveId))
            {
                body["approveId"] = request.ApproveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JumpUrl))
            {
                body["jumpUrl"] = request.JumpUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverTimeToMore))
            {
                body["overTimeToMore"] = request.OverTimeToMore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OvertimeDuration))
            {
                body["overtimeDuration"] = request.OvertimeDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubType))
            {
                body["subType"] = request.SubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                body["tagName"] = request.TagName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopCalculateApproveDurationParam))
            {
                body["topCalculateApproveDurationParam"] = request.TopCalculateApproveDurationParam;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProcessApproveFinish",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/approvals/finish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProcessApproveFinishResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通知审批通过
         *
         * @param request ProcessApproveFinishRequest
         * @param headers ProcessApproveFinishHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ProcessApproveFinishResponse
         */
        public async Task<ProcessApproveFinishResponse> ProcessApproveFinishWithOptionsAsync(ProcessApproveFinishRequest request, ProcessApproveFinishHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveId))
            {
                body["approveId"] = request.ApproveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JumpUrl))
            {
                body["jumpUrl"] = request.JumpUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverTimeToMore))
            {
                body["overTimeToMore"] = request.OverTimeToMore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OvertimeDuration))
            {
                body["overtimeDuration"] = request.OvertimeDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubType))
            {
                body["subType"] = request.SubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                body["tagName"] = request.TagName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopCalculateApproveDurationParam))
            {
                body["topCalculateApproveDurationParam"] = request.TopCalculateApproveDurationParam;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProcessApproveFinish",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/approvals/finish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProcessApproveFinishResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通知审批通过
         *
         * @param request ProcessApproveFinishRequest
         * @return ProcessApproveFinishResponse
         */
        public ProcessApproveFinishResponse ProcessApproveFinish(ProcessApproveFinishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProcessApproveFinishHeaders headers = new ProcessApproveFinishHeaders();
            return ProcessApproveFinishWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通知审批通过
         *
         * @param request ProcessApproveFinishRequest
         * @return ProcessApproveFinishResponse
         */
        public async Task<ProcessApproveFinishResponse> ProcessApproveFinishAsync(ProcessApproveFinishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProcessApproveFinishHeaders headers = new ProcessApproveFinishHeaders();
            return await ProcessApproveFinishWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 扣减员工假期余额
         *
         * @param request ReduceQuotaWithLeaveRecordRequest
         * @param headers ReduceQuotaWithLeaveRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReduceQuotaWithLeaveRecordResponse
         */
        public ReduceQuotaWithLeaveRecordResponse ReduceQuotaWithLeaveRecordWithOptions(string unionId, ReduceQuotaWithLeaveRecordRequest request, ReduceQuotaWithLeaveRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCode))
            {
                body["leaveCode"] = request.LeaveCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                body["outerId"] = request.OuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNum))
            {
                body["quotaNum"] = request.QuotaNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReduceQuotaWithLeaveRecord",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/users/" + unionId + "/vacations/records/modify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReduceQuotaWithLeaveRecordResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 扣减员工假期余额
         *
         * @param request ReduceQuotaWithLeaveRecordRequest
         * @param headers ReduceQuotaWithLeaveRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReduceQuotaWithLeaveRecordResponse
         */
        public async Task<ReduceQuotaWithLeaveRecordResponse> ReduceQuotaWithLeaveRecordWithOptionsAsync(string unionId, ReduceQuotaWithLeaveRecordRequest request, ReduceQuotaWithLeaveRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCode))
            {
                body["leaveCode"] = request.LeaveCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                body["outerId"] = request.OuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNum))
            {
                body["quotaNum"] = request.QuotaNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReduceQuotaWithLeaveRecord",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/users/" + unionId + "/vacations/records/modify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReduceQuotaWithLeaveRecordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 扣减员工假期余额
         *
         * @param request ReduceQuotaWithLeaveRecordRequest
         * @return ReduceQuotaWithLeaveRecordResponse
         */
        public ReduceQuotaWithLeaveRecordResponse ReduceQuotaWithLeaveRecord(string unionId, ReduceQuotaWithLeaveRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReduceQuotaWithLeaveRecordHeaders headers = new ReduceQuotaWithLeaveRecordHeaders();
            return ReduceQuotaWithLeaveRecordWithOptions(unionId, request, headers, runtime);
        }

        /**
         * @summary 扣减员工假期余额
         *
         * @param request ReduceQuotaWithLeaveRecordRequest
         * @return ReduceQuotaWithLeaveRecordResponse
         */
        public async Task<ReduceQuotaWithLeaveRecordResponse> ReduceQuotaWithLeaveRecordAsync(string unionId, ReduceQuotaWithLeaveRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReduceQuotaWithLeaveRecordHeaders headers = new ReduceQuotaWithLeaveRecordHeaders();
            return await ReduceQuotaWithLeaveRecordWithOptionsAsync(unionId, request, headers, runtime);
        }

        /**
         * @summary 修改假期规则来源
         *
         * @param request RetainLeaveTypesRequest
         * @param headers RetainLeaveTypesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetainLeaveTypesResponse
         */
        public RetainLeaveTypesResponse RetainLeaveTypesWithOptions(RetainLeaveTypesRequest request, RetainLeaveTypesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCodes))
            {
                body["leaveCodes"] = request.LeaveCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetainLeaveTypes",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/vacations/types/change",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetainLeaveTypesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 修改假期规则来源
         *
         * @param request RetainLeaveTypesRequest
         * @param headers RetainLeaveTypesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetainLeaveTypesResponse
         */
        public async Task<RetainLeaveTypesResponse> RetainLeaveTypesWithOptionsAsync(RetainLeaveTypesRequest request, RetainLeaveTypesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveCodes))
            {
                body["leaveCodes"] = request.LeaveCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetainLeaveTypes",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/vacations/types/change",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetainLeaveTypesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 修改假期规则来源
         *
         * @param request RetainLeaveTypesRequest
         * @return RetainLeaveTypesResponse
         */
        public RetainLeaveTypesResponse RetainLeaveTypes(RetainLeaveTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetainLeaveTypesHeaders headers = new RetainLeaveTypesHeaders();
            return RetainLeaveTypesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 修改假期规则来源
         *
         * @param request RetainLeaveTypesRequest
         * @return RetainLeaveTypesResponse
         */
        public async Task<RetainLeaveTypesResponse> RetainLeaveTypesAsync(RetainLeaveTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetainLeaveTypesHeaders headers = new RetainLeaveTypesHeaders();
            return await RetainLeaveTypesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 提供给高级假期的试用订单回退
         *
         * @param request ReverseTrialAdvancedLeaveRequest
         * @param headers ReverseTrialAdvancedLeaveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReverseTrialAdvancedLeaveResponse
         */
        public ReverseTrialAdvancedLeaveResponse ReverseTrialAdvancedLeaveWithOptions(ReverseTrialAdvancedLeaveRequest request, ReverseTrialAdvancedLeaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServCode))
            {
                query["servCode"] = request.ServCode;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReverseTrialAdvancedLeave",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/leaves/reverse",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReverseTrialAdvancedLeaveResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 提供给高级假期的试用订单回退
         *
         * @param request ReverseTrialAdvancedLeaveRequest
         * @param headers ReverseTrialAdvancedLeaveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReverseTrialAdvancedLeaveResponse
         */
        public async Task<ReverseTrialAdvancedLeaveResponse> ReverseTrialAdvancedLeaveWithOptionsAsync(ReverseTrialAdvancedLeaveRequest request, ReverseTrialAdvancedLeaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServCode))
            {
                query["servCode"] = request.ServCode;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReverseTrialAdvancedLeave",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/leaves/reverse",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReverseTrialAdvancedLeaveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 提供给高级假期的试用订单回退
         *
         * @param request ReverseTrialAdvancedLeaveRequest
         * @return ReverseTrialAdvancedLeaveResponse
         */
        public ReverseTrialAdvancedLeaveResponse ReverseTrialAdvancedLeave(ReverseTrialAdvancedLeaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReverseTrialAdvancedLeaveHeaders headers = new ReverseTrialAdvancedLeaveHeaders();
            return ReverseTrialAdvancedLeaveWithOptions(request, headers, runtime);
        }

        /**
         * @summary 提供给高级假期的试用订单回退
         *
         * @param request ReverseTrialAdvancedLeaveRequest
         * @return ReverseTrialAdvancedLeaveResponse
         */
        public async Task<ReverseTrialAdvancedLeaveResponse> ReverseTrialAdvancedLeaveAsync(ReverseTrialAdvancedLeaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReverseTrialAdvancedLeaveHeaders headers = new ReverseTrialAdvancedLeaveHeaders();
            return await ReverseTrialAdvancedLeaveWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 新增水印签到模板
         *
         * @param request SaveCustomWaterMarkTemplateRequest
         * @param headers SaveCustomWaterMarkTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveCustomWaterMarkTemplateResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveCustomWaterMarkTemplate",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/watermarks/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveCustomWaterMarkTemplateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 新增水印签到模板
         *
         * @param request SaveCustomWaterMarkTemplateRequest
         * @param headers SaveCustomWaterMarkTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveCustomWaterMarkTemplateResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveCustomWaterMarkTemplate",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/watermarks/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveCustomWaterMarkTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 新增水印签到模板
         *
         * @param request SaveCustomWaterMarkTemplateRequest
         * @return SaveCustomWaterMarkTemplateResponse
         */
        public SaveCustomWaterMarkTemplateResponse SaveCustomWaterMarkTemplate(SaveCustomWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveCustomWaterMarkTemplateHeaders headers = new SaveCustomWaterMarkTemplateHeaders();
            return SaveCustomWaterMarkTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新增水印签到模板
         *
         * @param request SaveCustomWaterMarkTemplateRequest
         * @return SaveCustomWaterMarkTemplateResponse
         */
        public async Task<SaveCustomWaterMarkTemplateResponse> SaveCustomWaterMarkTemplateAsync(SaveCustomWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveCustomWaterMarkTemplateHeaders headers = new SaveCustomWaterMarkTemplateHeaders();
            return await SaveCustomWaterMarkTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建班次
         *
         * @param request ShiftAddRequest
         * @param headers ShiftAddHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ShiftAddResponse
         */
        public ShiftAddResponse ShiftAddWithOptions(ShiftAddRequest request, ShiftAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                body["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sections))
            {
                body["sections"] = request.Sections;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Setting))
            {
                body["setting"] = request.Setting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShiftId))
            {
                body["shiftId"] = request.ShiftId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ShiftAdd",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/shifts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ShiftAddResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建班次
         *
         * @param request ShiftAddRequest
         * @param headers ShiftAddHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ShiftAddResponse
         */
        public async Task<ShiftAddResponse> ShiftAddWithOptionsAsync(ShiftAddRequest request, ShiftAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                body["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sections))
            {
                body["sections"] = request.Sections;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Setting))
            {
                body["setting"] = request.Setting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShiftId))
            {
                body["shiftId"] = request.ShiftId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ShiftAdd",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/shifts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ShiftAddResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建班次
         *
         * @param request ShiftAddRequest
         * @return ShiftAddResponse
         */
        public ShiftAddResponse ShiftAdd(ShiftAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ShiftAddHeaders headers = new ShiftAddHeaders();
            return ShiftAddWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建班次
         *
         * @param request ShiftAddRequest
         * @return ShiftAddResponse
         */
        public async Task<ShiftAddResponse> ShiftAddAsync(ShiftAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ShiftAddHeaders headers = new ShiftAddHeaders();
            return await ShiftAddWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 用于考勤排班附加信息，例如打卡位置，打卡wifi等
         *
         * @param request SyncScheduleInfoRequest
         * @param headers SyncScheduleInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncScheduleInfoResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncScheduleInfo",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/schedules/additionalInfo",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<SyncScheduleInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 用于考勤排班附加信息，例如打卡位置，打卡wifi等
         *
         * @param request SyncScheduleInfoRequest
         * @param headers SyncScheduleInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncScheduleInfoResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncScheduleInfo",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/schedules/additionalInfo",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<SyncScheduleInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 用于考勤排班附加信息，例如打卡位置，打卡wifi等
         *
         * @param request SyncScheduleInfoRequest
         * @return SyncScheduleInfoResponse
         */
        public SyncScheduleInfoResponse SyncScheduleInfo(SyncScheduleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncScheduleInfoHeaders headers = new SyncScheduleInfoHeaders();
            return SyncScheduleInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 用于考勤排班附加信息，例如打卡位置，打卡wifi等
         *
         * @param request SyncScheduleInfoRequest
         * @return SyncScheduleInfoResponse
         */
        public async Task<SyncScheduleInfoResponse> SyncScheduleInfoAsync(SyncScheduleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncScheduleInfoHeaders headers = new SyncScheduleInfoHeaders();
            return await SyncScheduleInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新假期规则
         *
         * @param request UpdateLeaveTypeRequest
         * @param headers UpdateLeaveTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLeaveTypeResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLeaveType",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/leaves/types",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLeaveTypeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新假期规则
         *
         * @param request UpdateLeaveTypeRequest
         * @param headers UpdateLeaveTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLeaveTypeResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLeaveType",
                Version = "attendance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/attendance/leaves/types",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLeaveTypeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新假期规则
         *
         * @param request UpdateLeaveTypeRequest
         * @return UpdateLeaveTypeResponse
         */
        public UpdateLeaveTypeResponse UpdateLeaveType(UpdateLeaveTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateLeaveTypeHeaders headers = new UpdateLeaveTypeHeaders();
            return UpdateLeaveTypeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新假期规则
         *
         * @param request UpdateLeaveTypeRequest
         * @return UpdateLeaveTypeResponse
         */
        public async Task<UpdateLeaveTypeResponse> UpdateLeaveTypeAsync(UpdateLeaveTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateLeaveTypeHeaders headers = new UpdateLeaveTypeHeaders();
            return await UpdateLeaveTypeWithOptionsAsync(request, headers, runtime);
        }

    }
}
