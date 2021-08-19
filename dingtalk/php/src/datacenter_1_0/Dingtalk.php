<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryActiveUserStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryActiveUserStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryActiveUserStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryApprovalStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryApprovalStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryApprovalStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryAttendanceStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryAttendanceStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryAttendanceStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryBlackboardStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryBlackboardStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryBlackboardStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCalendarStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCalendarStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCalendarStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCheckinStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCheckinStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCheckinStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCircleStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCircleStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCircleStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDigitalDistrictOrgInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDigitalDistrictOrgInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDigitalDistrictOrgInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDingReciveStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDingReciveStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDingReciveStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDingSendStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDingSendStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDingSendStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDocumentStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDocumentStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDocumentStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDriveStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDriveStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDriveStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryEmployeeTypeStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryEmployeeTypeStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryEmployeeTypeStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGroupLiveStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGroupLiveStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGroupLiveStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGroupMessageStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGroupMessageStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGroupMessageStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryHealthStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryHealthStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryHealthStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryMailStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryMailStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryMailStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOnlineUserStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOnlineUserStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOnlineUserStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryRedEnvelopeReciveStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryRedEnvelopeReciveStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryRedEnvelopeReciveStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryRedEnvelopeSendStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryRedEnvelopeSendStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryRedEnvelopeSendStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryReportStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryReportStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryReportStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QuerySingleMessageStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QuerySingleMessageStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QuerySingleMessageStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTelMeetingStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTelMeetingStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTelMeetingStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTodoStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTodoStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTodoStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryVedioMeetingStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryVedioMeetingStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryVedioMeetingStatisticalDataResponse;
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
     * @param QueryGroupMessageStatisticalDataRequest $request
     *
     * @return QueryGroupMessageStatisticalDataResponse
     */
    public function queryGroupMessageStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupMessageStatisticalDataHeaders([]);

        return $this->queryGroupMessageStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryGroupMessageStatisticalDataRequest $request
     * @param QueryGroupMessageStatisticalDataHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return QueryGroupMessageStatisticalDataResponse
     */
    public function queryGroupMessageStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryGroupMessageStatisticalDataResponse::fromMap($this->doROARequest('QueryGroupMessageStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/groupMessageData', 'json', $req, $runtime));
    }

    /**
     * @param QueryVedioMeetingStatisticalDataRequest $request
     *
     * @return QueryVedioMeetingStatisticalDataResponse
     */
    public function queryVedioMeetingStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryVedioMeetingStatisticalDataHeaders([]);

        return $this->queryVedioMeetingStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryVedioMeetingStatisticalDataRequest $request
     * @param QueryVedioMeetingStatisticalDataHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return QueryVedioMeetingStatisticalDataResponse
     */
    public function queryVedioMeetingStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryVedioMeetingStatisticalDataResponse::fromMap($this->doROARequest('QueryVedioMeetingStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/vedioMeetingData', 'json', $req, $runtime));
    }

    /**
     * @param QueryHealthStatisticalDataRequest $request
     *
     * @return QueryHealthStatisticalDataResponse
     */
    public function queryHealthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHealthStatisticalDataHeaders([]);

        return $this->queryHealthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryHealthStatisticalDataRequest $request
     * @param QueryHealthStatisticalDataHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return QueryHealthStatisticalDataResponse
     */
    public function queryHealthStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryHealthStatisticalDataResponse::fromMap($this->doROARequest('QueryHealthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/healtheUserData', 'json', $req, $runtime));
    }

    /**
     * @param QuerySingleMessageStatisticalDataRequest $request
     *
     * @return QuerySingleMessageStatisticalDataResponse
     */
    public function querySingleMessageStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySingleMessageStatisticalDataHeaders([]);

        return $this->querySingleMessageStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QuerySingleMessageStatisticalDataRequest $request
     * @param QuerySingleMessageStatisticalDataHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return QuerySingleMessageStatisticalDataResponse
     */
    public function querySingleMessageStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QuerySingleMessageStatisticalDataResponse::fromMap($this->doROARequest('QuerySingleMessageStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/singleMessagerData', 'json', $req, $runtime));
    }

    /**
     * @param QueryTodoStatisticalDataRequest $request
     *
     * @return QueryTodoStatisticalDataResponse
     */
    public function queryTodoStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTodoStatisticalDataHeaders([]);

        return $this->queryTodoStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryTodoStatisticalDataRequest $request
     * @param QueryTodoStatisticalDataHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return QueryTodoStatisticalDataResponse
     */
    public function queryTodoStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryTodoStatisticalDataResponse::fromMap($this->doROARequest('QueryTodoStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/todoUserData', 'json', $req, $runtime));
    }

    /**
     * @param QueryCheckinStatisticalDataRequest $request
     *
     * @return QueryCheckinStatisticalDataResponse
     */
    public function queryCheckinStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCheckinStatisticalDataHeaders([]);

        return $this->queryCheckinStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCheckinStatisticalDataRequest $request
     * @param QueryCheckinStatisticalDataHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return QueryCheckinStatisticalDataResponse
     */
    public function queryCheckinStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryCheckinStatisticalDataResponse::fromMap($this->doROARequest('QueryCheckinStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/checkinData', 'json', $req, $runtime));
    }

    /**
     * @param QueryEmployeeTypeStatisticalDataRequest $request
     *
     * @return QueryEmployeeTypeStatisticalDataResponse
     */
    public function queryEmployeeTypeStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryEmployeeTypeStatisticalDataHeaders([]);

        return $this->queryEmployeeTypeStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryEmployeeTypeStatisticalDataRequest $request
     * @param QueryEmployeeTypeStatisticalDataHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return QueryEmployeeTypeStatisticalDataResponse
     */
    public function queryEmployeeTypeStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryEmployeeTypeStatisticalDataResponse::fromMap($this->doROARequest('QueryEmployeeTypeStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/employeeTypeData', 'json', $req, $runtime));
    }

    /**
     * @param QueryMailStatisticalDataRequest $request
     *
     * @return QueryMailStatisticalDataResponse
     */
    public function queryMailStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMailStatisticalDataHeaders([]);

        return $this->queryMailStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryMailStatisticalDataRequest $request
     * @param QueryMailStatisticalDataHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return QueryMailStatisticalDataResponse
     */
    public function queryMailStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryMailStatisticalDataResponse::fromMap($this->doROARequest('QueryMailStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/mailData', 'json', $req, $runtime));
    }

    /**
     * @param QueryCalendarStatisticalDataRequest $request
     *
     * @return QueryCalendarStatisticalDataResponse
     */
    public function queryCalendarStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCalendarStatisticalDataHeaders([]);

        return $this->queryCalendarStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCalendarStatisticalDataRequest $request
     * @param QueryCalendarStatisticalDataHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryCalendarStatisticalDataResponse
     */
    public function queryCalendarStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryCalendarStatisticalDataResponse::fromMap($this->doROARequest('QueryCalendarStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/calendarData', 'json', $req, $runtime));
    }

    /**
     * @param QueryDocumentStatisticalDataRequest $request
     *
     * @return QueryDocumentStatisticalDataResponse
     */
    public function queryDocumentStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDocumentStatisticalDataHeaders([]);

        return $this->queryDocumentStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDocumentStatisticalDataRequest $request
     * @param QueryDocumentStatisticalDataHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryDocumentStatisticalDataResponse
     */
    public function queryDocumentStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryDocumentStatisticalDataResponse::fromMap($this->doROARequest('QueryDocumentStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/documentData', 'json', $req, $runtime));
    }

    /**
     * @param QueryReportStatisticalDataRequest $request
     *
     * @return QueryReportStatisticalDataResponse
     */
    public function queryReportStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryReportStatisticalDataHeaders([]);

        return $this->queryReportStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryReportStatisticalDataRequest $request
     * @param QueryReportStatisticalDataHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return QueryReportStatisticalDataResponse
     */
    public function queryReportStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryReportStatisticalDataResponse::fromMap($this->doROARequest('QueryReportStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/reportData', 'json', $req, $runtime));
    }

    /**
     * @param QueryOnlineUserStatisticalDataRequest $request
     *
     * @return QueryOnlineUserStatisticalDataResponse
     */
    public function queryOnlineUserStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOnlineUserStatisticalDataHeaders([]);

        return $this->queryOnlineUserStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryOnlineUserStatisticalDataRequest $request
     * @param QueryOnlineUserStatisticalDataHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryOnlineUserStatisticalDataResponse
     */
    public function queryOnlineUserStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryOnlineUserStatisticalDataResponse::fromMap($this->doROARequest('QueryOnlineUserStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/onlineUserData', 'json', $req, $runtime));
    }

    /**
     * @param QueryApprovalStatisticalDataRequest $request
     *
     * @return QueryApprovalStatisticalDataResponse
     */
    public function queryApprovalStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryApprovalStatisticalDataHeaders([]);

        return $this->queryApprovalStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryApprovalStatisticalDataRequest $request
     * @param QueryApprovalStatisticalDataHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryApprovalStatisticalDataResponse
     */
    public function queryApprovalStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryApprovalStatisticalDataResponse::fromMap($this->doROARequest('QueryApprovalStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/approvalData', 'json', $req, $runtime));
    }

    /**
     * @param QueryDriveStatisticalDataRequest $request
     *
     * @return QueryDriveStatisticalDataResponse
     */
    public function queryDriveStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDriveStatisticalDataHeaders([]);

        return $this->queryDriveStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDriveStatisticalDataRequest $request
     * @param QueryDriveStatisticalDataHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryDriveStatisticalDataResponse
     */
    public function queryDriveStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryDriveStatisticalDataResponse::fromMap($this->doROARequest('QueryDriveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/driveData', 'json', $req, $runtime));
    }

    /**
     * @param QueryDingSendStatisticalDataRequest $request
     *
     * @return QueryDingSendStatisticalDataResponse
     */
    public function queryDingSendStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDingSendStatisticalDataHeaders([]);

        return $this->queryDingSendStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDingSendStatisticalDataRequest $request
     * @param QueryDingSendStatisticalDataHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryDingSendStatisticalDataResponse
     */
    public function queryDingSendStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryDingSendStatisticalDataResponse::fromMap($this->doROARequest('QueryDingSendStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/dingSendData', 'json', $req, $runtime));
    }

    /**
     * @param QueryActiveUserStatisticalDataRequest $request
     *
     * @return QueryActiveUserStatisticalDataResponse
     */
    public function queryActiveUserStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryActiveUserStatisticalDataHeaders([]);

        return $this->queryActiveUserStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryActiveUserStatisticalDataRequest $request
     * @param QueryActiveUserStatisticalDataHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryActiveUserStatisticalDataResponse
     */
    public function queryActiveUserStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryActiveUserStatisticalDataResponse::fromMap($this->doROARequest('QueryActiveUserStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/activeUserData', 'json', $req, $runtime));
    }

    /**
     * @param QueryGroupLiveStatisticalDataRequest $request
     *
     * @return QueryGroupLiveStatisticalDataResponse
     */
    public function queryGroupLiveStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupLiveStatisticalDataHeaders([]);

        return $this->queryGroupLiveStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryGroupLiveStatisticalDataRequest $request
     * @param QueryGroupLiveStatisticalDataHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return QueryGroupLiveStatisticalDataResponse
     */
    public function queryGroupLiveStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryGroupLiveStatisticalDataResponse::fromMap($this->doROARequest('QueryGroupLiveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/groupLiveData', 'json', $req, $runtime));
    }

    /**
     * @param QueryDigitalDistrictOrgInfoRequest $request
     *
     * @return QueryDigitalDistrictOrgInfoResponse
     */
    public function queryDigitalDistrictOrgInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDigitalDistrictOrgInfoHeaders([]);

        return $this->queryDigitalDistrictOrgInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDigitalDistrictOrgInfoRequest $request
     * @param QueryDigitalDistrictOrgInfoHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return QueryDigitalDistrictOrgInfoResponse
     */
    public function queryDigitalDistrictOrgInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->kpiGroupId)) {
            @$body['kpiGroupId'] = $request->kpiGroupId;
        }
        if (!Utils::isUnset($request->statDates)) {
            @$body['statDates'] = $request->statDates;
        }
        if (!Utils::isUnset($request->corpIds)) {
            @$body['corpIds'] = $request->corpIds;
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

        return QueryDigitalDistrictOrgInfoResponse::fromMap($this->doROARequest('QueryDigitalDistrictOrgInfo', 'datacenter_1.0', 'HTTP', 'POST', 'AK', '/v1.0/datacenter/digitalCounty/orgInfos/query', 'json', $req, $runtime));
    }

    /**
     * @param QueryAttendanceStatisticalDataRequest $request
     *
     * @return QueryAttendanceStatisticalDataResponse
     */
    public function queryAttendanceStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAttendanceStatisticalDataHeaders([]);

        return $this->queryAttendanceStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAttendanceStatisticalDataRequest $request
     * @param QueryAttendanceStatisticalDataHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryAttendanceStatisticalDataResponse
     */
    public function queryAttendanceStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryAttendanceStatisticalDataResponse::fromMap($this->doROARequest('QueryAttendanceStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/attendanceData', 'json', $req, $runtime));
    }

    /**
     * @param QueryDingReciveStatisticalDataRequest $request
     *
     * @return QueryDingReciveStatisticalDataResponse
     */
    public function queryDingReciveStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDingReciveStatisticalDataHeaders([]);

        return $this->queryDingReciveStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDingReciveStatisticalDataRequest $request
     * @param QueryDingReciveStatisticalDataHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryDingReciveStatisticalDataResponse
     */
    public function queryDingReciveStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryDingReciveStatisticalDataResponse::fromMap($this->doROARequest('QueryDingReciveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/dingReciveData', 'json', $req, $runtime));
    }

    /**
     * @param QueryRedEnvelopeReciveStatisticalDataRequest $request
     *
     * @return QueryRedEnvelopeReciveStatisticalDataResponse
     */
    public function queryRedEnvelopeReciveStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRedEnvelopeReciveStatisticalDataHeaders([]);

        return $this->queryRedEnvelopeReciveStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryRedEnvelopeReciveStatisticalDataRequest $request
     * @param QueryRedEnvelopeReciveStatisticalDataHeaders $headers
     * @param RuntimeOptions                               $runtime
     *
     * @return QueryRedEnvelopeReciveStatisticalDataResponse
     */
    public function queryRedEnvelopeReciveStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryRedEnvelopeReciveStatisticalDataResponse::fromMap($this->doROARequest('QueryRedEnvelopeReciveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/redEnvelopeReciveData', 'json', $req, $runtime));
    }

    /**
     * @param QueryCircleStatisticalDataRequest $request
     *
     * @return QueryCircleStatisticalDataResponse
     */
    public function queryCircleStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCircleStatisticalDataHeaders([]);

        return $this->queryCircleStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCircleStatisticalDataRequest $request
     * @param QueryCircleStatisticalDataHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return QueryCircleStatisticalDataResponse
     */
    public function queryCircleStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryCircleStatisticalDataResponse::fromMap($this->doROARequest('QueryCircleStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/circleData', 'json', $req, $runtime));
    }

    /**
     * @param QueryRedEnvelopeSendStatisticalDataRequest $request
     *
     * @return QueryRedEnvelopeSendStatisticalDataResponse
     */
    public function queryRedEnvelopeSendStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRedEnvelopeSendStatisticalDataHeaders([]);

        return $this->queryRedEnvelopeSendStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryRedEnvelopeSendStatisticalDataRequest $request
     * @param QueryRedEnvelopeSendStatisticalDataHeaders $headers
     * @param RuntimeOptions                             $runtime
     *
     * @return QueryRedEnvelopeSendStatisticalDataResponse
     */
    public function queryRedEnvelopeSendStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryRedEnvelopeSendStatisticalDataResponse::fromMap($this->doROARequest('QueryRedEnvelopeSendStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/redEnvelopeSendData', 'json', $req, $runtime));
    }

    /**
     * @param QueryTelMeetingStatisticalDataRequest $request
     *
     * @return QueryTelMeetingStatisticalDataResponse
     */
    public function queryTelMeetingStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTelMeetingStatisticalDataHeaders([]);

        return $this->queryTelMeetingStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryTelMeetingStatisticalDataRequest $request
     * @param QueryTelMeetingStatisticalDataHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryTelMeetingStatisticalDataResponse
     */
    public function queryTelMeetingStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryTelMeetingStatisticalDataResponse::fromMap($this->doROARequest('QueryTelMeetingStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/telMeetingData', 'json', $req, $runtime));
    }

    /**
     * @param QueryBlackboardStatisticalDataRequest $request
     *
     * @return QueryBlackboardStatisticalDataResponse
     */
    public function queryBlackboardStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBlackboardStatisticalDataHeaders([]);

        return $this->queryBlackboardStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryBlackboardStatisticalDataRequest $request
     * @param QueryBlackboardStatisticalDataHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryBlackboardStatisticalDataResponse
     */
    public function queryBlackboardStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
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

        return QueryBlackboardStatisticalDataResponse::fromMap($this->doROARequest('QueryBlackboardStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', '/v1.0/datacenter/blackboardData', 'json', $req, $runtime));
    }
}
