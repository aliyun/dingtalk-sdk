<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryRequest\queryParams;
use AlibabaCloud\Tea\Model;

class MasterDataQueryRequest extends Model
{
    /**
     * @description 领域code 由钉钉分配
     *
     * @var string
     */
    public $scopeCode;

    /**
     * @description 实体code
     *
     * @var string
     */
    public $viewEntityCode;

    /**
     * @description 数据生产方的租户id，由钉钉分配
     *
     * @var int
     */
    public $tenantId;

    /**
     * @description 数据唯一键
     *
     * @var string
     */
    public $bizUK;

    /**
     * @description 关联id列表，一般为userId
     *
     * @var string[]
     */
    public $relationIds;

    /**
     * @description 当前操作人userId
     *
     * @var string
     */
    public $optUserId;

    /**
     * @description 分页查询的游标
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 分页查询每页数据条数
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 其他查询条件
     *
     * @var queryParams[]
     */
    public $queryParams;
    protected $_name = [
        'scopeCode'      => 'scopeCode',
        'viewEntityCode' => 'viewEntityCode',
        'tenantId'       => 'tenantId',
        'bizUK'          => 'bizUK',
        'relationIds'    => 'relationIds',
        'optUserId'      => 'optUserId',
        'nextToken'      => 'nextToken',
        'maxResults'     => 'maxResults',
        'queryParams'    => 'queryParams',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->scopeCode) {
            $res['scopeCode'] = $this->scopeCode;
        }
        if (null !== $this->viewEntityCode) {
            $res['viewEntityCode'] = $this->viewEntityCode;
        }
        if (null !== $this->tenantId) {
            $res['tenantId'] = $this->tenantId;
        }
        if (null !== $this->bizUK) {
            $res['bizUK'] = $this->bizUK;
        }
        if (null !== $this->relationIds) {
            $res['relationIds'] = $this->relationIds;
        }
        if (null !== $this->optUserId) {
            $res['optUserId'] = $this->optUserId;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
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
        if (isset($map['scopeCode'])) {
            $model->scopeCode = $map['scopeCode'];
        }
        if (isset($map['viewEntityCode'])) {
            $model->viewEntityCode = $map['viewEntityCode'];
        }
        if (isset($map['tenantId'])) {
            $model->tenantId = $map['tenantId'];
        }
        if (isset($map['bizUK'])) {
            $model->bizUK = $map['bizUK'];
        }
        if (isset($map['relationIds'])) {
            if (!empty($map['relationIds'])) {
                $model->relationIds = $map['relationIds'];
            }
        }
        if (isset($map['optUserId'])) {
            $model->optUserId = $map['optUserId'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
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

        return $model;
    }
}
