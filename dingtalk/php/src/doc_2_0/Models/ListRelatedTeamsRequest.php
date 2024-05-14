<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class ListRelatedTeamsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example ajYkbc7
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description This parameter is required.
     *
     * @example YEp3JcM******UIbhwiE
     *
     * @var string
     */
    public $operatorId;

    /**
     * @example 0
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'operatorId' => 'operatorId',
        'type'       => 'type',
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
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListRelatedTeamsRequest
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
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
