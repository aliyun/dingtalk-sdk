<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryExternalAuthControlledSheetsRequest extends Model
{
    /**
     * @var string
     */
    public $externalAuthType;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;

    /**
     * @var int
     */
    public $pageSize;
    protected $_name = [
        'externalAuthType' => 'externalAuthType',
        'nextToken' => 'nextToken',
        'operatorId' => 'operatorId',
        'pageSize' => 'pageSize',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->externalAuthType) {
            $res['externalAuthType'] = $this->externalAuthType;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryExternalAuthControlledSheetsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['externalAuthType'])) {
            $model->externalAuthType = $map['externalAuthType'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }

        return $model;
    }
}
