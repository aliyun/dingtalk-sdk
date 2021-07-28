<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassRequest\courses;
use AlibabaCloud\Tea\Model;

class UpdateCoursesOfClassRequest extends Model
{
    /**
     * @var courses[]
     */
    public $courses;

    /**
     * @description 操作者id
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'courses'  => 'courses',
        'opUserId' => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->courses) {
            $res['courses'] = [];
            if (null !== $this->courses && \is_array($this->courses)) {
                $n = 0;
                foreach ($this->courses as $item) {
                    $res['courses'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateCoursesOfClassRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['courses'])) {
            if (!empty($map['courses'])) {
                $model->courses = [];
                $n              = 0;
                foreach ($map['courses'] as $item) {
                    $model->courses[$n++] = null !== $item ? courses::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
