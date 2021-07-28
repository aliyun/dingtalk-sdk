<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryClassScheduleConfigShrinkRequest extends Model
{
    /**
     * @description 课程id列表
     *
     * @var string
     */
    public $classIdsShrink;

    /**
     * @description 操作者的UserID
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'classIdsShrink' => 'classIds',
        'opUserId'       => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classIdsShrink) {
            $res['classIds'] = $this->classIdsShrink;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryClassScheduleConfigShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classIds'])) {
            $model->classIdsShrink = $map['classIds'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
