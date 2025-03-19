<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchInvalidCourseRequest extends Model
{
    /**
     * @example class_xxx
     *
     * @var string
     */
    public $classId;

    /**
     * @example dingxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example ISV_XXX
     *
     * @var string
     */
    public $isvCode;

    /**
     * @example courseId
     *
     * @var string
     */
    public $isvCourseId;

    /**
     * @var string[]
     */
    public $isvCourseIds;
    protected $_name = [
        'classId' => 'classId',
        'corpId' => 'corpId',
        'isvCode' => 'isvCode',
        'isvCourseId' => 'isvCourseId',
        'isvCourseIds' => 'isvCourseIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }
        if (null !== $this->isvCourseId) {
            $res['isvCourseId'] = $this->isvCourseId;
        }
        if (null !== $this->isvCourseIds) {
            $res['isvCourseIds'] = $this->isvCourseIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchInvalidCourseRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }
        if (isset($map['isvCourseId'])) {
            $model->isvCourseId = $map['isvCourseId'];
        }
        if (isset($map['isvCourseIds'])) {
            if (!empty($map['isvCourseIds'])) {
                $model->isvCourseIds = $map['isvCourseIds'];
            }
        }

        return $model;
    }
}
