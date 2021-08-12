<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesAddHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesAddRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesAddResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesRemoveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesRemoveRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesRemoveResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckClosingAccountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckClosingAccountRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckClosingAccountResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckWritePermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckWritePermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckWritePermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClosingAccountsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClosingAccountsRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClosingAccountsResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetUserHolidaysHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetUserHolidaysRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetUserHolidaysResponse;
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
     * @param CreateApproveRequest $request
     *
     * @return CreateApproveResponse
     */
    public function createApprove($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateApproveHeaders([]);

        return $this->createApproveWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateApproveRequest $request
     * @param CreateApproveHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return CreateApproveResponse
     */
    public function createApproveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userid)) {
            @$body['userid'] = $request->userid;
        }
        if (!Utils::isUnset($request->tagName)) {
            @$body['tagName'] = $request->tagName;
        }
        if (!Utils::isUnset($request->subType)) {
            @$body['subType'] = $request->subType;
        }
        if (!Utils::isUnset($request->punchParam)) {
            @$body['punchParam'] = $request->punchParam;
        }
        if (!Utils::isUnset($request->approveId)) {
            @$body['approveId'] = $request->approveId;
        }
        if (!Utils::isUnset($request->opUserid)) {
            @$body['opUserid'] = $request->opUserid;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateApproveResponse::fromMap($this->doROARequest('CreateApprove', 'attendance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/attendance/approves', 'json', $req, $runtime));
    }

    /**
     * @param CheckClosingAccountRequest $request
     *
     * @return CheckClosingAccountResponse
     */
    public function checkClosingAccount($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckClosingAccountHeaders([]);

        return $this->checkClosingAccountWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CheckClosingAccountRequest $request
     * @param CheckClosingAccountHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return CheckClosingAccountResponse
     */
    public function checkClosingAccountWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
        }
        if (!Utils::isUnset($request->userTimeRange)) {
            @$body['userTimeRange'] = $request->userTimeRange;
        }
        if (!Utils::isUnset($request->bizCode)) {
            @$body['bizCode'] = $request->bizCode;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CheckClosingAccountResponse::fromMap($this->doROARequest('CheckClosingAccount', 'attendance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/attendance/closingAccounts/status/query', 'json', $req, $runtime));
    }

    /**
     * @param GetUserHolidaysRequest $request
     *
     * @return GetUserHolidaysResponse
     */
    public function getUserHolidays($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserHolidaysHeaders([]);

        return $this->getUserHolidaysWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetUserHolidaysRequest $request
     * @param GetUserHolidaysHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetUserHolidaysResponse
     */
    public function getUserHolidaysWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
        }
        if (!Utils::isUnset($request->workDateFrom)) {
            @$body['workDateFrom'] = $request->workDateFrom;
        }
        if (!Utils::isUnset($request->workDateTo)) {
            @$body['workDateTo'] = $request->workDateTo;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetUserHolidaysResponse::fromMap($this->doROARequest('GetUserHolidays', 'attendance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/attendance/holidays', 'json', $req, $runtime));
    }

    /**
     * @param AttendanceBleDevicesQueryRequest $request
     *
     * @return AttendanceBleDevicesQueryResponse
     */
    public function attendanceBleDevicesQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AttendanceBleDevicesQueryHeaders([]);

        return $this->attendanceBleDevicesQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AttendanceBleDevicesQueryRequest $request
     * @param AttendanceBleDevicesQueryHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return AttendanceBleDevicesQueryResponse
     */
    public function attendanceBleDevicesQueryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->groupKey)) {
            @$body['groupKey'] = $request->groupKey;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AttendanceBleDevicesQueryResponse::fromMap($this->doROARequestWithForm('AttendanceBleDevicesQuery', 'attendance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/attendance/group/bledevices/query', 'json', $req, $runtime));
    }

    /**
     * @param AttendanceBleDevicesAddRequest $request
     *
     * @return AttendanceBleDevicesAddResponse
     */
    public function attendanceBleDevicesAdd($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AttendanceBleDevicesAddHeaders([]);

        return $this->attendanceBleDevicesAddWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AttendanceBleDevicesAddRequest $request
     * @param AttendanceBleDevicesAddHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return AttendanceBleDevicesAddResponse
     */
    public function attendanceBleDevicesAddWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->groupKey)) {
            @$body['groupKey'] = $request->groupKey;
        }
        if (!Utils::isUnset($request->deviceIdList)) {
            @$body['deviceIdList'] = $request->deviceIdList;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AttendanceBleDevicesAddResponse::fromMap($this->doROARequest('AttendanceBleDevicesAdd', 'attendance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/attendance/group/bledevices', 'json', $req, $runtime));
    }

    /**
     * @param AttendanceBleDevicesRemoveRequest $request
     *
     * @return AttendanceBleDevicesRemoveResponse
     */
    public function attendanceBleDevicesRemove($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AttendanceBleDevicesRemoveHeaders([]);

        return $this->attendanceBleDevicesRemoveWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AttendanceBleDevicesRemoveRequest $request
     * @param AttendanceBleDevicesRemoveHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return AttendanceBleDevicesRemoveResponse
     */
    public function attendanceBleDevicesRemoveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->groupKey)) {
            @$body['groupKey'] = $request->groupKey;
        }
        if (!Utils::isUnset($request->deviceIdList)) {
            @$body['deviceIdList'] = $request->deviceIdList;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AttendanceBleDevicesRemoveResponse::fromMap($this->doROARequest('AttendanceBleDevicesRemove', 'attendance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/attendance/group/bledevices/remove', 'json', $req, $runtime));
    }

    /**
     * @param CheckWritePermissionRequest $request
     *
     * @return CheckWritePermissionResponse
     */
    public function checkWritePermission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckWritePermissionHeaders([]);

        return $this->checkWritePermissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CheckWritePermissionRequest $request
     * @param CheckWritePermissionHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return CheckWritePermissionResponse
     */
    public function checkWritePermissionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            @$query['corpId'] = $request->corpId;
        }
        $body = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->category)) {
            @$body['category'] = $request->category;
        }
        if (!Utils::isUnset($request->resourceKey)) {
            @$body['resourceKey'] = $request->resourceKey;
        }
        if (!Utils::isUnset($request->entityIds)) {
            @$body['entityIds'] = $request->entityIds;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CheckWritePermissionResponse::fromMap($this->doROARequest('CheckWritePermission', 'attendance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/attendance/writePermissions/query', 'json', $req, $runtime));
    }

    /**
     * @param GetClosingAccountsRequest $request
     *
     * @return GetClosingAccountsResponse
     */
    public function getClosingAccounts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetClosingAccountsHeaders([]);

        return $this->getClosingAccountsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetClosingAccountsRequest $request
     * @param GetClosingAccountsHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetClosingAccountsResponse
     */
    public function getClosingAccountsWithOptions($request, $headers, $runtime)
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
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetClosingAccountsResponse::fromMap($this->doROARequest('GetClosingAccounts', 'attendance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/attendance/closingAccounts/rules/query', 'json', $req, $runtime));
    }
}
