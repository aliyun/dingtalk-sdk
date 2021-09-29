<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListConnectorInformationResponseBody\pluginInfos;

use AlibabaCloud\Tea\Model;

class apps extends Model
{
    /**
     * @description appName
     *
     * @var string
     */
    public $appName;
    protected $_name = [
        'appName' => 'appName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return apps
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }

        return $model;
    }
}
