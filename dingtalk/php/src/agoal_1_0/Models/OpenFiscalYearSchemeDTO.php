<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\OpenFiscalYearSchemeDTO\subPeriodConfigs;
use AlibabaCloud\Tea\Model;

class OpenFiscalYearSchemeDTO extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $enabled;

    /**
     * @example 12起财年方案
     *
     * @var string
     */
    public $schemeName;

    /**
     * @example xxxxxxx
     *
     * @var string
     */
    public $schemeUid;

    /**
     * @example 12
     *
     * @var int
     */
    public $startMonth;

    /**
     * @var subPeriodConfigs[]
     */
    public $subPeriodConfigs;
    protected $_name = [
        'enabled' => 'enabled',
        'schemeName' => 'schemeName',
        'schemeUid' => 'schemeUid',
        'startMonth' => 'startMonth',
        'subPeriodConfigs' => 'subPeriodConfigs',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->enabled) {
            $res['enabled'] = $this->enabled;
        }
        if (null !== $this->schemeName) {
            $res['schemeName'] = $this->schemeName;
        }
        if (null !== $this->schemeUid) {
            $res['schemeUid'] = $this->schemeUid;
        }
        if (null !== $this->startMonth) {
            $res['startMonth'] = $this->startMonth;
        }
        if (null !== $this->subPeriodConfigs) {
            $res['subPeriodConfigs'] = [];
            if (null !== $this->subPeriodConfigs && \is_array($this->subPeriodConfigs)) {
                $n = 0;
                foreach ($this->subPeriodConfigs as $item) {
                    $res['subPeriodConfigs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenFiscalYearSchemeDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enabled'])) {
            $model->enabled = $map['enabled'];
        }
        if (isset($map['schemeName'])) {
            $model->schemeName = $map['schemeName'];
        }
        if (isset($map['schemeUid'])) {
            $model->schemeUid = $map['schemeUid'];
        }
        if (isset($map['startMonth'])) {
            $model->startMonth = $map['startMonth'];
        }
        if (isset($map['subPeriodConfigs'])) {
            if (!empty($map['subPeriodConfigs'])) {
                $model->subPeriodConfigs = [];
                $n = 0;
                foreach ($map['subPeriodConfigs'] as $item) {
                    $model->subPeriodConfigs[$n++] = null !== $item ? subPeriodConfigs::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
