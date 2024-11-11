<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateCourseRequest\courseDetailItemList;
use AlibabaCloud\Tea\Model;

class BatchCreateCourseRequest extends Model
{
    /**
     * @example class_xxx
     *
     * @var string
     */
    public $classId;

    /**
     * @example 一年级一班
     *
     * @var string
     */
    public $className;

    /**
     * @example 1
     *
     * @var int
     */
    public $classType;

    /**
     * @example ding_xxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @var courseDetailItemList[]
     */
    public $courseDetailItemList;

    /**
     * @example ISV_XXX
     *
     * @var string
     */
    public $isvCode;

    /**
     * @example 2024
     *
     * @var string
     */
    public $schoolYear;

    /**
     * @example 1
     *
     * @var int
     */
    public $semester;
    protected $_name = [
        'classId'              => 'classId',
        'className'            => 'className',
        'classType'            => 'classType',
        'corpId'               => 'corpId',
        'courseDetailItemList' => 'courseDetailItemList',
        'isvCode'              => 'isvCode',
        'schoolYear'           => 'schoolYear',
        'semester'             => 'semester',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->className) {
            $res['className'] = $this->className;
        }
        if (null !== $this->classType) {
            $res['classType'] = $this->classType;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->courseDetailItemList) {
            $res['courseDetailItemList'] = [];
            if (null !== $this->courseDetailItemList && \is_array($this->courseDetailItemList)) {
                $n = 0;
                foreach ($this->courseDetailItemList as $item) {
                    $res['courseDetailItemList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }
        if (null !== $this->schoolYear) {
            $res['schoolYear'] = $this->schoolYear;
        }
        if (null !== $this->semester) {
            $res['semester'] = $this->semester;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchCreateCourseRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['className'])) {
            $model->className = $map['className'];
        }
        if (isset($map['classType'])) {
            $model->classType = $map['classType'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['courseDetailItemList'])) {
            if (!empty($map['courseDetailItemList'])) {
                $model->courseDetailItemList = [];
                $n                           = 0;
                foreach ($map['courseDetailItemList'] as $item) {
                    $model->courseDetailItemList[$n++] = null !== $item ? courseDetailItemList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }
        if (isset($map['schoolYear'])) {
            $model->schoolYear = $map['schoolYear'];
        }
        if (isset($map['semester'])) {
            $model->semester = $map['semester'];
        }

        return $model;
    }
}
