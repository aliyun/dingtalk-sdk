<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAllCustomerRequest extends Model
{
    /**
     * @example 100
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 100010
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example crm_customer
     *
     * @var string
     */
    public $objectType;

    /**
     * @example ding_userid
     *
     * @var string
     */
    public $operatorUserId;
    protected $_name = [
        'maxResults'     => 'maxResults',
        'nextToken'      => 'nextToken',
        'objectType'     => 'objectType',
        'operatorUserId' => 'operatorUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->objectType) {
            $res['objectType'] = $this->objectType;
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAllCustomerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['objectType'])) {
            $model->objectType = $map['objectType'];
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }

        return $model;
    }
}
