<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardRequest\openDynamicDataConfig;

use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardRequest\openDynamicDataConfig\dynamicDataSourceConfigs\pullConfig;
use AlibabaCloud\Tea\Model;

class dynamicDataSourceConfigs extends Model
{
    /**
     * @description 回调数据源的常量参数
     *
     * @var string[]
     */
    public $constParams;

    /**
     * @description 【条件必填】数据源的唯一 ID
     *
     * @var string
     */
    public $dynamicDataSourceId;

    /**
     * @description 【条件必填】数据源拉取配置
     *
     * @var pullConfig
     */
    public $pullConfig;
    protected $_name = [
        'constParams'         => 'constParams',
        'dynamicDataSourceId' => 'dynamicDataSourceId',
        'pullConfig'          => 'pullConfig',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->constParams) {
            $res['constParams'] = $this->constParams;
        }
        if (null !== $this->dynamicDataSourceId) {
            $res['dynamicDataSourceId'] = $this->dynamicDataSourceId;
        }
        if (null !== $this->pullConfig) {
            $res['pullConfig'] = null !== $this->pullConfig ? $this->pullConfig->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dynamicDataSourceConfigs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['constParams'])) {
            $model->constParams = $map['constParams'];
        }
        if (isset($map['dynamicDataSourceId'])) {
            $model->dynamicDataSourceId = $map['dynamicDataSourceId'];
        }
        if (isset($map['pullConfig'])) {
            $model->pullConfig = pullConfig::fromMap($map['pullConfig']);
        }

        return $model;
    }
}
