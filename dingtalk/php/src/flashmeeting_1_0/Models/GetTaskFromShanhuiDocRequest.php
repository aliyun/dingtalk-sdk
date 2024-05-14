<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetTaskFromShanhuiDocRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example gMp7ldNxoWbAqBQN
     *
     * @var string
     */
    public $docKey;

    /**
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 0
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description This parameter is required.
     *
     * @example DMvP2vrwe5QVUk0RcNb2FgiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'docKey'     => 'docKey',
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'unionId'    => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->docKey) {
            $res['docKey'] = $this->docKey;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTaskFromShanhuiDocRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['docKey'])) {
            $model->docKey = $map['docKey'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
