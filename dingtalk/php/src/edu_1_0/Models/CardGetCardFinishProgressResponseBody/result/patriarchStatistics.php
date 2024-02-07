<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardGetCardFinishProgressResponseBody\result;

use AlibabaCloud\Tea\Model;

class patriarchStatistics extends Model
{
    /**
     * @example CARD_TASK_CODE_0
     *
     * @var string
     */
    public $cardTaskCode;

    /**
     * @example 2023-11-01
     *
     * @var string
     */
    public $date;

    /**
     * @var bool
     */
    public $isFinished;

    /**
     * @var bool
     */
    public $isFinishedByReissueCard;

    /**
     * @var bool
     */
    public $isLastDay;

    /**
     * @var bool
     */
    public $reissueCard;

    /**
     * @example 23424234
     *
     * @var string
     */
    public $studentId;

    /**
     * @example 李四
     *
     * @var string
     */
    public $studentName;

    /**
     * @example 2023-11-01
     *
     * @var string
     */
    public $today;

    /**
     * @example 234234234
     *
     * @var int
     */
    public $userSubTaskId;
    protected $_name = [
        'cardTaskCode'            => 'cardTaskCode',
        'date'                    => 'date',
        'isFinished'              => 'isFinished',
        'isFinishedByReissueCard' => 'isFinishedByReissueCard',
        'isLastDay'               => 'isLastDay',
        'reissueCard'             => 'reissueCard',
        'studentId'               => 'studentId',
        'studentName'             => 'studentName',
        'today'                   => 'today',
        'userSubTaskId'           => 'userSubTaskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardTaskCode) {
            $res['cardTaskCode'] = $this->cardTaskCode;
        }
        if (null !== $this->date) {
            $res['date'] = $this->date;
        }
        if (null !== $this->isFinished) {
            $res['isFinished'] = $this->isFinished;
        }
        if (null !== $this->isFinishedByReissueCard) {
            $res['isFinishedByReissueCard'] = $this->isFinishedByReissueCard;
        }
        if (null !== $this->isLastDay) {
            $res['isLastDay'] = $this->isLastDay;
        }
        if (null !== $this->reissueCard) {
            $res['reissueCard'] = $this->reissueCard;
        }
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
        }
        if (null !== $this->studentName) {
            $res['studentName'] = $this->studentName;
        }
        if (null !== $this->today) {
            $res['today'] = $this->today;
        }
        if (null !== $this->userSubTaskId) {
            $res['userSubTaskId'] = $this->userSubTaskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return patriarchStatistics
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardTaskCode'])) {
            $model->cardTaskCode = $map['cardTaskCode'];
        }
        if (isset($map['date'])) {
            $model->date = $map['date'];
        }
        if (isset($map['isFinished'])) {
            $model->isFinished = $map['isFinished'];
        }
        if (isset($map['isFinishedByReissueCard'])) {
            $model->isFinishedByReissueCard = $map['isFinishedByReissueCard'];
        }
        if (isset($map['isLastDay'])) {
            $model->isLastDay = $map['isLastDay'];
        }
        if (isset($map['reissueCard'])) {
            $model->reissueCard = $map['reissueCard'];
        }
        if (isset($map['studentId'])) {
            $model->studentId = $map['studentId'];
        }
        if (isset($map['studentName'])) {
            $model->studentName = $map['studentName'];
        }
        if (isset($map['today'])) {
            $model->today = $map['today'];
        }
        if (isset($map['userSubTaskId'])) {
            $model->userSubTaskId = $map['userSubTaskId'];
        }

        return $model;
    }
}
