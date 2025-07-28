<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetContactsRequest extends Model
{
    /**
     * @example user01
     *
     * @var string
     */
    public $currentOperatorUserId;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 0
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example crm_contact
     *
     * @var string
     */
    public $objectType;

    /**
     * @example dingxxx
     *
     * @var string
     */
    public $providerCorpId;

    /**
     * @example {"queryGroupList":[{"logicType":"AND","queryObjectList":[{"fieldId":"contact_phone","value":"18000000000"},{"fieldId":"contact_related_customer","value":"INST-XXX"}]}]}
     *
     * @var string
     */
    public $queryDsl;
    protected $_name = [
        'currentOperatorUserId' => 'currentOperatorUserId',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'objectType' => 'objectType',
        'providerCorpId' => 'providerCorpId',
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
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->objectType) {
            $res['objectType'] = $this->objectType;
        }
        if (null !== $this->providerCorpId) {
            $res['providerCorpId'] = $this->providerCorpId;
        }
        if (null !== $this->queryDsl) {
            $res['queryDsl'] = $this->queryDsl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetContactsRequest
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
        if (isset($map['objectType'])) {
            $model->objectType = $map['objectType'];
        }
        if (isset($map['providerCorpId'])) {
            $model->providerCorpId = $map['providerCorpId'];
        }
        if (isset($map['queryDsl'])) {
            $model->queryDsl = $map['queryDsl'];
        }

        return $model;
    }
}
