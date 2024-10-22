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
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CalculateDurationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CalculateDurationRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CalculateDurationResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckClosingAccountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckClosingAccountRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckClosingAccountResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckWritePermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckWritePermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckWritePermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\DeleteLeaveRequestHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\DeleteLeaveRequestRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\DeleteLeaveRequestResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClassWithDeletedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClassWithDeletedResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClosingAccountsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClosingAccountsRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClosingAccountsResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetColumnvalsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetColumnvalsRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetColumnvalsResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOverdraftInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOverdraftInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOverdraftInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOvertimeSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOvertimeSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOvertimeSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetSimpleGroupsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetSimpleGroupsRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetSimpleGroupsResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ProcessApproveFinishHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ProcessApproveFinishRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ProcessApproveFinishResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ReduceQuotaWithLeaveRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ReduceQuotaWithLeaveRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ReduceQuotaWithLeaveRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\RetainLeaveTypesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\RetainLeaveTypesRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\RetainLeaveTypesResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ReverseTrialAdvancedLeaveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ReverseTrialAdvancedLeaveRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ReverseTrialAdvancedLeaveResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SalaryThirdDataIntegrationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SalaryThirdDataIntegrationRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SalaryThirdDataIntegrationResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SaveCustomWaterMarkTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SaveCustomWaterMarkTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SaveCustomWaterMarkTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ShiftAddHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ShiftAddRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ShiftAddResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SyncScheduleInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SyncScheduleInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SyncScheduleInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\UpdateLeaveTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\UpdateLeaveTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\UpdateLeaveTypeResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 添加假期规则
     *  *
     * @param AddLeaveTypeRequest $request AddLeaveTypeRequest
     * @param AddLeaveTypeHeaders $headers AddLeaveTypeHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return AddLeaveTypeResponse AddLeaveTypeResponse
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
        if (!Utils::isUnset($request->freedomLeave)) {
            $body['freedomLeave'] = $request->freedomLeave;
        }
        if (!Utils::isUnset($request->hoursInPerDay)) {
            $body['hoursInPerDay'] = $request->hoursInPerDay;
        }
        if (!Utils::isUnset($request->leaveCertificate)) {
            $body['leaveCertificate'] = $request->leaveCertificate;
        }
        if (!Utils::isUnset($request->leaveHourCeil)) {
            $body['leaveHourCeil'] = $request->leaveHourCeil;
        }
        if (!Utils::isUnset($request->leaveName)) {
            $body['leaveName'] = $request->leaveName;
        }
        if (!Utils::isUnset($request->leaveTimeCeil)) {
            $body['leaveTimeCeil'] = $request->leaveTimeCeil;
        }
        if (!Utils::isUnset($request->leaveTimeCeilMinUnit)) {
            $body['leaveTimeCeilMinUnit'] = $request->leaveTimeCeilMinUnit;
        }
        if (!Utils::isUnset($request->leaveViewUnit)) {
            $body['leaveViewUnit'] = $request->leaveViewUnit;
        }
        if (!Utils::isUnset($request->maxLeaveTime)) {
            $body['maxLeaveTime'] = $request->maxLeaveTime;
        }
        if (!Utils::isUnset($request->minLeaveHour)) {
            $body['minLeaveHour'] = $request->minLeaveHour;
        }
        if (!Utils::isUnset($request->naturalDayLeave)) {
            $body['naturalDayLeave'] = $request->naturalDayLeave;
        }
        if (!Utils::isUnset($request->paidLeave)) {
            $body['paidLeave'] = $request->paidLeave;
        }
        if (!Utils::isUnset($request->submitTimeRule)) {
            $body['submitTimeRule'] = $request->submitTimeRule;
        }
        if (!Utils::isUnset($request->visibilityRules)) {
            $body['visibilityRules'] = $request->visibilityRules;
        }
        if (!Utils::isUnset($request->whenCanLeave)) {
            $body['whenCanLeave'] = $request->whenCanLeave;
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
     * @summary 添加假期规则
     *  *
     * @param AddLeaveTypeRequest $request AddLeaveTypeRequest
     *
     * @return AddLeaveTypeResponse AddLeaveTypeResponse
     */
    public function addLeaveType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddLeaveTypeHeaders([]);

        return $this->addLeaveTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量给考勤组添加蓝牙设备
     *  *
     * @param AttendanceBleDevicesAddRequest $request AttendanceBleDevicesAddRequest
     * @param AttendanceBleDevicesAddHeaders $headers AttendanceBleDevicesAddHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return AttendanceBleDevicesAddResponse AttendanceBleDevicesAddResponse
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
     * @summary 批量给考勤组添加蓝牙设备
     *  *
     * @param AttendanceBleDevicesAddRequest $request AttendanceBleDevicesAddRequest
     *
     * @return AttendanceBleDevicesAddResponse AttendanceBleDevicesAddResponse
     */
    public function attendanceBleDevicesAdd($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AttendanceBleDevicesAddHeaders([]);

        return $this->attendanceBleDevicesAddWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询蓝牙设备
     *  *
     * @param AttendanceBleDevicesQueryRequest $request AttendanceBleDevicesQueryRequest
     * @param AttendanceBleDevicesQueryHeaders $headers AttendanceBleDevicesQueryHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return AttendanceBleDevicesQueryResponse AttendanceBleDevicesQueryResponse
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
     * @summary 批量查询蓝牙设备
     *  *
     * @param AttendanceBleDevicesQueryRequest $request AttendanceBleDevicesQueryRequest
     *
     * @return AttendanceBleDevicesQueryResponse AttendanceBleDevicesQueryResponse
     */
    public function attendanceBleDevicesQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AttendanceBleDevicesQueryHeaders([]);

        return $this->attendanceBleDevicesQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量删除考勤组的蓝牙设备
     *  *
     * @param AttendanceBleDevicesRemoveRequest $request AttendanceBleDevicesRemoveRequest
     * @param AttendanceBleDevicesRemoveHeaders $headers AttendanceBleDevicesRemoveHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return AttendanceBleDevicesRemoveResponse AttendanceBleDevicesRemoveResponse
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
     * @summary 批量删除考勤组的蓝牙设备
     *  *
     * @param AttendanceBleDevicesRemoveRequest $request AttendanceBleDevicesRemoveRequest
     *
     * @return AttendanceBleDevicesRemoveResponse AttendanceBleDevicesRemoveResponse
     */
    public function attendanceBleDevicesRemove($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AttendanceBleDevicesRemoveHeaders([]);

        return $this->attendanceBleDevicesRemoveWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量修改考勤结果
     *  *
     * @param BatchBossCheckRequest $request BatchBossCheckRequest
     * @param BatchBossCheckHeaders $headers BatchBossCheckHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchBossCheckResponse BatchBossCheckResponse
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
     * @summary 批量修改考勤结果
     *  *
     * @param BatchBossCheckRequest $request BatchBossCheckRequest
     *
     * @return BatchBossCheckResponse BatchBossCheckResponse
     */
    public function batchBossCheck($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchBossCheckHeaders([]);

        return $this->batchBossCheckWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 预计算时长
     *  *
     * @param CalculateDurationRequest $request CalculateDurationRequest
     * @param CalculateDurationHeaders $headers CalculateDurationHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CalculateDurationResponse CalculateDurationResponse
     */
    public function calculateDurationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->calculateModel)) {
            $body['calculateModel'] = $request->calculateModel;
        }
        if (!Utils::isUnset($request->durationUnit)) {
            $body['durationUnit'] = $request->durationUnit;
        }
        if (!Utils::isUnset($request->fromTime)) {
            $body['fromTime'] = $request->fromTime;
        }
        if (!Utils::isUnset($request->leaveCode)) {
            $body['leaveCode'] = $request->leaveCode;
        }
        if (!Utils::isUnset($request->toTime)) {
            $body['toTime'] = $request->toTime;
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
            'action'      => 'CalculateDuration',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/approvals/durations/calculate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CalculateDurationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 预计算时长
     *  *
     * @param CalculateDurationRequest $request CalculateDurationRequest
     *
     * @return CalculateDurationResponse CalculateDurationResponse
     */
    public function calculateDuration($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CalculateDurationHeaders([]);

        return $this->calculateDurationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 针对某些员工某段时间内封账状态的查询
     *  *
     * @param CheckClosingAccountRequest $request CheckClosingAccountRequest
     * @param CheckClosingAccountHeaders $headers CheckClosingAccountHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return CheckClosingAccountResponse CheckClosingAccountResponse
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
     * @summary 针对某些员工某段时间内封账状态的查询
     *  *
     * @param CheckClosingAccountRequest $request CheckClosingAccountRequest
     *
     * @return CheckClosingAccountResponse CheckClosingAccountResponse
     */
    public function checkClosingAccount($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckClosingAccountHeaders([]);

        return $this->checkClosingAccountWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 考勤资源的写权限查询
     *  *
     * @param CheckWritePermissionRequest $request CheckWritePermissionRequest
     * @param CheckWritePermissionHeaders $headers CheckWritePermissionHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return CheckWritePermissionResponse CheckWritePermissionResponse
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
     * @summary 考勤资源的写权限查询
     *  *
     * @param CheckWritePermissionRequest $request CheckWritePermissionRequest
     *
     * @return CheckWritePermissionResponse CheckWritePermissionResponse
     */
    public function checkWritePermission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckWritePermissionHeaders([]);

        return $this->checkWritePermissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建考勤打卡审批单
     *  *
     * @param CreateApproveRequest $request CreateApproveRequest
     * @param CreateApproveHeaders $headers CreateApproveHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateApproveResponse CreateApproveResponse
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
     * @summary 创建考勤打卡审批单
     *  *
     * @param CreateApproveRequest $request CreateApproveRequest
     *
     * @return CreateApproveResponse CreateApproveResponse
     */
    public function createApprove($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateApproveHeaders([]);

        return $this->createApproveWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 撤销请假
     *  *
     * @param string                    $unionId
     * @param DeleteLeaveRequestRequest $request DeleteLeaveRequestRequest
     * @param DeleteLeaveRequestHeaders $headers DeleteLeaveRequestHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteLeaveRequestResponse DeleteLeaveRequestResponse
     */
    public function deleteLeaveRequestWithOptions($unionId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->outerId)) {
            $body['outerId'] = $request->outerId;
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
            'action'      => 'DeleteLeaveRequest',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/users/' . $unionId . '/vacations/records/revoke',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteLeaveRequestResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 撤销请假
     *  *
     * @param string                    $unionId
     * @param DeleteLeaveRequestRequest $request DeleteLeaveRequestRequest
     *
     * @return DeleteLeaveRequestResponse DeleteLeaveRequestResponse
     */
    public function deleteLeaveRequest($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteLeaveRequestHeaders([]);

        return $this->deleteLeaveRequestWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除水印模板
     *  *
     * @param DeleteWaterMarkTemplateRequest $request DeleteWaterMarkTemplateRequest
     * @param DeleteWaterMarkTemplateHeaders $headers DeleteWaterMarkTemplateHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteWaterMarkTemplateResponse DeleteWaterMarkTemplateResponse
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
     * @summary 删除水印模板
     *  *
     * @param DeleteWaterMarkTemplateRequest $request DeleteWaterMarkTemplateRequest
     *
     * @return DeleteWaterMarkTemplateResponse DeleteWaterMarkTemplateResponse
     */
    public function deleteWaterMarkTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteWaterMarkTemplateHeaders([]);

        return $this->deleteWaterMarkTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 钉钉安全检查
     *  *
     * @param DingTalkSecurityCheckRequest $request DingTalkSecurityCheckRequest
     * @param DingTalkSecurityCheckHeaders $headers DingTalkSecurityCheckHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return DingTalkSecurityCheckResponse DingTalkSecurityCheckResponse
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
     * @summary 钉钉安全检查
     *  *
     * @param DingTalkSecurityCheckRequest $request DingTalkSecurityCheckRequest
     *
     * @return DingTalkSecurityCheckResponse DingTalkSecurityCheckResponse
     */
    public function dingTalkSecurityCheck($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DingTalkSecurityCheckHeaders([]);

        return $this->dingTalkSecurityCheckWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询管理员管理范围下的userid
     *  *
     * @param GetATManageScopeRequest $request GetATManageScopeRequest
     * @param GetATManageScopeHeaders $headers GetATManageScopeHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetATManageScopeResponse GetATManageScopeResponse
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
     * @summary 查询管理员管理范围下的userid
     *  *
     * @param GetATManageScopeRequest $request GetATManageScopeRequest
     *
     * @return GetATManageScopeResponse GetATManageScopeResponse
     */
    public function getATManageScope($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetATManageScopeHeaders([]);

        return $this->getATManageScopeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取补卡规则列表
     *  *
     * @param GetAdjustmentsRequest $request GetAdjustmentsRequest
     * @param GetAdjustmentsHeaders $headers GetAdjustmentsHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAdjustmentsResponse GetAdjustmentsResponse
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
     * @summary 获取补卡规则列表
     *  *
     * @param GetAdjustmentsRequest $request GetAdjustmentsRequest
     *
     * @return GetAdjustmentsResponse GetAdjustmentsResponse
     */
    public function getAdjustments($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAdjustmentsHeaders([]);

        return $this->getAdjustmentsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取水印打卡模板
     *  *
     * @param GetCheckInSchemaTemplateRequest $request GetCheckInSchemaTemplateRequest
     * @param GetCheckInSchemaTemplateHeaders $headers GetCheckInSchemaTemplateHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCheckInSchemaTemplateResponse GetCheckInSchemaTemplateResponse
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
     * @summary 获取水印打卡模板
     *  *
     * @param GetCheckInSchemaTemplateRequest $request GetCheckInSchemaTemplateRequest
     *
     * @return GetCheckInSchemaTemplateResponse GetCheckInSchemaTemplateResponse
     */
    public function getCheckInSchemaTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCheckInSchemaTemplateHeaders([]);

        return $this->getCheckInSchemaTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 调用本接口，获取用户签到记录。
     *  *
     * @param GetCheckinRecordByUserRequest $request GetCheckinRecordByUserRequest
     * @param GetCheckinRecordByUserHeaders $headers GetCheckinRecordByUserHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCheckinRecordByUserResponse GetCheckinRecordByUserResponse
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
     * @summary 调用本接口，获取用户签到记录。
     *  *
     * @param GetCheckinRecordByUserRequest $request GetCheckinRecordByUserRequest
     *
     * @return GetCheckinRecordByUserResponse GetCheckinRecordByUserResponse
     */
    public function getCheckinRecordByUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCheckinRecordByUserHeaders([]);

        return $this->getCheckinRecordByUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 班次查询（包含已删除班次）
     *  *
     * @param string                     $classId
     * @param GetClassWithDeletedHeaders $headers GetClassWithDeletedHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetClassWithDeletedResponse GetClassWithDeletedResponse
     */
    public function getClassWithDeletedWithOptions($classId, $headers, $runtime)
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
            'action'      => 'GetClassWithDeleted',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/classWithDeleted/' . $classId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetClassWithDeletedResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 班次查询（包含已删除班次）
     *  *
     * @param string $classId
     *
     * @return GetClassWithDeletedResponse GetClassWithDeletedResponse
     */
    public function getClassWithDeleted($classId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetClassWithDeletedHeaders([]);

        return $this->getClassWithDeletedWithOptions($classId, $headers, $runtime);
    }

    /**
     * @summary 查询指定用户的封账规则
     *  *
     * @param GetClosingAccountsRequest $request GetClosingAccountsRequest
     * @param GetClosingAccountsHeaders $headers GetClosingAccountsHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetClosingAccountsResponse GetClosingAccountsResponse
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
     * @summary 查询指定用户的封账规则
     *  *
     * @param GetClosingAccountsRequest $request GetClosingAccountsRequest
     *
     * @return GetClosingAccountsResponse GetClosingAccountsResponse
     */
    public function getClosingAccounts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetClosingAccountsHeaders([]);

        return $this->getClosingAccountsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取多个用户的智能考勤报表的列值
     *  *
     * @param GetColumnvalsRequest $request GetColumnvalsRequest
     * @param GetColumnvalsHeaders $headers GetColumnvalsHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetColumnvalsResponse GetColumnvalsResponse
     */
    public function getColumnvalsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->columnIdList)) {
            $body['columnIdList'] = $request->columnIdList;
        }
        if (!Utils::isUnset($request->fromDate)) {
            $body['fromDate'] = $request->fromDate;
        }
        if (!Utils::isUnset($request->toDate)) {
            $body['toDate'] = $request->toDate;
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
            'action'      => 'GetColumnvals',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/columnValues/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetColumnvalsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取多个用户的智能考勤报表的列值
     *  *
     * @param GetColumnvalsRequest $request GetColumnvalsRequest
     *
     * @return GetColumnvalsResponse GetColumnvalsResponse
     */
    public function getColumnvals($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetColumnvalsHeaders([]);

        return $this->getColumnvalsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询员工假期余额变更记录
     *  *
     * @param GetLeaveRecordsRequest $request GetLeaveRecordsRequest
     * @param GetLeaveRecordsHeaders $headers GetLeaveRecordsHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetLeaveRecordsResponse GetLeaveRecordsResponse
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
     * @summary 批量查询员工假期余额变更记录
     *  *
     * @param GetLeaveRecordsRequest $request GetLeaveRecordsRequest
     *
     * @return GetLeaveRecordsResponse GetLeaveRecordsResponse
     */
    public function getLeaveRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetLeaveRecordsHeaders([]);

        return $this->getLeaveRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询假期规则列表
     *  *
     * @param GetLeaveTypeRequest $request GetLeaveTypeRequest
     * @param GetLeaveTypeHeaders $headers GetLeaveTypeHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetLeaveTypeResponse GetLeaveTypeResponse
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
     * @summary 查询假期规则列表
     *  *
     * @param GetLeaveTypeRequest $request GetLeaveTypeRequest
     *
     * @return GetLeaveTypeResponse GetLeaveTypeResponse
     */
    public function getLeaveType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetLeaveTypeHeaders([]);

        return $this->getLeaveTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据设备id获取考勤机信息
     *  *
     * @param string            $devId
     * @param GetMachineHeaders $headers GetMachineHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetMachineResponse GetMachineResponse
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
     * @summary 根据设备id获取考勤机信息
     *  *
     * @param string $devId
     *
     * @return GetMachineResponse GetMachineResponse
     */
    public function getMachine($devId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMachineHeaders([]);

        return $this->getMachineWithOptions($devId, $headers, $runtime);
    }

    /**
     * @summary 根据设备id获取员工信息
     *  *
     * @param string                $devId
     * @param GetMachineUserRequest $request GetMachineUserRequest
     * @param GetMachineUserHeaders $headers GetMachineUserHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetMachineUserResponse GetMachineUserResponse
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
     * @summary 根据设备id获取员工信息
     *  *
     * @param string                $devId
     * @param GetMachineUserRequest $request GetMachineUserRequest
     *
     * @return GetMachineUserResponse GetMachineUserResponse
     */
    public function getMachineUser($devId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMachineUserHeaders([]);

        return $this->getMachineUserWithOptions($devId, $request, $headers, $runtime);
    }

    /**
     * @summary 假期透支信息查询
     *  *
     * @param GetOverdraftInfoRequest $request GetOverdraftInfoRequest
     * @param GetOverdraftInfoHeaders $headers GetOverdraftInfoHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOverdraftInfoResponse GetOverdraftInfoResponse
     */
    public function getOverdraftInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->leaveCode)) {
            $body['leaveCode'] = $request->leaveCode;
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
            'action'      => 'GetOverdraftInfo',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/vacations/overdraft/get',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOverdraftInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 假期透支信息查询
     *  *
     * @param GetOverdraftInfoRequest $request GetOverdraftInfoRequest
     *
     * @return GetOverdraftInfoResponse GetOverdraftInfoResponse
     */
    public function getOverdraftInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOverdraftInfoHeaders([]);

        return $this->getOverdraftInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量获取加班规则设置
     *  *
     * @param GetOvertimeSettingRequest $request GetOvertimeSettingRequest
     * @param GetOvertimeSettingHeaders $headers GetOvertimeSettingHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOvertimeSettingResponse GetOvertimeSettingResponse
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
     * @summary 批量获取加班规则设置
     *  *
     * @param GetOvertimeSettingRequest $request GetOvertimeSettingRequest
     *
     * @return GetOvertimeSettingResponse GetOvertimeSettingResponse
     */
    public function getOvertimeSetting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOvertimeSettingHeaders([]);

        return $this->getOvertimeSettingWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 班次详情
     *  *
     * @param GetShiftRequest $request GetShiftRequest
     * @param GetShiftHeaders $headers GetShiftHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetShiftResponse GetShiftResponse
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
     * @summary 班次详情
     *  *
     * @param GetShiftRequest $request GetShiftRequest
     *
     * @return GetShiftResponse GetShiftResponse
     */
    public function getShift($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetShiftHeaders([]);

        return $this->getShiftWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取考勤组列表详情
     *  *
     * @param GetSimpleGroupsRequest $request GetSimpleGroupsRequest
     * @param GetSimpleGroupsHeaders $headers GetSimpleGroupsHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSimpleGroupsResponse GetSimpleGroupsResponse
     */
    public function getSimpleGroupsWithOptions($request, $headers, $runtime)
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
            'action'      => 'GetSimpleGroups',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/groupDetails',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSimpleGroupsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取考勤组列表详情
     *  *
     * @param GetSimpleGroupsRequest $request GetSimpleGroupsRequest
     *
     * @return GetSimpleGroupsResponse GetSimpleGroupsResponse
     */
    public function getSimpleGroups($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSimpleGroupsHeaders([]);

        return $this->getSimpleGroupsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 加班规则列表
     *  *
     * @param GetSimpleOvertimeSettingRequest $request GetSimpleOvertimeSettingRequest
     * @param GetSimpleOvertimeSettingHeaders $headers GetSimpleOvertimeSettingHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSimpleOvertimeSettingResponse GetSimpleOvertimeSettingResponse
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
     * @summary 加班规则列表
     *  *
     * @param GetSimpleOvertimeSettingRequest $request GetSimpleOvertimeSettingRequest
     *
     * @return GetSimpleOvertimeSettingResponse GetSimpleOvertimeSettingResponse
     */
    public function getSimpleOvertimeSetting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSimpleOvertimeSettingHeaders([]);

        return $this->getSimpleOvertimeSettingWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询员工某段时间的假期
     *  *
     * @param GetUserHolidaysRequest $request GetUserHolidaysRequest
     * @param GetUserHolidaysHeaders $headers GetUserHolidaysHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserHolidaysResponse GetUserHolidaysResponse
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
     * @summary 查询员工某段时间的假期
     *  *
     * @param GetUserHolidaysRequest $request GetUserHolidaysRequest
     *
     * @return GetUserHolidaysResponse GetUserHolidaysResponse
     */
    public function getUserHolidays($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserHolidaysHeaders([]);

        return $this->getUserHolidaysWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建考勤组
     *  *
     * @param GroupAddRequest $request GroupAddRequest
     * @param GroupAddHeaders $headers GroupAddHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return GroupAddResponse GroupAddResponse
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
        if (!Utils::isUnset($request->onlyMachineCheck)) {
            $body['onlyMachineCheck'] = $request->onlyMachineCheck;
        }
        if (!Utils::isUnset($request->openCameraCheck)) {
            $body['openCameraCheck'] = $request->openCameraCheck;
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
     * @summary 创建考勤组
     *  *
     * @param GroupAddRequest $request GroupAddRequest
     *
     * @return GroupAddResponse GroupAddResponse
     */
    public function groupAdd($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupAddHeaders([]);

        return $this->groupAddWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改考勤组
     *  *
     * @param GroupUpdateRequest $request GroupUpdateRequest
     * @param GroupUpdateHeaders $headers GroupUpdateHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GroupUpdateResponse GroupUpdateResponse
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
        if (!Utils::isUnset($request->freecheckDayStartMinOffset)) {
            $body['freecheckDayStartMinOffset'] = $request->freecheckDayStartMinOffset;
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
        if (!Utils::isUnset($request->onlyMachineCheck)) {
            $body['onlyMachineCheck'] = $request->onlyMachineCheck;
        }
        if (!Utils::isUnset($request->openCameraCheck)) {
            $body['openCameraCheck'] = $request->openCameraCheck;
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
     * @summary 修改考勤组
     *  *
     * @param GroupUpdateRequest $request GroupUpdateRequest
     *
     * @return GroupUpdateResponse GroupUpdateResponse
     */
    public function groupUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupUpdateHeaders([]);

        return $this->groupUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 生态系统假期初始化查询余额接口
     *  *
     * @param InitAndGetLeaveALlocationQuotasRequest $request InitAndGetLeaveALlocationQuotasRequest
     * @param InitAndGetLeaveALlocationQuotasHeaders $headers InitAndGetLeaveALlocationQuotasHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return InitAndGetLeaveALlocationQuotasResponse InitAndGetLeaveALlocationQuotasResponse
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
     * @summary 生态系统假期初始化查询余额接口
     *  *
     * @param InitAndGetLeaveALlocationQuotasRequest $request InitAndGetLeaveALlocationQuotasRequest
     *
     * @return InitAndGetLeaveALlocationQuotasResponse InitAndGetLeaveALlocationQuotasResponse
     */
    public function initAndGetLeaveALlocationQuotas($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InitAndGetLeaveALlocationQuotasHeaders([]);

        return $this->initAndGetLeaveALlocationQuotasWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取用户某段时间内同步到考勤的审批单信息
     *  *
     * @param ListApproveByUsersRequest $request ListApproveByUsersRequest
     * @param ListApproveByUsersHeaders $headers ListApproveByUsersHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return ListApproveByUsersResponse ListApproveByUsersResponse
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
     * @summary 获取用户某段时间内同步到考勤的审批单信息
     *  *
     * @param ListApproveByUsersRequest $request ListApproveByUsersRequest
     *
     * @return ListApproveByUsersResponse ListApproveByUsersResponse
     */
    public function listApproveByUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListApproveByUsersHeaders([]);

        return $this->listApproveByUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改水印模板
     *  *
     * @param ModifyWaterMarkTemplateRequest $request ModifyWaterMarkTemplateRequest
     * @param ModifyWaterMarkTemplateHeaders $headers ModifyWaterMarkTemplateHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return ModifyWaterMarkTemplateResponse ModifyWaterMarkTemplateResponse
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
     * @summary 修改水印模板
     *  *
     * @param ModifyWaterMarkTemplateRequest $request ModifyWaterMarkTemplateRequest
     *
     * @return ModifyWaterMarkTemplateResponse ModifyWaterMarkTemplateResponse
     */
    public function modifyWaterMarkTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ModifyWaterMarkTemplateHeaders([]);

        return $this->modifyWaterMarkTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建考勤打卡审批单
     *  *
     * @param ProcessApproveCreateRequest $request ProcessApproveCreateRequest
     * @param ProcessApproveCreateHeaders $headers ProcessApproveCreateHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return ProcessApproveCreateResponse ProcessApproveCreateResponse
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
     * @summary 创建考勤打卡审批单
     *  *
     * @param ProcessApproveCreateRequest $request ProcessApproveCreateRequest
     *
     * @return ProcessApproveCreateResponse ProcessApproveCreateResponse
     */
    public function processApproveCreate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ProcessApproveCreateHeaders([]);

        return $this->processApproveCreateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通知审批通过
     *  *
     * @param ProcessApproveFinishRequest $request ProcessApproveFinishRequest
     * @param ProcessApproveFinishHeaders $headers ProcessApproveFinishHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return ProcessApproveFinishResponse ProcessApproveFinishResponse
     */
    public function processApproveFinishWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->approveId)) {
            $body['approveId'] = $request->approveId;
        }
        if (!Utils::isUnset($request->jumpUrl)) {
            $body['jumpUrl'] = $request->jumpUrl;
        }
        if (!Utils::isUnset($request->overTimeToMore)) {
            $body['overTimeToMore'] = $request->overTimeToMore;
        }
        if (!Utils::isUnset($request->overtimeDuration)) {
            $body['overtimeDuration'] = $request->overtimeDuration;
        }
        if (!Utils::isUnset($request->subType)) {
            $body['subType'] = $request->subType;
        }
        if (!Utils::isUnset($request->tagName)) {
            $body['tagName'] = $request->tagName;
        }
        if (!Utils::isUnset($request->topCalculateApproveDurationParam)) {
            $body['topCalculateApproveDurationParam'] = $request->topCalculateApproveDurationParam;
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
            'action'      => 'ProcessApproveFinish',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/approvals/finish',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ProcessApproveFinishResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通知审批通过
     *  *
     * @param ProcessApproveFinishRequest $request ProcessApproveFinishRequest
     *
     * @return ProcessApproveFinishResponse ProcessApproveFinishResponse
     */
    public function processApproveFinish($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ProcessApproveFinishHeaders([]);

        return $this->processApproveFinishWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 扣减员工假期余额
     *  *
     * @param string                            $unionId
     * @param ReduceQuotaWithLeaveRecordRequest $request ReduceQuotaWithLeaveRecordRequest
     * @param ReduceQuotaWithLeaveRecordHeaders $headers ReduceQuotaWithLeaveRecordHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return ReduceQuotaWithLeaveRecordResponse ReduceQuotaWithLeaveRecordResponse
     */
    public function reduceQuotaWithLeaveRecordWithOptions($unionId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->leaveCode)) {
            $body['leaveCode'] = $request->leaveCode;
        }
        if (!Utils::isUnset($request->outerId)) {
            $body['outerId'] = $request->outerId;
        }
        if (!Utils::isUnset($request->quotaNum)) {
            $body['quotaNum'] = $request->quotaNum;
        }
        if (!Utils::isUnset($request->reason)) {
            $body['reason'] = $request->reason;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
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
            'action'      => 'ReduceQuotaWithLeaveRecord',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/users/' . $unionId . '/vacations/records/modify',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ReduceQuotaWithLeaveRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 扣减员工假期余额
     *  *
     * @param string                            $unionId
     * @param ReduceQuotaWithLeaveRecordRequest $request ReduceQuotaWithLeaveRecordRequest
     *
     * @return ReduceQuotaWithLeaveRecordResponse ReduceQuotaWithLeaveRecordResponse
     */
    public function reduceQuotaWithLeaveRecord($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReduceQuotaWithLeaveRecordHeaders([]);

        return $this->reduceQuotaWithLeaveRecordWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @summary 修改假期规则来源
     *  *
     * @param RetainLeaveTypesRequest $request RetainLeaveTypesRequest
     * @param RetainLeaveTypesHeaders $headers RetainLeaveTypesHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return RetainLeaveTypesResponse RetainLeaveTypesResponse
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
     * @summary 修改假期规则来源
     *  *
     * @param RetainLeaveTypesRequest $request RetainLeaveTypesRequest
     *
     * @return RetainLeaveTypesResponse RetainLeaveTypesResponse
     */
    public function retainLeaveTypes($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RetainLeaveTypesHeaders([]);

        return $this->retainLeaveTypesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 提供给高级假期的试用订单回退
     *  *
     * @param ReverseTrialAdvancedLeaveRequest $request ReverseTrialAdvancedLeaveRequest
     * @param ReverseTrialAdvancedLeaveHeaders $headers ReverseTrialAdvancedLeaveHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return ReverseTrialAdvancedLeaveResponse ReverseTrialAdvancedLeaveResponse
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
     * @summary 提供给高级假期的试用订单回退
     *  *
     * @param ReverseTrialAdvancedLeaveRequest $request ReverseTrialAdvancedLeaveRequest
     *
     * @return ReverseTrialAdvancedLeaveResponse ReverseTrialAdvancedLeaveResponse
     */
    public function reverseTrialAdvancedLeave($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReverseTrialAdvancedLeaveHeaders([]);

        return $this->reverseTrialAdvancedLeaveWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 薪酬三方数据写入
     *  *
     * @param SalaryThirdDataIntegrationRequest $request SalaryThirdDataIntegrationRequest
     * @param SalaryThirdDataIntegrationHeaders $headers SalaryThirdDataIntegrationHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return SalaryThirdDataIntegrationResponse SalaryThirdDataIntegrationResponse
     */
    public function salaryThirdDataIntegrationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->items)) {
            $body['items'] = $request->items;
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
            'action'      => 'SalaryThirdDataIntegration',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/salaries/tripartiteDatas/write',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SalaryThirdDataIntegrationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 薪酬三方数据写入
     *  *
     * @param SalaryThirdDataIntegrationRequest $request SalaryThirdDataIntegrationRequest
     *
     * @return SalaryThirdDataIntegrationResponse SalaryThirdDataIntegrationResponse
     */
    public function salaryThirdDataIntegration($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SalaryThirdDataIntegrationHeaders([]);

        return $this->salaryThirdDataIntegrationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新增水印签到模板
     *  *
     * @param SaveCustomWaterMarkTemplateRequest $request SaveCustomWaterMarkTemplateRequest
     * @param SaveCustomWaterMarkTemplateHeaders $headers SaveCustomWaterMarkTemplateHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveCustomWaterMarkTemplateResponse SaveCustomWaterMarkTemplateResponse
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
     * @summary 新增水印签到模板
     *  *
     * @param SaveCustomWaterMarkTemplateRequest $request SaveCustomWaterMarkTemplateRequest
     *
     * @return SaveCustomWaterMarkTemplateResponse SaveCustomWaterMarkTemplateResponse
     */
    public function saveCustomWaterMarkTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveCustomWaterMarkTemplateHeaders([]);

        return $this->saveCustomWaterMarkTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建班次
     *  *
     * @param ShiftAddRequest $request ShiftAddRequest
     * @param ShiftAddHeaders $headers ShiftAddHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return ShiftAddResponse ShiftAddResponse
     */
    public function shiftAddWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->owner)) {
            $body['owner'] = $request->owner;
        }
        if (!Utils::isUnset($request->sections)) {
            $body['sections'] = $request->sections;
        }
        if (!Utils::isUnset($request->serviceId)) {
            $body['serviceId'] = $request->serviceId;
        }
        if (!Utils::isUnset($request->setting)) {
            $body['setting'] = $request->setting;
        }
        if (!Utils::isUnset($request->shiftId)) {
            $body['shiftId'] = $request->shiftId;
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
            'action'      => 'ShiftAdd',
            'version'     => 'attendance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/attendance/shifts',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ShiftAddResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建班次
     *  *
     * @param ShiftAddRequest $request ShiftAddRequest
     *
     * @return ShiftAddResponse ShiftAddResponse
     */
    public function shiftAdd($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ShiftAddHeaders([]);

        return $this->shiftAddWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 用于考勤排班附加信息，例如打卡位置，打卡wifi等
     *  *
     * @param SyncScheduleInfoRequest $request SyncScheduleInfoRequest
     * @param SyncScheduleInfoHeaders $headers SyncScheduleInfoHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return SyncScheduleInfoResponse SyncScheduleInfoResponse
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
     * @summary 用于考勤排班附加信息，例如打卡位置，打卡wifi等
     *  *
     * @param SyncScheduleInfoRequest $request SyncScheduleInfoRequest
     *
     * @return SyncScheduleInfoResponse SyncScheduleInfoResponse
     */
    public function syncScheduleInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncScheduleInfoHeaders([]);

        return $this->syncScheduleInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新假期规则
     *  *
     * @param UpdateLeaveTypeRequest $request UpdateLeaveTypeRequest
     * @param UpdateLeaveTypeHeaders $headers UpdateLeaveTypeHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateLeaveTypeResponse UpdateLeaveTypeResponse
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
     * @summary 更新假期规则
     *  *
     * @param UpdateLeaveTypeRequest $request UpdateLeaveTypeRequest
     *
     * @return UpdateLeaveTypeResponse UpdateLeaveTypeResponse
     */
    public function updateLeaveType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateLeaveTypeHeaders([]);

        return $this->updateLeaveTypeWithOptions($request, $headers, $runtime);
    }
}
