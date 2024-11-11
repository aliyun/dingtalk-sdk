<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTransferCourseResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example {""}
     *
     * @var string
     */
    public $attributes;

    /**
     * @example classIdx
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
     * @example ding_xxx
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
     * @example record_xxx
     *
     * @var string
     */
    public $isvRecordId;

    /**
     * @example srcCode
     *
     * @var string
     */
    public $srcCourseCode;

    /**
     * @example 0
     *
     * @var int
     */
    public $srcCourseDate;

    /**
     * @example srcName
     *
     * @var string
     */
    public $srcCourseName;

    /**
     * @example srcId
     *
     * @var string
     */
    public $srcIsvCourseId;

    /**
     * @example 第一节
     *
     * @var string
     */
    public $srcTimeslotName;

    /**
     * @example 1
     *
     * @var int
     */
    public $srcTimeslotNum;

    /**
     * @example tarCode
     *
     * @var string
     */
    public $tarCourseCode;

    /**
     * @example 0
     *
     * @var int
     */
    public $tarCourseDate;

    /**
     * @example tarName
     *
     * @var string
     */
    public $tarCourseName;

    /**
     * @example tarId
     *
     * @var string
     */
    public $tarIsvCourseId;

    /**
     * @example 第一节
     *
     * @var string
     */
    public $tarTimeslotName;

    /**
     * @example 1
     *
     * @var int
     */
    public $tarTimeslotNum;
    protected $_name = [
        'attributes'      => 'attributes',
        'classId'         => 'classId',
        'className'       => 'className',
        'corpId'          => 'corpId',
        'isvCode'         => 'isvCode',
        'isvRecordId'     => 'isvRecordId',
        'srcCourseCode'   => 'srcCourseCode',
        'srcCourseDate'   => 'srcCourseDate',
        'srcCourseName'   => 'srcCourseName',
        'srcIsvCourseId'  => 'srcIsvCourseId',
        'srcTimeslotName' => 'srcTimeslotName',
        'srcTimeslotNum'  => 'srcTimeslotNum',
        'tarCourseCode'   => 'tarCourseCode',
        'tarCourseDate'   => 'tarCourseDate',
        'tarCourseName'   => 'tarCourseName',
        'tarIsvCourseId'  => 'tarIsvCourseId',
        'tarTimeslotName' => 'tarTimeslotName',
        'tarTimeslotNum'  => 'tarTimeslotNum',
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
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }
        if (null !== $this->isvRecordId) {
            $res['isvRecordId'] = $this->isvRecordId;
        }
        if (null !== $this->srcCourseCode) {
            $res['srcCourseCode'] = $this->srcCourseCode;
        }
        if (null !== $this->srcCourseDate) {
            $res['srcCourseDate'] = $this->srcCourseDate;
        }
        if (null !== $this->srcCourseName) {
            $res['srcCourseName'] = $this->srcCourseName;
        }
        if (null !== $this->srcIsvCourseId) {
            $res['srcIsvCourseId'] = $this->srcIsvCourseId;
        }
        if (null !== $this->srcTimeslotName) {
            $res['srcTimeslotName'] = $this->srcTimeslotName;
        }
        if (null !== $this->srcTimeslotNum) {
            $res['srcTimeslotNum'] = $this->srcTimeslotNum;
        }
        if (null !== $this->tarCourseCode) {
            $res['tarCourseCode'] = $this->tarCourseCode;
        }
        if (null !== $this->tarCourseDate) {
            $res['tarCourseDate'] = $this->tarCourseDate;
        }
        if (null !== $this->tarCourseName) {
            $res['tarCourseName'] = $this->tarCourseName;
        }
        if (null !== $this->tarIsvCourseId) {
            $res['tarIsvCourseId'] = $this->tarIsvCourseId;
        }
        if (null !== $this->tarTimeslotName) {
            $res['tarTimeslotName'] = $this->tarTimeslotName;
        }
        if (null !== $this->tarTimeslotNum) {
            $res['tarTimeslotNum'] = $this->tarTimeslotNum;
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
        if (isset($map['attributes'])) {
            $model->attributes = $map['attributes'];
        }
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['className'])) {
            $model->className = $map['className'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }
        if (isset($map['isvRecordId'])) {
            $model->isvRecordId = $map['isvRecordId'];
        }
        if (isset($map['srcCourseCode'])) {
            $model->srcCourseCode = $map['srcCourseCode'];
        }
        if (isset($map['srcCourseDate'])) {
            $model->srcCourseDate = $map['srcCourseDate'];
        }
        if (isset($map['srcCourseName'])) {
            $model->srcCourseName = $map['srcCourseName'];
        }
        if (isset($map['srcIsvCourseId'])) {
            $model->srcIsvCourseId = $map['srcIsvCourseId'];
        }
        if (isset($map['srcTimeslotName'])) {
            $model->srcTimeslotName = $map['srcTimeslotName'];
        }
        if (isset($map['srcTimeslotNum'])) {
            $model->srcTimeslotNum = $map['srcTimeslotNum'];
        }
        if (isset($map['tarCourseCode'])) {
            $model->tarCourseCode = $map['tarCourseCode'];
        }
        if (isset($map['tarCourseDate'])) {
            $model->tarCourseDate = $map['tarCourseDate'];
        }
        if (isset($map['tarCourseName'])) {
            $model->tarCourseName = $map['tarCourseName'];
        }
        if (isset($map['tarIsvCourseId'])) {
            $model->tarIsvCourseId = $map['tarIsvCourseId'];
        }
        if (isset($map['tarTimeslotName'])) {
            $model->tarTimeslotName = $map['tarTimeslotName'];
        }
        if (isset($map['tarTimeslotNum'])) {
            $model->tarTimeslotNum = $map['tarTimeslotNum'];
        }

        return $model;
    }
}
