<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListCommentsRequest extends Model
{
    /**
     * @var bool
     */
    public $isGlobal;

    /**
     * @var bool
     */
    public $isSolved;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @example next_token
     *
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
    protected $_name = [
        'isGlobal' => 'isGlobal',
        'isSolved' => 'isSolved',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->isGlobal) {
            $res['isGlobal'] = $this->isGlobal;
        }
        if (null !== $this->isSolved) {
            $res['isSolved'] = $this->isSolved;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListCommentsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isGlobal'])) {
            $model->isGlobal = $map['isGlobal'];
        }
        if (isset($map['isSolved'])) {
            $model->isSolved = $map['isSolved'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
