<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vevent_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\GetCallBackFaileResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\GetCallBackFaileResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\GetCallBackFaileResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\InstallAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\InstallAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\InstallAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\InstallCoolAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\InstallCoolAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\InstallCoolAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\InstallCoolAppShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\RePushSuiteTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\RePushSuiteTicketResponse;
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
        $this->_client             = new DarabonbaGatewayDingTalkClient();
        $this->_spi                = $this->_client;
        $this->_signatureAlgorithm = 'v2';
        $this->_endpointRule       = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param GetCallBackFaileResultRequest $request
     * @param GetCallBackFaileResultHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetCallBackFaileResultResponse
     */
    public function getCallBackFaileResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->beginTime)) {
            $query['beginTime'] = $request->beginTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
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
            'action'      => 'GetCallBackFaileResult',
            'version'     => 'event_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/event/callbacks/failedResults',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCallBackFaileResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetCallBackFaileResultRequest $request
     *
     * @return GetCallBackFaileResultResponse
     */
    public function getCallBackFaileResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCallBackFaileResultHeaders([]);

        return $this->getCallBackFaileResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param InstallAppRequest $request
     * @param InstallAppHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return InstallAppResponse
     */
    public function installAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appId)) {
            $query['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->dingUserId)) {
            $query['dingUserId'] = $request->dingUserId;
        }
        if (!Utils::isUnset($request->suiteId)) {
            $query['suiteId'] = $request->suiteId;
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
            'action'      => 'InstallApp',
            'version'     => 'event_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/event/elm/apps/install',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InstallAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param InstallAppRequest $request
     *
     * @return InstallAppResponse
     */
    public function installApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InstallAppHeaders([]);

        return $this->installAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @param InstallCoolAppRequest $tmpReq
     * @param InstallCoolAppHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return InstallCoolAppResponse
     */
    public function installCoolAppWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new InstallCoolAppShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->feature)) {
            $request->featureShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->feature, 'feature', 'json');
        }
        if (!Utils::isUnset($tmpReq->options)) {
            $request->optionsShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->options, 'options', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->appId)) {
            $query['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->coolAppCode)) {
            $query['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->featureShrink)) {
            $query['feature'] = $request->featureShrink;
        }
        if (!Utils::isUnset($request->installUid)) {
            $query['installUid'] = $request->installUid;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $query['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->optionsShrink)) {
            $query['options'] = $request->optionsShrink;
        }
        if (!Utils::isUnset($request->suiteId)) {
            $query['suiteId'] = $request->suiteId;
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
            'action'      => 'InstallCoolApp',
            'version'     => 'event_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/event/elm/coolApps/install',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InstallCoolAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param InstallCoolAppRequest $request
     *
     * @return InstallCoolAppResponse
     */
    public function installCoolApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InstallCoolAppHeaders([]);

        return $this->installCoolAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RePushSuiteTicketRequest $request
     * @param string[]                 $headers
     * @param RuntimeOptions           $runtime
     *
     * @return RePushSuiteTicketResponse
     */
    public function rePushSuiteTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->suiteId)) {
            $query['suiteId'] = $request->suiteId;
        }
        if (!Utils::isUnset($request->suiteSecret)) {
            $query['suiteSecret'] = $request->suiteSecret;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'RePushSuiteTicket',
            'version'     => 'event_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/event/suiteTicket/rePush',
            'method'      => 'POST',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RePushSuiteTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RePushSuiteTicketRequest $request
     *
     * @return RePushSuiteTicketResponse
     */
    public function rePushSuiteTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->rePushSuiteTicketWithOptions($request, $headers, $runtime);
    }
}
