<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchUpdateDeviceCutCustomerSwitchRequest extends Model
{
    /**
     * @var bool
     */
    public $enabled;

    /**
     * @var string[]
     */
    public $snList;
    protected $_name = [
        'enabled' => 'enabled',
        'snList' => 'snList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->enabled) {
            $res['enabled'] = $this->enabled;
        }
        if (null !== $this->snList) {
            $res['snList'] = $this->snList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchUpdateDeviceCutCustomerSwitchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enabled'])) {
            $model->enabled = $map['enabled'];
        }
        if (isset($map['snList'])) {
            if (!empty($map['snList'])) {
                $model->snList = $map['snList'];
            }
        }

        return $model;
    }
}
