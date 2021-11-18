<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\StartCoursePrepareResponseBody;

use AlibabaCloud\Tea\Model;

class universityCourseCommonResponse extends Model
{
    /**
     * @description 调用是否成功
     *
     * @var bool
     */
    public $success;

    /**
     * @description 课程编码
     *
     * @var string
     */
    public $courseCode;
    protected $_name = [
        'success'    => 'success',
        'courseCode' => 'courseCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->courseCode) {
            $res['courseCode'] = $this->courseCode;
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
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['courseCode'])) {
            $model->courseCode = $map['courseCode'];
        }

        return $model;
    }
}
