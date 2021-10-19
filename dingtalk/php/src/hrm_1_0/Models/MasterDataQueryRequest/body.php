<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string
     */
    public $scopeCode;

    /**
     * @var string
     */
    public $viewEntityCode;

    /**
     * @var int
     */
    public $tenantId;

    /**
     * @var string
     */
    public $bizUK;

    /**
     * @var string[]
     */
    public $relationIds;

    /**
     * @var string
     */
    public $optUserId;

    /**
     * @var int
     */
    public $nextToken;

    /**
     * @var int
     */
    public $maxResults;
    protected $_name = [
        'scopeCode'      => 'scopeCode',
        'viewEntityCode' => 'viewEntityCode',
        'tenantId'       => 'tenantId',
        'bizUK'          => 'bizUK',
        'relationIds'    => 'relationIds',
        'optUserId'      => 'optUserId',
        'nextToken'      => 'nextToken',
        'maxResults'     => 'maxResults',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
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

        return $model;
    }
}
