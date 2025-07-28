<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCollegeContactSceneStruResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 20
     *
     * @var int
     */
    public $struId;

    /**
     * @example 20
     *
     * @var int
     */
    public $studentDeptId;

    /**
     * @example 20
     *
     * @var int
     */
    public $teacherDeptId;
    protected $_name = [
        'struId' => 'struId',
        'studentDeptId' => 'studentDeptId',
        'teacherDeptId' => 'teacherDeptId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->struId) {
            $res['struId'] = $this->struId;
        }
        if (null !== $this->studentDeptId) {
            $res['studentDeptId'] = $this->studentDeptId;
        }
        if (null !== $this->teacherDeptId) {
            $res['teacherDeptId'] = $this->teacherDeptId;
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
        if (isset($map['struId'])) {
            $model->struId = $map['struId'];
        }
        if (isset($map['studentDeptId'])) {
            $model->studentDeptId = $map['studentDeptId'];
        }
        if (isset($map['teacherDeptId'])) {
            $model->teacherDeptId = $map['teacherDeptId'];
        }

        return $model;
    }
}
