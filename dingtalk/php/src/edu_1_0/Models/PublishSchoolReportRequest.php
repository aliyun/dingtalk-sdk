<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PublishSchoolReportRequest\classDetailItems;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PublishSchoolReportRequest\subjectList;
use AlibabaCloud\Tea\Model;

class PublishSchoolReportRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bizCode;

    /**
     * @var classDetailItems[]
     */
    public $classDetailItems;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $examClass;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $examTitle;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $identifier;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $publishScope;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $scoreType;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $share;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $showRank;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $showStatisticsScore;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $subScoreType;

    /**
     * @description This parameter is required.
     *
     * @var subjectList[]
     */
    public $subjectList;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $subjects;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $teacherId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $teacherName;
    protected $_name = [
        'bizCode' => 'bizCode',
        'classDetailItems' => 'classDetailItems',
        'examClass' => 'examClass',
        'examTitle' => 'examTitle',
        'identifier' => 'identifier',
        'publishScope' => 'publishScope',
        'scoreType' => 'scoreType',
        'share' => 'share',
        'showRank' => 'showRank',
        'showStatisticsScore' => 'showStatisticsScore',
        'subScoreType' => 'subScoreType',
        'subjectList' => 'subjectList',
        'subjects' => 'subjects',
        'teacherId' => 'teacherId',
        'teacherName' => 'teacherName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->classDetailItems) {
            $res['classDetailItems'] = [];
            if (null !== $this->classDetailItems && \is_array($this->classDetailItems)) {
                $n = 0;
                foreach ($this->classDetailItems as $item) {
                    $res['classDetailItems'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->examClass) {
            $res['examClass'] = $this->examClass;
        }
        if (null !== $this->examTitle) {
            $res['examTitle'] = $this->examTitle;
        }
        if (null !== $this->identifier) {
            $res['identifier'] = $this->identifier;
        }
        if (null !== $this->publishScope) {
            $res['publishScope'] = $this->publishScope;
        }
        if (null !== $this->scoreType) {
            $res['scoreType'] = $this->scoreType;
        }
        if (null !== $this->share) {
            $res['share'] = $this->share;
        }
        if (null !== $this->showRank) {
            $res['showRank'] = $this->showRank;
        }
        if (null !== $this->showStatisticsScore) {
            $res['showStatisticsScore'] = $this->showStatisticsScore;
        }
        if (null !== $this->subScoreType) {
            $res['subScoreType'] = $this->subScoreType;
        }
        if (null !== $this->subjectList) {
            $res['subjectList'] = [];
            if (null !== $this->subjectList && \is_array($this->subjectList)) {
                $n = 0;
                foreach ($this->subjectList as $item) {
                    $res['subjectList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->subjects) {
            $res['subjects'] = $this->subjects;
        }
        if (null !== $this->teacherId) {
            $res['teacherId'] = $this->teacherId;
        }
        if (null !== $this->teacherName) {
            $res['teacherName'] = $this->teacherName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PublishSchoolReportRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['classDetailItems'])) {
            if (!empty($map['classDetailItems'])) {
                $model->classDetailItems = [];
                $n = 0;
                foreach ($map['classDetailItems'] as $item) {
                    $model->classDetailItems[$n++] = null !== $item ? classDetailItems::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['examClass'])) {
            $model->examClass = $map['examClass'];
        }
        if (isset($map['examTitle'])) {
            $model->examTitle = $map['examTitle'];
        }
        if (isset($map['identifier'])) {
            $model->identifier = $map['identifier'];
        }
        if (isset($map['publishScope'])) {
            $model->publishScope = $map['publishScope'];
        }
        if (isset($map['scoreType'])) {
            $model->scoreType = $map['scoreType'];
        }
        if (isset($map['share'])) {
            $model->share = $map['share'];
        }
        if (isset($map['showRank'])) {
            $model->showRank = $map['showRank'];
        }
        if (isset($map['showStatisticsScore'])) {
            $model->showStatisticsScore = $map['showStatisticsScore'];
        }
        if (isset($map['subScoreType'])) {
            $model->subScoreType = $map['subScoreType'];
        }
        if (isset($map['subjectList'])) {
            if (!empty($map['subjectList'])) {
                $model->subjectList = [];
                $n = 0;
                foreach ($map['subjectList'] as $item) {
                    $model->subjectList[$n++] = null !== $item ? subjectList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['subjects'])) {
            $model->subjects = $map['subjects'];
        }
        if (isset($map['teacherId'])) {
            $model->teacherId = $map['teacherId'];
        }
        if (isset($map['teacherName'])) {
            $model->teacherName = $map['teacherName'];
        }

        return $model;
    }
}
