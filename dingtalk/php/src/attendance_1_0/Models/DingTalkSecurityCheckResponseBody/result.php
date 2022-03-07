<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\DingTalkSecurityCheckResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 是否有风险
     *
     * @var bool
     */
    public $hasRisk;

    /**
     * @description 风险信息
     *
     * @var string[]
     */
    public $riskInfo;
    protected $_name = [
        'hasRisk'  => 'hasRisk',
        'riskInfo' => 'riskInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasRisk) {
            $res['hasRisk'] = $this->hasRisk;
        }
        if (null !== $this->riskInfo) {
            $res['riskInfo'] = $this->riskInfo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasRisk'])) {
            $model->hasRisk = $map['hasRisk'];
        }
        if (isset($map['riskInfo'])) {
            $model->riskInfo = $map['riskInfo'];
        }

        return $model;
    }
}
