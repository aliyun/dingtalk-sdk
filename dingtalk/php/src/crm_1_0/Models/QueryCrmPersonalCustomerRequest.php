<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCrmPersonalCustomerRequest extends Model
{
    /**
     * @description 用户ID
     *
     * @var string
     */
    public $currentOperatorUserId;

    /**
     * @var string
     */
    public $relationType;

    /**
     * @description 分页页码
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 分页条数
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 查询条件
     *
     * @var string
     */
    public $queryDsl;
    protected $_name = [
        'currentOperatorUserId' => 'currentOperatorUserId',
        'relationType'          => 'relationType',
        'nextToken'             => 'nextToken',
        'maxResults'            => 'maxResults',
        'queryDsl'              => 'queryDsl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->currentOperatorUserId) {
            $res['currentOperatorUserId'] = $this->currentOperatorUserId;
        }
        if (null !== $this->relationType) {
            $res['relationType'] = $this->relationType;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->queryDsl) {
            $res['queryDsl'] = $this->queryDsl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCrmPersonalCustomerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['currentOperatorUserId'])) {
            $model->currentOperatorUserId = $map['currentOperatorUserId'];
        }
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['queryDsl'])) {
            $model->queryDsl = $map['queryDsl'];
        }

        return $model;
    }
}
