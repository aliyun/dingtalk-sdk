<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAllCustomerRequest extends Model
{
    /**
     * @description 翻页size
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页游标，第一次调用传空或者null
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 数据类型（私海个人客户：crm_customer_personal，私海企业客户：crm_customer，公海个人客户：open_customer_personal，公海企业客户：open_customer_org）
     *
     * @var string
     */
    public $objectType;

    /**
     * @description 用户ID
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
