<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateStudentClassRequest extends Model
{
    /**
     * @example {"key":"value"}
     *
     * @var string
     */
    public $attributes;

    /**
     * @example classIdxxx
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
     * @example 0
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
     * @example 小明
     *
     * @var string
     */
    public $studentName;

    /**
     * @example staffxxx
     *
     * @var string
     */
    public $studentUserId;
    protected $_name = [
        'attributes'    => 'attributes',
        'classId'       => 'classId',
        'className'     => 'className',
        'classType'     => 'classType',
        'corpId'        => 'corpId',
        'isvCode'       => 'isvCode',
        'studentName'   => 'studentName',
        'studentUserId' => 'studentUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attributes) {
            $res['attributes'] = $this->attributes;
        }
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
        if (null !== $this->studentName) {
            $res['studentName'] = $this->studentName;
        }
        if (null !== $this->studentUserId) {
            $res['studentUserId'] = $this->studentUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateStudentClassRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attributes'])) {
            $model->attributes = $map['attributes'];
        }
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
        if (isset($map['studentName'])) {
            $model->studentName = $map['studentName'];
        }
        if (isset($map['studentUserId'])) {
            $model->studentUserId = $map['studentUserId'];
        }

        return $model;
    }
}
