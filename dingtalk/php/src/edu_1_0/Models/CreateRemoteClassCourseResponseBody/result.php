<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateRemoteClassCourseResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 课程码
     *
     * @var string
     */
    public $courseCode;
    protected $_name = [
        'courseCode' => 'courseCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->courseCode) {
            $res['courseCode'] = $this->courseCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['courseCode'])) {
            $model->courseCode = $map['courseCode'];
        }

        return $model;
    }
}
