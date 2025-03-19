<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateCourseRequest\courseDetailItemList;

use AlibabaCloud\Tea\Model;

class teacherList extends Model
{
    /**
     * @example 李老师
     *
     * @var string
     */
    public $teacherName;

    /**
     * @example staff_xxx
     *
     * @var string
     */
    public $teacherUserId;
    protected $_name = [
        'teacherName' => 'teacherName',
        'teacherUserId' => 'teacherUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->teacherName) {
            $res['teacherName'] = $this->teacherName;
        }
        if (null !== $this->teacherUserId) {
            $res['teacherUserId'] = $this->teacherUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return teacherList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['teacherName'])) {
            $model->teacherName = $map['teacherName'];
        }
        if (isset($map['teacherUserId'])) {
            $model->teacherUserId = $map['teacherUserId'];
        }

        return $model;
    }
}
