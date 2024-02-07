<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\UpgradeTemplateResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $upgradeResult;
    protected $_name = [
        'upgradeResult' => 'upgradeResult',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->upgradeResult) {
            $res['upgradeResult'] = $this->upgradeResult;
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
        if (isset($map['upgradeResult'])) {
            $model->upgradeResult = $map['upgradeResult'];
        }

        return $model;
    }
}
