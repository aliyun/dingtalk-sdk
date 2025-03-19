<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateTeacherCourseRequest;

use AlibabaCloud\Tea\Model;

class teacherCourseDetailItemList extends Model
{
    /**
     * @example {"key":"value"}
     *
     * @var string
     */
    public $attributes;

    /**
     * @example courseIdxxx
     *
     * @var string
     */
    public $isvCourseId;
    protected $_name = [
        'attributes' => 'attributes',
        'isvCourseId' => 'isvCourseId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->attributes) {
            $res['attributes'] = $this->attributes;
        }
        if (null !== $this->isvCourseId) {
            $res['isvCourseId'] = $this->isvCourseId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return teacherCourseDetailItemList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attributes'])) {
            $model->attributes = $map['attributes'];
        }
        if (isset($map['isvCourseId'])) {
            $model->isvCourseId = $map['isvCourseId'];
        }

        return $model;
    }
}
