<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdatePrivacyRequest extends Model
{
    /**
     * @description 权限修改的类型
     *
     * @var string
     */
    public $privacy;

    /**
     * @description 当前目标的 ID
     *
     * @var string
     */
    public $targetId;

    /**
     * @description 当前目标的权限类型。
     *
     * @var string
     */
    public $targetType;

    /**
     * @description 当前用户的userId。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'privacy'    => 'privacy',
        'targetId'   => 'targetId',
        'targetType' => 'targetType',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->privacy) {
            $res['privacy'] = $this->privacy;
        }
        if (null !== $this->targetId) {
            $res['targetId'] = $this->targetId;
        }
        if (null !== $this->targetType) {
            $res['targetType'] = $this->targetType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdatePrivacyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['privacy'])) {
            $model->privacy = $map['privacy'];
        }
        if (isset($map['targetId'])) {
            $model->targetId = $map['targetId'];
        }
        if (isset($map['targetType'])) {
            $model->targetType = $map['targetType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
