<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ReleaseGrayPercentSetRequest extends Model
{
    /**
     * @description 离线包ID
     *
     * @var string
     */
    public $miniAppId;

    /**
     * @description 百分比值，范围为0.0.1~100
     *
     * @var float
     */
    public $value;

    /**
     * @description 要设置的离线包版本号
     *
     * @var string
     */
    public $version;
    protected $_name = [
        'miniAppId' => 'miniAppId',
        'value'     => 'value',
        'version'   => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ReleaseGrayPercentSetRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
