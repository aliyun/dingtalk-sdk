<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AddLeaveTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AddLeaveTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AddLeaveTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesAddHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesAddRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesAddResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesRemoveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesRemoveRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesRemoveResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\BatchBossCheckHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\BatchBossCheckRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\BatchBossCheckResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckClosingAccountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckClosingAccountRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckClosingAccountResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckWritePermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckWritePermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckWritePermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\DeleteWaterMarkTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\DeleteWaterMarkTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\DeleteWaterMarkTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\DingTalkSecurityCheckHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\DingTalkSecurityCheckRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\DingTalkSecurityCheckResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetAdjustmentsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetAdjustmentsRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetAdjustmentsResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetATManageScopeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetATManageScopeRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetATManageScopeResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetCheckinRecordByUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetCheckinRecordByUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetCheckinRecordByUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetCheckInSchemaTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetCheckInSchemaTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetCheckInSchemaTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClosingAccountsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClosingAccountsRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClosingAccountsResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetLeaveRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetLeaveRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetLeaveRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetLeaveTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetLeaveTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetLeaveTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetMachineHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetMachineResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetMachineUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetMachineUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetMachineUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOvertimeSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOvertimeSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOvertimeSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetSimpleOvertimeSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetSimpleOvertimeSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetSimpleOvertimeSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetUserHolidaysHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetUserHolidaysRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetUserHolidaysResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupUpdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupUpdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupUpdateResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\InitAndGetLeaveALlocationQuotasHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\InitAndGetLeaveALlocationQuotasRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\InitAndGetLeaveALlocationQuotasResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ListApproveByUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ListApproveByUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ListApproveByUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ModifyWaterMarkTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ModifyWaterMarkTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ModifyWaterMarkTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ProcessApproveCreateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ProcessApproveCreateRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ProcessApproveCreateResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\RetainLeaveTypesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\RetainLeaveTypesRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\RetainLeaveTypesResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ReverseTrialAdvancedLeaveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ReverseTrialAdvancedLeaveRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ReverseTrialAdvancedLeaveResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SaveCustomWaterMarkTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SaveCustomWaterMarkTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SaveCustomWaterMarkTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SyncScheduleInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SyncScheduleInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SyncScheduleInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\UpdateLeaveTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\UpdateLeaveTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\UpdateLeaveTypeResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client as DarabonbaGatewayDingTalkClient;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    protected $_client;

    public function __construct($config)
    {
        parent::__construct($config);
        $this->_client       = new DarabonbaGatewayDingTalkClient();
        $this->_spi          = $this->_client;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param AddLeaveTypeRequest $request
     * @param AddLeaveTypeHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return AddLeaveTypeResponse
     */
    public function addLeaveTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->extras)) {
            $body['extras'] = $request->extras;
        }
        if (!Utils::isUnset($request->hoursInPerDay)) {
            $body['hoursInPerDay'] = $request->hoursInPerDay;
        }
        if (!Utils::isUnset($request->leaveCertificate)) {
            $body['leaveCertificate'] = $request->leaveCertificate;
        }
        if (!Utils::isUnset($request->leaveName)) {
            $body['leaveName'] = $request->leaveName;
        }
        if (!Utils::isUnset($request->leaveViewUnit)) {
            $body['leaveViewUnit'] = $request->leaveViewUnit;
        }
        if (!Utils::isUnset($request->naturalDayLeave)) {
            $body['naturalDayLeave'] = $request->naturalDayLeave;
        }
        if (!Utils::isUnset($request->submitTimeRule)) {
            $body['submitTimeRule'] = $request->submitTimeRule;
        }
        if (!Utils::isUnset($request->visibilityRules)) {
            $body['visibilityRules'] = $request->visibilityRules;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AddLeaveType',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/leaves/types',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddLeaveTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddLeaveTypeRequest $request
     *
     * @return AddLeaveTypeResponse
     */
    public function addLeaveType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddLeaveTypeHeaders([]);

        return $this->addLeaveTypeWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->deviceIdList)) {
            $body['deviceIdList'] = $request->deviceIdList;
        }
        if (!Utils::isUnset($request->groupKey)) {
            $body['groupKey'] = $request->groupKey;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AttendanceBleDevicesAdd',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/group/bledevices',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return AttendanceBleDevicesAddResponse::fromMap($this->execute($params, $req, $runtime));
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
        if (!Utils::isUnset($request->groupKey)) {
            $body['groupKey'] = $request->groupKey;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AttendanceBleDevicesQuery',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/group/bledevices/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return AttendanceBleDevicesQueryResponse::fromMap($this->execute($params, $req, $runtime));
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
        if (!Utils::isUnset($request->deviceIdList)) {
            $body['deviceIdList'] = $request->deviceIdList;
        }
        if (!Utils::isUnset($request->groupKey)) {
            $body['groupKey'] = $request->groupKey;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AttendanceBleDevicesRemove',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/group/bledevices/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return AttendanceBleDevicesRemoveResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param BatchBossCheckRequest $request
     * @param BatchBossCheckHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return BatchBossCheckResponse
     */
    public function batchBossCheckWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->models)) {
            $body['models'] = $request->models;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BatchBossCheck',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/results/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchBossCheckResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchBossCheckRequest $request
     *
     * @return BatchBossCheckResponse
     */
    public function batchBossCheck($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchBossCheckHeaders([]);

        return $this->batchBossCheckWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
        }
        if (!Utils::isUnset($request->userTimeRange)) {
            $body['userTimeRange'] = $request->userTimeRange;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CheckClosingAccount',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/closingAccounts/status/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CheckClosingAccountResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param CheckWritePermissionRequest $request
     * @param CheckWritePermissionHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return CheckWritePermissionResponse
     */
    public function checkWritePermissionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->category)) {
            $body['category'] = $request->category;
        }
        if (!Utils::isUnset($request->entityIds)) {
            $body['entityIds'] = $request->entityIds;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->resourceKey)) {
            $body['resourceKey'] = $request->resourceKey;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CheckWritePermission',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/writePermissions/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CheckWritePermissionResponse::fromMap($this->execute($params, $req, $runtime));
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
        if (!Utils::isUnset($request->approveId)) {
            $body['approveId'] = $request->approveId;
        }
        if (!Utils::isUnset($request->opUserid)) {
            $body['opUserid'] = $request->opUserid;
        }
        if (!Utils::isUnset($request->punchParam)) {
            $body['punchParam'] = $request->punchParam;
        }
        if (!Utils::isUnset($request->subType)) {
            $body['subType'] = $request->subType;
        }
        if (!Utils::isUnset($request->tagName)) {
            $body['tagName'] = $request->tagName;
        }
        if (!Utils::isUnset($request->userid)) {
            $body['userid'] = $request->userid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateApprove',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/approves',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateApproveResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param DeleteWaterMarkTemplateRequest $request
     * @param DeleteWaterMarkTemplateHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return DeleteWaterMarkTemplateResponse
     */
    public function deleteWaterMarkTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->formCode)) {
            $query['formCode'] = $request->formCode;
        }
        if (!Utils::isUnset($request->formContent)) {
            $query['formContent'] = $request->formContent;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $query['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->systemTemplate)) {
            $query['systemTemplate'] = $request->systemTemplate;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeleteWaterMarkTemplate',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/watermarks/templates',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteWaterMarkTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteWaterMarkTemplateRequest $request
     *
     * @return DeleteWaterMarkTemplateResponse
     */
    public function deleteWaterMarkTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteWaterMarkTemplateHeaders([]);

        return $this->deleteWaterMarkTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DingTalkSecurityCheckRequest $request
     * @param DingTalkSecurityCheckHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return DingTalkSecurityCheckResponse
     */
    public function dingTalkSecurityCheckWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->clientVer)) {
            $body['clientVer'] = $request->clientVer;
        }
        if (!Utils::isUnset($request->platform)) {
            $body['platform'] = $request->platform;
        }
        if (!Utils::isUnset($request->platformVer)) {
            $body['platformVer'] = $request->platformVer;
        }
        if (!Utils::isUnset($request->sec)) {
            $body['sec'] = $request->sec;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DingTalkSecurityCheck',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/securities/check',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DingTalkSecurityCheckResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DingTalkSecurityCheckRequest $request
     *
     * @return DingTalkSecurityCheckResponse
     */
    public function dingTalkSecurityCheck($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DingTalkSecurityCheckHeaders([]);

        return $this->dingTalkSecurityCheckWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetATManageScopeRequest $request
     * @param GetATManageScopeHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetATManageScopeResponse
     */
    public function getATManageScopeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetATManageScope',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/manageScopes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetATManageScopeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetATManageScopeRequest $request
     *
     * @return GetATManageScopeResponse
     */
    public function getATManageScope($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetATManageScopeHeaders([]);

        return $this->getATManageScopeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetAdjustmentsRequest $request
     * @param GetAdjustmentsHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetAdjustmentsResponse
     */
    public function getAdjustmentsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetAdjustments',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/adjustments',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAdjustmentsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetAdjustmentsRequest $request
     *
     * @return GetAdjustmentsResponse
     */
    public function getAdjustments($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAdjustmentsHeaders([]);

        return $this->getAdjustmentsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCheckInSchemaTemplateRequest $request
     * @param GetCheckInSchemaTemplateHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return GetCheckInSchemaTemplateResponse
     */
    public function getCheckInSchemaTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $query['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->sceneCode)) {
            $query['sceneCode'] = $request->sceneCode;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetCheckInSchemaTemplate',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/watermarks/templates',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCheckInSchemaTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetCheckInSchemaTemplateRequest $request
     *
     * @return GetCheckInSchemaTemplateResponse
     */
    public function getCheckInSchemaTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCheckInSchemaTemplateHeaders([]);

        return $this->getCheckInSchemaTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCheckinRecordByUserRequest $request
     * @param GetCheckinRecordByUserHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetCheckinRecordByUserResponse
     */
    public function getCheckinRecordByUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->userIdList)) {
            $body['userIdList'] = $request->userIdList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetCheckinRecordByUser',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/checkin/records/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCheckinRecordByUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetCheckinRecordByUserRequest $request
     *
     * @return GetCheckinRecordByUserResponse
     */
    public function getCheckinRecordByUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCheckinRecordByUserHeaders([]);

        return $this->getCheckinRecordByUserWithOptions($request, $headers, $runtime);
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
            $body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetClosingAccounts',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/closingAccounts/rules/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetClosingAccountsResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param GetLeaveRecordsRequest $request
     * @param GetLeaveRecordsHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetLeaveRecordsResponse
     */
    public function getLeaveRecordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->leaveCode)) {
            $body['leaveCode'] = $request->leaveCode;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetLeaveRecords',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/vacations/records/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetLeaveRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetLeaveRecordsRequest $request
     *
     * @return GetLeaveRecordsResponse
     */
    public function getLeaveRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetLeaveRecordsHeaders([]);

        return $this->getLeaveRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetLeaveTypeRequest $request
     * @param GetLeaveTypeHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetLeaveTypeResponse
     */
    public function getLeaveTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->vacationSource)) {
            $query['vacationSource'] = $request->vacationSource;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetLeaveType',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/leaves/types',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetLeaveTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetLeaveTypeRequest $request
     *
     * @return GetLeaveTypeResponse
     */
    public function getLeaveType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetLeaveTypeHeaders([]);

        return $this->getLeaveTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string            $devId
     * @param GetMachineHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return GetMachineResponse
     */
    public function getMachineWithOptions($devId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetMachine',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/machines/' . $devId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetMachineResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $devId
     *
     * @return GetMachineResponse
     */
    public function getMachine($devId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMachineHeaders([]);

        return $this->getMachineWithOptions($devId, $headers, $runtime);
    }

    /**
     * @param string                $devId
     * @param GetMachineUserRequest $request
     * @param GetMachineUserHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetMachineUserResponse
     */
    public function getMachineUserWithOptions($devId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetMachineUser',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/machines/getUser/' . $devId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetMachineUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                $devId
     * @param GetMachineUserRequest $request
     *
     * @return GetMachineUserResponse
     */
    public function getMachineUser($devId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMachineUserHeaders([]);

        return $this->getMachineUserWithOptions($devId, $request, $headers, $runtime);
    }

    /**
     * @param GetOvertimeSettingRequest $request
     * @param GetOvertimeSettingHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetOvertimeSettingResponse
     */
    public function getOvertimeSettingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->overtimeSettingIds)) {
            $body['overtimeSettingIds'] = $request->overtimeSettingIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetOvertimeSetting',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/overtimeSettings/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOvertimeSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetOvertimeSettingRequest $request
     *
     * @return GetOvertimeSettingResponse
     */
    public function getOvertimeSetting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOvertimeSettingHeaders([]);

        return $this->getOvertimeSettingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetShiftRequest $request
     * @param GetShiftHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return GetShiftResponse
     */
    public function getShiftWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->shiftId)) {
            $query['shiftId'] = $request->shiftId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetShift',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/shifts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetShiftResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetShiftRequest $request
     *
     * @return GetShiftResponse
     */
    public function getShift($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetShiftHeaders([]);

        return $this->getShiftWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSimpleOvertimeSettingRequest $request
     * @param GetSimpleOvertimeSettingHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return GetSimpleOvertimeSettingResponse
     */
    public function getSimpleOvertimeSettingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetSimpleOvertimeSetting',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/overtimeSettings',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSimpleOvertimeSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetSimpleOvertimeSettingRequest $request
     *
     * @return GetSimpleOvertimeSettingResponse
     */
    public function getSimpleOvertimeSetting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSimpleOvertimeSettingHeaders([]);

        return $this->getSimpleOvertimeSettingWithOptions($request, $headers, $runtime);
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
            $body['userIds'] = $request->userIds;
        }
        if (!Utils::isUnset($request->workDateFrom)) {
            $body['workDateFrom'] = $request->workDateFrom;
        }
        if (!Utils::isUnset($request->workDateTo)) {
            $body['workDateTo'] = $request->workDateTo;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetUserHolidays',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/holidays',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetUserHolidaysResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param GroupAddRequest $request
     * @param GroupAddHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return GroupAddResponse
     */
    public function groupAddWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->adjustmentSettingId)) {
            $body['adjustmentSettingId'] = $request->adjustmentSettingId;
        }
        if (!Utils::isUnset($request->bleDeviceList)) {
            $body['bleDeviceList'] = $request->bleDeviceList;
        }
        if (!Utils::isUnset($request->checkNeedHealthyCode)) {
            $body['checkNeedHealthyCode'] = $request->checkNeedHealthyCode;
        }
        if (!Utils::isUnset($request->defaultClassId)) {
            $body['defaultClassId'] = $request->defaultClassId;
        }
        if (!Utils::isUnset($request->disableCheckWhenRest)) {
            $body['disableCheckWhenRest'] = $request->disableCheckWhenRest;
        }
        if (!Utils::isUnset($request->disableCheckWithoutSchedule)) {
            $body['disableCheckWithoutSchedule'] = $request->disableCheckWithoutSchedule;
        }
        if (!Utils::isUnset($request->enableCameraCheck)) {
            $body['enableCameraCheck'] = $request->enableCameraCheck;
        }
        if (!Utils::isUnset($request->enableEmpSelectClass)) {
            $body['enableEmpSelectClass'] = $request->enableEmpSelectClass;
        }
        if (!Utils::isUnset($request->enableFaceCheck)) {
            $body['enableFaceCheck'] = $request->enableFaceCheck;
        }
        if (!Utils::isUnset($request->enableFaceStrictMode)) {
            $body['enableFaceStrictMode'] = $request->enableFaceStrictMode;
        }
        if (!Utils::isUnset($request->enableNextDay)) {
            $body['enableNextDay'] = $request->enableNextDay;
        }
        if (!Utils::isUnset($request->enableOutSideUpdateNormalCheck)) {
            $body['enableOutSideUpdateNormalCheck'] = $request->enableOutSideUpdateNormalCheck;
        }
        if (!Utils::isUnset($request->enableOutsideApply)) {
            $body['enableOutsideApply'] = $request->enableOutsideApply;
        }
        if (!Utils::isUnset($request->enableOutsideCameraCheck)) {
            $body['enableOutsideCameraCheck'] = $request->enableOutsideCameraCheck;
        }
        if (!Utils::isUnset($request->enableOutsideCheck)) {
            $body['enableOutsideCheck'] = $request->enableOutsideCheck;
        }
        if (!Utils::isUnset($request->enableOutsideRemark)) {
            $body['enableOutsideRemark'] = $request->enableOutsideRemark;
        }
        if (!Utils::isUnset($request->enablePositionBle)) {
            $body['enablePositionBle'] = $request->enablePositionBle;
        }
        if (!Utils::isUnset($request->enableTrimDistance)) {
            $body['enableTrimDistance'] = $request->enableTrimDistance;
        }
        if (!Utils::isUnset($request->forbidHideOutSideAddress)) {
            $body['forbidHideOutSideAddress'] = $request->forbidHideOutSideAddress;
        }
        if (!Utils::isUnset($request->freeCheckSetting)) {
            $body['freeCheckSetting'] = $request->freeCheckSetting;
        }
        if (!Utils::isUnset($request->freeCheckTypeId)) {
            $body['freeCheckTypeId'] = $request->freeCheckTypeId;
        }
        if (!Utils::isUnset($request->freecheckDayStartMinOffset)) {
            $body['freecheckDayStartMinOffset'] = $request->freecheckDayStartMinOffset;
        }
        if (!Utils::isUnset($request->freecheckWorkDays)) {
            $body['freecheckWorkDays'] = $request->freecheckWorkDays;
        }
        if (!Utils::isUnset($request->groupId)) {
            $body['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->managerList)) {
            $body['managerList'] = $request->managerList;
        }
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->modifyMember)) {
            $body['modifyMember'] = $request->modifyMember;
        }
        if (!Utils::isUnset($request->offset)) {
            $body['offset'] = $request->offset;
        }
        if (!Utils::isUnset($request->openFaceCheck)) {
            $body['openFaceCheck'] = $request->openFaceCheck;
        }
        if (!Utils::isUnset($request->outsideCheckApproveModeId)) {
            $body['outsideCheckApproveModeId'] = $request->outsideCheckApproveModeId;
        }
        if (!Utils::isUnset($request->overtimeSettingId)) {
            $body['overtimeSettingId'] = $request->overtimeSettingId;
        }
        if (!Utils::isUnset($request->owner)) {
            $body['owner'] = $request->owner;
        }
        if (!Utils::isUnset($request->positions)) {
            $body['positions'] = $request->positions;
        }
        if (!Utils::isUnset($request->resourcePermissionMap)) {
            $body['resourcePermissionMap'] = $request->resourcePermissionMap;
        }
        if (!Utils::isUnset($request->shiftVOList)) {
            $body['shiftVOList'] = $request->shiftVOList;
        }
        if (!Utils::isUnset($request->skipHolidays)) {
            $body['skipHolidays'] = $request->skipHolidays;
        }
        if (!Utils::isUnset($request->specialDays)) {
            $body['specialDays'] = $request->specialDays;
        }
        if (!Utils::isUnset($request->trimDistance)) {
            $body['trimDistance'] = $request->trimDistance;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
        }
        if (!Utils::isUnset($request->wifis)) {
            $body['wifis'] = $request->wifis;
        }
        if (!Utils::isUnset($request->workdayClassList)) {
            $body['workdayClassList'] = $request->workdayClassList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GroupAdd',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/groups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GroupAddResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GroupAddRequest $request
     *
     * @return GroupAddResponse
     */
    public function groupAdd($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupAddHeaders([]);

        return $this->groupAddWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GroupUpdateRequest $request
     * @param GroupUpdateHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GroupUpdateResponse
     */
    public function groupUpdateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->adjustmentSettingId)) {
            $body['adjustmentSettingId'] = $request->adjustmentSettingId;
        }
        if (!Utils::isUnset($request->disableCheckWhenRest)) {
            $body['disableCheckWhenRest'] = $request->disableCheckWhenRest;
        }
        if (!Utils::isUnset($request->disableCheckWithoutSchedule)) {
            $body['disableCheckWithoutSchedule'] = $request->disableCheckWithoutSchedule;
        }
        if (!Utils::isUnset($request->enableCameraCheck)) {
            $body['enableCameraCheck'] = $request->enableCameraCheck;
        }
        if (!Utils::isUnset($request->enableEmpSelectClass)) {
            $body['enableEmpSelectClass'] = $request->enableEmpSelectClass;
        }
        if (!Utils::isUnset($request->enableFaceCheck)) {
            $body['enableFaceCheck'] = $request->enableFaceCheck;
        }
        if (!Utils::isUnset($request->enableFaceStrictMode)) {
            $body['enableFaceStrictMode'] = $request->enableFaceStrictMode;
        }
        if (!Utils::isUnset($request->enableOutSideUpdateNormalCheck)) {
            $body['enableOutSideUpdateNormalCheck'] = $request->enableOutSideUpdateNormalCheck;
        }
        if (!Utils::isUnset($request->enableOutsideApply)) {
            $body['enableOutsideApply'] = $request->enableOutsideApply;
        }
        if (!Utils::isUnset($request->enableOutsideCheck)) {
            $body['enableOutsideCheck'] = $request->enableOutsideCheck;
        }
        if (!Utils::isUnset($request->enableOutsideRemark)) {
            $body['enableOutsideRemark'] = $request->enableOutsideRemark;
        }
        if (!Utils::isUnset($request->enableTrimDistance)) {
            $body['enableTrimDistance'] = $request->enableTrimDistance;
        }
        if (!Utils::isUnset($request->forbidHideOutSideAddress)) {
            $body['forbidHideOutSideAddress'] = $request->forbidHideOutSideAddress;
        }
        if (!Utils::isUnset($request->freeCheckSetting)) {
            $body['freeCheckSetting'] = $request->freeCheckSetting;
        }
        if (!Utils::isUnset($request->freeCheckTypeId)) {
            $body['freeCheckTypeId'] = $request->freeCheckTypeId;
        }
        if (!Utils::isUnset($request->groupId)) {
            $body['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->managerList)) {
            $body['managerList'] = $request->managerList;
        }
        if (!Utils::isUnset($request->offset)) {
            $body['offset'] = $request->offset;
        }
        if (!Utils::isUnset($request->openFaceCheck)) {
            $body['openFaceCheck'] = $request->openFaceCheck;
        }
        if (!Utils::isUnset($request->outsideCheckApproveModeId)) {
            $body['outsideCheckApproveModeId'] = $request->outsideCheckApproveModeId;
        }
        if (!Utils::isUnset($request->overtimeSettingId)) {
            $body['overtimeSettingId'] = $request->overtimeSettingId;
        }
        if (!Utils::isUnset($request->owner)) {
            $body['owner'] = $request->owner;
        }
        if (!Utils::isUnset($request->positions)) {
            $body['positions'] = $request->positions;
        }
        if (!Utils::isUnset($request->resourcePermissionMap)) {
            $body['resourcePermissionMap'] = $request->resourcePermissionMap;
        }
        if (!Utils::isUnset($request->shiftVOList)) {
            $body['shiftVOList'] = $request->shiftVOList;
        }
        if (!Utils::isUnset($request->skipHolidays)) {
            $body['skipHolidays'] = $request->skipHolidays;
        }
        if (!Utils::isUnset($request->trimDistance)) {
            $body['trimDistance'] = $request->trimDistance;
        }
        if (!Utils::isUnset($request->workdayClassList)) {
            $body['workdayClassList'] = $request->workdayClassList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GroupUpdate',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/groups',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GroupUpdateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GroupUpdateRequest $request
     *
     * @return GroupUpdateResponse
     */
    public function groupUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupUpdateHeaders([]);

        return $this->groupUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param InitAndGetLeaveALlocationQuotasRequest $request
     * @param InitAndGetLeaveALlocationQuotasHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return InitAndGetLeaveALlocationQuotasResponse
     */
    public function initAndGetLeaveALlocationQuotasWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->leaveCode)) {
            $query['leaveCode'] = $request->leaveCode;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'InitAndGetLeaveALlocationQuotas',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/leaves/initializations/balances',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InitAndGetLeaveALlocationQuotasResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param InitAndGetLeaveALlocationQuotasRequest $request
     *
     * @return InitAndGetLeaveALlocationQuotasResponse
     */
    public function initAndGetLeaveALlocationQuotas($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InitAndGetLeaveALlocationQuotasHeaders([]);

        return $this->initAndGetLeaveALlocationQuotasWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListApproveByUsersRequest $request
     * @param ListApproveByUsersHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return ListApproveByUsersResponse
     */
    public function listApproveByUsersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizTypes)) {
            $body['bizTypes'] = $request->bizTypes;
        }
        if (!Utils::isUnset($request->fromDateTime)) {
            $body['fromDateTime'] = $request->fromDateTime;
        }
        if (!Utils::isUnset($request->toDateTime)) {
            $body['toDateTime'] = $request->toDateTime;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ListApproveByUsers',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/approvals/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListApproveByUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListApproveByUsersRequest $request
     *
     * @return ListApproveByUsersResponse
     */
    public function listApproveByUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListApproveByUsersHeaders([]);

        return $this->listApproveByUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ModifyWaterMarkTemplateRequest $request
     * @param ModifyWaterMarkTemplateHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return ModifyWaterMarkTemplateResponse
     */
    public function modifyWaterMarkTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $query['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->formCode)) {
            $body['formCode'] = $request->formCode;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->layoutDesignId)) {
            $body['layoutDesignId'] = $request->layoutDesignId;
        }
        if (!Utils::isUnset($request->schemaContent)) {
            $body['schemaContent'] = $request->schemaContent;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->waterMarkId)) {
            $body['waterMarkId'] = $request->waterMarkId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ModifyWaterMarkTemplate',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/watermarks/templates',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ModifyWaterMarkTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ModifyWaterMarkTemplateRequest $request
     *
     * @return ModifyWaterMarkTemplateResponse
     */
    public function modifyWaterMarkTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ModifyWaterMarkTemplateHeaders([]);

        return $this->modifyWaterMarkTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ProcessApproveCreateRequest $request
     * @param ProcessApproveCreateHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return ProcessApproveCreateResponse
     */
    public function processApproveCreateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->approveId)) {
            $body['approveId'] = $request->approveId;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->punchParam)) {
            $body['punchParam'] = $request->punchParam;
        }
        if (!Utils::isUnset($request->subType)) {
            $body['subType'] = $request->subType;
        }
        if (!Utils::isUnset($request->tagName)) {
            $body['tagName'] = $request->tagName;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ProcessApproveCreate',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/workflows/checkInForms',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ProcessApproveCreateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ProcessApproveCreateRequest $request
     *
     * @return ProcessApproveCreateResponse
     */
    public function processApproveCreate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ProcessApproveCreateHeaders([]);

        return $this->processApproveCreateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RetainLeaveTypesRequest $request
     * @param RetainLeaveTypesHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return RetainLeaveTypesResponse
     */
    public function retainLeaveTypesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->leaveCodes)) {
            $body['leaveCodes'] = $request->leaveCodes;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RetainLeaveTypes',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/vacations/types/change',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RetainLeaveTypesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RetainLeaveTypesRequest $request
     *
     * @return RetainLeaveTypesResponse
     */
    public function retainLeaveTypes($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RetainLeaveTypesHeaders([]);

        return $this->retainLeaveTypesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReverseTrialAdvancedLeaveRequest $request
     * @param ReverseTrialAdvancedLeaveHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return ReverseTrialAdvancedLeaveResponse
     */
    public function reverseTrialAdvancedLeaveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->servCode)) {
            $query['servCode'] = $request->servCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ReverseTrialAdvancedLeave',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/leaves/reverse',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ReverseTrialAdvancedLeaveResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ReverseTrialAdvancedLeaveRequest $request
     *
     * @return ReverseTrialAdvancedLeaveResponse
     */
    public function reverseTrialAdvancedLeave($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReverseTrialAdvancedLeaveHeaders([]);

        return $this->reverseTrialAdvancedLeaveWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SaveCustomWaterMarkTemplateRequest $request
     * @param SaveCustomWaterMarkTemplateHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return SaveCustomWaterMarkTemplateResponse
     */
    public function saveCustomWaterMarkTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $query['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->layoutDesignId)) {
            $body['layoutDesignId'] = $request->layoutDesignId;
        }
        if (!Utils::isUnset($request->sceneCode)) {
            $body['sceneCode'] = $request->sceneCode;
        }
        if (!Utils::isUnset($request->schemaContent)) {
            $body['schemaContent'] = $request->schemaContent;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SaveCustomWaterMarkTemplate',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/watermarks/templates',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveCustomWaterMarkTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SaveCustomWaterMarkTemplateRequest $request
     *
     * @return SaveCustomWaterMarkTemplateResponse
     */
    public function saveCustomWaterMarkTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveCustomWaterMarkTemplateHeaders([]);

        return $this->saveCustomWaterMarkTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncScheduleInfoRequest $request
     * @param SyncScheduleInfoHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return SyncScheduleInfoResponse
     */
    public function syncScheduleInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->scheduleInfos)) {
            $body['scheduleInfos'] = $request->scheduleInfos;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SyncScheduleInfo',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/schedules/additionalInfo',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return SyncScheduleInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SyncScheduleInfoRequest $request
     *
     * @return SyncScheduleInfoResponse
     */
    public function syncScheduleInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncScheduleInfoHeaders([]);

        return $this->syncScheduleInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateLeaveTypeRequest $request
     * @param UpdateLeaveTypeHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return UpdateLeaveTypeResponse
     */
    public function updateLeaveTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->extras)) {
            $body['extras'] = $request->extras;
        }
        if (!Utils::isUnset($request->hoursInPerDay)) {
            $body['hoursInPerDay'] = $request->hoursInPerDay;
        }
        if (!Utils::isUnset($request->leaveCertificate)) {
            $body['leaveCertificate'] = $request->leaveCertificate;
        }
        if (!Utils::isUnset($request->leaveCode)) {
            $body['leaveCode'] = $request->leaveCode;
        }
        if (!Utils::isUnset($request->leaveName)) {
            $body['leaveName'] = $request->leaveName;
        }
        if (!Utils::isUnset($request->leaveViewUnit)) {
            $body['leaveViewUnit'] = $request->leaveViewUnit;
        }
        if (!Utils::isUnset($request->naturalDayLeave)) {
            $body['naturalDayLeave'] = $request->naturalDayLeave;
        }
        if (!Utils::isUnset($request->submitTimeRule)) {
            $body['submitTimeRule'] = $request->submitTimeRule;
        }
        if (!Utils::isUnset($request->visibilityRules)) {
            $body['visibilityRules'] = $request->visibilityRules;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateLeaveType',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/leaves/types',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateLeaveTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateLeaveTypeRequest $request
     *
     * @return UpdateLeaveTypeResponse
     */
    public function updateLeaveType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateLeaveTypeHeaders([]);

        return $this->updateLeaveTypeWithOptions($request, $headers, $runtime);
    }
}
