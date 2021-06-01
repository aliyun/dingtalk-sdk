<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchGetGroupSetConfigResponseBody;

use AlibabaCloud\Tea\Model;

class groupSetConfigs extends Model
{
    /**
     * @description 配置项key
     *
     * @var string
     */
    public $configKey;

    /**
     * @description 配置项值
     *
     * @var string
     */
    public $configValue;
    protected $_name = [
        'configKey'   => 'configKey',
        'configValue' => 'configValue',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->configKey) {
            $res['configKey'] = $this->configKey;
        }
        if (null !== $this->configValue) {
            $res['configValue'] = $this->configValue;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupSetConfigs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['configKey'])) {
            $model->configKey = $map['configKey'];
        }
        if (isset($map['configValue'])) {
            $model->configValue = $map['configValue'];
        }

        return $model;
    }
}
