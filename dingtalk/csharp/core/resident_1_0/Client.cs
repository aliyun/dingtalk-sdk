// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkresident_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0
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


        public AddPointResponse AddPoint(AddPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddPointHeaders headers = new AddPointHeaders();
            return AddPointWithOptions(request, headers, runtime);
        }

        public async Task<AddPointResponse> AddPointAsync(AddPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddPointHeaders headers = new AddPointHeaders();
            return await AddPointWithOptionsAsync(request, headers, runtime);
        }

        public AddPointResponse AddPointWithOptions(AddPointRequest request, AddPointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionTime))
            {
                query["actionTime"] = request.ActionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCircle))
            {
                query["isCircle"] = request.IsCircle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCode))
            {
                query["ruleCode"] = request.RuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Score))
            {
                query["score"] = request.Score;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
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
            return TeaModel.ToObject<AddPointResponse>(DoROARequest("AddPoint", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/points", "none", req, runtime));
        }

        public async Task<AddPointResponse> AddPointWithOptionsAsync(AddPointRequest request, AddPointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionTime))
            {
                query["actionTime"] = request.ActionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCircle))
            {
                query["isCircle"] = request.IsCircle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCode))
            {
                query["ruleCode"] = request.RuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["ruleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Score))
            {
                query["score"] = request.Score;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
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
            return TeaModel.ToObject<AddPointResponse>(await DoROARequestAsync("AddPoint", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/points", "none", req, runtime));
        }

        public AddResidentDepartmentResponse AddResidentDepartment(AddResidentDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentDepartmentHeaders headers = new AddResidentDepartmentHeaders();
            return AddResidentDepartmentWithOptions(request, headers, runtime);
        }

        public async Task<AddResidentDepartmentResponse> AddResidentDepartmentAsync(AddResidentDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentDepartmentHeaders headers = new AddResidentDepartmentHeaders();
            return await AddResidentDepartmentWithOptionsAsync(request, headers, runtime);
        }

        public AddResidentDepartmentResponse AddResidentDepartmentWithOptions(AddResidentDepartmentRequest request, AddResidentDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["departmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsResidenceGroup))
            {
                query["isResidenceGroup"] = request.IsResidenceGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDepartmentId))
            {
                query["parentDepartmentId"] = request.ParentDepartmentId;
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
            return TeaModel.ToObject<AddResidentDepartmentResponse>(DoROARequest("AddResidentDepartment", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/departments", "json", req, runtime));
        }

        public async Task<AddResidentDepartmentResponse> AddResidentDepartmentWithOptionsAsync(AddResidentDepartmentRequest request, AddResidentDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["departmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsResidenceGroup))
            {
                query["isResidenceGroup"] = request.IsResidenceGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDepartmentId))
            {
                query["parentDepartmentId"] = request.ParentDepartmentId;
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
            return TeaModel.ToObject<AddResidentDepartmentResponse>(await DoROARequestAsync("AddResidentDepartment", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/departments", "json", req, runtime));
        }

        public AddResidentMemberResponse AddResidentMember(AddResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentMemberHeaders headers = new AddResidentMemberHeaders();
            return AddResidentMemberWithOptions(request, headers, runtime);
        }

        public async Task<AddResidentMemberResponse> AddResidentMemberAsync(AddResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentMemberHeaders headers = new AddResidentMemberHeaders();
            return await AddResidentMemberWithOptionsAsync(request, headers, runtime);
        }

        public AddResidentMemberResponse AddResidentMemberWithOptions(AddResidentMemberRequest request, AddResidentMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentAddInfo.ToMap()))
            {
                body["residentAddInfo"] = request.ResidentAddInfo;
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
            return TeaModel.ToObject<AddResidentMemberResponse>(DoROARequest("AddResidentMember", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/members", "json", req, runtime));
        }

        public async Task<AddResidentMemberResponse> AddResidentMemberWithOptionsAsync(AddResidentMemberRequest request, AddResidentMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentAddInfo.ToMap()))
            {
                body["residentAddInfo"] = request.ResidentAddInfo;
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
            return TeaModel.ToObject<AddResidentMemberResponse>(await DoROARequestAsync("AddResidentMember", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/members", "json", req, runtime));
        }

        public AddResidentUsersResponse AddResidentUsers(AddResidentUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentUsersHeaders headers = new AddResidentUsersHeaders();
            return AddResidentUsersWithOptions(request, headers, runtime);
        }

        public async Task<AddResidentUsersResponse> AddResidentUsersAsync(AddResidentUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddResidentUsersHeaders headers = new AddResidentUsersHeaders();
            return await AddResidentUsersWithOptionsAsync(request, headers, runtime);
        }

        public AddResidentUsersResponse AddResidentUsersWithOptions(AddResidentUsersRequest request, AddResidentUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtField))
            {
                query["extField"] = request.ExtField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsLeaseholder))
            {
                query["isLeaseholder"] = request.IsLeaseholder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelateType))
            {
                query["relateType"] = request.RelateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["userName"] = request.UserName;
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
            return TeaModel.ToObject<AddResidentUsersResponse>(DoROARequest("AddResidentUsers", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/users", "json", req, runtime));
        }

        public async Task<AddResidentUsersResponse> AddResidentUsersWithOptionsAsync(AddResidentUsersRequest request, AddResidentUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtField))
            {
                query["extField"] = request.ExtField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsLeaseholder))
            {
                query["isLeaseholder"] = request.IsLeaseholder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelateType))
            {
                query["relateType"] = request.RelateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["userName"] = request.UserName;
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
            return TeaModel.ToObject<AddResidentUsersResponse>(await DoROARequestAsync("AddResidentUsers", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/users", "json", req, runtime));
        }

        public CreateResidentBlackBoardResponse CreateResidentBlackBoard(CreateResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateResidentBlackBoardHeaders headers = new CreateResidentBlackBoardHeaders();
            return CreateResidentBlackBoardWithOptions(request, headers, runtime);
        }

        public async Task<CreateResidentBlackBoardResponse> CreateResidentBlackBoardAsync(CreateResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateResidentBlackBoardHeaders headers = new CreateResidentBlackBoardHeaders();
            return await CreateResidentBlackBoardWithOptionsAsync(request, headers, runtime);
        }

        public CreateResidentBlackBoardResponse CreateResidentBlackBoardWithOptions(CreateResidentBlackBoardRequest request, CreateResidentBlackBoardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                body["context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendTime))
            {
                body["sendTime"] = request.SendTime;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateResidentBlackBoardResponse>(DoROARequest("CreateResidentBlackBoard", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/blackboards", "json", req, runtime));
        }

        public async Task<CreateResidentBlackBoardResponse> CreateResidentBlackBoardWithOptionsAsync(CreateResidentBlackBoardRequest request, CreateResidentBlackBoardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                body["context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendTime))
            {
                body["sendTime"] = request.SendTime;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateResidentBlackBoardResponse>(await DoROARequestAsync("CreateResidentBlackBoard", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/blackboards", "json", req, runtime));
        }

        public CreateSpaceResponse CreateSpace(CreateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSpaceHeaders headers = new CreateSpaceHeaders();
            return CreateSpaceWithOptions(request, headers, runtime);
        }

        public async Task<CreateSpaceResponse> CreateSpaceAsync(CreateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSpaceHeaders headers = new CreateSpaceHeaders();
            return await CreateSpaceWithOptionsAsync(request, headers, runtime);
        }

        public CreateSpaceResponse CreateSpaceWithOptions(CreateSpaceRequest request, CreateSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingArea))
            {
                body["billingArea"] = request.BillingArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildingArea))
            {
                body["buildingArea"] = request.BuildingArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Floor))
            {
                body["floor"] = request.Floor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HouseState))
            {
                body["houseState"] = request.HouseState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDeptId))
            {
                body["parentDeptId"] = request.ParentDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
            return TeaModel.ToObject<CreateSpaceResponse>(DoROARequest("CreateSpace", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/spaces", "json", req, runtime));
        }

        public async Task<CreateSpaceResponse> CreateSpaceWithOptionsAsync(CreateSpaceRequest request, CreateSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingArea))
            {
                body["billingArea"] = request.BillingArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildingArea))
            {
                body["buildingArea"] = request.BuildingArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Floor))
            {
                body["floor"] = request.Floor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HouseState))
            {
                body["houseState"] = request.HouseState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDeptId))
            {
                body["parentDeptId"] = request.ParentDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
            return TeaModel.ToObject<CreateSpaceResponse>(await DoROARequestAsync("CreateSpace", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/spaces", "json", req, runtime));
        }

        public DeleteResidentBlackBoardResponse DeleteResidentBlackBoard(DeleteResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteResidentBlackBoardHeaders headers = new DeleteResidentBlackBoardHeaders();
            return DeleteResidentBlackBoardWithOptions(request, headers, runtime);
        }

        public async Task<DeleteResidentBlackBoardResponse> DeleteResidentBlackBoardAsync(DeleteResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteResidentBlackBoardHeaders headers = new DeleteResidentBlackBoardHeaders();
            return await DeleteResidentBlackBoardWithOptionsAsync(request, headers, runtime);
        }

        public DeleteResidentBlackBoardResponse DeleteResidentBlackBoardWithOptions(DeleteResidentBlackBoardRequest request, DeleteResidentBlackBoardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackboardId))
            {
                query["blackboardId"] = request.BlackboardId;
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
            return TeaModel.ToObject<DeleteResidentBlackBoardResponse>(DoROARequest("DeleteResidentBlackBoard", "resident_1.0", "HTTP", "DELETE", "AK", "/v1.0/resident/blackboards", "json", req, runtime));
        }

        public async Task<DeleteResidentBlackBoardResponse> DeleteResidentBlackBoardWithOptionsAsync(DeleteResidentBlackBoardRequest request, DeleteResidentBlackBoardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackboardId))
            {
                query["blackboardId"] = request.BlackboardId;
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
            return TeaModel.ToObject<DeleteResidentBlackBoardResponse>(await DoROARequestAsync("DeleteResidentBlackBoard", "resident_1.0", "HTTP", "DELETE", "AK", "/v1.0/resident/blackboards", "json", req, runtime));
        }

        public DeleteResidentDepartmentResponse DeleteResidentDepartment(DeleteResidentDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteResidentDepartmentHeaders headers = new DeleteResidentDepartmentHeaders();
            return DeleteResidentDepartmentWithOptions(request, headers, runtime);
        }

        public async Task<DeleteResidentDepartmentResponse> DeleteResidentDepartmentAsync(DeleteResidentDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteResidentDepartmentHeaders headers = new DeleteResidentDepartmentHeaders();
            return await DeleteResidentDepartmentWithOptionsAsync(request, headers, runtime);
        }

        public DeleteResidentDepartmentResponse DeleteResidentDepartmentWithOptions(DeleteResidentDepartmentRequest request, DeleteResidentDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
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
            return TeaModel.ToObject<DeleteResidentDepartmentResponse>(DoROARequest("DeleteResidentDepartment", "resident_1.0", "HTTP", "DELETE", "AK", "/v1.0/resident/departments", "json", req, runtime));
        }

        public async Task<DeleteResidentDepartmentResponse> DeleteResidentDepartmentWithOptionsAsync(DeleteResidentDepartmentRequest request, DeleteResidentDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
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
            return TeaModel.ToObject<DeleteResidentDepartmentResponse>(await DoROARequestAsync("DeleteResidentDepartment", "resident_1.0", "HTTP", "DELETE", "AK", "/v1.0/resident/departments", "json", req, runtime));
        }

        public DeleteSpaceResponse DeleteSpace(DeleteSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSpaceHeaders headers = new DeleteSpaceHeaders();
            return DeleteSpaceWithOptions(request, headers, runtime);
        }

        public async Task<DeleteSpaceResponse> DeleteSpaceAsync(DeleteSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSpaceHeaders headers = new DeleteSpaceHeaders();
            return await DeleteSpaceWithOptionsAsync(request, headers, runtime);
        }

        public DeleteSpaceResponse DeleteSpaceWithOptions(DeleteSpaceRequest request, DeleteSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
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
            return TeaModel.ToObject<DeleteSpaceResponse>(DoROARequest("DeleteSpace", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/spaces/remove", "json", req, runtime));
        }

        public async Task<DeleteSpaceResponse> DeleteSpaceWithOptionsAsync(DeleteSpaceRequest request, DeleteSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
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
            return TeaModel.ToObject<DeleteSpaceResponse>(await DoROARequestAsync("DeleteSpace", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/spaces/remove", "json", req, runtime));
        }

        public GetConversationIdResponse GetConversationId(GetConversationIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationIdHeaders headers = new GetConversationIdHeaders();
            return GetConversationIdWithOptions(request, headers, runtime);
        }

        public async Task<GetConversationIdResponse> GetConversationIdAsync(GetConversationIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationIdHeaders headers = new GetConversationIdHeaders();
            return await GetConversationIdWithOptionsAsync(request, headers, runtime);
        }

        public GetConversationIdResponse GetConversationIdWithOptions(GetConversationIdRequest request, GetConversationIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                query["chatId"] = request.ChatId;
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
            return TeaModel.ToObject<GetConversationIdResponse>(DoROARequest("GetConversationId", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/conversations", "json", req, runtime));
        }

        public async Task<GetConversationIdResponse> GetConversationIdWithOptionsAsync(GetConversationIdRequest request, GetConversationIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                query["chatId"] = request.ChatId;
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
            return TeaModel.ToObject<GetConversationIdResponse>(await DoROARequestAsync("GetConversationId", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/conversations", "json", req, runtime));
        }

        public GetIndustryTypeResponse GetIndustryType()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIndustryTypeHeaders headers = new GetIndustryTypeHeaders();
            return GetIndustryTypeWithOptions(headers, runtime);
        }

        public async Task<GetIndustryTypeResponse> GetIndustryTypeAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIndustryTypeHeaders headers = new GetIndustryTypeHeaders();
            return await GetIndustryTypeWithOptionsAsync(headers, runtime);
        }

        public GetIndustryTypeResponse GetIndustryTypeWithOptions(GetIndustryTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetIndustryTypeResponse>(DoROARequest("GetIndustryType", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/organizations/industryTypes", "json", req, runtime));
        }

        public async Task<GetIndustryTypeResponse> GetIndustryTypeWithOptionsAsync(GetIndustryTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetIndustryTypeResponse>(await DoROARequestAsync("GetIndustryType", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/organizations/industryTypes", "json", req, runtime));
        }

        public GetPropertyInfoResponse GetPropertyInfo(GetPropertyInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPropertyInfoHeaders headers = new GetPropertyInfoHeaders();
            return GetPropertyInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetPropertyInfoResponse> GetPropertyInfoAsync(GetPropertyInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPropertyInfoHeaders headers = new GetPropertyInfoHeaders();
            return await GetPropertyInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetPropertyInfoResponse GetPropertyInfoWithOptions(GetPropertyInfoRequest request, GetPropertyInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyCorpId))
            {
                query["propertyCorpId"] = request.PropertyCorpId;
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
            return TeaModel.ToObject<GetPropertyInfoResponse>(DoROARequest("GetPropertyInfo", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/propertyInfos", "json", req, runtime));
        }

        public async Task<GetPropertyInfoResponse> GetPropertyInfoWithOptionsAsync(GetPropertyInfoRequest request, GetPropertyInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyCorpId))
            {
                query["propertyCorpId"] = request.PropertyCorpId;
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
            return TeaModel.ToObject<GetPropertyInfoResponse>(await DoROARequestAsync("GetPropertyInfo", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/propertyInfos", "json", req, runtime));
        }

        public GetResidentInfoResponse GetResidentInfo(GetResidentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResidentInfoHeaders headers = new GetResidentInfoHeaders();
            return GetResidentInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetResidentInfoResponse> GetResidentInfoAsync(GetResidentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResidentInfoHeaders headers = new GetResidentInfoHeaders();
            return await GetResidentInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetResidentInfoResponse GetResidentInfoWithOptions(GetResidentInfoRequest request, GetResidentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCorpId))
            {
                query["residentCorpId"] = request.ResidentCorpId;
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
            return TeaModel.ToObject<GetResidentInfoResponse>(DoROARequest("GetResidentInfo", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/residentInfos", "json", req, runtime));
        }

        public async Task<GetResidentInfoResponse> GetResidentInfoWithOptionsAsync(GetResidentInfoRequest request, GetResidentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCorpId))
            {
                query["residentCorpId"] = request.ResidentCorpId;
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
            return TeaModel.ToObject<GetResidentInfoResponse>(await DoROARequestAsync("GetResidentInfo", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/residentInfos", "json", req, runtime));
        }

        public GetResidentMembersInfoResponse GetResidentMembersInfo(GetResidentMembersInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResidentMembersInfoHeaders headers = new GetResidentMembersInfoHeaders();
            return GetResidentMembersInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetResidentMembersInfoResponse> GetResidentMembersInfoAsync(GetResidentMembersInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResidentMembersInfoHeaders headers = new GetResidentMembersInfoHeaders();
            return await GetResidentMembersInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetResidentMembersInfoResponse GetResidentMembersInfoWithOptions(GetResidentMembersInfoRequest request, GetResidentMembersInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCropId))
            {
                body["residentCropId"] = request.ResidentCropId;
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
            return TeaModel.ToObject<GetResidentMembersInfoResponse>(DoROARequest("GetResidentMembersInfo", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/residences/query", "json", req, runtime));
        }

        public async Task<GetResidentMembersInfoResponse> GetResidentMembersInfoWithOptionsAsync(GetResidentMembersInfoRequest request, GetResidentMembersInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCropId))
            {
                body["residentCropId"] = request.ResidentCropId;
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
            return TeaModel.ToObject<GetResidentMembersInfoResponse>(await DoROARequestAsync("GetResidentMembersInfo", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/residences/query", "json", req, runtime));
        }

        public GetSpaceIdByTypeResponse GetSpaceIdByType(GetSpaceIdByTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceIdByTypeHeaders headers = new GetSpaceIdByTypeHeaders();
            return GetSpaceIdByTypeWithOptions(request, headers, runtime);
        }

        public async Task<GetSpaceIdByTypeResponse> GetSpaceIdByTypeAsync(GetSpaceIdByTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceIdByTypeHeaders headers = new GetSpaceIdByTypeHeaders();
            return await GetSpaceIdByTypeWithOptionsAsync(request, headers, runtime);
        }

        public GetSpaceIdByTypeResponse GetSpaceIdByTypeWithOptions(GetSpaceIdByTypeRequest request, GetSpaceIdByTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentType))
            {
                query["departmentType"] = request.DepartmentType;
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
            return TeaModel.ToObject<GetSpaceIdByTypeResponse>(DoROARequest("GetSpaceIdByType", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/spaces/types", "json", req, runtime));
        }

        public async Task<GetSpaceIdByTypeResponse> GetSpaceIdByTypeWithOptionsAsync(GetSpaceIdByTypeRequest request, GetSpaceIdByTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentType))
            {
                query["departmentType"] = request.DepartmentType;
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
            return TeaModel.ToObject<GetSpaceIdByTypeResponse>(await DoROARequestAsync("GetSpaceIdByType", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/spaces/types", "json", req, runtime));
        }

        public GetSpacesInfoResponse GetSpacesInfo(GetSpacesInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpacesInfoHeaders headers = new GetSpacesInfoHeaders();
            return GetSpacesInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetSpacesInfoResponse> GetSpacesInfoAsync(GetSpacesInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpacesInfoHeaders headers = new GetSpacesInfoHeaders();
            return await GetSpacesInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetSpacesInfoResponse GetSpacesInfoWithOptions(GetSpacesInfoRequest request, GetSpacesInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferIds))
            {
                body["referIds"] = request.ReferIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCorpId))
            {
                body["residentCorpId"] = request.ResidentCorpId;
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
            return TeaModel.ToObject<GetSpacesInfoResponse>(DoROARequest("GetSpacesInfo", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/spaces/query", "json", req, runtime));
        }

        public async Task<GetSpacesInfoResponse> GetSpacesInfoWithOptionsAsync(GetSpacesInfoRequest request, GetSpacesInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferIds))
            {
                body["referIds"] = request.ReferIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCorpId))
            {
                body["residentCorpId"] = request.ResidentCorpId;
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
            return TeaModel.ToObject<GetSpacesInfoResponse>(await DoROARequestAsync("GetSpacesInfo", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/spaces/query", "json", req, runtime));
        }

        public ListIndustryRoleUsersResponse ListIndustryRoleUsers(ListIndustryRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListIndustryRoleUsersHeaders headers = new ListIndustryRoleUsersHeaders();
            return ListIndustryRoleUsersWithOptions(request, headers, runtime);
        }

        public async Task<ListIndustryRoleUsersResponse> ListIndustryRoleUsersAsync(ListIndustryRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListIndustryRoleUsersHeaders headers = new ListIndustryRoleUsersHeaders();
            return await ListIndustryRoleUsersWithOptionsAsync(request, headers, runtime);
        }

        public ListIndustryRoleUsersResponse ListIndustryRoleUsersWithOptions(ListIndustryRoleUsersRequest request, ListIndustryRoleUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                query["tagCode"] = request.TagCode;
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
            return TeaModel.ToObject<ListIndustryRoleUsersResponse>(DoROARequest("ListIndustryRoleUsers", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/industryRoles/users", "json", req, runtime));
        }

        public async Task<ListIndustryRoleUsersResponse> ListIndustryRoleUsersWithOptionsAsync(ListIndustryRoleUsersRequest request, ListIndustryRoleUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                query["tagCode"] = request.TagCode;
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
            return TeaModel.ToObject<ListIndustryRoleUsersResponse>(await DoROARequestAsync("ListIndustryRoleUsers", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/industryRoles/users", "json", req, runtime));
        }

        public ListPointRulesResponse ListPointRules(ListPointRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPointRulesHeaders headers = new ListPointRulesHeaders();
            return ListPointRulesWithOptions(request, headers, runtime);
        }

        public async Task<ListPointRulesResponse> ListPointRulesAsync(ListPointRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPointRulesHeaders headers = new ListPointRulesHeaders();
            return await ListPointRulesWithOptionsAsync(request, headers, runtime);
        }

        public ListPointRulesResponse ListPointRulesWithOptions(ListPointRulesRequest request, ListPointRulesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCircle))
            {
                query["isCircle"] = request.IsCircle;
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
            return TeaModel.ToObject<ListPointRulesResponse>(DoROARequest("ListPointRules", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/points/rules", "json", req, runtime));
        }

        public async Task<ListPointRulesResponse> ListPointRulesWithOptionsAsync(ListPointRulesRequest request, ListPointRulesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCircle))
            {
                query["isCircle"] = request.IsCircle;
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
            return TeaModel.ToObject<ListPointRulesResponse>(await DoROARequestAsync("ListPointRules", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/points/rules", "json", req, runtime));
        }

        public ListSubSpaceResponse ListSubSpace(ListSubSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubSpaceHeaders headers = new ListSubSpaceHeaders();
            return ListSubSpaceWithOptions(request, headers, runtime);
        }

        public async Task<ListSubSpaceResponse> ListSubSpaceAsync(ListSubSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubSpaceHeaders headers = new ListSubSpaceHeaders();
            return await ListSubSpaceWithOptionsAsync(request, headers, runtime);
        }

        public ListSubSpaceResponse ListSubSpaceWithOptions(ListSubSpaceRequest request, ListSubSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferId))
            {
                query["referId"] = request.ReferId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCorpId))
            {
                query["residentCorpId"] = request.ResidentCorpId;
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
            return TeaModel.ToObject<ListSubSpaceResponse>(DoROARequest("ListSubSpace", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/spaces/subSpaces", "json", req, runtime));
        }

        public async Task<ListSubSpaceResponse> ListSubSpaceWithOptionsAsync(ListSubSpaceRequest request, ListSubSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferId))
            {
                query["referId"] = request.ReferId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCorpId))
            {
                query["residentCorpId"] = request.ResidentCorpId;
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
            return TeaModel.ToObject<ListSubSpaceResponse>(await DoROARequestAsync("ListSubSpace", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/spaces/subSpaces", "json", req, runtime));
        }

        public ListUncheckUsersResponse ListUncheckUsers(ListUncheckUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUncheckUsersHeaders headers = new ListUncheckUsersHeaders();
            return ListUncheckUsersWithOptions(request, headers, runtime);
        }

        public async Task<ListUncheckUsersResponse> ListUncheckUsersAsync(ListUncheckUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUncheckUsersHeaders headers = new ListUncheckUsersHeaders();
            return await ListUncheckUsersWithOptionsAsync(request, headers, runtime);
        }

        public ListUncheckUsersResponse ListUncheckUsersWithOptions(ListUncheckUsersRequest request, ListUncheckUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
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
            return TeaModel.ToObject<ListUncheckUsersResponse>(DoROARequest("ListUncheckUsers", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/organizations/noJoinUsers", "json", req, runtime));
        }

        public async Task<ListUncheckUsersResponse> ListUncheckUsersWithOptionsAsync(ListUncheckUsersRequest request, ListUncheckUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
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
            return TeaModel.ToObject<ListUncheckUsersResponse>(await DoROARequestAsync("ListUncheckUsers", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/organizations/noJoinUsers", "json", req, runtime));
        }

        public ListUserIndustryRolesResponse ListUserIndustryRoles(ListUserIndustryRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserIndustryRolesHeaders headers = new ListUserIndustryRolesHeaders();
            return ListUserIndustryRolesWithOptions(request, headers, runtime);
        }

        public async Task<ListUserIndustryRolesResponse> ListUserIndustryRolesAsync(ListUserIndustryRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserIndustryRolesHeaders headers = new ListUserIndustryRolesHeaders();
            return await ListUserIndustryRolesWithOptionsAsync(request, headers, runtime);
        }

        public ListUserIndustryRolesResponse ListUserIndustryRolesWithOptions(ListUserIndustryRolesRequest request, ListUserIndustryRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            return TeaModel.ToObject<ListUserIndustryRolesResponse>(DoROARequest("ListUserIndustryRoles", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/users/industryRoles", "json", req, runtime));
        }

        public async Task<ListUserIndustryRolesResponse> ListUserIndustryRolesWithOptionsAsync(ListUserIndustryRolesRequest request, ListUserIndustryRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            return TeaModel.ToObject<ListUserIndustryRolesResponse>(await DoROARequestAsync("ListUserIndustryRoles", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/users/industryRoles", "json", req, runtime));
        }

        public PagePointHistoryResponse PagePointHistory(PagePointHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PagePointHistoryHeaders headers = new PagePointHistoryHeaders();
            return PagePointHistoryWithOptions(request, headers, runtime);
        }

        public async Task<PagePointHistoryResponse> PagePointHistoryAsync(PagePointHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PagePointHistoryHeaders headers = new PagePointHistoryHeaders();
            return await PagePointHistoryWithOptionsAsync(request, headers, runtime);
        }

        public PagePointHistoryResponse PagePointHistoryWithOptions(PagePointHistoryRequest request, PagePointHistoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCircle))
            {
                query["isCircle"] = request.IsCircle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
            return TeaModel.ToObject<PagePointHistoryResponse>(DoROARequest("PagePointHistory", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/points/records", "json", req, runtime));
        }

        public async Task<PagePointHistoryResponse> PagePointHistoryWithOptionsAsync(PagePointHistoryRequest request, PagePointHistoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCircle))
            {
                query["isCircle"] = request.IsCircle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
            return TeaModel.ToObject<PagePointHistoryResponse>(await DoROARequestAsync("PagePointHistory", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/points/records", "json", req, runtime));
        }

        public RemoveResidentMemberResponse RemoveResidentMember(RemoveResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveResidentMemberHeaders headers = new RemoveResidentMemberHeaders();
            return RemoveResidentMemberWithOptions(request, headers, runtime);
        }

        public async Task<RemoveResidentMemberResponse> RemoveResidentMemberAsync(RemoveResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveResidentMemberHeaders headers = new RemoveResidentMemberHeaders();
            return await RemoveResidentMemberWithOptionsAsync(request, headers, runtime);
        }

        public RemoveResidentMemberResponse RemoveResidentMemberWithOptions(RemoveResidentMemberRequest request, RemoveResidentMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
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
            return TeaModel.ToObject<RemoveResidentMemberResponse>(DoROARequest("RemoveResidentMember", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/members/remove", "json", req, runtime));
        }

        public async Task<RemoveResidentMemberResponse> RemoveResidentMemberWithOptionsAsync(RemoveResidentMemberRequest request, RemoveResidentMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
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
            return TeaModel.ToObject<RemoveResidentMemberResponse>(await DoROARequestAsync("RemoveResidentMember", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/members/remove", "json", req, runtime));
        }

        public RemoveResidentUserResponse RemoveResidentUser(RemoveResidentUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveResidentUserHeaders headers = new RemoveResidentUserHeaders();
            return RemoveResidentUserWithOptions(request, headers, runtime);
        }

        public async Task<RemoveResidentUserResponse> RemoveResidentUserAsync(RemoveResidentUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveResidentUserHeaders headers = new RemoveResidentUserHeaders();
            return await RemoveResidentUserWithOptionsAsync(request, headers, runtime);
        }

        public RemoveResidentUserResponse RemoveResidentUserWithOptions(RemoveResidentUserRequest request, RemoveResidentUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
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
            return TeaModel.ToObject<RemoveResidentUserResponse>(DoROARequest("RemoveResidentUser", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/users/remove", "json", req, runtime));
        }

        public async Task<RemoveResidentUserResponse> RemoveResidentUserWithOptionsAsync(RemoveResidentUserRequest request, RemoveResidentUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
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
            return TeaModel.ToObject<RemoveResidentUserResponse>(await DoROARequestAsync("RemoveResidentUser", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/users/remove", "json", req, runtime));
        }

        public SearchResidentResponse SearchResident(SearchResidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchResidentHeaders headers = new SearchResidentHeaders();
            return SearchResidentWithOptions(request, headers, runtime);
        }

        public async Task<SearchResidentResponse> SearchResidentAsync(SearchResidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchResidentHeaders headers = new SearchResidentHeaders();
            return await SearchResidentWithOptionsAsync(request, headers, runtime);
        }

        public SearchResidentResponse SearchResidentWithOptions(SearchResidentRequest request, SearchResidentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCropId))
            {
                query["residentCropId"] = request.ResidentCropId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchWord))
            {
                query["searchWord"] = request.SearchWord;
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
            return TeaModel.ToObject<SearchResidentResponse>(DoROARequest("SearchResident", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/residences", "json", req, runtime));
        }

        public async Task<SearchResidentResponse> SearchResidentWithOptionsAsync(SearchResidentRequest request, SearchResidentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentCropId))
            {
                query["residentCropId"] = request.ResidentCropId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchWord))
            {
                query["searchWord"] = request.SearchWord;
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
            return TeaModel.ToObject<SearchResidentResponse>(await DoROARequestAsync("SearchResident", "resident_1.0", "HTTP", "GET", "AK", "/v1.0/resident/residences", "json", req, runtime));
        }

        public UpdateResideceGroupResponse UpdateResideceGroup(UpdateResideceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResideceGroupHeaders headers = new UpdateResideceGroupHeaders();
            return UpdateResideceGroupWithOptions(request, headers, runtime);
        }

        public async Task<UpdateResideceGroupResponse> UpdateResideceGroupAsync(UpdateResideceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResideceGroupHeaders headers = new UpdateResideceGroupHeaders();
            return await UpdateResideceGroupWithOptionsAsync(request, headers, runtime);
        }

        public UpdateResideceGroupResponse UpdateResideceGroupWithOptions(UpdateResideceGroupRequest request, UpdateResideceGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["departmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                query["managerUserId"] = request.ManagerUserId;
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
            return TeaModel.ToObject<UpdateResideceGroupResponse>(DoROARequest("UpdateResideceGroup", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/departments/updateResideceGroup", "json", req, runtime));
        }

        public async Task<UpdateResideceGroupResponse> UpdateResideceGroupWithOptionsAsync(UpdateResideceGroupRequest request, UpdateResideceGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["departmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                query["managerUserId"] = request.ManagerUserId;
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
            return TeaModel.ToObject<UpdateResideceGroupResponse>(await DoROARequestAsync("UpdateResideceGroup", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/departments/updateResideceGroup", "json", req, runtime));
        }

        public UpdateResidenceResponse UpdateResidence(UpdateResidenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidenceHeaders headers = new UpdateResidenceHeaders();
            return UpdateResidenceWithOptions(request, headers, runtime);
        }

        public async Task<UpdateResidenceResponse> UpdateResidenceAsync(UpdateResidenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidenceHeaders headers = new UpdateResidenceHeaders();
            return await UpdateResidenceWithOptionsAsync(request, headers, runtime);
        }

        public UpdateResidenceResponse UpdateResidenceWithOptions(UpdateResidenceRequest request, UpdateResidenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["departmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destitute))
            {
                query["destitute"] = request.Destitute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grid))
            {
                query["grid"] = request.Grid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomeTel))
            {
                query["homeTel"] = request.HomeTel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                query["managerUserId"] = request.ManagerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDepartmentId))
            {
                query["parentDepartmentId"] = request.ParentDepartmentId;
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
            return TeaModel.ToObject<UpdateResidenceResponse>(DoROARequest("UpdateResidence", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/departments/updateResidece", "json", req, runtime));
        }

        public async Task<UpdateResidenceResponse> UpdateResidenceWithOptionsAsync(UpdateResidenceRequest request, UpdateResidenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["departmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destitute))
            {
                query["destitute"] = request.Destitute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grid))
            {
                query["grid"] = request.Grid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomeTel))
            {
                query["homeTel"] = request.HomeTel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                query["managerUserId"] = request.ManagerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDepartmentId))
            {
                query["parentDepartmentId"] = request.ParentDepartmentId;
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
            return TeaModel.ToObject<UpdateResidenceResponse>(await DoROARequestAsync("UpdateResidence", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/departments/updateResidece", "json", req, runtime));
        }

        public UpdateResidentBlackBoardResponse UpdateResidentBlackBoard(UpdateResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentBlackBoardHeaders headers = new UpdateResidentBlackBoardHeaders();
            return UpdateResidentBlackBoardWithOptions(request, headers, runtime);
        }

        public async Task<UpdateResidentBlackBoardResponse> UpdateResidentBlackBoardAsync(UpdateResidentBlackBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentBlackBoardHeaders headers = new UpdateResidentBlackBoardHeaders();
            return await UpdateResidentBlackBoardWithOptionsAsync(request, headers, runtime);
        }

        public UpdateResidentBlackBoardResponse UpdateResidentBlackBoardWithOptions(UpdateResidentBlackBoardRequest request, UpdateResidentBlackBoardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackboardId))
            {
                body["blackboardId"] = request.BlackboardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                body["context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateResidentBlackBoardResponse>(DoROARequest("UpdateResidentBlackBoard", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/blackboards", "json", req, runtime));
        }

        public async Task<UpdateResidentBlackBoardResponse> UpdateResidentBlackBoardWithOptionsAsync(UpdateResidentBlackBoardRequest request, UpdateResidentBlackBoardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackboardId))
            {
                body["blackboardId"] = request.BlackboardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                body["context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateResidentBlackBoardResponse>(await DoROARequestAsync("UpdateResidentBlackBoard", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/blackboards", "json", req, runtime));
        }

        public UpdateResidentInfoResponse UpdateResidentInfo(UpdateResidentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentInfoHeaders headers = new UpdateResidentInfoHeaders();
            return UpdateResidentInfoWithOptions(request, headers, runtime);
        }

        public async Task<UpdateResidentInfoResponse> UpdateResidentInfoAsync(UpdateResidentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentInfoHeaders headers = new UpdateResidentInfoHeaders();
            return await UpdateResidentInfoWithOptionsAsync(request, headers, runtime);
        }

        public UpdateResidentInfoResponse UpdateResidentInfoWithOptions(UpdateResidentInfoRequest request, UpdateResidentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildingArea))
            {
                body["buildingArea"] = request.BuildingArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityName))
            {
                body["cityName"] = request.CityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommunityType))
            {
                body["communityType"] = request.CommunityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountyName))
            {
                body["countyName"] = request.CountyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvName))
            {
                body["provName"] = request.ProvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["state"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                body["telephone"] = request.Telephone;
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
            return TeaModel.ToObject<UpdateResidentInfoResponse>(DoROARequest("UpdateResidentInfo", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/residences", "json", req, runtime));
        }

        public async Task<UpdateResidentInfoResponse> UpdateResidentInfoWithOptionsAsync(UpdateResidentInfoRequest request, UpdateResidentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildingArea))
            {
                body["buildingArea"] = request.BuildingArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityName))
            {
                body["cityName"] = request.CityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommunityType))
            {
                body["communityType"] = request.CommunityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountyName))
            {
                body["countyName"] = request.CountyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvName))
            {
                body["provName"] = request.ProvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["state"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                body["telephone"] = request.Telephone;
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
            return TeaModel.ToObject<UpdateResidentInfoResponse>(await DoROARequestAsync("UpdateResidentInfo", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/residences", "json", req, runtime));
        }

        public UpdateResidentMemberResponse UpdateResidentMember(UpdateResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentMemberHeaders headers = new UpdateResidentMemberHeaders();
            return UpdateResidentMemberWithOptions(request, headers, runtime);
        }

        public async Task<UpdateResidentMemberResponse> UpdateResidentMemberAsync(UpdateResidentMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentMemberHeaders headers = new UpdateResidentMemberHeaders();
            return await UpdateResidentMemberWithOptionsAsync(request, headers, runtime);
        }

        public UpdateResidentMemberResponse UpdateResidentMemberWithOptions(UpdateResidentMemberRequest request, UpdateResidentMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentUpdateInfo.ToMap()))
            {
                body["residentUpdateInfo"] = request.ResidentUpdateInfo;
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
            return TeaModel.ToObject<UpdateResidentMemberResponse>(DoROARequest("UpdateResidentMember", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/members", "json", req, runtime));
        }

        public async Task<UpdateResidentMemberResponse> UpdateResidentMemberWithOptionsAsync(UpdateResidentMemberRequest request, UpdateResidentMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResidentUpdateInfo.ToMap()))
            {
                body["residentUpdateInfo"] = request.ResidentUpdateInfo;
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
            return TeaModel.ToObject<UpdateResidentMemberResponse>(await DoROARequestAsync("UpdateResidentMember", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/members", "json", req, runtime));
        }

        public UpdateResidentUserResponse UpdateResidentUser(UpdateResidentUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentUserHeaders headers = new UpdateResidentUserHeaders();
            return UpdateResidentUserWithOptions(request, headers, runtime);
        }

        public async Task<UpdateResidentUserResponse> UpdateResidentUserAsync(UpdateResidentUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateResidentUserHeaders headers = new UpdateResidentUserHeaders();
            return await UpdateResidentUserWithOptionsAsync(request, headers, runtime);
        }

        public UpdateResidentUserResponse UpdateResidentUserWithOptions(UpdateResidentUserRequest request, UpdateResidentUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtField))
            {
                query["extField"] = request.ExtField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRetainOldDept))
            {
                query["isRetainOldDept"] = request.IsRetainOldDept;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldDepartmentId))
            {
                query["oldDepartmentId"] = request.OldDepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelateType))
            {
                query["relateType"] = request.RelateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["userName"] = request.UserName;
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
            return TeaModel.ToObject<UpdateResidentUserResponse>(DoROARequest("UpdateResidentUser", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/users", "json", req, runtime));
        }

        public async Task<UpdateResidentUserResponse> UpdateResidentUserWithOptionsAsync(UpdateResidentUserRequest request, UpdateResidentUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtField))
            {
                query["extField"] = request.ExtField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRetainOldDept))
            {
                query["isRetainOldDept"] = request.IsRetainOldDept;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldDepartmentId))
            {
                query["oldDepartmentId"] = request.OldDepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelateType))
            {
                query["relateType"] = request.RelateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["userName"] = request.UserName;
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
            return TeaModel.ToObject<UpdateResidentUserResponse>(await DoROARequestAsync("UpdateResidentUser", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/users", "json", req, runtime));
        }

        public UpdateSpaceResponse UpdateSpace(UpdateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSpaceHeaders headers = new UpdateSpaceHeaders();
            return UpdateSpaceWithOptions(request, headers, runtime);
        }

        public async Task<UpdateSpaceResponse> UpdateSpaceAsync(UpdateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSpaceHeaders headers = new UpdateSpaceHeaders();
            return await UpdateSpaceWithOptionsAsync(request, headers, runtime);
        }

        public UpdateSpaceResponse UpdateSpaceWithOptions(UpdateSpaceRequest request, UpdateSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceInfoVOList))
            {
                body["spaceInfoVOList"] = request.SpaceInfoVOList;
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
            return TeaModel.ToObject<UpdateSpaceResponse>(DoROARequest("UpdateSpace", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/spaces", "json", req, runtime));
        }

        public async Task<UpdateSpaceResponse> UpdateSpaceWithOptionsAsync(UpdateSpaceRequest request, UpdateSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceInfoVOList))
            {
                body["spaceInfoVOList"] = request.SpaceInfoVOList;
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
            return TeaModel.ToObject<UpdateSpaceResponse>(await DoROARequestAsync("UpdateSpace", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/spaces", "json", req, runtime));
        }

    }
}
