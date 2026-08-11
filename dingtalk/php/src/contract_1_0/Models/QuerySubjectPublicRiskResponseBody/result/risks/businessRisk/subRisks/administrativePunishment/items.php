<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result\risks\businessRisk\subRisks\administrativePunishment;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $decisionDate;

    /**
     * @var string
     */
    public $departmentName;

    /**
     * @var string
     */
    public $punishNumber;

    /**
     * @var string
     */
    public $reason;
    protected $_name = [
        'content' => 'content',
        'decisionDate' => 'decisionDate',
        'departmentName' => 'departmentName',
        'punishNumber' => 'punishNumber',
        'reason' => 'reason',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->decisionDate) {
            $res['decisionDate'] = $this->decisionDate;
        }
        if (null !== $this->departmentName) {
            $res['departmentName'] = $this->departmentName;
        }
        if (null !== $this->punishNumber) {
            $res['punishNumber'] = $this->punishNumber;
        }
        if (null !== $this->reason) {
            $res['reason'] = $this->reason;
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
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['decisionDate'])) {
            $model->decisionDate = $map['decisionDate'];
        }
        if (isset($map['departmentName'])) {
            $model->departmentName = $map['departmentName'];
        }
        if (isset($map['punishNumber'])) {
            $model->punishNumber = $map['punishNumber'];
        }
        if (isset($map['reason'])) {
            $model->reason = $map['reason'];
        }

        return $model;
    }
}
