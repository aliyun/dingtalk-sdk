<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpedia_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsAddHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsAddRequest;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsAddResponse;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsApproveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsApproveRequest;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsApproveResponse;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsDeleteHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsDeleteRequest;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsDeleteResponse;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsSearchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsSearchRequest;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsSearchResponse;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsUpdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsUpdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsUpdateResponse;
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
        $gatewayClient = new Client();
        $this->_spi = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 企业百科增加当前企业词条信息
     *  *
     * @param PediaWordsAddRequest $request PediaWordsAddRequest
     * @param PediaWordsAddHeaders $headers PediaWordsAddHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return PediaWordsAddResponse PediaWordsAddResponse
     */
    public function pediaWordsAddWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->contactList)) {
            $body['contactList'] = $request->contactList;
        }
        if (!Utils::isUnset($request->highLightWordAlias)) {
            $body['highLightWordAlias'] = $request->highLightWordAlias;
        }
        if (!Utils::isUnset($request->picList)) {
            $body['picList'] = $request->picList;
        }
        if (!Utils::isUnset($request->relatedDoc)) {
            $body['relatedDoc'] = $request->relatedDoc;
        }
        if (!Utils::isUnset($request->relatedLink)) {
            $body['relatedLink'] = $request->relatedLink;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->wordAlias)) {
            $body['wordAlias'] = $request->wordAlias;
        }
        if (!Utils::isUnset($request->wordName)) {
            $body['wordName'] = $request->wordName;
        }
        if (!Utils::isUnset($request->wordParaphrase)) {
            $body['wordParaphrase'] = $request->wordParaphrase;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PediaWordsAdd',
            'version' => 'pedia_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/pedia/words',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PediaWordsAddResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 企业百科增加当前企业词条信息
     *  *
     * @param PediaWordsAddRequest $request PediaWordsAddRequest
     *
     * @return PediaWordsAddResponse PediaWordsAddResponse
     */
    public function pediaWordsAdd($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PediaWordsAddHeaders([]);

        return $this->pediaWordsAddWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 企业百科针对待审核词条进行审核
     *  *
     * @param PediaWordsApproveRequest $request PediaWordsApproveRequest
     * @param PediaWordsApproveHeaders $headers PediaWordsApproveHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return PediaWordsApproveResponse PediaWordsApproveResponse
     */
    public function pediaWordsApproveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->aliDocHighLight)) {
            $body['aliDocHighLight'] = $request->aliDocHighLight;
        }
        if (!Utils::isUnset($request->approveReason)) {
            $body['approveReason'] = $request->approveReason;
        }
        if (!Utils::isUnset($request->approveStatus)) {
            $body['approveStatus'] = $request->approveStatus;
        }
        if (!Utils::isUnset($request->imHighLight)) {
            $body['imHighLight'] = $request->imHighLight;
        }
        if (!Utils::isUnset($request->simHighLight)) {
            $body['simHighLight'] = $request->simHighLight;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->uuid)) {
            $body['uuid'] = $request->uuid;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PediaWordsApprove',
            'version' => 'pedia_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/pedia/words/approve',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PediaWordsApproveResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 企业百科针对待审核词条进行审核
     *  *
     * @param PediaWordsApproveRequest $request PediaWordsApproveRequest
     *
     * @return PediaWordsApproveResponse PediaWordsApproveResponse
     */
    public function pediaWordsApprove($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PediaWordsApproveHeaders([]);

        return $this->pediaWordsApproveWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 企业百科针对uuid删除当前词条
     *  *
     * @param PediaWordsDeleteRequest $request PediaWordsDeleteRequest
     * @param PediaWordsDeleteHeaders $headers PediaWordsDeleteHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return PediaWordsDeleteResponse PediaWordsDeleteResponse
     */
    public function pediaWordsDeleteWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->uuid)) {
            $query['uuid'] = $request->uuid;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'PediaWordsDelete',
            'version' => 'pedia_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/pedia/words',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PediaWordsDeleteResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 企业百科针对uuid删除当前词条
     *  *
     * @param PediaWordsDeleteRequest $request PediaWordsDeleteRequest
     *
     * @return PediaWordsDeleteResponse PediaWordsDeleteResponse
     */
    public function pediaWordsDelete($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PediaWordsDeleteHeaders([]);

        return $this->pediaWordsDeleteWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据词条主键ID查询当前词条详情
     *  *
     * @param PediaWordsQueryRequest $request PediaWordsQueryRequest
     * @param PediaWordsQueryHeaders $headers PediaWordsQueryHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return PediaWordsQueryResponse PediaWordsQueryResponse
     */
    public function pediaWordsQueryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->uuid)) {
            $query['uuid'] = $request->uuid;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'PediaWordsQuery',
            'version' => 'pedia_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/pedia/words/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PediaWordsQueryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据词条主键ID查询当前词条详情
     *  *
     * @param PediaWordsQueryRequest $request PediaWordsQueryRequest
     *
     * @return PediaWordsQueryResponse PediaWordsQueryResponse
     */
    public function pediaWordsQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PediaWordsQueryHeaders([]);

        return $this->pediaWordsQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页获取企业词条信息
     *  *
     * @param PediaWordsSearchRequest $request PediaWordsSearchRequest
     * @param PediaWordsSearchHeaders $headers PediaWordsSearchHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return PediaWordsSearchResponse PediaWordsSearchResponse
     */
    public function pediaWordsSearchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->wordName)) {
            $body['wordName'] = $request->wordName;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PediaWordsSearch',
            'version' => 'pedia_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/pedia/words/search',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PediaWordsSearchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页获取企业词条信息
     *  *
     * @param PediaWordsSearchRequest $request PediaWordsSearchRequest
     *
     * @return PediaWordsSearchResponse PediaWordsSearchResponse
     */
    public function pediaWordsSearch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PediaWordsSearchHeaders([]);

        return $this->pediaWordsSearchWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 企业百科对当前已经生效词条进行编辑
     *  *
     * @param PediaWordsUpdateRequest $request PediaWordsUpdateRequest
     * @param PediaWordsUpdateHeaders $headers PediaWordsUpdateHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return PediaWordsUpdateResponse PediaWordsUpdateResponse
     */
    public function pediaWordsUpdateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appLink)) {
            $body['appLink'] = $request->appLink;
        }
        if (!Utils::isUnset($request->contactList)) {
            $body['contactList'] = $request->contactList;
        }
        if (!Utils::isUnset($request->highLightWordAlias)) {
            $body['highLightWordAlias'] = $request->highLightWordAlias;
        }
        if (!Utils::isUnset($request->picList)) {
            $body['picList'] = $request->picList;
        }
        if (!Utils::isUnset($request->relatedDoc)) {
            $body['relatedDoc'] = $request->relatedDoc;
        }
        if (!Utils::isUnset($request->relatedLink)) {
            $body['relatedLink'] = $request->relatedLink;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->uuid)) {
            $body['uuid'] = $request->uuid;
        }
        if (!Utils::isUnset($request->wordAlias)) {
            $body['wordAlias'] = $request->wordAlias;
        }
        if (!Utils::isUnset($request->wordName)) {
            $body['wordName'] = $request->wordName;
        }
        if (!Utils::isUnset($request->wordParaphrase)) {
            $body['wordParaphrase'] = $request->wordParaphrase;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PediaWordsUpdate',
            'version' => 'pedia_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/pedia/words',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PediaWordsUpdateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 企业百科对当前已经生效词条进行编辑
     *  *
     * @param PediaWordsUpdateRequest $request PediaWordsUpdateRequest
     *
     * @return PediaWordsUpdateResponse PediaWordsUpdateResponse
     */
    public function pediaWordsUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PediaWordsUpdateHeaders([]);

        return $this->pediaWordsUpdateWithOptions($request, $headers, $runtime);
    }
}
