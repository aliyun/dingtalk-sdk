<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\AddDeviceVideoConferenceMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\AddDeviceVideoConferenceMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\AddDeviceVideoConferenceMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\CreateDeviceVideoConferenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\CreateDeviceVideoConferenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\CreateDeviceVideoConferenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\ExtractFacialFeatureHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\ExtractFacialFeatureRequest;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\ExtractFacialFeatureResponse;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\KickDeviceVideoConferenceMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\KickDeviceVideoConferenceMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\KickDeviceVideoConferenceMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\QueryDeviceVideoConferenceBookHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\QueryDeviceVideoConferenceBookResponse;
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
     * @param string $deviceId
     * @param string $bookId
     *
     * @return QueryDeviceVideoConferenceBookResponse
     */
    public function queryDeviceVideoConferenceBook($deviceId, $bookId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceVideoConferenceBookHeaders([]);

        return $this->queryDeviceVideoConferenceBookWithOptions($deviceId, $bookId, $headers, $runtime);
    }

    /**
     * @param string                                $deviceId
     * @param string                                $bookId
     * @param QueryDeviceVideoConferenceBookHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryDeviceVideoConferenceBookResponse
     */
    public function queryDeviceVideoConferenceBookWithOptions($deviceId, $bookId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryDeviceVideoConferenceBookResponse::fromMap($this->doROARequest('QueryDeviceVideoConferenceBook', 'smartDevice_1.0', 'HTTP', 'GET', 'AK', '/v1.0/smartDevice/devices/' . $deviceId . '/books/' . $bookId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                                 $deviceId
     * @param string                                 $conferenceId
     * @param AddDeviceVideoConferenceMembersRequest $request
     *
     * @return AddDeviceVideoConferenceMembersResponse
     */
    public function addDeviceVideoConferenceMembers($deviceId, $conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddDeviceVideoConferenceMembersHeaders([]);

        return $this->addDeviceVideoConferenceMembersWithOptions($deviceId, $conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string                                 $deviceId
     * @param string                                 $conferenceId
     * @param AddDeviceVideoConferenceMembersRequest $request
     * @param AddDeviceVideoConferenceMembersHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return AddDeviceVideoConferenceMembersResponse
     */
    public function addDeviceVideoConferenceMembersWithOptions($deviceId, $conferenceId, $request, $headers, $runtime)
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

        return AddDeviceVideoConferenceMembersResponse::fromMap($this->doROARequest('AddDeviceVideoConferenceMembers', 'smartDevice_1.0', 'HTTP', 'POST', 'AK', '/v1.0/smartDevice/devices/' . $deviceId . '/videoConferences/' . $conferenceId . '/members', 'none', $req, $runtime));
    }

    /**
     * @param string                             $deviceId
     * @param CreateDeviceVideoConferenceRequest $request
     *
     * @return CreateDeviceVideoConferenceResponse
     */
    public function createDeviceVideoConference($deviceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDeviceVideoConferenceHeaders([]);

        return $this->createDeviceVideoConferenceWithOptions($deviceId, $request, $headers, $runtime);
    }

    /**
     * @param string                             $deviceId
     * @param CreateDeviceVideoConferenceRequest $request
     * @param CreateDeviceVideoConferenceHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return CreateDeviceVideoConferenceResponse
     */
    public function createDeviceVideoConferenceWithOptions($deviceId, $request, $headers, $runtime)
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

        return CreateDeviceVideoConferenceResponse::fromMap($this->doROARequest('CreateDeviceVideoConference', 'smartDevice_1.0', 'HTTP', 'POST', 'AK', '/v1.0/smartDevice/devices/' . $deviceId . '/videoConferences', 'json', $req, $runtime));
    }

    /**
     * @param string                                  $deviceId
     * @param string                                  $conferenceId
     * @param KickDeviceVideoConferenceMembersRequest $request
     *
     * @return KickDeviceVideoConferenceMembersResponse
     */
    public function kickDeviceVideoConferenceMembers($deviceId, $conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new KickDeviceVideoConferenceMembersHeaders([]);

        return $this->kickDeviceVideoConferenceMembersWithOptions($deviceId, $conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string                                  $deviceId
     * @param string                                  $conferenceId
     * @param KickDeviceVideoConferenceMembersRequest $request
     * @param KickDeviceVideoConferenceMembersHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return KickDeviceVideoConferenceMembersResponse
     */
    public function kickDeviceVideoConferenceMembersWithOptions($deviceId, $conferenceId, $request, $headers, $runtime)
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

        return KickDeviceVideoConferenceMembersResponse::fromMap($this->doROARequest('KickDeviceVideoConferenceMembers', 'smartDevice_1.0', 'HTTP', 'POST', 'AK', '/v1.0/smartDevice/devices/' . $deviceId . '/videoConferences/' . $conferenceId . '/members/batchDelete', 'none', $req, $runtime));
    }

    /**
     * @param ExtractFacialFeatureRequest $request
     *
     * @return ExtractFacialFeatureResponse
     */
    public function extractFacialFeature($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExtractFacialFeatureHeaders([]);

        return $this->extractFacialFeatureWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ExtractFacialFeatureRequest $request
     * @param ExtractFacialFeatureHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return ExtractFacialFeatureResponse
     */
    public function extractFacialFeatureWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userid)) {
            @$body['userid'] = $request->userid;
        }
        if (!Utils::isUnset($request->mediaId)) {
            @$body['mediaId'] = $request->mediaId;
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

        return ExtractFacialFeatureResponse::fromMap($this->doROARequest('ExtractFacialFeature', 'smartDevice_1.0', 'HTTP', 'POST', 'AK', '/v1.0/smartDevice/faceRecognitions/features/extract', 'json', $req, $runtime));
    }
}
