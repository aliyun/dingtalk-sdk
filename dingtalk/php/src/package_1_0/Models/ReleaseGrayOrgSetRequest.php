<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ReleaseGrayOrgSetRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 5000000000000000
     *
     * @var string
     */
    public $miniAppId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $value;

    /**
     * @description This parameter is required.
     *
     * @example 0.0.1
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
     * @return ReleaseGrayOrgSetRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }
        if (isset($map['value'])) {
            if (!empty($map['value'])) {
                $model->value = $map['value'];
            }
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
