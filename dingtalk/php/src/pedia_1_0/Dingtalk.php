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
     * @param PediaWordsAddRequest $request
     *
     * @return PediaWordsAddResponse
     */
    public function pediaWordsAdd($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PediaWordsAddHeaders([]);

        return $this->pediaWordsAddWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PediaWordsAddRequest $request
     * @param PediaWordsAddHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return PediaWordsAddResponse
     */
    public function pediaWordsAddWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->contactList)) {
            @$body['contactList'] = $request->contactList;
        }
        if (!Utils::isUnset($request->highLightWordAlias)) {
            @$body['highLightWordAlias'] = $request->highLightWordAlias;
        }
        if (!Utils::isUnset($request->picList)) {
            @$body['picList'] = $request->picList;
        }
        if (!Utils::isUnset($request->relatedDoc)) {
            @$body['relatedDoc'] = $request->relatedDoc;
        }
        if (!Utils::isUnset($request->relatedLink)) {
            @$body['relatedLink'] = $request->relatedLink;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->wordAlias)) {
            @$body['wordAlias'] = $request->wordAlias;
        }
        if (!Utils::isUnset($request->wordName)) {
            @$body['wordName'] = $request->wordName;
        }
        if (!Utils::isUnset($request->wordParaphrase)) {
            @$body['wordParaphrase'] = $request->wordParaphrase;
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

        return PediaWordsAddResponse::fromMap($this->doROARequest('PediaWordsAdd', 'pedia_1.0', 'HTTP', 'POST', 'AK', '/v1.0/pedia/words', 'json', $req, $runtime));
    }

    /**
     * @param PediaWordsApproveRequest $request
     *
     * @return PediaWordsApproveResponse
     */
    public function pediaWordsApprove($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PediaWordsApproveHeaders([]);

        return $this->pediaWordsApproveWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PediaWordsApproveRequest $request
     * @param PediaWordsApproveHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return PediaWordsApproveResponse
     */
    public function pediaWordsApproveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->approveReason)) {
            @$body['approveReason'] = $request->approveReason;
        }
        if (!Utils::isUnset($request->approveStatus)) {
            @$body['approveStatus'] = $request->approveStatus;
        }
        if (!Utils::isUnset($request->imHighLight)) {
            @$body['imHighLight'] = $request->imHighLight;
        }
        if (!Utils::isUnset($request->simHighLight)) {
            @$body['simHighLight'] = $request->simHighLight;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->uuid)) {
            @$body['uuid'] = $request->uuid;
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

        return PediaWordsApproveResponse::fromMap($this->doROARequest('PediaWordsApprove', 'pedia_1.0', 'HTTP', 'POST', 'AK', '/v1.0/pedia/words/approve', 'json', $req, $runtime));
    }

    /**
     * @param PediaWordsDeleteRequest $request
     *
     * @return PediaWordsDeleteResponse
     */
    public function pediaWordsDelete($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PediaWordsDeleteHeaders([]);

        return $this->pediaWordsDeleteWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PediaWordsDeleteRequest $request
     * @param PediaWordsDeleteHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return PediaWordsDeleteResponse
     */
    public function pediaWordsDeleteWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->uuid)) {
            @$query['uuid'] = $request->uuid;
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

        return PediaWordsDeleteResponse::fromMap($this->doROARequest('PediaWordsDelete', 'pedia_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/pedia/words', 'json', $req, $runtime));
    }

    /**
     * @param PediaWordsQueryRequest $request
     *
     * @return PediaWordsQueryResponse
     */
    public function pediaWordsQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PediaWordsQueryHeaders([]);

        return $this->pediaWordsQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PediaWordsQueryRequest $request
     * @param PediaWordsQueryHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return PediaWordsQueryResponse
     */
    public function pediaWordsQueryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->uuid)) {
            @$query['uuid'] = $request->uuid;
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

        return PediaWordsQueryResponse::fromMap($this->doROARequest('PediaWordsQuery', 'pedia_1.0', 'HTTP', 'POST', 'AK', '/v1.0/pedia/words/query', 'json', $req, $runtime));
    }

    /**
     * @param PediaWordsSearchRequest $request
     *
     * @return PediaWordsSearchResponse
     */
    public function pediaWordsSearch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PediaWordsSearchHeaders([]);

        return $this->pediaWordsSearchWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PediaWordsSearchRequest $request
     * @param PediaWordsSearchHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return PediaWordsSearchResponse
     */
    public function pediaWordsSearchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->wordName)) {
            @$body['wordName'] = $request->wordName;
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

        return PediaWordsSearchResponse::fromMap($this->doROARequest('PediaWordsSearch', 'pedia_1.0', 'HTTP', 'POST', 'AK', '/v1.0/pedia/words/search', 'json', $req, $runtime));
    }

    /**
     * @param PediaWordsUpdateRequest $request
     *
     * @return PediaWordsUpdateResponse
     */
    public function pediaWordsUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PediaWordsUpdateHeaders([]);

        return $this->pediaWordsUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PediaWordsUpdateRequest $request
     * @param PediaWordsUpdateHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return PediaWordsUpdateResponse
     */
    public function pediaWordsUpdateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appLink)) {
            @$body['appLink'] = $request->appLink;
        }
        if (!Utils::isUnset($request->contactList)) {
            @$body['contactList'] = $request->contactList;
        }
        if (!Utils::isUnset($request->highLightWordAlias)) {
            @$body['highLightWordAlias'] = $request->highLightWordAlias;
        }
        if (!Utils::isUnset($request->picList)) {
            @$body['picList'] = $request->picList;
        }
        if (!Utils::isUnset($request->relatedDoc)) {
            @$body['relatedDoc'] = $request->relatedDoc;
        }
        if (!Utils::isUnset($request->relatedLink)) {
            @$body['relatedLink'] = $request->relatedLink;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->uuid)) {
            @$body['uuid'] = $request->uuid;
        }
        if (!Utils::isUnset($request->wordAlias)) {
            @$body['wordAlias'] = $request->wordAlias;
        }
        if (!Utils::isUnset($request->wordName)) {
            @$body['wordName'] = $request->wordName;
        }
        if (!Utils::isUnset($request->wordParaphrase)) {
            @$body['wordParaphrase'] = $request->wordParaphrase;
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

        return PediaWordsUpdateResponse::fromMap($this->doROARequest('PediaWordsUpdate', 'pedia_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/pedia/words', 'json', $req, $runtime));
    }
}
