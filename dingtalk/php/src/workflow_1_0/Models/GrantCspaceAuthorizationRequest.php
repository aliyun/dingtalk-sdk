<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class GrantCspaceAuthorizationRequest extends Model
{
    /**
     * @example 3600
     *
     * @var int
     */
    public $durationSeconds;

    /**
     * @description This parameter is required.
     *
     * @example 163xxxx658
     *
     * @var string
     */
    public $spaceId;

    /**
     * @description This parameter is required.
     *
     * @example add
     *
     * @var string
     */
    public $type;

    /**
     * @description This parameter is required.
     *
     * @example 26652461xxxx5992
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'durationSeconds' => 'durationSeconds',
        'spaceId'         => 'spaceId',
        'type'            => 'type',
        'userId'          => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->durationSeconds) {
            $res['durationSeconds'] = $this->durationSeconds;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GrantCspaceAuthorizationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['durationSeconds'])) {
            $model->durationSeconds = $map['durationSeconds'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
