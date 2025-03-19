<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetTaskStudentListResponseBody;

use AlibabaCloud\Tea\Model;

class studentList extends Model
{
    /**
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @example F
     *
     * @var string
     */
    public $sexuality;

    /**
     * @example 675656
     *
     * @var int
     */
    public $studentId;
    protected $_name = [
        'name' => 'name',
        'sexuality' => 'sexuality',
        'studentId' => 'studentId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->sexuality) {
            $res['sexuality'] = $this->sexuality;
        }
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return studentList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['sexuality'])) {
            $model->sexuality = $map['sexuality'];
        }
        if (isset($map['studentId'])) {
            $model->studentId = $map['studentId'];
        }

        return $model;
    }
}
