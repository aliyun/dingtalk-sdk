<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdatePrivacyRequest extends Model
{
    /**
     * @example public
     *
     * @var string
     */
    public $privacy;

    /**
     * @example 3RF5
     *
     * @var string
     */
    public $targetId;

    /**
     * @example 2
     *
     * @var string
     */
    public $targetType;

    /**
     * @example 0115396701752283
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
