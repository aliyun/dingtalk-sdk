<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class PageQueryClassCourseRequest extends Model
{
    /**
     * @example classId_xxx
     *
     * @var string
     */
    public $classId;

    /**
     * @example ding_xxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 0
     *
     * @var int
     */
    public $endCourseDate;

    /**
     * @example ISV_XXX
     *
     * @var string
     */
    public $isvCode;

    /**
     * @example 0
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 20
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example 0
     *
     * @var int
     */
    public $startCourseDate;
    protected $_name = [
        'classId'         => 'classId',
        'corpId'          => 'corpId',
        'endCourseDate'   => 'endCourseDate',
        'isvCode'         => 'isvCode',
        'pageNumber'      => 'pageNumber',
        'pageSize'        => 'pageSize',
        'startCourseDate' => 'startCourseDate',
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
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->endCourseDate) {
            $res['endCourseDate'] = $this->endCourseDate;
        }
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->startCourseDate) {
            $res['startCourseDate'] = $this->startCourseDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PageQueryClassCourseRequest
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
        if (isset($map['endCourseDate'])) {
            $model->endCourseDate = $map['endCourseDate'];
        }
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['startCourseDate'])) {
            $model->startCourseDate = $map['startCourseDate'];
        }

        return $model;
    }
}
