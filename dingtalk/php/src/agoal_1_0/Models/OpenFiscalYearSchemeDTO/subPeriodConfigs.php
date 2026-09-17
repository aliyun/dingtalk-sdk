<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\OpenFiscalYearSchemeDTO;

use AlibabaCloud\Tea\Model;

class subPeriodConfigs extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $enabled;

    /**
     * @example 3
     *
     * @var int
     */
    public $intervalMonth;

    /**
     * @example FY_HALF_YEAR
     *
     * @var string
     */
    public $subPeriodType;
    protected $_name = [
        'enabled' => 'enabled',
        'intervalMonth' => 'intervalMonth',
        'subPeriodType' => 'subPeriodType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->enabled) {
            $res['enabled'] = $this->enabled;
        }
        if (null !== $this->intervalMonth) {
            $res['intervalMonth'] = $this->intervalMonth;
        }
        if (null !== $this->subPeriodType) {
            $res['subPeriodType'] = $this->subPeriodType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subPeriodConfigs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enabled'])) {
            $model->enabled = $map['enabled'];
        }
        if (isset($map['intervalMonth'])) {
            $model->intervalMonth = $map['intervalMonth'];
        }
        if (isset($map['subPeriodType'])) {
            $model->subPeriodType = $map['subPeriodType'];
        }

        return $model;
    }
}
