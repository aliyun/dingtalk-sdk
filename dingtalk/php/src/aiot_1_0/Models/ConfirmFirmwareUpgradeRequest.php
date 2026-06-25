<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class ConfirmFirmwareUpgradeRequest extends Model
{
    /**
     * @var string
     */
    public $moduleName;
    protected $_name = [
        'moduleName' => 'moduleName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->moduleName) {
            $res['moduleName'] = $this->moduleName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ConfirmFirmwareUpgradeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['moduleName'])) {
            $model->moduleName = $map['moduleName'];
        }

        return $model;
    }
}
