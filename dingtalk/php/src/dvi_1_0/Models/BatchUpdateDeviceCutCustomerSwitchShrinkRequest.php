<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchUpdateDeviceCutCustomerSwitchShrinkRequest extends Model
{
    /**
     * @var bool
     */
    public $enabled;

    /**
     * @var string
     */
    public $snListShrink;
    protected $_name = [
        'enabled' => 'enabled',
        'snListShrink' => 'snList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->enabled) {
            $res['enabled'] = $this->enabled;
        }
        if (null !== $this->snListShrink) {
            $res['snList'] = $this->snListShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchUpdateDeviceCutCustomerSwitchShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enabled'])) {
            $model->enabled = $map['enabled'];
        }
        if (isset($map['snList'])) {
            $model->snListShrink = $map['snList'];
        }

        return $model;
    }
}
