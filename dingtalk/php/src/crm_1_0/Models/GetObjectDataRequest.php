<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetObjectDataRequest extends Model
{
    /**
     * @example ding_userid
     *
     * @var string
     */
    public $currentOperatorUserId;

    /**
     * @description This parameter is required.
     *
     * @example 100
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description This parameter is required.
     *
     * @example PROC-EF199CCA-8AB6-482A-AE10-85EDE5E391D9
     *
     * @var string
     */
    public $name;

    /**
     * @example 0
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example {"queryGroupList":[{"logicType":"AND","queryObjectList":[{"fieldId":"contact_phone","value":"18000000000"},{"fieldId":"contact_related_customer","value":"INST-XXX"}]}]}
     *
     * @var string
     */
    public $queryDsl;
    protected $_name = [
        'currentOperatorUserId' => 'currentOperatorUserId',
        'maxResults' => 'maxResults',
        'name' => 'name',
        'nextToken' => 'nextToken',
        'queryDsl' => 'queryDsl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->currentOperatorUserId) {
            $res['currentOperatorUserId'] = $this->currentOperatorUserId;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->queryDsl) {
            $res['queryDsl'] = $this->queryDsl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetObjectDataRequest
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['queryDsl'])) {
            $model->queryDsl = $map['queryDsl'];
        }

        return $model;
    }
}
