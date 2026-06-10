<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryOrgCorrectTaskDetailRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $endTime;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $pageNo;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description This parameter is required.
     *
     * @example ding26d260744657eb6378f
     *
     * @var string
     */
    public $queryCorpId;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $startTime;

    /**
     * @example math
     *
     * @var string
     */
    public $subjectCode;
    protected $_name = [
        'endTime' => 'endTime',
        'pageNo' => 'pageNo',
        'pageSize' => 'pageSize',
        'queryCorpId' => 'queryCorpId',
        'startTime' => 'startTime',
        'subjectCode' => 'subjectCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->pageNo) {
            $res['pageNo'] = $this->pageNo;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->queryCorpId) {
            $res['queryCorpId'] = $this->queryCorpId;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->subjectCode) {
            $res['subjectCode'] = $this->subjectCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryOrgCorrectTaskDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['pageNo'])) {
            $model->pageNo = $map['pageNo'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['queryCorpId'])) {
            $model->queryCorpId = $map['queryCorpId'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['subjectCode'])) {
            $model->subjectCode = $map['subjectCode'];
        }

        return $model;
    }
}
