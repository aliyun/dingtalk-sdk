<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportPerfEvalRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string
     */
    public $comment;

    /**
     * @var mixed[]
     */
    public $extendInfo;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $perfCate;

    /**
     * @var string
     */
    public $perfPlanName;

    /**
     * @var string
     */
    public $perfScore;

    /**
     * @var string
     */
    public $period;

    /**
     * @var string
     */
    public $periodEndDate;

    /**
     * @var string
     */
    public $periodStartDate;

    /**
     * @var string
     */
    public $score;

    /**
     * @var string
     */
    public $workNo;
    protected $_name = [
        'comment'         => 'comment',
        'extendInfo'      => 'extendInfo',
        'name'            => 'name',
        'perfCate'        => 'perfCate',
        'perfPlanName'    => 'perfPlanName',
        'perfScore'       => 'perfScore',
        'period'          => 'period',
        'periodEndDate'   => 'periodEndDate',
        'periodStartDate' => 'periodStartDate',
        'score'           => 'score',
        'workNo'          => 'workNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->comment) {
            $res['comment'] = $this->comment;
        }
        if (null !== $this->extendInfo) {
            $res['extendInfo'] = $this->extendInfo;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->perfCate) {
            $res['perfCate'] = $this->perfCate;
        }
        if (null !== $this->perfPlanName) {
            $res['perfPlanName'] = $this->perfPlanName;
        }
        if (null !== $this->perfScore) {
            $res['perfScore'] = $this->perfScore;
        }
        if (null !== $this->period) {
            $res['period'] = $this->period;
        }
        if (null !== $this->periodEndDate) {
            $res['periodEndDate'] = $this->periodEndDate;
        }
        if (null !== $this->periodStartDate) {
            $res['periodStartDate'] = $this->periodStartDate;
        }
        if (null !== $this->score) {
            $res['score'] = $this->score;
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['comment'])) {
            $model->comment = $map['comment'];
        }
        if (isset($map['extendInfo'])) {
            $model->extendInfo = $map['extendInfo'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['perfCate'])) {
            $model->perfCate = $map['perfCate'];
        }
        if (isset($map['perfPlanName'])) {
            $model->perfPlanName = $map['perfPlanName'];
        }
        if (isset($map['perfScore'])) {
            $model->perfScore = $map['perfScore'];
        }
        if (isset($map['period'])) {
            $model->period = $map['period'];
        }
        if (isset($map['periodEndDate'])) {
            $model->periodEndDate = $map['periodEndDate'];
        }
        if (isset($map['periodStartDate'])) {
            $model->periodStartDate = $map['periodStartDate'];
        }
        if (isset($map['score'])) {
            $model->score = $map['score'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
