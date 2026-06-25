<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\CheckDeviceUpdateRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string
     */
    public $currentVersion;

    /**
     * @var string
     */
    public $moduleName;
    protected $_name = [
        'currentVersion' => 'currentVersion',
        'moduleName' => 'moduleName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->currentVersion) {
            $res['currentVersion'] = $this->currentVersion;
        }
        if (null !== $this->moduleName) {
            $res['moduleName'] = $this->moduleName;
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
        if (isset($map['currentVersion'])) {
            $model->currentVersion = $map['currentVersion'];
        }
        if (isset($map['moduleName'])) {
            $model->moduleName = $map['moduleName'];
        }

        return $model;
    }
}
