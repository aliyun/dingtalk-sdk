<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\CreateFlashMeetingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\CreateFlashMeetingRequest;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\CreateFlashMeetingResponse;
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
     * @param CreateFlashMeetingRequest $request
     * @param CreateFlashMeetingHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return CreateFlashMeetingResponse
     */
    public function createFlashMeetingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->creator)) {
            $body['creator'] = $request->creator;
        }
        if (!Utils::isUnset($request->eventId)) {
            $body['eventId'] = $request->eventId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateFlashMeeting',
            'version'     => 'flashmeeting_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/flashmeeting/meetings',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateFlashMeetingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateFlashMeetingRequest $request
     *
     * @return CreateFlashMeetingResponse
     */
    public function createFlashMeeting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateFlashMeetingHeaders([]);

        return $this->createFlashMeetingWithOptions($request, $headers, $runtime);
    }
}
