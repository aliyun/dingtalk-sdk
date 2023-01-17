<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardRequest;

use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardRequest\openDynamicDataConfig\dynamicDataSourceConfigs;
use AlibabaCloud\Tea\Model;

class openDynamicDataConfig extends Model
{
    /**
     * @description 动态数据源配置列表
     *
     * @var dynamicDataSourceConfigs[]
     */
    public $dynamicDataSourceConfigs;
    protected $_name = [
        'dynamicDataSourceConfigs' => 'dynamicDataSourceConfigs',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dynamicDataSourceConfigs) {
            $res['dynamicDataSourceConfigs'] = [];
            if (null !== $this->dynamicDataSourceConfigs && \is_array($this->dynamicDataSourceConfigs)) {
                $n = 0;
                foreach ($this->dynamicDataSourceConfigs as $item) {
                    $res['dynamicDataSourceConfigs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return openDynamicDataConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dynamicDataSourceConfigs'])) {
            if (!empty($map['dynamicDataSourceConfigs'])) {
                $model->dynamicDataSourceConfigs = [];
                $n                               = 0;
                foreach ($map['dynamicDataSourceConfigs'] as $item) {
                    $model->dynamicDataSourceConfigs[$n++] = null !== $item ? dynamicDataSourceConfigs::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
