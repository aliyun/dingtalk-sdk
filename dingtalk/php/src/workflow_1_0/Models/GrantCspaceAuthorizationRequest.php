<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class GrantCspaceAuthorizationRequest extends Model
{
    /**
     * @description 权限有效时间，单位为秒。
     *
     * @var int
     */
    public $durationSeconds;

    /**
     * @description 审批控件 id。
     *
     * @var string
     */
    public $spaceId;

    /**
     * @description 权限类型。
     *
     * @var string
     */
    public $type;

    /**
     * @description 用户 id。
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
