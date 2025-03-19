<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateStudentClassRequest\studentList;
use AlibabaCloud\Tea\Model;

class BatchCreateStudentClassRequest extends Model
{
    /**
     * @example classxxx
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
     * @var studentList[]
     */
    public $studentList;
    protected $_name = [
        'classId' => 'classId',
        'className' => 'className',
        'classType' => 'classType',
        'corpId' => 'corpId',
        'isvCode' => 'isvCode',
        'studentList' => 'studentList',
    ];

    public function validate() {}

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
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }
        if (null !== $this->studentList) {
            $res['studentList'] = [];
            if (null !== $this->studentList && \is_array($this->studentList)) {
                $n = 0;
                foreach ($this->studentList as $item) {
                    $res['studentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchCreateStudentClassRequest
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
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }
        if (isset($map['studentList'])) {
            if (!empty($map['studentList'])) {
                $model->studentList = [];
                $n = 0;
                foreach ($map['studentList'] as $item) {
                    $model->studentList[$n++] = null !== $item ? studentList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
