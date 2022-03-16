<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPermissionRequest extends Model
{
    /**
     * @var string
     */
    public $targetId;

    /**
     * @var string
     */
    public $targetType;

    /**
     * @description A short description of struct
     *
     * @var string
     */
    public $userId;

    /**
     * @var bool
     */
    public $withKr;

    /**
     * @var bool
     */
    public $withObjective;
    protected $_name = [
        'targetId'      => 'targetId',
        'targetType'    => 'targetType',
        'userId'        => 'userId',
        'withKr'        => 'withKr',
        'withObjective' => 'withObjective',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->targetId) {
            $res['targetId'] = $this->targetId;
        }
        if (null !== $this->targetType) {
            $res['targetType'] = $this->targetType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->withKr) {
            $res['withKr'] = $this->withKr;
        }
        if (null !== $this->withObjective) {
            $res['withObjective'] = $this->withObjective;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPermissionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['targetId'])) {
            $model->targetId = $map['targetId'];
        }
        if (isset($map['targetType'])) {
            $model->targetType = $map['targetType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['withKr'])) {
            $model->withKr = $map['withKr'];
        }
        if (isset($map['withObjective'])) {
            $model->withObjective = $map['withObjective'];
        }

        return $model;
    }
}
