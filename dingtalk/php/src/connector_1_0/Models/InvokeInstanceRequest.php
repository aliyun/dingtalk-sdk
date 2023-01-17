<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\Tea\Model;

class InvokeInstanceRequest extends Model
{
    /**
     * @description 连接资产标识
     *
     * @var string
     */
    public $connectAssetUri;

    /**
     * @description 入参JSON文本
     *
     * @var string
     */
    public $inputJsonString;

    /**
     * @description 外部实例唯一标识
     *
     * @var string
     */
    public $instanceKey;
    protected $_name = [
        'connectAssetUri' => 'connectAssetUri',
        'inputJsonString' => 'inputJsonString',
        'instanceKey'     => 'instanceKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->connectAssetUri) {
            $res['connectAssetUri'] = $this->connectAssetUri;
        }
        if (null !== $this->inputJsonString) {
            $res['inputJsonString'] = $this->inputJsonString;
        }
        if (null !== $this->instanceKey) {
            $res['instanceKey'] = $this->instanceKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InvokeInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['connectAssetUri'])) {
            $model->connectAssetUri = $map['connectAssetUri'];
        }
        if (isset($map['inputJsonString'])) {
            $model->inputJsonString = $map['inputJsonString'];
        }
        if (isset($map['instanceKey'])) {
            $model->instanceKey = $map['instanceKey'];
        }

        return $model;
    }
}
