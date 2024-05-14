<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetATManageScopeRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 50
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description This parameter is required.
     *
     * @example user01
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'userId'     => 'userId',
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
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetATManageScopeRequest
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
