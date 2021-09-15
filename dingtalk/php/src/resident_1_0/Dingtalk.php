<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentDepartmentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentDepartmentRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentDepartmentResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\DeleteResidentDepartmentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\DeleteResidentDepartmentRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\DeleteResidentDepartmentResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\RemoveResidentUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\RemoveResidentUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\RemoveResidentUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResideceGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResideceGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResideceGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentUserResponse;
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
     * @param UpdateResideceGroupRequest $request
     *
     * @return UpdateResideceGroupResponse
     */
    public function updateResideceGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateResideceGroupHeaders([]);

        return $this->updateResideceGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateResideceGroupRequest $request
     * @param UpdateResideceGroupHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return UpdateResideceGroupResponse
     */
    public function updateResideceGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->managerUserId)) {
            @$query['managerUserId'] = $request->managerUserId;
        }
        if (!Utils::isUnset($request->name)) {
            @$query['name'] = $request->name;
        }
        if (!Utils::isUnset($request->departmentId)) {
            @$query['departmentId'] = $request->departmentId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return UpdateResideceGroupResponse::fromMap($this->doROARequest('UpdateResideceGroup', 'resident_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/resident/departments/updateResideceGroup', 'json', $req, $runtime));
    }

    /**
     * @param DeleteResidentDepartmentRequest $request
     *
     * @return DeleteResidentDepartmentResponse
     */
    public function deleteResidentDepartment($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteResidentDepartmentHeaders([]);

        return $this->deleteResidentDepartmentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteResidentDepartmentRequest $request
     * @param DeleteResidentDepartmentHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return DeleteResidentDepartmentResponse
     */
    public function deleteResidentDepartmentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->departmentId)) {
            @$query['departmentId'] = $request->departmentId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteResidentDepartmentResponse::fromMap($this->doROARequest('DeleteResidentDepartment', 'resident_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/resident/departments', 'json', $req, $runtime));
    }

    /**
     * @param AddResidentUsersRequest $request
     *
     * @return AddResidentUsersResponse
     */
    public function addResidentUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddResidentUsersHeaders([]);

        return $this->addResidentUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddResidentUsersRequest $request
     * @param AddResidentUsersHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return AddResidentUsersResponse
     */
    public function addResidentUsersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->address)) {
            @$query['address'] = $request->address;
        }
        if (!Utils::isUnset($request->isLeaseholder)) {
            @$query['isLeaseholder'] = $request->isLeaseholder;
        }
        if (!Utils::isUnset($request->name)) {
            @$query['name'] = $request->name;
        }
        if (!Utils::isUnset($request->mobile)) {
            @$query['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->departmentId)) {
            @$query['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->extField)) {
            @$query['extField'] = $request->extField;
        }
        if (!Utils::isUnset($request->relateType)) {
            @$query['relateType'] = $request->relateType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return AddResidentUsersResponse::fromMap($this->doROARequest('AddResidentUsers', 'resident_1.0', 'HTTP', 'POST', 'AK', '/v1.0/resident/users', 'json', $req, $runtime));
    }

    /**
     * @param AddResidentDepartmentRequest $request
     *
     * @return AddResidentDepartmentResponse
     */
    public function addResidentDepartment($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddResidentDepartmentHeaders([]);

        return $this->addResidentDepartmentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddResidentDepartmentRequest $request
     * @param AddResidentDepartmentHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return AddResidentDepartmentResponse
     */
    public function addResidentDepartmentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->isResidenceGroup)) {
            @$query['isResidenceGroup'] = $request->isResidenceGroup;
        }
        if (!Utils::isUnset($request->name)) {
            @$query['name'] = $request->name;
        }
        if (!Utils::isUnset($request->parentDepartmentId)) {
            @$query['parentDepartmentId'] = $request->parentDepartmentId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return AddResidentDepartmentResponse::fromMap($this->doROARequest('AddResidentDepartment', 'resident_1.0', 'HTTP', 'POST', 'AK', '/v1.0/resident/departments', 'json', $req, $runtime));
    }

    /**
     * @param RemoveResidentUserRequest $request
     *
     * @return RemoveResidentUserResponse
     */
    public function removeResidentUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveResidentUserHeaders([]);

        return $this->removeResidentUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RemoveResidentUserRequest $request
     * @param RemoveResidentUserHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return RemoveResidentUserResponse
     */
    public function removeResidentUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->departmentId)) {
            @$query['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return RemoveResidentUserResponse::fromMap($this->doROARequest('RemoveResidentUser', 'resident_1.0', 'HTTP', 'POST', 'AK', '/v1.0/resident/users/remove', 'json', $req, $runtime));
    }

    /**
     * @param UpdateResidenceRequest $request
     *
     * @return UpdateResidenceResponse
     */
    public function updateResidence($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateResidenceHeaders([]);

        return $this->updateResidenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateResidenceRequest $request
     * @param UpdateResidenceHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return UpdateResidenceResponse
     */
    public function updateResidenceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->managerUserId)) {
            @$query['managerUserId'] = $request->managerUserId;
        }
        if (!Utils::isUnset($request->name)) {
            @$query['name'] = $request->name;
        }
        if (!Utils::isUnset($request->departmentId)) {
            @$query['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->grid)) {
            @$query['grid'] = $request->grid;
        }
        if (!Utils::isUnset($request->homeTel)) {
            @$query['homeTel'] = $request->homeTel;
        }
        if (!Utils::isUnset($request->destitute)) {
            @$query['destitute'] = $request->destitute;
        }
        if (!Utils::isUnset($request->parentDepartmentId)) {
            @$query['parentDepartmentId'] = $request->parentDepartmentId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return UpdateResidenceResponse::fromMap($this->doROARequest('UpdateResidence', 'resident_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/resident/departments/updateResidece', 'json', $req, $runtime));
    }

    /**
     * @param UpdateResidentUserRequest $request
     *
     * @return UpdateResidentUserResponse
     */
    public function updateResidentUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateResidentUserHeaders([]);

        return $this->updateResidentUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateResidentUserRequest $request
     * @param UpdateResidentUserHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return UpdateResidentUserResponse
     */
    public function updateResidentUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->address)) {
            @$query['address'] = $request->address;
        }
        if (!Utils::isUnset($request->isRetainOldDept)) {
            @$query['isRetainOldDept'] = $request->isRetainOldDept;
        }
        if (!Utils::isUnset($request->name)) {
            @$query['name'] = $request->name;
        }
        if (!Utils::isUnset($request->mobile)) {
            @$query['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->departmentId)) {
            @$query['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->extField)) {
            @$query['extField'] = $request->extField;
        }
        if (!Utils::isUnset($request->relateType)) {
            @$query['relateType'] = $request->relateType;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->oldDepartmentId)) {
            @$query['oldDepartmentId'] = $request->oldDepartmentId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return UpdateResidentUserResponse::fromMap($this->doROARequest('UpdateResidentUser', 'resident_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/resident/users', 'json', $req, $runtime));
    }
}
