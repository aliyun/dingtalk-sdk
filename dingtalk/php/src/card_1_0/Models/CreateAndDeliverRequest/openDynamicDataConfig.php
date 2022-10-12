<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest;

use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\openDynamicDataConfig\dynamicDataSourceConfigs;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\OpenDynamicDataConfigDynamicDataMappingValue;
use AlibabaCloud\Tea\Model;

class openDynamicDataConfig extends Model
{
    /**
     * @description 动态数据替换关系,key是变量名, value是数据源的jsonPath相关配置
     *
     * @var OpenDynamicDataConfigDynamicDataMappingValue[]
     */
    public $dynamicDataMapping;

    /**
     * @description 动态数据映射类型 (REPLACE_WITHOUT_MAPPING: 直接将动态数据返回，无需根据 key mapping, MAPPING_BY_KEY: 根据创建时的 key 进行 mapping)
     *
     * @var string
     */
    public $dynamicDataMappingMethod;

    /**
     * @description 动态数据源配置列表
     *
     * @var dynamicDataSourceConfigs[]
     */
    public $dynamicDataSourceConfigs;
    protected $_name = [
        'dynamicDataMapping'       => 'dynamicDataMapping',
        'dynamicDataMappingMethod' => 'dynamicDataMappingMethod',
        'dynamicDataSourceConfigs' => 'dynamicDataSourceConfigs',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dynamicDataMapping) {
            $res['dynamicDataMapping'] = [];
            if (null !== $this->dynamicDataMapping && \is_array($this->dynamicDataMapping)) {
                foreach ($this->dynamicDataMapping as $key => $val) {
                    $res['dynamicDataMapping'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }
        if (null !== $this->dynamicDataMappingMethod) {
            $res['dynamicDataMappingMethod'] = $this->dynamicDataMappingMethod;
        }
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
        if (isset($map['dynamicDataMapping'])) {
            $model->dynamicDataMapping = $map['dynamicDataMapping'];
        }
        if (isset($map['dynamicDataMappingMethod'])) {
            $model->dynamicDataMappingMethod = $map['dynamicDataMappingMethod'];
        }
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
