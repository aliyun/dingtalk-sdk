<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\StartCoursePrepareResponseBody;

use AlibabaCloud\Tea\Model;

class universityCourseCommonResponse extends Model
{
    /**
     * @description 课程编码
     *
     * @var string
     */
    public $courseCode;

    /**
     * @description 调用是否成功
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'courseCode' => 'courseCode',
        'success'    => 'success',
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
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return universityCourseCommonResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['courseCode'])) {
            $model->courseCode = $map['courseCode'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
