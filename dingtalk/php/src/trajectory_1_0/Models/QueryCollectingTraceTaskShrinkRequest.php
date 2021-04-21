<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCollectingTraceTaskShrinkRequest extends Model
{
    /**
     * @description 员工用户ID
     *
     * @var string
     */
    public $staffIdsShrink;
    protected $_name = [
        'staffIdsShrink' => 'staffIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->staffIdsShrink) {
            $res['staffIds'] = $this->staffIdsShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCollectingTraceTaskShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['staffIds'])) {
            $model->staffIdsShrink = $map['staffIds'];
        }

        return $model;
    }
}
