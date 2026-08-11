<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result\risks\justiceRisk\subRisks\courtOpeningAnnouncement;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @var string
     */
    public $caseNo;

    /**
     * @var string
     */
    public $caseReason;

    /**
     * @var string
     */
    public $court;

    /**
     * @var string
     */
    public $startDate;
    protected $_name = [
        'caseNo' => 'caseNo',
        'caseReason' => 'caseReason',
        'court' => 'court',
        'startDate' => 'startDate',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->caseNo) {
            $res['caseNo'] = $this->caseNo;
        }
        if (null !== $this->caseReason) {
            $res['caseReason'] = $this->caseReason;
        }
        if (null !== $this->court) {
            $res['court'] = $this->court;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['caseNo'])) {
            $model->caseNo = $map['caseNo'];
        }
        if (isset($map['caseReason'])) {
            $model->caseReason = $map['caseReason'];
        }
        if (isset($map['court'])) {
            $model->court = $map['court'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }

        return $model;
    }
}
