<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class EduListUserByFromUserIdsRequest extends Model
{
    /**
     * @var int
     */
    public $classId;

    /**
     * @example ding123456
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 123456
     *
     * @var string
     */
    public $guardianUserId;
    protected $_name = [
        'classId' => 'classId',
        'corpId' => 'corpId',
        'guardianUserId' => 'guardianUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->guardianUserId) {
            $res['guardianUserId'] = $this->guardianUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EduListUserByFromUserIdsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['guardianUserId'])) {
            $model->guardianUserId = $map['guardianUserId'];
        }

        return $model;
    }
}
