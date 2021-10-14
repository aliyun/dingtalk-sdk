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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AddResidentDepartmentResponse>(await DoROARequestAsync("AddResidentDepartment", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/departments", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AddResidentUsersResponse>(await DoROARequestAsync("AddResidentUsers", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/users", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteResidentDepartmentResponse>(await DoROARequestAsync("DeleteResidentDepartment", "resident_1.0", "HTTP", "DELETE", "AK", "/v1.0/resident/departments", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RemoveResidentUserResponse>(await DoROARequestAsync("RemoveResidentUser", "resident_1.0", "HTTP", "POST", "AK", "/v1.0/resident/users/remove", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateResidenceResponse>(await DoROARequestAsync("UpdateResidence", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/departments/updateResidece", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateResidentUserResponse>(await DoROARequestAsync("UpdateResidentUser", "resident_1.0", "HTTP", "PUT", "AK", "/v1.0/resident/users", "json", req, runtime));
        }

    }
}
