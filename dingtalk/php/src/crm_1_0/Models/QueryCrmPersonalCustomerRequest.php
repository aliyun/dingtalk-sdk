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
     * @description 分页条数
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页页码
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 查询条件
     *
     * @var string
     */
    public $queryDsl;

    /**
     * @var string
     */
    public $relationType;
    protected $_name = [
        'currentOperatorUserId' => 'currentOperatorUserId',
        'maxResults'            => 'maxResults',
        'nextToken'             => 'nextToken',
        'queryDsl'              => 'queryDsl',
        'relationType'          => 'relationType',
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
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->queryDsl) {
            $res['queryDsl'] = $this->queryDsl;
        }
        if (null !== $this->relationType) {
            $res['relationType'] = $this->relationType;
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
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['queryDsl'])) {
            $model->queryDsl = $map['queryDsl'];
        }
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }

        return $model;
    }
}
