<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryRequest\queryParams;
use AlibabaCloud\Tea\Model;

class MasterDataQueryRequest extends Model
{
    /**
     * @example uk_12123
     *
     * @var string
     */
    public $bizUK;

    /**
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 0
     *
     * @var int
     */
    public $nextToken;

    /**
     * @example admin1234
     *
     * @var string
     */
    public $optUserId;

    /**
     * @var queryParams[]
     */
    public $queryParams;

    /**
     * @var string[]
     */
    public $relationIds;

    /**
     * @example PERFORMANCE
     *
     * @var string
     */
    public $scopeCode;

    /**
     * @example 3
     *
     * @var int
     */
    public $tenantId;

    /**
     * @example base
     *
     * @var string
     */
    public $viewEntityCode;
    protected $_name = [
        'bizUK'          => 'bizUK',
        'maxResults'     => 'maxResults',
        'nextToken'      => 'nextToken',
        'optUserId'      => 'optUserId',
        'queryParams'    => 'queryParams',
        'relationIds'    => 'relationIds',
        'scopeCode'      => 'scopeCode',
        'tenantId'       => 'tenantId',
        'viewEntityCode' => 'viewEntityCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizUK) {
            $res['bizUK'] = $this->bizUK;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->optUserId) {
            $res['optUserId'] = $this->optUserId;
        }
        if (null !== $this->queryParams) {
            $res['queryParams'] = [];
            if (null !== $this->queryParams && \is_array($this->queryParams)) {
                $n = 0;
                foreach ($this->queryParams as $item) {
                    $res['queryParams'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->relationIds) {
            $res['relationIds'] = $this->relationIds;
        }
        if (null !== $this->scopeCode) {
            $res['scopeCode'] = $this->scopeCode;
        }
        if (null !== $this->tenantId) {
            $res['tenantId'] = $this->tenantId;
        }
        if (null !== $this->viewEntityCode) {
            $res['viewEntityCode'] = $this->viewEntityCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MasterDataQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizUK'])) {
            $model->bizUK = $map['bizUK'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['optUserId'])) {
            $model->optUserId = $map['optUserId'];
        }
        if (isset($map['queryParams'])) {
            if (!empty($map['queryParams'])) {
                $model->queryParams = [];
                $n                  = 0;
                foreach ($map['queryParams'] as $item) {
                    $model->queryParams[$n++] = null !== $item ? queryParams::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['relationIds'])) {
            if (!empty($map['relationIds'])) {
                $model->relationIds = $map['relationIds'];
            }
        }
        if (isset($map['scopeCode'])) {
            $model->scopeCode = $map['scopeCode'];
        }
        if (isset($map['tenantId'])) {
            $model->tenantId = $map['tenantId'];
        }
        if (isset($map['viewEntityCode'])) {
            $model->viewEntityCode = $map['viewEntityCode'];
        }

        return $model;
    }
}
