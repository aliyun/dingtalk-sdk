<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportPromEvalRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string
     */
    public $comment;

    /**
     * @var string
     */
    public $effectiveDate;

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
    public $newJobLevel;

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
    public $preJobLevel;

    /**
     * @var string
     */
    public $workNo;
    protected $_name = [
        'comment'         => 'comment',
        'effectiveDate'   => 'effectiveDate',
        'extendInfo'      => 'extendInfo',
        'name'            => 'name',
        'newJobLevel'     => 'newJobLevel',
        'period'          => 'period',
        'periodEndDate'   => 'periodEndDate',
        'periodStartDate' => 'periodStartDate',
        'preJobLevel'     => 'preJobLevel',
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
        if (null !== $this->effectiveDate) {
            $res['effectiveDate'] = $this->effectiveDate;
        }
        if (null !== $this->extendInfo) {
            $res['extendInfo'] = $this->extendInfo;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->newJobLevel) {
            $res['newJobLevel'] = $this->newJobLevel;
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
        if (null !== $this->preJobLevel) {
            $res['preJobLevel'] = $this->preJobLevel;
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
        if (isset($map['effectiveDate'])) {
            $model->effectiveDate = $map['effectiveDate'];
        }
        if (isset($map['extendInfo'])) {
            $model->extendInfo = $map['extendInfo'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['newJobLevel'])) {
            $model->newJobLevel = $map['newJobLevel'];
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
        if (isset($map['preJobLevel'])) {
            $model->preJobLevel = $map['preJobLevel'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
