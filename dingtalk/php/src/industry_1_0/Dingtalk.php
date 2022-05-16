<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactCreateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactCreateRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactCreateResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeleteHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeleteRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeleteResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptCreateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptCreateRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptCreateResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptDeleteHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptDeleteRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptDeleteResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptListRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptListResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptUpdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptUpdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptUpdateResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpAddHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpAddRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpAddResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpDeleteHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpDeleteRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpDeleteResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpListRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpListResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactListResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactUpdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactUpdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactUpdateResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreContactInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreContactInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreGroupInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreGroupInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreGroupInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreGroupsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreGroupsResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreNodeInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreNodeInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreNodeInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreRolesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreRolesResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreStoreInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreStoreInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreStoreInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreSubNodesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreSubNodesRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreSubNodesResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUserInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureCostRecordListGetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureCostRecordListGetRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureCostRecordListGetResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureFeeListGetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureFeeListGetRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureFeeListGetResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureLabourCostHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureLabourCostRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureLabourCostResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMaterialListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMaterialListRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMaterialListResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesTeamMgmtHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesTeamMgmtRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesTeamMgmtResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryMmanufactureMaterialCostGetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryMmanufactureMaterialCostGetRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryMmanufactureMaterialCostGetResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDoctorsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDoctorsRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDoctorsResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupsInDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupsInDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupsInDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryBizOptLogHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryBizOptLogRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryBizOptLogResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryGroupInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryGroupInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalDistrictInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalDistrictInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalDistrictInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRolesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRolesResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRoleUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRoleUserInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRoleUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryJobCodeDictionaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryJobCodeDictionaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryJobStatusCodeDictionaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryJobStatusCodeDictionaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryMedicalEventsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryMedicalEventsResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserCredentialsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserCredentialsRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserCredentialsResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserExtendValuesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserExtendValuesRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserExtendValuesResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserExtInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserExtInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserProbCodeDictionaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserProbCodeDictionaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserRolesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserRolesResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SaveUserExtendValuesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SaveUserExtendValuesRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SaveUserExtendValuesResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\UpdateUserExtendInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\UpdateUserExtendInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\UpdateUserExtendInfoResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param CustomizeContactCreateRequest $request
     *
     * @return CustomizeContactCreateResponse
     */
    public function customizeContactCreate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactCreateHeaders([]);

        return $this->customizeContactCreateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactCreateRequest $request
     * @param CustomizeContactCreateHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CustomizeContactCreateResponse
     */
    public function customizeContactCreateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->managerIdList)) {
            @$body['managerIdList'] = $request->managerIdList;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->order)) {
            @$body['order'] = $request->order;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CustomizeContactCreateResponse::fromMap($this->doROARequest('CustomizeContactCreate', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/customizations/contacts', 'json', $req, $runtime));
    }

    /**
     * @param CustomizeContactDeleteRequest $request
     *
     * @return CustomizeContactDeleteResponse
     */
    public function customizeContactDelete($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeleteHeaders([]);

        return $this->customizeContactDeleteWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactDeleteRequest $request
     * @param CustomizeContactDeleteHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CustomizeContactDeleteResponse
     */
    public function customizeContactDeleteWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            @$query['code'] = $request->code;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return CustomizeContactDeleteResponse::fromMap($this->doROARequest('CustomizeContactDelete', 'industry_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/industry/customizations/contacts', 'json', $req, $runtime));
    }

    /**
     * @param CustomizeContactDeptCreateRequest $request
     *
     * @return CustomizeContactDeptCreateResponse
     */
    public function customizeContactDeptCreate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptCreateHeaders([]);

        return $this->customizeContactDeptCreateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactDeptCreateRequest $request
     * @param CustomizeContactDeptCreateHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return CustomizeContactDeptCreateResponse
     */
    public function customizeContactDeptCreateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->code)) {
            @$body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->managerIdList)) {
            @$body['managerIdList'] = $request->managerIdList;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->order)) {
            @$body['order'] = $request->order;
        }
        if (!Utils::isUnset($request->parentDeptId)) {
            @$body['parentDeptId'] = $request->parentDeptId;
        }
        if (!Utils::isUnset($request->refId)) {
            @$body['refId'] = $request->refId;
        }
        if (!Utils::isUnset($request->type)) {
            @$body['type'] = $request->type;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CustomizeContactDeptCreateResponse::fromMap($this->doROARequest('CustomizeContactDeptCreate', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/customizations/departments', 'json', $req, $runtime));
    }

    /**
     * @param CustomizeContactDeptDeleteRequest $request
     *
     * @return CustomizeContactDeptDeleteResponse
     */
    public function customizeContactDeptDelete($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptDeleteHeaders([]);

        return $this->customizeContactDeptDeleteWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactDeptDeleteRequest $request
     * @param CustomizeContactDeptDeleteHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return CustomizeContactDeptDeleteResponse
     */
    public function customizeContactDeptDeleteWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            @$query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->deptId)) {
            @$query['deptId'] = $request->deptId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return CustomizeContactDeptDeleteResponse::fromMap($this->doROARequest('CustomizeContactDeptDelete', 'industry_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/industry/customizations/departments', 'json', $req, $runtime));
    }

    /**
     * @param CustomizeContactDeptInfoRequest $request
     *
     * @return CustomizeContactDeptInfoResponse
     */
    public function customizeContactDeptInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptInfoHeaders([]);

        return $this->customizeContactDeptInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactDeptInfoRequest $request
     * @param CustomizeContactDeptInfoHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return CustomizeContactDeptInfoResponse
     */
    public function customizeContactDeptInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            @$query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->deptId)) {
            @$query['deptId'] = $request->deptId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return CustomizeContactDeptInfoResponse::fromMap($this->doROARequest('CustomizeContactDeptInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/customizations/departments', 'json', $req, $runtime));
    }

    /**
     * @param CustomizeContactDeptListRequest $request
     *
     * @return CustomizeContactDeptListResponse
     */
    public function customizeContactDeptList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptListHeaders([]);

        return $this->customizeContactDeptListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactDeptListRequest $request
     * @param CustomizeContactDeptListHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return CustomizeContactDeptListResponse
     */
    public function customizeContactDeptListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            @$query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->deptId)) {
            @$query['deptId'] = $request->deptId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return CustomizeContactDeptListResponse::fromMap($this->doROARequest('CustomizeContactDeptList', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/customizations/subsidiaryDepartments', 'json', $req, $runtime));
    }

    /**
     * @param CustomizeContactDeptUpdateRequest $request
     *
     * @return CustomizeContactDeptUpdateResponse
     */
    public function customizeContactDeptUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptUpdateHeaders([]);

        return $this->customizeContactDeptUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactDeptUpdateRequest $request
     * @param CustomizeContactDeptUpdateHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return CustomizeContactDeptUpdateResponse
     */
    public function customizeContactDeptUpdateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->code)) {
            @$body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->deptId)) {
            @$body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->managerIdList)) {
            @$body['managerIdList'] = $request->managerIdList;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->order)) {
            @$body['order'] = $request->order;
        }
        if (!Utils::isUnset($request->parentDeptId)) {
            @$body['parentDeptId'] = $request->parentDeptId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CustomizeContactDeptUpdateResponse::fromMap($this->doROARequest('CustomizeContactDeptUpdate', 'industry_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/industry/customizations/departments', 'json', $req, $runtime));
    }

    /**
     * @param CustomizeContactEmpAddRequest $request
     *
     * @return CustomizeContactEmpAddResponse
     */
    public function customizeContactEmpAdd($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactEmpAddHeaders([]);

        return $this->customizeContactEmpAddWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactEmpAddRequest $request
     * @param CustomizeContactEmpAddHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CustomizeContactEmpAddResponse
     */
    public function customizeContactEmpAddWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->code)) {
            @$body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->deptId)) {
            @$body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->userIdList)) {
            @$body['userIdList'] = $request->userIdList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CustomizeContactEmpAddResponse::fromMap($this->doROARequest('CustomizeContactEmpAdd', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/customizations/users', 'json', $req, $runtime));
    }

    /**
     * @param CustomizeContactEmpDeleteRequest $request
     *
     * @return CustomizeContactEmpDeleteResponse
     */
    public function customizeContactEmpDelete($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactEmpDeleteHeaders([]);

        return $this->customizeContactEmpDeleteWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactEmpDeleteRequest $request
     * @param CustomizeContactEmpDeleteHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return CustomizeContactEmpDeleteResponse
     */
    public function customizeContactEmpDeleteWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->code)) {
            @$body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->deptId)) {
            @$body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->userIdList)) {
            @$body['userIdList'] = $request->userIdList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CustomizeContactEmpDeleteResponse::fromMap($this->doROARequest('CustomizeContactEmpDelete', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/customizations/users/remove', 'json', $req, $runtime));
    }

    /**
     * @param CustomizeContactEmpListRequest $request
     *
     * @return CustomizeContactEmpListResponse
     */
    public function customizeContactEmpList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactEmpListHeaders([]);

        return $this->customizeContactEmpListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactEmpListRequest $request
     * @param CustomizeContactEmpListHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CustomizeContactEmpListResponse
     */
    public function customizeContactEmpListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            @$query['deptId'] = $request->deptId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return CustomizeContactEmpListResponse::fromMap($this->doROARequest('CustomizeContactEmpList', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/customizations/users', 'json', $req, $runtime));
    }

    /**
     * @return CustomizeContactListResponse
     */
    public function customizeContactList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactListHeaders([]);

        return $this->customizeContactListWithOptions($headers, $runtime);
    }

    /**
     * @param CustomizeContactListHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return CustomizeContactListResponse
     */
    public function customizeContactListWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return CustomizeContactListResponse::fromMap($this->doROARequest('CustomizeContactList', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/customizations/contacts', 'json', $req, $runtime));
    }

    /**
     * @param CustomizeContactUpdateRequest $request
     *
     * @return CustomizeContactUpdateResponse
     */
    public function customizeContactUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactUpdateHeaders([]);

        return $this->customizeContactUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactUpdateRequest $request
     * @param CustomizeContactUpdateHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CustomizeContactUpdateResponse
     */
    public function customizeContactUpdateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->code)) {
            @$body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->managerIdList)) {
            @$body['managerIdList'] = $request->managerIdList;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->order)) {
            @$body['order'] = $request->order;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CustomizeContactUpdateResponse::fromMap($this->doROARequest('CustomizeContactUpdate', 'industry_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/industry/customizations/contacts', 'json', $req, $runtime));
    }

    /**
     * @return DigitalStoreContactInfoResponse
     */
    public function digitalStoreContactInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreContactInfoHeaders([]);

        return $this->digitalStoreContactInfoWithOptions($headers, $runtime);
    }

    /**
     * @param DigitalStoreContactInfoHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return DigitalStoreContactInfoResponse
     */
    public function digitalStoreContactInfoWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return DigitalStoreContactInfoResponse::fromMap($this->doROARequest('DigitalStoreContactInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/digitalStores/contactInfos', 'json', $req, $runtime));
    }

    /**
     * @param DigitalStoreGroupInfoRequest $request
     *
     * @return DigitalStoreGroupInfoResponse
     */
    public function digitalStoreGroupInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreGroupInfoHeaders([]);

        return $this->digitalStoreGroupInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DigitalStoreGroupInfoRequest $request
     * @param DigitalStoreGroupInfoHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return DigitalStoreGroupInfoResponse
     */
    public function digitalStoreGroupInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->groupId)) {
            @$query['groupId'] = $request->groupId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DigitalStoreGroupInfoResponse::fromMap($this->doROARequest('DigitalStoreGroupInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/digitalStores/groupInfos', 'json', $req, $runtime));
    }

    /**
     * @return DigitalStoreGroupsResponse
     */
    public function digitalStoreGroups()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreGroupsHeaders([]);

        return $this->digitalStoreGroupsWithOptions($headers, $runtime);
    }

    /**
     * @param DigitalStoreGroupsHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return DigitalStoreGroupsResponse
     */
    public function digitalStoreGroupsWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return DigitalStoreGroupsResponse::fromMap($this->doROARequest('DigitalStoreGroups', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/digitalStores/groups', 'json', $req, $runtime));
    }

    /**
     * @param DigitalStoreNodeInfoRequest $request
     *
     * @return DigitalStoreNodeInfoResponse
     */
    public function digitalStoreNodeInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreNodeInfoHeaders([]);

        return $this->digitalStoreNodeInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DigitalStoreNodeInfoRequest $request
     * @param DigitalStoreNodeInfoHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return DigitalStoreNodeInfoResponse
     */
    public function digitalStoreNodeInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            @$query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->nodeId)) {
            @$query['nodeId'] = $request->nodeId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DigitalStoreNodeInfoResponse::fromMap($this->doROARequest('DigitalStoreNodeInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/digitalStores/nodeInfos', 'json', $req, $runtime));
    }

    /**
     * @return DigitalStoreRolesResponse
     */
    public function digitalStoreRoles()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreRolesHeaders([]);

        return $this->digitalStoreRolesWithOptions($headers, $runtime);
    }

    /**
     * @param DigitalStoreRolesHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return DigitalStoreRolesResponse
     */
    public function digitalStoreRolesWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return DigitalStoreRolesResponse::fromMap($this->doROARequest('DigitalStoreRoles', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/digitalStores/roles', 'json', $req, $runtime));
    }

    /**
     * @param DigitalStoreStoreInfoRequest $request
     *
     * @return DigitalStoreStoreInfoResponse
     */
    public function digitalStoreStoreInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreStoreInfoHeaders([]);

        return $this->digitalStoreStoreInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DigitalStoreStoreInfoRequest $request
     * @param DigitalStoreStoreInfoHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return DigitalStoreStoreInfoResponse
     */
    public function digitalStoreStoreInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            @$query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->storeId)) {
            @$query['storeId'] = $request->storeId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DigitalStoreStoreInfoResponse::fromMap($this->doROARequest('DigitalStoreStoreInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/digitalStores/storeInfos', 'json', $req, $runtime));
    }

    /**
     * @param DigitalStoreSubNodesRequest $request
     *
     * @return DigitalStoreSubNodesResponse
     */
    public function digitalStoreSubNodes($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreSubNodesHeaders([]);

        return $this->digitalStoreSubNodesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DigitalStoreSubNodesRequest $request
     * @param DigitalStoreSubNodesHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return DigitalStoreSubNodesResponse
     */
    public function digitalStoreSubNodesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            @$query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->nodeId)) {
            @$query['nodeId'] = $request->nodeId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DigitalStoreSubNodesResponse::fromMap($this->doROARequest('DigitalStoreSubNodes', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/digitalStores/subsidiaryNodes', 'json', $req, $runtime));
    }

    /**
     * @param DigitalStoreUserInfoRequest $request
     *
     * @return DigitalStoreUserInfoResponse
     */
    public function digitalStoreUserInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreUserInfoHeaders([]);

        return $this->digitalStoreUserInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DigitalStoreUserInfoRequest $request
     * @param DigitalStoreUserInfoHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return DigitalStoreUserInfoResponse
     */
    public function digitalStoreUserInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            @$query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DigitalStoreUserInfoResponse::fromMap($this->doROARequest('DigitalStoreUserInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/digitalStores/userInfos', 'json', $req, $runtime));
    }

    /**
     * @param DigitalStoreUsersRequest $request
     *
     * @return DigitalStoreUsersResponse
     */
    public function digitalStoreUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreUsersHeaders([]);

        return $this->digitalStoreUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DigitalStoreUsersRequest $request
     * @param DigitalStoreUsersHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return DigitalStoreUsersResponse
     */
    public function digitalStoreUsersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            @$query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->nodeId)) {
            @$query['nodeId'] = $request->nodeId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DigitalStoreUsersResponse::fromMap($this->doROARequest('DigitalStoreUsers', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/digitalStores/nodes/users', 'json', $req, $runtime));
    }

    /**
     * @param IndustryManufactureCostRecordListGetRequest $request
     *
     * @return IndustryManufactureCostRecordListGetResponse
     */
    public function industryManufactureCostRecordListGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureCostRecordListGetHeaders([]);

        return $this->industryManufactureCostRecordListGetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureCostRecordListGetRequest $request
     * @param IndustryManufactureCostRecordListGetHeaders $headers
     * @param RuntimeOptions                              $runtime
     *
     * @return IndustryManufactureCostRecordListGetResponse
     */
    public function industryManufactureCostRecordListGetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            @$body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->appIds)) {
            @$body['appIds'] = $request->appIds;
        }
        if (!Utils::isUnset($request->appName)) {
            @$body['appName'] = $request->appName;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->cursor)) {
            @$body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->isvOrgId)) {
            @$body['isvOrgId'] = $request->isvOrgId;
        }
        if (!Utils::isUnset($request->materialNo)) {
            @$body['materialNo'] = $request->materialNo;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            @$body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->orderNo)) {
            @$body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->orgId)) {
            @$body['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->productionTaskNo)) {
            @$body['productionTaskNo'] = $request->productionTaskNo;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->suiteKey)) {
            @$body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->tokenGrantType)) {
            @$body['tokenGrantType'] = $request->tokenGrantType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return IndustryManufactureCostRecordListGetResponse::fromMap($this->doROARequest('IndustryManufactureCostRecordListGet', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/manufactures/materialCostRecords/query', 'json', $req, $runtime));
    }

    /**
     * @param IndustryManufactureFeeListGetRequest $request
     *
     * @return IndustryManufactureFeeListGetResponse
     */
    public function industryManufactureFeeListGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureFeeListGetHeaders([]);

        return $this->industryManufactureFeeListGetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureFeeListGetRequest $request
     * @param IndustryManufactureFeeListGetHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return IndustryManufactureFeeListGetResponse
     */
    public function industryManufactureFeeListGetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            @$body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->appIds)) {
            @$body['appIds'] = $request->appIds;
        }
        if (!Utils::isUnset($request->appName)) {
            @$body['appName'] = $request->appName;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->cursor)) {
            @$body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->isvOrgId)) {
            @$body['isvOrgId'] = $request->isvOrgId;
        }
        if (!Utils::isUnset($request->materialNo)) {
            @$body['materialNo'] = $request->materialNo;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            @$body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->orgId)) {
            @$body['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->productionTaskNo)) {
            @$body['productionTaskNo'] = $request->productionTaskNo;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->suiteKey)) {
            @$body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->tokenGrantType)) {
            @$body['tokenGrantType'] = $request->tokenGrantType;
        }
        if (!Utils::isUnset($request->type)) {
            @$body['type'] = $request->type;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return IndustryManufactureFeeListGetResponse::fromMap($this->doROARequest('IndustryManufactureFeeListGet', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/manufactures/fees/query', 'json', $req, $runtime));
    }

    /**
     * @param IndustryManufactureLabourCostRequest $request
     *
     * @return IndustryManufactureLabourCostResponse
     */
    public function industryManufactureLabourCost($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureLabourCostHeaders([]);

        return $this->industryManufactureLabourCostWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureLabourCostRequest $request
     * @param IndustryManufactureLabourCostHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return IndustryManufactureLabourCostResponse
     */
    public function industryManufactureLabourCostWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            @$body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->appIds)) {
            @$body['appIds'] = $request->appIds;
        }
        if (!Utils::isUnset($request->appName)) {
            @$body['appName'] = $request->appName;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->cursor)) {
            @$body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->isvOrgId)) {
            @$body['isvOrgId'] = $request->isvOrgId;
        }
        if (!Utils::isUnset($request->materialNo)) {
            @$body['materialNo'] = $request->materialNo;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            @$body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->orgId)) {
            @$body['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->processNo)) {
            @$body['processNo'] = $request->processNo;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->suiteKey)) {
            @$body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->tokenGrantType)) {
            @$body['tokenGrantType'] = $request->tokenGrantType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return IndustryManufactureLabourCostResponse::fromMap($this->doROARequest('IndustryManufactureLabourCost', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/manufactures/labourCosts/query', 'json', $req, $runtime));
    }

    /**
     * @param IndustryManufactureMaterialListRequest $request
     *
     * @return IndustryManufactureMaterialListResponse
     */
    public function industryManufactureMaterialList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMaterialListHeaders([]);

        return $this->industryManufactureMaterialListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureMaterialListRequest $request
     * @param IndustryManufactureMaterialListHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return IndustryManufactureMaterialListResponse
     */
    public function industryManufactureMaterialListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            @$body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->appIds)) {
            @$body['appIds'] = $request->appIds;
        }
        if (!Utils::isUnset($request->appName)) {
            @$body['appName'] = $request->appName;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->currentPage)) {
            @$body['currentPage'] = $request->currentPage;
        }
        if (!Utils::isUnset($request->cursor)) {
            @$body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->isvOrgId)) {
            @$body['isvOrgId'] = $request->isvOrgId;
        }
        if (!Utils::isUnset($request->materialNo)) {
            @$body['materialNo'] = $request->materialNo;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            @$body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->orgId)) {
            @$body['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->suiteKey)) {
            @$body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->tokenGrantType)) {
            @$body['tokenGrantType'] = $request->tokenGrantType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return IndustryManufactureMaterialListResponse::fromMap($this->doROARequest('IndustryManufactureMaterialList', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/manufactures/materials/query', 'json', $req, $runtime));
    }

    /**
     * @param IndustryManufactureMesTeamMgmtRequest $request
     *
     * @return IndustryManufactureMesTeamMgmtResponse
     */
    public function industryManufactureMesTeamMgmt($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesTeamMgmtHeaders([]);

        return $this->industryManufactureMesTeamMgmtWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureMesTeamMgmtRequest $request
     * @param IndustryManufactureMesTeamMgmtHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return IndustryManufactureMesTeamMgmtResponse
     */
    public function industryManufactureMesTeamMgmtWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            @$body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->appKey)) {
            @$body['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->baseDataName)) {
            @$body['baseDataName'] = $request->baseDataName;
        }
        if (!Utils::isUnset($request->events)) {
            @$body['events'] = $request->events;
        }
        if (!Utils::isUnset($request->extendData)) {
            @$body['extendData'] = $request->extendData;
        }
        if (!Utils::isUnset($request->groupConfig)) {
            @$body['groupConfig'] = $request->groupConfig;
        }
        if (!Utils::isUnset($request->groupPlugins)) {
            @$body['groupPlugins'] = $request->groupPlugins;
        }
        if (!Utils::isUnset($request->groupType)) {
            @$body['groupType'] = $request->groupType;
        }
        if (!Utils::isUnset($request->id)) {
            @$body['id'] = $request->id;
        }
        if (!Utils::isUnset($request->leaders)) {
            @$body['leaders'] = $request->leaders;
        }
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->processIds)) {
            @$body['processIds'] = $request->processIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return IndustryManufactureMesTeamMgmtResponse::fromMap($this->doROARequest('IndustryManufactureMesTeamMgmt', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/manufacturing/base/data/team', 'json', $req, $runtime));
    }

    /**
     * @param IndustryMmanufactureMaterialCostGetRequest $request
     *
     * @return IndustryMmanufactureMaterialCostGetResponse
     */
    public function industryMmanufactureMaterialCostGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryMmanufactureMaterialCostGetHeaders([]);

        return $this->industryMmanufactureMaterialCostGetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryMmanufactureMaterialCostGetRequest $request
     * @param IndustryMmanufactureMaterialCostGetHeaders $headers
     * @param RuntimeOptions                             $runtime
     *
     * @return IndustryMmanufactureMaterialCostGetResponse
     */
    public function industryMmanufactureMaterialCostGetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            @$body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->appIds)) {
            @$body['appIds'] = $request->appIds;
        }
        if (!Utils::isUnset($request->appName)) {
            @$body['appName'] = $request->appName;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->cursor)) {
            @$body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->isvOrgId)) {
            @$body['isvOrgId'] = $request->isvOrgId;
        }
        if (!Utils::isUnset($request->materialNo)) {
            @$body['materialNo'] = $request->materialNo;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            @$body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->orgId)) {
            @$body['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->suiteKey)) {
            @$body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->tokenGrantType)) {
            @$body['tokenGrantType'] = $request->tokenGrantType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return IndustryMmanufactureMaterialCostGetResponse::fromMap($this->doROARequest('IndustryMmanufactureMaterialCostGet', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/manufactures/base/materialCosts/query', 'json', $req, $runtime));
    }

    /**
     * @param QueryAllDepartmentRequest $request
     *
     * @return QueryAllDepartmentResponse
     */
    public function queryAllDepartment($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllDepartmentHeaders([]);

        return $this->queryAllDepartmentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllDepartmentRequest $request
     * @param QueryAllDepartmentHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryAllDepartmentResponse
     */
    public function queryAllDepartmentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryAllDepartmentResponse::fromMap($this->doROARequest('QueryAllDepartment', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/departments', 'json', $req, $runtime));
    }

    /**
     * @param QueryAllDoctorsRequest $request
     *
     * @return QueryAllDoctorsResponse
     */
    public function queryAllDoctors($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllDoctorsHeaders([]);

        return $this->queryAllDoctorsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllDoctorsRequest $request
     * @param QueryAllDoctorsHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return QueryAllDoctorsResponse
     */
    public function queryAllDoctorsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNum)) {
            @$query['pageNum'] = $request->pageNum;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryAllDoctorsResponse::fromMap($this->doROARequest('QueryAllDoctors', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/doctors', 'json', $req, $runtime));
    }

    /**
     * @param QueryAllGroupRequest $request
     *
     * @return QueryAllGroupResponse
     */
    public function queryAllGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllGroupHeaders([]);

        return $this->queryAllGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllGroupRequest $request
     * @param QueryAllGroupHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return QueryAllGroupResponse
     */
    public function queryAllGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryAllGroupResponse::fromMap($this->doROARequest('QueryAllGroup', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/groups', 'json', $req, $runtime));
    }

    /**
     * @param string                      $deptId
     * @param QueryAllGroupsInDeptRequest $request
     *
     * @return QueryAllGroupsInDeptResponse
     */
    public function queryAllGroupsInDept($deptId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllGroupsInDeptHeaders([]);

        return $this->queryAllGroupsInDeptWithOptions($deptId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $deptId
     * @param QueryAllGroupsInDeptRequest $request
     * @param QueryAllGroupsInDeptHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryAllGroupsInDeptResponse
     */
    public function queryAllGroupsInDeptWithOptions($deptId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $deptId = OpenApiUtilClient::getEncodeParam($deptId);
        $query  = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryAllGroupsInDeptResponse::fromMap($this->doROARequest('QueryAllGroupsInDept', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/departments/' . $deptId . '/groups', 'json', $req, $runtime));
    }

    /**
     * @param string                      $deptId
     * @param QueryAllMemberByDeptRequest $request
     *
     * @return QueryAllMemberByDeptResponse
     */
    public function queryAllMemberByDept($deptId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllMemberByDeptHeaders([]);

        return $this->queryAllMemberByDeptWithOptions($deptId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $deptId
     * @param QueryAllMemberByDeptRequest $request
     * @param QueryAllMemberByDeptHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryAllMemberByDeptResponse
     */
    public function queryAllMemberByDeptWithOptions($deptId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $deptId = OpenApiUtilClient::getEncodeParam($deptId);
        $query  = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryAllMemberByDeptResponse::fromMap($this->doROARequest('QueryAllMemberByDept', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/departments/' . $deptId . '/members', 'json', $req, $runtime));
    }

    /**
     * @param string                       $groupId
     * @param QueryAllMemberByGroupRequest $request
     *
     * @return QueryAllMemberByGroupResponse
     */
    public function queryAllMemberByGroup($groupId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllMemberByGroupHeaders([]);

        return $this->queryAllMemberByGroupWithOptions($groupId, $request, $headers, $runtime);
    }

    /**
     * @param string                       $groupId
     * @param QueryAllMemberByGroupRequest $request
     * @param QueryAllMemberByGroupHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return QueryAllMemberByGroupResponse
     */
    public function queryAllMemberByGroupWithOptions($groupId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $groupId = OpenApiUtilClient::getEncodeParam($groupId);
        $query   = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryAllMemberByGroupResponse::fromMap($this->doROARequest('QueryAllMemberByGroup', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/groups/' . $groupId . '/members', 'json', $req, $runtime));
    }

    /**
     * @param QueryBizOptLogRequest $request
     *
     * @return QueryBizOptLogResponse
     */
    public function queryBizOptLog($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBizOptLogHeaders([]);

        return $this->queryBizOptLogWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryBizOptLogRequest $request
     * @param QueryBizOptLogHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryBizOptLogResponse
     */
    public function queryBizOptLogWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryBizOptLogResponse::fromMap($this->doROARequest('QueryBizOptLog', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/bizOptLogs', 'json', $req, $runtime));
    }

    /**
     * @param string $deptId
     *
     * @return QueryDepartmentInfoResponse
     */
    public function queryDepartmentInfo($deptId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDepartmentInfoHeaders([]);

        return $this->queryDepartmentInfoWithOptions($deptId, $headers, $runtime);
    }

    /**
     * @param string                     $deptId
     * @param QueryDepartmentInfoHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryDepartmentInfoResponse
     */
    public function queryDepartmentInfoWithOptions($deptId, $headers, $runtime)
    {
        $deptId      = OpenApiUtilClient::getEncodeParam($deptId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryDepartmentInfoResponse::fromMap($this->doROARequest('QueryDepartmentInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/departments/' . $deptId . '', 'json', $req, $runtime));
    }

    /**
     * @param string $groupId
     *
     * @return QueryGroupInfoResponse
     */
    public function queryGroupInfo($groupId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupInfoHeaders([]);

        return $this->queryGroupInfoWithOptions($groupId, $headers, $runtime);
    }

    /**
     * @param string                $groupId
     * @param QueryGroupInfoHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryGroupInfoResponse
     */
    public function queryGroupInfoWithOptions($groupId, $headers, $runtime)
    {
        $groupId     = OpenApiUtilClient::getEncodeParam($groupId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryGroupInfoResponse::fromMap($this->doROARequest('QueryGroupInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/groups/' . $groupId . '', 'json', $req, $runtime));
    }

    /**
     * @param QueryHospitalDistrictInfoRequest $request
     *
     * @return QueryHospitalDistrictInfoResponse
     */
    public function queryHospitalDistrictInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHospitalDistrictInfoHeaders([]);

        return $this->queryHospitalDistrictInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryHospitalDistrictInfoRequest $request
     * @param QueryHospitalDistrictInfoHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryHospitalDistrictInfoResponse
     */
    public function queryHospitalDistrictInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryHospitalDistrictInfoResponse::fromMap($this->doROARequest('QueryHospitalDistrictInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/districts', 'json', $req, $runtime));
    }

    /**
     * @param QueryHospitalRoleUserInfoRequest $request
     *
     * @return QueryHospitalRoleUserInfoResponse
     */
    public function queryHospitalRoleUserInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHospitalRoleUserInfoHeaders([]);

        return $this->queryHospitalRoleUserInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryHospitalRoleUserInfoRequest $request
     * @param QueryHospitalRoleUserInfoHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryHospitalRoleUserInfoResponse
     */
    public function queryHospitalRoleUserInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryHospitalRoleUserInfoResponse::fromMap($this->doROARequest('QueryHospitalRoleUserInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/roles/userInfos', 'json', $req, $runtime));
    }

    /**
     * @return QueryHospitalRolesResponse
     */
    public function queryHospitalRoles()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHospitalRolesHeaders([]);

        return $this->queryHospitalRolesWithOptions($headers, $runtime);
    }

    /**
     * @param QueryHospitalRolesHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryHospitalRolesResponse
     */
    public function queryHospitalRolesWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryHospitalRolesResponse::fromMap($this->doROARequest('QueryHospitalRoles', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/roles', 'json', $req, $runtime));
    }

    /**
     * @return QueryJobCodeDictionaryResponse
     */
    public function queryJobCodeDictionary()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryJobCodeDictionaryHeaders([]);

        return $this->queryJobCodeDictionaryWithOptions($headers, $runtime);
    }

    /**
     * @param QueryJobCodeDictionaryHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return QueryJobCodeDictionaryResponse
     */
    public function queryJobCodeDictionaryWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryJobCodeDictionaryResponse::fromMap($this->doROARequest('QueryJobCodeDictionary', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/jobCodes', 'json', $req, $runtime));
    }

    /**
     * @return QueryJobStatusCodeDictionaryResponse
     */
    public function queryJobStatusCodeDictionary()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryJobStatusCodeDictionaryHeaders([]);

        return $this->queryJobStatusCodeDictionaryWithOptions($headers, $runtime);
    }

    /**
     * @param QueryJobStatusCodeDictionaryHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryJobStatusCodeDictionaryResponse
     */
    public function queryJobStatusCodeDictionaryWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryJobStatusCodeDictionaryResponse::fromMap($this->doROARequest('QueryJobStatusCodeDictionary', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/jobStatusCodes', 'json', $req, $runtime));
    }

    /**
     * @return QueryMedicalEventsResponse
     */
    public function queryMedicalEvents()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMedicalEventsHeaders([]);

        return $this->queryMedicalEventsWithOptions($headers, $runtime);
    }

    /**
     * @param QueryMedicalEventsHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryMedicalEventsResponse
     */
    public function queryMedicalEventsWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryMedicalEventsResponse::fromMap($this->doROARequest('QueryMedicalEvents', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/events', 'json', $req, $runtime));
    }

    /**
     * @param QueryUserCredentialsRequest $request
     *
     * @return QueryUserCredentialsResponse
     */
    public function queryUserCredentials($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserCredentialsHeaders([]);

        return $this->queryUserCredentialsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryUserCredentialsRequest $request
     * @param QueryUserCredentialsHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryUserCredentialsResponse
     */
    public function queryUserCredentialsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return QueryUserCredentialsResponse::fromMap($this->doROARequest('QueryUserCredentials', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/medicals/users/credentials/query', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return QueryUserExtInfoResponse
     */
    public function queryUserExtInfo($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserExtInfoHeaders([]);

        return $this->queryUserExtInfoWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string                  $userId
     * @param QueryUserExtInfoHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QueryUserExtInfoResponse
     */
    public function queryUserExtInfoWithOptions($userId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryUserExtInfoResponse::fromMap($this->doROARequest('QueryUserExtInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/users/' . $userId . '/extInfos', 'json', $req, $runtime));
    }

    /**
     * @param QueryUserExtendValuesRequest $request
     *
     * @return QueryUserExtendValuesResponse
     */
    public function queryUserExtendValues($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserExtendValuesHeaders([]);

        return $this->queryUserExtendValuesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryUserExtendValuesRequest $request
     * @param QueryUserExtendValuesHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return QueryUserExtendValuesResponse
     */
    public function queryUserExtendValuesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userExtendKey)) {
            @$body['userExtendKey'] = $request->userExtendKey;
        }
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return QueryUserExtendValuesResponse::fromMap($this->doROARequest('QueryUserExtendValues', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/medicals/users/extends/query', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return QueryUserInfoResponse
     */
    public function queryUserInfo($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserInfoHeaders([]);

        return $this->queryUserInfoWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string               $userId
     * @param QueryUserInfoHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return QueryUserInfoResponse
     */
    public function queryUserInfoWithOptions($userId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryUserInfoResponse::fromMap($this->doROARequest('QueryUserInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/users/' . $userId . '', 'json', $req, $runtime));
    }

    /**
     * @return QueryUserProbCodeDictionaryResponse
     */
    public function queryUserProbCodeDictionary()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserProbCodeDictionaryHeaders([]);

        return $this->queryUserProbCodeDictionaryWithOptions($headers, $runtime);
    }

    /**
     * @param QueryUserProbCodeDictionaryHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return QueryUserProbCodeDictionaryResponse
     */
    public function queryUserProbCodeDictionaryWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryUserProbCodeDictionaryResponse::fromMap($this->doROARequest('QueryUserProbCodeDictionary', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/userProbCodes', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return QueryUserRolesResponse
     */
    public function queryUserRoles($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserRolesHeaders([]);

        return $this->queryUserRolesWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param QueryUserRolesHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryUserRolesResponse
     */
    public function queryUserRolesWithOptions($userId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryUserRolesResponse::fromMap($this->doROARequest('QueryUserRoles', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/users/' . $userId . '/roles', 'json', $req, $runtime));
    }

    /**
     * @param string                      $userId
     * @param SaveUserExtendValuesRequest $request
     *
     * @return SaveUserExtendValuesResponse
     */
    public function saveUserExtendValues($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveUserExtendValuesHeaders([]);

        return $this->saveUserExtendValuesWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $userId
     * @param SaveUserExtendValuesRequest $request
     * @param SaveUserExtendValuesHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return SaveUserExtendValuesResponse
     */
    public function saveUserExtendValuesWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $query  = [];
        if (!Utils::isUnset($request->userDisplayName)) {
            @$query['userDisplayName'] = $request->userDisplayName;
        }
        if (!Utils::isUnset($request->userExtendKey)) {
            @$query['userExtendKey'] = $request->userExtendKey;
        }
        if (!Utils::isUnset($request->userExtendValue)) {
            @$query['userExtendValue'] = $request->userExtendValue;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return SaveUserExtendValuesResponse::fromMap($this->doROARequest('SaveUserExtendValues', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/medicals/users/' . $userId . '/extends', 'json', $req, $runtime));
    }

    /**
     * @param string                      $userId
     * @param UpdateUserExtendInfoRequest $request
     *
     * @return UpdateUserExtendInfoResponse
     */
    public function updateUserExtendInfo($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateUserExtendInfoHeaders([]);

        return $this->updateUserExtendInfoWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $userId
     * @param UpdateUserExtendInfoRequest $request
     * @param UpdateUserExtendInfoHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return UpdateUserExtendInfoResponse
     */
    public function updateUserExtendInfoWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->comments)) {
            @$body['comments'] = $request->comments;
        }
        if (!Utils::isUnset($request->jobCode)) {
            @$body['jobCode'] = $request->jobCode;
        }
        if (!Utils::isUnset($request->jobStatusCode)) {
            @$body['jobStatusCode'] = $request->jobStatusCode;
        }
        if (!Utils::isUnset($request->userProbCode)) {
            @$body['userProbCode'] = $request->userProbCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateUserExtendInfoResponse::fromMap($this->doROARequest('UpdateUserExtendInfo', 'industry_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/industry/medicals/users/' . $userId . '/extInfos', 'none', $req, $runtime));
    }
}
