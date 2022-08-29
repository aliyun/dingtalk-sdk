<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\SaveProcessRequest\processFeatureConfig\features;

use AlibabaCloud\Tea\Model;

class callback extends Model
{
    /**
     * @description 网关接口标识
     *
     * @var string
     */
    public $apiKey;

    /**
     * @description 网关接口对应应用的uuid
     *
     * @var string
     */
    public $appUuid;

    /**
     * @description 网关接口版本
     *
     * @var string
     */
    public $version;
    protected $_name = [
        'apiKey'  => 'apiKey',
        'appUuid' => 'appUuid',
        'version' => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->apiKey) {
            $res['apiKey'] = $this->apiKey;
        }
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return callback
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['apiKey'])) {
            $model->apiKey = $map['apiKey'];
        }
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
